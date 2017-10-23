using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace MoecraftFramework
{

    public partial class Form1 : Form
    {
        delegate void UpdateControlText1(string str);
        protected void updateControlText(string str)
        {
            this.textBox1.Text = str;
            return;
        }
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(this.askTask));
            thread.IsBackground = true;
            thread.Start();
        }
        UDPCommunication udp = new UDPCommunication();
        MoeDllImport.PluginManager md = new MoeDllImport.PluginManager();
        bool ask = true;
        private void button1_Click(object sender, EventArgs e)
        {
            udp.sendMsg = textBox1.Text;
            udp.SendHandle();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udp.RunningFlag = false;
            ask = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = udp.receiveMsg;
        }
        private void askTask()
        {
            Thread.Sleep(300);
            while (ask)
            {
                Thread.Sleep(200);
                UpdateControlText1 update = new UpdateControlText1(updateControlText);
                try
                {
                    this.Invoke(update, udp.receiveMsg);
                }
                catch (Exception)
                {
                    //还是什么都不做了，反正这里是结束
                }

            }
        }
    }
}
