using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace haopintui
{
    /// <summary>
    /// 拥有ToolTip属性的Form基类
    /// </summary>
    public class BaseForm : Form
    {
        private ToolTip _toolTip;

        public BaseForm()
            : base()
        {
            _toolTip = new ToolTip();
        }

        internal ToolTip ToolTip
        {
            get { return _toolTip; }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                _toolTip.Dispose();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);

        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
