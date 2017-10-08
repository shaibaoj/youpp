using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace haopintui
{
    public partial class ShowQqForm : Form
    {
        CmsForm cmsForm;
        public ShowQqForm(CmsForm cmsForm)
        {
            InitializeComponent();
            this.cmsForm = cmsForm;
            this.show_qun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.show_qun();
        }

        private void show_qun()
        {
            try
            {
                //ArrayList qqList = ProcessesUtil.getWindows(this.cmsForm, "ChatBox_PreviewWnd");
                ArrayList qqList = ProcessesUtil.getWindows(this.cmsForm, "TXGuiFoundation");
                this.dataGridView1.Rows.Clear();
                //this.load_qq_qun_shunxu();
                int num = 0;
                foreach (string arrayList4 in qqList)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    this.dataGridView1.Rows.Add(dataGridViewRow);
                    this.dataGridView1.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                    this.dataGridView1[0, num].Value = arrayList4;
                    //this.dataGridView_qunfa_weixin_list[1, num].Value = "  ↑↓";
                    num++;
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this.cmsForm, string.Concat("[loadWeixinList]出错：", exception.ToString()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.ColumnIndex;
            //SendItem tag = (SendItem)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
            cmsForm.textBox_fenqun_qq_name.Text = (string)this.dataGridView1[0, e.RowIndex].Value;
            this.Close();
        }
    }
}
