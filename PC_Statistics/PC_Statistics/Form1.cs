using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using System.Net;

namespace PC_Statistics
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Get_Informations(); // Get Statistics in form load
        }

        public void Get_Informations() // Get or update the statistics
        {
            TimeZone_txt.Text = TimeZone.CurrentTimeZone.StandardName; // Gets the current timezone
            UserName_txt.Text = SystemInformation.UserName; // Gets the current user name 
            cpu_txt.Text = GetProcessorName(); // Call GetProcessorName() that returns the processor name as a string 
            ComputerName_txt.Text = SystemInformation.ComputerName; // Gets Computer name
            Ram_Properties(); // Gets current ram properties
            GPU_Properties(); // Gets GPU name and properties
            Osname_txt.Text = Environment.OSVersion.VersionString; // Gets Os name 
            GetLocalIP(); // Gets the Current local ip address

        }

        private static string GetProcessorName() // This function returns the name of the Processor name as a string
        {
            var key = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0\");
            return key?.GetValue("ProcessorNameString").ToString() ?? "Not Found";
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Get_Informations(); // Refresh statistics in onClick event of Refresh_btn
        }

        public void Ram_Properties() // This function detects the statistics of ram and shows it
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                double TotalVisibleMemory = Convert.ToDouble(result["TotalVisibleMemorySize"]) / 1024 / 1024;
                double FreePhysicalMemory = Convert.ToDouble(result["FreePhysicalMemory"]) / 1024 / 1024;
                double TotalVirtualMemory = Convert.ToDouble(result["TotalVirtualMemorySize"]) / 1024 / 1024;
                double FreeVirtualMemory = Convert.ToDouble(result["FreeVirtualMemory"]) / 1024 / 1024;

                RAM_txt.Text = "Total Visible Memory: " + TotalVisibleMemory.ToString() + " GB\n" +
                    "Free Physical Memory: " + FreePhysicalMemory.ToString() + " GB\n" +
                    "Total Virtual Memory: " + TotalVirtualMemory.ToString() + " GB\n" +
                    "Free Virtual Memory: " + FreeVirtualMemory.ToString() + " GB";

             
                //Managing RAM Chart points
                chart1.Series["RAM"].Points[0].SetValueXY("Total Visible Memory", TotalVisibleMemory);
                chart1.Series["RAM"].Points[1].SetValueXY("Free Physical Memory", FreePhysicalMemory);
                chart1.Series["RAM"].Points[2].SetValueXY("Total Virtual Memory", TotalVirtualMemory);
                chart1.Series["RAM"].Points[3].SetValueXY("Free Virtual Memory", FreeVirtualMemory);
                         
            }

        }

        public void GPU_Properties() // This function detects the name of GPU
        {
            ManagementObjectSearcher searcher
            = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        GPU_txt.Text = property.Value.ToString();
                    }
                }
            }
        }
        public void GetLocalIP()
        {     
            // Get the IP
            string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            systemip_txt.Text = myIP;
        }
        
    }  
}
/*https://ourcodeworld.com/articles/read/879/how-to-retrieve-the-ram-amount-available-on-the-system-in-winforms-with-c-sharp */
