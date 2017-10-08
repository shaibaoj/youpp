using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

public static class ProcessorUtil
{
    public static bool smethod_0(string string_0)
    {
        Form2 form;
        string str = "";
        str = smethod_3() + smethod_4();
        CryptUtil.encrypt(str);
        if (!File.Exists(string_0 + "/支付宝采集.key"))
        {
            Clipboard.SetDataObject(str);
            form = new Form2();
            form.textBoxMashine.Text = str;
            form.textBoxKey.Text = "没有KEY文件！";
            form.ShowDialog();
            return false;
        }
        string str2 = new StreamReader(string_0 + "/支付宝采集.key").ReadToEnd();
        string str3 = CryptUtil.decrypt(str2);
        if (!str3.Equals(str))
        {
            Clipboard.SetDataObject(str);
            form = new Form2();
            form.textBoxMashine.Text = str;
            form.textBoxKey.Text = str + "***" + str2 + "***" + str3;
            form.ShowDialog();
            return false;
        }
        return true;
    }

    public static string smethod_1()
    {
        return (smethod_3() + smethod_4());
    }

    public static string smethod_2()
    {
        try
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Processor");
            string str = "";
            foreach (ManagementObject obj2 in searcher.Get())
            {
                str = obj2["ProcessorId"].ToString().Trim();
            }
            return str;
        }
        catch
        {
            return "";
        }
    }

    public static string smethod_3()
    {
        try
        {
            string str = "";
            ManagementClass class2 = new ManagementClass("Win32_Processor");
            foreach (ManagementObject obj2 in class2.GetInstances())
            {
                str = obj2.Properties["ProcessorId"].Value.ToString();
            }
            return str.ToString();
        }
        catch
        {
            return "";
        }
    }

    public static string smethod_4()
    {
        try
        {
            string str = "";
            ManagementClass class2 = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj2 in class2.GetInstances())
            {
                if ((bool) obj2["IPEnabled"])
                {
                    str = obj2["MacAddress"].ToString();
                }
                obj2.Dispose();
            }
            return str;
        }
        catch
        {
            return "";
        }
    }
}

