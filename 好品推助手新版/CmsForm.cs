using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using com.haopintui.util;
using System.Net;
using com.haopintui;
using haopintui;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using mshtml;
using haopintui.util;
using haopintui.entity;
using haopintui.weixin;
using System.Runtime.CompilerServices;
using System.Net.Sockets;

namespace haopintui
{
    public class CmsForm : BaseForm
    {
        #region Field

        //窗体圆角矩形半径
        private int _radius = 5;

        //是否允许窗体改变大小
        private bool _canResize = true;

        private Image _fringe = Image.FromFile(@".\Res\fringe_bkg.png");
        //private Image _formBkg = Image.FromFile(@".\Res\FormBkg\bkg_flower.jpg");
        private Image _formBkg = null;
        public RichTextBox richTextBoxLogs;
        private FlowLayoutPanel layout_menu;
        private Panel panelTop;
        private Label tool_name;
        private Label label1;
        private Label label_version;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label_cms;
        private Label label_qunfa;
        private Label label_tools;
        private Label label_setting;
        private Panel panel_content;
        public TabControl tabControlMain;
        private TabPage tabPage1;
        private Panel panel_cms;
        private GroupBox groupBox1;
        public RichTextBox richTextBoxCms;
        private GroupBox groupBox_cms;
        public Button button_cms_click_apply;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        public ComboBox comboBoxCmsList;
        public ComboBox comboBoxCmPPos;
        public ComboBox comboBoxCmPUnit;
        private RadioButton radioButtonCmMOth;
        private RadioButton radioButtonCmMApp;
        private RadioButton radioButtonCmMWeb;
        private TrackBar trackBarAlimama;
        private Panel panel2;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private GroupBox groupBox_alimama;
        public TextBox textBoxAlimamaAcc;
        private Label label13;
        public TextBox textBoxAlimamaPwd;
        private Label label12;
        private Button buttonLoginAlimama2;
        public CheckBox checkBoxAutoLogin;
        private GroupBox groupBox_dama;
        public TextBox textBoxUUPwd;
        private Label label15;
        public TextBox textBoxUUUsername;
        private Label label14;
        private Button buttonUUWiseLogin;
        private Button buttonOpenUUHP;
        private Button buttonTestCode;
        private PictureBox pictureBoxTest;
        private TabControl tabControl_qunfa;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Panel panel3;
        private Button button_qunfa_fa;
        private Button button_qunfa_setting;
        private Panel panel4;
        private GroupBox groupBox2;
        public Button buttonFollowSndStart;
        public Button button_qunfa_start;
        public CheckBox checkBox_haopintui;
        public CheckBox checkBox_gengfa_qq;
        private Label label16;
        public TextBox textBox_qunfa_times;
        private TabControl tabControl_qunfa_config;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        public DataGridView dataGridViewFollowSnd;
        private GroupBox groupBox3;
        private Panel panel5;
        private Button button_qunfa_qq_shuaxin;
        private Button button_qunfa_open_mulu;
        private Button button_qunfa_open_qun;
        private DataGridView dataGridView_qunfa_qq_list;
        private GroupBox groupBox5;
        private LinkLabel linkLabel_get_qq_guanggao;
        private Label label18;
        private Label label17;
        public ComboBox comboBox_qq_tongyong_weizhi;
        public ComboBox comboBox_qq_tongyong_danyuan;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton_qq_tongyong;
        private GroupBox groupBox6;
        private LinkLabel linkLabel_get_qq_guangg_queqiao;
        private Label label19;
        private Label label20;
        public ComboBox comboBox_qq_queqiao_weizhi;
        public ComboBox comboBox_qq_queqiao_danyuan;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private GroupBox groupBox8;
        private LinkLabel linkLabel_get_weixin_guanggao;
        private Label label23;
        private Label label24;
        public ComboBox comboBox_weixin_tongyong_weizhi;
        public ComboBox comboBox_weixin_tongyong_danyuan;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private GroupBox groupBox7;
        private Label label21;
        public TextBox textBox_qunfa_apply_content;
        public CheckBox checkBox_qunfa_erheyi;
        private Button button_save_config_qunfa;
        private GroupBox groupBox9;
        private Label label25;
        public TextBox textBox_qunfa_qq_peizhi_qiehuan_times;
        private Label label22;
        public CheckBox checkBox_qunfa_qq_guanbi;
        private Label label29;
        private Label label27;
        public TextBox textBox_qunfa_qq_peizhi_fasong_times;
        public TextBox textBox_qunfa_qq_peizhi_zhantietimes;
        private Label label28;
        private Label label26;
        public CheckBox checkBox_qunfa_qq_str_times;
        public CheckBox checkBox_qunfa_qq_str_suiji;
        public CheckBox checkBox_qunfa_qq_zuixiaohua;
        public RadioButton radioButton_qunfa_qq_enter;
        public RadioButton radioButton_qunfa_qq_enter_ctrl;
        private GroupBox groupBox10;
        private Label label32;
        public TextBox textBox_qunfa_wieba_content;
        private DataGridViewTextBoxColumn Column_qqname;
        private DataGridViewTextBoxColumn Column1;
        private Label label33;
        public TextBox textBox_qunfa_coupon;
        private Label label34;
        private Label label38;
        private Label label36;
        private Label label37;
        public TextBox textBox_qunfa_times_jiange;
        private Label label35;
        public TextBox textBox_qunfa_commission;
        public CheckBox checkBox_qunfa_pid;
        public CheckBox checkBox_qunfa_link;
        private Button buttonSaveConfig;
        private TabPage tabPage10;
        private GroupBox groupBox11;
        private GroupBox groupBox12;
        private Button button_qunfa_shoudong_qingkong;
        private Button button_qunfa_shoudong_fasong;
        private Button button_qunfa_shoudong_gengfa;
        public WebBrowser webBrowser_send_content;
        private Panel panel6;
        private Button button_tools_bt_changgui;
        private TabControl tabControl_tools;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabControl tabControl_tools_common;
        private TabPage tabPage13;
        private GroupBox groupBox13;
        public WebBrowser webBrowser_zhuanhua;
        private GroupBox groupBox14;
        public CheckBox checkBox_tools_qingkong;
        public CheckBox checkBox_tools_piliang;
        private Button button_tools_zhuanhua_tianjia_zhushou;
        private Button button_tools_zhuanhua_copy;
        private Button button_tools_qingkong;
        private Label label39;
        public TextBox textBoxAppCmsReson;
        private NotifyIcon notifyIcon_task;
        private IContainer components;
        private ContextMenuStrip contextMenuStripTask;
        private ToolStripMenuItem toolStripMenuItem1;

        //系统按钮管理器
        private SystemButtonManager _systemButtonManager;
        public UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
        public IContainer icontainer = null;
        public string app_path = Application.StartupPath;

        public AppBean appBean = null;
        public LoginUtil loginUtil = null;
        public AdzoneBean adzoneBean = null;

        public WebClient webClient = new WebClient();
        private LinkLabel linkLabelGetPromot;
        public WebBrowser webBrowserQuanAlimama;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TabPage tabPage14;
        public TextBox textBoxAlimamaCookieUrl;
        private Button button_tools_test_get_cookie;
        private GroupBox groupBox16;
        public Label label_tongji_all;
        public Label label_tongji_have;
        public HttpService httpService = null;
        public char[] char_message = new char[0x1388];
        private System.Windows.Forms.Timer timer_kouling;
        private GroupBox groupBox17;
        private Label label8;
        public TextBox textBox_setting_appKey;
        private Label label9;
        public TextBox textBox_setting_appId;
        private LinkLabel linkLabel3;
        private ContextMenuStrip contextMenuStripCouponPage;
        private Label label_banben;
        private Label label_welcome;
        private int char_message_int = 0;
        private ContextMenuStrip contextMenuStripFwSnd;
        public CheckBox checkBox_qunfa_weixin_boolean;
        public CheckBox checkBox_qunfa_qq_boolean;
        private ContextMenuStrip contextMenuStripCtEdit;

        private Thread thread_gengfa;
        private Thread thread_gengfa_top;
        private Thread thread_send;
        private Thread thread_gengfa_qq;

        public Thread thread_cms;
        public Thread thread_cms_tongji;
        public Thread thread_cms_user;
        public Thread thread_cms_user_KeepAlive;
        public Thread thread_cms_user_Receive;
        public Thread thread_cms_user_submit_taokeitem;

        public Socket clientSocket;

        public Thread thread_cms_alimama_login;

        public Thread thread_user_info;

        public Thread thread_order_ali;

        public Thread thread_coupon;

        private DataGridViewTextBoxColumn Column_time;
        private DataGridViewTextBoxColumn Column_from;
        private DataGridViewTextBoxColumn Column_content;
        private DataGridViewTextBoxColumn Column_status;
        public RadioButton radioButtonsetting_app_haopintui;
        public RadioButton radioButtonsetting_app_ben;
        private Label label10;
        private Label label11;
        private ContextMenuStrip contextMenuStripTool;
        private TabPage tabPage15;
        public CheckBox checkBox_qunfa_weibo_boolean;
        private GroupBox groupBox19;
        public DataGridView dataGridView_weibo;
        private Button button1;
        public CheckBox checkBox_qunfa_qq_kouling_boolean;
        public SendSqlUtil sendSqlUtil;
        private Button button_qunfa_template;
        private TabPage tabPage16;
        private GroupBox groupBox20;
        public TextBox textBox_qq_template;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button8;
        private Button button10;
        private Button button11;
        private Button button12;
        private GroupBox groupBox21;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        public TextBox textBox_weixin_template;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private LinkLabel linkLabel6;
        private System.Windows.Forms.Timer timer_caiji;

        public Thread thread_online;

        private Panel panel8;
        private TabControl tabControl1;
        private TabPage tabPage17;
        private GroupBox groupBox15;
        private Label label31;
        public TextBox textBox_qunfa_weixin_fatu_times;
        private Label label30;
        private GroupBox groupBox4;
        public DataGridView dataGridView_qunfa_weixin_list;
        private DataGridViewTextBoxColumn Column2;
        private Button button_qunfa_weixin_huoqu;
        private TabPage tabPage18;
        private Panel panel7;
        private GroupBox groupBox22;
        public RadioButton radioButton_fasong_weixin_fashi_houtai;
        public RadioButton radioButton_fasong_weixin_fashi_qiantai;
        private GroupBox groupBox25;
        private Button button28;
        private Button button29;
        public Button button_bind;
        public string online_version;
        private GroupBox groupBox24;
        private TabPage tabPage19;
        private TabControl tabControl2;
        private TabPage tabPage20;
        private Panel panel9;
        private GroupBox groupBox23;
        private Label label41;
        public TextBox textBox_qun_guolv;
        private GroupBox groupBox26;
        private TabPage tabPage21;
        private GroupBox groupBox27;
        public RichTextBox richTextBox_qq_log;
        private Label label42;
        public TextBox textBox_qun_del;

        private Thread thread_weixin_houtai;

        public char[] char_message_qq = new char[0x1388];
        public TextBox textBox_qun_list;
        private GroupBox groupBox28;
        private Label label43;
        private Label label44;
        private TextBox textBox_weibo_pwd;
        private TextBox textBox_weibo_name;
        private Button button_weibo;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn status;
        private ContextMenuStrip contextMenuStrip_weibo;
        private LinkLabel linkLabel9;
        private LinkLabel linkLabel8;
        private int char_message_int_qq = 0;
        private GroupBox groupBox29;
        public CheckBox checkBox_qunfa_duanlian;
        public RadioButton radioButton_qunfa_duanlian_hpt;

        private Thread thread_alimama_income;
        private TabPage tabPage22;
        public CheckBox checkBox_cmslist_jihua;
        private Label label51;
        private GroupBox groupBox32;
        private LinkLabel linkLabel_get_weibo_guanggao;
        private Label label52;
        private Label label53;
        public ComboBox comboBox_weibo_tongyong_weizhi;
        public ComboBox comboBox_weibo_tongyong_danyuan;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TabControl tabControl3;
        private TabPage tabPage23;
        private GroupBox groupBox30;
        public TextBox textBox_fenqun_qq_weiba;
        private Label label49;
        private Button button2;
        public DataGridView dataGridView_fenqun_qq;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        public TextBox textBox_fenqun_qq_pid;
        public TextBox textBox_fenqun_qq_name;
        private Label label46;
        private Label label45;
        private TabPage tabPage24;
        private GroupBox groupBox31;
        public TextBox textBox_fenqun_weixin_weiba;
        private Label label50;
        private Button button30;
        public DataGridView dataGridView_fenqun_weixin;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public TextBox textBox_fenqun_weixin_pid;
        public TextBox textBox_fenqun_weixin_name;
        private Label label47;
        private Label label48;
        private GroupBox groupBox33;
        private Label label54;
        private Label label55;
        private Label label56;
        public CheckBox checkBox1;
        public CheckBox checkBox2;
        private Label label57;
        private Button button31;
        private Button button32;
        private ContextMenuStrip contextMenuStrip_pid_qq;
        private ContextMenuStrip contextMenuStrip_pid_weixin;
        public CheckBox checkBox_qunfa_top;
        private Label label58;
        public ComboBox comboBox_cj_pinlv;
        private Label label59;
        private Label label60;
        private Label label62;
        public ComboBox comboBox_qunfa_ds_f1;
        private Label label61;
        public ComboBox comboBox_qunfa_ds_s1;
        private Label label63;
        private Label label65;
        public ComboBox comboBox_qunfa_ds_f2;
        private Label label64;
        public ComboBox comboBox_qunfa_ds_s2;
        private GroupBox groupBox18;
        private LinkLabel linkLabel7;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button41;
        private Button button42;
        private Button button43;
        private Button button44;
        private Button button45;
        public TextBox textBox_weibo_template;
        private Label label_user_type_name;
        private Label label66;
        private Label label67;
        public CheckBox checkBox_cmslist_xianshi;
        private TabPage tabPage25;
        private GroupBox groupBox34;
        private Label label68;
        public ComboBox comboBox_ali_order_pinlv;
        private Label label69;
        private Button button46;
        public CheckBox checkBoxScanLogin;
        public CheckBox checkBox3;
        private Label label70;
        private Label label71;
        public ComboBox comboBox_ali_order_days;
        private LinkLabel linkLabel10;
        private Label label40;
        public TextBox textBox_price2;
        public TextBox textBox_price1;
        private Label label72;
        private Button button47;
        private Button button48;

        private Thread thread_zhuan_copy;

        #endregion

        #region Constructor

        public CmsForm()
        {
            ProcessesUtil.check_Process();
            ProcessesUtil.kill_all();
            AutoUpdateUtil.call_update(this.app_path);
            this.httpService = new HttpService();
            this.appBean = new AppBean();
            this.appBean.follow_path = this.app_path + @"\config\临时文件夹\follow";
            this.appBean.qqquan_shunxun_path = string.Concat(this.app_path, "\\config\\QQ群顺序.txt");
            this.appBean.weixin_path = string.Concat(this.app_path, "\\config\\weixin.txt");

            this.loginUtil = new LoginUtil();
            this.loginUtil.visits = 0;
            this.loginUtil.login_url = Constants.login_url;
            if (!this.loginUtil.login(Constants.product_code, Constants.main_exe, Constants.version + ""))
            {
                Environment.Exit(Environment.ExitCode);
            }
            this.appBean.user_id = loginUtil.user_id;
            this.appBean.user_name = loginUtil.user_name;
            this.appBean.user_key = loginUtil.user_key;
            this.appBean.qunfa = loginUtil.qunfa;
            this.appBean.alimama_id = loginUtil.alimama_id;
            this.appBean.user_type_name = loginUtil.user_type_name;
            this.appBean.qunfa_date = loginUtil.qunfa_date;
            this.sendSqlUtil = new SendSqlUtil();
            string out_log;
            this.sendSqlUtil.delete_send_item(240, out out_log);
            this.sendSqlUtil.delete_cms_item_plan(24, out out_log);
            InitializeComponent();
            FormExIni();
            _systemButtonManager = new SystemButtonManager(this);
            init_();

            //WeixinUtil.sendForm(this,"啥东西啊啊  ");
        }

        #endregion

        #region Properties

