namespace Coco.choujiang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.积分不足 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.抽奖未开始 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExternalIds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPointType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.中奖回复 = new System.Windows.Forms.TextBox();
            this.numPoint = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.未中奖回复 = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChoujiang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(14, 14);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(72, 16);
            this.chkStatus.TabIndex = 0;
            this.chkStatus.Text = "抽奖开关";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "积分不足回复";
            // 
            // 积分不足
            // 
            this.积分不足.Location = new System.Drawing.Point(396, 68);
            this.积分不足.Multiline = true;
            this.积分不足.Name = "积分不足";
            this.积分不足.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.积分不足.Size = new System.Drawing.Size(184, 119);
            this.积分不足.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "抽奖结束回复（无奖品时）";
            // 
            // 抽奖未开始
            // 
            this.抽奖未开始.Location = new System.Drawing.Point(204, 68);
            this.抽奖未开始.Multiline = true;
            this.抽奖未开始.Name = "抽奖未开始";
            this.抽奖未开始.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.抽奖未开始.Size = new System.Drawing.Size(184, 119);
            this.抽奖未开始.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "允许抽奖的群号（1运行所有群）";
            // 
            // txtExternalIds
            // 
            this.txtExternalIds.Location = new System.Drawing.Point(13, 68);
            this.txtExternalIds.Multiline = true;
            this.txtExternalIds.Name = "txtExternalIds";
            this.txtExternalIds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExternalIds.Size = new System.Drawing.Size(184, 119);
            this.txtExternalIds.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(755, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "奖品，一行一个，按顺序发放，打开本页面设置时会临时关闭抽奖，#表示不中奖，其它为中奖:1、在下面填写奖品 2、插入空白 3、打乱顺序";
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(13, 268);
            this.txtItems.Multiline = true;
            this.txtItems.Name = "txtItems";
            this.txtItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItems.Size = new System.Drawing.Size(958, 316);
            this.txtItems.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "抽奖消耗积分：";
            // 
            // cmbPointType
            // 
            this.cmbPointType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPointType.FormattingEnabled = true;
            this.cmbPointType.Location = new System.Drawing.Point(580, 12);
            this.cmbPointType.Name = "cmbPointType";
            this.cmbPointType.Size = new System.Drawing.Size(121, 20);
            this.cmbPointType.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "中奖回复";
            // 
            // 中奖回复
            // 
            this.中奖回复.Location = new System.Drawing.Point(594, 68);
            this.中奖回复.Multiline = true;
            this.中奖回复.Name = "中奖回复";
            this.中奖回复.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.中奖回复.Size = new System.Drawing.Size(184, 119);
            this.中奖回复.TabIndex = 2;
            // 
            // numPoint
            // 
            this.numPoint.Location = new System.Drawing.Point(487, 12);
            this.numPoint.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPoint.Name = "numPoint";
            this.numPoint.Size = new System.Drawing.Size(87, 21);
            this.numPoint.TabIndex = 4;
            this.numPoint.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(785, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "未中奖回复";
            // 
            // 未中奖回复
            // 
            this.未中奖回复.Location = new System.Drawing.Point(787, 68);
            this.未中奖回复.Multiline = true;
            this.未中奖回复.Name = "未中奖回复";
            this.未中奖回复.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.未中奖回复.Size = new System.Drawing.Size(184, 119);
            this.未中奖回复.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(330, 230);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "打乱顺序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(164, 230);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(49, 231);
            this.numCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(58, 21);
            this.numCount.TabIndex = 4;
            this.numCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "插入";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "个空白";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "过滤空白";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "抽奖指令";
            // 
            // txtChoujiang
            // 
            this.txtChoujiang.Location = new System.Drawing.Point(166, 9);
            this.txtChoujiang.Name = "txtChoujiang";
            this.txtChoujiang.Size = new System.Drawing.Size(100, 21);
            this.txtChoujiang.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 594);
            this.Controls.Add(this.txtChoujiang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.numPoint);
            this.Controls.Add(this.cmbPointType);
            this.Controls.Add(this.抽奖未开始);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.未中奖回复);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.中奖回复);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExternalIds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.积分不足);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkStatus);
            this.Name = "Form1";
            this.Text = "抽奖";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 积分不足;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 抽奖未开始;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExternalIds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPointType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox 中奖回复;
        private System.Windows.Forms.NumericUpDown numPoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 未中奖回复;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChoujiang;
    }
}