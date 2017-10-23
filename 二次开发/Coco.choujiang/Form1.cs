using Coco.Framework.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coco.choujiang
{
    public partial class Form1 : Form
    {
        ChoujiangPlugin class1;
        public Form1(ChoujiangPlugin class1)
        {
            this.class1 = class1;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chkStatus.Checked = class1.config.Status;
            this.numPoint.Value = class1.config.Point;
            class1.Config.ExtcreditsType.ForEach(t => cmbPointType.Items.Add(t));
            if (class1.config.PointType < cmbPointType.Items.Count)
                cmbPointType.SelectedIndex = class1.config.PointType;
            else
                cmbPointType.SelectedIndex = 0;

            this.txtChoujiang.Text = class1.config.抽奖指令;
            this.抽奖未开始.Text = class1.config.抽奖结束;
            this.积分不足.Text = class1.config.积分不足;
            this.中奖回复.Text = class1.config.中奖回复;
            this.未中奖回复.Text = class1.config.未中奖回复;

            this.txtExternalIds.Text = string.Join("\r\n", class1.config.ExternalIds);
            this.txtItems.Text = string.Join("\r\n", class1.config.Items);

            class1.config.Status = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            class1.config.Status = this.chkStatus.Checked;
            class1.config.Point = (long)this.numPoint.Value;
            class1.config.PointType = cmbPointType.SelectedIndex;

            class1.config.抽奖指令 = this.txtChoujiang.Text.Trim();
            class1.config.抽奖结束 = this.抽奖未开始.Text;
            class1.config.积分不足 = this.积分不足.Text;
            class1.config.中奖回复 = this.中奖回复.Text;
            class1.config.未中奖回复 = this.未中奖回复.Text;

            class1.config.ExternalIds = Util.ToUintList(this.txtExternalIds.Text);
            class1.config.Items = this.txtItems.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            class1.config.Save();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string txt = txtItems.Text.Trim();

            StringBuilder sb = new StringBuilder(txt);
            sb.AppendLine();

            for (int i = 0; i < numCount.Value; i++)
            {
                sb.AppendLine("#");
            }

            txtItems.Text = sb.ToString().Trim();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var item = txtItems.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            var rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                item = (from a in item orderby rnd.Next() descending select a).ToList();
            }

            txtItems.Text = string.Join("\r\n", item).Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = txtItems.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            item.RemoveAll(t => t == "#");
            txtItems.Text = string.Join("\r\n", item).Trim();
        }
    }
}