        [DefaultValue(typeof(byte), "5")]
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    this.Invalidate();
                }
            }
        }

        public bool CanResize
        {
            get
            {
                return _canResize;
            }
            set
            {
                if (_canResize != value)
                {
                    _canResize = value;
                }
            }
        }

        public override Image BackgroundImage
        {
            get
            {
                return _formBkg;
            }
            set
            {
                if (_formBkg != value)
                {
                    _formBkg = value;
                    Invalidate();
                }
            }
        }

        internal Rectangle IconRect
        {
            get
            {
                if (base.ShowIcon && base.Icon != null)
                {
                    return new Rectangle(8, 6, SystemInformation.SmallIconSize.Width, SystemInformation.SmallIconSize.Width);
                }
                return Rectangle.Empty;
            }
        }

        internal Rectangle TextRect
        {
            get
            {
                if (base.Text.Length != 0)
                {
                    return new Rectangle(IconRect.Right + 2, 4, Width - (8 + IconRect.Width + 2), Font.Height);
                }
                return Rectangle.Empty;
            }
        }

        internal SystemButtonManager SystemButtonManager
        {
            get
            {
                if (_systemButtonManager == null)
                {
                    _systemButtonManager = new SystemButtonManager(this);
                }
                return _systemButtonManager;
            }
        }

        #endregion

        #region Overrides

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!DesignMode)
                {
                    if (MaximizeBox) { cp.Style |= (int)WindowStyle.WS_MAXIMIZEBOX; }
                    if (MinimizeBox) { cp.Style |= (int)WindowStyle.WS_MINIMIZEBOX; }
                    //cp.ExStyle |= (int)WindowStyle.WS_CLIPCHILDREN;  //防止因窗体控件太多出现闪烁
                    cp.ClassStyle |= (int)ClassStyle.CS_DropSHADOW;  //实现窗体边框阴影效果
                }
                return cp;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            RenderHelper.SetFormRoundRectRgn(this, Radius);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RenderHelper.SetFormRoundRectRgn(this, Radius);
            UpdateSystemButtonRect();
            UpdateMaxButton();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_ERASEBKGND:
                    m.Result = IntPtr.Zero;
                    break;
                case Win32.WM_NCHITTEST:
                    WmNcHitTest(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            SystemButtonManager.ProcessMouseOperate(e.Location, MouseOperate.Move);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                SystemButtonManager.ProcessMouseOperate(e.Location, MouseOperate.Down);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                SystemButtonManager.ProcessMouseOperate(e.Location, MouseOperate.Up);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SystemButtonManager.ProcessMouseOperate(Point.Empty, MouseOperate.Leave);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //draw BackgroundImage
            e.Graphics.DrawImage(_formBkg, ClientRectangle, new Rectangle(0, 0, _formBkg.Width, _formBkg.Height), GraphicsUnit.Pixel);

            //draw form main part
            RenderHelper.DrawFromAlphaMainPart(this, e.Graphics);

            //draw system buttons
            //SystemButtonManager.DrawSystemButtons(e.Graphics);
            //SystemButtonManager.DrawSystemButtons(this.panelTop.CreateGraphics());

            //draw fringe
            RenderHelper.DrawFormFringe(this, e.Graphics, _fringe, Radius);

            //draw icon
            if (Icon != null && ShowIcon)
            {
                e.Graphics.DrawIcon(Icon, IconRect);
            }

            //draw text
            if (Text.Length != 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    Text, Font,
                    TextRect,
                    Color.White,
                    TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis);
            }

            //e.Graphics.DrawRectangle(Pens.DarkOliveGreen, 0, 0, this.Width - 1, this.Height - 1);

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                if (_systemButtonManager != null)
                {
                    _systemButtonManager.Dispose();
                    _systemButtonManager = null;
                    //_formBkg.Dispose();
                    _formBkg = null;
                    //_fringe.Dispose();
                    _fringe = null;
                }
            }
        }

        #endregion

        #region Private Methods

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmsForm));
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.layout_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_setting = new System.Windows.Forms.Label();
            this.label_tools = new System.Windows.Forms.Label();
            this.label_qunfa = new System.Windows.Forms.Label();
            this.label_cms = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button_bind = new System.Windows.Forms.Button();
            this.label_user_type_name = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_banben = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.webBrowserQuanAlimama = new System.Windows.Forms.WebBrowser();
            this.contextMenuStripCouponPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tool_name = new System.Windows.Forms.Label();
            this.panel_content = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_cms = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCms = new System.Windows.Forms.RichTextBox();
            this.groupBox_cms = new System.Windows.Forms.GroupBox();
            this.checkBox_cmslist_xianshi = new System.Windows.Forms.CheckBox();
            this.checkBox_cmslist_jihua = new System.Windows.Forms.CheckBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabelGetPromot = new System.Windows.Forms.LinkLabel();
            this.textBoxAppCmsReson = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.button_cms_click_apply = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCmsList = new System.Windows.Forms.ComboBox();
            this.comboBoxCmPPos = new System.Windows.Forms.ComboBox();
            this.comboBoxCmPUnit = new System.Windows.Forms.ComboBox();
            this.radioButtonCmMOth = new System.Windows.Forms.RadioButton();
            this.radioButtonCmMApp = new System.Windows.Forms.RadioButton();
            this.radioButtonCmMWeb = new System.Windows.Forms.RadioButton();
            this.trackBarAlimama = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label_tongji_have = new System.Windows.Forms.Label();
            this.label_tongji_all = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_qunfa = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox_price2 = new System.Windows.Forms.TextBox();
            this.textBox_price1 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.comboBox_qunfa_ds_f2 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.comboBox_qunfa_ds_f1 = new System.Windows.Forms.ComboBox();
            this.comboBox_qunfa_ds_s2 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.comboBox_qunfa_ds_s1 = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox_qunfa_coupon = new System.Windows.Forms.TextBox();
            this.checkBox_qunfa_link = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.checkBox_qunfa_pid = new System.Windows.Forms.CheckBox();
            this.textBox_qunfa_times_jiange = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_qunfa_times = new System.Windows.Forms.TextBox();
            this.textBox_qunfa_commission = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tabControl_qunfa_config = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridViewFollowSnd = new System.Windows.Forms.DataGridView();
            this.Column_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripFwSnd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBox_qunfa_qq_kouling_boolean = new System.Windows.Forms.CheckBox();
            this.textBox_qunfa_wieba_content = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButton_qunfa_qq_enter_ctrl = new System.Windows.Forms.RadioButton();
            this.radioButton_qunfa_qq_enter = new System.Windows.Forms.RadioButton();
            this.checkBox_qunfa_qq_zuixiaohua = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_qq_str_suiji = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_qq_str_times = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_qq_guanbi = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_qunfa_qq_peizhi_fasong_times = new System.Windows.Forms.TextBox();
            this.textBox_qunfa_qq_peizhi_zhantietimes = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_qunfa_qq_peizhi_qiehuan_times = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_qunfa_qq_list = new System.Windows.Forms.DataGridView();
            this.Column_qqname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_qunfa_open_mulu = new System.Windows.Forms.Button();
            this.button_qunfa_open_qun = new System.Windows.Forms.Button();
            this.button_qunfa_qq_shuaxin = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_qunfa_weixin_fatu_times = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_qunfa_weixin_list = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_qunfa_weixin_huoqu = new System.Windows.Forms.Button();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.radioButton_fasong_weixin_fashi_houtai = new System.Windows.Forms.RadioButton();
            this.radioButton_fasong_weixin_fashi_qiantai = new System.Windows.Forms.RadioButton();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button_qunfa_shoudong_gengfa = new System.Windows.Forms.Button();
            this.button_qunfa_shoudong_fasong = new System.Windows.Forms.Button();
            this.button_qunfa_shoudong_qingkong = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.webBrowser_send_content = new System.Windows.Forms.WebBrowser();
            this.contextMenuStripCtEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.button_weibo = new System.Windows.Forms.Button();
            this.textBox_weibo_pwd = new System.Windows.Forms.TextBox();
            this.textBox_weibo_name = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dataGridView_weibo = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_weibo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox_qun_del = new System.Windows.Forms.TextBox();
            this.textBox_qun_guolv = new System.Windows.Forms.TextBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox_qun_list = new System.Windows.Forms.TextBox();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.richTextBox_qq_log = new System.Windows.Forms.RichTextBox();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage23 = new System.Windows.Forms.TabPage();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.textBox_fenqun_qq_weiba = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.button31 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_fenqun_qq_pid = new System.Windows.Forms.TextBox();
            this.textBox_fenqun_qq_name = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.dataGridView_fenqun_qq = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_pid_qq = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage24 = new System.Windows.Forms.TabPage();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.textBox_fenqun_weixin_weiba = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.textBox_fenqun_weixin_pid = new System.Windows.Forms.TextBox();
            this.textBox_fenqun_weixin_name = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.dataGridView_fenqun_weixin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_pid_weixin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.comboBox_cj_pinlv = new System.Windows.Forms.ComboBox();
            this.checkBox_gengfa_qq = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_top = new System.Windows.Forms.CheckBox();
            this.checkBox_haopintui = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_weibo_boolean = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.checkBox_qunfa_weixin_boolean = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_qq_boolean = new System.Windows.Forms.CheckBox();
            this.button_qunfa_start = new System.Windows.Forms.Button();
            this.buttonFollowSndStart = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button_save_config_qunfa = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabel_get_qq_guangg_queqiao = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_qq_queqiao_weizhi = new System.Windows.Forms.ComboBox();
            this.comboBox_qq_queqiao_danyuan = new System.Windows.Forms.ComboBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.radioButton_qunfa_duanlian_hpt = new System.Windows.Forms.RadioButton();
            this.checkBox_qunfa_duanlian = new System.Windows.Forms.CheckBox();
            this.checkBox_qunfa_erheyi = new System.Windows.Forms.CheckBox();
            this.textBox_qunfa_apply_content = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.linkLabel_get_weibo_guanggao = new System.Windows.Forms.LinkLabel();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.comboBox_weibo_tongyong_weizhi = new System.Windows.Forms.ComboBox();
            this.comboBox_weibo_tongyong_danyuan = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.linkLabel_get_weixin_guanggao = new System.Windows.Forms.LinkLabel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox_weixin_tongyong_weizhi = new System.Windows.Forms.ComboBox();
            this.comboBox_weixin_tongyong_danyuan = new System.Windows.Forms.ComboBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel_get_qq_guanggao = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_qq_tongyong_weizhi = new System.Windows.Forms.ComboBox();
            this.comboBox_qq_tongyong_danyuan = new System.Windows.Forms.ComboBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton_qq_tongyong = new System.Windows.Forms.RadioButton();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.textBox_weibo_template = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox_weixin_template = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_qq_template = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_qunfa_template = new System.Windows.Forms.Button();
            this.button_qunfa_setting = new System.Windows.Forms.Button();
            this.button_qunfa_fa = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl_tools = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabControl_tools_common = new System.Windows.Forms.TabControl();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button_tools_qingkong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_tools_zhuanhua_copy = new System.Windows.Forms.Button();
            this.button_tools_zhuanhua_tianjia_zhushou = new System.Windows.Forms.Button();
            this.checkBox_tools_piliang = new System.Windows.Forms.CheckBox();
            this.checkBox_tools_qingkong = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.webBrowser_zhuanhua = new System.Windows.Forms.WebBrowser();
            this.contextMenuStripTool = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.button_tools_test_get_cookie = new System.Windows.Forms.Button();
            this.textBoxAlimamaCookieUrl = new System.Windows.Forms.TextBox();
            this.tabPage25 = new System.Windows.Forms.TabPage();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.comboBox_ali_order_days = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.button46 = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.comboBox_ali_order_pinlv = new System.Windows.Forms.ComboBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_tools_bt_changgui = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.groupBox_dama = new System.Windows.Forms.GroupBox();
            this.buttonOpenUUHP = new System.Windows.Forms.Button();
            this.buttonTestCode = new System.Windows.Forms.Button();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.buttonUUWiseLogin = new System.Windows.Forms.Button();
            this.textBoxUUPwd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUUUsername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonsetting_app_haopintui = new System.Windows.Forms.RadioButton();
            this.radioButtonsetting_app_ben = new System.Windows.Forms.RadioButton();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_setting_appKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_setting_appId = new System.Windows.Forms.TextBox();
            this.groupBox_alimama = new System.Windows.Forms.GroupBox();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.label66 = new System.Windows.Forms.Label();
            this.checkBoxScanLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.buttonLoginAlimama2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAlimamaPwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAlimamaAcc = new System.Windows.Forms.TextBox();
            this.notifyIcon_task = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_kouling = new System.Windows.Forms.Timer(this.components);
            this.timer_caiji = new System.Windows.Forms.Timer(this.components);
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.layout_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_content.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_cms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlimama)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl_qunfa.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.tabControl_qunfa_config.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowSnd)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_qunfa_qq_list)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_qunfa_weixin_list)).BeginInit();
            this.tabPage18.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_weibo)).BeginInit();
            this.tabPage19.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.tabPage21.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.tabPage22.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage23.SuspendLayout();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fenqun_qq)).BeginInit();
            this.tabPage24.SuspendLayout();
            this.groupBox31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fenqun_weixin)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl_tools.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabControl_tools_common.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage25.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox_dama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox_alimama.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxLogs.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxLogs.Location = new System.Drawing.Point(0, 590);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.Size = new System.Drawing.Size(980, 60);
            this.richTextBoxLogs.TabIndex = 0;
            this.richTextBoxLogs.Text = "";
            // 
            // layout_menu
            // 
            this.layout_menu.BackColor = System.Drawing.Color.White;
            this.layout_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layout_menu.Controls.Add(this.panel1);
            this.layout_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.layout_menu.Location = new System.Drawing.Point(0, 60);
            this.layout_menu.Name = "layout_menu";
            this.layout_menu.Size = new System.Drawing.Size(100, 530);
            this.layout_menu.TabIndex = 2;
            this.layout_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.layout_menu_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_setting);
            this.panel1.Controls.Add(this.label_tools);
            this.panel1.Controls.Add(this.label_qunfa);
            this.panel1.Controls.Add(this.label_cms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 476);
            this.panel1.TabIndex = 0;
            // 
            // label_setting
            // 
            this.label_setting.Image = global::haopintui.Properties.Resources.setting;
            this.label_setting.Location = new System.Drawing.Point(2, 252);
            this.label_setting.Name = "label_setting";
            this.label_setting.Size = new System.Drawing.Size(91, 80);
            this.label_setting.TabIndex = 0;
            this.label_setting.Text = "软件设置";
            this.label_setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_setting.Click += new System.EventHandler(this.label11_Click);
            // 
            // label_tools
            // 
            this.label_tools.Image = global::haopintui.Properties.Resources.tools;
            this.label_tools.Location = new System.Drawing.Point(3, 168);
            this.label_tools.Name = "label_tools";
            this.label_tools.Size = new System.Drawing.Size(91, 80);
            this.label_tools.TabIndex = 0;
            this.label_tools.Text = "实用工具";
            this.label_tools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_tools.Click += new System.EventHandler(this.label10_Click);
            // 
            // label_qunfa
            // 
            this.label_qunfa.Image = global::haopintui.Properties.Resources.qunfa;
            this.label_qunfa.Location = new System.Drawing.Point(2, 86);
            this.label_qunfa.Name = "label_qunfa";
            this.label_qunfa.Size = new System.Drawing.Size(91, 80);
            this.label_qunfa.TabIndex = 0;
            this.label_qunfa.Text = "群发功能";
            this.label_qunfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_qunfa.Click += new System.EventHandler(this.label9_Click);
            // 
            // label_cms
            // 
            this.label_cms.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_cms.Image = global::haopintui.Properties.Resources.cms1;
            this.label_cms.Location = new System.Drawing.Point(2, 3);
            this.label_cms.Name = "label_cms";
            this.label_cms.Size = new System.Drawing.Size(91, 80);
            this.label_cms.TabIndex = 0;
            this.label_cms.Text = "CMS转链";
            this.label_cms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_cms.Click += new System.EventHandler(this.label8_Click);
            // 
            // panelTop
            // 
            this.panelTop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTop.Controls.Add(this.button47);
            this.panelTop.Controls.Add(this.button_bind);
            this.panelTop.Controls.Add(this.label_user_type_name);
            this.panelTop.Controls.Add(this.label_welcome);
            this.panelTop.Controls.Add(this.label_banben);
            this.panelTop.Controls.Add(this.linkLabel2);
            this.panelTop.Controls.Add(this.linkLabel1);
            this.panelTop.Controls.Add(this.webBrowserQuanAlimama);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.label_version);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.tool_name);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(980, 60);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTop.DoubleClick += new System.EventHandler(this.on_panel_doubleclick);
            this.panelTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDoubleClick);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plan_OnMouseDown);
            this.panelTop.MouseEnter += new System.EventHandler(this.panelTop_MouseEnter);
            this.panelTop.MouseLeave += new System.EventHandler(this.panelTop_MouseLeave);
            this.panelTop.MouseHover += new System.EventHandler(this.panelTop_MouseHover);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // button_bind
            // 
            this.button_bind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_bind.Location = new System.Drawing.Point(251, 5);
            this.button_bind.Name = "button_bind";
            this.button_bind.Size = new System.Drawing.Size(75, 23);
            this.button_bind.TabIndex = 8;
            this.button_bind.Text = "账号认证";
            this.button_bind.UseVisualStyleBackColor = true;
            this.button_bind.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // label_user_type_name
            // 
            this.label_user_type_name.AutoSize = true;
            this.label_user_type_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_user_type_name.ForeColor = System.Drawing.Color.White;
            this.label_user_type_name.Location = new System.Drawing.Point(515, 30);
            this.label_user_type_name.Name = "label_user_type_name";
            this.label_user_type_name.Size = new System.Drawing.Size(68, 17);
            this.label_user_type_name.TabIndex = 7;
            this.label_user_type_name.Text = "用户类型：";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(515, 5);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(44, 17);
            this.label_welcome.TabIndex = 7;
            this.label_welcome.Text = "欢迎：";
            // 
            // label_banben
            // 
            this.label_banben.AutoSize = true;
            this.label_banben.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_banben.ForeColor = System.Drawing.Color.White;
            this.label_banben.Location = new System.Drawing.Point(398, 30);
            this.label_banben.Name = "label_banben";
            this.label_banben.Size = new System.Drawing.Size(56, 17);
            this.label_banben.TabIndex = 6;
            this.label_banben.Text = "版本号：";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(397, 5);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(60, 17);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = " 使用教程";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(754, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "官网";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // webBrowserQuanAlimama
            // 
            this.webBrowserQuanAlimama.ContextMenuStrip = this.contextMenuStripCouponPage;
            this.webBrowserQuanAlimama.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserQuanAlimama.Location = new System.Drawing.Point(554, 5);
            this.webBrowserQuanAlimama.MinimumSize = new System.Drawing.Size(1, 1);
            this.webBrowserQuanAlimama.Name = "webBrowserQuanAlimama";
            this.webBrowserQuanAlimama.ScriptErrorsSuppressed = true;
            this.webBrowserQuanAlimama.Size = new System.Drawing.Size(1, 1);
            this.webBrowserQuanAlimama.TabIndex = 4;
            this.webBrowserQuanAlimama.Url = new System.Uri("http://uland.taobao.com/coupon/edetail?activityId=fb9bf43aeda246aa8be2b61d4e619d8" +
        "c&pid=mm_110019639_17876093_65366558&itemId=45189982853&src=qhkj_dtkp&dx=", System.UriKind.Absolute);
            // 
            // contextMenuStripCouponPage
            // 
            this.contextMenuStripCouponPage.Name = "contextMenuStripCouponPage";
            this.contextMenuStripCouponPage.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::haopintui.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.ForeColor = System.Drawing.Color.White;
            this.label_version.Location = new System.Drawing.Point(401, 29);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(0, 19);
            this.label_version.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "陪伴你每天进步一点点";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tool_name
            // 
            this.tool_name.AutoSize = true;
            this.tool_name.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tool_name.ForeColor = System.Drawing.Color.White;
            this.tool_name.Location = new System.Drawing.Point(71, 9);
            this.tool_name.Name = "tool_name";
            this.tool_name.Size = new System.Drawing.Size(178, 42);
            this.tool_name.TabIndex = 0;
            this.tool_name.Text = "好品推助手";
            this.tool_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.White;
            this.panel_content.Controls.Add(this.tabControlMain);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_content.Location = new System.Drawing.Point(100, 60);
            this.panel_content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(880, 530);
            this.panel_content.TabIndex = 3;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 10);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(880, 530);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel_cms);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel_cms
            // 
            this.panel_cms.Controls.Add(this.groupBox1);
            this.panel_cms.Controls.Add(this.groupBox_cms);
            this.panel_cms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cms.Location = new System.Drawing.Point(3, 53);
            this.panel_cms.Name = "panel_cms";
            this.panel_cms.Size = new System.Drawing.Size(866, 456);
            this.panel_cms.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxCms);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(315, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 456);
            this.groupBox1.TabIndex = 3;
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
            this.richTextBoxCms.Size = new System.Drawing.Size(545, 432);
            this.richTextBoxCms.TabIndex = 0;
            this.richTextBoxCms.Text = "";
            // 
            // groupBox_cms
            // 
            this.groupBox_cms.Controls.Add(this.checkBox_cmslist_xianshi);
            this.groupBox_cms.Controls.Add(this.checkBox_cmslist_jihua);
            this.groupBox_cms.Controls.Add(this.linkLabel6);
            this.groupBox_cms.Controls.Add(this.linkLabelGetPromot);
            this.groupBox_cms.Controls.Add(this.textBoxAppCmsReson);
            this.groupBox_cms.Controls.Add(this.label39);
            this.groupBox_cms.Controls.Add(this.button_cms_click_apply);
            this.groupBox_cms.Controls.Add(this.label7);
            this.groupBox_cms.Controls.Add(this.label6);
            this.groupBox_cms.Controls.Add(this.label5);
            this.groupBox_cms.Controls.Add(this.label4);
            this.groupBox_cms.Controls.Add(this.label3);
            this.groupBox_cms.Controls.Add(this.label2);
            this.groupBox_cms.Controls.Add(this.comboBoxCmsList);
            this.groupBox_cms.Controls.Add(this.comboBoxCmPPos);
            this.groupBox_cms.Controls.Add(this.comboBoxCmPUnit);
            this.groupBox_cms.Controls.Add(this.radioButtonCmMOth);
            this.groupBox_cms.Controls.Add(this.radioButtonCmMApp);
            this.groupBox_cms.Controls.Add(this.radioButtonCmMWeb);
            this.groupBox_cms.Controls.Add(this.trackBarAlimama);
            this.groupBox_cms.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_cms.Font = new System.Drawing.Font("微软雅黑 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_cms.Location = new System.Drawing.Point(0, 0);
            this.groupBox_cms.Name = "groupBox_cms";
            this.groupBox_cms.Size = new System.Drawing.Size(315, 456);
            this.groupBox_cms.TabIndex = 2;
            this.groupBox_cms.TabStop = false;
            this.groupBox_cms.Text = "cms转换配置";
            // 
            // checkBox_cmslist_xianshi
            // 
            this.checkBox_cmslist_xianshi.AutoSize = true;
            this.checkBox_cmslist_xianshi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_cmslist_xianshi.Location = new System.Drawing.Point(19, 362);
            this.checkBox_cmslist_xianshi.Name = "checkBox_cmslist_xianshi";
            this.checkBox_cmslist_xianshi.Size = new System.Drawing.Size(287, 21);
            this.checkBox_cmslist_xianshi.TabIndex = 12;
            this.checkBox_cmslist_xianshi.Text = "闲时自动转化(开启此项，请设置好阿狸妈妈请求)";
            this.checkBox_cmslist_xianshi.UseVisualStyleBackColor = true;
            this.checkBox_cmslist_xianshi.CheckedChanged += new System.EventHandler(this.checkBox_cmslist_jihua_CheckedChanged);
            // 
            // checkBox_cmslist_jihua
            // 
            this.checkBox_cmslist_jihua.AutoSize = true;
            this.checkBox_cmslist_jihua.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_cmslist_jihua.Location = new System.Drawing.Point(21, 333);
            this.checkBox_cmslist_jihua.Name = "checkBox_cmslist_jihua";
            this.checkBox_cmslist_jihua.Size = new System.Drawing.Size(249, 21);
            this.checkBox_cmslist_jihua.TabIndex = 12;
            this.checkBox_cmslist_jihua.Text = "只申请计划,不保存链接,可以提高转换速度";
            this.checkBox_cmslist_jihua.UseVisualStyleBackColor = true;
            this.checkBox_cmslist_jihua.Visible = false;
            this.checkBox_cmslist_jihua.CheckedChanged += new System.EventHandler(this.checkBox_cmslist_jihua_CheckedChanged);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(253, 106);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(61, 19);
            this.linkLabel6.TabIndex = 11;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "如何创建";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabelGetPromot
            // 
            this.linkLabelGetPromot.AutoSize = true;
            this.linkLabelGetPromot.Location = new System.Drawing.Point(204, 1);
            this.linkLabelGetPromot.Name = "linkLabelGetPromot";
            this.linkLabelGetPromot.Size = new System.Drawing.Size(100, 19);
            this.linkLabelGetPromot.TabIndex = 10;
            this.linkLabelGetPromot.TabStop = true;
            this.linkLabelGetPromot.Text = "获取最新推广位";
            this.linkLabelGetPromot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGetPromot_LinkClicked);
            // 
            // textBoxAppCmsReson
            // 
            this.textBoxAppCmsReson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAppCmsReson.Location = new System.Drawing.Point(21, 194);
            this.textBoxAppCmsReson.Multiline = true;
            this.textBoxAppCmsReson.Name = "textBoxAppCmsReson";
            this.textBoxAppCmsReson.Size = new System.Drawing.Size(273, 46);
            this.textBoxAppCmsReson.TabIndex = 9;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(161, 286);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 19);
            this.label39.TabIndex = 8;
            // 
            // button_cms_click_apply
            // 
            this.button_cms_click_apply.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_cms_click_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cms_click_apply.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cms_click_apply.ForeColor = System.Drawing.Color.White;
            this.button_cms_click_apply.Location = new System.Drawing.Point(58, 403);
            this.button_cms_click_apply.Name = "button_cms_click_apply";
            this.button_cms_click_apply.Size = new System.Drawing.Size(147, 30);
            this.button_cms_click_apply.TabIndex = 7;
            this.button_cms_click_apply.Text = "开始自动申请";
            this.button_cms_click_apply.UseVisualStyleBackColor = false;
            this.button_cms_click_apply.Click += new System.EventHandler(this.button_cms_click_apply_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(15, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "建议将间隔时间设置为大于1秒，防止被阿里限制";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "阿里妈妈请求间隔(秒)：0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "计划申请理由：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "CMS选择：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "推广位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "推广单元：";
            // 
            // comboBoxCmsList
            // 
            this.comboBoxCmsList.BackColor = System.Drawing.Color.White;
            this.comboBoxCmsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCmsList.FormattingEnabled = true;
            this.comboBoxCmsList.Location = new System.Drawing.Point(96, 139);
            this.comboBoxCmsList.Name = "comboBoxCmsList";
            this.comboBoxCmsList.Size = new System.Drawing.Size(197, 27);
            this.comboBoxCmsList.TabIndex = 3;
            // 
            // comboBoxCmPPos
            // 
            this.comboBoxCmPPos.BackColor = System.Drawing.Color.White;
            this.comboBoxCmPPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCmPPos.FormattingEnabled = true;
            this.comboBoxCmPPos.Location = new System.Drawing.Point(96, 103);
            this.comboBoxCmPPos.Name = "comboBoxCmPPos";
            this.comboBoxCmPPos.Size = new System.Drawing.Size(151, 27);
            this.comboBoxCmPPos.TabIndex = 3;
            // 
            // comboBoxCmPUnit
            // 
            this.comboBoxCmPUnit.BackColor = System.Drawing.Color.White;
            this.comboBoxCmPUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCmPUnit.FormattingEnabled = true;
            this.comboBoxCmPUnit.Location = new System.Drawing.Point(96, 68);
            this.comboBoxCmPUnit.Name = "comboBoxCmPUnit";
            this.comboBoxCmPUnit.Size = new System.Drawing.Size(197, 27);
            this.comboBoxCmPUnit.TabIndex = 3;
            this.comboBoxCmPUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxCmPUnit_SelectedIndexChanged);
            // 
            // radioButtonCmMOth
            // 
            this.radioButtonCmMOth.AutoSize = true;
            this.radioButtonCmMOth.Enabled = false;
            this.radioButtonCmMOth.Location = new System.Drawing.Point(223, 31);
            this.radioButtonCmMOth.Name = "radioButtonCmMOth";
            this.radioButtonCmMOth.Size = new System.Drawing.Size(79, 23);
            this.radioButtonCmMOth.TabIndex = 2;
            this.radioButtonCmMOth.Text = "导购推广";
            this.radioButtonCmMOth.UseVisualStyleBackColor = true;
            // 
            // radioButtonCmMApp
            // 
            this.radioButtonCmMApp.AutoSize = true;
            this.radioButtonCmMApp.Enabled = false;
            this.radioButtonCmMApp.Location = new System.Drawing.Point(127, 31);
            this.radioButtonCmMApp.Name = "radioButtonCmMApp";
            this.radioButtonCmMApp.Size = new System.Drawing.Size(78, 23);
            this.radioButtonCmMApp.TabIndex = 1;
            this.radioButtonCmMApp.Text = "APP推广";
            this.radioButtonCmMApp.UseVisualStyleBackColor = true;
            // 
            // radioButtonCmMWeb
            // 
            this.radioButtonCmMWeb.AutoSize = true;
            this.radioButtonCmMWeb.Checked = true;
            this.radioButtonCmMWeb.Location = new System.Drawing.Point(21, 31);
            this.radioButtonCmMWeb.Name = "radioButtonCmMWeb";
            this.radioButtonCmMWeb.Size = new System.Drawing.Size(79, 23);
            this.radioButtonCmMWeb.TabIndex = 0;
            this.radioButtonCmMWeb.TabStop = true;
            this.radioButtonCmMWeb.Text = "网站推广";
            this.radioButtonCmMWeb.UseVisualStyleBackColor = true;
            // 
            // trackBarAlimama
            // 
            this.trackBarAlimama.Location = new System.Drawing.Point(19, 263);
            this.trackBarAlimama.Name = "trackBarAlimama";
            this.trackBarAlimama.Size = new System.Drawing.Size(272, 45);
            this.trackBarAlimama.TabIndex = 6;
            this.trackBarAlimama.Scroll += new System.EventHandler(this.trackBarAlimama_Scroll);
            this.trackBarAlimama.ValueChanged += new System.EventHandler(this.trackBarAlimama_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label67);
            this.panel2.Controls.Add(this.groupBox16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 50);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label67.Location = new System.Drawing.Point(310, 21);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(320, 17);
            this.label67.TabIndex = 2;
            this.label67.Text = "实时申请为用户看啥商品，助手立马申请啥商品高佣金计划";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label_tongji_have);
            this.groupBox16.Controls.Add(this.label_tongji_all);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox16.Enabled = false;
            this.groupBox16.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox16.Location = new System.Drawing.Point(633, 0);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox16.Size = new System.Drawing.Size(233, 50);
            this.groupBox16.TabIndex = 1;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "实时转换统计";
            this.groupBox16.Visible = false;
            // 
            // label_tongji_have
            // 
            this.label_tongji_have.AutoSize = true;
            this.label_tongji_have.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tongji_have.Location = new System.Drawing.Point(100, 25);
            this.label_tongji_have.Name = "label_tongji_have";
            this.label_tongji_have.Size = new System.Drawing.Size(0, 12);
            this.label_tongji_have.TabIndex = 0;
            // 
            // label_tongji_all
            // 
            this.label_tongji_all.AutoSize = true;
            this.label_tongji_all.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tongji_all.Location = new System.Drawing.Point(4, 25);
            this.label_tongji_all.Name = "label_tongji_all";
            this.label_tongji_all.Size = new System.Drawing.Size(0, 12);
            this.label_tongji_all.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl_qunfa);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(872, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl_qunfa
            // 
            this.tabControl_qunfa.Controls.Add(this.tabPage5);
            this.tabControl_qunfa.Controls.Add(this.tabPage6);
            this.tabControl_qunfa.Controls.Add(this.tabPage16);
            this.tabControl_qunfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_qunfa.ItemSize = new System.Drawing.Size(0, 10);
            this.tabControl_qunfa.Location = new System.Drawing.Point(0, 50);
            this.tabControl_qunfa.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_qunfa.Name = "tabControl_qunfa";
            this.tabControl_qunfa.SelectedIndex = 0;
            this.tabControl_qunfa.Size = new System.Drawing.Size(872, 462);
            this.tabControl_qunfa.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox33);
            this.tabPage5.Controls.Add(this.tabControl_qunfa_config);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage5.Location = new System.Drawing.Point(4, 14);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(864, 444);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.label40);
            this.groupBox33.Controls.Add(this.textBox_price2);
            this.groupBox33.Controls.Add(this.textBox_price1);
            this.groupBox33.Controls.Add(this.label60);
            this.groupBox33.Controls.Add(this.label72);
            this.groupBox33.Controls.Add(this.label63);
            this.groupBox33.Controls.Add(this.label65);
            this.groupBox33.Controls.Add(this.comboBox_qunfa_ds_f2);
            this.groupBox33.Controls.Add(this.label62);
            this.groupBox33.Controls.Add(this.label64);
            this.groupBox33.Controls.Add(this.comboBox_qunfa_ds_f1);
            this.groupBox33.Controls.Add(this.comboBox_qunfa_ds_s2);
            this.groupBox33.Controls.Add(this.label61);
            this.groupBox33.Controls.Add(this.comboBox_qunfa_ds_s1);
            this.groupBox33.Controls.Add(this.label57);
            this.groupBox33.Controls.Add(this.textBox_qunfa_coupon);
            this.groupBox33.Controls.Add(this.checkBox_qunfa_link);
            this.groupBox33.Controls.Add(this.label38);
            this.groupBox33.Controls.Add(this.label33);
            this.groupBox33.Controls.Add(this.label34);
            this.groupBox33.Controls.Add(this.label37);
            this.groupBox33.Controls.Add(this.checkBox_qunfa_pid);
            this.groupBox33.Controls.Add(this.textBox_qunfa_times_jiange);
            this.groupBox33.Controls.Add(this.label36);
            this.groupBox33.Controls.Add(this.label16);
            this.groupBox33.Controls.Add(this.textBox_qunfa_times);
            this.groupBox33.Controls.Add(this.textBox_qunfa_commission);
            this.groupBox33.Controls.Add(this.label35);
            this.groupBox33.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox33.Location = new System.Drawing.Point(0, 97);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(861, 86);
            this.groupBox33.TabIndex = 7;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "发送规则";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(481, 24);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 17);
            this.label40.TabIndex = 12;
            this.label40.Text = "商品价格区间:";
            // 
            // textBox_price2
            // 
            this.textBox_price2.Location = new System.Drawing.Point(620, 24);
            this.textBox_price2.Name = "textBox_price2";
            this.textBox_price2.Size = new System.Drawing.Size(27, 23);
            this.textBox_price2.TabIndex = 11;
            this.textBox_price2.Text = "0";
            // 
            // textBox_price1
            // 
            this.textBox_price1.Location = new System.Drawing.Point(564, 24);
            this.textBox_price1.Name = "textBox_price1";
            this.textBox_price1.Size = new System.Drawing.Size(30, 23);
            this.textBox_price1.TabIndex = 11;
            this.textBox_price1.Text = "0";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(444, 61);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(59, 17);
            this.label60.TabIndex = 7;
            this.label60.Text = "定时发送:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label72.Location = new System.Drawing.Point(596, 24);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(23, 17);
            this.label72.TabIndex = 10;
            this.label72.Text = "---";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label63.Location = new System.Drawing.Point(634, 61);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(23, 17);
            this.label63.TabIndex = 10;
            this.label63.Text = "---";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label65.Location = new System.Drawing.Point(772, 61);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(20, 17);
            this.label65.TabIndex = 10;
            this.label65.Text = "分";
            // 
            // comboBox_qunfa_ds_f2
            // 
            this.comboBox_qunfa_ds_f2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_qunfa_ds_f2.FormattingEnabled = true;
            this.comboBox_qunfa_ds_f2.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBox_qunfa_ds_f2.Location = new System.Drawing.Point(729, 57);
            this.comboBox_qunfa_ds_f2.Name = "comboBox_qunfa_ds_f2";
            this.comboBox_qunfa_ds_f2.Size = new System.Drawing.Size(40, 25);
            this.comboBox_qunfa_ds_f2.TabIndex = 9;
            this.comboBox_qunfa_ds_f2.SelectedIndexChanged += new System.EventHandler(this.comboBox_qunfa_ds_f2_SelectedIndexChanged);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.Location = new System.Drawing.Point(612, 60);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(20, 17);
            this.label62.TabIndex = 10;
            this.label62.Text = "分";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label64.Location = new System.Drawing.Point(707, 61);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(20, 17);
            this.label64.TabIndex = 10;
            this.label64.Text = "时";
            // 
            // comboBox_qunfa_ds_f1
            // 
            this.comboBox_qunfa_ds_f1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_qunfa_ds_f1.FormattingEnabled = true;
            this.comboBox_qunfa_ds_f1.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBox_qunfa_ds_f1.Location = new System.Drawing.Point(569, 56);
            this.comboBox_qunfa_ds_f1.Name = "comboBox_qunfa_ds_f1";
            this.comboBox_qunfa_ds_f1.Size = new System.Drawing.Size(40, 25);
            this.comboBox_qunfa_ds_f1.TabIndex = 9;
            this.comboBox_qunfa_ds_f1.SelectedIndexChanged += new System.EventHandler(this.comboBox_qunfa_ds_f1_SelectedIndexChanged);
            // 
            // comboBox_qunfa_ds_s2
            // 
            this.comboBox_qunfa_ds_s2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_qunfa_ds_s2.FormattingEnabled = true;
            this.comboBox_qunfa_ds_s2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_qunfa_ds_s2.Location = new System.Drawing.Point(663, 57);
            this.comboBox_qunfa_ds_s2.Name = "comboBox_qunfa_ds_s2";
            this.comboBox_qunfa_ds_s2.Size = new System.Drawing.Size(40, 25);
            this.comboBox_qunfa_ds_s2.TabIndex = 9;
            this.comboBox_qunfa_ds_s2.SelectedIndexChanged += new System.EventHandler(this.comboBox_qunfa_ds_s2_SelectedIndexChanged);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(548, 60);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(20, 17);
            this.label61.TabIndex = 10;
            this.label61.Text = "时";
            // 
            // comboBox_qunfa_ds_s1
            // 
            this.comboBox_qunfa_ds_s1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_qunfa_ds_s1.FormattingEnabled = true;
            this.comboBox_qunfa_ds_s1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_qunfa_ds_s1.Location = new System.Drawing.Point(505, 56);
            this.comboBox_qunfa_ds_s1.Name = "comboBox_qunfa_ds_s1";
            this.comboBox_qunfa_ds_s1.Size = new System.Drawing.Size(40, 25);
            this.comboBox_qunfa_ds_s1.TabIndex = 9;
            this.comboBox_qunfa_ds_s1.SelectedIndexChanged += new System.EventHandler(this.comboBox_qunfa_ds_s1_SelectedIndexChanged);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(14, 24);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(83, 17);
            this.label57.TabIndex = 6;
            this.label57.Text = "天猫淘宝规则:";
            // 
            // textBox_qunfa_coupon
            // 
            this.textBox_qunfa_coupon.Location = new System.Drawing.Point(159, 24);
            this.textBox_qunfa_coupon.Name = "textBox_qunfa_coupon";
            this.textBox_qunfa_coupon.Size = new System.Drawing.Size(42, 23);
            this.textBox_qunfa_coupon.TabIndex = 2;
            this.textBox_qunfa_coupon.Text = "50";
            // 
            // checkBox_qunfa_link
            // 
            this.checkBox_qunfa_link.AutoSize = true;
            this.checkBox_qunfa_link.Location = new System.Drawing.Point(337, 60);
            this.checkBox_qunfa_link.Name = "checkBox_qunfa_link";
            this.checkBox_qunfa_link.Size = new System.Drawing.Size(99, 21);
            this.checkBox_qunfa_link.TabIndex = 5;
            this.checkBox_qunfa_link.Text = "没有连接不发";
            this.checkBox_qunfa_link.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(183, 61);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(80, 17);
            this.label38.TabIndex = 4;
            this.label38.Text = "发送间隔时间";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(205, 24);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 17);
            this.label33.TabIndex = 3;
            this.label33.Text = "张不发";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(93, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 17);
            this.label34.TabIndex = 4;
            this.label34.Text = "优惠券低于";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(311, 60);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 17);
            this.label37.TabIndex = 3;
            this.label37.Text = "秒";
            // 
            // checkBox_qunfa_pid
            // 
            this.checkBox_qunfa_pid.AutoSize = true;
            this.checkBox_qunfa_pid.Checked = true;
            this.checkBox_qunfa_pid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_qunfa_pid.Location = new System.Drawing.Point(391, 24);
            this.checkBox_qunfa_pid.Name = "checkBox_qunfa_pid";
            this.checkBox_qunfa_pid.Size = new System.Drawing.Size(94, 21);
            this.checkBox_qunfa_pid.TabIndex = 5;
            this.checkBox_qunfa_pid.Text = "自动转换pid";
            this.checkBox_qunfa_pid.UseVisualStyleBackColor = true;
            // 
            // textBox_qunfa_times_jiange
            // 
            this.textBox_qunfa_times_jiange.Location = new System.Drawing.Point(264, 56);
            this.textBox_qunfa_times_jiange.Name = "textBox_qunfa_times_jiange";
            this.textBox_qunfa_times_jiange.Size = new System.Drawing.Size(45, 23);
            this.textBox_qunfa_times_jiange.TabIndex = 2;
            this.textBox_qunfa_times_jiange.Text = "5";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(250, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 17);
            this.label36.TabIndex = 4;
            this.label36.Text = "佣金低于";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "小时内重复产品不发";
            // 
            // textBox_qunfa_times
            // 
            this.textBox_qunfa_times.Location = new System.Drawing.Point(16, 56);
            this.textBox_qunfa_times.Name = "textBox_qunfa_times";
            this.textBox_qunfa_times.Size = new System.Drawing.Size(27, 23);
            this.textBox_qunfa_times.TabIndex = 2;
            this.textBox_qunfa_times.Text = "12";
            this.textBox_qunfa_times.TextChanged += new System.EventHandler(this.textBox_qunfa_times_TextChanged);
            // 
            // textBox_qunfa_commission
            // 
            this.textBox_qunfa_commission.Location = new System.Drawing.Point(306, 22);
            this.textBox_qunfa_commission.Name = "textBox_qunfa_commission";
            this.textBox_qunfa_commission.Size = new System.Drawing.Size(35, 23);
            this.textBox_qunfa_commission.TabIndex = 2;
            this.textBox_qunfa_commission.Text = "20";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(345, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(43, 17);
            this.label35.TabIndex = 3;
            this.label35.Text = "%不发";
            // 
            // tabControl_qunfa_config
            // 
            this.tabControl_qunfa_config.Controls.Add(this.tabPage7);
            this.tabControl_qunfa_config.Controls.Add(this.tabPage8);
            this.tabControl_qunfa_config.Controls.Add(this.tabPage9);
            this.tabControl_qunfa_config.Controls.Add(this.tabPage10);
            this.tabControl_qunfa_config.Controls.Add(this.tabPage15);
            this.tabControl_qunfa_config.Controls.Add(this.tabPage19);
            this.tabControl_qunfa_config.Controls.Add(this.tabPage22);
            this.tabControl_qunfa_config.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_qunfa_config.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_qunfa_config.Location = new System.Drawing.Point(0, 186);
            this.tabControl_qunfa_config.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_qunfa_config.Name = "tabControl_qunfa_config";
            this.tabControl_qunfa_config.SelectedIndex = 0;
            this.tabControl_qunfa_config.Size = new System.Drawing.Size(864, 258);
            this.tabControl_qunfa_config.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.ContextMenuStrip = this.contextMenuStripCouponPage;
            this.tabPage7.Controls.Add(this.dataGridViewFollowSnd);
            this.tabPage7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(856, 226);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "监控消息队列";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFollowSnd
            // 
            this.dataGridViewFollowSnd.AllowUserToAddRows = false;
            this.dataGridViewFollowSnd.AllowUserToDeleteRows = false;
            this.dataGridViewFollowSnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFollowSnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowSnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_time,
            this.Column_from,
            this.Column_content,
            this.Column_status});
            this.dataGridViewFollowSnd.ContextMenuStrip = this.contextMenuStripFwSnd;
            this.dataGridViewFollowSnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFollowSnd.GridColor = System.Drawing.Color.White;
            this.dataGridViewFollowSnd.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFollowSnd.Name = "dataGridViewFollowSnd";
            this.dataGridViewFollowSnd.ReadOnly = true;
            this.dataGridViewFollowSnd.RowHeadersWidth = 50;
            this.dataGridViewFollowSnd.RowTemplate.Height = 23;
            this.dataGridViewFollowSnd.Size = new System.Drawing.Size(850, 220);
            this.dataGridViewFollowSnd.TabIndex = 0;
            // 
            // Column_time
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column_time.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_time.FillWeight = 20F;
            this.Column_time.HeaderText = "时间";
            this.Column_time.Name = "Column_time";
            this.Column_time.ReadOnly = true;
            // 
            // Column_from
            // 
            this.Column_from.FillWeight = 15F;
            this.Column_from.HeaderText = "消息来源";
            this.Column_from.Name = "Column_from";
            this.Column_from.ReadOnly = true;
            // 
            // Column_content
            // 
            this.Column_content.FillWeight = 55F;
            this.Column_content.HeaderText = "内容";
            this.Column_content.Name = "Column_content";
            this.Column_content.ReadOnly = true;
            // 
            // Column_status
            // 
            this.Column_status.FillWeight = 10F;
            this.Column_status.HeaderText = "状态";
            this.Column_status.Name = "Column_status";
            this.Column_status.ReadOnly = true;
            // 
            // contextMenuStripFwSnd
            // 
            this.contextMenuStripFwSnd.Name = "contextMenuStripFwSnd";
            this.contextMenuStripFwSnd.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox10);
            this.tabPage8.Controls.Add(this.groupBox9);
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(856, 226);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "qq群发配置";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox_qunfa_qq_kouling_boolean);
            this.groupBox10.Controls.Add(this.textBox_qunfa_wieba_content);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(499, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(354, 220);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "扩展设置";
            // 
            // checkBox_qunfa_qq_kouling_boolean
            // 
            this.checkBox_qunfa_qq_kouling_boolean.AutoSize = true;
            this.checkBox_qunfa_qq_kouling_boolean.Location = new System.Drawing.Point(11, 113);
            this.checkBox_qunfa_qq_kouling_boolean.Name = "checkBox_qunfa_qq_kouling_boolean";
            this.checkBox_qunfa_qq_kouling_boolean.Size = new System.Drawing.Size(122, 23);
            this.checkBox_qunfa_qq_kouling_boolean.TabIndex = 2;
            this.checkBox_qunfa_qq_kouling_boolean.Text = "qq群是否带口令";
            this.checkBox_qunfa_qq_kouling_boolean.UseVisualStyleBackColor = true;
            // 
            // textBox_qunfa_wieba_content
            // 
            this.textBox_qunfa_wieba_content.Location = new System.Drawing.Point(11, 46);
            this.textBox_qunfa_wieba_content.Multiline = true;
            this.textBox_qunfa_wieba_content.Name = "textBox_qunfa_wieba_content";
            this.textBox_qunfa_wieba_content.Size = new System.Drawing.Size(257, 44);
            this.textBox_qunfa_wieba_content.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 19);
            this.label32.TabIndex = 0;
            this.label32.Text = "加群发尾巴：";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButton_qunfa_qq_enter_ctrl);
            this.groupBox9.Controls.Add(this.radioButton_qunfa_qq_enter);
            this.groupBox9.Controls.Add(this.checkBox_qunfa_qq_zuixiaohua);
            this.groupBox9.Controls.Add(this.checkBox_qunfa_qq_str_suiji);
            this.groupBox9.Controls.Add(this.checkBox_qunfa_qq_str_times);
            this.groupBox9.Controls.Add(this.checkBox_qunfa_qq_guanbi);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.textBox_qunfa_qq_peizhi_fasong_times);
            this.groupBox9.Controls.Add(this.textBox_qunfa_qq_peizhi_zhantietimes);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.textBox_qunfa_qq_peizhi_qiehuan_times);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox9.Location = new System.Drawing.Point(253, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(246, 220);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "qq群配置";
            // 
            // radioButton_qunfa_qq_enter_ctrl
            // 
            this.radioButton_qunfa_qq_enter_ctrl.AutoSize = true;
            this.radioButton_qunfa_qq_enter_ctrl.Location = new System.Drawing.Point(102, 179);
            this.radioButton_qunfa_qq_enter_ctrl.Name = "radioButton_qunfa_qq_enter_ctrl";
            this.radioButton_qunfa_qq_enter_ctrl.Size = new System.Drawing.Size(130, 23);
            this.radioButton_qunfa_qq_enter_ctrl.TabIndex = 5;
            this.radioButton_qunfa_qq_enter_ctrl.Text = "Ctrl+Enter键发送";
            this.radioButton_qunfa_qq_enter_ctrl.UseVisualStyleBackColor = true;
            // 
            // radioButton_qunfa_qq_enter
            // 
            this.radioButton_qunfa_qq_enter.AutoSize = true;
            this.radioButton_qunfa_qq_enter.Checked = true;
            this.radioButton_qunfa_qq_enter.Location = new System.Drawing.Point(7, 179);
            this.radioButton_qunfa_qq_enter.Name = "radioButton_qunfa_qq_enter";
            this.radioButton_qunfa_qq_enter.Size = new System.Drawing.Size(98, 23);
            this.radioButton_qunfa_qq_enter.TabIndex = 5;
            this.radioButton_qunfa_qq_enter.TabStop = true;
            this.radioButton_qunfa_qq_enter.Text = "Enter键发送";
            this.radioButton_qunfa_qq_enter.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_qq_zuixiaohua
            // 
            this.checkBox_qunfa_qq_zuixiaohua.AutoSize = true;
            this.checkBox_qunfa_qq_zuixiaohua.BackColor = System.Drawing.Color.White;
            this.checkBox_qunfa_qq_zuixiaohua.Location = new System.Drawing.Point(97, 0);
            this.checkBox_qunfa_qq_zuixiaohua.Name = "checkBox_qunfa_qq_zuixiaohua";
            this.checkBox_qunfa_qq_zuixiaohua.Size = new System.Drawing.Size(145, 23);
            this.checkBox_qunfa_qq_zuixiaohua.TabIndex = 4;
            this.checkBox_qunfa_qq_zuixiaohua.Text = "发送结束最小化软件";
            this.checkBox_qunfa_qq_zuixiaohua.UseVisualStyleBackColor = false;
            // 
            // checkBox_qunfa_qq_str_suiji
            // 
            this.checkBox_qunfa_qq_str_suiji.AutoSize = true;
            this.checkBox_qunfa_qq_str_suiji.Location = new System.Drawing.Point(7, 153);
            this.checkBox_qunfa_qq_str_suiji.Name = "checkBox_qunfa_qq_str_suiji";
            this.checkBox_qunfa_qq_str_suiji.Size = new System.Drawing.Size(158, 23);
            this.checkBox_qunfa_qq_str_suiji.TabIndex = 3;
            this.checkBox_qunfa_qq_str_suiji.Text = "群发送结尾加随机字符";
            this.checkBox_qunfa_qq_str_suiji.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_qq_str_times
            // 
            this.checkBox_qunfa_qq_str_times.AutoSize = true;
            this.checkBox_qunfa_qq_str_times.Location = new System.Drawing.Point(7, 132);
            this.checkBox_qunfa_qq_str_times.Name = "checkBox_qunfa_qq_str_times";
            this.checkBox_qunfa_qq_str_times.Size = new System.Drawing.Size(158, 23);
            this.checkBox_qunfa_qq_str_times.TabIndex = 3;
            this.checkBox_qunfa_qq_str_times.Text = "群发送结尾加当前时间";
            this.checkBox_qunfa_qq_str_times.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_qq_guanbi
            // 
            this.checkBox_qunfa_qq_guanbi.AutoSize = true;
            this.checkBox_qunfa_qq_guanbi.Location = new System.Drawing.Point(7, 114);
            this.checkBox_qunfa_qq_guanbi.Name = "checkBox_qunfa_qq_guanbi";
            this.checkBox_qunfa_qq_guanbi.Size = new System.Drawing.Size(145, 23);
            this.checkBox_qunfa_qq_guanbi.TabIndex = 3;
            this.checkBox_qunfa_qq_guanbi.Text = "发送完关闭聊天窗口";
            this.checkBox_qunfa_qq_guanbi.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(207, 81);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 19);
            this.label29.TabIndex = 2;
            this.label29.Text = "毫秒";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(206, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 19);
            this.label27.TabIndex = 2;
            this.label27.Text = "毫秒";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(207, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 19);
            this.label25.TabIndex = 2;
            this.label25.Text = "毫秒";
            // 
            // textBox_qunfa_qq_peizhi_fasong_times
            // 
            this.textBox_qunfa_qq_peizhi_fasong_times.Location = new System.Drawing.Point(123, 78);
            this.textBox_qunfa_qq_peizhi_fasong_times.Name = "textBox_qunfa_qq_peizhi_fasong_times";
            this.textBox_qunfa_qq_peizhi_fasong_times.Size = new System.Drawing.Size(77, 25);
            this.textBox_qunfa_qq_peizhi_fasong_times.TabIndex = 1;
            this.textBox_qunfa_qq_peizhi_fasong_times.Text = "500";
            // 
            // textBox_qunfa_qq_peizhi_zhantietimes
            // 
            this.textBox_qunfa_qq_peizhi_zhantietimes.Location = new System.Drawing.Point(123, 52);
            this.textBox_qunfa_qq_peizhi_zhantietimes.Name = "textBox_qunfa_qq_peizhi_zhantietimes";
            this.textBox_qunfa_qq_peizhi_zhantietimes.Size = new System.Drawing.Size(77, 25);
            this.textBox_qunfa_qq_peizhi_zhantietimes.TabIndex = 1;
            this.textBox_qunfa_qq_peizhi_zhantietimes.Text = "500";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 19);
            this.label28.TabIndex = 0;
            this.label28.Text = "发送消息延时：";
            // 
            // textBox_qunfa_qq_peizhi_qiehuan_times
            // 
            this.textBox_qunfa_qq_peizhi_qiehuan_times.Location = new System.Drawing.Point(123, 25);
            this.textBox_qunfa_qq_peizhi_qiehuan_times.Name = "textBox_qunfa_qq_peizhi_qiehuan_times";
            this.textBox_qunfa_qq_peizhi_qiehuan_times.Size = new System.Drawing.Size(77, 25);
            this.textBox_qunfa_qq_peizhi_qiehuan_times.TabIndex = 1;
            this.textBox_qunfa_qq_peizhi_qiehuan_times.Text = "500";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 19);
            this.label26.TabIndex = 0;
            this.label26.Text = "粘贴消息延时：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "切换窗口延时：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_qunfa_qq_list);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(250, 220);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "群发列表";
            // 
            // dataGridView_qunfa_qq_list
            // 
            this.dataGridView_qunfa_qq_list.AllowUserToAddRows = false;
            this.dataGridView_qunfa_qq_list.AllowUserToDeleteRows = false;
            this.dataGridView_qunfa_qq_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_qunfa_qq_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_qunfa_qq_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_qqname,
            this.Column1});
            this.dataGridView_qunfa_qq_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_qunfa_qq_list.Location = new System.Drawing.Point(0, 18);
            this.dataGridView_qunfa_qq_list.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_qunfa_qq_list.Name = "dataGridView_qunfa_qq_list";
            this.dataGridView_qunfa_qq_list.ReadOnly = true;
            this.dataGridView_qunfa_qq_list.RowHeadersWidth = 45;
            this.dataGridView_qunfa_qq_list.RowTemplate.Height = 23;
            this.dataGridView_qunfa_qq_list.Size = new System.Drawing.Size(250, 172);
            this.dataGridView_qunfa_qq_list.TabIndex = 1;
            // 
            // Column_qqname
            // 
            this.Column_qqname.HeaderText = "QQ群名称";
            this.Column_qqname.Name = "Column_qqname";
            this.Column_qqname.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "排序";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_qunfa_open_mulu);
            this.panel5.Controls.Add(this.button_qunfa_open_qun);
            this.panel5.Controls.Add(this.button_qunfa_qq_shuaxin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 190);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 30);
            this.panel5.TabIndex = 0;
            // 
            // button_qunfa_open_mulu
            // 
            this.button_qunfa_open_mulu.Location = new System.Drawing.Point(166, 0);
            this.button_qunfa_open_mulu.Margin = new System.Windows.Forms.Padding(0);
            this.button_qunfa_open_mulu.Name = "button_qunfa_open_mulu";
            this.button_qunfa_open_mulu.Size = new System.Drawing.Size(83, 28);
            this.button_qunfa_open_mulu.TabIndex = 0;
            this.button_qunfa_open_mulu.Text = "打开文件夹";
            this.button_qunfa_open_mulu.UseVisualStyleBackColor = true;
            this.button_qunfa_open_mulu.Click += new System.EventHandler(this.button_qunfa_open_mulu_Click);
            // 
            // button_qunfa_open_qun
            // 
            this.button_qunfa_open_qun.Location = new System.Drawing.Point(80, 0);
            this.button_qunfa_open_qun.Margin = new System.Windows.Forms.Padding(0);
            this.button_qunfa_open_qun.Name = "button_qunfa_open_qun";
            this.button_qunfa_open_qun.Size = new System.Drawing.Size(83, 28);
            this.button_qunfa_open_qun.TabIndex = 0;
            this.button_qunfa_open_qun.Text = "打开所有群";
            this.button_qunfa_open_qun.UseVisualStyleBackColor = true;
            this.button_qunfa_open_qun.Click += new System.EventHandler(this.button_qunfa_open_qun_Click);
            // 
            // button_qunfa_qq_shuaxin
            // 
            this.button_qunfa_qq_shuaxin.Location = new System.Drawing.Point(2, 0);
            this.button_qunfa_qq_shuaxin.Margin = new System.Windows.Forms.Padding(0);
            this.button_qunfa_qq_shuaxin.Name = "button_qunfa_qq_shuaxin";
            this.button_qunfa_qq_shuaxin.Size = new System.Drawing.Size(75, 28);
            this.button_qunfa_qq_shuaxin.TabIndex = 0;
            this.button_qunfa_qq_shuaxin.Text = "刷新群列表";
            this.button_qunfa_qq_shuaxin.UseVisualStyleBackColor = true;
            this.button_qunfa_qq_shuaxin.Click += new System.EventHandler(this.button_qunfa_qq_shuaxin_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.panel8);
            this.tabPage9.Controls.Add(this.panel7);
            this.tabPage9.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage9.Location = new System.Drawing.Point(4, 28);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(856, 226);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "微信群发配置";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tabControl1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(856, 191);
            this.panel8.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage17);
            this.tabControl1.Controls.Add(this.tabPage18);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 191);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.groupBox15);
            this.tabPage17.Controls.Add(this.groupBox4);
            this.tabPage17.Location = new System.Drawing.Point(27, 4);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(825, 183);
            this.tabPage17.TabIndex = 0;
            this.tabPage17.Text = "前台模式";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label31);
            this.groupBox15.Controls.Add(this.textBox_qunfa_weixin_fatu_times);
            this.groupBox15.Controls.Add(this.label30);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(253, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(569, 177);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "微信配置";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(211, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 19);
            this.label31.TabIndex = 5;
            this.label31.Text = "毫秒";
            // 
            // textBox_qunfa_weixin_fatu_times
            // 
            this.textBox_qunfa_weixin_fatu_times.Location = new System.Drawing.Point(127, 18);
            this.textBox_qunfa_weixin_fatu_times.Name = "textBox_qunfa_weixin_fatu_times";
            this.textBox_qunfa_weixin_fatu_times.Size = new System.Drawing.Size(77, 25);
            this.textBox_qunfa_weixin_fatu_times.TabIndex = 4;
            this.textBox_qunfa_weixin_fatu_times.Text = "1000";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 19);
            this.label30.TabIndex = 3;
            this.label30.Text = "微信图片延时：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_qunfa_weixin_list);
            this.groupBox4.Controls.Add(this.button_qunfa_weixin_huoqu);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(250, 177);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "微信群列表";
            // 
            // dataGridView_qunfa_weixin_list
            // 
            this.dataGridView_qunfa_weixin_list.AllowUserToAddRows = false;
            this.dataGridView_qunfa_weixin_list.AllowUserToDeleteRows = false;
            this.dataGridView_qunfa_weixin_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_qunfa_weixin_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_qunfa_weixin_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView_qunfa_weixin_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_qunfa_weixin_list.Location = new System.Drawing.Point(0, 18);
            this.dataGridView_qunfa_weixin_list.Name = "dataGridView_qunfa_weixin_list";
            this.dataGridView_qunfa_weixin_list.ReadOnly = true;
            this.dataGridView_qunfa_weixin_list.RowHeadersWidth = 48;
            this.dataGridView_qunfa_weixin_list.RowTemplate.Height = 23;
            this.dataGridView_qunfa_weixin_list.Size = new System.Drawing.Size(250, 131);
            this.dataGridView_qunfa_weixin_list.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "微信群名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button_qunfa_weixin_huoqu
            // 
            this.button_qunfa_weixin_huoqu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_qunfa_weixin_huoqu.Location = new System.Drawing.Point(0, 149);
            this.button_qunfa_weixin_huoqu.Name = "button_qunfa_weixin_huoqu";
            this.button_qunfa_weixin_huoqu.Size = new System.Drawing.Size(250, 28);
            this.button_qunfa_weixin_huoqu.TabIndex = 0;
            this.button_qunfa_weixin_huoqu.Text = "识别所有单独拖出窗口微信群";
            this.button_qunfa_weixin_huoqu.UseVisualStyleBackColor = true;
            this.button_qunfa_weixin_huoqu.Click += new System.EventHandler(this.button_qunfa_weixin_huoqu_Click);
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.groupBox25);
            this.tabPage18.Controls.Add(this.groupBox24);
            this.tabPage18.Location = new System.Drawing.Point(27, 4);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(825, 183);
            this.tabPage18.TabIndex = 1;
            this.tabPage18.Text = "后台模式";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox25.Location = new System.Drawing.Point(203, 3);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(619, 177);
            this.groupBox25.TabIndex = 2;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "其他配置";
            // 
            // groupBox24
            // 
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox24.Location = new System.Drawing.Point(3, 3);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(200, 177);
            this.groupBox24.TabIndex = 1;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "微信发送群设置";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox22);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(856, 35);
            this.panel7.TabIndex = 0;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.radioButton_fasong_weixin_fashi_houtai);
            this.groupBox22.Controls.Add(this.radioButton_fasong_weixin_fashi_qiantai);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox22.Location = new System.Drawing.Point(0, 0);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(856, 35);
            this.groupBox22.TabIndex = 0;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "发送模式";
            // 
            // radioButton_fasong_weixin_fashi_houtai
            // 
            this.radioButton_fasong_weixin_fashi_houtai.AutoSize = true;
            this.radioButton_fasong_weixin_fashi_houtai.Location = new System.Drawing.Point(197, 12);
            this.radioButton_fasong_weixin_fashi_houtai.Name = "radioButton_fasong_weixin_fashi_houtai";
            this.radioButton_fasong_weixin_fashi_houtai.Size = new System.Drawing.Size(79, 23);
            this.radioButton_fasong_weixin_fashi_houtai.TabIndex = 0;
            this.radioButton_fasong_weixin_fashi_houtai.TabStop = true;
            this.radioButton_fasong_weixin_fashi_houtai.Text = "后台发送";
            this.radioButton_fasong_weixin_fashi_houtai.UseVisualStyleBackColor = true;
            this.radioButton_fasong_weixin_fashi_houtai.CheckedChanged += new System.EventHandler(this.radioButton_fasong_weixin_fashi_houtai_CheckedChanged);
            // 
            // radioButton_fasong_weixin_fashi_qiantai
            // 
            this.radioButton_fasong_weixin_fashi_qiantai.AutoSize = true;
            this.radioButton_fasong_weixin_fashi_qiantai.Location = new System.Drawing.Point(73, 11);
            this.radioButton_fasong_weixin_fashi_qiantai.Name = "radioButton_fasong_weixin_fashi_qiantai";
            this.radioButton_fasong_weixin_fashi_qiantai.Size = new System.Drawing.Size(79, 23);
            this.radioButton_fasong_weixin_fashi_qiantai.TabIndex = 0;
            this.radioButton_fasong_weixin_fashi_qiantai.TabStop = true;
            this.radioButton_fasong_weixin_fashi_qiantai.Text = "前台发送";
            this.radioButton_fasong_weixin_fashi_qiantai.UseVisualStyleBackColor = true;
            this.radioButton_fasong_weixin_fashi_qiantai.CheckedChanged += new System.EventHandler(this.radioButton_fasong_weixin_fashi_qiantai_CheckedChanged);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.groupBox12);
            this.tabPage10.Controls.Add(this.groupBox11);
            this.tabPage10.Location = new System.Drawing.Point(4, 28);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(856, 226);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "手动群发";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button_qunfa_shoudong_gengfa);
            this.groupBox12.Controls.Add(this.button_qunfa_shoudong_fasong);
            this.groupBox12.Controls.Add(this.button_qunfa_shoudong_qingkong);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(596, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(260, 226);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "发送控制区";
            // 
            // button_qunfa_shoudong_gengfa
            // 
            this.button_qunfa_shoudong_gengfa.Location = new System.Drawing.Point(29, 115);
            this.button_qunfa_shoudong_gengfa.Name = "button_qunfa_shoudong_gengfa";
            this.button_qunfa_shoudong_gengfa.Size = new System.Drawing.Size(102, 29);
            this.button_qunfa_shoudong_gengfa.TabIndex = 1;
            this.button_qunfa_shoudong_gengfa.Text = "添加到群发";
            this.button_qunfa_shoudong_gengfa.UseVisualStyleBackColor = true;
            this.button_qunfa_shoudong_gengfa.Click += new System.EventHandler(this.button_qunfa_shoudong_gengfa_Click);
            // 
            // button_qunfa_shoudong_fasong
            // 
            this.button_qunfa_shoudong_fasong.Location = new System.Drawing.Point(29, 68);
            this.button_qunfa_shoudong_fasong.Name = "button_qunfa_shoudong_fasong";
            this.button_qunfa_shoudong_fasong.Size = new System.Drawing.Size(75, 27);
            this.button_qunfa_shoudong_fasong.TabIndex = 0;
            this.button_qunfa_shoudong_fasong.Text = "立即发送";
            this.button_qunfa_shoudong_fasong.UseVisualStyleBackColor = true;
            this.button_qunfa_shoudong_fasong.Click += new System.EventHandler(this.button_qunfa_shoudong_fasong_Click);
            // 
            // button_qunfa_shoudong_qingkong
            // 
            this.button_qunfa_shoudong_qingkong.Location = new System.Drawing.Point(29, 26);
            this.button_qunfa_shoudong_qingkong.Name = "button_qunfa_shoudong_qingkong";
            this.button_qunfa_shoudong_qingkong.Size = new System.Drawing.Size(75, 27);
            this.button_qunfa_shoudong_qingkong.TabIndex = 0;
            this.button_qunfa_shoudong_qingkong.Text = "清空";
            this.button_qunfa_shoudong_qingkong.UseVisualStyleBackColor = true;
            this.button_qunfa_shoudong_qingkong.Click += new System.EventHandler(this.button_qunfa_shoudong_qingkong_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox11.Controls.Add(this.webBrowser_send_content);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(596, 226);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "内容编辑区(复制图片失败,请用QQ截图再粘贴)";
            // 
            // webBrowser_send_content
            // 
            this.webBrowser_send_content.ContextMenuStrip = this.contextMenuStripCtEdit;
            this.webBrowser_send_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_send_content.Location = new System.Drawing.Point(3, 21);
            this.webBrowser_send_content.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser_send_content.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_send_content.Name = "webBrowser_send_content";
            this.webBrowser_send_content.Size = new System.Drawing.Size(590, 202);
            this.webBrowser_send_content.TabIndex = 0;
            this.webBrowser_send_content.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // contextMenuStripCtEdit
            // 
            this.contextMenuStripCtEdit.Name = "contextMenuStripCtEdit";
            this.contextMenuStripCtEdit.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.groupBox28);
            this.tabPage15.Controls.Add(this.groupBox19);
            this.tabPage15.Location = new System.Drawing.Point(4, 28);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(856, 226);
            this.tabPage15.TabIndex = 4;
            this.tabPage15.Text = "微博群发配置";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.button_weibo);
            this.groupBox28.Controls.Add(this.textBox_weibo_pwd);
            this.groupBox28.Controls.Add(this.textBox_weibo_name);
            this.groupBox28.Controls.Add(this.label44);
            this.groupBox28.Controls.Add(this.label43);
            this.groupBox28.Location = new System.Drawing.Point(368, 3);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(293, 227);
            this.groupBox28.TabIndex = 1;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "配置";
            // 
            // button_weibo
            // 
            this.button_weibo.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_weibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_weibo.ForeColor = System.Drawing.Color.White;
            this.button_weibo.Location = new System.Drawing.Point(11, 111);
            this.button_weibo.Name = "button_weibo";
            this.button_weibo.Size = new System.Drawing.Size(84, 33);
            this.button_weibo.TabIndex = 2;
            this.button_weibo.Text = "保存";
            this.button_weibo.UseVisualStyleBackColor = false;
            this.button_weibo.Click += new System.EventHandler(this.button_weibo_Click);
            // 
            // textBox_weibo_pwd
            // 
            this.textBox_weibo_pwd.Location = new System.Drawing.Point(73, 55);
            this.textBox_weibo_pwd.Name = "textBox_weibo_pwd";
            this.textBox_weibo_pwd.Size = new System.Drawing.Size(191, 25);
            this.textBox_weibo_pwd.TabIndex = 1;
            // 
            // textBox_weibo_name
            // 
            this.textBox_weibo_name.Location = new System.Drawing.Point(73, 24);
            this.textBox_weibo_name.Name = "textBox_weibo_name";
            this.textBox_weibo_name.Size = new System.Drawing.Size(191, 25);
            this.textBox_weibo_name.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 57);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(48, 19);
            this.label44.TabIndex = 0;
            this.label44.Text = "密码：";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(7, 25);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(61, 19);
            this.label43.TabIndex = 0;
            this.label43.Text = "用户名：";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dataGridView_weibo);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(329, 226);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "微博账号设置";
            // 
            // dataGridView_weibo
            // 
            this.dataGridView_weibo.AllowUserToAddRows = false;
            this.dataGridView_weibo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_weibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_weibo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.status});
            this.dataGridView_weibo.ContextMenuStrip = this.contextMenuStrip_weibo;
            this.dataGridView_weibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_weibo.Location = new System.Drawing.Point(3, 21);
            this.dataGridView_weibo.Name = "dataGridView_weibo";
            this.dataGridView_weibo.ReadOnly = true;
            this.dataGridView_weibo.RowTemplate.Height = 23;
            this.dataGridView_weibo.Size = new System.Drawing.Size(323, 202);
            this.dataGridView_weibo.TabIndex = 0;
            // 
            // name
            // 
            this.name.FillWeight = 200F;
            this.name.HeaderText = "账号";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // contextMenuStrip_weibo
            // 
            this.contextMenuStrip_weibo.Name = "contextMenuStrip_weibo";
            this.contextMenuStrip_weibo.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.tabControl2);
            this.tabPage19.Location = new System.Drawing.Point(4, 28);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Size = new System.Drawing.Size(856, 226);
            this.tabPage19.TabIndex = 5;
            this.tabPage19.Text = "采集群配置";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage20);
            this.tabControl2.Controls.Add(this.tabPage21);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(856, 226);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.panel9);
            this.tabPage20.Controls.Add(this.groupBox26);
            this.tabPage20.Location = new System.Drawing.Point(4, 28);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage20.Size = new System.Drawing.Size(848, 194);
            this.tabPage20.TabIndex = 0;
            this.tabPage20.Text = "群监控";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox23);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(225, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(620, 188);
            this.panel9.TabIndex = 1;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.linkLabel9);
            this.groupBox23.Controls.Add(this.linkLabel8);
            this.groupBox23.Controls.Add(this.label42);
            this.groupBox23.Controls.Add(this.label41);
            this.groupBox23.Controls.Add(this.textBox_qun_del);
            this.groupBox23.Controls.Add(this.textBox_qun_guolv);
            this.groupBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox23.Location = new System.Drawing.Point(0, 0);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(620, 188);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "监控设置";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(435, 30);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(61, 19);
            this.linkLabel9.TabIndex = 3;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "恢复默认";
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(163, 30);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(61, 19);
            this.linkLabel8.TabIndex = 2;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "恢复默认";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(238, 21);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(181, 19);
            this.label42.TabIndex = 1;
            this.label42.Text = "包含以下信息的行下面都过滤:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 21);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(142, 19);
            this.label41.TabIndex = 1;
            this.label41.Text = "过滤包含以下信息的行:";
            // 
            // textBox_qun_del
            // 
            this.textBox_qun_del.Location = new System.Drawing.Point(242, 47);
            this.textBox_qun_del.Multiline = true;
            this.textBox_qun_del.Name = "textBox_qun_del";
            this.textBox_qun_del.Size = new System.Drawing.Size(242, 128);
            this.textBox_qun_del.TabIndex = 0;
            this.textBox_qun_del.Leave += new System.EventHandler(this.textBox_qun_del_Leave);
            // 
            // textBox_qun_guolv
            // 
            this.textBox_qun_guolv.Location = new System.Drawing.Point(9, 48);
            this.textBox_qun_guolv.Multiline = true;
            this.textBox_qun_guolv.Name = "textBox_qun_guolv";
            this.textBox_qun_guolv.Size = new System.Drawing.Size(226, 127);
            this.textBox_qun_guolv.TabIndex = 0;
            this.textBox_qun_guolv.Leave += new System.EventHandler(this.textBox_qun_guolv_Leave);
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.label51);
            this.groupBox26.Controls.Add(this.textBox_qun_list);
            this.groupBox26.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox26.Location = new System.Drawing.Point(3, 3);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(222, 188);
            this.groupBox26.TabIndex = 0;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "填写需要监控群";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(120, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(61, 19);
            this.label51.TabIndex = 1;
            this.label51.Text = "填写群号";
            // 
            // textBox_qun_list
            // 
            this.textBox_qun_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_qun_list.Location = new System.Drawing.Point(3, 21);
            this.textBox_qun_list.Multiline = true;
            this.textBox_qun_list.Name = "textBox_qun_list";
            this.textBox_qun_list.Size = new System.Drawing.Size(216, 164);
            this.textBox_qun_list.TabIndex = 0;
            this.textBox_qun_list.Leave += new System.EventHandler(this.textBox_qun_list_Leave);
            // 
            // tabPage21
            // 
            this.tabPage21.Controls.Add(this.groupBox27);
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Size = new System.Drawing.Size(848, 200);
            this.tabPage21.TabIndex = 1;
            this.tabPage21.Text = "日志";
            this.tabPage21.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.richTextBox_qq_log);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox27.Location = new System.Drawing.Point(0, 0);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(848, 200);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "运行监控";
            // 
            // richTextBox_qq_log
            // 
            this.richTextBox_qq_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_qq_log.Location = new System.Drawing.Point(3, 21);
            this.richTextBox_qq_log.Name = "richTextBox_qq_log";
            this.richTextBox_qq_log.Size = new System.Drawing.Size(842, 176);
            this.richTextBox_qq_log.TabIndex = 0;
            this.richTextBox_qq_log.Text = "";
            // 
            // tabPage22
            // 
            this.tabPage22.Controls.Add(this.tabControl3);
            this.tabPage22.Location = new System.Drawing.Point(4, 28);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Size = new System.Drawing.Size(856, 226);
            this.tabPage22.TabIndex = 6;
            this.tabPage22.Text = "分群配置";
            this.tabPage22.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage23);
            this.tabControl3.Controls.Add(this.tabPage24);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(856, 226);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage23
            // 
            this.tabPage23.Controls.Add(this.groupBox30);
            this.tabPage23.Controls.Add(this.dataGridView_fenqun_qq);
            this.tabPage23.Location = new System.Drawing.Point(4, 28);
            this.tabPage23.Name = "tabPage23";
            this.tabPage23.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage23.Size = new System.Drawing.Size(848, 194);
            this.tabPage23.TabIndex = 0;
            this.tabPage23.Text = "qq群配置";
            this.tabPage23.UseVisualStyleBackColor = true;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.textBox_fenqun_qq_weiba);
            this.groupBox30.Controls.Add(this.label49);
            this.groupBox30.Controls.Add(this.button31);
            this.groupBox30.Controls.Add(this.button2);
            this.groupBox30.Controls.Add(this.textBox_fenqun_qq_pid);
            this.groupBox30.Controls.Add(this.textBox_fenqun_qq_name);
            this.groupBox30.Controls.Add(this.label46);
            this.groupBox30.Controls.Add(this.label45);
            this.groupBox30.Location = new System.Drawing.Point(3, 3);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(360, 181);
            this.groupBox30.TabIndex = 2;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "qq分群配置";
            // 
            // textBox_fenqun_qq_weiba
            // 
            this.textBox_fenqun_qq_weiba.Location = new System.Drawing.Point(6, 111);
            this.textBox_fenqun_qq_weiba.Multiline = true;
            this.textBox_fenqun_qq_weiba.Name = "textBox_fenqun_qq_weiba";
            this.textBox_fenqun_qq_weiba.Size = new System.Drawing.Size(238, 64);
            this.textBox_fenqun_qq_weiba.TabIndex = 5;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 89);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(87, 19);
            this.label49.TabIndex = 4;
            this.label49.Text = "加群发尾巴：";
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.DodgerBlue;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(246, 22);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(78, 23);
            this.button31.TabIndex = 3;
            this.button31.Text = "选择q群";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(249, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_5);
            // 
            // textBox_fenqun_qq_pid
            // 
            this.textBox_fenqun_qq_pid.Location = new System.Drawing.Point(75, 52);
            this.textBox_fenqun_qq_pid.Name = "textBox_fenqun_qq_pid";
            this.textBox_fenqun_qq_pid.Size = new System.Drawing.Size(165, 25);
            this.textBox_fenqun_qq_pid.TabIndex = 1;
            // 
            // textBox_fenqun_qq_name
            // 
            this.textBox_fenqun_qq_name.Location = new System.Drawing.Point(75, 22);
            this.textBox_fenqun_qq_name.Name = "textBox_fenqun_qq_name";
            this.textBox_fenqun_qq_name.Size = new System.Drawing.Size(165, 25);
            this.textBox_fenqun_qq_name.TabIndex = 1;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 55);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(41, 19);
            this.label46.TabIndex = 0;
            this.label46.Text = "pid：";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(7, 25);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 19);
            this.label45.TabIndex = 0;
            this.label45.Text = "群名称：";
            // 
            // dataGridView_fenqun_qq
            // 
            this.dataGridView_fenqun_qq.AllowUserToAddRows = false;
            this.dataGridView_fenqun_qq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_fenqun_qq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fenqun_qq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dataGridView_fenqun_qq.ContextMenuStrip = this.contextMenuStrip_pid_qq;
            this.dataGridView_fenqun_qq.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_fenqun_qq.Location = new System.Drawing.Point(385, 3);
            this.dataGridView_fenqun_qq.Name = "dataGridView_fenqun_qq";
            this.dataGridView_fenqun_qq.RowTemplate.ContextMenuStrip = this.contextMenuStrip_pid_qq;
            this.dataGridView_fenqun_qq.RowTemplate.Height = 23;
            this.dataGridView_fenqun_qq.Size = new System.Drawing.Size(460, 188);
            this.dataGridView_fenqun_qq.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "名称";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "pid";
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip_pid_qq
            // 
            this.contextMenuStrip_pid_qq.Name = "contextMenuStrip_pid_qq";
            this.contextMenuStrip_pid_qq.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage24
            // 
            this.tabPage24.Controls.Add(this.groupBox31);
            this.tabPage24.Controls.Add(this.dataGridView_fenqun_weixin);
            this.tabPage24.Location = new System.Drawing.Point(4, 22);
            this.tabPage24.Name = "tabPage24";
            this.tabPage24.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage24.Size = new System.Drawing.Size(848, 200);
            this.tabPage24.TabIndex = 1;
            this.tabPage24.Text = "微信群配置";
            this.tabPage24.UseVisualStyleBackColor = true;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.textBox_fenqun_weixin_weiba);
            this.groupBox31.Controls.Add(this.label50);
            this.groupBox31.Controls.Add(this.button32);
            this.groupBox31.Controls.Add(this.button30);
            this.groupBox31.Controls.Add(this.textBox_fenqun_weixin_pid);
            this.groupBox31.Controls.Add(this.textBox_fenqun_weixin_name);
            this.groupBox31.Controls.Add(this.label47);
            this.groupBox31.Controls.Add(this.label48);
            this.groupBox31.Location = new System.Drawing.Point(3, 3);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(349, 191);
            this.groupBox31.TabIndex = 2;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "微信分群配置";
            // 
            // textBox_fenqun_weixin_weiba
            // 
            this.textBox_fenqun_weixin_weiba.Location = new System.Drawing.Point(11, 122);
            this.textBox_fenqun_weixin_weiba.Multiline = true;
            this.textBox_fenqun_weixin_weiba.Name = "textBox_fenqun_weixin_weiba";
            this.textBox_fenqun_weixin_weiba.Size = new System.Drawing.Size(227, 63);
            this.textBox_fenqun_weixin_weiba.TabIndex = 7;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(7, 91);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(87, 19);
            this.label50.TabIndex = 6;
            this.label50.Text = "加群发尾巴：";
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.DodgerBlue;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button32.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(249, 25);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(81, 23);
            this.button32.TabIndex = 3;
            this.button32.Text = "选择微信群";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.DodgerBlue;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(245, 152);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 3;
            this.button30.Text = "保存";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click_1);
            // 
            // textBox_fenqun_weixin_pid
            // 
            this.textBox_fenqun_weixin_pid.Location = new System.Drawing.Point(75, 52);
            this.textBox_fenqun_weixin_pid.Name = "textBox_fenqun_weixin_pid";
            this.textBox_fenqun_weixin_pid.Size = new System.Drawing.Size(165, 25);
            this.textBox_fenqun_weixin_pid.TabIndex = 1;
            // 
            // textBox_fenqun_weixin_name
            // 
            this.textBox_fenqun_weixin_name.Location = new System.Drawing.Point(75, 22);
            this.textBox_fenqun_weixin_name.Name = "textBox_fenqun_weixin_name";
            this.textBox_fenqun_weixin_name.Size = new System.Drawing.Size(165, 25);
            this.textBox_fenqun_weixin_name.TabIndex = 1;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 19);
            this.label47.TabIndex = 0;
            this.label47.Text = "pid：";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(7, 25);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(61, 19);
            this.label48.TabIndex = 0;
            this.label48.Text = "群名称：";
            // 
            // dataGridView_fenqun_weixin
            // 
            this.dataGridView_fenqun_weixin.AllowUserToAddRows = false;
            this.dataGridView_fenqun_weixin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_fenqun_weixin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fenqun_weixin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_fenqun_weixin.ContextMenuStrip = this.contextMenuStrip_pid_weixin;
            this.dataGridView_fenqun_weixin.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_fenqun_weixin.Location = new System.Drawing.Point(383, 3);
            this.dataGridView_fenqun_weixin.Name = "dataGridView_fenqun_weixin";
            this.dataGridView_fenqun_weixin.RowTemplate.Height = 23;
            this.dataGridView_fenqun_weixin.Size = new System.Drawing.Size(462, 194);
            this.dataGridView_fenqun_weixin.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "pid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // contextMenuStrip_pid_weixin
            // 
            this.contextMenuStrip_pid_weixin.Name = "contextMenuStrip_pid_weixin";
            this.contextMenuStrip_pid_weixin.Size = new System.Drawing.Size(61, 4);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(864, 99);
            this.panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label59);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.comboBox_cj_pinlv);
            this.groupBox2.Controls.Add(this.checkBox_gengfa_qq);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox_qunfa_top);
            this.groupBox2.Controls.Add(this.checkBox_haopintui);
            this.groupBox2.Controls.Add(this.checkBox_qunfa_weibo_boolean);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.checkBox_qunfa_weixin_boolean);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox_qunfa_qq_boolean);
            this.groupBox2.Controls.Add(this.button_qunfa_start);
            this.groupBox2.Controls.Add(this.buttonFollowSndStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "群发控制台";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(454, 52);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(32, 17);
            this.label59.TabIndex = 10;
            this.label59.Text = "频率";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label58.Location = new System.Drawing.Point(535, 52);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(32, 17);
            this.label58.TabIndex = 10;
            this.label58.Text = "分钟";
            // 
            // comboBox_cj_pinlv
            // 
            this.comboBox_cj_pinlv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_cj_pinlv.FormattingEnabled = true;
            this.comboBox_cj_pinlv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox_cj_pinlv.Location = new System.Drawing.Point(491, 48);
            this.comboBox_cj_pinlv.Name = "comboBox_cj_pinlv";
            this.comboBox_cj_pinlv.Size = new System.Drawing.Size(38, 25);
            this.comboBox_cj_pinlv.TabIndex = 9;
            this.comboBox_cj_pinlv.SelectedIndexChanged += new System.EventHandler(this.comboBox_cj_pinlv_SelectedIndexChanged);
            // 
            // checkBox_gengfa_qq
            // 
            this.checkBox_gengfa_qq.AutoSize = true;
            this.checkBox_gengfa_qq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_gengfa_qq.Location = new System.Drawing.Point(585, 52);
            this.checkBox_gengfa_qq.Name = "checkBox_gengfa_qq";
            this.checkBox_gengfa_qq.Size = new System.Drawing.Size(79, 21);
            this.checkBox_gengfa_qq.TabIndex = 1;
            this.checkBox_gengfa_qq.Text = "qq群采集";
            this.checkBox_gengfa_qq.UseVisualStyleBackColor = true;
            this.checkBox_gengfa_qq.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_gengfa_qq_MouseClick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(290, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(231, 21);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "全网商品（搭配超级买家系统后可用）";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(197, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "淘宝、天猫";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_top
            // 
            this.checkBox_qunfa_top.AutoSize = true;
            this.checkBox_qunfa_top.Checked = true;
            this.checkBox_qunfa_top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_qunfa_top.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_qunfa_top.Location = new System.Drawing.Point(382, 51);
            this.checkBox_qunfa_top.Name = "checkBox_qunfa_top";
            this.checkBox_qunfa_top.Size = new System.Drawing.Size(75, 21);
            this.checkBox_qunfa_top.TabIndex = 1;
            this.checkBox_qunfa_top.Text = "全网热门";
            this.checkBox_qunfa_top.UseVisualStyleBackColor = true;
            // 
            // checkBox_haopintui
            // 
            this.checkBox_haopintui.AutoSize = true;
            this.checkBox_haopintui.Checked = true;
            this.checkBox_haopintui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_haopintui.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_haopintui.Location = new System.Drawing.Point(273, 51);
            this.checkBox_haopintui.Name = "checkBox_haopintui";
            this.checkBox_haopintui.Size = new System.Drawing.Size(111, 21);
            this.checkBox_haopintui.TabIndex = 1;
            this.checkBox_haopintui.Text = "好品推官方直播";
            this.checkBox_haopintui.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_weibo_boolean
            // 
            this.checkBox_qunfa_weibo_boolean.AutoSize = true;
            this.checkBox_qunfa_weibo_boolean.Location = new System.Drawing.Point(331, 20);
            this.checkBox_qunfa_weibo_boolean.Name = "checkBox_qunfa_weibo_boolean";
            this.checkBox_qunfa_weibo_boolean.Size = new System.Drawing.Size(54, 23);
            this.checkBox_qunfa_weibo_boolean.TabIndex = 7;
            this.checkBox_qunfa_weibo_boolean.Text = "微博";
            this.checkBox_qunfa_weibo_boolean.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(114, 78);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(74, 19);
            this.label56.TabIndex = 8;
            this.label56.Text = "包含产品：";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(115, 50);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(74, 19);
            this.label55.TabIndex = 8;
            this.label55.Text = "采集对象：";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(117, 20);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(74, 19);
            this.label54.TabIndex = 8;
            this.label54.Text = "发送对象：";
            // 
            // checkBox_qunfa_weixin_boolean
            // 
            this.checkBox_qunfa_weixin_boolean.AutoSize = true;
            this.checkBox_qunfa_weixin_boolean.Checked = true;
            this.checkBox_qunfa_weixin_boolean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_qunfa_weixin_boolean.Location = new System.Drawing.Point(260, 20);
            this.checkBox_qunfa_weixin_boolean.Name = "checkBox_qunfa_weixin_boolean";
            this.checkBox_qunfa_weixin_boolean.Size = new System.Drawing.Size(67, 23);
            this.checkBox_qunfa_weixin_boolean.TabIndex = 7;
            this.checkBox_qunfa_weixin_boolean.Text = "微信群";
            this.checkBox_qunfa_weixin_boolean.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(197, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "手动选品";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_qq_boolean
            // 
            this.checkBox_qunfa_qq_boolean.AutoSize = true;
            this.checkBox_qunfa_qq_boolean.Checked = true;
            this.checkBox_qunfa_qq_boolean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_qunfa_qq_boolean.Location = new System.Drawing.Point(198, 20);
            this.checkBox_qunfa_qq_boolean.Name = "checkBox_qunfa_qq_boolean";
            this.checkBox_qunfa_qq_boolean.Size = new System.Drawing.Size(57, 23);
            this.checkBox_qunfa_qq_boolean.TabIndex = 6;
            this.checkBox_qunfa_qq_boolean.Text = "qq群";
            this.checkBox_qunfa_qq_boolean.UseVisualStyleBackColor = true;
            // 
            // button_qunfa_start
            // 
            this.button_qunfa_start.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_qunfa_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_qunfa_start.ForeColor = System.Drawing.Color.White;
            this.button_qunfa_start.Location = new System.Drawing.Point(13, 65);
            this.button_qunfa_start.Name = "button_qunfa_start";
            this.button_qunfa_start.Size = new System.Drawing.Size(89, 28);
            this.button_qunfa_start.TabIndex = 0;
            this.button_qunfa_start.Text = "开始群发";
            this.button_qunfa_start.UseVisualStyleBackColor = false;
            this.button_qunfa_start.Click += new System.EventHandler(this.button_qunfa_start_Click);
            // 
            // buttonFollowSndStart
            // 
            this.buttonFollowSndStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFollowSndStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFollowSndStart.ForeColor = System.Drawing.Color.White;
            this.buttonFollowSndStart.Location = new System.Drawing.Point(13, 24);
            this.buttonFollowSndStart.Name = "buttonFollowSndStart";
            this.buttonFollowSndStart.Size = new System.Drawing.Size(89, 28);
            this.buttonFollowSndStart.TabIndex = 0;
            this.buttonFollowSndStart.Text = "启动采集";
            this.buttonFollowSndStart.UseVisualStyleBackColor = false;
            this.buttonFollowSndStart.Click += new System.EventHandler(this.buttonFollowSndStart_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button_save_config_qunfa);
            this.tabPage6.Controls.Add(this.groupBox6);
            this.tabPage6.Controls.Add(this.groupBox7);
            this.tabPage6.Controls.Add(this.groupBox32);
            this.tabPage6.Controls.Add(this.groupBox8);
            this.tabPage6.Controls.Add(this.groupBox5);
            this.tabPage6.Location = new System.Drawing.Point(4, 14);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(864, 444);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button_save_config_qunfa
            // 
            this.button_save_config_qunfa.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_save_config_qunfa.ForeColor = System.Drawing.Color.White;
            this.button_save_config_qunfa.Location = new System.Drawing.Point(116, 324);
            this.button_save_config_qunfa.Name = "button_save_config_qunfa";
            this.button_save_config_qunfa.Size = new System.Drawing.Size(145, 39);
            this.button_save_config_qunfa.TabIndex = 1;
            this.button_save_config_qunfa.Text = "保存配置";
            this.button_save_config_qunfa.UseVisualStyleBackColor = false;
            this.button_save_config_qunfa.Click += new System.EventHandler(this.button_save_config_qunfa_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.linkLabel_get_qq_guangg_queqiao);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.comboBox_qq_queqiao_weizhi);
            this.groupBox6.Controls.Add(this.comboBox_qq_queqiao_danyuan);
            this.groupBox6.Controls.Add(this.radioButton7);
            this.groupBox6.Controls.Add(this.radioButton8);
            this.groupBox6.Controls.Add(this.radioButton9);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(6, 145);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 133);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "qq群鹊桥推广位设置";
            // 
            // linkLabel_get_qq_guangg_queqiao
            // 
            this.linkLabel_get_qq_guangg_queqiao.AutoSize = true;
            this.linkLabel_get_qq_guangg_queqiao.BackColor = System.Drawing.Color.White;
            this.linkLabel_get_qq_guangg_queqiao.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_get_qq_guangg_queqiao.Location = new System.Drawing.Point(151, 0);
            this.linkLabel_get_qq_guangg_queqiao.Name = "linkLabel_get_qq_guangg_queqiao";
            this.linkLabel_get_qq_guangg_queqiao.Size = new System.Drawing.Size(100, 19);
            this.linkLabel_get_qq_guangg_queqiao.TabIndex = 3;
            this.linkLabel_get_qq_guangg_queqiao.TabStop = true;
            this.linkLabel_get_qq_guangg_queqiao.Text = "获取最新推广位";
            this.linkLabel_get_qq_guangg_queqiao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_get_qq_guangg_queqiao_LinkClicked);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 19);
            this.label19.TabIndex = 2;
            this.label19.Text = "推广位:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 19);
            this.label20.TabIndex = 2;
            this.label20.Text = "推广单元:";
            // 
            // comboBox_qq_queqiao_weizhi
            // 
            this.comboBox_qq_queqiao_weizhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_qq_queqiao_weizhi.FormattingEnabled = true;
            this.comboBox_qq_queqiao_weizhi.Location = new System.Drawing.Point(77, 97);
            this.comboBox_qq_queqiao_weizhi.Name = "comboBox_qq_queqiao_weizhi";
            this.comboBox_qq_queqiao_weizhi.Size = new System.Drawing.Size(160, 27);
            this.comboBox_qq_queqiao_weizhi.TabIndex = 1;
            // 
            // comboBox_qq_queqiao_danyuan
            // 
            this.comboBox_qq_queqiao_danyuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_qq_queqiao_danyuan.FormattingEnabled = true;
            this.comboBox_qq_queqiao_danyuan.Location = new System.Drawing.Point(77, 64);
            this.comboBox_qq_queqiao_danyuan.Name = "comboBox_qq_queqiao_danyuan";
            this.comboBox_qq_queqiao_danyuan.Size = new System.Drawing.Size(160, 27);
            this.comboBox_qq_queqiao_danyuan.TabIndex = 1;
            this.comboBox_qq_queqiao_danyuan.SelectedIndexChanged += new System.EventHandler(this.comboBox_qq_queqiao_danyuan_SelectedIndexChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(176, 24);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(79, 23);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "导购推广";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(92, 25);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(78, 23);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.Text = "APP推广";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 25);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(79, 23);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.Text = "网站推广";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox29);
            this.groupBox7.Controls.Add(this.checkBox_qunfa_erheyi);
            this.groupBox7.Controls.Add(this.textBox_qunfa_apply_content);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(606, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 438);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "其他设置";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.radioButton_qunfa_duanlian_hpt);
            this.groupBox29.Controls.Add(this.checkBox_qunfa_duanlian);
            this.groupBox29.Location = new System.Drawing.Point(11, 149);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(238, 98);
            this.groupBox29.TabIndex = 3;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "短连接配置";
            // 
            // radioButton_qunfa_duanlian_hpt
            // 
            this.radioButton_qunfa_duanlian_hpt.AutoSize = true;
            this.radioButton_qunfa_duanlian_hpt.Location = new System.Drawing.Point(6, 24);
            this.radioButton_qunfa_duanlian_hpt.Name = "radioButton_qunfa_duanlian_hpt";
            this.radioButton_qunfa_duanlian_hpt.Size = new System.Drawing.Size(105, 23);
            this.radioButton_qunfa_duanlian_hpt.TabIndex = 1;
            this.radioButton_qunfa_duanlian_hpt.TabStop = true;
            this.radioButton_qunfa_duanlian_hpt.Text = "好品推短连接";
            this.radioButton_qunfa_duanlian_hpt.UseVisualStyleBackColor = true;
            // 
            // checkBox_qunfa_duanlian
            // 
            this.checkBox_qunfa_duanlian.AutoSize = true;
            this.checkBox_qunfa_duanlian.BackColor = System.Drawing.Color.White;
            this.checkBox_qunfa_duanlian.Location = new System.Drawing.Point(88, 0);
            this.checkBox_qunfa_duanlian.Name = "checkBox_qunfa_duanlian";
            this.checkBox_qunfa_duanlian.Size = new System.Drawing.Size(93, 23);
            this.checkBox_qunfa_duanlian.TabIndex = 0;
            this.checkBox_qunfa_duanlian.Text = "开启短连接";
            this.checkBox_qunfa_duanlian.UseVisualStyleBackColor = false;
            // 
            // checkBox_qunfa_erheyi
            // 
            this.checkBox_qunfa_erheyi.AutoSize = true;
            this.checkBox_qunfa_erheyi.Location = new System.Drawing.Point(11, 119);
            this.checkBox_qunfa_erheyi.Name = "checkBox_qunfa_erheyi";
            this.checkBox_qunfa_erheyi.Size = new System.Drawing.Size(145, 23);
            this.checkBox_qunfa_erheyi.TabIndex = 2;
            this.checkBox_qunfa_erheyi.Text = "使用二合一推广链接";
            this.checkBox_qunfa_erheyi.UseVisualStyleBackColor = true;
            // 
            // textBox_qunfa_apply_content
            // 
            this.textBox_qunfa_apply_content.Location = new System.Drawing.Point(11, 48);
            this.textBox_qunfa_apply_content.Multiline = true;
            this.textBox_qunfa_apply_content.Name = "textBox_qunfa_apply_content";
            this.textBox_qunfa_apply_content.Size = new System.Drawing.Size(238, 55);
            this.textBox_qunfa_apply_content.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "高佣金申请理由：";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.linkLabel_get_weibo_guanggao);
            this.groupBox32.Controls.Add(this.label52);
            this.groupBox32.Controls.Add(this.label53);
            this.groupBox32.Controls.Add(this.comboBox_weibo_tongyong_weizhi);
            this.groupBox32.Controls.Add(this.comboBox_weibo_tongyong_danyuan);
            this.groupBox32.Controls.Add(this.radioButton1);
            this.groupBox32.Controls.Add(this.radioButton2);
            this.groupBox32.Controls.Add(this.radioButton3);
            this.groupBox32.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox32.Location = new System.Drawing.Point(267, 152);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(255, 133);
            this.groupBox32.TabIndex = 0;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "微博推广位设置";
            // 
            // linkLabel_get_weibo_guanggao
            // 
            this.linkLabel_get_weibo_guanggao.AutoSize = true;
            this.linkLabel_get_weibo_guanggao.BackColor = System.Drawing.Color.White;
            this.linkLabel_get_weibo_guanggao.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_get_weibo_guanggao.Location = new System.Drawing.Point(151, 0);
            this.linkLabel_get_weibo_guanggao.Name = "linkLabel_get_weibo_guanggao";
            this.linkLabel_get_weibo_guanggao.Size = new System.Drawing.Size(100, 19);
            this.linkLabel_get_weibo_guanggao.TabIndex = 3;
            this.linkLabel_get_weibo_guanggao.TabStop = true;
            this.linkLabel_get_weibo_guanggao.Text = "获取微博推广位";
            this.linkLabel_get_weibo_guanggao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_get_weibo_guanggao_LinkClicked);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(7, 100);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(51, 19);
            this.label52.TabIndex = 2;
            this.label52.Text = "推广位:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(7, 67);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(64, 19);
            this.label53.TabIndex = 2;
            this.label53.Text = "推广单元:";
            // 
            // comboBox_weibo_tongyong_weizhi
            // 
            this.comboBox_weibo_tongyong_weizhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weibo_tongyong_weizhi.FormattingEnabled = true;
            this.comboBox_weibo_tongyong_weizhi.Location = new System.Drawing.Point(77, 97);
            this.comboBox_weibo_tongyong_weizhi.Name = "comboBox_weibo_tongyong_weizhi";
            this.comboBox_weibo_tongyong_weizhi.Size = new System.Drawing.Size(160, 27);
            this.comboBox_weibo_tongyong_weizhi.TabIndex = 1;
            // 
            // comboBox_weibo_tongyong_danyuan
            // 
            this.comboBox_weibo_tongyong_danyuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weibo_tongyong_danyuan.FormattingEnabled = true;
            this.comboBox_weibo_tongyong_danyuan.Location = new System.Drawing.Point(77, 64);
            this.comboBox_weibo_tongyong_danyuan.Name = "comboBox_weibo_tongyong_danyuan";
            this.comboBox_weibo_tongyong_danyuan.Size = new System.Drawing.Size(160, 27);
            this.comboBox_weibo_tongyong_danyuan.TabIndex = 1;
            this.comboBox_weibo_tongyong_danyuan.SelectedIndexChanged += new System.EventHandler(this.comboBox_weibo_tongyong_danyuan_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "导购推广";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(92, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 23);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "APP推广";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 23);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "网站推广";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.linkLabel_get_weixin_guanggao);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.comboBox_weixin_tongyong_weizhi);
            this.groupBox8.Controls.Add(this.comboBox_weixin_tongyong_danyuan);
            this.groupBox8.Controls.Add(this.radioButton13);
            this.groupBox8.Controls.Add(this.radioButton14);
            this.groupBox8.Controls.Add(this.radioButton15);
            this.groupBox8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(267, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(255, 133);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "微信推广位设置";
            // 
            // linkLabel_get_weixin_guanggao
            // 
            this.linkLabel_get_weixin_guanggao.AutoSize = true;
            this.linkLabel_get_weixin_guanggao.BackColor = System.Drawing.Color.White;
            this.linkLabel_get_weixin_guanggao.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_get_weixin_guanggao.Location = new System.Drawing.Point(151, 0);
            this.linkLabel_get_weixin_guanggao.Name = "linkLabel_get_weixin_guanggao";
            this.linkLabel_get_weixin_guanggao.Size = new System.Drawing.Size(100, 19);
            this.linkLabel_get_weixin_guanggao.TabIndex = 3;
            this.linkLabel_get_weixin_guanggao.TabStop = true;
            this.linkLabel_get_weixin_guanggao.Text = "获取微信推广位";
            this.linkLabel_get_weixin_guanggao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_get_weixin_guanggao_LinkClicked);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 19);
            this.label23.TabIndex = 2;
            this.label23.Text = "推广位:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 19);
            this.label24.TabIndex = 2;
            this.label24.Text = "推广单元:";
            // 
            // comboBox_weixin_tongyong_weizhi
            // 
            this.comboBox_weixin_tongyong_weizhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weixin_tongyong_weizhi.FormattingEnabled = true;
            this.comboBox_weixin_tongyong_weizhi.Location = new System.Drawing.Point(77, 97);
            this.comboBox_weixin_tongyong_weizhi.Name = "comboBox_weixin_tongyong_weizhi";
            this.comboBox_weixin_tongyong_weizhi.Size = new System.Drawing.Size(160, 27);
            this.comboBox_weixin_tongyong_weizhi.TabIndex = 1;
            // 
            // comboBox_weixin_tongyong_danyuan
            // 
            this.comboBox_weixin_tongyong_danyuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_weixin_tongyong_danyuan.FormattingEnabled = true;
            this.comboBox_weixin_tongyong_danyuan.Location = new System.Drawing.Point(77, 64);
            this.comboBox_weixin_tongyong_danyuan.Name = "comboBox_weixin_tongyong_danyuan";
            this.comboBox_weixin_tongyong_danyuan.Size = new System.Drawing.Size(160, 27);
            this.comboBox_weixin_tongyong_danyuan.TabIndex = 1;
            this.comboBox_weixin_tongyong_danyuan.SelectedIndexChanged += new System.EventHandler(this.comboBox_weixin_tongyong_danyuan_SelectedIndexChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Checked = true;
            this.radioButton13.Location = new System.Drawing.Point(176, 24);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(79, 23);
            this.radioButton13.TabIndex = 0;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "导购推广";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(92, 25);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(78, 23);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.Text = "APP推广";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(7, 25);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(79, 23);
            this.radioButton15.TabIndex = 0;
            this.radioButton15.Text = "网站推广";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel_get_qq_guanggao);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.comboBox_qq_tongyong_weizhi);
            this.groupBox5.Controls.Add(this.comboBox_qq_tongyong_danyuan);
            this.groupBox5.Controls.Add(this.radioButton6);
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Controls.Add(this.radioButton_qq_tongyong);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 133);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "qq群通用推广位设置";
            // 
            // linkLabel_get_qq_guanggao
            // 
            this.linkLabel_get_qq_guanggao.AutoSize = true;
            this.linkLabel_get_qq_guanggao.BackColor = System.Drawing.Color.White;
            this.linkLabel_get_qq_guanggao.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_get_qq_guanggao.Location = new System.Drawing.Point(151, 0);
            this.linkLabel_get_qq_guanggao.Name = "linkLabel_get_qq_guanggao";
            this.linkLabel_get_qq_guanggao.Size = new System.Drawing.Size(100, 19);
            this.linkLabel_get_qq_guanggao.TabIndex = 3;
            this.linkLabel_get_qq_guanggao.TabStop = true;
            this.linkLabel_get_qq_guanggao.Text = "获取最新推广位";
            this.linkLabel_get_qq_guanggao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "推广位:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 2;
            this.label17.Text = "推广单元:";
            // 
            // comboBox_qq_tongyong_weizhi
            // 
            this.comboBox_qq_tongyong_weizhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_qq_tongyong_weizhi.FormattingEnabled = true;
            this.comboBox_qq_tongyong_weizhi.Location = new System.Drawing.Point(77, 97);
            this.comboBox_qq_tongyong_weizhi.Name = "comboBox_qq_tongyong_weizhi";
            this.comboBox_qq_tongyong_weizhi.Size = new System.Drawing.Size(160, 27);
            this.comboBox_qq_tongyong_weizhi.TabIndex = 1;
            // 
            // comboBox_qq_tongyong_danyuan
            // 
            this.comboBox_qq_tongyong_danyuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_qq_tongyong_danyuan.FormattingEnabled = true;
            this.comboBox_qq_tongyong_danyuan.Location = new System.Drawing.Point(77, 64);
            this.comboBox_qq_tongyong_danyuan.Name = "comboBox_qq_tongyong_danyuan";
            this.comboBox_qq_tongyong_danyuan.Size = new System.Drawing.Size(160, 27);
            this.comboBox_qq_tongyong_danyuan.TabIndex = 1;
            this.comboBox_qq_tongyong_danyuan.SelectedIndexChanged += new System.EventHandler(this.comboBox_qq_tongyong_danyuan_SelectedIndexChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(176, 24);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 23);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "导购推广";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(92, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 23);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "APP推广";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton_qq_tongyong
            // 
            this.radioButton_qq_tongyong.AutoSize = true;
            this.radioButton_qq_tongyong.Location = new System.Drawing.Point(7, 25);
            this.radioButton_qq_tongyong.Name = "radioButton_qq_tongyong";
            this.radioButton_qq_tongyong.Size = new System.Drawing.Size(79, 23);
            this.radioButton_qq_tongyong.TabIndex = 0;
            this.radioButton_qq_tongyong.Text = "网站推广";
            this.radioButton_qq_tongyong.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.button23);
            this.tabPage16.Controls.Add(this.groupBox18);
            this.tabPage16.Controls.Add(this.groupBox21);
            this.tabPage16.Controls.Add(this.groupBox20);
            this.tabPage16.Location = new System.Drawing.Point(4, 14);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(864, 444);
            this.tabPage16.TabIndex = 2;
            this.tabPage16.Text = "tabPage16";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DodgerBlue;
            this.button23.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button23.ForeColor = System.Drawing.Color.AliceBlue;
            this.button23.Location = new System.Drawing.Point(297, 407);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(152, 34);
            this.button23.TabIndex = 1;
            this.button23.Text = "保存";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.linkLabel7);
            this.groupBox18.Controls.Add(this.button33);
            this.groupBox18.Controls.Add(this.button34);
            this.groupBox18.Controls.Add(this.button35);
            this.groupBox18.Controls.Add(this.button36);
            this.groupBox18.Controls.Add(this.button37);
            this.groupBox18.Controls.Add(this.button38);
            this.groupBox18.Controls.Add(this.button39);
            this.groupBox18.Controls.Add(this.button40);
            this.groupBox18.Controls.Add(this.button41);
            this.groupBox18.Controls.Add(this.button42);
            this.groupBox18.Controls.Add(this.button43);
            this.groupBox18.Controls.Add(this.button44);
            this.groupBox18.Controls.Add(this.button45);
            this.groupBox18.Controls.Add(this.textBox_weibo_template);
            this.groupBox18.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox18.Location = new System.Drawing.Point(575, 6);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(252, 396);
            this.groupBox18.TabIndex = 0;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "微博模板设置";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.BackColor = System.Drawing.Color.White;
            this.linkLabel7.Location = new System.Drawing.Point(124, 2);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(97, 15);
            this.linkLabel7.TabIndex = 4;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "恢复默认模板";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button33.Location = new System.Drawing.Point(117, 261);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(103, 23);
            this.button33.TabIndex = 3;
            this.button33.Text = "二合一短网址";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button34.Location = new System.Drawing.Point(7, 370);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 3;
            this.button34.Text = "券后价";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button35.Location = new System.Drawing.Point(118, 346);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(75, 23);
            this.button35.TabIndex = 3;
            this.button35.Text = "淘口令";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button36.Location = new System.Drawing.Point(118, 201);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(75, 23);
            this.button36.TabIndex = 2;
            this.button36.Text = "原价";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button37.Location = new System.Drawing.Point(114, 317);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(104, 23);
            this.button37.TabIndex = 1;
            this.button37.Text = "视频介绍";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button38.Location = new System.Drawing.Point(116, 288);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(104, 23);
            this.button38.TabIndex = 1;
            this.button38.Text = "商品类型";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button39.Location = new System.Drawing.Point(6, 288);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(104, 23);
            this.button39.TabIndex = 1;
            this.button39.Text = "主图片";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button40.Location = new System.Drawing.Point(7, 259);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(104, 23);
            this.button40.TabIndex = 1;
            this.button40.Text = "文案";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button41.Location = new System.Drawing.Point(7, 344);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(104, 23);
            this.button41.TabIndex = 1;
            this.button41.Text = "商品标题";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button42.Location = new System.Drawing.Point(7, 317);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(104, 23);
            this.button42.TabIndex = 1;
            this.button42.Text = "商品地址";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button43.Location = new System.Drawing.Point(118, 232);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(104, 23);
            this.button43.TabIndex = 1;
            this.button43.Text = "优惠券手机连接";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button44.Location = new System.Drawing.Point(6, 230);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(104, 23);
            this.button44.TabIndex = 1;
            this.button44.Text = "优惠券电脑连接";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button45
            // 
            this.button45.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button45.Location = new System.Drawing.Point(7, 201);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(104, 23);
            this.button45.TabIndex = 1;
            this.button45.Text = "优惠券面额";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // textBox_weibo_template
            // 
            this.textBox_weibo_template.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_weibo_template.Location = new System.Drawing.Point(3, 21);
            this.textBox_weibo_template.Multiline = true;
            this.textBox_weibo_template.Name = "textBox_weibo_template";
            this.textBox_weibo_template.Size = new System.Drawing.Size(246, 175);
            this.textBox_weibo_template.TabIndex = 0;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.linkLabel5);
            this.groupBox21.Controls.Add(this.button13);
            this.groupBox21.Controls.Add(this.button14);
            this.groupBox21.Controls.Add(this.button15);
            this.groupBox21.Controls.Add(this.button16);
            this.groupBox21.Controls.Add(this.button29);
            this.groupBox21.Controls.Add(this.button27);
            this.groupBox21.Controls.Add(this.button25);
            this.groupBox21.Controls.Add(this.button17);
            this.groupBox21.Controls.Add(this.button18);
            this.groupBox21.Controls.Add(this.button19);
            this.groupBox21.Controls.Add(this.button20);
            this.groupBox21.Controls.Add(this.button21);
            this.groupBox21.Controls.Add(this.button22);
            this.groupBox21.Controls.Add(this.textBox_weixin_template);
            this.groupBox21.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox21.Location = new System.Drawing.Point(297, 5);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(252, 396);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "微信群模板设置";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(124, 2);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(97, 15);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "恢复默认模板";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(117, 261);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(103, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "二合一短网址";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(7, 370);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "券后价";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button6_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(118, 346);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 3;
            this.button15.Text = "淘口令";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button5_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(118, 201);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 2;
            this.button16.Text = "原价";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button4_Click);
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button29.Location = new System.Drawing.Point(114, 317);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(104, 23);
            this.button29.TabIndex = 1;
            this.button29.Text = "视频介绍";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button12_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button27.Location = new System.Drawing.Point(116, 288);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(104, 23);
            this.button27.TabIndex = 1;
            this.button27.Text = "商品类型";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button12_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button25.Location = new System.Drawing.Point(6, 288);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(104, 23);
            this.button25.TabIndex = 1;
            this.button25.Text = "主图片";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button12_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(7, 259);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(104, 23);
            this.button17.TabIndex = 1;
            this.button17.Text = "文案";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button12_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button18.Location = new System.Drawing.Point(7, 344);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(104, 23);
            this.button18.TabIndex = 1;
            this.button18.Text = "商品标题";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button11_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button19.Location = new System.Drawing.Point(7, 317);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(104, 23);
            this.button19.TabIndex = 1;
            this.button19.Text = "商品地址";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button10_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button20.Location = new System.Drawing.Point(118, 232);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(104, 23);
            this.button20.TabIndex = 1;
            this.button20.Text = "优惠券手机连接";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button9_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button21.Location = new System.Drawing.Point(6, 230);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(104, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "优惠券电脑连接";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button22.Location = new System.Drawing.Point(7, 201);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(104, 23);
            this.button22.TabIndex = 1;
            this.button22.Text = "优惠券面额";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox_weixin_template
            // 
            this.textBox_weixin_template.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_weixin_template.Location = new System.Drawing.Point(3, 21);
            this.textBox_weixin_template.Multiline = true;
            this.textBox_weixin_template.Name = "textBox_weixin_template";
            this.textBox_weixin_template.Size = new System.Drawing.Size(246, 175);
            this.textBox_weixin_template.TabIndex = 0;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.linkLabel4);
            this.groupBox20.Controls.Add(this.button7);
            this.groupBox20.Controls.Add(this.button6);
            this.groupBox20.Controls.Add(this.button5);
            this.groupBox20.Controls.Add(this.button4);
            this.groupBox20.Controls.Add(this.button28);
            this.groupBox20.Controls.Add(this.button26);
            this.groupBox20.Controls.Add(this.button24);
            this.groupBox20.Controls.Add(this.button12);
            this.groupBox20.Controls.Add(this.button11);
            this.groupBox20.Controls.Add(this.button10);
            this.groupBox20.Controls.Add(this.button9);
            this.groupBox20.Controls.Add(this.button8);
            this.groupBox20.Controls.Add(this.button3);
            this.groupBox20.Controls.Add(this.textBox_qq_template);
            this.groupBox20.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox20.Location = new System.Drawing.Point(3, 3);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(376, 398);
            this.groupBox20.TabIndex = 0;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "QQ群模板设置";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(122, 2);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(97, 15);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "恢复默认模板";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(117, 261);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "二合一短网址";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_2);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(116, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "券后价";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(6, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "淘口令";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(118, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "原价";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button28.Location = new System.Drawing.Point(116, 317);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(104, 23);
            this.button28.TabIndex = 1;
            this.button28.Text = "视频介绍";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button26.Location = new System.Drawing.Point(116, 288);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(104, 23);
            this.button26.TabIndex = 1;
            this.button26.Text = "商品类型";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button24.Location = new System.Drawing.Point(6, 288);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(104, 23);
            this.button24.TabIndex = 1;
            this.button24.Text = "主图片";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(7, 259);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(104, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "文案";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.Location = new System.Drawing.Point(7, 346);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(104, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "商品标题";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(7, 317);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "商品地址";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(118, 232);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "优惠券手机连接";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(6, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "优惠券电脑连接";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(7, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "优惠券面额";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_qq_template
            // 
            this.textBox_qq_template.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_qq_template.Location = new System.Drawing.Point(3, 21);
            this.textBox_qq_template.Multiline = true;
            this.textBox_qq_template.Name = "textBox_qq_template";
            this.textBox_qq_template.Size = new System.Drawing.Size(370, 175);
            this.textBox_qq_template.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button_qunfa_template);
            this.panel3.Controls.Add(this.button_qunfa_setting);
            this.panel3.Controls.Add(this.button_qunfa_fa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 50);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button_qunfa_template
            // 
            this.button_qunfa_template.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_qunfa_template.Location = new System.Drawing.Point(373, 12);
            this.button_qunfa_template.Name = "button_qunfa_template";
            this.button_qunfa_template.Size = new System.Drawing.Size(119, 33);
            this.button_qunfa_template.TabIndex = 0;
            this.button_qunfa_template.Text = "群发模板设置";
            this.button_qunfa_template.UseVisualStyleBackColor = true;
            this.button_qunfa_template.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button_qunfa_setting
            // 
            this.button_qunfa_setting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_qunfa_setting.Location = new System.Drawing.Point(256, 12);
            this.button_qunfa_setting.Name = "button_qunfa_setting";
            this.button_qunfa_setting.Size = new System.Drawing.Size(119, 33);
            this.button_qunfa_setting.TabIndex = 0;
            this.button_qunfa_setting.Text = "群发基础设置";
            this.button_qunfa_setting.UseVisualStyleBackColor = true;
            this.button_qunfa_setting.Click += new System.EventHandler(this.button8_Click);
            // 
            // button_qunfa_fa
            // 
            this.button_qunfa_fa.BackColor = System.Drawing.Color.DarkGray;
            this.button_qunfa_fa.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_qunfa_fa.Location = new System.Drawing.Point(144, 12);
            this.button_qunfa_fa.Name = "button_qunfa_fa";
            this.button_qunfa_fa.Size = new System.Drawing.Size(113, 33);
            this.button_qunfa_fa.TabIndex = 0;
            this.button_qunfa_fa.Text = "群发";
            this.button_qunfa_fa.UseVisualStyleBackColor = false;
            this.button_qunfa_fa.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.tabControl_tools);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(872, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabControl_tools
            // 
            this.tabControl_tools.Controls.Add(this.tabPage11);
            this.tabControl_tools.Controls.Add(this.tabPage12);
            this.tabControl_tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tools.ItemSize = new System.Drawing.Size(1, 1);
            this.tabControl_tools.Location = new System.Drawing.Point(0, 80);
            this.tabControl_tools.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_tools.Name = "tabControl_tools";
            this.tabControl_tools.SelectedIndex = 0;
            this.tabControl_tools.Size = new System.Drawing.Size(872, 432);
            this.tabControl_tools.TabIndex = 1;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.tabControl_tools_common);
            this.tabPage11.Location = new System.Drawing.Point(4, 5);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(864, 423);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabControl_tools_common
            // 
            this.tabControl_tools_common.Controls.Add(this.tabPage13);
            this.tabControl_tools_common.Controls.Add(this.tabPage14);
            this.tabControl_tools_common.Controls.Add(this.tabPage25);
            this.tabControl_tools_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tools_common.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_tools_common.Location = new System.Drawing.Point(3, 3);
            this.tabControl_tools_common.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_tools_common.Name = "tabControl_tools_common";
            this.tabControl_tools_common.SelectedIndex = 0;
            this.tabControl_tools_common.Size = new System.Drawing.Size(858, 417);
            this.tabControl_tools_common.TabIndex = 0;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.groupBox14);
            this.tabPage13.Controls.Add(this.groupBox13);
            this.tabPage13.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage13.Location = new System.Drawing.Point(4, 28);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(850, 385);
            this.tabPage13.TabIndex = 0;
            this.tabPage13.Text = "转换连接";
            this.tabPage13.UseVisualStyleBackColor = true;
            this.tabPage13.Click += new System.EventHandler(this.tabPage13_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button_tools_qingkong);
            this.groupBox14.Controls.Add(this.button1);
            this.groupBox14.Controls.Add(this.button_tools_zhuanhua_copy);
            this.groupBox14.Controls.Add(this.button_tools_zhuanhua_tianjia_zhushou);
            this.groupBox14.Controls.Add(this.checkBox_tools_piliang);
            this.groupBox14.Controls.Add(this.checkBox_tools_qingkong);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(600, 0);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(250, 385);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "一键转链接操作";
            // 
            // button_tools_qingkong
            // 
            this.button_tools_qingkong.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_tools_qingkong.Location = new System.Drawing.Point(9, 304);
            this.button_tools_qingkong.Name = "button_tools_qingkong";
            this.button_tools_qingkong.Size = new System.Drawing.Size(155, 30);
            this.button_tools_qingkong.TabIndex = 1;
            this.button_tools_qingkong.Text = "清空";
            this.button_tools_qingkong.UseVisualStyleBackColor = true;
            this.button_tools_qingkong.Click += new System.EventHandler(this.button_tools_qingkong_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(9, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "转化带口令并拷贝";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_tools_zhuanhua_copy
            // 
            this.button_tools_zhuanhua_copy.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_tools_zhuanhua_copy.Location = new System.Drawing.Point(9, 113);
            this.button_tools_zhuanhua_copy.Name = "button_tools_zhuanhua_copy";
            this.button_tools_zhuanhua_copy.Size = new System.Drawing.Size(155, 30);
            this.button_tools_zhuanhua_copy.TabIndex = 1;
            this.button_tools_zhuanhua_copy.Text = "转化并拷贝";
            this.button_tools_zhuanhua_copy.UseVisualStyleBackColor = true;
            this.button_tools_zhuanhua_copy.Click += new System.EventHandler(this.button_tools_zhuanhua_copy_Click);
            // 
            // button_tools_zhuanhua_tianjia_zhushou
            // 
            this.button_tools_zhuanhua_tianjia_zhushou.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_tools_zhuanhua_tianjia_zhushou.Location = new System.Drawing.Point(9, 77);
            this.button_tools_zhuanhua_tianjia_zhushou.Name = "button_tools_zhuanhua_tianjia_zhushou";
            this.button_tools_zhuanhua_tianjia_zhushou.Size = new System.Drawing.Size(155, 30);
            this.button_tools_zhuanhua_tianjia_zhushou.TabIndex = 1;
            this.button_tools_zhuanhua_tianjia_zhushou.Text = "转化并添加到群发任务";
            this.button_tools_zhuanhua_tianjia_zhushou.UseVisualStyleBackColor = true;
            this.button_tools_zhuanhua_tianjia_zhushou.Click += new System.EventHandler(this.button_tools_zhuanhua_tianjia_zhushou_Click);
            // 
            // checkBox_tools_piliang
            // 
            this.checkBox_tools_piliang.AutoSize = true;
            this.checkBox_tools_piliang.Location = new System.Drawing.Point(9, 47);
            this.checkBox_tools_piliang.Name = "checkBox_tools_piliang";
            this.checkBox_tools_piliang.Size = new System.Drawing.Size(132, 23);
            this.checkBox_tools_piliang.TabIndex = 0;
            this.checkBox_tools_piliang.Text = "批量转换连接模式";
            this.checkBox_tools_piliang.UseVisualStyleBackColor = true;
            // 
            // checkBox_tools_qingkong
            // 
            this.checkBox_tools_qingkong.AutoSize = true;
            this.checkBox_tools_qingkong.Checked = true;
            this.checkBox_tools_qingkong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_tools_qingkong.Location = new System.Drawing.Point(9, 24);
            this.checkBox_tools_qingkong.Name = "checkBox_tools_qingkong";
            this.checkBox_tools_qingkong.Size = new System.Drawing.Size(93, 23);
            this.checkBox_tools_qingkong.TabIndex = 0;
            this.checkBox_tools_qingkong.Text = "转换完清空";
            this.checkBox_tools_qingkong.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox13.Controls.Add(this.webBrowser_zhuanhua);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox13.Location = new System.Drawing.Point(0, 0);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(600, 385);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "一键转链接内容编辑 - CTRL+V(可以包含图片文字、链接)";
            // 
            // webBrowser_zhuanhua
            // 
            this.webBrowser_zhuanhua.ContextMenuStrip = this.contextMenuStripTool;
            this.webBrowser_zhuanhua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_zhuanhua.Location = new System.Drawing.Point(3, 21);
            this.webBrowser_zhuanhua.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_zhuanhua.Name = "webBrowser_zhuanhua";
            this.webBrowser_zhuanhua.Size = new System.Drawing.Size(594, 361);
            this.webBrowser_zhuanhua.TabIndex = 0;
            // 
            // contextMenuStripTool
            // 
            this.contextMenuStripTool.Name = "contextMenuStripTool";
            this.contextMenuStripTool.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.button_tools_test_get_cookie);
            this.tabPage14.Controls.Add(this.textBoxAlimamaCookieUrl);
            this.tabPage14.Location = new System.Drawing.Point(4, 28);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(850, 385);
            this.tabPage14.TabIndex = 1;
            this.tabPage14.Text = "测试功能";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // button_tools_test_get_cookie
            // 
            this.button_tools_test_get_cookie.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_tools_test_get_cookie.Location = new System.Drawing.Point(181, 67);
            this.button_tools_test_get_cookie.Name = "button_tools_test_get_cookie";
            this.button_tools_test_get_cookie.Size = new System.Drawing.Size(105, 30);
            this.button_tools_test_get_cookie.TabIndex = 1;
            this.button_tools_test_get_cookie.Text = "跟踪cookies";
            this.button_tools_test_get_cookie.UseVisualStyleBackColor = false;
            this.button_tools_test_get_cookie.Click += new System.EventHandler(this.button_tools_test_get_cookie_Click);
            // 
            // textBoxAlimamaCookieUrl
            // 
            this.textBoxAlimamaCookieUrl.Location = new System.Drawing.Point(3, 17);
            this.textBoxAlimamaCookieUrl.Name = "textBoxAlimamaCookieUrl";
            this.textBoxAlimamaCookieUrl.Size = new System.Drawing.Size(495, 25);
            this.textBoxAlimamaCookieUrl.TabIndex = 0;
            // 
            // tabPage25
            // 
            this.tabPage25.Controls.Add(this.groupBox34);
            this.tabPage25.Location = new System.Drawing.Point(4, 28);
            this.tabPage25.Name = "tabPage25";
            this.tabPage25.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage25.Size = new System.Drawing.Size(850, 385);
            this.tabPage25.TabIndex = 2;
            this.tabPage25.Text = "阿里妈妈订单同步";
            this.tabPage25.UseVisualStyleBackColor = true;
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.label71);
            this.groupBox34.Controls.Add(this.comboBox_ali_order_days);
            this.groupBox34.Controls.Add(this.label70);
            this.groupBox34.Controls.Add(this.button46);
            this.groupBox34.Controls.Add(this.label69);
            this.groupBox34.Controls.Add(this.label68);
            this.groupBox34.Controls.Add(this.comboBox_ali_order_pinlv);
            this.groupBox34.Location = new System.Drawing.Point(6, 6);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(316, 264);
            this.groupBox34.TabIndex = 0;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "同步订单设置";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(140, 83);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(74, 19);
            this.label71.TabIndex = 17;
            this.label71.Text = "天内的数据";
            // 
            // comboBox_ali_order_days
            // 
            this.comboBox_ali_order_days.FormattingEnabled = true;
            this.comboBox_ali_order_days.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "7",
            "15",
            "30",
            "60",
            "90"});
            this.comboBox_ali_order_days.Location = new System.Drawing.Point(68, 77);
            this.comboBox_ali_order_days.Name = "comboBox_ali_order_days";
            this.comboBox_ali_order_days.Size = new System.Drawing.Size(61, 27);
            this.comboBox_ali_order_days.TabIndex = 16;
            this.comboBox_ali_order_days.SelectedIndexChanged += new System.EventHandler(this.comboBox_ali_order_days_SelectedIndexChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(9, 79);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(48, 19);
            this.label70.TabIndex = 15;
            this.label70.Text = "只同步";
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.DodgerBlue;
            this.button46.FlatAppearance.BorderSize = 0;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button46.ForeColor = System.Drawing.Color.White;
            this.button46.Location = new System.Drawing.Point(9, 115);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(187, 40);
            this.button46.TabIndex = 14;
            this.button46.Text = "开始阿里妈妈订单同步";
            this.button46.UseVisualStyleBackColor = false;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(136, 36);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(35, 19);
            this.label69.TabIndex = 13;
            this.label69.Text = "分钟";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label68.Location = new System.Drawing.Point(6, 36);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(56, 17);
            this.label68.TabIndex = 12;
            this.label68.Text = "同步频率";
            // 
            // comboBox_ali_order_pinlv
            // 
            this.comboBox_ali_order_pinlv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ali_order_pinlv.FormattingEnabled = true;
            this.comboBox_ali_order_pinlv.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "45",
            "50",
            "55",
            "60",
            "120",
            "300",
            "600",
            "1800",
            "3600"});
            this.comboBox_ali_order_pinlv.Location = new System.Drawing.Point(68, 32);
            this.comboBox_ali_order_pinlv.Name = "comboBox_ali_order_pinlv";
            this.comboBox_ali_order_pinlv.Size = new System.Drawing.Size(61, 25);
            this.comboBox_ali_order_pinlv.TabIndex = 11;
            this.comboBox_ali_order_pinlv.SelectedIndexChanged += new System.EventHandler(this.comboBox_ali_order_pinlv_SelectedIndexChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 5);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(864, 423);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_tools_bt_changgui);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(872, 80);
            this.panel6.TabIndex = 0;
            // 
            // button_tools_bt_changgui
            // 
            this.button_tools_bt_changgui.BackColor = System.Drawing.Color.DarkGray;
            this.button_tools_bt_changgui.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_tools_bt_changgui.Location = new System.Drawing.Point(100, 25);
            this.button_tools_bt_changgui.Name = "button_tools_bt_changgui";
            this.button_tools_bt_changgui.Size = new System.Drawing.Size(113, 33);
            this.button_tools_bt_changgui.TabIndex = 1;
            this.button_tools_bt_changgui.Text = "常规功能";
            this.button_tools_bt_changgui.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.buttonSaveConfig);
            this.tabPage4.Controls.Add(this.groupBox_dama);
            this.tabPage4.Controls.Add(this.groupBox17);
            this.tabPage4.Controls.Add(this.groupBox_alimama);
            this.tabPage4.Location = new System.Drawing.Point(4, 14);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(872, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveConfig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveConfig.ForeColor = System.Drawing.Color.White;
            this.buttonSaveConfig.Location = new System.Drawing.Point(301, 421);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(130, 43);
            this.buttonSaveConfig.TabIndex = 2;
            this.buttonSaveConfig.Text = "保存";
            this.buttonSaveConfig.UseVisualStyleBackColor = false;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // groupBox_dama
            // 
            this.groupBox_dama.Controls.Add(this.buttonOpenUUHP);
            this.groupBox_dama.Controls.Add(this.buttonTestCode);
            this.groupBox_dama.Controls.Add(this.pictureBoxTest);
            this.groupBox_dama.Controls.Add(this.buttonUUWiseLogin);
            this.groupBox_dama.Controls.Add(this.textBoxUUPwd);
            this.groupBox_dama.Controls.Add(this.label15);
            this.groupBox_dama.Controls.Add(this.textBoxUUUsername);
            this.groupBox_dama.Controls.Add(this.label14);
            this.groupBox_dama.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_dama.Location = new System.Drawing.Point(285, 22);
            this.groupBox_dama.Name = "groupBox_dama";
            this.groupBox_dama.Size = new System.Drawing.Size(225, 202);
            this.groupBox_dama.TabIndex = 1;
            this.groupBox_dama.TabStop = false;
            this.groupBox_dama.Text = "打码兔";
            // 
            // buttonOpenUUHP
            // 
            this.buttonOpenUUHP.Location = new System.Drawing.Point(131, 127);
            this.buttonOpenUUHP.Name = "buttonOpenUUHP";
            this.buttonOpenUUHP.Size = new System.Drawing.Size(86, 31);
            this.buttonOpenUUHP.TabIndex = 4;
            this.buttonOpenUUHP.Text = "官网";
            this.buttonOpenUUHP.UseVisualStyleBackColor = true;
            this.buttonOpenUUHP.Click += new System.EventHandler(this.buttonOpenUUHP_Click);
            // 
            // buttonTestCode
            // 
            this.buttonTestCode.Location = new System.Drawing.Point(133, 86);
            this.buttonTestCode.Name = "buttonTestCode";
            this.buttonTestCode.Size = new System.Drawing.Size(86, 35);
            this.buttonTestCode.TabIndex = 4;
            this.buttonTestCode.Text = "打码测试";
            this.buttonTestCode.UseVisualStyleBackColor = true;
            this.buttonTestCode.Click += new System.EventHandler(this.buttonTestCode_Click);
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxTest.Location = new System.Drawing.Point(8, 100);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(119, 50);
            this.pictureBoxTest.TabIndex = 3;
            this.pictureBoxTest.TabStop = false;
            // 
            // buttonUUWiseLogin
            // 
            this.buttonUUWiseLogin.Location = new System.Drawing.Point(133, 32);
            this.buttonUUWiseLogin.Name = "buttonUUWiseLogin";
            this.buttonUUWiseLogin.Size = new System.Drawing.Size(86, 35);
            this.buttonUUWiseLogin.TabIndex = 2;
            this.buttonUUWiseLogin.Text = "登录打码兔";
            this.buttonUUWiseLogin.UseVisualStyleBackColor = true;
            this.buttonUUWiseLogin.Click += new System.EventHandler(this.buttonUUWiseLogin_Click);
            // 
            // textBoxUUPwd
            // 
            this.textBoxUUPwd.Location = new System.Drawing.Point(52, 55);
            this.textBoxUUPwd.Name = "textBoxUUPwd";
            this.textBoxUUPwd.Size = new System.Drawing.Size(75, 25);
            this.textBoxUUPwd.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "密码:";
            // 
            // textBoxUUUsername
            // 
            this.textBoxUUUsername.Location = new System.Drawing.Point(52, 22);
            this.textBoxUUUsername.Name = "textBoxUUUsername";
            this.textBoxUUUsername.Size = new System.Drawing.Size(75, 25);
            this.textBoxUUUsername.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "账号:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label11);
            this.groupBox17.Controls.Add(this.label10);
            this.groupBox17.Controls.Add(this.radioButtonsetting_app_haopintui);
            this.groupBox17.Controls.Add(this.radioButtonsetting_app_ben);
            this.groupBox17.Controls.Add(this.linkLabel3);
            this.groupBox17.Controls.Add(this.label8);
            this.groupBox17.Controls.Add(this.textBox_setting_appKey);
            this.groupBox17.Controls.Add(this.label9);
            this.groupBox17.Controls.Add(this.textBox_setting_appId);
            this.groupBox17.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox17.Location = new System.Drawing.Point(16, 242);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(255, 224);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "淘口令接口配置";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(4, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 58);
            this.label11.TabIndex = 6;
            this.label11.Text = "不会申请接口的，可以使用好品推接口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "群发淘口令接口方式:";
            // 
            // radioButtonsetting_app_haopintui
            // 
            this.radioButtonsetting_app_haopintui.AutoSize = true;
            this.radioButtonsetting_app_haopintui.Location = new System.Drawing.Point(115, 131);
            this.radioButtonsetting_app_haopintui.Name = "radioButtonsetting_app_haopintui";
            this.radioButtonsetting_app_haopintui.Size = new System.Drawing.Size(92, 23);
            this.radioButtonsetting_app_haopintui.TabIndex = 4;
            this.radioButtonsetting_app_haopintui.Text = "好品推接口";
            this.radioButtonsetting_app_haopintui.UseVisualStyleBackColor = true;
            // 
            // radioButtonsetting_app_ben
            // 
            this.radioButtonsetting_app_ben.AutoSize = true;
            this.radioButtonsetting_app_ben.Checked = true;
            this.radioButtonsetting_app_ben.Location = new System.Drawing.Point(8, 131);
            this.radioButtonsetting_app_ben.Name = "radioButtonsetting_app_ben";
            this.radioButtonsetting_app_ben.Size = new System.Drawing.Size(105, 23);
            this.radioButtonsetting_app_ben.TabIndex = 3;
            this.radioButtonsetting_app_ben.TabStop = true;
            this.radioButtonsetting_app_ben.Text = "自己口令接口";
            this.radioButtonsetting_app_ben.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(140, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(87, 19);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "查看配置教程";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "App Secret:";
            // 
            // textBox_setting_appKey
            // 
            this.textBox_setting_appKey.Location = new System.Drawing.Point(90, 77);
            this.textBox_setting_appKey.Name = "textBox_setting_appKey";
            this.textBox_setting_appKey.Size = new System.Drawing.Size(122, 25);
            this.textBox_setting_appKey.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "App Key:";
            // 
            // textBox_setting_appId
            // 
            this.textBox_setting_appId.Location = new System.Drawing.Point(90, 37);
            this.textBox_setting_appId.Name = "textBox_setting_appId";
            this.textBox_setting_appId.Size = new System.Drawing.Size(122, 25);
            this.textBox_setting_appId.TabIndex = 0;
            // 
            // groupBox_alimama
            // 
            this.groupBox_alimama.Controls.Add(this.button48);
            this.groupBox_alimama.Controls.Add(this.linkLabel10);
            this.groupBox_alimama.Controls.Add(this.label66);
            this.groupBox_alimama.Controls.Add(this.checkBoxScanLogin);
            this.groupBox_alimama.Controls.Add(this.checkBoxAutoLogin);
            this.groupBox_alimama.Controls.Add(this.buttonLoginAlimama2);
            this.groupBox_alimama.Controls.Add(this.label13);
            this.groupBox_alimama.Controls.Add(this.textBoxAlimamaPwd);
            this.groupBox_alimama.Controls.Add(this.label12);
            this.groupBox_alimama.Controls.Add(this.textBoxAlimamaAcc);
            this.groupBox_alimama.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_alimama.Location = new System.Drawing.Point(16, 22);
            this.groupBox_alimama.Name = "groupBox_alimama";
            this.groupBox_alimama.Size = new System.Drawing.Size(255, 202);
            this.groupBox_alimama.TabIndex = 0;
            this.groupBox_alimama.TabStop = false;
            this.groupBox_alimama.Text = "阿里妈妈";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(4, 136);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(230, 19);
            this.linkLabel10.TabIndex = 5;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "如挂旺旺，不能自动登陆，下载此版本";
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(60, 109);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(100, 19);
            this.label66.TabIndex = 4;
            this.label66.Text = "推荐挂旺旺登陆";
            // 
            // checkBoxScanLogin
            // 
            this.checkBoxScanLogin.AutoSize = true;
            this.checkBoxScanLogin.BackColor = System.Drawing.Color.White;
            this.checkBoxScanLogin.Location = new System.Drawing.Point(147, -3);
            this.checkBoxScanLogin.Name = "checkBoxScanLogin";
            this.checkBoxScanLogin.Size = new System.Drawing.Size(80, 23);
            this.checkBoxScanLogin.TabIndex = 3;
            this.checkBoxScanLogin.Text = "扫码登陆";
            this.checkBoxScanLogin.UseVisualStyleBackColor = false;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.White;
            this.checkBoxAutoLogin.Checked = true;
            this.checkBoxAutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(70, -3);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(80, 23);
            this.checkBoxAutoLogin.TabIndex = 3;
            this.checkBoxAutoLogin.Text = "自动登录";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = false;
            // 
            // buttonLoginAlimama2
            // 
            this.buttonLoginAlimama2.Location = new System.Drawing.Point(54, 162);
            this.buttonLoginAlimama2.Name = "buttonLoginAlimama2";
            this.buttonLoginAlimama2.Size = new System.Drawing.Size(103, 24);
            this.buttonLoginAlimama2.TabIndex = 2;
            this.buttonLoginAlimama2.Text = "登录阿里妈妈";
            this.buttonLoginAlimama2.UseVisualStyleBackColor = true;
            this.buttonLoginAlimama2.Click += new System.EventHandler(this.buttonLoginAlimama2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "阿里妈妈密码:";
            // 
            // textBoxAlimamaPwd
            // 
            this.textBoxAlimamaPwd.Location = new System.Drawing.Point(100, 77);
            this.textBoxAlimamaPwd.Name = "textBoxAlimamaPwd";
            this.textBoxAlimamaPwd.PasswordChar = '*';
            this.textBoxAlimamaPwd.Size = new System.Drawing.Size(112, 25);
            this.textBoxAlimamaPwd.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "阿里妈妈账号:";
            // 
            // textBoxAlimamaAcc
            // 
            this.textBoxAlimamaAcc.Location = new System.Drawing.Point(100, 37);
            this.textBoxAlimamaAcc.Name = "textBoxAlimamaAcc";
            this.textBoxAlimamaAcc.Size = new System.Drawing.Size(112, 25);
            this.textBoxAlimamaAcc.TabIndex = 0;
            // 
            // notifyIcon_task
            // 
            this.notifyIcon_task.ContextMenuStrip = this.contextMenuStripTask;
            this.notifyIcon_task.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_task.Icon")));
            this.notifyIcon_task.Text = "好品推助手";
            this.notifyIcon_task.Visible = true;
            this.notifyIcon_task.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon_task.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStripTask
            // 
            this.contextMenuStripTask.Name = "contextMenuStripTask";
            this.contextMenuStripTask.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripTask.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTask_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // timer_kouling
            // 
            this.timer_kouling.Enabled = true;
            this.timer_kouling.Interval = 500;
            this.timer_kouling.Tick += new System.EventHandler(this.timer_kouling_Tick);
            // 
            // timer_caiji
            // 
            this.timer_caiji.Enabled = true;
            this.timer_caiji.Interval = 60000;
            this.timer_caiji.Tick += new System.EventHandler(this.timer_caiji_Tick);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button47.ForeColor = System.Drawing.Color.Red;
            this.button47.Location = new System.Drawing.Point(326, 5);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(75, 23);
            this.button47.TabIndex = 9;
            this.button47.Text = "高佣授权";
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button48
            // 
            this.button48.ForeColor = System.Drawing.Color.Red;
            this.button48.Location = new System.Drawing.Point(164, 162);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(75, 23);
            this.button48.TabIndex = 6;
            this.button48.Text = "高佣授权";
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // CmsForm
            // 
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.layout_menu);
            this.Controls.Add(this.richTextBoxLogs);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CmsForm";
            this.Text = "好品推助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEx_FormClosing);
            this.Load += new System.EventHandler(this.FormEx_Load);
            this.SizeChanged += new System.EventHandler(this.FormEx_SizeChanged);
            this.Resize += new System.EventHandler(this.FormEx_Resize);
            this.layout_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_content.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_cms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_cms.ResumeLayout(false);
            this.groupBox_cms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlimama)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl_qunfa.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.tabControl_qunfa_config.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowSnd)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_qunfa_qq_list)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage17.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_qunfa_weixin_list)).EndInit();
            this.tabPage18.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_weibo)).EndInit();
            this.tabPage19.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage20.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.tabPage21.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.tabPage22.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage23.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fenqun_qq)).EndInit();
            this.tabPage24.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fenqun_weixin)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl_tools.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabControl_tools_common.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage25.ResumeLayout(false);
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox_dama.ResumeLayout(false);
            this.groupBox_dama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox_alimama.ResumeLayout(false);
            this.groupBox_alimama.PerformLayout();
            this.ResumeLayout(false);

        }

        private void plan_OnMouseDown(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormExIni()
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            SetStyles();
        }

        private void SetStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }

        private void WmNcHitTest(ref Message m)  //调整窗体大小
        {
            int wparam = m.LParam.ToInt32();
            Point mouseLocation = new Point(RenderHelper.LOWORD(wparam), RenderHelper.HIWORD(wparam));
            mouseLocation = PointToClient(mouseLocation);

            if (WindowState != FormWindowState.Maximized)
            {
                if (CanResize == true)
                {
                    if (mouseLocation.X < 5 && mouseLocation.Y < 5)
                    {
                        m.Result = new IntPtr(Win32.HTTOPLEFT);
                        return;
                    }

                    if (mouseLocation.X > Width - 5 && mouseLocation.Y < 5)
                    {
                        m.Result = new IntPtr(Win32.HTTOPRIGHT);
                        return;
                    }

                    if (mouseLocation.X < 5 && mouseLocation.Y > Height - 5)
                    {
                        m.Result = new IntPtr(Win32.HTBOTTOMLEFT);
                        return;
                    }

                    if (mouseLocation.X > Width - 5 && mouseLocation.Y > Height - 5)
                    {
                        m.Result = new IntPtr(Win32.HTBOTTOMRIGHT);
                        return;
                    }

                    if (mouseLocation.Y < 3)
                    {
                        m.Result = new IntPtr(Win32.HTTOP);
                        return;
                    }

                    if (mouseLocation.Y > Height - 3)
                    {
                        m.Result = new IntPtr(Win32.HTBOTTOM);
                        return;
                    }

                    if (mouseLocation.X < 3)
                    {
                        m.Result = new IntPtr(Win32.HTLEFT);
                        return;
                    }

                    if (mouseLocation.X > Width - 3)
                    {
                        m.Result = new IntPtr(Win32.HTRIGHT);
                        return;
                    }
                }
            }
            m.Result = new IntPtr(Win32.HTCLIENT);
        }

        private void UpdateMaxButton()  //根据窗体的状态更换最大(还原)系统按钮
        {
            bool isMax = WindowState == FormWindowState.Maximized;
            if (isMax)
            {
                SystemButtonManager.SystemButtonArray[1].NormalImg = Image.FromFile(@".\Res\SystemButton\restore_normal.png"); 
                SystemButtonManager.SystemButtonArray[1].HighLightImg = Image.FromFile(@".\Res\SystemButton\restore_highlight.png"); 
                SystemButtonManager.SystemButtonArray[1].PressedImg = Image.FromFile(@".\Res\SystemButton\restore_press.png");
                SystemButtonManager.SystemButtonArray[1].ToolTip = "还原";
            }
            else
            {
                SystemButtonManager.SystemButtonArray[1].NormalImg = Image.FromFile(@".\Res\SystemButton\max_normal.png"); 
                SystemButtonManager.SystemButtonArray[1].HighLightImg = Image.FromFile(@".\Res\SystemButton\max_highlight.png"); 
                SystemButtonManager.SystemButtonArray[1].PressedImg = Image.FromFile(@".\Res\SystemButton\max_press.png");
                SystemButtonManager.SystemButtonArray[1].ToolTip = "最大化";
            }
        }

        protected void UpdateSystemButtonRect()
        {
            bool isShowMaxButton = MaximizeBox;
            bool isShowMinButton = MinimizeBox;
            Rectangle closeRect = new Rectangle(
                    Width - SystemButtonManager.SystemButtonArray[0].NormalImg.Width,
                    -1,
                    SystemButtonManager.SystemButtonArray[0].NormalImg.Width,
                    SystemButtonManager.SystemButtonArray[0].NormalImg.Height);

            //update close button location rect.
            SystemButtonManager.SystemButtonArray[0].LocationRect = closeRect;
                
            //Max
            if (isShowMaxButton)
            {
                SystemButtonManager.SystemButtonArray[1].LocationRect = new Rectangle(
                    closeRect.X - SystemButtonManager.SystemButtonArray[1].NormalImg.Width,
                    -1,
                    SystemButtonManager.SystemButtonArray[1].NormalImg.Width,
                    SystemButtonManager.SystemButtonArray[1].NormalImg.Height);
            }
            else
            {
                SystemButtonManager.SystemButtonArray[1].LocationRect = Rectangle.Empty;
            }

            //Min
            if (!isShowMinButton)
            {
                SystemButtonManager.SystemButtonArray[2].LocationRect = Rectangle.Empty;
                return;
            }
            if (isShowMaxButton)
            {
                SystemButtonManager.SystemButtonArray[2].LocationRect = new Rectangle(
                    SystemButtonManager.SystemButtonArray[1].LocationRect.X - SystemButtonManager.SystemButtonArray[2].NormalImg.Width,
                    -1,
                    SystemButtonManager.SystemButtonArray[2].NormalImg.Width,
                    SystemButtonManager.SystemButtonArray[2].NormalImg.Height);
            }
            else
            {
                SystemButtonManager.SystemButtonArray[2].LocationRect = new Rectangle(
                   closeRect.X - SystemButtonManager.SystemButtonArray[2].NormalImg.Width,
                   -1,
                   SystemButtonManager.SystemButtonArray[2].NormalImg.Width,
                   SystemButtonManager.SystemButtonArray[2].NormalImg.Height);
            }
        }

        #endregion


        #region init_
        public void init_() {
            try
            {
                this.webBrowser_send_content.ScriptErrorsSuppressed = true;
                this.webBrowser_send_content.Navigate("about:blank");
                this.webBrowser_send_content.IsWebBrowserContextMenuEnabled = false;
                this.webBrowser_send_content.Document.ExecCommand("EditMode", false, null);
                this.webBrowser_send_content.Document.ExecCommand("LiveResize", false, null);

                this.webBrowser_zhuanhua.ScriptErrorsSuppressed = true;
                this.webBrowser_zhuanhua.Navigate("about:blank");
                this.webBrowser_zhuanhua.IsWebBrowserContextMenuEnabled = false;
                this.webBrowser_zhuanhua.Document.ExecCommand("EditMode", false, null);
                this.webBrowser_zhuanhua.Document.ExecCommand("LiveResize", false, null);

                ConfigUtil.init_config(this);

                Thread.Sleep(2000);

                bool taoke_check_login = AlimamaUtil.check_login(this.appBean.taoke_cookie);
                if (!taoke_check_login)
                {
                    if (this.checkBoxAutoLogin.Checked)
                    {
                        AlimamaLogin.login(this, 1);
                    }
                }

                ////this.Invoke(new MethodWithoutParameter(LoadContactTemplate));
                new Thread(new ParameterizedThreadStart(CmsUtil.update_cms_list_call)).Start(this);

                BindingUtil.ini_(this);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[initWbSndContent]出错：" + exception.ToString());
            }

            try
            {
                if(!string.IsNullOrEmpty(this.appBean.qunfa)
                    && int.Parse(this.appBean.qunfa)>0)
                {
                    this.thread_user_info = new Thread(new ParameterizedThreadStart(UserUtil.updata_user_info));
                    this.thread_user_info.IsBackground = true;
                    this.thread_user_info.Start(this);
                }
            }
            catch (Exception)
            {
                
            }

            this.thread_coupon = new Thread(new ParameterizedThreadStart(CouponUtil.check_coupon));
            this.thread_coupon.IsBackground = true;
            this.thread_coupon.Start(this);

        }
        #endregion

        private void FormEx_Load(object sender, EventArgs e)
        {
            this.tabControlMain.Region = new Region(new RectangleF(this.tabPage1.Left, this.tabPage1.Top, this.tabPage1.Width, this.tabPage1.Height));
            this.tabControl_qunfa.Region = new Region(new RectangleF(this.tabPage5.Left, this.tabPage5.Top, this.tabPage5.Width, this.tabPage5.Height));
            this.tabControl_tools.Region = new Region(new RectangleF(this.tabPage11.Left, this.tabPage11.Top, this.tabPage11.Width, this.tabPage11.Height));

            //var setting = new CefSharp.CefSettings();
            //CefSharp.Cef.Initialize(setting, true, false);
            //var webView = new CefSharp.Wpf.ChromiumWebBrowser();
            //this.Content = webView;

            //webView.Address = "http://www.cnblogs.com/TianFang/";
            this.label_banben.Text = "版本号：V"+Constants.version;
            this.label_welcome.Text = "欢迎：" + this.appBean.user_name;

            this.label_user_type_name.Text = "用户类型：" + this.appBean.user_type_name;
            if (!string.IsNullOrEmpty(this.appBean.qunfa_date))
            {            
                this.label_user_type_name.Text = this.label_user_type_name.Text+"  有效期：" + this.appBean.qunfa_date;
            }

            this.contextMenuStripTask.Items.Add("退出");
            this.contextMenuStripTask.Items[0].Click += new EventHandler(this.exit);

            this.appBean.qqquan_path = string.Concat(this.app_path, "\\QQ群快捷方式");
            this.appBean.weixin_path_img = string.Concat(this.app_path, "\\config\\临时文件夹\\weixinimg");
            if (!Directory.Exists(this.appBean.qqquan_path))
            {
                Directory.CreateDirectory(this.appBean.qqquan_path);
            }
            if (Directory.Exists(this.appBean.weixin_path_img))
            {
                Directory.Delete(this.appBean.weixin_path_img,true);
            }
            if (!Directory.Exists(this.appBean.weixin_path_img))
            {
                Directory.CreateDirectory(this.appBean.weixin_path_img);
            }
            this.appBean.qqqun_list = new ArrayList();
            this.init_brower();
            this.init_followsnd();
            string out_log;
            this.sendSqlUtil.create_send_table(out out_log);
            //LogUtil.log_call(this, "out_log:" + out_log);
            this.load_follow(out out_log);
            FollowUtil.load_weibo_call(this);
            this.load_qq_qun_list();
            this.load_weixin_qun_list();

            this.thread_alimama_income = new Thread(new ParameterizedThreadStart(BindingUtil.binding_income));
            this.thread_alimama_income.IsBackground = true;
            this.thread_alimama_income.Start(this);

        }

        private void init_followsnd() { 
            //int string0=0;
            //DataGridViewRow dataGridViewRow = new DataGridViewRow();
            ////if (arrayList26.int_0 != 1)
            ////{
            ////    this.dataGridViewFollowSnd.Rows.Add(dataGridViewRow);
            ////    string0 = count;
            ////}
            ////else
            ////{
            //    this.dataGridViewFollowSnd.Rows.Insert(0, dataGridViewRow);
            //    this.dataGridViewFollowSnd.Rows.Add(new DataGridViewRow());
            //    this.dataGridViewFollowSnd.Rows.Add(new DataGridViewRow());
            //    this.dataGridViewFollowSnd.Rows.Add(new DataGridViewRow());
            //    this.dataGridViewFollowSnd.Rows.Add(new DataGridViewRow());
            //    this.dataGridViewFollowSnd.Rows.Add(new DataGridViewRow());
            //    this.dataGridViewFollowSnd.Rows.Add(new DataGridViewRow());
            //    string0 = 0;
            ////}
            //    this.dataGridViewFollowSnd.Rows[string0].HeaderCell.Value = string.Concat(string0 + 1, "");
            //    this.dataGridViewFollowSnd[0, string0].Value = "adsfasdf";
            //    //this.dataGridViewFollowSnd[1, string0].Value = ᜸.ᜄ(arrayList26.string_1);
            //    //this.dataGridViewFollowSnd[2, string0].Value = GClass13.smethod_15(arrayList26.string_2);
            //    //this.dataGridViewFollowSnd[2, string0].Style.ForeColor = GClass13.smethod_16(arrayList26.string_2);
            //    //this.dataGridViewFollowSnd[0, string0].Tag = arrayList26;
            //    this.dataGridViewFollowSnd.Rows.Insert(0, new DataGridViewRow());
        }

        private void init_brower()
        {
            try
            {
                this.contextMenuStripCtEdit.Items.Add("粘贴图文");
                this.contextMenuStripCtEdit.Items[0].Click += new EventHandler(this.method_64);
                this.contextMenuStripCtEdit.Items.Add("复制全部");
                this.contextMenuStripCtEdit.Items[1].Click += new EventHandler(this.method_65);
                this.contextMenuStripCtEdit.Items.Add("清空");
                this.contextMenuStripCtEdit.Items[2].Click += new EventHandler(this.method_66);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[initContextMenuStripCtEdit]出错：", exception.ToString()));
            }
            try
            {
                this.contextMenuStripFwSnd.Items.Add("查看群发内容(双击)");
                this.contextMenuStripFwSnd.Items[0].Click += new EventHandler(this.method_267);
                this.contextMenuStripFwSnd.Items.Add("删除群发内容");
                this.contextMenuStripFwSnd.Items[1].Click += new EventHandler(this.method_268);
                this.contextMenuStripFwSnd.Items.Add("发送选中内容");
                this.contextMenuStripFwSnd.Items[2].Click += new EventHandler(this.method_269);
                this.contextMenuStripFwSnd.Items.Add("删除全部");
                this.contextMenuStripFwSnd.Items[3].Click += new EventHandler(this.buttonFwSndDelAll_Click);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this,string.Concat("[initContentMenuTripFwSnd]出错：", exception.ToString()));
            }

            try
            {
                this.contextMenuStripTool.Items.Add("粘贴图文");
                this.contextMenuStripTool.Items[0].Click += new EventHandler(this.method_67);
                this.contextMenuStripTool.Items.Add("复制全部");
                this.contextMenuStripTool.Items[1].Click += new EventHandler(this.method_68);
                this.contextMenuStripTool.Items.Add("清空");
                this.contextMenuStripTool.Items[2].Click += new EventHandler(this.method_69);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[initContextMenuStripCtEdit]出错：", exception.ToString()));
            }

            try
            {
                this.contextMenuStrip_weibo.Items.Add("删除选中");
                this.contextMenuStrip_weibo.Items[0].Click += new EventHandler(this.weibo_del_none);
                this.contextMenuStrip_weibo.Items.Add("登陆选中");
                this.contextMenuStrip_weibo.Items[1].Click += new EventHandler(this.method_weibo_login);
                this.contextMenuStrip_weibo.Items.Add("删除全部");
                this.contextMenuStrip_weibo.Items[2].Click += new EventHandler(this.buttonWeiboDelAll_Click);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[initContextMenuStripCtEdit]出错：", exception.ToString()));
            }

            try
            {
                this.contextMenuStrip_pid_qq.Items.Add("删除选中");
                this.contextMenuStrip_pid_qq.Items[0].Click += new EventHandler(this.pid_qq_del_none);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[initContextMenuStripCtEdit]出错：", exception.ToString()));
            }
            try
            {
                this.contextMenuStrip_pid_weixin.Items.Add("删除选中");
                this.contextMenuStrip_pid_weixin.Items[0].Click += new EventHandler(this.pid_weixin_del_none);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[initContextMenuStripCtEdit]出错：", exception.ToString()));
            }
        }

        private void method_66(object sender, EventArgs e)
        {
            try
            {
                ((IHTMLDocument2)this.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                LogUtil.log_call(this, "清空成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[ClearContent_Click]出错：", exception.ToString()));
            }
        }


        private void method_64(object sender, EventArgs e)
	{
		try
		{
            this.webBrowser_send_content.Select();
            MouseUtil.paste();  //粘贴消息
            LogUtil.log_call(this, "粘贴图文成功！");
		}
		catch (Exception exception)
		{
            LogUtil.log_call(this, string.Concat("[PasteContent_Click]出错：", exception.ToString()));
		}
	}

        private void method_65(object sender, EventArgs e)
        {
            try
            {
                string out_log = "";
                if (CommonUtil.clipboard(this.webBrowser_send_content.Document.Body.InnerHtml, out out_log))
                {
                    LogUtil.log_call(this, "复制全部成功！");
                }
                else
                {
                    LogUtil.log_call(this, string.Concat("复制全部失败！", out_log));
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[CopyContent_Click]出错：", exception.ToString()));
            }
        }

        private void method_67(object sender, EventArgs e)
        {
            try
            {
                this.webBrowser_zhuanhua.Select();
                MouseUtil.paste();  //粘贴消息
                LogUtil.log_call(this, "粘贴图文成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[PasteContent_Click]出错：", exception.ToString()));
            }
        }

        private void method_68(object sender, EventArgs e)
        {
            try
            {
                ((IHTMLDocument2)this.webBrowser_zhuanhua.Document.DomDocument).body.innerHTML = "";
                LogUtil.log_call(this, "清空成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[ClearContent_Click]出错：", exception.ToString()));
            }
        }
        private void method_69(object sender, EventArgs e)
        {
            try
            {
                string out_log = "";
                if (CommonUtil.clipboard(this.webBrowser_zhuanhua.Document.Body.InnerHtml, out out_log))
                {
                    LogUtil.log_call(this, "复制全部成功！");
                }
                else
                {
                    LogUtil.log_call(this, string.Concat("复制全部失败！", out_log));
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[CopyContent_Click]出错：", exception.ToString()));
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SystemButtonManager.DrawSystemButtons(e.Graphics);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plan_OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                SystemButtonManager.ProcessMouseOperate(e.Location, MouseOperate.Down);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void layout_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.tabControlMain.SelectedTab = this.tabPage4;
            this.update_icon(4);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.tabControlMain.SelectedTab = this.tabPage3;
            this.update_icon(3);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Tab | Keys.Control):
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.tabControlMain.SelectedTab = this.tabPage1;
            this.update_icon(1);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.tabControlMain.SelectedTab = this.tabPage2;
            this.update_icon(2);
        }

        private void update_icon(int icon_index) {

            this.label_cms.Image = global::haopintui.Properties.Resources.cms;
            this.label_qunfa.Image = global::haopintui.Properties.Resources.qunfa;
            this.label_tools.Image = global::haopintui.Properties.Resources.tools;
            this.label_setting.Image = global::haopintui.Properties.Resources.setting;
            if (icon_index == 1)
            {
                this.label_cms.Image = global::haopintui.Properties.Resources.cms1;
            }
            else if (icon_index == 2)
            {
                this.label_qunfa.Image = global::haopintui.Properties.Resources.qunfa1;
            }
            else if (icon_index == 3)
            {
                this.label_tools.Image = global::haopintui.Properties.Resources.tools1;
            }
            else if (icon_index == 4)
            {
                this.label_setting.Image = global::haopintui.Properties.Resources.setting1;
            }

        }

        private void update_qunfa_icon(int icon_index)
        {

            this.button_qunfa_fa.BackColor = System.Drawing.Color.White;
            this.button_qunfa_setting.BackColor = System.Drawing.Color.White;
            this.button_qunfa_template.BackColor = System.Drawing.Color.White;
            if (icon_index == 1)
            {
                this.button_qunfa_fa.BackColor = System.Drawing.Color.DarkGray;
            }
            else if (icon_index == 2)
            {
                this.button_qunfa_setting.BackColor = System.Drawing.Color.DarkGray;
            }
            else if (icon_index == 3)
            {
                this.button_qunfa_template.BackColor = System.Drawing.Color.DarkGray;
            }

        }
        
        private void on_panel_doubleclick(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tabControl_qunfa.SelectedTab = this.tabPage5;
            this.update_qunfa_icon(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tabControl_qunfa.SelectedTab = this.tabPage6;
            this.update_qunfa_icon(2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!AlimamaUtil.check_login(this.appBean.taoke_cookie))
                {
                    LogUtil.log_call(this, "登录以后再查看和修改PID！");
                    this.appBean.alimama_login_status = false;
                    AlimamaLogin.login(this, 1);
                }
                else
                {
                    LogUtil.log_call(this, "获取qq通用广告位信息！");
                    AlimamaAdUtil.updAliPid(new Object[] { this, 2 });
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[linkLabelGetPromot_LinkClicked]出错：" + exception.ToString());
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void FormEx_SizeChanged(object sender, EventArgs e)
        {

        }

        private void TabPageRefresh()
        {
            foreach(TabPage p in this.tabControlMain.TabPages){
                p.Refresh();
            }
            foreach (TabPage p in this.tabControl_qunfa.TabPages)
            {
                p.Refresh();
            }
            foreach (TabPage p in this.tabControl_tools.TabPages)
            {
                p.Refresh();
            }
            foreach (TabPage p in this.tabControl_tools_common.TabPages)
            {
                p.Refresh();
            }
        }

        private void FormEx_Resize(object sender, EventArgs e)
        {
            this.TabPageRefresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panelTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
                if (base.WindowState == FormWindowState.Maximized)
                {
                    base.WindowState = FormWindowState.Normal;
                }
                else
                {
                    base.WindowState = FormWindowState.Maximized;
                }
            //}
           
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            SystemButtonManager.ProcessMouseOperate(e.Location, MouseOperate.Move);
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            SystemButtonManager.ProcessMouseOperate(e.Location, MouseOperate.Up);
        }

        private void panelTop_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
            SystemButtonManager.ProcessMouseOperate(Point.Empty, MouseOperate.Leave);
        }

        private void panelTop_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelTop_MouseEnter(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void FormEx_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.Hide();
            e.Cancel = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    base.Activate();
                    base.Visible = true;
                    base.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                //this.method_114("[notifyIconTask_MouseClick]出错，" + exception.ToString());
            }
        }

        private void contextMenuStripTask_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
            this.notifyIcon_task.Visible = false;
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.haopintui.net/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wenda.shaibaoj.com/");
        }

        private void button_tools_test_get_cookie_Click(object sender, EventArgs e)
        {
            if (this.appBean.alimama_cookie_put_url_status == false)
            {
                this.button_tools_test_get_cookie.Text = "停止跟踪";
                this.button_tools_test_get_cookie.BackColor = System.Drawing.Color.Gray;
                this.button_tools_test_get_cookie.ForeColor = System.Drawing.Color.Black;

                this.appBean.alimama_cookie_put_url_status = true;

                Thread thread = new Thread(new ParameterizedThreadStart(TestUtil.put_alimama_cookie_url));
                thread.IsBackground = true;
                thread.Start(this);
            }
            else
            {
                this.button_tools_test_get_cookie.Text = "开始跟踪cookie";
                this.button_tools_test_get_cookie.UseVisualStyleBackColor = true;
                this.button_tools_test_get_cookie.BackColor = System.Drawing.Color.Green;
                this.button_tools_test_get_cookie.ForeColor = System.Drawing.Color.White;

                this.appBean.alimama_cookie_put_url_status = false;
            }
        }

        private void button_cms_click_apply_Click(object sender, EventArgs e)
        {

            if (this.appBean.apply_taoke_url_status == false)
            {
                CmsUtil.cms_apply_taoke_url(this, 1);
            }
            else
            {
                CmsUtil.cms_apply_taoke_url(this, 0);
            }
        }

        private void linkLabelGetPromot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!AlimamaUtil.check_login(this.appBean.taoke_cookie))
                {
                    LogUtil.log_call(this, "登录以后再查看和修改PID！");
                    this.appBean.alimama_login_status = false;
                    AlimamaLogin.login(this, 1);
                }
                else
                {
                    LogUtil.log_call(this, "获取CMS广告位信息！");
                    AlimamaAdUtil.updAliPid(new Object[]{this,1});
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[linkLabelGetPromot_LinkClicked]出错：" + exception.ToString());
            }
        }

        private void trackBarAlimama_ValueChanged(object sender, EventArgs e)
        {
            this.label6.Text = "阿里妈妈请求间隔（秒）：" + this.trackBarAlimama.Value;
            this.appBean.alimama_request_url_time = this.trackBarAlimama.Value;
        }

        private void trackBarAlimama_Scroll(object sender, EventArgs e)
        {

        }

        protected override void DefWndProc(ref Message message)
        {
            try
            {
                //0x465
                if (message.Msg == 1125)
                {
                    if (message.LParam == IntPtr.Zero)
                    {
                        this.char_message[this.char_message_int] = (char)((int)message.WParam);
                        this.char_message_int++;
                    }
                    else
                    {
                        int login_status_int = message.LParam.ToInt32();
                        AlimamaLogin.log_login(this, login_status_int, this.unicodeEncoding.GetString(this.unicodeEncoding.GetBytes(this.char_message, 0, this.char_message_int)),1);
                        this.char_message_int = 0;
                    }
                    //LogUtil.log_qun_call(this, "--------1125------");
                }
                else if (message.Msg == 1135)
                {
                    if (message.LParam == IntPtr.Zero)
                    {
                        this.char_message[this.char_message_int] = (char)((int)message.WParam);
                        this.char_message_int++;
                    }
                    else
                    {
                        int login_status_int = message.LParam.ToInt32();
                        WeiboLogin.log_login(this, login_status_int, this.unicodeEncoding.GetString(this.unicodeEncoding.GetBytes(this.char_message, 0, this.char_message_int)), 1);
                        this.char_message_int = 0;
                    }
                    //LogUtil.log_qun_call(this, "--------1135------");
                }
                else if (message.Msg == 1126)
                {

                    if (message.LParam == IntPtr.Zero)
                    {
                        this.char_message_qq[this.char_message_int_qq] = (char)((int)message.WParam);
                        this.char_message_int_qq++;
                    }
                    else
                    {
                        int login_status_int = message.LParam.ToInt32();
                        string receiveMsg = this.unicodeEncoding.GetString(this.unicodeEncoding.GetBytes(this.char_message_qq, 0, this.char_message_int_qq));
                        
                        //AlimamaLogin.log_login(this, login_status_int, this.unicodeEncoding.GetString(this.unicodeEncoding.GetBytes(this.char_message_qq, 0, this.char_message_int_qq)), 1);
                        this.char_message_int_qq = 0;
                        QQqunUtil.sendGroup(this,receiveMsg);
                        //LogUtil.log_qun_call(this, receiveMsg);
                    }
                    //LogUtil.log_qun_call(this, "--------1126------");

                    //try
                    //{
                    //LogUtil.log_qun_call(this, "--------1126------");
                    //COPYDATASTRUCT mystr = new COPYDATASTRUCT();
                    //Type mytype = mystr.GetType();
                    //mystr = (COPYDATASTRUCT)message.GetLParam(mytype);
                    //string receiveMsg = mystr.lpData;

                    ////this.sendContent(receiveMsg);
                    //LogUtil.log_qun_call(this,receiveMsg);

                    //}
                    //catch (Exception)
                    //{
                        
                    //}
                }
                else {
                    base.DefWndProc(ref message);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[DefWndProc]出错，" + exception.ToString());
            }
        }

        private void comboBoxCmPUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmsUtil.comboBoxBrdgPUnit_SelectedIndexChanged(this,1);
        }

        private void buttonLoginAlimama2_Click(object sender, EventArgs e)
        {
            try
            {
                //this.appBean.taoke_cookie = "";
                //LogUtil.log_call(cmsForm, "" + cmsForm.appBean.taoke_cookie);
                if (AlimamaUtil.check_login(this.appBean.taoke_cookie))
                {
                    LogUtil.log_call(this, "已经登录阿里妈妈！");
                }
                else
                {
                    //this.bool_0 = false;
                    this.appBean.alimama_login_status = false;
                    AlimamaLogin.login(this,1);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[buttonLoginAlimama_Click]出错：" + exception.ToString());
            }
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void timer_kouling_Tick(object sender, EventArgs e)
        {
            if (this.appBean.apply_taoke_url_status)
            {
                //try
                //{
                //    HtmlElement elementById = this.webBrowserQuanAlimama.Document.GetElementById("mx_8");
                //    if (elementById != null && elementById.GetAttribute("className").Contains("share-kl"))
                //    {
                //        IEnumerator enumerator = elementById.GetElementsByTagName("div").GetEnumerator();
                //        {
                //            string attribute;
                //            HtmlElement current;
                //            while (enumerator.MoveNext())
                //            {
                //                current = (HtmlElement)enumerator.Current;
                //                attribute = current.GetAttribute("className");
                //                if (((attribute != null) && attribute.Contains("share-con")))
                //                {
                //                    current.InvokeMember("click");
                //                }
                //            }
                //        }
                //    }
                //}
                //catch (Exception exception)
                //{
                //    ////LogUtil.log_call(cmsForm, "exception1：[" + exception.ToString() + "]");
                //}

                //try
                //{
                //    HtmlElement elementById_kouling = this.webBrowserQuanAlimama.Document.GetElementById("atomdlg_11");
                //    if (elementById_kouling != null
                //        && elementById_kouling.GetAttribute("className").Contains("atom-dialog-wrap"))
                //    {
                //        IEnumerator enumerator = elementById_kouling.GetElementsByTagName("div").GetEnumerator();
                //        {
                //            string attribute;
                //            HtmlElement current;
                //            while (enumerator.MoveNext())
                //            {
                //                current = (HtmlElement)enumerator.Current;
                //                attribute = current.GetAttribute("className");
                //                if (((attribute != null) && attribute.Contains("kouling-content")))
                //                {
                //                    string kouling = StringUtil.subString(current.InnerHtml, 0, "👉手淘👈", "】");
                //                    //LogUtil.log_cms_call(cmsForm, "获取到口令：[" + kouling + "]");
                //                    this.appBean.taokouling = kouling;
                //                }
                //            }
                //        }
                //    }
                //}
                //catch (Exception exception)
                //{
                //    ////LogUtil.log_call(cmsForm, "exception2：[" + exception.ToString() + "]");
                //}

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wenda.shaibaoj.com/");
        }

        private void button_qunfa_open_mulu_Click(object sender, EventArgs e)
        {
            Process.Start(this.appBean.qqquan_path);
        }

        private void buttonOpenUUHP_Click(object sender, EventArgs e)
        {
            Process.Start("http://dama2.com/");
        }

        private void open_qq_qun_list()
        {
            try
            {
                foreach (string qun_str in this.appBean.qqqun_list)
                {
                    IntPtr intPtr = FindWindow(null, qun_str);
                    int num = 0;
                    if (intPtr == IntPtr.Zero)
                    {
                        try
                        {
                            Process.Start(string.Concat(this.appBean.qqquan_path, "\\", qun_str, ".lnk"));
                        }
                        catch
                        {
                        }
                        Thread.Sleep(800);
                        intPtr = FindWindow(null, qun_str);
                        if (intPtr != IntPtr.Zero)
                        {
                            SetForegroundWindow(intPtr);
                        }
                        if (num > 2)
                        {
                            break;
                        }
                    }
                    Thread.Sleep(800);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[openAllQQGrp]出错：", exception.ToString()));
            }
        }



        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int EnumWindows(GDelegate66 gdelegate66_0, IntPtr intptr_1);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
        public static extern IntPtr FindWindow(string string_96, string string_97);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr intptr_1, uint uint_0, string string_96, string string_97);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int GetClassName(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_28);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int GetWindowRect(IntPtr intptr_1, out GStruct0 gstruct0_0);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = false)]
        public static extern int GetWindowText(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_28);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
        public static extern void SetForegroundWindow(IntPtr intptr_1);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern bool ShowWindowAsync(IntPtr intptr_1, int int_28);

        private void button_qunfa_open_qun_Click(object sender, EventArgs e)
        {
            (new Thread(new ThreadStart(this.open_qq_qun_list))).Start();
        }

        private void load_weixin_qun_list()
        {
            try
            {
                this.load_weixin_list();
                this.dataGridView_qunfa_weixin_list.Rows.Clear();
                int num = 0;
                foreach (string arrayList4 in this.appBean.weixin_list)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    this.dataGridView_qunfa_weixin_list.Rows.Add(dataGridViewRow);
                    this.dataGridView_qunfa_weixin_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                    this.dataGridView_qunfa_weixin_list[0, num].Value = arrayList4;
                    //this.dataGridView_qunfa_weixin_list[1, num].Value = "  ↑↓";
                    num++;
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void load_qq_qun_list()
        {
            string arrayList;
            bool flag;
            IEnumerator enumerator;
            string current;
            IDisposable disposable;
            try
            {
                this.appBean.qqqun_list = new ArrayList();
                this.load_qq_qun_shunxu();
                this.dataGridView_qunfa_qq_list.Rows.Clear();
                string[] files = Directory.GetFiles(this.appBean.qqquan_path);
                ArrayList arrayLists = new ArrayList();
                string[] strArrays = files;
                for (int i = 0; i < (int)strArrays.Length; i++)
                {
                    string str = strArrays[i];
                    if (str.EndsWith(".lnk"))
                    {
                        string str1 = str.Substring(str.LastIndexOf("\\") + 1);
                        arrayList = str1.Substring(0, str1.IndexOf("."));
                        arrayLists.Add(arrayList);
                    }
                }
                for (int j = this.appBean.qqqun_list.Count - 1; j >= 0; j--)
                {
                    string item = (string)this.appBean.qqqun_list[j];
                    flag = false;
                    enumerator = arrayLists.GetEnumerator();
                    try
                    {
                        while (true)
                        {
                            if (enumerator.MoveNext())
                            {
                                current = (string)enumerator.Current;
                                if (item.Equals(current))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    finally
                    {
                        disposable = enumerator as IDisposable;
                        if (disposable != null)
                        {
                            disposable.Dispose();
                        }
                    }
                    if (!flag)
                    {
                        this.appBean.qqqun_list.RemoveAt(j);
                    }
                }
                foreach (string arrayList_str in arrayLists)
                {
                    flag = false;
                    IEnumerator enumerator1 = this.appBean.qqqun_list.GetEnumerator();
                    try
                    {
                        while (true)
                        {
                            if (enumerator1.MoveNext())
                            {
                                current = (string)enumerator1.Current;
                                if (arrayList_str.Equals(current))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    finally
                    {
                        disposable = enumerator1 as IDisposable;
                        if (disposable != null)
                        {
                            disposable.Dispose();
                        }
                    }
                    if (flag)
                    {
                        continue;
                    }
                    this.appBean.qqqun_list.Add(arrayList_str);
                }
                int num = 0;
                foreach (string arrayList4 in this.appBean.qqqun_list)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    this.dataGridView_qunfa_qq_list.Rows.Add(dataGridViewRow);
                    this.dataGridView_qunfa_qq_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                    this.dataGridView_qunfa_qq_list[0, num].Value = arrayList4;
                    this.dataGridView_qunfa_qq_list[1, num].Value = "  ↑↓";
                    num++;
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[loadQQGrpList]出错：", exception.ToString()));
            }
        }

        private void load_qq_qun_shunxu()
        {
            try
            {
                this.appBean.qqquan_shunxun_path = string.Concat(this.app_path, "\\config\\QQ群顺序.txt");
                this.appBean.qqqun_list = new ArrayList();
                if (File.Exists(this.appBean.qqquan_shunxun_path))
                {
                    StreamReader streamReader = new StreamReader(this.appBean.qqquan_shunxun_path, Encoding.GetEncoding("GB2312"));
                    string str = null;
                    while (true)
                    {
                        string str1 = streamReader.ReadLine();
                        str = str1;
                        if (str1 == null)
                        {
                            break;
                        }
                        if (!str.Trim().Equals(""))
                        {
                            this.appBean.qqqun_list.Add(str.Trim());
                        }
                    }
                    streamReader.Close();
                    streamReader.Dispose();
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[loadQQGrpOrder]出错：", exception.ToString()));
            }
        }

        private void load_weixin_list()
        {
            try
            {
                this.appBean.weixin_path = string.Concat(this.app_path, "\\config\\weixin.txt");
                this.appBean.weixin_list = new ArrayList();
                if (File.Exists(this.appBean.weixin_path))
                {
                    StreamReader streamReader = new StreamReader(this.appBean.weixin_path, Encoding.GetEncoding("GB2312"));
                    string str = null;
                    while (true)
                    {
                        string str1 = streamReader.ReadLine();
                        str = str1;
                        if (str1 == null)
                        {
                            break;
                        }
                        if (!str.Trim().Equals(""))
                        {
                            this.appBean.weixin_list.Add(str.Trim());
                        }
                    }
                    streamReader.Close();
                    streamReader.Dispose();
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[loadQQGrpOrder]出错：", exception.ToString()));
            }
        }

        private void button_qunfa_qq_shuaxin_Click(object sender, EventArgs e)
        {
            this.load_qq_qun_list();
        }

        private void button_qunfa_start_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            if (this.appBean.qunfa_genfa_qunfa_status == false)
            {

                if (this.checkBox_qunfa_pid.Checked
               && string.IsNullOrEmpty(PidUtil.get_qq_com_pid_call(this, null))
                    && this.checkBox_qunfa_qq_boolean.Checked == true)
                {
                    LogUtil.log_call(this, "qq通用推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【群发基础设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】！");
                    return;
                }
                if (this.checkBox_qunfa_pid.Checked
                    && string.IsNullOrEmpty(PidUtil.get_qq_queqiao_pid_call(this, null))
                   && this.checkBox_qunfa_qq_boolean.Checked == true)
                {
                    LogUtil.log_call(this, "qq鹊桥推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【群发基础设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】！");
                    return;
                }
                if (this.checkBox_qunfa_pid.Checked
               && string.IsNullOrEmpty(PidUtil.get_weixin_pid_call(this, null))
                   && this.checkBox_qunfa_weixin_boolean.Checked == true)
                {
                    LogUtil.log_call(this, "微信推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【群发基础设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】！");
                    return;
                }
                if (this.checkBox_qunfa_pid.Checked
              && string.IsNullOrEmpty(PidUtil.get_weibo_pid_call(this, null))
                  && this.checkBox_qunfa_weibo_boolean.Checked == true)
                {
                    LogUtil.log_call(this, "微博推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【群发基础设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】！");
                    return;
                }

                this.appBean.qunfa_genfa_qunfa_status = true;
                try
                {
                    ConfigUtil.save_config(this);
                    try
                    {
                        this.appBean.send_coupon_num = int.Parse(this.textBox_qunfa_coupon.Text.Trim());
                    }
                    catch
                    {
                        this.appBean.send_coupon_num = 10;
                        this.textBox_qunfa_coupon.Text = "10";
                    }
                    try
                    {
                        this.appBean.send_commission = (float)int.Parse(this.textBox_qunfa_commission.Text.Trim());
                    }
                    catch
                    {
                        this.appBean.send_commission = 10f;
                        this.textBox_qunfa_commission.Text = "10";
                    }
                    try
                    {
                        this.appBean.send_qunfa_times_jiange = int.Parse(this.textBox_qunfa_times_jiange.Text) * 1000;
                    }
                    catch
                    {
                        this.appBean.send_qunfa_times_jiange = 600000;
                        this.textBox_qunfa_times_jiange.Text = "60";
                    }
                    try
                    {
                        this.appBean.send_qunfa_times = int.Parse(this.textBox_qunfa_times.Text);
                    }
                    catch
                    {
                        this.appBean.send_qunfa_times = 1;
                        this.textBox_qunfa_times.Text = "1";
                    }
                    //if (!this.checkBoxQQGrpFw.Checked)
                    //{
                    //    this.bool_27 = false;
                    //}
                    //else if (this.radioButtonQQFollow.Checked)
                    //{
                    //    this.bool_27 = true;
                    //}
                    //else
                    //{
                    //    this.checkBoxQQGrpFw.Checked = false;
                    //    this.bool_27 = false;
                    //    this.method_115("只有【QQ群采集】模式下才能勾选【机器人采集上传采集】！");
                    //}
                    //this.bool_15 = this.checkBoxUpHotShare.Checked;
                    this.thread_send = new Thread(new ThreadStart(this.gengfa_qunfa));
                    this.thread_send.SetApartmentState(ApartmentState.MTA); 
                    this.thread_send.IsBackground = true;
                    this.thread_send.Start();
                    LogUtil.log_call(this, "启动群发！");

                    this.button_qunfa_start.Text = "停止群发";
                    this.button_qunfa_start.BackColor = System.Drawing.Color.Gray;
                    this.button_qunfa_start.ForeColor = System.Drawing.Color.Black;

                    //this.buttonLoadQQGrpList.Focus();
                }
                catch (Exception exception)
                {
                    //LogUtil.log_call(this, string.Concat("[buttonFollowSndStart_Click]出错：", exception.ToString()));
                }
            }
            else
            {
                try
                {
                    this.appBean.qunfa_genfa_qunfa_status = false;
                    this.thread_send.Abort();
                    LogUtil.log_call(this, "停止群发！");

                    this.button_qunfa_start.Text = "开始群发";
                    this.button_qunfa_start.BackColor = System.Drawing.Color.DodgerBlue;
                    this.button_qunfa_start.ForeColor = System.Drawing.Color.White;
                }
                catch (Exception)
                {
                    
                }

            }

        }

         private void gengfa_qunfa()
        {
            try
            {
                while (true)
                {
                    if (TimeUtil.is_fa(this))
                    {
                        try
                        {
                            if (this.dataGridViewFollowSnd.Rows.Count <= 0)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                SendItem tag = (SendItem)this.dataGridViewFollowSnd[0, 0].Tag;
                                //LogUtil.log_call(this, "this.dataGridViewFollowSnd.Rows.Count:" + this.dataGridViewFollowSnd.Rows.Count);
                                bool send_boolean = this.send_tag(tag);
                                if (send_boolean)
                                {
                                    try
                                    {
                                        int times = int.Parse(this.textBox_qunfa_times_jiange.Text.Trim());
                                        Thread.Sleep(1000 * times);
                                    }
                                    catch (Exception)
                                    {
                                        Thread.Sleep(5000);
                                    }
                                }
                            }
                        }
                        catch (Exception exception2)
                        {
                            Exception exception1 = exception2;
                            if (!exception1.ToString().Contains("System.Threading.ThreadAbortException"))
                            {
                                LogUtil.log_call(this, string.Concat("采集中出点问题ex1，", exception1.ToString()));
                                //this.method_264();
                            }
                        }
                    }
                    else {
                        LogUtil.log_call(this, "定时发送设置了该时段不发送商品:设置的时间段【"+TimeUtil.fa_time(this)+"】");
                        Thread.Sleep(1000);
                    }                    
                }
            }
            catch (Exception exception4)
            {
                Exception exception3 = exception4;
                if (!exception3.ToString().Contains("System.Threading.ThreadAbortException"))
                {
                    LogUtil.log_call(this,string.Concat("[followSend]出错：", exception3.ToString()));
                }
            }
        }

         private bool method_117()
        {
            bool flag;
            try
            {
                string str = this.method_124();
                this.appBean.qq_com_sid =  StringUtil.subString(str, 0, "\"sid\":", ",");
                this.appBean.qq_com_aid =  StringUtil.subString(str, 0, "\"aid\":", ",");
                if ((this.appBean.member_id == null || this.appBean.member_id.Equals("") 
                    || this.appBean.qq_com_sid == null || this.appBean.qq_com_sid.Equals("") 
                    || this.appBean.qq_com_aid == null || this.appBean.qq_com_aid.Equals("")
                    ))
                {
                    LogUtil.log_call(this,"qq通用推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【软件设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】");
                    flag = false;
                }
                else
                {
                    string[] string35 = new string[] { "mm_", this.appBean.member_id, "_", this.appBean.qq_com_sid, "_", this.appBean.qq_com_aid };
                    this.appBean.qq_com_pid = string.Concat(string35);
                    flag = true;
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[checkCmAliPid]出错：", exception.ToString()));
                flag = false;
            }
            return flag;
        }

         private bool method_119()
        {
            bool flag;
            try
            {
                string str = this.method_126();
                this.appBean.weixin_sid = StringUtil.subString(str, 0, "\"sid\":", ",");
                this.appBean.weixin_aid = StringUtil.subString(str, 0, "\"aid\":", ",");
                if ((this.appBean.member_id == null || this.appBean.member_id.Equals("")
                    || this.appBean.weixin_sid == null || this.appBean.weixin_sid.Equals("")
                    || this.appBean.weixin_aid == null || this.appBean.weixin_aid.Equals("")))
                {
                    string[] string35 = new string[] { "mm_", this.appBean.member_id, "_", this.appBean.weixin_sid, "_", this.appBean.weixin_aid };
                    this.appBean.weixin_pid = string.Concat(string35);
                    flag = true;
                }
                else
                {
                    LogUtil.log_call(this, "微信推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【软件设置】界面的【获取微信推广位】；\n也可以参考网页设置微信推广位：【】");
                    flag = false;
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[checkWxAliPid]出错：", exception.ToString()));
                flag = false;
            }
            return flag;
        }

         private string method_126()
        {
            string str;
            try
            {
                SelectedItem selectedItem = (SelectedItem)this.comboBox_weixin_tongyong_danyuan.SelectedItem;
                if (selectedItem == null)
                {
                    selectedItem = new SelectedItem();
                }
                object[] objArray = new object[] { "\"sid\":", selectedItem.getId(), ",\"sname\":\"", selectedItem.getLabel(), "\"" };
                string str1 = string.Concat(objArray);
                SelectedItem gClass24 = (SelectedItem)this.comboBox_weixin_tongyong_weizhi.SelectedItem;
                if (gClass24 == null)
                {
                    gClass24 = new SelectedItem();
                }
                objArray = new object[] { "\"aid\":", gClass24.getId(), ",\"aname\":\"", gClass24.getLabel(), "\"" };
                string str2 = string.Concat(objArray);
                string[] string35 = new string[] { "\"memid\":", this.appBean.member_id, ",", str1, ",", str2 };
                str = string.Concat(string35);
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[getWxPidStr]出错：", exception.ToString()));
                str = "";
            }
            return str;
        }

         public void method_260(int int_28, bool bool_40)
        {
            GDelegate83 gDelegate83;
            object[] int28;
            try
            {
                if (int_28 == 1)
                {
                    if (!this.buttonFollowSndStart.InvokeRequired)
                    {
                        this.buttonFollowSndStart.Enabled = bool_40;
                    }
                    else
                    {
                        gDelegate83 = new GDelegate83(this.method_260);
                        int28 = new object[] { int_28, bool_40 };
                        base.BeginInvoke(gDelegate83, int28);
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[FollowSendBtnCtl]出错：", exception.ToString()));
            }
        }

        private string method_124()
	    {
		    string str;
		    try
		    {
			    SelectedItem selectedItem = (SelectedItem)this.comboBoxCmPUnit.SelectedItem;
			    if (selectedItem == null)
			    {
				    selectedItem = new SelectedItem();
			    }
			    object[] objArray = new object[] { "\"sid\":", selectedItem.getId(), ",\"sname\":\"", selectedItem.getLabel(), "\"" };
			    string str1 = string.Concat(objArray);
			    SelectedItem gClass24 = (SelectedItem)this.comboBoxCmPPos.SelectedItem;
			    if (gClass24 == null)
			    {
				    gClass24 = new SelectedItem();
			    }
			    objArray = new object[] { "\"aid\":", selectedItem.getId(), ",\"aname\":\"", selectedItem.getLabel(), "\"" };
			    string str2 = string.Concat(objArray);
			    string[] string35 = new string[] { "\"memid\":", this.appBean.member_id, ",", str1, ",", str2 };
			    str = string.Concat(string35);
		    }
		    catch (Exception exception)
		    {
                LogUtil.log_call(this, string.Concat("[getCmPidStr]出错：", exception.ToString()));
			    str = "";
		    }
		    return str;
	    }

        private void method_267(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewFollowSnd.CurrentCell != null)
                {
                    ConfigUtil.save_config(this);
                    SendItem tag = (SendItem)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
                    (new ShowFwSndForm(tag.create_date_str)).ShowDialog();
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[ViewFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void method_weibo_login(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView_weibo.CurrentCell != null)
                {
                    WeiboBean tag = (WeiboBean)this.dataGridView_weibo[0, this.dataGridView_weibo.CurrentCell.RowIndex].Tag;
                    WeiboLogin.login(this,tag);
                }
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(this, string.Concat("[ViewFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void method_268(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewFollowSnd.CurrentCell != null)
                {
                    ConfigUtil.save_config(this);
                    SendItem tag = (SendItem)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
                    //this.method_270(tag.create_date_str);
                    this.remove_send(tag.create_date_str);
                    LogUtil.log_call(this, "删除群发内容成功！");
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[DelFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void pid_qq_del_none(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView_fenqun_qq.CurrentCell != null)
                {
                    PidBean tag = (PidBean)this.dataGridView_fenqun_qq[0, this.dataGridView_fenqun_qq.CurrentCell.RowIndex].Tag;
                    this.remove_pid_qq(tag.pid_id);
                    string out_log = "";
                    this.load_follow(out out_log);
                    LogUtil.log_call(this, "删除pid成功！");
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[DelFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void pid_weixin_del_none(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView_fenqun_weixin.CurrentCell != null)
                {
                    PidBean tag = (PidBean)this.dataGridView_fenqun_weixin[0, this.dataGridView_fenqun_weixin.CurrentCell.RowIndex].Tag;
                    this.remove_pid_weixin(tag.pid_id);
                    string out_log = "";
                    this.load_follow(out out_log);
                    LogUtil.log_call(this, "删除pid成功！");
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[DelFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void weibo_del_none(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView_weibo.CurrentCell != null)
                {
                    ConfigUtil.save_config(this);
                    WeiboBean tag = (WeiboBean)this.dataGridView_weibo[0, this.dataGridView_weibo.CurrentCell.RowIndex].Tag;
                    //this.method_270(tag.create_date_str);
                    this.remove_weibo(tag.user_name);
                    LogUtil.log_call(this, "删除微博账号成功！");
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[DelFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void method_269(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewFollowSnd.CurrentCell != null)
                {
                    SendItem tag = (SendItem)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
                    this.send_tag(tag);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[FwSnd_Click]出错：", exception.ToString()));
            }
        }

        public bool send_tag(SendItem sendItem) {
            if (sendItem.type != 2)
            {
                try
                {
                    string content = UtilFile.read_str(this.appBean.follow_path + @"\" + sendItem.create_date_str + @"\content.html");
                    if (string.IsNullOrEmpty(content))
                    {
                        LogUtil.log_call(this, "群发内容不能为空！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }

                    content = UrlUtil.parseContentWenan(this, content);
                    content = UrlUtil.copyImgContent(this, content, sendItem.create_date_str);
                    ContentItem contentItem = UrlUtil.parseContent(this, content,null, this.checkBox_qunfa_pid.Checked,true,0);
                    if ((contentItem.urlList == null || contentItem.urlList.Count == 0)
                        && this.checkBox_qunfa_link.Checked)
                    {
                        LogUtil.log_call(this, "没有连接，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }

                    if (contentItem.status<1)
                    {
                        if(!UrlUtil.isPrice(this,contentItem.get_buy_price())){
                            contentItem.status = 5;
                        }
                    }

                    if (contentItem.status < 1)
                    {
                        if (!string.IsNullOrEmpty(contentItem.num_iid))
                        {
                            string out_log = "";
                            int hours =1;
                            try 
	                        {	        
		                        hours = int.Parse(this.textBox_qunfa_times.Text.Trim());
	                        }
	                        catch (Exception){	                    }
                            ArrayList arrayList = this.sendSqlUtil.query_send_item(contentItem.num_iid, hours, out out_log);
                            if(arrayList.Count>0){
                                LogUtil.log_call(this, hours+"小时内，已经发送过该商品了，跳过发送！");
                                this.remove_send(sendItem.create_date_str);
                                return false;
                            }
                        }
                        if (this.checkBox_qunfa_qq_boolean.Checked) //开启了qq发送
                        {
                            LogUtil.log_call(this, "开始qq群的发送1！");
                            string content_send = contentItem.content_send;
                            content_send = UrlUtil.template_qq(this, contentItem, PidUtil.get_qq_com_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked, this.appBean.qq_template);
                            LogUtil.log_call(this, "发送开始！");
                            //if (this.checkBox_qunfa_qq_kouling_boolean.Checked==true)
                            //{
                            //    string kouling = UrlUtil.parseContent_kouling(this, contentItem, PidUtil.get_qq_com_pid(this, this.appBean.member_id), true);
                            //    content_send = content_send + kouling;
                            //}
                            QqUtil.send(this, content_send, content, contentItem.url_type, sendItem.type);
                        }
                        if (this.checkBox_qunfa_weixin_boolean.Checked) //开启了qq发送
                        {
                            UrlUtil.parseContent_weixin(this, contentItem, PidUtil.get_weixin_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked);

                            UrlUtil.template_qq(this, contentItem, PidUtil.get_weixin_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked, this.appBean.weixin_template);
                    
                            LogUtil.log_call(this, "开始微信群的发送！");
                            WeixinUtil.send(this, contentItem.content_weixin, contentItem.content_weixin_img, contentItem.imgList, content, contentItem.url_type, sendItem.type);
                        }

                        if (this.checkBox_qunfa_weibo_boolean.Checked) //开启了qq发送
                        {
                            UrlUtil.parseContent_weixin(this, contentItem, PidUtil.get_weibo_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked);

                            UrlUtil.template_qq(this, contentItem, PidUtil.get_weibo_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked, this.appBean.weibo_template);

                            LogUtil.log_call(this, "开始微博的发送！");
                            WeiboUtil.send(this, contentItem.content_weixin, contentItem.content_weixin_img, contentItem.imgList, content, contentItem.url_type, sendItem.type);
                        }

                        if(!string.IsNullOrEmpty(contentItem.num_iid)){
                            string out_log = "";
                            this.sendSqlUtil.insert_item(contentItem.num_iid, out out_log);
                        }
                    }
                    else if (contentItem.status == 1)
                    {
                        LogUtil.log_call(this, "优惠券小于最低优惠券要求，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }
                    else if (contentItem.status == 2)
                    {
                        LogUtil.log_call(this, "佣金比例小于设置的最低比例，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }

                    else if (contentItem.status == 3)
                    {
                        LogUtil.log_call(this, "所发的链接转换失败，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }
                    else if (contentItem.status == 4)
                    {
                        int hours = 1;
                        try
                        {
                            hours = int.Parse(this.textBox_qunfa_times.Text.Trim());
                        }
                        catch (Exception) { }
                        LogUtil.log_call(this, hours + "小时内，已经发送过该商品了，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }
                    else if (contentItem.status == 5)
                    {
                        LogUtil.log_call(this, "产品价格不在区间内，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    //LogUtil.log_call(this, ex.ToString());
                }
            }
            else {
                try
                {
                    string content = UtilFile.read_str(this.appBean.follow_path + @"\" + sendItem.create_date_str + @"\content.html");
                    if (string.IsNullOrEmpty(content))
                    {
                        LogUtil.log_call(this, "群发内容不能为空！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }

                    content = UrlUtil.parseContentWenan(this, content);
                    content = UrlUtil.copyImgContent(this, content, sendItem.create_date_str);
                    ContentItem contentItem = UrlHptUtil.parseContent(this, content, null, this.checkBox_qunfa_pid.Checked, true, 0);
                    if ((contentItem.urlList == null || contentItem.urlList.Count == 0)
                        && this.checkBox_qunfa_link.Checked)
                    {
                        LogUtil.log_call(this, "没有连接，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }

                    if (contentItem.status < 1)
                    {
                        if (!string.IsNullOrEmpty(contentItem.num_iid))
                        {
                            string out_log = "";
                            int hours = 1;
                            try
                            {
                                hours = int.Parse(this.textBox_qunfa_times.Text.Trim());
                            }
                            catch (Exception) { }
                            ArrayList arrayList = this.sendSqlUtil.query_send_item(contentItem.num_iid, hours, out out_log);
                            if (arrayList.Count > 0)
                            {
                                LogUtil.log_call(this, hours + "小时内，已经发送过该商品了，跳过发送！");
                                this.remove_send(sendItem.create_date_str);
                                return false;
                            }
                        }
                        if (this.checkBox_qunfa_qq_boolean.Checked) //开启了qq发送
                        {
                            LogUtil.log_call(this, "开始qq群的发送1！");
                            string content_send = contentItem.content_send;
                            //content_send = UrlUtil.template_qq(this, contentItem, PidUtil.get_qq_com_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked, this.appBean.qq_template);
                            LogUtil.log_call(this, "发送开始！");
                            QqUtil.send(this, content_send, content, contentItem.url_type, sendItem.type);
                        }
                        if (this.checkBox_qunfa_weixin_boolean.Checked) //开启了qq发送
                        {
                            UrlUtil.parseContent_weixin(this, contentItem, PidUtil.get_weixin_pid_call(this, this.appBean.member_id), false);

                            //UrlUtil.template_qq(this, contentItem, PidUtil.get_weixin_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked, this.appBean.weixin_template);

                            LogUtil.log_call(this, "开始微信群的发送！");
                            WeixinUtil.send(this, contentItem.content_send, contentItem.content_weixin_img, contentItem.imgList, content, contentItem.url_type, sendItem.type);
                        }

                        if (this.checkBox_qunfa_weibo_boolean.Checked) //开启了qq发送
                        {
                            UrlUtil.parseContent_weixin(this, contentItem, PidUtil.get_weibo_pid_call(this, this.appBean.member_id), false);

                            //UrlUtil.template_qq(this, contentItem, PidUtil.get_weibo_pid_call(this, this.appBean.member_id), this.checkBox_qunfa_pid.Checked, this.appBean.weibo_template);

                            LogUtil.log_call(this, "开始微博的发送！");
                            WeiboUtil.send(this, contentItem.content_send, contentItem.content_weixin_img, contentItem.imgList, content, contentItem.url_type, sendItem.type);
                        }

                        if (!string.IsNullOrEmpty(contentItem.num_iid))
                        {
                            string out_log = "";
                            this.sendSqlUtil.insert_item(contentItem.num_iid, out out_log);
                        }
                    }
                    //else if (contentItem.status == 1)
                    //{
                    //    LogUtil.log_call(this, "优惠券小于最低优惠券要求，跳过发送！");
                    //    this.remove_send(sendItem.create_date_str);
                    //    return false;
                    //}
                    else if (contentItem.status == 2)
                    {
                        LogUtil.log_call(this, "佣金比例小于设置的最低比例，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }
                    else if (contentItem.status == 3)
                    {
                        LogUtil.log_call(this, "所发的链接转换失败，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }
                    else if (contentItem.status == 4)
                    {
                        int hours = 1;
                        try
                        {
                            hours = int.Parse(this.textBox_qunfa_times.Text.Trim());
                        }
                        catch (Exception) { }
                        LogUtil.log_call(this, hours + "小时内，已经发送过该商品了，跳过发送！");
                        this.remove_send(sendItem.create_date_str);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    //LogUtil.log_call(this, ex.ToString());
                }
            }
            try
            {
                this.remove_send(sendItem.create_date_str);
            }
            catch (Exception exception)
            { }
            return true;
        }

        private void buttonFwSndDelAll_Click(object sender, EventArgs e)
        {
            try
            {
                //for (int i = 0; i < this.dataGridViewFollowSnd.Rows.Count; i++)
                //{
                //}
                string out_log;
                this.sendSqlUtil.delete_send_all(out out_log);
                this.dataGridViewFollowSnd.Rows.Clear();

                if (Directory.Exists(this.appBean.follow_path))
                {
                    //获取指定路径下所有文件夹
                    string[] folderPaths = Directory.GetDirectories(this.appBean.follow_path);

                    foreach (string folderPath in folderPaths)
                        Directory.Delete(folderPath, true);
                    //获取指定路径下所有文件
                    string[] filePaths = Directory.GetFiles(this.appBean.follow_path);

                    foreach (string filePath in filePaths)
                        File.Delete(filePath);
                }

                //while (this.dataGridViewFollowSnd.Rows.Count>0)
                //{
                //    SendItem tag = (SendItem)this.dataGridViewFollowSnd[0, 0].Tag;
                //    this.remove_send(tag.create_date_str);
                //}
                //this.dataGridViewFollowSnd.Rows.Clear();
                LogUtil.log_call(this, "删除全部消息成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[buttonFwSndDelAll_Click]出错：", exception.ToString()));
            }
        }

        private void buttonWeiboDelAll_Click(object sender, EventArgs e)
        {
            try
            {
                while (this.dataGridView_weibo.Rows.Count > 0)
                {
                    WeiboBean tag = (WeiboBean)this.dataGridView_weibo[0, 0].Tag;
                    this.remove_weibo(tag.user_name);
                }
                LogUtil.log_call(this, "删除全部微博账号成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[buttonWeiboDelAll_Click]出错：", exception.ToString()));
            }
        }

        public void remove_send(string create_date_str)
	    {
		    try
		    {
			    if (!this.dataGridViewFollowSnd.InvokeRequired)
			    {
				    int num = 0;
				    while (true)
				    {
					    if ((num>0
                            && num >= this.dataGridViewFollowSnd.Rows.Count) || this.dataGridViewFollowSnd.Rows.Count==0)
					    {
						    break;
					    }
                        else if (create_date_str.Equals(((SendItem)this.dataGridViewFollowSnd[0, num].Tag).create_date_str))
					    {
                            SendItem sendItem = (SendItem)this.dataGridViewFollowSnd[0, num].Tag;
						    this.dataGridViewFollowSnd.Rows.RemoveAt(num);
                            string out_log = "";
                            this.sendSqlUtil.delete_send_create(sendItem.create_date_str, out out_log);
                            if (!string.IsNullOrEmpty(sendItem.create_date_str))
                            {
                                Directory.Delete(this.appBean.follow_path + @"\" + sendItem.create_date_str, true);
                                //UtilFile.delete_dir(this.appBean.follow_path + @"\" + sendItem.create_date_str);
                            }
						    break;
					    }
					    else
					    {
						    num++;
					    }
				    }
				    for (int i = 0; i < this.dataGridViewFollowSnd.Rows.Count; i++)
				    {
					    this.dataGridViewFollowSnd.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
				    }
			    }
			    else
			    {
				    GDelegate85 gDelegate85 = new GDelegate85(this.remove_send);
				    object[] string96 = new object[] { create_date_str };
				    base.Invoke(gDelegate85, string96);
			    }
		    }
		    catch (Exception exception)
		    {
			   LogUtil.log_call(this, string.Concat("[deleteDataGridViewFollowSnd]出错了！只是小错，吓吓你们的：", exception.ToString()));
		    }
	    }

        public void remove_weibo(string user_name)
        {
            try
            {
                if (!this.dataGridView_weibo.InvokeRequired)
                {
                    int num = 0;
                    while (true)
                    {
                        if ((num > 0
                            && num >= this.dataGridView_weibo.Rows.Count) || this.dataGridView_weibo.Rows.Count == 0)
                        {
                            break;
                        }
                        else if (user_name.Equals(((WeiboBean)this.dataGridView_weibo[0, num].Tag).user_name))
                        {
                            WeiboBean weiboBean = (WeiboBean)this.dataGridView_weibo[0, num].Tag;
                            this.dataGridView_weibo.Rows.RemoveAt(num);
                            string out_log = "";
                            this.sendSqlUtil.delete_weibo(weiboBean.user_name, out out_log);
                            break;
                        }
                        else
                        {
                            num++;
                        }
                    }
                    for (int i = 0; i < this.dataGridView_weibo.Rows.Count; i++)
                    {
                        this.dataGridView_weibo.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                    }
                }
                else
                {
                    GDelegate85 gDelegate85 = new GDelegate85(this.remove_weibo);
                    object[] string96 = new object[] { user_name };
                    base.Invoke(gDelegate85, string96);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[deleteDataGridViewFollowSnd]出错了！只是小错，吓吓你们的：", exception.ToString()));
            }
        }

        public void remove_pid_qq(int pid_id)
        {
            try
            {
                if (!this.dataGridView_fenqun_qq.InvokeRequired)
                {
                    int num = 0;
                    while (true)
                    {
                        if ((num > 0
                            && num >= this.dataGridView_fenqun_qq.Rows.Count) || this.dataGridView_fenqun_qq.Rows.Count == 0)
                        {
                            break;
                        }
                        else if (pid_id == (((PidBean)this.dataGridView_fenqun_qq[0, num].Tag).pid_id))
                        {
                            PidBean pidBean = (PidBean)this.dataGridView_fenqun_qq[0, num].Tag;
                            this.dataGridView_fenqun_qq.Rows.RemoveAt(num);
                            string out_log = "";
                            this.sendSqlUtil.delete_pid(pidBean.pid_id, out out_log);
                            break;
                        }
                        else
                        {
                            num++;
                        }
                    }
                    for (int i = 0; i < this.dataGridView_fenqun_qq.Rows.Count; i++)
                    {
                        this.dataGridView_fenqun_qq.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                    }
                }
                else
                {
                    GDelegate185 gDelegate185 = new GDelegate185(this.remove_pid_qq);
                    object[] string96 = new object[] { pid_id };
                    base.Invoke(gDelegate185, string96);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[remove_pid_qq]出错了！只是小错，吓吓你们的：", exception.ToString()));
            }
        }

        public void remove_pid_weixin(int pid_id)
        {
            try
            {
                if (!this.dataGridView_fenqun_weixin.InvokeRequired)
                {
                    int num = 0;
                    while (true)
                    {
                        if ((num > 0
                            && num >= this.dataGridView_fenqun_weixin.Rows.Count) || this.dataGridView_fenqun_weixin.Rows.Count == 0)
                        {
                            break;
                        }
                        else if (pid_id == (((PidBean)this.dataGridView_fenqun_weixin[0, num].Tag).pid_id))
                        {
                            PidBean pidBean = (PidBean)this.dataGridView_fenqun_weixin[0, num].Tag;
                            this.dataGridView_fenqun_weixin.Rows.RemoveAt(num);
                            string out_log = "";
                            this.sendSqlUtil.delete_pid(pidBean.pid_id, out out_log);
                            break;
                        }
                        else
                        {
                            num++;
                        }
                    }
                    for (int i = 0; i < this.dataGridView_fenqun_weixin.Rows.Count; i++)
                    {
                        this.dataGridView_fenqun_weixin.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                    }
                }
                else
                {
                    GDelegate185 gDelegate185 = new GDelegate185(this.remove_pid_qq);
                    object[] string96 = new object[] { pid_id };
                    base.Invoke(gDelegate185, string96);
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[remove_pid_qq]出错了！只是小错，吓吓你们的：", exception.ToString()));
            }
        }
    
        private void method_270(string create_date_str)
	    {
		    FileStream fileStream = File.Create(string.Concat(this.app_path+Constants.config_follow_path, "\\", create_date_str, "\\2.txt"));
		    fileStream.Close();
		    fileStream.Dispose();
	    }

        public bool method_121(IntPtr intptr_1, IntPtr intptr_2)
	    {
		    bool flag;
		    StringBuilder stringBuilder = new StringBuilder();
		    CmsForm.GetWindowText(intptr_1, stringBuilder, stringBuilder.Capacity);
		    if ((stringBuilder.ToString() == string.Empty ? false : stringBuilder.ToString().Contains("微信")))
		    {
			    StringBuilder stringBuilder1 = new StringBuilder();
			    CmsForm.GetClassName(intptr_1, stringBuilder1, 2000);
			    if (!"WeChatMainWndForPC".Equals(stringBuilder1.ToString()))
			    {
				    flag = true;
				    return flag;
			    }
			    this.appBean.weixin_win_id = intptr_1;
			    flag = true;
			    return flag;
		    }
		    flag = true;
		    return flag;
	    }

        private void comboBox_qq_tongyong_danyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmsUtil.comboBoxBrdgPUnit_SelectedIndexChanged(this,2);
        }

        private void comboBox_weixin_tongyong_danyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmsUtil.comboBoxBrdgPUnit_SelectedIndexChanged(this,4);
        }
        private void comboBox_weibo_tongyong_danyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmsUtil.comboBoxBrdgPUnit_SelectedIndexChanged(this, 5);
        }

        private void comboBox_qq_queqiao_danyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmsUtil.comboBoxBrdgPUnit_SelectedIndexChanged(this,3);
        }

        private void linkLabel_get_qq_guangg_queqiao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!AlimamaUtil.check_login(this.appBean.taoke_cookie))
                {
                    LogUtil.log_call(this, "登录以后再查看和修改PID！");
                    this.appBean.alimama_login_status = false;
                    AlimamaLogin.login(this, 1);
                }
                else
                {
                    LogUtil.log_call(this, "获取qq鹊桥广告位信息！");
                    AlimamaAdUtil.updAliPid(new Object[] { this, 3 });
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[linkLabelGetPromot_LinkClicked]出错：" + exception.ToString());
            }
        }

        private void linkLabel_get_weixin_guanggao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!AlimamaUtil.check_login(this.appBean.taoke_cookie))
                {
                    LogUtil.log_call(this, "登录以后再查看和修改PID！");
                    this.appBean.alimama_login_status = false;
                    AlimamaLogin.login(this, 1);
                }
                else
                {
                    LogUtil.log_call(this, "获微信广告位信息！");
                    AlimamaAdUtil.updAliPid(new Object[] { this, 4 });
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[linkLabelGetPromot_LinkClicked]出错：" + exception.ToString());
            }
        }

        private void linkLabel_get_weibo_guanggao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!AlimamaUtil.check_login(this.appBean.taoke_cookie))
                {
                    LogUtil.log_call(this, "登录以后再查看和修改PID！");
                    this.appBean.alimama_login_status = false;
                    AlimamaLogin.login(this, 1);
                }
                else
                {
                    LogUtil.log_call(this, "获微博广告位信息！");
                    AlimamaAdUtil.updAliPid(new Object[] { this, 5 });
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, "[linkLabelGetPromot_LinkClicked]出错：" + exception.ToString());
            }
        }

        private void button_save_config_qunfa_Click(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void button_qunfa_shoudong_qingkong_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            try
            {
                ((IHTMLDocument2)this.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                LogUtil.log_call(this, "清空成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[ClearContent_Click]出错：", exception.ToString()));
            }
        }

        private void button_qunfa_shoudong_fasong_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            this.appBean.send_status = true;
            string content = this.webBrowser_send_content.Document.Body.InnerHtml;
            if (string.IsNullOrEmpty(content))
            {
                LogUtil.log_call(this, "群发内容不能为空！");
                ((IHTMLDocument2)this.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                return;
            }
            //LogUtil.log_call(this, "this.checkBox_qunfa_qq_boolean.Checked:" + this.checkBox_qunfa_qq_boolean.Checked);

            if (this.checkBox_qunfa_pid.Checked
                &&(
                    (this.checkBox_qunfa_qq_boolean.Checked && string.IsNullOrEmpty(PidUtil.get_qq_com_pid_call(this, null)))
                ))
            {
                LogUtil.log_call(this, "qq群通用广告位没有设置，请在群发设置里面设置广告位【】！");
                return;
            }
            else if (this.checkBox_qunfa_pid.Checked
                && (
                    (this.checkBox_qunfa_qq_boolean.Checked && string.IsNullOrEmpty(PidUtil.get_qq_queqiao_pid_call(this, null)))
                ))
            {
                LogUtil.log_call(this, "qq群鹊桥广告位没有设置，请在群发设置里面设置广告位【】！");
                return;
            }
            else if (this.checkBox_qunfa_pid.Checked
                && (
                    (this.checkBox_qunfa_weixin_boolean.Checked && string.IsNullOrEmpty(PidUtil.get_weixin_pid_call(this, null)))
                ))
            {
                LogUtil.log_call(this, "微信广告位没有设置，请在群发设置里面设置广告位【】！");
                return;
            }

            QunfaUtil.qunfa_shoudong_fasong_call(this, content);
        }

        private void button_qunfa_shoudong_gengfa_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            QunfaUtil.qunfa_shoudong_gengfa_call(this, null);
        }

        private void load_follow(out string out_log) {
            out_log = "";
            FollowUtil.load_call(this);
            FollowUtil.load_pid_call(this, 1);
            FollowUtil.load_pid_call(this, 2);
        }

        private void buttonUUWiseLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonTestCode_Click(object sender, EventArgs e)
        {

        }

        private void button_tools_qingkong_Click(object sender, EventArgs e)
        {
            try
            {
                ((IHTMLDocument2)this.webBrowser_zhuanhua.Document.DomDocument).body.innerHTML = "";
                LogUtil.log_call(this, "清空成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[ClearContent_Click]出错：", exception.ToString()));
            }
        }

        private void button_tools_zhuanhua_copy_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            string content = this.webBrowser_zhuanhua.Document.Body.InnerHtml;
            if (string.IsNullOrEmpty(content))
            {
                LogUtil.log_call(this, "跟发内容不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(PidUtil.get_qq_com_pid_call(this, null))
                && string.IsNullOrEmpty(PidUtil.get_weixin_pid_call(this, null))
                && string.IsNullOrEmpty(PidUtil.get_qq_queqiao_pid_call(this, null))
                )
            {
                LogUtil.log_call(this, "qq通用/鹊桥/微信推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【群发基础设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】！");
                return;
            }


            try
            {
                this.thread_zhuan_copy.Abort();
            } catch (Exception){}

            this.thread_zhuan_copy = new Thread(new ParameterizedThreadStart(this.zhuanhua_copy_Click_call));
            this.thread_zhuan_copy.IsBackground = true;
            this.thread_zhuan_copy.Start(new Object[] { this, content });

        }

        public void zhuanhua_copy_Click_call(object obj)
        {
            Object[] obj_list = (Object[])obj;
            CmsForm cmsForm = (CmsForm)obj_list[0];
            String content = (String)obj_list[1];
            ToolsUtil.zhuanhua_copy_Click_call(this,content);
        }

        private void button_tools_zhuanhua_tianjia_zhushou_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            ToolsUtil.tools_zhuanhua_tianjia_zhushou_call(this, null);
        }

        private void button_qunfa_weixin_huoqu_Click(object sender, EventArgs e)
        {
            //foreach (Process process in Process.GetProcesses())
            //{
            //    LogUtil.log_call(this, "name:" + process.ProcessName);
            //}
            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //{
            //        LogUtil.log_call(this, "name:" + Application.OpenForms[i].Name);
            //    //if (Application.OpenForms[i].Name != "index")
            //        //Application.OpenForms[i].Close();
            //}

            ArrayList weixinList = ProcessesUtil.getWindows(this, "ChatWnd");
            try
            {
                this.appBean.weixin_list = weixinList;
                this.dataGridView_qunfa_weixin_list.Rows.Clear();
                //this.load_qq_qun_shunxu();
                int num = 0;
                foreach (string arrayList4 in this.appBean.weixin_list)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    this.dataGridView_qunfa_weixin_list.Rows.Add(dataGridViewRow);
                    this.dataGridView_qunfa_weixin_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                    this.dataGridView_qunfa_weixin_list[0, num].Value = arrayList4;
                    //this.dataGridView_qunfa_weixin_list[1, num].Value = "  ↑↓";
                    num++;
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[loadWeixinList]出错：", exception.ToString()));
            }
            this.save_weixin_list();
        }

        private void save_weixin_list()
        {
            try
            {
                if (File.Exists(this.appBean.weixin_path))
                {
                    File.Delete(this.appBean.weixin_path);
                }
                FileStream fileStream = new FileStream(this.appBean.weixin_path, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding("GB2312"));
                foreach (string arrayList4 in this.appBean.weixin_list)
                {
                    streamWriter.WriteLine(arrayList4);
                }
                streamWriter.Flush();
                streamWriter.Close();
                streamWriter.Dispose();
                fileStream.Close();
                fileStream.Dispose();
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[saveWeixinGrpOrderList]出错：", exception.ToString()));
            }
        }

        private delegate bool WNDENUMPROC(IntPtr hWnd, int lParam);
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);
        //[DllImport("user32.dll")] 
        //private static extern IntPtr FindWindowW(string lpClassName, string lpWindowName); 
        [DllImport("user32.dll")]
        private static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        public WindowInfo[] GetAllDesktopWindows()
        {
            List<WindowInfo> wndList = new List<WindowInfo>();

            //enum all desktop windows 
            EnumWindows(delegate(IntPtr hWnd, int lParam)
            {
                try
                {
                    WindowInfo wnd = new WindowInfo();
                    StringBuilder sb = new StringBuilder(2560);
                    //get hwnd 
                    wnd.hWnd = hWnd;
                    //get window name 
                    GetWindowTextW(hWnd, sb, sb.Capacity);
                    wnd.szWindowName = sb.ToString();
                    //get window class 
                    GetClassNameW(hWnd, sb, sb.Capacity);
                    wnd.szClassName = sb.ToString();
                    //add it into list 
                    wndList.Add(wnd);
                }
                catch (Exception)
                {                    
                }
                return true;
            }, 0);

            return wndList.ToArray();
        }

        private void buttonFollowSndStart_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }
            if (this.appBean.qunfa_genfa_status == false)
            {
                this.appBean.qunfa_genfa_status = true;
                this.thread_gengfa = new Thread(new ThreadStart(this.gengfa));
                this.thread_gengfa.IsBackground = true;
                this.thread_gengfa.Start();
                LogUtil.log_call(this, "开始采集！");

                this.buttonFollowSndStart.Text = "停止采集";
                this.buttonFollowSndStart.BackColor = System.Drawing.Color.Gray;
                this.buttonFollowSndStart.ForeColor = System.Drawing.Color.Black;

                if (this.checkBox_gengfa_qq.Checked)
                {
                    this.thread_gengfa_qq = new Thread(new ThreadStart(this.gengfa_qq_jiankong));
                    this.thread_gengfa_qq.IsBackground = true;
                    this.thread_gengfa_qq.Start();
                }

                if (this.checkBox_qunfa_top.Checked)
                {
                    this.thread_gengfa_top = new Thread(new ThreadStart(this.gengfa_top));
                    this.thread_gengfa_top.IsBackground = true;
                    this.thread_gengfa_top.Start();
                }

            }
            else
            {
                try
                {
                    this.appBean.qunfa_genfa_status = false;
                    this.thread_gengfa.Abort();
                    LogUtil.log_call(this, "停止采集！");

                    this.buttonFollowSndStart.Text = "开始采集";
                    this.buttonFollowSndStart.BackColor = System.Drawing.Color.DodgerBlue;
                    this.buttonFollowSndStart.ForeColor = System.Drawing.Color.White;
                }
                catch (Exception)
                {                    
                }
                try
                {
                    this.thread_gengfa_top.Abort();
                }
                catch (Exception)
                {
                }
            }
        }

        private void gengfa_qq_jiankong()
        {
            QQqunUtil.call_qq(this);
        }
        private void gengfa()
        {
            object[] string0;
            try
            {
                while (true)
                {
                    //LogUtil.log_call(this, "--------");

                    if (TimeUtil.is_fa(this)||true)
                    {
                        //LogUtil.log_call(this, "--------");
                        Thread.Sleep(1000);
                        try
                        {
                            string out_log = "";
                            ArrayList list = UserUtil.query_gengfa_item_list(this);
                            foreach (GengfaItem gengfaItem in list)
                            {
                                if (gengfaItem != null)
                                {

                                    SendItem sendItem = new SendItem();
                                    sendItem.from = gengfaItem.from;
                                    sendItem.create_date_str = gengfaItem.create_date_str;
                                    sendItem.num_iid = gengfaItem.num_iid;
                                    sendItem.goods_type = gengfaItem.goods_type;
                                    sendItem.type = gengfaItem.type;

                                    ArrayList arrayList = this.sendSqlUtil.query_send(sendItem.num_iid, sendItem.goods_type, out out_log);
                                    if (arrayList.Count <= 0)
                                    {
                                        FollowUtil.load_item(this,sendItem);
                                        string content = gengfaItem.content;

                                        //LogUtil.log_call(this, sendItem.create_date_str);

                                        if (!string.IsNullOrEmpty(content))
                                        {
                                            //content = UrlUtil.copyImgContent(this, content, sendItem.create_date_str);
                                            sendItem.memo = CommonUtil.toText(content);
                                            string follow_path = this.appBean.follow_path + @"\" + sendItem.create_date_str;
                                            if (!Directory.Exists(follow_path))
                                            {
                                                Directory.CreateDirectory(follow_path);
                                            }
                                            //UtilFile.write(string.Concat(follow_path, "\\content_wenan.html"), UrlUtil.parseContentWenan(this, content), Encoding.GetEncoding("GB2312"));

                                            //UtilFile.write(string.Concat(follow_path, "\\content_img.html"), UrlUtil.parseImg(this, content), Encoding.GetEncoding("GB2312"));
                                            UtilFile.write(string.Concat(follow_path, "\\content.html"), content, Encoding.GetEncoding("GB2312"));
                                            //((IHTMLDocument2)this.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                                            //LogUtil.log_call(this,"---------------------");
                                            this.sendSqlUtil.insert(sendItem, out out_log);
                                            //LogUtil.log_call(this, "-----------out_log----------" + out_log);
                                        }
                                    }

                                }
                                //string out_log = "";
                                //LogUtil.log_call(this, "添加采集成功！");
                            }
                            //if (list.Count>0)
                            //{                            
                            //    this.load_follow(out out_log);
                            //}

                        }
                        catch (Exception exception2)
                        {
                            Exception exception1 = exception2;
                            if (!exception1.ToString().Contains("System.Threading.ThreadAbortException"))
                            {
                                LogUtil.log_call(this, string.Concat("采集中出点问题ex1，", exception1.ToString()));
                                //this.method_264();
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception exception4)
            {
                Exception exception3 = exception4;
                if (!exception3.ToString().Contains("System.Threading.ThreadAbortException"))
                {
                    LogUtil.log_call(this, string.Concat("[followSend]出错：", exception3.ToString()));
                }
            }
        }

        private void gengfa_top()
        {
            object[] string0;
            try
            {
                while (true)
                {
                    if (TimeUtil.is_fa(this))
                    {
                        try
                        {
                            string out_log = "";
                            ArrayList list = UserUtil.query_gengfa_top_item_list(this);
                            foreach (GengfaItem gengfaItem in list)
                            {
                                if (gengfaItem != null)
                                {
                                    SendItem sendItem = new SendItem();
                                    sendItem.from = gengfaItem.from;
                                    sendItem.create_date_str = gengfaItem.create_date_str;
                                    sendItem.num_iid = gengfaItem.num_iid;
                                    sendItem.goods_type = gengfaItem.goods_type;
                                    sendItem.type = gengfaItem.type;

                                    ArrayList arrayList = this.sendSqlUtil.query_send(sendItem.num_iid, sendItem.goods_type, out out_log);
                                    if (arrayList.Count <= 0)
                                    {
                                        FollowUtil.load_item(this, sendItem);
                                        string content = gengfaItem.content;

                                        //LogUtil.log_call(this, sendItem.create_date_str);

                                        if (!string.IsNullOrEmpty(content))
                                        {
                                            //content = UrlUtil.copyImgContent(this, content, sendItem.create_date_str);
                                            sendItem.memo = CommonUtil.toText(content);
                                            string follow_path = this.appBean.follow_path + @"\" + sendItem.create_date_str;
                                            if (!Directory.Exists(follow_path))
                                            {
                                                Directory.CreateDirectory(follow_path);
                                            }
                                            //UtilFile.write(string.Concat(follow_path, "\\content_wenan.html"), UrlUtil.parseContentWenan(this, content), Encoding.GetEncoding("GB2312"));

                                            //UtilFile.write(string.Concat(follow_path, "\\content_img.html"), UrlUtil.parseImg(this, content), Encoding.GetEncoding("GB2312"));
                                            UtilFile.write(string.Concat(follow_path, "\\content.html"), content, Encoding.GetEncoding("GB2312"));
                                            //((IHTMLDocument2)this.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                                            //LogUtil.log_call(this,"---------------------");
                                            this.sendSqlUtil.insert(sendItem, out out_log);


                                            //LogUtil.log_call(this, "-----------out_log----------" + out_log);
                                        }
                                    }
                                }
                                //string out_log = "";
                                //LogUtil.log_call(this, "添加采集成功！");
                            }
                            //if (list.Count>0)
                            //{                            
                            //    this.load_follow(out out_log);
                            //}
                        }
                        catch (Exception exception2)
                        {
                            Exception exception1 = exception2;
                            if (!exception1.ToString().Contains("System.Threading.ThreadAbortException"))
                            {
                                LogUtil.log_call(this, string.Concat("采集中出点问题ex1，", exception1.ToString()));
                                //this.method_264();
                            }
                        }
                        Thread.Sleep(this.appBean.qunfa_caiji_pinlv * 60 * 1000);
                    }
                    else {
                        LogUtil.log_call(this, "定时发送设置了该时段不监控热门商品:设置的时间段【" + TimeUtil.fa_time(this) + "】");
                        Thread.Sleep(1000);
                    }
                   
                }
            }
            catch (Exception exception4)
            {
                Exception exception3 = exception4;
                if (!exception3.ToString().Contains("System.Threading.ThreadAbortException"))
                {
                    LogUtil.log_call(this, string.Concat("[followSend]出错：", exception3.ToString()));
                }
            }
        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!UserUtil.isQuanfa(this))
            {
                return;
            }

            string content = this.webBrowser_zhuanhua.Document.Body.InnerHtml;
            if (string.IsNullOrEmpty(content))
            {
                LogUtil.log_call(this, "内容不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(PidUtil.get_qq_com_pid_call(this, null))
                && string.IsNullOrEmpty(PidUtil.get_weixin_pid_call(this, null))
                && string.IsNullOrEmpty(PidUtil.get_qq_queqiao_pid_call(this, null))
                )
            {
                LogUtil.log_call(this, "qq通用/鹊桥/微信推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【群发基础设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【】！");
                return;
            }
            ToolsUtil.zhuanhua_copy_Click_kouling_call(this, content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 
            
            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }



        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigUtil.ini_qq_template_default(this);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigUtil.ini_weixin_template_default(this);
        }
       

        private void button23_Click(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void button22_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string s = this.textBox_weixin_template.Text;
            int idx = this.textBox_weixin_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weixin_template.Text = s;
            this.textBox_weixin_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weixin_template.Focus();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#优惠券面额#");

            Button button = (Button)sender;
            //this.textBox_template.Text = this.textBox_template.Text.Insert(this.textBox_template.SelectionStart, "#"+button.Text+"#"); 

            string s = this.textBox_qq_template.Text;
            int idx = this.textBox_qq_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_qq_template.Text = s;
            this.textBox_qq_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_qq_template.Focus();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.tabControl_qunfa.SelectedTab = this.tabPage16;
            this.update_qunfa_icon(3);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wenda.shaibaoj.com/article/13");
        }

        private void timer_caiji_Tick(object sender, EventArgs e)
        {
            try
            {
                this.online_version = CmsUtil.query_post_ver(this);
                if (online_version==(Constants.version+""))
                {
                
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            BindingUtil.isBinding_call(this);
        }

        private void radioButton_fasong_weixin_fashi_houtai_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rb = sender as RadioButton;
            //if (rb.Name == "radioButton_fasong_weixin_fashi_qiantai")
            //    this.label1.Text = "first";
            //else if (rb.Name == "radioButton_fasong_weixin_fashi_houtai")
            //    this.label1.Text = "secord";

            if (this.radioButton_fasong_weixin_fashi_qiantai.Checked)
            {

                LogUtil.log_call(this, "微信启用前台群发！");
                try
                {
                    //this.thread_weixin_houtai.Abort();
                }
                catch (Exception)
                {

                }
            }
            else if (this.radioButton_fasong_weixin_fashi_houtai.Checked)
            {
            //    this.thread_weixin_houtai = new Thread(new ThreadStart(this.weixin_houtai));
            //    this.thread_weixin_houtai.SetApartmentState(ApartmentState.MTA);
            //    this.thread_weixin_houtai.IsBackground = true;
            //    this.thread_weixin_houtai.Start();
                LogUtil.log_call(this, "微信启用后台群发！");
                WeixinUtil.login(this);
            }
        }

        private void radioButton_fasong_weixin_fashi_qiantai_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioButton_fasong_weixin_fashi_qiantai.Checked)
            //{

            //    LogUtil.log_call(this, "微信启用前台群发！");
            //    try
            //    {
            //        this.thread_weixin_houtai.Abort();
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}
            //else if (this.radioButton_fasong_weixin_fashi_houtai.Checked)
            //{
            //    this.thread_weixin_houtai = new Thread(new ThreadStart(this.weixin_houtai));
            //    this.thread_weixin_houtai.SetApartmentState(ApartmentState.MTA);
            //    this.thread_weixin_houtai.IsBackground = true;
            //    this.thread_weixin_houtai.Start();
            //    LogUtil.log_call(this, "微信启用后台群发！");
            //}
        }

        private void weixin_houtai()
        {
            //pictureBox_weixin_login.Image = null;
            //pictureBox_weixin_login.SizeMode = PictureBoxSizeMode.Zoom;
            ////lblTip.Text = "手机微信扫一扫以登录";
            //LogUtil.log_call(this, "weixin_houtai！");

            //try
            //{

            //    string address = LoginService._session_id_url;
            //    WebClient client = new WebClient();
            //    client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            //    client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            //    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            //    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            //    //client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
            //    client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            //    client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            //    //client.Headers.Add("Connection", "keep-alive");
            //    client.Headers.Add(HttpRequestHeader.KeepAlive, "TRUE");
            //    string str3 = "";
            //    byte[] buffer = client.DownloadData(address);
            //    string str4 = client.ResponseHeaders["Content-Encoding"];
            //    if ("gzip".Equals(str4))
            //    {
            //        str3 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            //    }
            //    else
            //    {
            //        str3 = Encoding.UTF8.GetString(buffer);
            //    }
            //    LogUtil.log_call(this, "str3！");
            //    LogUtil.log_call(this, str3);

            //}
            //catch (Exception ex)
            //{
            //    LogUtil.log_call(this, ex.ToString());
            //}


            //byte[] bytes = BaseService.SendGetRequest(LoginService._session_id_url);
            //LogUtil.log_call(this, Encoding.UTF8.GetString(bytes));

            //((Action)(delegate()
            //{
            //    //异步加载二维码
            //    LoginService ls = new LoginService();
            //    Image qrcode = ls.GetQRCode();
            //    LogUtil.log_call(this, "qrcode！" + qrcode.ToString());
            //    if (qrcode != null)
            //    {
            //        this.BeginInvoke((Action)delegate()
            //        {
            //            pictureBox_weixin_login.Image = qrcode;
            //        });

            //        object login_result = null;
            //        while (true)  //循环判断手机扫面二维码结果
            //        {
            //            login_result = ls.LoginCheck();
            //            if (login_result is Image) //已扫描 未登录
            //            {
            //                this.BeginInvoke((Action)delegate()
            //                {
            //                    //lblTip.Text = "请点击手机上登录按钮";
            //                    pictureBox_weixin_login.SizeMode = PictureBoxSizeMode.CenterImage;  //显示头像
            //                    pictureBox_weixin_login.Image = login_result as Image;
            //                    //linkReturn.Visible = true;
            //                });
            //            }
            //            if (login_result is string)  //已完成登录
            //            {
            //                //访问登录跳转URL
            //                ls.GetSidUid(login_result as string);

            //                //打开主界面
            //                //this.BeginInvoke((Action)delegate()
            //                //{
            //                //    this.Hide();
            //                //    frmMainForm frmmf = new frmMainForm();
            //                //    frmmf.Show();
            //                //});
            //                break;
            //            }
            //        }
            //    }
            //})).BeginInvoke(null, null);
       
        }

        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);
        /// <summary>
        /// 自定义的结构
        /// </summary>
        public struct My_lParam
        {
            public int i;
            public string s;
        }
        /// <summary>
        /// 使用COPYDATASTRUCT来传递字符串
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
        //消息发送API
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            IntPtr hWnd,        // 信息发往的窗口的句柄
           int Msg,            // 消息ID
            int wParam,         // 参数1
            int lParam          //参数2
        );


        //消息发送API
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            IntPtr hWnd,        // 信息发往的窗口的句柄
           int Msg,            // 消息ID
            int wParam,         // 参数1
            ref My_lParam lParam //参数2
        );

        //消息发送API
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            IntPtr hWnd,        // 信息发往的窗口的句柄
           int Msg,            // 消息ID
            int wParam,         // 参数1
            ref  COPYDATASTRUCT lParam  //参数2
        );

        //消息发送API
        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(
            IntPtr hWnd,        // 信息发往的窗口的句柄
           int Msg,            // 消息ID
            int wParam,         // 参数1
            int lParam            // 参数2
        );



        //消息发送API
        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(
            IntPtr hWnd,        // 信息发往的窗口的句柄
           int Msg,            // 消息ID
            int wParam,         // 参数1
            ref My_lParam lParam //参数2
        );

        //异步消息发送API
        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(
            IntPtr hWnd,        // 信息发往的窗口的句柄
           int Msg,            // 消息ID
            int wParam,         // 参数1
            ref  COPYDATASTRUCT lParam  // 参数2
        );

        private void textBox_qun_guolv_Leave(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void textBox_qun_del_Leave(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void textBox_qun_list_Leave(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void button_weibo_Click(object sender, EventArgs e)
        {
            string user_name = this.textBox_weibo_name.Text;
            string pwd = this.textBox_weibo_pwd.Text;
            if(!string.IsNullOrEmpty(user_name)
                && !string.IsNullOrEmpty(pwd))
            {
                WeiboBean weiboBean = new WeiboBean();
                weiboBean.user_name = user_name;
                weiboBean.pwd = pwd;

                //DataGridViewRow dataGridViewRow = new DataGridViewRow();
                //dataGridViewRow.Cells.Add(new DataGridViewCell());
                //dataGridViewRow.Cells.Add(new DataGridViewCell());
                //dataGridViewRow.Cells[0].Value = user_name;
                //dataGridViewRow.Cells[1].Value = "未登陆";
                //dataGridViewRow.Cells[1].Tag = weiboBean;

                string out_log;
                this.sendSqlUtil.insert_weibo(weiboBean, out out_log);

                //FollowUtil.load_weibo_call(this);

                int count = this.dataGridView_weibo.Rows.Count;
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                //dataGridViewRow.HeaderCell.Value = string.Concat(count + 1, "");
                //dataGridViewRow.Cells[0].Value = weiboBean.user_name;
                //dataGridViewRow.Cells[1].Value = (weiboBean.status == 0 ? "未发送" : "已发送");
                //dataGridViewRow.Cells[0].Tag = weiboBean;

                this.dataGridView_weibo.Rows.Add(dataGridViewRow);

                this.dataGridView_weibo.Rows[count].HeaderCell.Value = string.Concat(count + 1, "");
                this.dataGridView_weibo[0, count].Value = weiboBean.user_name;
                this.dataGridView_weibo[1, count].Value = (weiboBean.status == 0 ? "未登陆" : "已登陆");
                this.dataGridView_weibo[0, count].Tag = weiboBean;

                this.appBean.weibo_list.Add(weiboBean);

                //dataGridViewRow.HeaderCell.Value = string.Concat(count + 1, "");
                //dataGridViewRow.Cells[0].Value = weiboBean.user_name;
                //dataGridViewRow.Cells[1].Value = (weiboBean.status == 0 ? "未发送" : "已发送");
                //dataGridViewRow.Cells[0].Tag = weiboBean;

                //int index = this.dataGridView_weibo.Rows.Add();
                //this.dataGridView_weibo.Rows[index].Cells[0].Value = user_name;
                //this.dataGridView_weibo.Rows[index].Cells[1].Value = "未登陆";
                //this.dataGridView_weibo.Rows[index].Cells[1].Tag = weiboBean;

                this.textBox_weibo_name.Text = "";
                this.textBox_weibo_pwd.Text = "";
                //this.dataGridView_weibo.Rows.Add(dataGridViewRow);
                //this.dataGridView_weixin_qun_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
            }

        }

        private void checkBox_gengfa_qq_MouseClick(object sender, MouseEventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigUtil.ini_qq_jiankong_guolv_template_default(this);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigUtil.ini_qq_jiankong_del_template_default(this);
        }

        private void checkBox_cmslist_jihua_CheckedChanged(object sender, EventArgs e)
        {
            ConfigUtil.save_config(this);
        }

        private void button2_Click_5(object sender, EventArgs e)
        {
            string qq_name = this.textBox_fenqun_qq_name.Text;
            string qq_pid = this.textBox_fenqun_qq_pid.Text;
            string qq_weiba = this.textBox_fenqun_qq_weiba.Text;
            if (!string.IsNullOrEmpty(qq_name)
                && !string.IsNullOrEmpty(qq_pid))
            {
                PidBean pidBean = new PidBean();
                pidBean.qun_name = qq_name;
                pidBean.qun_pid = qq_pid.Trim();
                pidBean.qun_type = 1;
                pidBean.weiba = qq_weiba;

                string out_log;
                this.sendSqlUtil.insert_pid(pidBean, out out_log);
                FollowUtil.load_pid_call(this, 1);

                this.textBox_fenqun_qq_name.Text = "";
                this.textBox_fenqun_qq_pid.Text = "";
                this.textBox_fenqun_qq_weiba.Text = "";
            }
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            string qq_name = this.textBox_fenqun_weixin_name.Text;
            string qq_pid = this.textBox_fenqun_weixin_pid.Text;
            string qq_weiba = this.textBox_fenqun_weixin_weiba.Text;
            if (!string.IsNullOrEmpty(qq_name)
                && !string.IsNullOrEmpty(qq_pid))
            {
                PidBean pidBean = new PidBean();
                pidBean.qun_name = qq_name;
                pidBean.qun_pid = qq_pid.Trim();
                pidBean.qun_type = 2;
                pidBean.weiba = qq_weiba;

                string out_log;
                this.sendSqlUtil.insert_pid(pidBean, out out_log);
                FollowUtil.load_pid_call(this, 2);

                this.textBox_fenqun_weixin_name.Text = "";
                this.textBox_fenqun_weixin_pid.Text = "";
                this.textBox_fenqun_weixin_weiba.Text = "";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                (new ShowWeixinForm(this)).ShowDialog();
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(this, string.Concat("[ViewFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                (new ShowQqForm(this)).ShowDialog();
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(this, string.Concat("[ViewFwSnd_Click]出错：", exception.ToString()));
            }
        }

        private void comboBox_cj_pinlv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        private void comboBox_qunfa_ds_s1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        private void comboBox_qunfa_ds_f1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        private void comboBox_qunfa_ds_s2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        private void comboBox_qunfa_ds_f2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string s = this.textBox_weibo_template.Text;
            int idx = this.textBox_weibo_template.SelectionStart;
            s = s.Insert(idx, "#" + button.Text + "#");

            this.textBox_weibo_template.Text = s;
            this.textBox_weibo_template.SelectionStart = idx + ("#" + button.Text + "#").Length;
            this.textBox_weibo_template.Focus();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigUtil.ini_weibo_template_default(this);
        }

        private void textBox_qunfa_times_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.appBean.qunfa_hours = int.Parse(this.textBox_qunfa_times.Text.Trim());
            }
            catch (Exception) { }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (this.appBean.ali_order_status == false)
            {
                this.appBean.ali_order_status = true;
                this.thread_order_ali = new Thread(new ThreadStart(this.order_ali));

                this.button46.BackColor = System.Drawing.Color.Gray;
                this.button46.ForeColor = System.Drawing.Color.Black;

                this.thread_order_ali.IsBackground = true;
                this.thread_order_ali.Start();

                this.button46.Text = "停止采集";

            }
            else
            {
                try
                {
                    this.appBean.ali_order_status = false;
                    this.thread_order_ali.Abort();
                    this.button46.Text = "开始采集";
                    this.button46.BackColor = System.Drawing.Color.DodgerBlue;
                    this.button46.ForeColor = System.Drawing.Color.White;
                }
                catch (Exception)
                {
                }
                try
                {
                    this.thread_order_ali.Abort();
                }
                catch (Exception)
                {
                }
            }
        }

        private void order_ali()
        {
            try
            {
                while (true)
                {
                    //LogUtil.log_call(this, "s0");
                    try
                    {
                        //LogUtil.log_call(this, "s" );
                        AliOrderUtil.putOrder(this);
                        LogUtil.log_call(this, "订单同步完成，等待下一次的同步");
                    }
                    catch (Exception exception2)
                    {
                        Exception exception1 = exception2;
                        if (!exception1.ToString().Contains("System.Threading.ThreadAbortException"))
                        {
                            LogUtil.log_call(this, string.Concat("采集中出点问题ex1，", exception1.ToString()));
                            //this.method_264();
                        }
                    }
                    Thread.Sleep(this.appBean.ali_order_pinlv*1000*60);
                }
            }
            catch (Exception exception4)
            {
                Exception exception3 = exception4;
                if (!exception3.ToString().Contains("System.Threading.ThreadAbortException"))
                {
                    LogUtil.log_call(this, string.Concat("[followSend]出错：", exception3.ToString()));
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_ali_order_pinlv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        private void comboBox_ali_order_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigUtil.sys_times(this);
        }

        //调用51OCR.dll 中的函数 using System.Runtime.InteropServices;
        //初始化， 读入样本库文件, 仅需要调用一次， 单线程程序可不调用，DLL会使用默认样本库文件 51ocr.Templates 
        [DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_InitOCR", CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall)]
        public static extern int www_51ocr_com_InitOCR(string templatefile);

        //调用51OCR.dll 中的函数 using System.Runtime.InteropServices;
        //初始化， 读入样本库文件, 仅需要调用一次， 单线程程序可不调用，DLL会使用默认样本库文件 51ocr.Templates 
        [DllImport("51OCR.dll", EntryPoint = "_www_51ocr_com_InitOCR_2@8", CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall)]
        public static extern int www_51ocr_com_InitOCR_2(byte[] imagebuf, int size);


        //[in] imagefile 文件名
        //[out] text 识别结果
        //返回 0 正常识别（可能返回空字符）；返回负数 异常状态(文件不存在，文件格式不对等)
        [DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_RECOG_1", CharSet = CharSet.Ansi,
           CallingConvention = CallingConvention.StdCall)]
        public static extern int www_51ocr_com_RECOG_1(string imagefile, StringBuilder text);

        //[in] imagebuf 图像文件内存
        //[in] size  文件内存大小
        //[in] type  图像文件类型
        //CXIMAGE_FORMAT_BMP = 1,
        //CXIMAGE_FORMAT_GIF = 2,
        //CXIMAGE_FORMAT_JPG = 3,
        //CXIMAGE_FORMAT_PNG = 4,
        //CXIMAGE_FORMAT_ICO = 5,
        //CXIMAGE_FORMAT_TIF = 6,
        //[out] text 识别结果
        //返回 0 正常识别（可能返回空字符）； 返回负数 异常状态(文件格式不对等)
        [DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_RECOG_2", CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern int www_51ocr_com_RECOG_2(byte[] imagebuf, int size, int type, StringBuilder text);

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://software1.huopinjie.com/update/update/aliwangwang.zip");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.haopintui.net/user_info.php?action=user&mod=taoke_token");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.haopintui.net/user_info.php?action=user&mod=taoke_token");
        }



        //[in] cdkey dll调用密码
        //返回 0 
        //[DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_SetCDKey", CharSet = CharSet.Ansi,
        //     CallingConvention = CallingConvention.StdCall)]
        //public static extern int www_51ocr_com_SetCDKey(string cdkey);

    }
}


public delegate void log(CmsForm cmsForm, String content);

public delegate void formWindowState(CmsForm cmsForm, FormWindowState formWindowState);

public delegate void view_cms_call(CmsForm cmsForm, int zone_id);

public delegate void update_cms_list_call(CmsForm cmsForm);

public delegate void update_cms_tongji_call(CmsForm cmsForm, UserCmsTongji userCmsTongji);

public delegate void update_user_agent_Handler(CmsForm cmsForm);

public delegate void GDelegate83(int int_0, bool bool_0);

public delegate void GDelegate85(string string_0);
public delegate void GDelegate185(int string_0);

public delegate void GDelegate86();
public delegate void GDelegate69(CmsForm cmsForm,string content,out string out_log);
public delegate void GDelegate74(CmsForm cmsForm,out string out_log);
public delegate void GDelegate75(CmsForm cmsForm,out string out_log);
public delegate bool GDelegate66(IntPtr intptr_0, IntPtr intptr_1);

public delegate void load(CmsForm cmsForm);
public delegate void load_item(CmsForm cmsForm, SendItem sendItem);
public delegate void load_qun_pid(CmsForm cmsForm, int qun_type);

public delegate bool GDelegate99(CmsForm cmsForm, string content, out string out_log);

public delegate void zhuanhua_copy_Click(CmsForm cmsForm,string content);

public delegate void bind(CmsForm cmsForm);
