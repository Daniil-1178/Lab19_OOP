using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace Lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            lstHardwareInfo.Items.Clear();

            OutputResult("ПРОЦЕСОР:", GetHardwareInfo("Win32_Processor", "Name"));
            OutputResult("Виробник:", GetHardwareInfo("Win32_Processor", "Manufacturer"));
            OutputResult("Опис:", GetHardwareInfo("Win32_Processor", "Description"));

            OutputResult("ВІДЕОКАРТА:", GetHardwareInfo("Win32_VideoController", "Name"));
            OutputResult("Відеопроцесор:", GetHardwareInfo("Win32_VideoController", "VideoProcessor"));
            OutputResult("Версія драйверу:", GetHardwareInfo("Win32_VideoController", "DriverVersion"));
            OutputResult("Об'єм пам'яті (байт):", GetHardwareInfo("Win32_VideoController", "AdapterRAM"));

            OutputResult("ЖОРСТКИЙ ДИСК:", GetHardwareInfo("Win32_DiskDrive", "Caption"));
            OutputResult("Об'єм диска (байт):", GetHardwareInfo("Win32_DiskDrive", "Size"));

            OutputResult("МАТЕРИНСЬКА ПЛАТА:", GetHardwareInfo("Win32_BaseBoard", "Product"));
            OutputResult("Виробник плати:", GetHardwareInfo("Win32_BaseBoard", "Manufacturer"));
            OutputResult("Серійний номер плати:", GetHardwareInfo("Win32_BaseBoard", "SerialNumber"));

            OutputResult("СИСТЕМА BIOS:", GetHardwareInfo("Win32_BIOS", "Caption"));
            OutputResult("Виробник BIOS:", GetHardwareInfo("Win32_BIOS", "Manufacturer"));
            OutputResult("Версія BIOS:", GetHardwareInfo("Win32_BIOS", "Version"));

            OutputResult("МЕРЕЖЕВЕ ОБЛАДНАННЯ:", GetHardwareInfo("Win32_NetworkAdapter", "Name"));
            OutputResult("Тип адаптера:", GetHardwareInfo("Win32_NetworkAdapter", "AdapterType"));
            OutputResult("MAC-адреса:", GetHardwareInfo("Win32_NetworkAdapter", "MACAddress"));
        }

        private List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            foreach (ManagementObject obj in searcher.Get())
            {
                if (obj[ClassItemField] != null)
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }

            return result;
        }

        private void OutputResult(string info, List<string> result)
        {
            if (result.Count > 0)
            {
                if (info.StartsWith("---"))
                {
                    lstHardwareInfo.Items.Add("");
                    lstHardwareInfo.Items.Add(info);
                }
                else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        lstHardwareInfo.Items.Add(info + " " + result[i]);
                    }
                }
            }
        }
    }
}