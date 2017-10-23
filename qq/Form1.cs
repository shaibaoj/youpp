using Coco.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qq
{
    public partial class Form1 : Form
    {
        Class1 class1 = null;

        public Form1(Class1 class1)
        {
            this.class1 = class1;
            InitializeComponent();
            this.init_();
        }

        public void init_() {

            try
            {
                //this.appBean.weixin_list = weixinList;
                this.dataGridView1.Rows.Clear();
                //this.load_qq_qun_shunxu();
                int num = 0;
                foreach (Cluster arrayList4 in class1.User.Clusters)
                {
                    //MessageBox.Show(arrayList4.UserName.ToString());
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    this.dataGridView1.Rows.Add(dataGridViewRow);
                    //this.dataGridView_weixin_qun_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                    this.dataGridView1[0, num].Value = true;
                    this.dataGridView1[1, num].Value = arrayList4.Name;
                    this.dataGridView1[1, num].Tag = arrayList4;
                    num++;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                //LogUtil.log_call(this, string.Concat("[loadWeixinList]出错：", exception.ToString()));
            }

        }
    }

    public delegate void log(Form1 cmsForm, String content);

}
