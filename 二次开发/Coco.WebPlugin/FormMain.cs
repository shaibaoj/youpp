using Coco.Framework.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coco.WebPlugin
{
    partial class FormMain : Form
    {
        WebConfig config = null;
        public FormMain(WebConfig config)
        {
            this.config = config;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.Url = txtUrl.Text.Trim();
            config.Encode = cmbEncode.Text;
            config.Key = txtKey.Text;
            config.Sleep = (int)numericUpDown1.Value;
            config.Port = (int)numericUpDown2.Value;
            config.Cancel = chkCancel.Checked;
            config.CustomData = txtCustomData.Text;
            config.Save();
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtUrl.Text = config.Url;
            cmbEncode.Text = config.Encode;
            txtKey.Text = config.Key;
            numericUpDown1.Value = config.Sleep;
            numericUpDown2.Value = config.Port;
            chkCancel.Checked = config.Cancel;
            txtCustomData.Text = config.CustomData;
        }
    }
}
