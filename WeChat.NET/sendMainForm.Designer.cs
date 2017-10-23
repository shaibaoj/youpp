namespace WeChat.NET
{
    partial class sendMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendMainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCms = new System.Windows.Forms.RichTextBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.dataGridView_weixin_qun_list = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_weixin_qun_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox24);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "群发管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 429);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBoxCms);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 429);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "执行状况";
            // 
            // richTextBoxCms
            // 
            this.richTextBoxCms.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCms.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxCms.Location = new System.Drawing.Point(3, 21);
            this.richTextBoxCms.Name = "richTextBoxCms";
            this.richTextBoxCms.Size = new System.Drawing.Size(364, 405);
            this.richTextBoxCms.TabIndex = 0;
            this.richTextBoxCms.Text = "";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.dataGridView_weixin_qun_list);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox24.Location = new System.Drawing.Point(3, 3);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(200, 429);
            this.groupBox24.TabIndex = 5;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "微信发送群设置";
            // 
            // dataGridView_weixin_qun_list
            // 
            this.dataGridView_weixin_qun_list.AllowUserToAddRows = false;
            this.dataGridView_weixin_qun_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_weixin_qun_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_weixin_qun_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.Column4});
            this.dataGridView_weixin_qun_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_weixin_qun_list.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_weixin_qun_list.Name = "dataGridView_weixin_qun_list";
            this.dataGridView_weixin_qun_list.RowHeadersVisible = false;
            this.dataGridView_weixin_qun_list.RowTemplate.Height = 23;
            this.dataGridView_weixin_qun_list.Size = new System.Drawing.Size(194, 409);
            this.dataGridView_weixin_qun_list.TabIndex = 0;
            this.dataGridView_weixin_qun_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_weixin_qun_list_CellClick);
            // 
            // select
            // 
            this.select.FillWeight = 48.46814F;
            this.select.HeaderText = "选择";
            this.select.Name = "select";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 202.8009F;
            this.Column4.HeaderText = "群名称";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "提醒：微信群先加通讯录";
            // 
            // sendMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sendMainForm";
            this.Text = "好品推微信群发";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sendMainForm_FormClosing);
            this.Load += new System.EventHandler(this.sendMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_weixin_qun_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.DataGridView dataGridView_weixin_qun_list;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RichTextBox richTextBoxCms;
        private System.Windows.Forms.Label label1;

    }
}