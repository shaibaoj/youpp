using mshtml;
using Sunisoft.IrisSkin;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;

public class AliBridgeForm : Form
{
	private IContainer icontainer_0;

	private RichTextBox richTextBoxSts;

	private DataGridView dataGridViewBrdg;

	private GroupBox groupBox2;

	private RadioButton rdobtnOrderByCms;

	private RadioButton rdobtnOrderByQnt;

	private TextBox textBoxBrdgId;

	private Label label2;

	private Button buttonSchByBrdgId;

	private TextBox textBoxItemId;

	private Label label1;

	private Button buttonSchByItemId;

	private Label label6;

	private Label label5;

	private TextBox textBoxKWHiP;

	private TextBox textBoxKWLowP;

	private Label label4;

	private TextBox textBoxKeyword;

	private Label label3;

	private Button buttonSchByKW;

	private Label label7;

	private Label label8;

	private TextBox textBoxCMSHiP;

	private TextBox textBoxCMSLowP;

	private Label label9;

	private TextBox textBoxCms;

	private Label label10;

	private Button buttonSchByCms;

	private PictureBox pictureBoxItemPic;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripBrdg;

	private CheckBox checkBoxFcMnDl;

	private Button buttonStt;

	private GroupBox groupBox3;

	private Label label12;

	private TextBox textBoxManulBrdgId;

	private Button buttonDlByBrdgID;

	private GroupBox groupBox4;

	private TabControl tabControlMain;

	private TabPage tabPageBridge;

	private TabPage tabPageOrder;

	private CheckBox checkBoxSingle;

	private RadioButton rdobtnOrderByPrice;

	private GroupBox groupBox6;

	private ComboBox comboBoxOrderSts;

	private Label label15;

	private Button buttonClrOdrSchCond;

	private TextBox textBoxProductID;

	private Button buttonLoadOrders;

	private TextBox textBoxOrderSch;

	private Label label16;

	private Label label18;

	private DataGridView dataGridViewAliOdr;

	private GroupBox groupBox9;

	private TextBox textBoxItemTitle;

	private Label label19;

	private Button buttonCpPromotLnk;

	private TextBox textBoxPromotLnk;

	private Label label17;

	private TextBox textBoxFEarn;

	private Label label23;

	private TextBox textBoxRemainDay;

	private Label label22;

	private Label label24;

	private PictureBox pictureBoxWaiting;

	private CheckBox checkBoxTmallOnly;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripTask;

	private NotifyIcon notifyIcon_0;

	private SkinEngine skinEngine_0;

	private GroupBox groupBox10;

	private Label label25;

	private Button buttonUpdAliOder;

	private Label label26;

	private TabPage tabPageAutoSend;

	private Button buttonStopTask;

	private GroupBox groupBox12;

	private Button buttonCompressDb;

	private GroupBox groupBox13;

	private Button buttonLoginAlimama;

	private Button buttonStartTask;

	private GroupBox groupBox11;

	private WebBrowser webBrowserSendContent;

	private GroupBox groupBox14;

	private GroupBox groupBox16;

	private GroupBox groupBox15;

	private GroupBox groupBox17;

	private Button buttonStop;

	private Button buttonPause;

	private Button buttonSend;

	private DataGridView dataGridViewAutoSndTask;

	private TextBox textBoxTmSwWindow;

	private Label label27;

	private Button buttonLoadQQGrpList;

	private DataGridView dataGridViewQQGrp;

	private Button buttonAddTask;

	private Button buttonDelTask;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripCtEdit;

	private RadioButton radioButtonSndCtrlEnter;

	private RadioButton radioButtonSndEnter;

	private Label label32;

	private TextBox textBoxTmSnd;

	private Label label33;

	private Label label30;

	private TextBox textBoxTmPasete;

	private Label label31;

	private Label label29;

	private Button buttonClearSndConten;

	private Button buttonOpenAllGrp;

	private CheckBox checkBoxNoNotStt;

	private TabPage tabPageHotShare;

	private GroupBox groupBox19;

	private WebBrowser webBrowserHotShare;

	private DataGridView dataGridViewHotShare;

	private System.Windows.Forms.Timer timer_0;

	private TabPage tabPageTools;

	private Button buttonShortUrl;

	private Button buttonClrBdShort;

	private GroupBox groupBox20;

	private TextBox textBoxOrgUrl;

	private Label label37;

	private Button buttonCopyShortUrl;

	private TextBox textBoxShortUrl;

	private Label label38;

	private GroupBox groupBox21;

	private Button buttonCpCoupon;

	private Button buttonPcToMbCoupon;

	private TextBox textBoxMbCoupon;

	private Label label39;

	private TextBox textBoxPcCoupon;

	private Button buttonClrCoupon;

	private Label label40;

	private Button buttonCpShortCoupon;

	private TextBox textBoxLowestCms;

	private Label label41;

	private Label label42;

	private TabPage tabPageTaoQingQiang;

	private DataGridView dataGridViewTaobaoQiang;

	private Button buttonDownloadTaoQing;

	private DataGridView dataGridViewCmsPlan;

	private DataGridView dataGridViewTaobaoQing;

	private RichTextBox richTextBoxDscTQQ;

	private Button buttonClrLclTQQData;

	private Label label45;

	private LinkLabel linkLabel1;

	private Label label47;

	private TextBox textBoxTQQLCms;

	private Label label46;

	private GroupBox groupBoxTaobaoQing;

	private GroupBox groupBoxTaobaoQiang;

	private CheckBox checkBoxSndAddRdm;

	private CheckBox checkBoxSndAddtime;

	private TextBox textBoxSndAddStr;

	private TabPage tabPageOnline;

	private DataGridView dataGridViewOnlineBrdg;

	private GroupBox groupBox25;

	private CheckBox checkBoxOTmallOnly;

	private Label label54;

	private Label label55;

	private TextBox textBoxOHiPrice;

	private TextBox textBoxOLowPrice;

	private Label label56;

	private TextBox textBoxOLowestCms;

	private Label label57;

	private Button buttonOSchKey;

	private TextBox textBoxOSoldQu;

	private Label label60;

	private TextBox textBoxOSchKey;

	private Label label61;

	private Button buttonOSchItemId;

	private Button buttonOFilter;

	private TextBox textBoxOItemId;

	private Label label63;

	private Label label49;

	private Button buttonNextPage;

	private Button buttonPrePage;

	private PictureBox pictureBoxOnlineItemPic;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripOnBrdg;

	private GroupBox groupBox24;

	private PictureBox pictureBoxTQQ;

	private Button buttonClrAliOdrDb;

	private TabControl tabControlSnd;

	private TabPage tabPageSndManual;

	private LinkLabel linkLabelGuid;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripTaoQing;

	private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripHiCms;

	private GroupBox groupBox28;

	private WebBrowser webBrowserConvert;

	private Button buttonConvert;

	private Button buttonConvertAndAddToSnd;

	private Button buttonConvertClr;

	private GroupBox groupBox29;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripUrlTrans;

	private CheckBox checkBoxPreChkPid;

	private Button buttonBatch;

	private OpenFileDialog openFileDialog_0;

	private CheckBox checkBoxFollowSend;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripHotShare;

	private TabPage tabPageFollowSend;

	private DataGridView dataGridViewFollowSnd;

	private Button buttonFollowSend;

	private Button buttonFollowSndStop;

	private Button buttonFollowSndStart;

	private Label label43;

	private TextBox textBoxFollowSndInteval;

	private Label label64;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripFwSnd;

	private Button buttonFwSndDelAll;

	private Button buttonFwSndDelSel;

	private CheckBox checkBoxChgFwSndPid;

	private GroupBox groupBox30;

	private RadioButton radioButtonQQFollow;

	private RadioButton radioButtonSvrFollow;

	private TextBox textBoxFwMainUser;

	private Label label65;

	private TextBox textBoxCouponLwNum;

	private CheckBox checkBoxChkCoupon;

	private Label label66;

	private Button buttonChkCoupon;

	private CheckBox checkBoxSndAddStr;

	private LinkLabel linkLabelCurUserNum;

	private TabPage tabPageQQGrpMng;

	private Button buttonLoginQQ;

	private DataGridView dataGridViewSchQQGrpMember;

	private DataGridView dataGridViewQQGrpMember;

	private DataGridView dataGridViewQQGroup;

	private Button buttonSynQQGrpMember;

	private Button buttonSchQQ;

	private TextBox textBoxSchQQ;

	private Button buttonExpQQGrp;

	private Button buttonExpAllQQ;

	private CheckBox checkBoxAllTaokeQQ;

	private CheckBox checkBoxAllQQ;

	private GroupBox groupBox33;

	private GroupBox groupBox32;

	private GroupBox groupBox31;

	private CheckBox checkBoxChkAllQQGrp;

	private SaveFileDialog saveFileDialog_0;

	private CheckBox checkBoxCloseWinWhileSnded;

	private CheckBox checkBoxIsTaoke;

	private TabPage tabPageQQGrpInvite;

	private GroupBox groupBox34;

	private Button buttonClrQQGrpInvite;

	private TextBox textBoxQQ;

	private Button buttonSchQQInvite;

	private Label label67;

	private TextBox textBoxQQInvite;

	private Label label68;

	private Label label69;

	private DataGridView dataGridViewQQGrpInvite;

	private ComboBox comboBoxQQGroup;

	private DateTimePicker dateTimePickerDlEnd;

	private DateTimePicker dateTimePickerDlStt;

	private Label label48;

	private Button buttonSchAliOdr;

	private Label label70;

	private DateTimePicker dateTimePickerSchOdrStt;

	private DateTimePicker dateTimePickerSchOdrEnd;

	private Button buttonDlOnlineOdr;

	private CheckBox checkBoxClrAfterConvert;

	private Button buttonStpFollowSend;

	private CheckBox checkBoxBatchConvert;

	private Button buttonSetQQGroup;

	private TabPage tabPageOdrPoi;

	private TabPage tabPageUserMng;

	private DataGridView dataGridViewRtnFundUser;

	private GroupBox groupBox7;

	private Button buttonBatchRefund;

	private Button buttonSchQQUser;

	private Button buttonClrUser;

	private Label label73;

	private TextBox textBoxUserSchQQ;

	private Label label74;

	private GroupBox groupBox35;

	private Button buttonClrOdrPoi;

	private TextBox textBoxSchOdrPid;

	private Button buttonSch;

	private TextBox textBoxSchAliOdrPoi;

	private Label label78;

	private TextBox textBoxOdrSchQQNum;

	private Label label79;

	private Label label80;

	private DataGridView dataGridViewAliOdrPoi;

	private Button buttonSchRefundHis;

	private TextBox textBoxSchRefundHisQQ;

	private Label label75;

	private Button buttonRefund;

	private TextBox textBoxRefundRemark;

	private TextBox textBoxRefundAmount;

	private Label label77;

	private Label label76;

	private TextBox textBoxRefundQQ;

	private Label label81;

	private Button buttonVipTry;

	private Button buttonSchVipTry;

	private GroupBox groupBox36;

	private TextBox textBoxVipTryQQ;

	private Label label82;

	private Button buttonOpenShortCutFolder;

	private WebBrowser webBrowserTaoQiang;

	private System.Windows.Forms.Timer timer_1;

	private System.Windows.Forms.ContextMenuStrip contextMenuStripOdrPoi;

	private Button buttonDelAllTask;

	private RadioButton radioButtonQYFollow;

	private TextBox textBoxFwCouponLwNum;

	private Label label83;

	private Label label84;

	private Button buttonAddUserPoi;

	private Button buttonSchUserAddPoi;

	private CheckBox checkBoxUpHotShare;

	private GroupBox groupBox37;

	private TextBox textBoxHotShareKW;

	private Button buttonSchHotShare;

	private Label label85;

	private GroupBox groupBox38;

	private DataGridView dgvQQGrpMonRep;

	private Button buttonAddMsgReplace;

	private Label label87;

	private TextBox textBoxNewChar;

	private TextBox textBoxOldChar;

	private Label label86;

	private CheckBox checkBoxNoLnkNoFw;

	private Button buttonDelMsgReplace;

	private TabControl tabControlHotShare;

	private TabPage tabPageSelfHotshare;

	private TabPage tabPageSelHotShare;

	private Label lblVip;

	private CheckBox checkBoxMinForm;

	private Button buttonCouponTkl;

	private GroupBox groupBox39;

	private Button buttonGenTaoKouLing;

	private TextBox textBoxTklUrl;

	private Label label90;

	private Button buttonPengyouQuan;

	private Button buttonCpPromotTkl;

	private Button buttonCpCouponTkl;

	private Button buttonAddWxGrp;

	private TextBox textBoxWxGrpName;

	private Label label92;

	private TextBox textBoxTaskInteval;

	private Label label28;

	private Label label34;

	private DateTimePicker dateTimePickerTaskStart;

	private Label label93;

	private TabPage tabPageShareHotShare;

	private TabPage tabPageMutualHotShare;

	private GroupBox groupBox42;

	private Button buttonMutualHotShare;

	private Button buttonShareHotShare;

	private TextBox textBoxNotFwHour;

	private Label label95;

	private ToolTip toolTip_0;

	private Button buttonLoadTaokeData;

	private Label label96;

	private TextBox textBoxWxPicDelay;

	private Label label97;

	private Button buttonSchLclTaokeQQ;

	private CheckBox checkBoxQQGrpFw;

	private LinkLabel linkLabelHot1;

	private LinkLabel linkLabelHot2;

	private Button buttonCp2in1Tkl;

	private GroupBox groupBox26;

	private GroupBox groupBox43;

	private GroupBox groupBox44;

	private Button buttonSetMainAcc;

	private TextBox textBoxOrderMainAcc;

	private Label label51;

	private Button buttonCoSubOrder;

	private Button buttonRtnSelHotList;

	private Button buttonSelHotAddManul;

	private Button buttonSelHotAddFollow;

	private RadioButton radioButtonSelHotShare;

	private Label label52;

	private Label label53;

	private LinkLabel linkLabelHelpOrderCmb;

	private LinkLabel linkLabelVipCharge;

	private ComboBox comboBoxPromotPsi;

	private Label label58;

	private RadioButton radioButtonQYFcFollow;

	private LinkLabel linkLabelLnkHelp;

	private LinkLabel linkLabelFollowHelp;

	private LinkLabel linkLabelPyq;

	private Label label62;

	private DateTimePicker dateTimePickerOdrPoiEndDate;

	private Label label102;

	private DateTimePicker dateTimePickerOdrPoiSttDate;

	private Label label103;

	private CheckBox checkBoxOdrDate;

	private Button buttonAddToFollow;

	private Button buttonOdrPoiSort;

	private Label label104;

	private Label label50;

	private TextBox textBoxLowestFwCms;

	private Label label105;

	private TabPage tabPageSetUp;

	private Button buttonSetWxTemp;

	private CheckBox checkBoxWxPromot;

	private GroupBox groupBox40;

	private LinkLabel linkLabelGetWeixinPromot;

	private ComboBox comboBoxWxPPos;

	private ComboBox comboBoxWxPUnit;

	private Label label89;

	private Label label91;

	private GroupBox groupBoxQyAdmin;

	private Button button1;

	private Button buttonSaveToSvr;

	private TextBox textBoxImgZipPer;

	private CheckBox checkBoxLoadDataNow;

	private Label label88;

	private GroupBox groupBox1;

	private TextBox textBoxQQPlusPath;

	private Label label71;

	private Button buttonOpenQQPlus;

	private GroupBox groupBox27;

	private LinkLabel linkLabelPromotPosition;

	private ComboBox comboBoxBrdgPPos;

	private ComboBox comboBoxBrdgPUnit;

	private RadioButton radioButtonBrdgMOth;

	private RadioButton radioButtonBrdgMApp;

	private RadioButton radioButtonBrdgMWeb;

	private Label label14;

	private Label label59;

	private GroupBox groupBox23;

	private RadioButton radioButton2in1Qyu;

	private CheckBox checkBoxShortUrl;

	private RadioButton radioButtonShBD;

	private RadioButton radioButtonShXL;

	private GroupBox groupBox22;

	private Label label72;

	private LinkLabel linkLabelHelpCMSPlan;

	private CheckBox checkBoxCouponItem;

	private Label label100;

	private RadioButton radioButtonHiCms;

	private RadioButton radioButtonNotAudit;

	private TextBox textBoxAppCmsReson;

	private Label label44;

	private GroupBox groupBox18;

	private LinkLabel linkLabelGetPromot;

	private ComboBox comboBoxCmPPos;

	private ComboBox comboBoxCmPUnit;

	private RadioButton radioButtonCmMOth;

	private RadioButton radioButtonCmMApp;

	private RadioButton radioButtonCmMWeb;

	private Label label35;

	private Label label36;

	private Button buttonSaveConfig;

	private GroupBox groupBox5;

	private Button buttonLoginAlimama2;

	private CheckBox checkBoxAutoLogin;

	private TextBox textBoxAlimamaPwd;

	private TextBox textBoxAlimamaAcc;

	private Label label11;

	private Label label13;

	private GroupBox groupBox8;

	private Button buttonOpenUUHP;

	private PictureBox pictureBoxTest;

	private Button buttonTestCode;

	private Label labelUUSts;

	private TextBox textBoxUUPwd;

	private TextBox textBoxUUUsername;

	private Label label20;

	private Label label21;

	private Button buttonUUWiseLogin;

	private CheckBox checkBoxQQKouling;

	private Label label101;

	private CheckBox checkBoxUseTemp;

	private GroupBox groupBox41;

	private CheckBox checkBoxTempCInMdl;

	private Label label94;

	private TabPage tabPageAmaze;

	private GroupBox groupBox45;

	private Button buttonGenBridge;

	private Button buttonAuditBridge;

	private GroupBox groupBox46;

	private Label label98;

	private TextBox textBoxAuditBridgeId;

	private Label label106;

	private TextBox textBoxSoldQuantity;

	private CheckBox checkBoxAuditCms;

	private CheckBox checkBoxAdd1212;

	private LinkLabel linkLabelBridgeHelp;

	private ᜐ ᜐ_0;

	public ᝠ ᝠ_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	public string string_14;

	private WebClient webClient_0;

	private int int_0;

	private string string_15;

	private string string_16;

	public string string_17;

	public string string_18;

	public string string_19;

	public Hashtable hashtable_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public string string_20;

	private int int_3;

	public char[] char_0;

	public UnicodeEncoding unicodeEncoding_0;

	public bool bool_1;

	public Thread thread_0;

	public ᝠ ᝠ_1;

	public string string_21;

	private GClass12 gclass12_0;

	private ArrayList arrayList_0;

	private string string_22;

	private ArrayList arrayList_1;

	private Class0 class0_0;

	private float float_0;

	private string string_23;

	private Class1 class1_0;

	private GClass1 gclass1_0;

	private GClass42 gclass42_0;

	public string string_24;

	public string string_25;

	private ArrayList arrayList_2;

	public ArrayList arrayList_3;

	public Hashtable hashtable_1;

	private bool bool_2;

	private string string_26;

	private string string_27;

	private string string_28;

	private string string_29;

	private string string_30;

	private string string_31;

	private string string_32;

	private string string_33;

	private string string_34;

	private string string_35;

	private string string_36;

	private string string_37;

	private string string_38;

	private int int_4;

	public int int_5;

	public double double_0;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public string string_39;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private bool bool_8;

	private bool bool_9;

	private string string_40;

	private bool bool_10;

	private bool bool_11;

	public string string_41;

	private string string_42;

	public Hashtable hashtable_2;

	public IntPtr intptr_0;

	private ᝦ ᝦ_0;

	private string string_43;

	private string string_44;

	private string string_45;

	private bool bool_12;

	public bool bool_13;

	public string string_46;

	public string string_47;

	private ArrayList arrayList_4;

	private string string_48;

	private bool bool_14;

	private bool bool_15;

	private bool bool_16;

	private int int_10;

	private string string_49;

	private bool bool_17;

	private bool bool_18;

	private ArrayList arrayList_5;

	private Thread thread_1;

	private int int_11;

	private bool bool_19;

	private bool bool_20;

	public string string_50;

	private string string_51;

	private string string_52;

	private string string_53;

	private ArrayList arrayList_6;

	public int int_12;

	private Thread thread_2;

	private bool bool_21;

	private string string_54;

	private bool bool_22;

	private string string_55;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public string string_56;

	private string string_57;

	private ArrayList arrayList_7;

	public string string_58;

	private string string_59;

	private ArrayList arrayList_8;

	public string string_60;

	private string string_61;

	private ArrayList arrayList_9;

	public string string_62;

	private string string_63;

	private ArrayList arrayList_10;

	public bool bool_23;

	public System.Windows.Forms.Timer timer_2;

	private int int_17;

	public string string_64;

	public string string_65;

	public string string_66;

	public ArrayList arrayList_11;

	public ArrayList arrayList_12;

	public GClass10 gclass10_0;

	public GClass2 gclass2_0;

	public bool bool_24;

	private long long_0;

	private int int_18;

	private ArrayList arrayList_13;

	private bool bool_25;

	private int int_19;

	private WebClient webClient_1;

	private bool bool_26;

	private string string_67;

	private int int_20;

	private ArrayList arrayList_14;

	private Thread thread_3;

	private Thread thread_4;

	private Thread thread_5;

	private string string_68;

	private int int_21;

	private int int_22;

	private float float_1;

	private int int_23;

	private bool bool_27;

	private Thread thread_6;

	public string string_69;

	public ArrayList arrayList_15;

	public bool bool_28;

	public string string_70;

	private string string_71;

	private ArrayList arrayList_16;

	private Regex regex_0;

	private string string_72;

	private int int_24;

	private string string_73;

	public bool bool_29;

	private bool bool_30;

	private ᝡ ᝡ_0;

	private ArrayList arrayList_17;

	private bool bool_31;

	private ᝡ ᝡ_1;

	private ArrayList arrayList_18;

	private ᝡ ᝡ_2;

	private ArrayList arrayList_19;

	private bool bool_32;

	public bool bool_33;

	public string string_74;

	public string string_75;

	public string string_76;

	public string string_77;

	private string string_78;

	private string string_79;

	private float float_2;

	private float float_3;

	private float float_4;

	private int int_25;

	private string string_80;

	private string string_81;

	private string string_82;

	public int int_26;

	public Hashtable hashtable_3;

	private bool bool_34;

	private string string_83;

	public bool bool_35;

	public ArrayList arrayList_20;

	private string string_84;

	private ArrayList arrayList_21;

	public bool bool_36;

	private string string_85;

	private string string_86;

	private string string_87;

	public GClass33 gclass33_0;

	private ArrayList arrayList_22;

	public bool bool_37;

	public string string_88;

	public string string_89;

	private ArrayList arrayList_23;

	public GClass4 gclass4_0;

	private ArrayList arrayList_24;

	private string string_90;

	private FileStream fileStream_0;

	private StreamWriter streamWriter_0;

	private string string_91;

	public ArrayList arrayList_25;

	public string string_92;

	public bool bool_38;

	private string string_93;

	private string string_94;

	public bool bool_39;

	public int int_27;

	public string string_95;

	public AliBridgeForm()
	{
		this.icontainer_0 = null;
		this.ᜐ_0 = new ᜐ();
		this.ᝠ_0 = new ᝠ();
		this.string_0 = string.Concat("http://", ᝮ.ᜄ, ":80/software.php");
		this.string_1 = string.Concat("http://", ᝮ.ᜄ, ":80/taokouling.php");
		this.string_2 = string.Concat("http://", ᝮ.ᜄ, ":80/taourl.php");
		this.string_3 = string.Concat("http://", ᝮ.ᜄ, ":80/hotshare.php");
		this.string_4 = string.Concat("http://", ᝮ.ᜄ, ":80/hotshare");
		this.string_5 = "";
		this.string_6 = string.Concat("http://", ᝮ.ᜅ, ":80/selhotshare");
		this.string_7 = "";
		this.string_8 = string.Concat("http://", ᝮ.ᜅ, ":80/selhotlist.php");
		this.string_9 = string.Concat("http://", ᝮ.ᜅ, ":80/updhotshare.php");
		this.string_10 = string.Concat("http://", ᝮ.ᜄ, ":80/sharehotshare");
		this.string_11 = "";
		this.string_12 = string.Concat("http://", ᝮ.ᜄ, ":80/mutualhotshare");
		this.string_13 = "";
		this.string_14 = string.Concat("http://", ᝮ.ᜄ, "/ordercmb");
		this.webClient_0 = new WebClient();
		this.int_0 = 161;
		this.string_15 = "alibridge";
		this.string_16 = "千语淘客助手.exe";
		this.string_17 = "";
		this.string_18 = "";
		this.string_19 = "";
		this.hashtable_0 = new Hashtable();
		this.int_1 = 600000;
		this.int_2 = 0;
		this.bool_0 = false;
		this.string_20 = "";
		this.int_3 = 0;
		this.char_0 = new char[5000];
		this.unicodeEncoding_0 = new UnicodeEncoding();
		this.bool_1 = false;
		this.thread_0 = null;
		this.ᝠ_1 = new ᝠ();
		this.string_21 = "";
		this.gclass12_0 = null;
		this.string_22 = "";
		this.float_0 = 0f;
		this.string_23 = "";
		this.class1_0 = null;
		this.gclass1_0 = null;
		this.gclass42_0 = null;
		this.string_24 = "";
		this.string_25 = "";
		this.arrayList_2 = null;
		this.arrayList_3 = new ArrayList();
		this.hashtable_1 = new Hashtable();
		this.bool_2 = true;
		this.string_26 = "";
		this.string_27 = "";
		this.string_28 = "";
		this.string_29 = "";
		this.string_30 = "";
		this.string_31 = "";
		this.string_32 = "";
		this.string_33 = "";
		this.string_34 = "";
		this.string_35 = "";
		this.string_36 = "";
		this.string_37 = "该申请通过千语淘客助手发出：";
		this.string_38 = "";
		this.int_4 = 0;
		this.int_5 = 0;
		this.double_0 = 0;
		this.bool_3 = false;
		this.bool_4 = false;
		this.bool_5 = false;
		this.bool_6 = true;
		this.bool_7 = true;
		this.string_39 = "";
		this.int_6 = 0;
		this.int_7 = 0;
		this.int_8 = 0;
		this.int_9 = 0;
		this.bool_8 = false;
		this.bool_9 = false;
		this.string_40 = "";
		this.bool_10 = false;
		this.bool_11 = false;
		this.string_41 = Application.StartupPath;
		this.string_42 = "";
		this.hashtable_2 = new Hashtable();
		this.intptr_0 = IntPtr.Zero;
		this.ᝦ_0 = new ᝦ();
		this.string_43 = "43b8acbd05a773df1f335a33f0e2f4fb";
		this.string_44 = "";
		this.string_45 = "";
		this.bool_12 = false;
		this.bool_13 = false;
		this.string_46 = "http://s.click.taobao.com/t?e=m%3D2%26s%3D2X6mEUUjqYQcQipKwQzePCperVdZeJviLKpWJ%2Bin0XJRAdhuF14FMVVDUMFQBWObCB4k3IenQnWcI1zX3waUoXyKwiqD2WK0Bmf7LSR66ah9sLqZgfhqiHhFfjPlhOpnwFMQSe0DLrzeixitsS%2BNsOriign%2FSVqrklzFeKMz7CfbybS9RzLIsP3rx%2B5YEfzF%2BESjOeIkRibbICUMyH%2FCZmYMBhR2FIUJcMqe%2BgPpS4gZ7mVdTGEsBLGOKy9H9KPr38tJbCFyLEjaoL2q0dojAE4rcRkUpcsQcSpj5qSCmbA%3D&pid={pid}";
		this.string_47 = "";
		this.arrayList_4 = new ArrayList();
		this.string_48 = "";
		this.bool_14 = false;
		this.bool_15 = false;
		this.bool_16 = false;
		this.int_10 = 0;
		this.string_49 = "";
		this.bool_17 = false;
		this.bool_18 = true;
		this.arrayList_5 = new ArrayList();
		this.thread_1 = null;
		this.int_11 = 0;
		this.bool_19 = false;
		this.bool_20 = false;
		this.string_50 = "";
		this.string_51 = "";
		this.string_52 = "";
		this.string_53 = "";
		this.arrayList_6 = new ArrayList();
		this.int_12 = 0;
		this.thread_2 = null;
		this.bool_21 = false;
		this.string_54 = "";
		this.bool_22 = false;
		this.string_55 = " - 您有最新爆款消息！";
		this.int_13 = 60000;
		this.int_14 = 600000;
		this.int_15 = 180000;
		this.int_16 = 60000;
		this.string_56 = "";
		this.string_57 = "";
		this.arrayList_7 = new ArrayList();
		this.string_58 = "";
		this.string_59 = "";
		this.arrayList_8 = new ArrayList();
		this.string_60 = "";
		this.string_61 = "";
		this.arrayList_9 = new ArrayList();
		this.string_62 = "";
		this.string_63 = "";
		this.arrayList_10 = new ArrayList();
		this.bool_23 = false;
		this.timer_2 = new System.Windows.Forms.Timer();
		this.int_17 = 0;
		this.string_64 = "";
		this.string_65 = "";
		this.string_66 = "";
		this.gclass10_0 = null;
		this.gclass2_0 = null;
		this.bool_24 = false;
		this.long_0 = 0L;
		this.int_18 = 0;
		this.arrayList_13 = new ArrayList();
		this.bool_25 = false;
		this.int_19 = 30;
		this.webClient_1 = new WebClient();
		this.bool_26 = false;
		this.string_67 = "";
		this.int_20 = 1;
		this.arrayList_14 = new ArrayList();
		this.string_68 = string.Concat(Directory.GetCurrentDirectory(), "\\config\\临时文件夹\\follow");
		this.int_21 = 0;
		this.int_22 = 0;
		this.float_1 = 0f;
		this.int_23 = 0;
		this.bool_27 = false;
		this.thread_6 = null;
		this.string_69 = "";
		this.arrayList_15 = new ArrayList();
		this.bool_28 = false;
		this.string_70 = "";
		this.string_71 = string.Concat("http://", ᝮ.ᜄ, "/bridge.php");
		this.arrayList_16 = new ArrayList();
		this.regex_0 = new Regex("^[0-9]*$");
		this.string_72 = "";
		this.int_24 = 1;
		this.string_73 = "";
		this.bool_29 = false;
		this.bool_30 = false;
		this.ᝡ_0 = null;
		this.arrayList_17 = new ArrayList();
		this.bool_31 = false;
		this.ᝡ_1 = null;
		this.arrayList_18 = new ArrayList();
		this.ᝡ_2 = null;
		this.arrayList_19 = new ArrayList();
		this.bool_32 = false;
		this.bool_33 = false;
		this.string_74 = "";
		this.string_75 = "";
		this.string_76 = "";
		this.string_77 = "";
		this.string_78 = "";
		this.string_79 = "";
		this.float_2 = 0f;
		this.float_3 = 0f;
		this.float_4 = 0f;
		this.int_25 = 0;
		this.string_80 = "";
		this.string_81 = "";
		this.string_82 = "((http|ftp|https)://)(([a-zA-Z0-9\\._-]+\\.[a-zA-Z]{2,6})|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(:[0-9]{1,4})*(/[a-zA-Z0-9\\&%_\\./-~-]*)?";
		this.int_26 = 0;
		this.hashtable_3 = null;
		this.bool_34 = false;
		this.string_83 = "";
		this.bool_35 = false;
		this.arrayList_20 = new ArrayList();
		this.string_84 = "";
		this.arrayList_21 = new ArrayList();
		this.bool_36 = false;
		this.string_85 = string.Concat("http://", ᝮ.ᜄ, "/qqgrpinvite.php");
		this.string_86 = string.Concat("http://", ᝮ.ᜄ, "/taokeqq.php");
		this.string_87 = "";
		this.gclass33_0 = null;
		this.arrayList_22 = new ArrayList();
		this.bool_37 = false;
		this.string_88 = "";
		this.string_89 = "";
		this.gclass4_0 = null;
		this.string_90 = "";
		this.fileStream_0 = null;
		this.streamWriter_0 = null;
		this.string_91 = "";
		this.arrayList_25 = new ArrayList();
		this.string_92 = "";
		this.bool_38 = true;
		this.string_93 = string.Concat("http://", ᝮ.ᜄ, ":80/ordercmb.php");
		this.bool_39 = false;
		this.int_27 = 0;
		this.string_95 = "";
		base();
		try
		{
			ᝉ.ᜀ();
			if (!File.Exists(string.Concat(this.string_41, "\\AutoUpd.exe")))
			{
				try
				{
					this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/AutoUpd.exe"), string.Concat(this.string_41, "\\AutoUpd.exe"));
				}
				catch
				{
					this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/AutoUpd.exe"), string.Concat(this.string_41, "\\AutoUpd.exe"));
				}
			}
			object[] string15 = new object[] { "serverhost=", ᝮ.ᜄ, "&softwarename=", this.string_15, "&curver=", this.int_0, "&processname=", this.string_16 };
			string str = string.Concat(string15);
			try
			{
				Process.Start(string.Concat(this.string_41, "\\AutoUpd.exe"), str);
			}
			catch
			{
				if (File.Exists(string.Concat(this.string_41, "\\AutoUpd.exe")))
				{
					File.Delete(string.Concat(this.string_41, "\\AutoUpd.exe"));
				}
				try
				{
					this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/AutoUpd.exe"), string.Concat(this.string_41, "\\AutoUpd.exe"));
				}
				catch
				{
					this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/AutoUpd.exe"), string.Concat(this.string_41, "\\AutoUpd.exe"));
				}
				Process.Start(string.Concat(this.string_41, "\\AutoUpd.exe"), str);
			}
			this.ᜐ_0.ᜍ = 0;
			this.ᜐ_0.ᜂ = this.string_0;
			if (!this.ᜐ_0.ᜑ(this.string_15, this.string_16, string.Concat(this.int_0, "")))
			{
				Environment.Exit(Environment.ExitCode);
			}
			string str1 = ᝚.ᜂ(string.Concat(this.string_41, "\\", this.string_16));
			string str2 = ᝚.ᜂ(string.Concat(this.string_41, "\\common.dll"));
			this.ᜐ_0.ᜈ = string.Concat(str1, "_", str2);
			Thread thread = new Thread(new ThreadStart(this.ᜐ_0.ᜒ))
			{
				IsBackground = true
			};
			thread.Start();
			(new Thread(new ThreadStart(this.method_5))).Start();
			(new Thread(new ThreadStart(this.method_1))).Start();
			(new Thread(new ThreadStart(this.method_383))).Start();
			(new Thread(new ThreadStart(this.method_3))).Start();
			this.InitializeComponent();
			base.FormClosing += new FormClosingEventHandler(this.AliBridgeForm_FormClosing);
			if (this.ᜐ_0.ᜆ.Equals("2"))
			{
				this.Text = string.Concat(this.Text, "(软件免费使用) - ", this.ᜐ_0.ᜁ);
				this.string_54 = this.Text;
			}
			try
			{
				this.gclass1_0 = new GClass1();
			}
			catch (Exception exception)
			{
				exception.ToString().Contains("System.IO.FileLoadException");
			}
			try
			{
				this.class1_0 = new Class1();
				this.gclass42_0 = new GClass42();
				this.gclass10_0 = new GClass10();
				this.gclass2_0 = new GClass2();
			}
			catch (Exception exception1)
			{
				this.method_115(string.Concat("打开数据库出错！", exception1.ToString()));
			}
			this.string_51 = string.Concat(this.string_41, "\\QQ群快捷方式");
			if (!Directory.Exists(this.string_51))
			{
				Directory.CreateDirectory(this.string_51);
			}
			this.string_52 = string.Concat(this.string_41, "\\任务文件夹");
			if (!Directory.Exists(this.string_52))
			{
				Directory.CreateDirectory(this.string_52);
			}
			this.string_53 = string.Concat(this.string_41, "\\config\\临时文件夹");
			if (!Directory.Exists(this.string_53))
			{
				Directory.CreateDirectory(this.string_53);
			}
			this.string_5 = string.Concat(this.string_53, "\\hotshare");
			if (!Directory.Exists(this.string_5))
			{
				Directory.CreateDirectory(this.string_5);
			}
			this.string_57 = string.Concat(this.string_5, "\\hotsharehid.txt");
			this.string_7 = string.Concat(this.string_53, "\\selhotshare");
			if (!Directory.Exists(this.string_7))
			{
				Directory.CreateDirectory(this.string_7);
			}
			this.string_59 = string.Concat(this.string_7, "\\hotsharehid.txt");
			this.string_11 = string.Concat(this.string_53, "\\sharehotshare");
			if (!Directory.Exists(this.string_11))
			{
				Directory.CreateDirectory(this.string_11);
			}
			this.string_61 = string.Concat(this.string_11, "\\hotsharehid.txt");
			this.string_13 = string.Concat(this.string_53, "\\mutualhotshare");
			if (!Directory.Exists(this.string_13))
			{
				Directory.CreateDirectory(this.string_13);
			}
			this.string_63 = string.Concat(this.string_13, "\\hotsharehid.txt");
			this.method_19();
			this.method_30();
			this.method_20();
			this.method_31();
			this.method_22();
			this.method_21();
			this.method_266();
			this.method_24();
			this.method_29();
			this.method_38();
			this.method_39();
			this.method_34();
			this.method_35();
			this.webBrowserTaoQiang.ScriptErrorsSuppressed = true;
			this.method_40();
			this.method_36();
			this.method_32();
			this.method_33();
			this.method_25();
			this.method_37();
			AliBridgeForm.RegisterHotKey(base.Handle, 10, AliBridgeForm.GEnum2.flag_2, Keys.F12);
			this.bool_30 = true;
			this.bool_31 = true;
			this.method_123();
			this.bool_30 = false;
			this.bool_31 = false;
			this.pictureBoxWaiting.Image = Image.FromFile(string.Concat(this.string_41, "\\config\\waiting.gif"));
			this.contextMenuStripTask.Items.Add("退出");
			this.contextMenuStripTask.Items[0].Click += new EventHandler(this.method_15);
			this.method_14();
			this.method_13();
			this.method_195();
			this.method_197();
			Thread thread1 = new Thread(new ThreadStart(this.method_173))
			{
				IsBackground = true
			};
			thread1.Start();
			this.timer_0 = new System.Windows.Forms.Timer()
			{
				Interval = 1000
			};
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			this.timer_0.Start();
			this.method_255();
			this.richTextBoxDscTQQ.Text = "1.点【显示最新数据】，显示佣金比例。 2.点【鹊桥佣金】或者【定向佣金】排序。\n3.双击鹊桥佣金数字，复制鹊桥产品链接推广。\n4.双击定向佣金数字，申请定向计划，通过后点【通用计划】行的【推广】。";
			this.method_0();
			this.method_41();
			this.method_42();
			this.method_43();
			this.method_44();
			if (this.method_350())
			{
				this.method_351();
			}
			this.method_377();
			this.method_379();
			this.method_45();
			this.method_47();
			this.method_49();
			GClass13 gClass13 = new GClass13();
			(new Thread(new ThreadStart(gClass13.method_0))).Start();
			(new Thread(new ThreadStart(gClass13.method_1))).Start();
			if (File.Exists(string.Concat(this.string_41, "\\admin.txt")))
			{
				this.buttonStt.Enabled = true;
				this.buttonSaveToSvr.Visible = true;
				this.checkBoxLoadDataNow.Visible = true;
				this.checkBoxUpHotShare.Visible = true;
				this.groupBoxQyAdmin.Visible = true;
			}
			if (this.checkBoxAutoLogin.Checked)
			{
				this.bool_0 = false;
				this.method_7();
			}
			Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
		}
		catch (Exception exception2)
		{
			MessageBox.Show(exception2.ToString(), "软件启动出错！");
		}
	}

	private void AliBridgeForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			base.Hide();
			e.Cancel = true;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[FormClosingProcess]出错，", exception.ToString()));
		}
	}

	private void AliBridgeForm_Load(object sender, EventArgs e)
	{
		try
		{
			this.skinEngine_0.set_SkinFile(string.Concat(Application.StartupPath, "\\skin\\Deep\\DeepCyan.ssk"));
			this.checkBoxShortUrl.ForeColor = Color.Red;
			this.labelUUSts.ForeColor = Color.Green;
			this.buttonRtnSelHotList.ForeColor = Color.Green;
			this.buttonSelHotAddFollow.ForeColor = Color.FromArgb(54, 222, 110);
			this.buttonSelHotAddManul.ForeColor = Color.FromArgb(54, 222, 110);
			this.linkLabelVipCharge.ForeColor = Color.Red;
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void buttonAddMsgReplace_Click(object sender, EventArgs e)
	{
		try
		{
			if (!this.textBoxOldChar.Text.Equals(""))
			{
				GClass29 gClass29 = new GClass29()
				{
					string_0 = this.textBoxOldChar.Text,
					string_1 = this.textBoxNewChar.Text
				};
				this.arrayList_25.Add(gClass29);
				this.method_378();
				this.method_379();
				this.textBoxOldChar.Text = "";
				this.textBoxNewChar.Text = "";
				this.method_115("添加文字替换成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonAddMsgReplace_Click]出错！", exception.ToString()));
		}
	}

	private void buttonAddTask_Click(object sender, EventArgs e)
	{
		IEnumerator enumerator;
		bool flag;
		try
		{
			this.bool_15 = this.checkBoxUpHotShare.Checked;
			string innerHtml = this.webBrowserSendContent.Document.Body.InnerHtml;
			if ((innerHtml == null ? false : !innerHtml.Equals("")))
			{
				string str = DateTime.Now.ToString("MMddHHmmss");
				string string52 = this.string_52;
				DateTime now = DateTime.Now;
				string str1 = string.Concat(string52, "\\", now.ToString("yyyy"), str);
				if (!Directory.Exists(str1))
				{
					Directory.CreateDirectory(str1);
					try
					{
						innerHtml = innerHtml.Replace("<img", "<IMG");
						int num = 0;
						while (true)
						{
							int num1 = innerHtml.IndexOf("<IMG", num);
							num = num1;
							if (num1 == -1)
							{
								break;
							}
							int num2 = innerHtml.IndexOf("src", num);
							int num3 = innerHtml.IndexOf("SRC", num);
							int num4 = num2;
							if (num4 == -1)
							{
								flag = false;
							}
							else
							{
								flag = (num4 <= num3 ? true : num3 == -1);
							}
							if (!flag)
							{
								num4 = num3;
							}
							int num5 = innerHtml.IndexOf("\"", num4) + 1;
							string str2 = innerHtml.Substring(num5, innerHtml.IndexOf("\"", num5) - num5);
							string str3 = HttpUtility.UrlDecode(str2.Replace("file:///", "").Replace("/", "\\"));
							now = DateTime.Now;
							string str4 = string.Concat(str1, "\\", now.ToString("yyyyMMddHHmmssfff"), str3.Substring(str3.LastIndexOf(".")));
							try
							{
								File.Copy(str3, str4);
								string str5 = string.Concat("file:///", str4.Replace(" ", "%20").Replace("{", "%7b").Replace("}", "%7d").Replace("\\", "/"));
								innerHtml = innerHtml.Replace(str2, str5);
							}
							catch (Exception exception)
							{
								this.method_115("复制图片出错，请用先删除编辑区图片，再用QQ截图单独拷贝图片！");
							}
							num++;
						}
						string str6 = string.Concat(str1, "\\task.txt");
						᝚.ᜁ(str6, innerHtml, Encoding.GetEncoding("GB2312"));
						this.string_76 = "";
						this.int_26 = 0;
						GClass15 gClass15 = new GClass15()
						{
							string_0 = str,
							string_1 = "0"
						};
						this.gclass42_0.method_8(gClass15, out this.string_23);
						if (this.string_23.Equals(""))
						{
							this.method_136(᜸.ᜄ(innerHtml.Replace("<", " <").Replace(">", "> ")).Replace("&nbsp;", " "), 0);
							if (File.Exists(string.Concat(this.string_41, "\\admin.txt")))
							{
								foreach (GClass25 arrayList5 in this.arrayList_5)
								{
									innerHtml = innerHtml.Replace(arrayList5.string_1, string.Concat(arrayList5.string_2, " "));
								}
								᝚.ᜁ(string.Concat(str1, "\\followContentWithoutPid.txt"), innerHtml);
							}
							if (this.bool_15)
							{
								bool flag1 = false;
								enumerator = ((IEnumerable)this.dataGridViewHotShare.Rows).GetEnumerator();
								try
								{
									while (true)
									{
										if (enumerator.MoveNext())
										{
											DataGridViewRow current = (DataGridViewRow)enumerator.Current;
											if (this.string_79.Equals(current.Cells[0].Value))
											{
												flag1 = true;
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
									IDisposable disposable = enumerator as IDisposable;
									if (disposable != null)
									{
										disposable.Dispose();
									}
								}
								if (flag1)
								{
									᝚.ᜁ(string.Concat(str1, "\\hotshare.txt"), "nocontent");
									this.method_115("爆款分享内容已经存在，不保存！");
								}
								else if ((this.arrayList_5 == null ? false : this.arrayList_5.Count != 0))
								{
									string str7 = string.Concat(str1, "\\hotshare.txt");
									object[] string79 = new object[] { this.string_79, "\n", this.float_2 - this.float_3, "\n", this.float_4 };
									᝚.ᜁ(str7, string.Concat(string79));
									this.method_115("保存爆款分享内容成功！");
								}
								else
								{
									᝚.ᜁ(string.Concat(str1, "\\hotshare.txt"), "nocontent");
									this.method_115("爆款分享内容没有产品链接，不保存！");
								}
							}
							else if (this.checkBoxUpHotShare.Visible)
							{
								this.method_115("该内容不保存爆款！");
							}
							this.method_156();
							this.method_159();
							this.method_115("添加任务成功！");
						}
						else
						{
							this.method_115(string.Concat("添加计划失败：", this.string_23));
							return;
						}
					}
					catch (Exception exception2)
					{
						Exception exception1 = exception2;
						Directory.Delete(str1, true);
						this.method_115(string.Concat("添加任务出错！", exception1.ToString(), "\n", this.webBrowserSendContent.Document.Body.InnerHtml));
					}
				}
				else
				{
					this.method_115("该时间已经有任务了！");
				}
			}
			else
			{
				this.method_115("请在【手动群发】的【内容编辑区】输入内容！");
			}
		}
		catch (Exception exception3)
		{
			this.method_115(string.Concat("[buttonAddTask_Click]出错：", exception3.ToString()));
		}
	}

	private void buttonAddToFollow_Click(object sender, EventArgs e)
	{
		string str;
		string str1;
		bool flag;
		try
		{
			string innerHtml = this.webBrowserSendContent.Document.Body.InnerHtml;
			if ((innerHtml == null ? false : !innerHtml.Equals("")))
			{
				while (true)
				{
					str1 = DateTime.Now.ToString("yyyyMMddHHmmss");
					str = string.Concat(this.string_68, "\\", str1);
					if (!Directory.Exists(str))
					{
						break;
					}
					Thread.Sleep(1000);
				}
				Directory.CreateDirectory(str);
				innerHtml = innerHtml.Replace("<img", "<IMG");
				int num = 0;
				while (true)
				{
					int num1 = innerHtml.IndexOf("<IMG", num);
					num = num1;
					if (num1 == -1)
					{
						break;
					}
					int num2 = innerHtml.IndexOf("src", num);
					int num3 = innerHtml.IndexOf("SRC", num);
					int num4 = num2;
					if (num4 == -1)
					{
						flag = false;
					}
					else
					{
						flag = (num4 <= num3 ? true : num3 == -1);
					}
					if (!flag)
					{
						num4 = num3;
					}
					int num5 = innerHtml.IndexOf("\"", num4) + 1;
					string str2 = innerHtml.Substring(num5, innerHtml.IndexOf("\"", num5) - num5);
					string str3 = HttpUtility.UrlDecode(str2.Replace("file:///", "").Replace("/", "\\"));
					if (!str3.Contains(str1))
					{
						DateTime now = DateTime.Now;
						string str4 = string.Concat(str, "\\", now.ToString("yyyyMMddHHmmssfff"), str3.Substring(str3.LastIndexOf(".")));
						try
						{
							File.Copy(str3, str4);
							string str5 = string.Concat("file:///", str4.Replace(" ", "%20").Replace("{", "%7b").Replace("}", "%7d").Replace("\\", "/"));
							innerHtml = innerHtml.Replace(str2, str5);
						}
						catch (Exception exception)
						{
							this.method_115("复制图片出错，请用先删除编辑区图片，再用QQ截图单独拷贝图片！");
						}
						num++;
					}
					else
					{
						num++;
					}
				}
				᝚.ᜁ(string.Concat(str, "\\content.html"), innerHtml, Encoding.GetEncoding("GB2312"));
				᝚.ᜁ(string.Concat(str, "\\0.txt"), "");
				this.method_156();
				this.method_115("添加到跟发成功！");
			}
			else
			{
				this.method_115("请在【手动群发】的【内容编辑区】输入内容！");
			}
		}
		catch (Exception exception1)
		{
			this.method_115(string.Concat("[buttonAddToFollow_Click]出错：", exception1.ToString()));
		}
	}

	private void buttonAddUserPoi_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.method_6(1))
			{
				if (!this.method_350())
				{
					this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
				}
				else if ((this.textBoxRefundQQ.Text.Trim().Equals("") ? false : !this.textBoxRefundAmount.Text.Trim().Equals("")))
				{
					string str = this.textBoxRefundQQ.Text.Trim();
					string str1 = this.textBoxRefundAmount.Text.Trim();
					string text = this.textBoxRefundRemark.Text;
					ArrayList arrayLists = this.method_361(str);
					if ((arrayLists == null ? false : arrayLists.Count != 0))
					{
						GClass38 gClass38 = new GClass38()
						{
							string_0 = str,
							string_1 = DateTime.Now.ToString("yyyyMMddHHmmss"),
							float_0 = float.Parse(str1),
							string_2 = text
						};
						if (!this.gclass33_0.method_35(gClass38, out this.string_23))
						{
							this.method_115(string.Concat("【", str, "】增加积分失败！", this.string_23));
						}
						else
						{
							this.method_360();
							this.textBoxRefundQQ.Text = "";
							this.textBoxRefundAmount.Text = "";
							object[] float0 = new object[] { "【", str, "】增加【", gClass38.float_0, "】积分成功！" };
							this.method_115(string.Concat(float0));
						}
					}
					else
					{
						this.method_115("QQ用户搜不到！");
					}
				}
				else
				{
					this.method_115("QQ号或者积分不对！");
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonAddUserPoi_Click]", exception.ToString()));
		}
	}

	private void buttonAddWxGrp_Click(object sender, EventArgs e)
	{
		if (this.checkBoxWxPromot.Checked)
		{
			string str = this.textBoxWxGrpName.Text.Trim();
			if (!str.Equals(""))
			{
				string str1 = string.Concat(this.string_51, "\\", str, ".lnk");
				if (!File.Exists(str1))
				{
					FileStream fileStream = File.Create(str1);
					fileStream.Close();
					fileStream.Dispose();
					this.textBoxWxGrpName.Text = "";
					this.method_26();
					this.method_115("微信群添加成功！");
				}
				else
				{
					this.method_115("微信群已经存在！");
				}
			}
			else
			{
				this.method_115("请输入微信群名称！");
			}
		}
		else
		{
			MessageBox.Show("请在【软件设置】里面选中【微信推广模式】，再添加微信群！");
		}
	}

	private void buttonAddWxGrp_MouseEnter(object sender, EventArgs e)
	{
		this.toolTip_0.ToolTipTitle = "添加微信群";
		this.toolTip_0.IsBalloon = false;
		this.toolTip_0.UseFading = true;
		this.toolTip_0.Show("如果灰色不能操作，在【软件设置】里面勾选【微信推广模式】", this.buttonAddWxGrp);
	}

	private void buttonAddWxGrp_MouseLeave(object sender, EventArgs e)
	{
		this.toolTip_0.Hide(this.buttonAddWxGrp);
	}

	private void buttonAuditBridge_Click(object sender, EventArgs e)
	{
		if (this.method_392(1))
		{
			this.string_95 = this.textBoxAuditBridgeId.Text.Trim();
			if (!this.string_95.Equals(""))
			{
				this.int_27 = 0;
				try
				{
					this.int_27 = int.Parse(this.textBoxSoldQuantity.Text);
				}
				catch
				{
				}
				this.bool_39 = this.checkBoxAuditCms.Checked;
				(new Thread(new ThreadStart(this.method_393))).Start();
			}
			else
			{
				this.method_115("请输入鹊桥编号！");
			}
		}
	}

	private void buttonBatch_Click(object sender, EventArgs e)
	{
		try
		{
			this.dataGridViewAliOdr.Rows.Clear();
			string fileName = "";
			this.openFileDialog_0.Filter = "文本文件(*.txt)|*.txt";
			this.openFileDialog_0.Title = "打开订单文件TXT(一行一个订单号)";
			if (this.openFileDialog_0.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				this.method_115("没有导入订单文件！");
			}
			else
			{
				fileName = this.openFileDialog_0.FileName;
				this.method_115(string.Concat("导入订单文件成功！【", fileName, "】"));
				ArrayList arrayLists = new ArrayList();
				StreamReader streamReader = new StreamReader(fileName);
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
						arrayLists.Add(str.Trim());
					}
				}
				streamReader.Close();
				streamReader.Dispose();
				this.method_115(string.Concat("订单文件有[", arrayLists.Count, "]个订单号！"));
				this.method_102();
				this.arrayList_2 = this.method_113(arrayLists);
				if (this.arrayList_2.Count == 0)
				{
					this.method_115("搜到结果有0个订单号！");
				}
				else
				{
					string str2 = this.method_112(arrayLists);
					if (!str2.Equals(""))
					{
						object[] count = new object[] { "搜到结果有[", this.arrayList_2.Count, "]个订单号！不存在的订单号：[", str2, "]。" };
						this.method_115(string.Concat(count));
					}
					else
					{
						this.method_115(string.Concat("搜到结果有[", this.arrayList_2.Count, "]个订单号！"));
					}
					this.method_114(this.arrayList_2);
				}
				this.method_103();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonBatch_Click]出错：", exception.ToString()));
			this.method_103();
		}
	}

	private void buttonBatchRefund_Click(object sender, EventArgs e)
	{
		bool flag;
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				try
				{
					if (MessageBox.Show("批量返现将会把所有可用积分清0，生成一个返现文件，立即执行吗？", "批量返现提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != System.Windows.Forms.DialogResult.Cancel)
					{
						this.method_375(5, false);
						this.arrayList_24 = new ArrayList();
						for (int i = 0; i < this.dataGridViewRtnFundUser.RowCount; i++)
						{
							float single = 0f;
							try
							{
								single = float.Parse(this.dataGridViewRtnFundUser[1, i].Value.ToString());
							}
							catch
							{
							}
							if (single > 0f)
							{
								if (this.dataGridViewRtnFundUser[4, i].Value == null || this.dataGridViewRtnFundUser[4, i].Value.Equals(""))
								{
									goto Label1;
								}
								if (this.dataGridViewRtnFundUser[5, i].Value == null)
								{
									flag = true;
									goto Label0;
								}
								else
								{
									flag = this.dataGridViewRtnFundUser[5, i].Value.Equals("");
									goto Label0;
								}
							}
						Label1:
							flag = true;
						Label0:
							if (!flag)
							{
								string str = this.dataGridViewRtnFundUser[0, i].Value.ToString();
								this.arrayList_24.Add(str);
							}
						}
						if (this.arrayList_24.Count <= 0)
						{
							this.method_115("没有要返现的用户！");
						}
						else
						{
							this.method_374();
							this.method_375(4, false);
							this.method_115("开始批量返现！");
							(new Thread(new ThreadStart(this.method_368))).Start();
						}
					}
				}
				catch (Exception exception)
				{
					this.method_115(string.Concat("[buttonBatchRefund_Click]", exception.ToString()));
				}
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonChkCoupon_Click(object sender, EventArgs e)
	{
		if ((this.webBrowserConvert.Document.Body.InnerHtml == null ? false : !this.webBrowserConvert.Document.Body.InnerHtml.Equals("")))
		{
			string innerText = this.webBrowserConvert.Document.Body.InnerText;
			this.bool_34 = this.method_135(innerText);
			if (!this.bool_34)
			{
				this.method_115("没有优惠券链接！");
			}
			else
			{
				᝕ _u1755 = ᜤ.ᜅ(this.string_83);
				this.method_115(string.Concat("优惠券数量提醒！******", _u1755.ᜄ(), "******"));
			}
		}
		else
		{
			this.method_115("没有内容！");
		}
	}

	private void buttonClearSndConten_Click(object sender, EventArgs e)
	{
		this.method_156();
		this.method_115("清空完成！");
	}

	private void buttonClrAliOdrDb_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("清空已经下载的所有订单吗？", "清空订单数据库提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != System.Windows.Forms.DialogResult.Cancel)
		{
			this.method_102();
			this.gclass42_0.method_7("delete from aliorder;", out this.string_23);
			this.method_115("清空订单数据库完成。");
			this.method_115("开始优化数据库！");
			this.gclass42_0.method_24();
			this.method_115("优化数据库成功！");
			this.method_103();
		}
	}

	private void buttonClrBdShort_Click(object sender, EventArgs e)
	{
		this.textBoxOrgUrl.Text = "";
		this.textBoxShortUrl.Text = "";
	}

	private void buttonClrCoupon_Click(object sender, EventArgs e)
	{
		this.textBoxPcCoupon.Text = "";
		this.textBoxMbCoupon.Text = "";
	}

	private void buttonClrLclTQQData_Click(object sender, EventArgs e)
	{
		try
		{
			this.buttonClrLclTQQData.Enabled = false;
			this.gclass10_0.method_16(out this.string_23);
			this.gclass10_0.method_11(out this.string_23);
			this.gclass10_0.method_6(GClass13.string_1, out this.string_23);
			this.gclass10_0.method_6(GClass13.string_2, out this.string_23);
			this.dataGridViewTaobaoQing.Rows.Clear();
			this.dataGridViewTaobaoQiang.Rows.Clear();
			this.buttonClrLclTQQData.Enabled = true;
			this.method_115("本地【淘清仓】【淘抢购】数据删除完成！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonClrLclTQQData_Click]出错：", exception.ToString()));
		}
	}

	private void buttonClrOdrPoi_Click(object sender, EventArgs e)
	{
		this.textBoxSchAliOdrPoi.Text = "";
		this.textBoxSchOdrPid.Text = "";
		this.textBoxOdrSchQQNum.Text = "";
		this.dataGridViewAliOdrPoi.Rows.Clear();
		this.dataGridViewAliOdrPoi.Columns[1].Width = 378;
	}

	private void buttonClrOdrSchCond_Click(object sender, EventArgs e)
	{
		this.textBoxOrderSch.Text = "";
		this.textBoxProductID.Text = "";
		this.comboBoxOrderSts.Text = "";
		this.dataGridViewAliOdr.Rows.Clear();
	}

	private void buttonClrQQGrpInvite_Click(object sender, EventArgs e)
	{
		this.comboBoxQQGroup.Text = "";
		this.textBoxQQInvite.Text = "";
		this.textBoxQQ.Text = "";
		this.dataGridViewQQGrpInvite.Rows.Clear();
	}

	private void buttonClrUser_Click(object sender, EventArgs e)
	{
		this.textBoxSchRefundHisQQ.Text = "";
		this.textBoxUserSchQQ.Text = "";
		this.dataGridViewRtnFundUser.Rows.Clear();
		this.method_375(4, false);
		this.method_375(5, false);
	}

	private void buttonCompressDb_Click(object sender, EventArgs e)
	{
		try
		{
			this.buttonStt.Enabled = false;
			this.buttonDlByBrdgID.Enabled = false;
			this.buttonCompressDb.Enabled = false;
			this.buttonCompressDb.Text = "正在优化";
			this.pictureBoxWaiting.Visible = true;
			(new Thread(new ThreadStart(this.method_99))).Start();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonCompressDb_Click]出错：", exception.ToString()));
		}
	}

	private void buttonConvert_Click(object sender, EventArgs e)
	{
		this.int_25 = 2;
		this.method_306();
	}

	private void buttonConvertAndAddToSnd_Click(object sender, EventArgs e)
	{
		this.int_25 = 1;
		this.method_306();
	}

	private void buttonConvertClr_Click(object sender, EventArgs e)
	{
		((IHTMLDocument2)this.webBrowserConvert.Document.DomDocument).body.innerHTML = "";
		this.method_323(1, false);
		this.method_323(2, false);
		this.method_323(3, false);
	}

	private void buttonCopyShortUrl_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.Clear();
			Clipboard.SetText(this.textBoxShortUrl.Text);
			this.method_115("复制短网址成功！");
		}
		catch
		{
			this.method_115("复制短网址失败！请重新复制！");
		}
	}

	private void buttonCoSubOrder_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_386(false);
			this.method_122();
			(new Thread(new ThreadStart(this.method_382))).Start();
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_386(true);
			this.method_115(string.Concat("[buttonCoSubOrder_Click]出错！", exception.ToString()));
		}
	}

	private void buttonCouponTkl_Click(object sender, EventArgs e)
	{
		try
		{
			string str = this.textBoxPcCoupon.Text.Trim();
			if ((!str.Contains("coupon") ? true : !str.Contains("taobao.com")))
			{
				str = ᜤ.ᜀ(str, str);
			}
			str = HttpUtility.UrlDecode(str);
			str = str.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
			string str1 = ᝉ.ᜀ(str, 0, "sellerId=", "&");
			string str2 = ᝉ.ᜀ(str, 0, "activityId=", "&");
			if ((str1 == null || str1.Equals("") || str2 == null ? false : !str2.Equals("")))
			{
				string str3 = "user={user}&type=coupon&coupontype={coupontype}&seller_id={seller_id}&activity_id={activity_id}";
				str3 = str3.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{coupontype}", "0").Replace("{seller_id}", str1).Replace("{activity_id}", str2);
				string str4 = this.method_17(this.ᝠ_1, this.string_1, str3);
				Hashtable hashtables = this.method_206(str4);
				if (!"ng".Equals(hashtables["result"]))
				{
					string item = (string)hashtables["taokouling"];
					Clipboard.Clear();
					Clipboard.SetText(item);
					this.method_115(string.Concat("生成优惠券淘口令完成并且已经拷贝到剪切板！淘口令：【", item, "】"));
				}
				else
				{
					this.method_115(string.Concat("生成淘口令失败：", (string)hashtables["errmsg"]));
				}
			}
			else
			{
				this.method_115("优惠券地址不对！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("复制优惠券的淘口令失败！", exception.ToString()));
		}
	}

	private void buttonCp2in1Tkl_Click(object sender, EventArgs e)
	{
		Clipboard.Clear();
		Clipboard.SetText(string.Concat("复制这条信息，", this.string_77, "，打开【手机淘宝】即可【领券购买】"));
		this.method_115(string.Concat("复制【2合1淘口令】完成并且已经拷贝到剪切板！淘口令：【", this.string_77, "】"));
	}

	private void buttonCpCoupon_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.Clear();
			string str = string.Concat("手机优惠券：", this.textBoxMbCoupon.Text.Trim(), "\r\n电脑优惠券：", this.textBoxPcCoupon.Text);
			Clipboard.SetText(str);
			this.method_115("复制优惠券成功！");
		}
		catch
		{
			this.method_115("复制优惠券失败！请重新复制！");
		}
	}

	private void buttonCpCouponTkl_Click(object sender, EventArgs e)
	{
		Clipboard.Clear();
		Clipboard.SetText(string.Concat("第一步：复制这条信息，", this.string_75, "，打开【手机淘宝】即可【领券】"));
		this.method_115(string.Concat("复制【优惠券淘口令】完成并且已经拷贝到剪切板！淘口令：【", this.string_75, "】"));
	}

	private void buttonCpPromotLnk_Click(object sender, EventArgs e)
	{
		try
		{
			if (!this.textBoxPromotLnk.Text.Equals(""))
			{
				Clipboard.SetText(this.method_198(this.textBoxPromotLnk.Text));
				this.method_115("推广链接复制成功！");
			}
		}
		catch
		{
			this.method_115("推广链接复制失败，请重新复制！");
		}
	}

	private void buttonCpPromotTkl_Click(object sender, EventArgs e)
	{
		Clipboard.Clear();
		if (!this.bool_34)
		{
			Clipboard.SetText(string.Concat("复制这条信息，", this.string_76, "，打开【手机淘宝】即可【购买】"));
		}
		else
		{
			Clipboard.SetText(string.Concat("第二步：复制这条信息，", this.string_76, "，打开【手机淘宝】即可【购买】"));
		}
		this.method_115(string.Concat("复制【推广淘口令】完成并且已经拷贝到剪切板！淘口令：【", this.string_76, "】"));
	}

	private void buttonCpShortCoupon_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.Clear();
			string str = this.textBoxPcCoupon.Text.Trim();
			if ((str.Contains("url.cn") || str.Contains("t.cn") || str.Contains("dwz.cn") || str.Contains("tb.cn") ? false : !str.Contains("tao.bb")))
			{
				str = this.method_204(str);
			}
			string str1 = string.Concat("手机优惠券：", this.method_204(this.textBoxMbCoupon.Text.Trim()), "\r\n电脑优惠券：", str);
			Clipboard.SetText(str1);
			this.method_115("复制优惠券成功！");
		}
		catch
		{
			this.method_115("复制优惠券失败！请重新复制！");
		}
	}

	private void buttonDelAllTask_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("确定要删除全部任务吗？", "删除全部任务提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != System.Windows.Forms.DialogResult.Cancel)
		{
			this.method_162();
			try
			{
				Directory.Delete(this.string_52, true);
			}
			catch
			{
			}
			this.gclass42_0.method_10(out this.string_23);
			if (this.string_23.Equals(""))
			{
				this.method_159();
				this.method_156();
				this.method_115("删除全部任务成功！");
			}
			else
			{
				this.method_115(string.Concat("删除全部计划失败，", this.string_23));
			}
		}
	}

	private void buttonDelMsgReplace_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.dgvQQGrpMonRep.CurrentCell != null)
			{
				int rowIndex = this.dgvQQGrpMonRep.CurrentCell.RowIndex;
				int columnIndex = this.dgvQQGrpMonRep.CurrentCell.ColumnIndex;
				string str = this.dgvQQGrpMonRep[0, rowIndex].Value.ToString();
				int num = -1;
				int num1 = 0;
				while (true)
				{
					if (num1 >= this.arrayList_25.Count)
					{
						break;
					}
					else if (str.Equals(((GClass29)this.arrayList_25[num1]).string_0))
					{
						num = num1;
						break;
					}
					else
					{
						num1++;
					}
				}
				if (num != -1)
				{
					this.arrayList_25.RemoveAt(num);
				}
				this.method_378();
				this.method_379();
				this.textBoxOldChar.Text = "";
				this.textBoxNewChar.Text = "";
				this.method_115("删除文字替换成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonDelMsgReplace_Click]出错！", exception.ToString()));
		}
	}

	private void buttonDelTask_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewAutoSndTask.CurrentCell != null)
			{
				string string0 = ((GClass15)this.dataGridViewAutoSndTask.CurrentRow.Tag).string_0;
				GClass15 gClass15 = null;
				IEnumerator enumerator = this.arrayList_6.GetEnumerator();
				try
				{
					while (true)
					{
						if (enumerator.MoveNext())
						{
							GClass15 current = (GClass15)enumerator.Current;
							if (current.string_0 == string0)
							{
								gClass15 = current;
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
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				try
				{
					Directory.Delete(string.Concat(this.string_52, "\\", gClass15.string_0), true);
				}
				catch
				{
				}
				this.gclass42_0.method_11(gClass15, out this.string_23);
				if (this.string_23.Equals(""))
				{
					this.method_159();
					this.method_156();
					this.method_115("删除任务成功！");
				}
				else
				{
					this.method_115(string.Concat("删除计划失败，", this.string_23));
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonDelTask_Click]出错：", exception.ToString()));
		}
	}

	private void buttonDlByBrdgID_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.method_118())
			{
				if (!this.textBoxManulBrdgId.Text.Trim().Equals(""))
				{
					this.buttonDlByBrdgID.Enabled = false;
					this.buttonDlByBrdgID.Text = "开始采集";
					this.buttonStt.Enabled = false;
					this.buttonCompressDb.Enabled = false;
					this.pictureBoxWaiting.Visible = true;
					(new Thread(new ThreadStart(this.method_96))).Start();
				}
				else
				{
					this.method_115("别忘了填鹊桥ID！");
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonDlByBrdgID_Click]出错：", exception.ToString()));
		}
	}

	private void buttonDlOnlineOdr_Click(object sender, EventArgs e)
	{
		try
		{
			this.dataGridViewAliOdr.Rows.Clear();
			(new Thread(new ThreadStart(this.method_108))).Start();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonDlOnlineOdr_Click]出错啦！", exception.ToString()));
		}
	}

	private void buttonDownloadTaoQing_Click(object sender, EventArgs e)
	{
		(new Thread(new ThreadStart(this.method_207))).Start();
	}

	private void buttonExpAllQQ_Click(object sender, EventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < this.dataGridViewQQGrpMember.Rows.Count; i++)
		{
			if (this.dataGridViewQQGrpMember.Rows[i].Cells[0].Value.ToString().ToLower().Equals("true"))
			{
				stringBuilder.AppendLine(this.dataGridViewQQGrpMember.Rows[i].Cells[1].Value.ToString());
			}
		}
		if (!stringBuilder.ToString().Equals(""))
		{
			this.method_346(stringBuilder.ToString());
			this.method_115("导出成功！");
		}
		else
		{
			this.method_115("没有选中QQ！");
		}
	}

	private void buttonExpQQGrp_Click(object sender, EventArgs e)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < this.dataGridViewSchQQGrpMember.Rows.Count; i++)
		{
			stringBuilder.AppendLine(this.dataGridViewSchQQGrpMember[0, i].Value.ToString());
		}
		if (!stringBuilder.ToString().Equals(""))
		{
			this.method_346(stringBuilder.ToString());
			this.method_115("导出成功！");
		}
		else
		{
			this.method_115("没有需要导出的QQ群！");
		}
	}

	private void buttonFollowSend_Click(object sender, EventArgs e)
	{
		string str;
		string str1;
		ᝯ _ᝯ;
		if ((!this.radioButtonQQFollow.Checked ? true : this.method_6(1)))
		{
			try
			{
				this.method_122();
				if (this.radioButtonSvrFollow.Checked)
				{
					str = this.textBoxFwMainUser.Text.Trim();
					if (!str.Equals(""))
					{
						this.thread_3 = new Thread(new ParameterizedThreadStart(GClass0.smethod_3));
						this.thread_3.Start(str);
					}
					else
					{
						this.method_115("输入主账号用户名！");
						this.buttonFollowSend.Enabled = true;
						this.buttonFollowSend.Text = "加载跟发内容";
						return;
					}
				}
				else if (this.radioButtonQQFollow.Checked)
				{
					if (File.Exists(this.textBoxQQPlusPath.Text))
					{
						string text = this.textBoxQQPlusPath.Text;
						᝚.ᜁ(string.Concat(text.Substring(0, text.LastIndexOf("\\")), "\\config\\mainprocesspath.txt"), string.Concat(this.string_41, "\\千语淘客助手.exe"));
						this.thread_4 = new Thread(new ThreadStart(this.method_250));
						this.thread_4.Start();
					}
					else
					{
						this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
						return;
					}
				}
				else if (this.radioButtonQYFollow.Checked)
				{
					str1 = "";
					_ᝯ = new ᝯ();
					_ᝯ.ᜀ("data", string.Concat("type=qianyumainuser&ftype=0&username=", this.ᜐ_0.ᜁ));
					_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/followsend.php"), ref str1);
					if (!str1.StartsWith("ok"))
					{
						_ᝯ = new ᝯ();
						_ᝯ.ᜀ("data", string.Concat("type=qianyumainuser&ftype=0&username=", this.ᜐ_0.ᜁ));
						_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/followsend.php"), ref str1);
						if (!str1.StartsWith("ok"))
						{
							this.method_115("等会再试试吧！");
							return;
						}
					}
					str = str1.Substring(2);
					this.thread_3 = new Thread(new ParameterizedThreadStart(GClass0.smethod_3));
					this.thread_3.Start(str);
				}
				else if (!this.radioButtonSelHotShare.Checked)
				{
					if (!this.radioButtonQYFcFollow.Checked)
					{
						this.method_115("跟发模式选择不正确，退出跟发！");
						return;
					}
					else
					{
						str1 = "";
						_ᝯ = new ᝯ();
						_ᝯ.ᜀ("data", string.Concat("type=qianyumainuser&ftype=1&username=", this.ᜐ_0.ᜁ));
						_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/followsend.php"), ref str1);
						if (!str1.StartsWith("ok"))
						{
							_ᝯ = new ᝯ();
							_ᝯ.ᜀ("data", string.Concat("type=qianyumainuser&ftype=1&username=", this.ᜐ_0.ᜁ));
							_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/followsend.php"), ref str1);
							if (!str1.StartsWith("ok"))
							{
								this.method_115("等会再试试吧！");
								return;
							}
						}
						str = str1.Substring(2);
						this.thread_3 = new Thread(new ParameterizedThreadStart(GClass0.smethod_3));
						this.thread_3.Start(str);
					}
				}
				this.thread_5 = new Thread(new ThreadStart(this.method_259));
				this.thread_5.Start();
				this.method_115("开始跟发内容监听！");
				this.buttonFollowSend.Text = "正在跟发";
				this.buttonFollowSend.Enabled = false;
				this.textBoxFwMainUser.Enabled = false;
				this.buttonStpFollowSend.Enabled = true;
				this.radioButtonSvrFollow.Enabled = false;
				this.radioButtonQQFollow.Enabled = false;
				this.radioButtonQYFollow.Enabled = false;
				this.radioButtonQYFcFollow.Enabled = false;
				this.radioButtonSelHotShare.Enabled = false;
				this.buttonLoadQQGrpList.Focus();
			}
			catch (Exception exception)
			{
				this.method_115(string.Concat("[buttonFollowSend_Click]出错：", exception.ToString()));
			}
		}
	}

	private void buttonFollowSndStart_Click(object sender, EventArgs e)
	{
		if (this.method_117() && this.method_119())
		{
			try
			{
				this.method_122();
				this.method_260(1, false);
				this.method_260(3, false);
				this.method_260(4, false);
				this.method_260(5, false);
				this.method_260(6, false);
				this.method_260(7, false);
				this.method_260(8, false);
				this.method_260(9, false);
				this.method_260(2, true);
				try
				{
					this.int_22 = int.Parse(this.textBoxFwCouponLwNum.Text.Trim());
				}
				catch
				{
					this.int_22 = 10;
					this.textBoxFwCouponLwNum.Text = "10";
				}
				try
				{
					this.float_1 = (float)int.Parse(this.textBoxLowestFwCms.Text.Trim());
				}
				catch
				{
					this.float_1 = 10f;
					this.textBoxLowestFwCms.Text = "10";
				}
				try
				{
					this.int_21 = int.Parse(this.textBoxFollowSndInteval.Text) * 1000;
				}
				catch
				{
					this.int_21 = 600000;
					this.textBoxFollowSndInteval.Text = "60";
				}
				try
				{
					this.int_23 = int.Parse(this.textBoxNotFwHour.Text);
				}
				catch
				{
					this.int_23 = 1;
					this.textBoxNotFwHour.Text = "1";
				}
				if (!this.checkBoxQQGrpFw.Checked)
				{
					this.bool_27 = false;
				}
				else if (this.radioButtonQQFollow.Checked)
				{
					this.bool_27 = true;
				}
				else
				{
					this.checkBoxQQGrpFw.Checked = false;
					this.bool_27 = false;
					this.method_115("只有【QQ群跟发】模式下才能勾选【机器人采集上传跟发】！");
				}
				this.bool_15 = this.checkBoxUpHotShare.Checked;
				this.thread_6 = new Thread(new ThreadStart(this.method_251));
				this.thread_6.Start();
				this.method_115("启动跟发群发！");
				this.buttonLoadQQGrpList.Focus();
			}
			catch (Exception exception)
			{
				this.method_115(string.Concat("[buttonFollowSndStart_Click]出错：", exception.ToString()));
			}
		}
	}

	private void buttonFollowSndStop_Click(object sender, EventArgs e)
	{
		try
		{
			this.bool_20 = true;
			this.thread_6.Abort();
			this.buttonLoadQQGrpList.Focus();
		}
		catch
		{
		}
		this.method_260(1, true);
		this.method_260(3, true);
		this.method_260(4, true);
		this.method_260(5, true);
		this.method_260(6, true);
		this.method_260(7, true);
		this.method_260(8, true);
		this.method_260(9, true);
		this.method_260(2, false);
	}

	private void buttonFwSndDelAll_Click(object sender, EventArgs e)
	{
		try
		{
			for (int i = 0; i < this.dataGridViewFollowSnd.Rows.Count; i++)
			{
				GClass23 tag = (GClass23)this.dataGridViewFollowSnd[0, i].Tag;
				this.method_270(tag.string_0);
			}
			this.dataGridViewFollowSnd.Rows.Clear();
			this.method_115("删除全部跟发群发成功！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonFwSndDelAll_Click]出错：", exception.ToString()));
		}
	}

	private void buttonFwSndDelSel_Click(object sender, EventArgs e)
	{
		try
		{
			for (int i = this.dataGridViewFollowSnd.SelectedRows.Count - 1; i >= 0; i--)
			{
				GClass23 tag = (GClass23)this.dataGridViewFollowSnd.SelectedRows[i].Cells[0].Tag;
				this.method_270(tag.string_0);
				this.method_263(tag.string_0);
			}
			this.method_115("删除选中跟发群发成功！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonFwSndDelSel_Click]出错：", exception.ToString()));
		}
	}

	private void buttonGenBridge_Click(object sender, EventArgs e)
	{
		if (this.method_392(1))
		{
			(new BridgeGenForm(this.string_20)).Show();
		}
	}

	private void buttonGenTaoKouLing_Click(object sender, EventArgs e)
	{
		try
		{
			string str = this.textBoxTklUrl.Text.Trim();
			if (!str.Equals(""))
			{
				if ((str.Contains("taobao.com") ? false : !str.Contains("tmall.com")))
				{
					str = ᜤ.ᜀ(str, str);
				}
				str = HttpUtility.UrlDecode(str);
				if ((str.Contains("taobao.com") ? true : str.Contains("tmall.com")))
				{
					string str1 = "";
					if ((!str.Contains("taobao.com") ? true : !str.Contains("coupon")))
					{
						str1 = "user={user}&type=url&url={url}";
						str1 = str1.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{url}", HttpUtility.UrlEncode(str));
					}
					else
					{
						string str2 = str.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
						string str3 = ᝉ.ᜀ(str2, 0, "sellerId=", "&");
						string str4 = ᝉ.ᜀ(str2, 0, "activityId=", "&");
						str1 = "user={user}&type=coupon&coupontype={coupontype}&seller_id={seller_id}&activity_id={activity_id}";
						str1 = str1.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{coupontype}", "0").Replace("{seller_id}", str3).Replace("{activity_id}", str4);
					}
					string str5 = this.method_17(this.ᝠ_1, this.string_1, str1);
					Hashtable hashtables = this.method_206(str5);
					if (!"ng".Equals(hashtables["result"]))
					{
						string item = (string)hashtables["taokouling"];
						Clipboard.Clear();
						Clipboard.SetText(item);
						this.method_115(string.Concat("生成淘口令完成并且已经拷贝到剪切板！淘口令：【", item, "】"));
					}
					else
					{
						this.method_115(string.Concat("生成淘口令失败：", (string)hashtables["errmsg"]));
					}
				}
				else
				{
					this.method_115("要转换的URL必须是【产品链接】或者【推广链接】或者【优惠券链接】！");
				}
			}
			else
			{
				this.method_115("请输入需要转淘口令的URL！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("生成淘口令失败！", exception.ToString()));
		}
	}

	private void buttonLoadOrders_Click(object sender, EventArgs e)
	{
		this.dataGridViewAliOdr.Rows.Clear();
		DateTime value = this.dateTimePickerSchOdrStt.Value;
		this.string_24 = value.ToString("yyyy-MM-dd");
		value = this.dateTimePickerSchOdrEnd.Value;
		this.string_25 = value.ToString("yyyy-MM-dd");
		if (DateTime.Parse(this.string_24) <= DateTime.Parse(this.string_25))
		{
			this.method_102();
			this.method_109();
			this.method_103();
		}
		else
		{
			this.method_115("结束时间不能小于开始时间！");
		}
	}

	private void buttonLoadQQGrpList_Click(object sender, EventArgs e)
	{
		this.method_26();
	}

	private void buttonLoadTaokeData_Click(object sender, EventArgs e)
	{
		// 
		// Current member / type: System.Void AliBridgeForm::buttonLoadTaokeData_Click(System.Object,System.EventArgs)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void buttonLoadTaokeData_Click(System.Object,System.EventArgs)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private void buttonLoginAlimama_Click(object sender, EventArgs e)
	{
		try
		{
			if (!ᜃ.ᜋ(this.string_20))
			{
				this.bool_0 = false;
				this.method_7();
			}
			else
			{
				this.method_115("已经登录阿里妈妈！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonLoginAlimama_Click]出错：", exception.ToString()));
		}
	}

	private void buttonLoginAlimama2_Click(object sender, EventArgs e)
	{
		try
		{
			if (!ᜃ.ᜋ(this.string_20))
			{
				this.bool_0 = false;
				this.method_7();
			}
			else
			{
				this.method_115("已经登录阿里妈妈！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonLoginAlimama2_Click]出错：", exception.ToString()));
		}
	}

	private void buttonLoginQQ_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_347();
			(new QQLoginForm()).ShowDialog();
			string str = ᜈ.ᜀ("http://qun.qzone.qq.com");
			this.string_84 = ᝉ.ᜀ(str, 0, "uin=o0", ";");
			this.arrayList_21 = ᝩ.ᜁ(str);
			if (this.arrayList_21.Count != 0)
			{
				this.method_336();
			}
			else
			{
				this.method_115("加载0个QQ群，清空IE缓存以后再试一次！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonLoginQQ_Click]出错：", exception.ToString()));
		}
	}

	private void buttonMutualHotShare_Click(object sender, EventArgs e)
	{
		if (this.method_319(4))
		{
			this.int_25 = 6;
			this.method_136(this.webBrowserConvert.Document.Body.InnerText, 0);
			this.method_306();
		}
	}

	private void buttonNextPage_Click(object sender, EventArgs e)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				this.method_122();
				this.pictureBoxOnlineItemPic.Image = null;
				this.dataGridViewCmsPlan.Visible = false;
				this.method_286();
				this.dataGridViewOnlineBrdg.Rows.Clear();
				this.string_73 = this.string_73.Replace(string.Concat("toPage=", this.int_24), string.Concat("toPage=", this.int_24 + 1));
				this.int_24 = this.int_24 + 1;
				(new Thread(new ThreadStart(this.method_276))).Start();
			}
			else
			{
				this.method_115("没有登录阿里妈妈！无法查询高佣金计划！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonNextPage_Click]出错：", exception.ToString()));
		}
	}

	private void buttonOdrPoiSort_Click(object sender, EventArgs e)
	{
		DateTime value = this.dateTimePickerOdrPoiSttDate.Value;
		this.string_88 = string.Concat(value.ToString("yyyy-MM-dd"), " 00:00:00");
		value = this.dateTimePickerOdrPoiEndDate.Value;
		this.string_89 = string.Concat(value.ToString("yyyy-MM-dd"), " 23:59:59");
		if ((!this.bool_37 ? true : !(DateTime.Parse(this.string_88) > DateTime.Parse(this.string_89))))
		{
			this.method_46();
			(new Thread(new ThreadStart(this.method_356))).Start();
		}
		else
		{
			this.method_115("结束时间不能小于开始时间！");
		}
	}

	private void buttonOFilter_Click(object sender, EventArgs e)
	{
		if (ᜃ.ᜋ(this.string_20))
		{
			this.method_115("开始按条件过滤所有产品！");
			this.method_275("");
		}
		else
		{
			this.method_115("没有登录阿里妈妈！无法查询高佣金计划！");
			this.bool_0 = false;
			this.method_7();
		}
	}

	private void buttonOpenAllGrp_Click(object sender, EventArgs e)
	{
		if (!this.bool_32)
		{
			(new Thread(new ThreadStart(this.method_153))).Start();
		}
		else
		{
			this.method_115("微信群不能通过快捷方式打开，请手动把微信群拖出来成为独立的窗口！");
		}
	}

	private void buttonOpenQQPlus_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			this.openFileDialog_0.Filter = "Coco文件(*.exe)|*.exe";
			this.openFileDialog_0.Title = "打开Coco文件路径";
			if (this.openFileDialog_0.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				this.method_115("没有打开机器人文件！");
			}
			else
			{
				this.textBoxQQPlusPath.Text = this.openFileDialog_0.FileName;
				if ((this.textBoxQQPlusPath.Text.EndsWith("QQPlus.exe") ? false : !this.textBoxQQPlusPath.Text.EndsWith("Coco.exe")))
				{
					this.method_115("打开机器人文件错误！");
				}
				else
				{
					string str = this.textBoxQQPlusPath.Text.Substring(0, this.textBoxQQPlusPath.Text.LastIndexOf("\\"));
					string str1 = string.Concat(str, "\\config\\QQ群智能机器人.mdb");
					if (!File.Exists(str1))
					{
						try
						{
							this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/QQ群智能机器人.mdb"), str1);
							this.method_115("打开机器人文件路径成功！");
						}
						catch
						{
							this.method_115("打开机器人文件路径成功，但是数据库不存在！");
						}
					}
					else
					{
						this.method_115("打开机器人文件路径成功！");
					}
					᝚.ᜁ(string.Concat(str, "\\config\\千语主程序路径.txt"), string.Concat(this.string_41, "\\千语淘客助手.exe"));
					this.method_122();
				}
			}
		}
	}

	private void buttonOpenShortCutFolder_Click(object sender, EventArgs e)
	{
		Process.Start(this.string_51);
	}

	private void buttonOpenUUHP_Click(object sender, EventArgs e)
	{
		Process.Start("http://dama2.com/");
	}

	private void buttonOSchItemId_Click(object sender, EventArgs e)
	{
		if (ᜃ.ᜋ(this.string_20))
		{
			this.method_271();
		}
		else
		{
			this.method_115("没有登录阿里妈妈！无法查询高佣金计划！");
			this.bool_0 = false;
			this.method_7();
		}
	}

	private void buttonOSchKey_Click(object sender, EventArgs e)
	{
		if (ᜃ.ᜋ(this.string_20))
		{
			this.method_274();
		}
		else
		{
			this.method_115("没有登录阿里妈妈！无法查询高佣金计划！");
			this.bool_0 = false;
			this.method_7();
		}
	}

	private void buttonPause_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_154(1, true, "恢复");
			this.method_154(2, false, "");
			this.method_154(3, true, "");
			this.thread_1.Suspend();
			this.bool_19 = true;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonPause_Click]出错：", exception.ToString()));
		}
	}

	private void buttonPcToMbCoupon_Click(object sender, EventArgs e)
	{
		try
		{
			string str = this.textBoxPcCoupon.Text.Trim();
			if ((!str.Contains("coupon") ? true : !str.Contains("taobao.com")))
			{
				str = ᜤ.ᜀ(str, str);
			}
			str = HttpUtility.UrlDecode(str);
			str = str.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
			string str1 = ᝉ.ᜀ(str, 0, "sellerId=", "&");
			string str2 = ᝉ.ᜀ(str, 0, "activityId=", "&");
			string str3 = "http://shop.m.taobao.com/shop/coupon.htm?seller_id={seller_id}&activity_id={activity_id}";
			string str4 = str3.Replace("{seller_id}", str1).Replace("{activity_id}", str2);
			this.textBoxMbCoupon.Text = str4;
			string str5 = "http://taoquan.taobao.com/coupon/unify_apply.htm?sellerId={seller_id}&activityId={activity_id}&scene=taobao_shop";
			string str6 = str5.Replace("{seller_id}", str1).Replace("{activity_id}", str2);
			this.textBoxPcCoupon.Text = str6;
			᝕ _u1755 = ᜤ.ᜅ(str);
			this.method_115(string.Concat("电脑优惠券转手机优惠券完成！******", _u1755.ᜄ(), "******"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("电脑优惠券转手机优惠券失败！", exception.ToString()));
		}
	}

	private void buttonPengyouQuan_Click(object sender, EventArgs e)
	{
		if (this.checkBoxWxPromot.Checked)
		{
			this.int_25 = 4;
			this.method_306();
		}
		else
		{
			MessageBox.Show("请在【软件设置】里面选中【微信推广模式】，再生成朋友圈评价内容！");
		}
	}

	private void buttonPrePage_Click(object sender, EventArgs e)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				this.method_122();
				this.pictureBoxOnlineItemPic.Image = null;
				this.dataGridViewCmsPlan.Visible = false;
				this.method_286();
				this.dataGridViewOnlineBrdg.Rows.Clear();
				this.string_73 = this.string_73.Replace(string.Concat("toPage=", this.int_24), string.Concat("toPage=", this.int_24 - 1));
				this.int_24 = this.int_24 - 1;
				(new Thread(new ThreadStart(this.method_276))).Start();
			}
			else
			{
				this.method_115("没有登录阿里妈妈！无法查询高佣金计划！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonPrePage_Click]出错：", exception.ToString()));
		}
	}

	private void buttonRefund_Click(object sender, EventArgs e)
	{
		string[] strArrays;
		try
		{
			if (this.method_6(1))
			{
				if (this.method_350())
				{
					this.method_375(5, false);
					if ((this.textBoxRefundQQ.Text.Trim().Equals("") ? false : !this.textBoxRefundAmount.Text.Trim().Equals("")))
					{
						string str = this.textBoxRefundQQ.Text.Trim();
						string str1 = this.textBoxRefundAmount.Text.Trim();
						string text = this.textBoxRefundRemark.Text;
						ArrayList arrayLists = this.method_361(str);
						if ((arrayLists == null ? false : arrayLists.Count != 0))
						{
							ᜆ item = (ᜆ)arrayLists[0];
							if ((float)item.ᜅ >= float.Parse(str1))
							{
								GClass37 gClass37 = new GClass37()
								{
									string_0 = str,
									float_0 = float.Parse(str1),
									string_1 = DateTime.Now.ToString("yyyyMMddHHmmss"),
									string_2 = text
								};
								if (this.gclass33_0.method_30(gClass37, out this.string_23))
								{
									if (!this.gclass4_0.method_3(gClass37, out this.string_23))
									{
										this.method_115(string.Concat("积分备份出错！", this.string_23));
										return;
									}
									else
									{
										string str2 = "";
										if (item.ᜆ != 0)
										{
											strArrays = new string[] { "update qquser set refundamount=refundamount+", str1, " where qq='", str, "'" };
											str2 = string.Concat(strArrays);
										}
										else
										{
											strArrays = new string[] { "update qquser set refundamount=", str1, " where qq='", str, "'" };
											str2 = string.Concat(strArrays);
										}
										if (this.gclass33_0.method_7(str2, out this.string_23))
										{
											this.method_360();
											this.textBoxRefundQQ.Text = "";
											this.textBoxRefundAmount.Text = "";
											strArrays = new string[] { "【", str, "】返现【", str1, "】积分成功！" };
											this.method_115(string.Concat(strArrays));
											return;
										}
									}
								}
								this.method_115(string.Concat("【", str, "】返现积分失败！", this.string_23));
							}
							else
							{
								this.method_115("返现积分大于可用积分！");
							}
						}
						else
						{
							this.method_115("搜索QQ号不对！");
						}
					}
					else
					{
						this.method_115("QQ号或者返现积分不对！");
					}
				}
				else
				{
					this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonRefund_Click]", exception.ToString()));
		}
	}

	private void buttonRtnSelHotList_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_390(false);
			this.webBrowserHotShare.GoBack();
			this.webBrowserHotShare.Focus();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonRtnSelHotList_Click]出错，", exception.ToString()));
		}
	}

	private void buttonSaveConfig_Click(object sender, EventArgs e)
	{
		this.method_122();
		this.method_115("保存成功！");
	}

	private void buttonSaveToSvr_Click(object sender, EventArgs e)
	{
		this.buttonSaveToSvr.Enabled = false;
		this.buttonSaveToSvr.Text = "处理中";
		(new Thread(new ThreadStart(this.method_246))).Start();
	}

	private void buttonSch_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				this.bool_37 = this.checkBoxOdrDate.Checked;
				DateTime value = this.dateTimePickerOdrPoiSttDate.Value;
				this.string_88 = string.Concat(value.ToString("yyyy-MM-dd"), " 00:00:00");
				value = this.dateTimePickerOdrPoiEndDate.Value;
				this.string_89 = string.Concat(value.ToString("yyyy-MM-dd"), " 23:59:59");
				if ((!this.bool_37 ? true : !(DateTime.Parse(this.string_88) > DateTime.Parse(this.string_89))))
				{
					this.method_45();
					(new Thread(new ThreadStart(this.method_354))).Start();
				}
				else
				{
					this.method_115("结束时间不能小于开始时间！");
				}
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonSchAliOdr_Click(object sender, EventArgs e)
	{
		try
		{
			this.dataGridViewAliOdr.Rows.Clear();
			if (!this.textBoxOrderSch.Text.Trim().Equals(""))
			{
				this.method_102();
				string str = string.Concat("select * from aliorder where taobaoTradeId like '%", this.textBoxOrderSch.Text.Trim(), "' order by tbTradeCreateTime desc");
				this.arrayList_2 = this.gclass42_0.method_3(str, out this.string_23);
				if (this.arrayList_2 == null)
				{
					this.method_115(string.Concat("搜索订单出错：", this.string_23));
					this.arrayList_2 = new ArrayList();
				}
				this.method_114(this.arrayList_2);
				this.method_103();
			}
			else
			{
				this.method_115("输入订单号再搜！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonSchAliOdr_Click]出错：", exception.ToString()));
			this.method_103();
		}
	}

	private void buttonSchByBrdgId_Click(object sender, EventArgs e)
	{
		this.method_68();
	}

	private void buttonSchByCms_Click(object sender, EventArgs e)
	{
		this.method_70();
	}

	private void buttonSchByItemId_Click(object sender, EventArgs e)
	{
		this.method_67();
	}

	private void buttonSchByKW_Click(object sender, EventArgs e)
	{
		this.method_69();
	}

	private void buttonSchHotShare_Click(object sender, EventArgs e)
	{
		this.method_192();
	}

	private void buttonSchLclTaokeQQ_Click(object sender, EventArgs e)
	{
		this.bool_36 = true;
		this.method_337(2);
	}

	private void buttonSchQQ_Click(object sender, EventArgs e)
	{
		// 
		// Current member / type: System.Void AliBridgeForm::buttonSchQQ_Click(System.Object,System.EventArgs)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void buttonSchQQ_Click(System.Object,System.EventArgs)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private void buttonSchQQInvite_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				this.method_351();
				this.method_349();
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonSchQQUser_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				try
				{
					this.method_374();
					this.method_375(4, false);
					this.method_375(5, false);
					(new Thread(new ThreadStart(this.method_360))).Start();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					this.method_373();
					this.method_115(string.Concat("[buttonSchQQUser_Click]", exception.ToString()));
				}
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonSchRefundHis_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				this.method_364();
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonSchUserAddPoi_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				this.method_366();
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonSchVipTry_Click(object sender, EventArgs e)
	{
		// 
		// Current member / type: System.Void AliBridgeForm::buttonSchVipTry_Click(System.Object,System.EventArgs)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void buttonSchVipTry_Click(System.Object,System.EventArgs)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private void buttonSelHotAddFollow_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_390(false);
			this.method_388((string)this.buttonSelHotAddManul.Tag);
			this.webBrowserHotShare.GoBack();
			this.webBrowserHotShare.Focus();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonSelHotAddFollow_Click]出错，", exception.ToString()));
		}
	}

	private void buttonSelHotAddManul_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_390(false);
			this.method_387((string)this.buttonSelHotAddManul.Tag);
			this.webBrowserHotShare.GoBack();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonSelHotAddManul_Click]出错，", exception.ToString()));
		}
	}

	private void buttonSend_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_122();
			if (this.arrayList_4.Count == 0)
			{
				this.method_115("没有要群发的QQ群！");
			}
			else if (this.method_117())
			{
				if (this.method_119())
				{
					this.method_133();
					this.method_147(᝛.ᜀ(this.webBrowserSendContent.Document.Body.InnerHtml));
					this.method_147(᝛.ᜂ(this.webBrowserSendContent.Document.Body.InnerHtml));
					string str = this.method_307(this.webBrowserSendContent.Document.Body.InnerHtml);
					if (str != null)
					{
						this.method_147(str);
						this.string_80 = this.webBrowserSendContent.Document.Body.InnerText;
						this.string_81 = this.webBrowserSendContent.Document.Body.InnerHtml;
						if (this.string_80 == null)
						{
							this.string_80 = "";
						}
						if ((this.string_81 == null ? false : !this.string_81.Equals("")))
						{
							this.string_49 = this.webBrowserSendContent.Document.Body.InnerHtml;
							this.bool_14 = this.checkBoxFollowSend.Checked;
							this.bool_15 = this.checkBoxUpHotShare.Checked;
							this.bool_18 = this.checkBoxPreChkPid.Checked;
							this.bool_16 = this.checkBoxChkCoupon.Checked;
							try
							{
								this.int_10 = int.Parse(this.textBoxCouponLwNum.Text.Trim());
							}
							catch
							{
								this.int_10 = 10;
								this.textBoxCouponLwNum.Text = "10";
							}
							(new Thread(new ThreadStart(this.method_128))).Start();
						}
						else
						{
							this.method_134();
							this.method_115("没有要发送的内容！");
						}
					}
					else
					{
						this.method_134();
					}
				}
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_134();
			this.method_115(string.Concat("[buttonSend_Click]出错：", exception.ToString()));
		}
	}

	private void buttonSetMainAcc_Click(object sender, EventArgs e)
	{
		try
		{
			this.method_122();
			string str = this.method_17(this.ᝠ_0, this.string_93, string.Concat("softwarename=alibridge&type=setmainacc&user=", this.ᜐ_0.ᜁ, "&puser=", this.textBoxOrderMainAcc.Text.Trim()));
			if (!str.Contains("result=ok"))
			{
				this.method_115(string.Concat("设定主账号失败！", str));
			}
			else
			{
				this.method_115("设定主账号成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonSetMainAcc_Click]出错！", exception.ToString()));
		}
	}

	private void buttonSetQQGroup_Click(object sender, EventArgs e)
	{
		if (this.method_6(1))
		{
			if (this.method_350())
			{
				SetQQGroupForm setQQGroupForm = new SetQQGroupForm(this.ᜐ_0.ᜁ, this.gclass33_0);
				setQQGroupForm.ShowDialog();
				this.method_351();
			}
			else
			{
				this.method_115("机器人文件不存在，无法打开QQ群数据库！在【软件设置】里面【机器人路径】点【打开】，找到【Coco.exe】");
			}
		}
	}

	private void buttonSetWxTemp_Click(object sender, EventArgs e)
	{
		(new TemplateForm()).ShowDialog();
		this.method_0();
	}

	private void buttonShareHotShare_Click(object sender, EventArgs e)
	{
		if (this.method_319(3))
		{
			this.int_25 = 5;
			this.method_136(this.webBrowserConvert.Document.Body.InnerText, 0);
			this.method_306();
		}
	}

	private void buttonShortUrl_Click(object sender, EventArgs e)
	{
		try
		{
			string str = this.method_204(this.textBoxOrgUrl.Text.Trim());
			if (!"error".Equals(str))
			{
				this.textBoxShortUrl.Text = str;
				this.method_115("转换短网址成功！");
			}
			else
			{
				this.method_115("转换短网址失败！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonShortUrl_Click]出错：", exception.ToString()));
		}
	}

	private void buttonStartTask_Click(object sender, EventArgs e)
	{
		try
		{
			this.int_12 = int.Parse(this.textBoxTaskInteval.Text.Trim());
		}
		catch
		{
			this.textBoxTaskInteval.Text = "300";
			this.int_12 = 300;
		}
		this.method_160();
	}

	private void buttonStop_Click(object sender, EventArgs e)
	{
		try
		{
			this.thread_1.Resume();
			this.thread_1.Abort();
			this.method_154(1, true, "发送");
			this.method_154(2, false, "");
			this.method_154(3, false, "");
			this.bool_19 = false;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonStop_Click]出错：", exception.ToString()));
		}
	}

	private void buttonStopTask_Click(object sender, EventArgs e)
	{
		this.bool_21 = false;
		this.method_122();
		this.method_162();
	}

	private void buttonStpFollowSend_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.thread_3 != null)
			{
				this.thread_3.Abort();
			}
		}
		catch
		{
		}
		try
		{
			if (this.thread_5 != null)
			{
				this.thread_5.Abort();
			}
		}
		catch
		{
		}
		try
		{
			if (this.thread_4 != null)
			{
				this.thread_4.Abort();
			}
		}
		catch
		{
		}
		this.method_115("停止跟发内容监听！");
		this.buttonFollowSend.Text = "加载跟发内容";
		this.buttonFollowSend.Enabled = true;
		this.buttonStpFollowSend.Enabled = false;
		this.textBoxFwMainUser.Enabled = true;
		this.radioButtonSvrFollow.Enabled = true;
		this.radioButtonQQFollow.Enabled = true;
		this.radioButtonQYFollow.Enabled = true;
		this.radioButtonQYFcFollow.Enabled = true;
		this.radioButtonSelHotShare.Enabled = true;
		this.buttonLoadQQGrpList.Focus();
	}

	private void buttonStt_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.method_118())
			{
				this.buttonStt.Enabled = false;
				this.buttonStt.Text = "正在采集";
				this.buttonDlByBrdgID.Enabled = false;
				this.buttonCompressDb.Enabled = false;
				this.pictureBoxWaiting.Visible = true;
				if (this.method_88())
				{
					try
					{
						this.float_0 = float.Parse(this.textBoxLowestCms.Text.Trim());
					}
					catch
					{
						this.textBoxLowestCms.Text = "30";
						this.float_0 = 30f;
					}
					(new Thread(new ThreadStart(this.method_90))).Start();
				}
				else
				{
					MessageBox.Show("原数据库类型无法满足变态的鹊桥数据，数据库正在移植，不要关闭程序，以免无法打开！");
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonStt_Click]出错：", exception.ToString()));
		}
	}

	private void buttonSynQQGrpMember_Click(object sender, EventArgs e)
	{
		this.bool_36 = this.checkBoxIsTaoke.Checked;
		this.method_337(1);
	}

	private void buttonTestCode_Click(object sender, EventArgs e)
	{
		try
		{
			if (!this.bool_12)
			{
				this.method_127();
			}
			try
			{
				this.pictureBoxTest.Image = Image.FromFile(string.Concat(this.string_41, "\\config\\captcha.jpg"));
			}
			catch (Exception exception)
			{
				this.method_115(exception.ToString());
				return;
			}
			this.method_115("正在识别验证码！");
			string str = this.ᝦ_0.ᜀ(this.pictureBoxTest.Image);
			if (!str.Equals("TIMEOUT"))
			{
				this.labelUUSts.Text = string.Concat("打码成功！验证码：[", str, "]");
				this.method_115(string.Concat("验证码识别成功，验证码：【", str, "】！"));
			}
			else
			{
				this.method_115("打码超时，正在重新打码。");
				Thread.Sleep(500);
				this.buttonTestCode_Click(sender, e);
			}
		}
		catch
		{
			this.method_115("打码出错，正在重新打。");
			Thread.Sleep(500);
			this.buttonTestCode_Click(sender, e);
		}
	}

	private void buttonUpdAliOder_Click(object sender, EventArgs e)
	{
		try
		{
			DateTime value = this.dateTimePickerDlStt.Value;
			this.string_24 = value.ToString("yyyy-MM-dd");
			value = this.dateTimePickerDlEnd.Value;
			this.string_25 = value.ToString("yyyy-MM-dd");
			if (DateTime.Parse(this.string_24) <= DateTime.Parse(this.string_25))
			{
				this.buttonUpdAliOder.Text = "正在下载";
				this.method_102();
				(new Thread(new ThreadStart(this.method_101))).Start();
				this.method_115("启动更新阿里妈妈订单线程。。。");
			}
			else
			{
				this.method_115("结束时间不能小于开始时间！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonUpdAliOder_Click]出错啦", exception.ToString()));
		}
	}

	private void buttonUUWiseLogin_Click(object sender, EventArgs e)
	{
		this.method_122();
		this.method_127();
	}

	private void buttonVipTry_Click(object sender, EventArgs e)
	{
		try
		{
			ᝠ ᝠ1 = this.ᝠ_1;
			string string85 = this.string_85;
			string[] ᜐ0 = new string[] { "user=", this.ᜐ_0.ᜁ, "&type=addvipuser&data=", this.ᜐ_0.ᜁ, "_", this.string_91 };
			string str = this.method_17(ᝠ1, string85, string.Concat(ᜐ0));
			char[] chrArray = new char[] { '&' };
			string[] strArrays = str.Split(chrArray);
			Hashtable hashtables = new Hashtable();
			string[] strArrays1 = strArrays;
			for (int i = 0; i < (int)strArrays1.Length; i++)
			{
				string str1 = strArrays1[i];
				chrArray = new char[] { '=' };
				string[] strArrays2 = str1.Split(chrArray);
				hashtables.Add(strArrays2[0], strArrays2[1]);
			}
			this.method_115((string)hashtables["msg"]);
			this.buttonVipTry.Enabled = false;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[buttonVipTry_Click]", exception.ToString()));
		}
	}

	private void checkBoxAllQQ_CheckedChanged(object sender, EventArgs e)
	{
		int i;
		try
		{
			if (this.checkBoxAllQQ.Checked)
			{
				for (i = 0; i < this.dataGridViewQQGrpMember.Rows.Count; i++)
				{
					this.dataGridViewQQGrpMember.Rows[i].Cells[0].Value = "true";
				}
			}
			else if (!this.checkBoxAllQQ.Checked)
			{
				for (i = 0; i < this.dataGridViewQQGrpMember.Rows.Count; i++)
				{
					this.dataGridViewQQGrpMember.Rows[i].Cells[0].Value = "false";
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkBoxAllQQ_CheckedChanged]出错：", exception.ToString()));
		}
	}

	private void checkBoxAllTaokeQQ_CheckedChanged(object sender, EventArgs e)
	{
		int i;
		try
		{
			if (this.checkBoxAllTaokeQQ.Checked)
			{
				for (i = 0; i < this.dataGridViewQQGrpMember.Rows.Count; i++)
				{
					if (this.dataGridViewQQGrpMember.Rows[i].Cells[3].Value.Equals("是"))
					{
						this.dataGridViewQQGrpMember.Rows[i].Cells[0].Value = "true";
					}
				}
			}
			else if (!this.checkBoxAllTaokeQQ.Checked)
			{
				for (i = 0; i < this.dataGridViewQQGrpMember.Rows.Count; i++)
				{
					if (this.dataGridViewQQGrpMember.Rows[i].Cells[3].Value.Equals("是"))
					{
						this.dataGridViewQQGrpMember.Rows[i].Cells[0].Value = "false";
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkBoxAllTaokeQQ_CheckedChanged]出错：", exception.ToString()));
		}
	}

	private void checkBoxChkAllQQGrp_CheckedChanged(object sender, EventArgs e)
	{
		int i;
		try
		{
			if (this.checkBoxChkAllQQGrp.Checked)
			{
				for (i = 0; i < this.dataGridViewQQGroup.Rows.Count; i++)
				{
					this.dataGridViewQQGroup.Rows[i].Cells[0].Value = "true";
				}
			}
			else if (!this.checkBoxChkAllQQGrp.Checked)
			{
				for (i = 0; i < this.dataGridViewQQGroup.Rows.Count; i++)
				{
					this.dataGridViewQQGroup.Rows[i].Cells[0].Value = "false";
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkBoxChkAllQQGrp_CheckedChanged]出错：", exception.ToString()));
		}
	}

	private void checkBoxCouponItem_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.checkBoxCouponItem.Checked ? false : !this.bool_38))
		{
			this.method_115("规则声明：上传至该页面的商品与优惠券信息，会被阿里妈妈官方收录并给其他推广者使用。上传者上传此类信息的，表明上传者已与商家达成一致，即商家同意官方收录且给其他推广者使用。如商家不同意，请上传者不要上传，如否导致的纠纷由上传者解决并承担责任。");
		}
	}

	private void checkBoxFollowSend_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.checkBoxFollowSend.Checked ? false : !this.method_6(1)))
		{
			MessageBox.Show("没有开通VIP权限，不能使用主帐号跟发模式！");
			this.checkBoxFollowSend.Checked = false;
		}
	}

	private void checkBoxWxPromot_CheckedChanged(object sender, EventArgs e)
	{
		this.method_305();
	}

	private void comboBoxBrdgPUnit_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			this.comboBoxBrdgPPos.Items.Clear();
			this.comboBoxBrdgPPos.Text = "";
			foreach (ᜀ _ᜀ in (ArrayList)((GClass24)this.comboBoxBrdgPUnit.SelectedItem).method_4())
			{
				GClass24 gClass24 = new GClass24();
				gClass24.method_3(_ᜀ.ᜀ);
				gClass24.method_1(_ᜀ.ᜁ);
				this.comboBoxBrdgPPos.Items.Add(gClass24);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[comboBoxBrdgPUnit_SelectedIndexChanged]出错：", exception.ToString()));
		}
	}

	private void comboBoxCmPUnit_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			this.comboBoxCmPPos.Items.Clear();
			this.comboBoxCmPPos.Text = "";
			foreach (ᜀ _ᜀ in (ArrayList)((GClass24)this.comboBoxCmPUnit.SelectedItem).method_4())
			{
				GClass24 gClass24 = new GClass24();
				gClass24.method_3(_ᜀ.ᜀ);
				gClass24.method_1(_ᜀ.ᜁ);
				this.comboBoxCmPPos.Items.Add(gClass24);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[comboBoxCmPUnit_SelectedIndexChanged]出错：", exception.ToString()));
		}
	}

	private void comboBoxPromotPsi_SelectedIndexChanged(object sender, EventArgs e)
	{
		ArrayList arrayLists = new ArrayList();
		string text = this.comboBoxPromotPsi.Text;
		if (!text.Equals("全部"))
		{
			foreach (᜴ arrayList2 in this.arrayList_2)
			{
				if (!arrayList2.ᜍ.Equals(text))
				{
					continue;
				}
				arrayLists.Add(arrayList2);
			}
		}
		else
		{
			arrayLists = this.arrayList_2;
		}
		this.method_114(arrayLists);
	}

	private void comboBoxWxPUnit_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			this.comboBoxWxPPos.Items.Clear();
			this.comboBoxWxPPos.Text = "";
			ArrayList arrayLists = (ArrayList)((GClass24)this.comboBoxWxPUnit.SelectedItem).method_4();
			foreach (ᜀ _ᜀ in arrayLists)
			{
				GClass24 gClass24 = new GClass24();
				gClass24.method_3(_ᜀ.ᜀ);
				gClass24.method_1(_ᜀ.ᜁ);
				this.comboBoxWxPPos.Items.Add(gClass24);
			}
			if (arrayLists.Count > 0)
			{
				this.comboBoxWxPPos.SelectedIndex = 0;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[comboBoxWxPUnit_SelectedIndexChanged]出错：", exception.ToString()));
		}
	}

	private void contextMenuStripHiCms_Opening(object sender, CancelEventArgs e)
	{
		try
		{
			if (this.dataGridViewCmsPlan.CurrentCell != null)
			{
				string str = this.dataGridViewCmsPlan[1, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				string str1 = this.dataGridViewCmsPlan[3, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				if ((!"未申请".Equals(str1) ? true : "通用计划".Equals(str)))
				{
					this.contextMenuStripHiCms.Items[0].Enabled = false;
				}
				else
				{
					this.contextMenuStripHiCms.Items[0].Enabled = true;
				}
				if (("已通过".Equals(str1) ? false : !"通用计划".Equals(str)))
				{
					this.contextMenuStripHiCms.Items[1].Enabled = false;
				}
				else
				{
					this.contextMenuStripHiCms.Items[1].Enabled = true;
				}
				if ((!"已通过".Equals(str1) || "通用计划".Equals(str) ? !"审核中".Equals(str1) : false))
				{
					this.contextMenuStripHiCms.Items[3].Enabled = false;
				}
				else
				{
					this.contextMenuStripHiCms.Items[3].Enabled = true;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[contextMenuStripHiCms_Opening]出错：", exception.ToString()));
		}
	}

	private void contextMenuStripOdrPoi_Opening(object sender, CancelEventArgs e)
	{
		try
		{
			if (this.dataGridViewRtnFundUser.CurrentCell == null)
			{
				e.Cancel = true;
			}
			else if (!this.dataGridViewRtnFundUser.Columns[2].HeaderText.Equals("使用积分"))
			{
				e.Cancel = true;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[contextMenuStripOdrPoi_Opening]出错：", exception.ToString()));
		}
	}

	private void dataGridViewAliOdr_DoubleClick(object sender, EventArgs e)
	{
		string str;
		try
		{
			if (this.dataGridViewAliOdr.CurrentCell != null)
			{
				int rowIndex = this.dataGridViewAliOdr.CurrentCell.RowIndex;
				if (this.dataGridViewAliOdr.CurrentCell.ColumnIndex == 1)
				{
					str = this.dataGridViewAliOdr[2, rowIndex].Value.ToString();
					Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", str));
				}
				else if (this.dataGridViewAliOdr.CurrentCell.ColumnIndex == 2)
				{
					str = this.dataGridViewAliOdr[2, rowIndex].Value.ToString();
					this.textBoxProductID.Text = str;
					this.dataGridViewAliOdr.Rows.Clear();
					this.method_109();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewAliOdr_DoubleClick]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewAutoSndTask_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewAutoSndTask.CurrentCell != null)
			{
				string string0 = ((GClass15)this.dataGridViewAutoSndTask.CurrentRow.Tag).string_0;
				GClass15 gClass15 = null;
				IEnumerator enumerator = this.arrayList_6.GetEnumerator();
				try
				{
					while (true)
					{
						if (enumerator.MoveNext())
						{
							GClass15 current = (GClass15)enumerator.Current;
							if (current.string_0.Equals(string0))
							{
								gClass15 = current;
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
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				this.method_164(gClass15);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewAutoSndTask_DoubleClick]出错：", exception.ToString()));
		}
	}

	private void dataGridViewBrdg_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		(e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0);
	}

	private void dataGridViewBrdg_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewBrdg.CurrentCell != null)
			{
				if (this.method_118())
				{
					string str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
					string str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
					if (this.method_58(str, str1))
					{
						this.method_61(str, str1);
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewBrdg_Click]出错：", exception.ToString()));
		}
	}

	private void dataGridViewBrdg_DoubleClick(object sender, EventArgs e)
	{
		string str;
		try
		{
			if (this.dataGridViewBrdg.CurrentCell != null)
			{
				if (this.dataGridViewBrdg.CurrentCell.ColumnIndex != 0)
				{
					str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
					string str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
					if (this.method_58(str, str1))
					{
						this.method_61(str, str1);
						this.method_56(1, this.dataGridViewBrdg.CurrentCell.RowIndex);
					}
					else
					{
						return;
					}
				}
				else
				{
					str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
					Process.Start(string.Concat("http://pub.alimama.com/myunion.htm?#!/promo/act/activity_detail?eventId=", str));
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewBrdg_DoubleClick]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewBrdg_KeyDown(object sender, KeyEventArgs e)
	{
		string str;
		string str1;
		try
		{
			if (e.KeyCode == Keys.Down)
			{
				if ((this.dataGridViewBrdg.CurrentCell == null ? false : this.dataGridViewBrdg.CurrentCell.RowIndex < this.dataGridViewBrdg.RowCount - 1))
				{
					str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex + 1].Value.ToString();
					str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex + 1].Value.ToString();
					if (this.method_58(str, str1))
					{
						this.method_61(str, str1);
					}
					else
					{
						return;
					}
				}
				else
				{
					return;
				}
			}
			else if (e.KeyCode == Keys.Up)
			{
				if ((this.dataGridViewBrdg.CurrentCell == null ? false : this.dataGridViewBrdg.CurrentCell.RowIndex > 0))
				{
					str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex - 1].Value.ToString();
					str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex - 1].Value.ToString();
					if (this.method_58(str, str1))
					{
						this.method_61(str, str1);
					}
					else
					{
						return;
					}
				}
				else
				{
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewBrdg_KeyDown]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewCmsPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (!(this.string_35 == null || this.string_35.Equals("") || this.string_26 == null || this.string_26.Equals("") || this.string_27 == null ? false : !this.string_27.Equals("")))
			{
				this.method_115("通用推广 - 阿里妈妈推广位设置错误，无法推广！");
			}
			else if (this.dataGridViewCmsPlan.CurrentCell != null)
			{
				string str = this.dataGridViewCmsPlan[0, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				᝘ _u1758 = this.method_245(str);
				if (this.dataGridViewCmsPlan.CurrentCell.ColumnIndex == 5)
				{
					if (!ᜃ.ᜋ(this.string_20))
					{
						this.method_115("没有登录阿里妈妈！");
						this.bool_0 = false;
						this.method_7();
						return;
					}
					else if ("推广".Equals(this.dataGridViewCmsPlan.CurrentCell.Value))
					{
						Clipboard.Clear();
						string str1 = ᜃ.ᜅ(ᜃ.ᜀ(this.string_67, this.string_27, this.string_26, this.string_20));
						try
						{
							Clipboard.SetText(str1);
							this.method_115(string.Concat("获取推广链接成功！已经复制到剪切板，可以直接粘贴！【", str1, "】"));
						}
						catch
						{
							this.method_115(string.Concat("获取推广链接成功！【", str1, "】"));
						}
						return;
					}
					else if ("退出".Equals(this.dataGridViewCmsPlan.CurrentCell.Value))
					{
						ᜃ.ᜁ(_u1758.ᜂ, this.string_20, ref this.string_23);
						this.method_115(string.Concat("【", _u1758.ᜄ, "】", this.string_23));
						this.method_240();
						return;
					}
					else if (!(this.string_36 == null ? false : !"".Equals(this.string_36)))
					{
						this.method_115("没有申请理由！在【软件设置】页面【申请高佣金理由】栏填上申请高佣金理由，点【保存】。");
						return;
					}
					else if ("申请".Equals(this.dataGridViewCmsPlan.CurrentCell.Value))
					{
						ᜃ.ᜂ(_u1758.ᜃ, _u1758.ᜇ, this.string_37, this.string_36, this.string_20, ref this.string_23);
						this.method_115(string.Concat("【", _u1758.ᜄ, "】", this.string_23));
						this.method_240();
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewCmsPlan_CellContentClick]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewCmsPlan_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0))
			{
				this.dataGridViewCmsPlan.ClearSelection();
				this.dataGridViewCmsPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				this.dataGridViewCmsPlan.CurrentCell = this.dataGridViewCmsPlan.Rows[e.RowIndex].Cells[e.ColumnIndex];
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewCmsPlan_CellMouseDown]出错：", exception.ToString()));
		}
	}

	private void dataGridViewCmsPlan_DoubleClick(object sender, EventArgs e)
	{
		this.method_244(1);
	}

	private void dataGridViewFollowSnd_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0))
		{
			this.dataGridViewFollowSnd.ClearSelection();
			this.dataGridViewFollowSnd.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
			this.dataGridViewFollowSnd.CurrentCell = this.dataGridViewFollowSnd.Rows[e.RowIndex].Cells[e.ColumnIndex];
		}
	}

	private void dataGridViewFollowSnd_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewFollowSnd.CurrentCell != null)
			{
				this.method_122();
				GClass23 tag = (GClass23)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
				(new ShowFwSndForm(tag.string_0)).ShowDialog();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewFollowSnd_DoubleClick]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewHotShare_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0))
		{
			this.dataGridViewHotShare.ClearSelection();
			this.dataGridViewHotShare.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
			this.dataGridViewHotShare.CurrentCell = this.dataGridViewHotShare.Rows[e.RowIndex].Cells[e.ColumnIndex];
			this.dataGridViewHotShare_Click(sender, e);
		}
	}

	private void dataGridViewHotShare_Click(object sender, EventArgs e)
	{
		this.method_188();
	}

	private void dataGridViewOnlineBrdg_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		(e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0);
	}

	private void dataGridViewOnlineBrdg_Click(object sender, EventArgs e)
	{
		if (this.dataGridViewOnlineBrdg.CurrentCell != null)
		{
			this.method_282(((ᜭ)this.dataGridViewOnlineBrdg.CurrentRow.Tag).ᜀ);
		}
	}

	private void dataGridViewOnlineBrdg_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewOnlineBrdg.CurrentCell != null)
			{
				if (this.dataGridViewOnlineBrdg.CurrentCell.ColumnIndex != 0)
				{
					if (this.dataGridViewOnlineBrdg.CurrentCell.ColumnIndex != 1)
					{
						string tag = ((ᜭ)this.dataGridViewOnlineBrdg.CurrentRow.Tag).ᜀ;
						this.method_282(tag);
						this.method_281(tag);
					}
					else
					{
						ᜭ _ᜭ = (ᜭ)this.dataGridViewOnlineBrdg.CurrentRow.Tag;
						this.textBoxOItemId.Text = _ᜭ.ᜀ;
						this.method_271();
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewOnlineBrdg_DoubleClick]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewOnlineBrdg_KeyDown(object sender, KeyEventArgs e)
	{
		string str;
		try
		{
			if (e.KeyCode == Keys.Down)
			{
				if ((this.dataGridViewOnlineBrdg.CurrentCell == null ? false : this.dataGridViewOnlineBrdg.CurrentCell.RowIndex < this.dataGridViewOnlineBrdg.RowCount - 1))
				{
					str = this.dataGridViewOnlineBrdg[1, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex + 1].Value.ToString();
					this.method_282(str);
				}
				else
				{
					return;
				}
			}
			else if (e.KeyCode == Keys.Up)
			{
				if ((this.dataGridViewOnlineBrdg.CurrentCell == null ? false : this.dataGridViewOnlineBrdg.CurrentCell.RowIndex > 0))
				{
					str = this.dataGridViewOnlineBrdg[1, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex - 1].Value.ToString();
					this.method_282(str);
				}
				else
				{
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewOnlineBrdg_KeyDown]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewQQGrp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex != 1 ? false : e.RowIndex >= 0))
			{
				string str = this.dataGridViewQQGrp[0, e.RowIndex].Value.ToString();
				this.method_157(str, 1);
				this.method_28();
				this.method_26();
				this.method_115("排序调整成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewQQGrp_CellMouseDown]出错：", exception.ToString()));
		}
	}

	private void dataGridViewQQGrp_Click(object sender, EventArgs e)
	{
		try
		{
			if ((this.dataGridViewQQGrp.CurrentCell == null ? false : this.dataGridViewQQGrp.CurrentCell.ColumnIndex == 1))
			{
				int rowIndex = this.dataGridViewQQGrp.CurrentCell.RowIndex;
				string str = this.dataGridViewQQGrp[0, rowIndex].Value.ToString();
				this.method_157(str, 0);
				this.method_28();
				this.method_26();
				this.method_115("排序调整成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewQQGrp_Click]出错：", exception.ToString()));
		}
	}

	private void dataGridViewQQGrpMember_Click(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewQQGrpMember.CurrentCell != null)
			{
				string str = this.dataGridViewQQGrpMember[1, this.dataGridViewQQGrpMember.CurrentCell.RowIndex].Value.ToString();
				this.string_87 = (this.dataGridViewQQGrpMember[3, this.dataGridViewQQGrpMember.CurrentCell.RowIndex].Value.ToString().Equals("是") ? "1" : "0");
				ArrayList arrayLists = this.gclass42_0.method_19(str, out this.string_23);
				this.method_345(arrayLists);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewQQGrpMember_Click]出错：", exception.ToString()));
		}
	}

	private void dataGridViewRtnFundUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0))
		{
			this.dataGridViewRtnFundUser.ClearSelection();
			this.dataGridViewRtnFundUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
			this.dataGridViewRtnFundUser.CurrentCell = this.dataGridViewRtnFundUser.Rows[e.RowIndex].Cells[e.ColumnIndex];
		}
	}

	private void dataGridViewRtnFundUser_Click(object sender, EventArgs e)
	{
		object value;
		DataGridViewCell currentCell = this.dataGridViewRtnFundUser.CurrentCell;
		if (currentCell != null && !this.dataGridViewRtnFundUser.Columns[1].HeaderText.Equals("日期"))
		{
			if (currentCell.ColumnIndex == 5)
			{
				value = this.dataGridViewRtnFundUser[currentCell.ColumnIndex, currentCell.RowIndex].Value;
				if ((value == null ? false : !value.ToString().Trim().Equals("")))
				{
					string str = value.ToString().Trim();
					try
					{
						Clipboard.SetText(str);
						this.method_115(string.Concat("支付宝账号【", str, "】已复制到剪切板！"));
					}
					catch
					{
						this.method_115(string.Concat("支付宝账号【", str, "】复制失败，请重新点击复制！"));
					}
				}
			}
			else if (currentCell.ColumnIndex != 2)
			{
				this.textBoxRefundQQ.Text = "";
				this.textBoxRefundAmount.Text = "";
				this.buttonRefund.Enabled = false;
			}
			else
			{
				value = this.dataGridViewRtnFundUser[2, currentCell.RowIndex].Value;
				if ((value == null ? false : !value.ToString().Trim().Equals("")))
				{
					try
					{
						if (float.Parse(value.ToString()) <= 0f)
						{
							this.textBoxRefundQQ.Text = this.dataGridViewRtnFundUser[0, currentCell.RowIndex].Value.ToString();
							this.textBoxRefundAmount.Text = "0";
							this.buttonRefund.Enabled = false;
						}
						else
						{
							this.textBoxRefundQQ.Text = this.dataGridViewRtnFundUser[0, currentCell.RowIndex].Value.ToString();
							this.textBoxRefundAmount.Text = value.ToString();
							this.buttonRefund.Enabled = true;
						}
					}
					catch
					{
						this.textBoxRefundQQ.Text = "";
						this.textBoxRefundAmount.Text = "";
						this.buttonRefund.Enabled = false;
					}
				}
			}
		}
	}

	private void dataGridViewRtnFundUser_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			DataGridViewCell currentCell = this.dataGridViewRtnFundUser.CurrentCell;
			if (currentCell != null)
			{
				if (currentCell.ColumnIndex == 0)
				{
					string str = this.dataGridViewRtnFundUser[currentCell.ColumnIndex, currentCell.RowIndex].Value.ToString();
					this.textBoxSchAliOdrPoi.Text = "";
					this.textBoxSchOdrPid.Text = "";
					this.textBoxOdrSchQQNum.Text = str;
					this.tabControlMain.SelectedIndex = GClass13.int_9;
					(new Thread(new ThreadStart(this.method_354))).Start();
				}
				else if (currentCell.ColumnIndex == 3)
				{
					if (("0".Equals(this.dataGridViewRtnFundUser[currentCell.ColumnIndex, currentCell.RowIndex].Value.ToString()) ? false : !this.dataGridViewRtnFundUser.Columns[3].HeaderText.Equals("备注")))
					{
						this.textBoxSchRefundHisQQ.Text = this.dataGridViewRtnFundUser[0, currentCell.RowIndex].Value.ToString();
						this.method_364();
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewRtnFundUser_DoubleClick]", exception.ToString()));
		}
	}

	private void dataGridViewTaobaoQiang_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0))
			{
				this.dataGridViewTaobaoQiang.ClearSelection();
				this.dataGridViewTaobaoQiang.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				this.dataGridViewTaobaoQiang.CurrentCell = this.dataGridViewTaobaoQiang.Rows[e.RowIndex].Cells[e.ColumnIndex];
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewTaobaoQiang_CellMouseDown]出错：", exception.ToString()));
		}
	}

	private void dataGridViewTaobaoQiang_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQiang.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQiang[0, this.dataGridViewTaobaoQiang.CurrentCell.RowIndex].Value.ToString();
				ᝰ _ᝰ = this.method_232(str);
				if (this.dataGridViewTaobaoQiang.CurrentCell.ColumnIndex == 0)
				{
					Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", _ᝰ.ᜀ, "&umpChannel=qianggou&u_channel=qianggou"));
				}
				else if (this.dataGridViewTaobaoQiang.CurrentCell.ColumnIndex == 4)
				{
					this.textBoxOItemId.Text = _ᝰ.ᜀ;
					this.tabControlMain.SelectedIndex = GClass13.int_0;
					this.method_271();
				}
				else if (this.dataGridViewTaobaoQiang.CurrentCell.ColumnIndex == 5)
				{
					this.dataGridViewCmsPlan.Visible = false;
					this.string_67 = _ᝰ.ᜀ;
					this.int_20 = 3;
					this.method_240();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewTaobaoQiang_DoubleClick]出错了！", exception.ToString()));
		}
	}

	private void dataGridViewTaobaoQing_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			if ((e.Button != System.Windows.Forms.MouseButtons.Right || e.ColumnIndex < 0 ? false : e.RowIndex >= 0))
			{
				this.dataGridViewTaobaoQing.ClearSelection();
				this.dataGridViewTaobaoQing.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				this.dataGridViewTaobaoQing.CurrentCell = this.dataGridViewTaobaoQing.Rows[e.RowIndex].Cells[e.ColumnIndex];
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewTaobaoQing_CellMouseDown]出错：", exception.ToString()));
		}
	}

	private void dataGridViewTaobaoQing_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQing.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQing[0, this.dataGridViewTaobaoQing.CurrentCell.RowIndex].Value.ToString();
				ᜥ _ᜥ = this.method_231(str);
				if (this.dataGridViewTaobaoQing.CurrentCell.ColumnIndex == 0)
				{
					Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", _ᜥ.ᜀ));
				}
				else if (this.dataGridViewTaobaoQing.CurrentCell.ColumnIndex == 2)
				{
					this.textBoxOItemId.Text = _ᜥ.ᜀ;
					this.tabControlMain.SelectedIndex = GClass13.int_0;
					this.method_271();
				}
				else if (this.dataGridViewTaobaoQing.CurrentCell.ColumnIndex == 3)
				{
					this.dataGridViewCmsPlan.Visible = false;
					this.string_67 = _ᜥ.ᜀ;
					this.int_20 = 2;
					this.method_240();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dataGridViewTaobaoQing_DoubleClick]出错了！", exception.ToString()));
		}
	}

	private void dateTimePickerDlEnd_MouseHover(object sender, EventArgs e)
	{
		this.method_23();
	}

	private void dateTimePickerDlStt_MouseHover(object sender, EventArgs e)
	{
		this.method_23();
	}

	private void dateTimePickerSchOdrEnd_MouseHover(object sender, EventArgs e)
	{
		this.method_107();
	}

	private void dateTimePickerSchOdrStt_MouseHover(object sender, EventArgs e)
	{
		this.method_107();
	}

	protected override void DefWndProc(ref Message message_0)
	{
		try
		{
			if (message_0.Msg != 1125)
			{
				base.DefWndProc(ref message_0);
			}
			else if (message_0.LParam != IntPtr.Zero)
			{
				int num = message_0.LParam.ToInt32();
				this.method_12(num, this.unicodeEncoding_0.GetString(this.unicodeEncoding_0.GetBytes(this.char_0, 0, this.int_3)));
				this.int_3 = 0;
			}
			else
			{
				this.char_0[this.int_3] = (char)((int)message_0.WParam);
				AliBridgeForm int3 = this;
				int3.int_3 = int3.int_3 + 1;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[DefWndProc]出错，", exception.ToString()));
		}
	}

	protected override void Dispose(bool disposing)
	{
		if ((!disposing ? false : this.icontainer_0 != null))
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern int EnumWindows(AliBridgeForm.GDelegate66 gdelegate66_0, IntPtr intptr_1);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern IntPtr FindWindow(string string_96, string string_97);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_1, uint uint_0, string string_96, string string_97);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern int GetClassName(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_28);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern int GetWindowRect(IntPtr intptr_1, out GStruct0 gstruct0_0);

	[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=false)]
	public static extern int GetWindowText(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_28);

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AliBridgeForm));
		this.richTextBoxSts = new RichTextBox();
		this.dataGridViewBrdg = new DataGridView();
		this.contextMenuStripBrdg = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.groupBox2 = new GroupBox();
		this.checkBoxNoNotStt = new CheckBox();
		this.checkBoxTmallOnly = new CheckBox();
		this.rdobtnOrderByPrice = new RadioButton();
		this.checkBoxSingle = new CheckBox();
		this.label7 = new Label();
		this.label8 = new Label();
		this.textBoxCMSHiP = new TextBox();
		this.textBoxCMSLowP = new TextBox();
		this.label9 = new Label();
		this.textBoxCms = new TextBox();
		this.label10 = new Label();
		this.buttonSchByCms = new Button();
		this.label6 = new Label();
		this.label5 = new Label();
		this.textBoxKWHiP = new TextBox();
		this.textBoxKWLowP = new TextBox();
		this.label4 = new Label();
		this.textBoxKeyword = new TextBox();
		this.label3 = new Label();
		this.buttonSchByKW = new Button();
		this.textBoxBrdgId = new TextBox();
		this.label2 = new Label();
		this.buttonSchByBrdgId = new Button();
		this.textBoxItemId = new TextBox();
		this.label1 = new Label();
		this.buttonSchByItemId = new Button();
		this.rdobtnOrderByQnt = new RadioButton();
		this.rdobtnOrderByCms = new RadioButton();
		this.pictureBoxItemPic = new PictureBox();
		this.checkBoxFcMnDl = new CheckBox();
		this.buttonStt = new Button();
		this.groupBox3 = new GroupBox();
		this.label42 = new Label();
		this.textBoxLowestCms = new TextBox();
		this.label41 = new Label();
		this.label12 = new Label();
		this.textBoxManulBrdgId = new TextBox();
		this.buttonDlByBrdgID = new Button();
		this.groupBox4 = new GroupBox();
		this.tabControlMain = new TabControl();
		this.tabPageOnline = new TabPage();
		this.pictureBoxOnlineItemPic = new PictureBox();
		this.buttonNextPage = new Button();
		this.buttonPrePage = new Button();
		this.groupBox25 = new GroupBox();
		this.label49 = new Label();
		this.textBoxOSoldQu = new TextBox();
		this.label54 = new Label();
		this.textBoxOLowestCms = new TextBox();
		this.checkBoxOTmallOnly = new CheckBox();
		this.label55 = new Label();
		this.textBoxOSchKey = new TextBox();
		this.textBoxOHiPrice = new TextBox();
		this.label61 = new Label();
		this.label60 = new Label();
		this.textBoxOLowPrice = new TextBox();
		this.label57 = new Label();
		this.buttonOFilter = new Button();
		this.label56 = new Label();
		this.textBoxOItemId = new TextBox();
		this.label63 = new Label();
		this.buttonOSchItemId = new Button();
		this.buttonOSchKey = new Button();
		this.dataGridViewOnlineBrdg = new DataGridView();
		this.contextMenuStripOnBrdg = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.tabPageOrder = new TabPage();
		this.groupBox26 = new GroupBox();
		this.linkLabelHelpOrderCmb = new LinkLabel();
		this.groupBox44 = new GroupBox();
		this.buttonCoSubOrder = new Button();
		this.groupBox43 = new GroupBox();
		this.buttonSetMainAcc = new Button();
		this.textBoxOrderMainAcc = new TextBox();
		this.label51 = new Label();
		this.groupBox10 = new GroupBox();
		this.label48 = new Label();
		this.dateTimePickerDlEnd = new DateTimePicker();
		this.dateTimePickerDlStt = new DateTimePicker();
		this.buttonClrAliOdrDb = new Button();
		this.buttonUpdAliOder = new Button();
		this.label25 = new Label();
		this.groupBox6 = new GroupBox();
		this.textBoxProductID = new TextBox();
		this.label62 = new Label();
		this.comboBoxPromotPsi = new ComboBox();
		this.label58 = new Label();
		this.buttonDlOnlineOdr = new Button();
		this.label70 = new Label();
		this.buttonBatch = new Button();
		this.dateTimePickerSchOdrStt = new DateTimePicker();
		this.dateTimePickerSchOdrEnd = new DateTimePicker();
		this.buttonSchAliOdr = new Button();
		this.label26 = new Label();
		this.comboBoxOrderSts = new ComboBox();
		this.label15 = new Label();
		this.buttonClrOdrSchCond = new Button();
		this.buttonLoadOrders = new Button();
		this.textBoxOrderSch = new TextBox();
		this.label16 = new Label();
		this.label18 = new Label();
		this.dataGridViewAliOdr = new DataGridView();
		this.tabPageAutoSend = new TabPage();
		this.tabControlSnd = new TabControl();
		this.tabPageSndManual = new TabPage();
		this.groupBox11 = new GroupBox();
		this.checkBoxUpHotShare = new CheckBox();
		this.textBoxCouponLwNum = new TextBox();
		this.label66 = new Label();
		this.checkBoxFollowSend = new CheckBox();
		this.checkBoxPreChkPid = new CheckBox();
		this.checkBoxChkCoupon = new CheckBox();
		this.webBrowserSendContent = new WebBrowser();
		this.contextMenuStripCtEdit = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.groupBox14 = new GroupBox();
		this.buttonAddToFollow = new Button();
		this.buttonClearSndConten = new Button();
		this.buttonPause = new Button();
		this.buttonSend = new Button();
		this.buttonStop = new Button();
		this.tabPageFollowSend = new TabPage();
		this.label50 = new Label();
		this.textBoxLowestFwCms = new TextBox();
		this.label105 = new Label();
		this.checkBoxQQGrpFw = new CheckBox();
		this.textBoxNotFwHour = new TextBox();
		this.label95 = new Label();
		this.checkBoxNoLnkNoFw = new CheckBox();
		this.label84 = new Label();
		this.textBoxFwCouponLwNum = new TextBox();
		this.groupBox30 = new GroupBox();
		this.linkLabelFollowHelp = new LinkLabel();
		this.radioButtonQYFcFollow = new RadioButton();
		this.radioButtonSelHotShare = new RadioButton();
		this.radioButtonQYFollow = new RadioButton();
		this.buttonStpFollowSend = new Button();
		this.textBoxFwMainUser = new TextBox();
		this.label65 = new Label();
		this.radioButtonQQFollow = new RadioButton();
		this.radioButtonSvrFollow = new RadioButton();
		this.buttonFollowSend = new Button();
		this.checkBoxChgFwSndPid = new CheckBox();
		this.label83 = new Label();
		this.buttonFwSndDelAll = new Button();
		this.buttonFwSndDelSel = new Button();
		this.label43 = new Label();
		this.textBoxFollowSndInteval = new TextBox();
		this.label64 = new Label();
		this.buttonFollowSndStop = new Button();
		this.buttonFollowSndStart = new Button();
		this.dataGridViewFollowSnd = new DataGridView();
		this.contextMenuStripFwSnd = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.groupBox17 = new GroupBox();
		this.dateTimePickerTaskStart = new DateTimePicker();
		this.label93 = new Label();
		this.label34 = new Label();
		this.textBoxTaskInteval = new TextBox();
		this.label28 = new Label();
		this.buttonDelAllTask = new Button();
		this.buttonDelTask = new Button();
		this.buttonAddTask = new Button();
		this.dataGridViewAutoSndTask = new DataGridView();
		this.buttonStartTask = new Button();
		this.buttonStopTask = new Button();
		this.groupBox16 = new GroupBox();
		this.label96 = new Label();
		this.textBoxWxPicDelay = new TextBox();
		this.label97 = new Label();
		this.checkBoxMinForm = new CheckBox();
		this.checkBoxCloseWinWhileSnded = new CheckBox();
		this.checkBoxSndAddStr = new CheckBox();
		this.textBoxSndAddStr = new TextBox();
		this.checkBoxSndAddRdm = new CheckBox();
		this.checkBoxSndAddtime = new CheckBox();
		this.radioButtonSndCtrlEnter = new RadioButton();
		this.radioButtonSndEnter = new RadioButton();
		this.label32 = new Label();
		this.textBoxTmSnd = new TextBox();
		this.label33 = new Label();
		this.label30 = new Label();
		this.textBoxTmPasete = new TextBox();
		this.label31 = new Label();
		this.label29 = new Label();
		this.textBoxTmSwWindow = new TextBox();
		this.label27 = new Label();
		this.groupBox15 = new GroupBox();
		this.linkLabelLnkHelp = new LinkLabel();
		this.textBoxWxGrpName = new TextBox();
		this.label92 = new Label();
		this.buttonAddWxGrp = new Button();
		this.buttonOpenShortCutFolder = new Button();
		this.buttonOpenAllGrp = new Button();
		this.buttonLoadQQGrpList = new Button();
		this.dataGridViewQQGrp = new DataGridView();
		this.tabPageHotShare = new TabPage();
		this.groupBox37 = new GroupBox();
		this.textBoxHotShareKW = new TextBox();
		this.buttonSchHotShare = new Button();
		this.label85 = new Label();
		this.label52 = new Label();
		this.dataGridViewHotShare = new DataGridView();
		this.contextMenuStripHotShare = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.tabControlHotShare = new TabControl();
		this.tabPageSelfHotshare = new TabPage();
		this.tabPageSelHotShare = new TabPage();
		this.groupBox19 = new GroupBox();
		this.buttonSelHotAddManul = new Button();
		this.buttonSelHotAddFollow = new Button();
		this.buttonRtnSelHotList = new Button();
		this.webBrowserHotShare = new WebBrowser();
		this.tabPageTools = new TabPage();
		this.groupBox39 = new GroupBox();
		this.buttonGenTaoKouLing = new Button();
		this.textBoxTklUrl = new TextBox();
		this.label90 = new Label();
		this.groupBox38 = new GroupBox();
		this.buttonDelMsgReplace = new Button();
		this.textBoxNewChar = new TextBox();
		this.dgvQQGrpMonRep = new DataGridView();
		this.buttonAddMsgReplace = new Button();
		this.label87 = new Label();
		this.textBoxOldChar = new TextBox();
		this.label86 = new Label();
		this.groupBox29 = new GroupBox();
		this.label53 = new Label();
		this.buttonMutualHotShare = new Button();
		this.buttonShareHotShare = new Button();
		this.groupBox42 = new GroupBox();
		this.linkLabelPyq = new LinkLabel();
		this.buttonCp2in1Tkl = new Button();
		this.buttonCpPromotTkl = new Button();
		this.buttonPengyouQuan = new Button();
		this.buttonCpCouponTkl = new Button();
		this.checkBoxBatchConvert = new CheckBox();
		this.checkBoxClrAfterConvert = new CheckBox();
		this.buttonChkCoupon = new Button();
		this.buttonConvertAndAddToSnd = new Button();
		this.buttonConvertClr = new Button();
		this.buttonConvert = new Button();
		this.groupBox28 = new GroupBox();
		this.webBrowserConvert = new WebBrowser();
		this.contextMenuStripUrlTrans = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.groupBox21 = new GroupBox();
		this.buttonCouponTkl = new Button();
		this.buttonCpShortCoupon = new Button();
		this.buttonCpCoupon = new Button();
		this.buttonPcToMbCoupon = new Button();
		this.textBoxMbCoupon = new TextBox();
		this.label39 = new Label();
		this.textBoxPcCoupon = new TextBox();
		this.buttonClrCoupon = new Button();
		this.label40 = new Label();
		this.groupBox20 = new GroupBox();
		this.buttonCopyShortUrl = new Button();
		this.buttonShortUrl = new Button();
		this.textBoxShortUrl = new TextBox();
		this.label38 = new Label();
		this.textBoxOrgUrl = new TextBox();
		this.buttonClrBdShort = new Button();
		this.label37 = new Label();
		this.tabPageQQGrpMng = new TabPage();
		this.groupBox33 = new GroupBox();
		this.textBoxSchQQ = new TextBox();
		this.dataGridViewSchQQGrpMember = new DataGridView();
		this.buttonSchQQ = new Button();
		this.buttonExpQQGrp = new Button();
		this.groupBox32 = new GroupBox();
		this.checkBoxIsTaoke = new CheckBox();
		this.dataGridViewQQGroup = new DataGridView();
		this.checkBoxChkAllQQGrp = new CheckBox();
		this.buttonSynQQGrpMember = new Button();
		this.buttonLoginQQ = new Button();
		this.groupBox31 = new GroupBox();
		this.buttonSchLclTaokeQQ = new Button();
		this.buttonLoadTaokeData = new Button();
		this.buttonExpAllQQ = new Button();
		this.dataGridViewQQGrpMember = new DataGridView();
		this.checkBoxAllTaokeQQ = new CheckBox();
		this.checkBoxAllQQ = new CheckBox();
		this.tabPageQQGrpInvite = new TabPage();
		this.groupBox36 = new GroupBox();
		this.textBoxVipTryQQ = new TextBox();
		this.buttonSchVipTry = new Button();
		this.label82 = new Label();
		this.buttonVipTry = new Button();
		this.groupBox34 = new GroupBox();
		this.buttonSetQQGroup = new Button();
		this.comboBoxQQGroup = new ComboBox();
		this.buttonClrQQGrpInvite = new Button();
		this.textBoxQQ = new TextBox();
		this.buttonSchQQInvite = new Button();
		this.label67 = new Label();
		this.textBoxQQInvite = new TextBox();
		this.label68 = new Label();
		this.label69 = new Label();
		this.dataGridViewQQGrpInvite = new DataGridView();
		this.tabPageOdrPoi = new TabPage();
		this.groupBox35 = new GroupBox();
		this.buttonOdrPoiSort = new Button();
		this.label104 = new Label();
		this.checkBoxOdrDate = new CheckBox();
		this.dateTimePickerOdrPoiEndDate = new DateTimePicker();
		this.label102 = new Label();
		this.dateTimePickerOdrPoiSttDate = new DateTimePicker();
		this.label103 = new Label();
		this.buttonClrOdrPoi = new Button();
		this.textBoxSchOdrPid = new TextBox();
		this.buttonSch = new Button();
		this.textBoxSchAliOdrPoi = new TextBox();
		this.label78 = new Label();
		this.textBoxOdrSchQQNum = new TextBox();
		this.label79 = new Label();
		this.label80 = new Label();
		this.dataGridViewAliOdrPoi = new DataGridView();
		this.tabPageUserMng = new TabPage();
		this.dataGridViewRtnFundUser = new DataGridView();
		this.contextMenuStripOdrPoi = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.groupBox7 = new GroupBox();
		this.buttonSchUserAddPoi = new Button();
		this.buttonAddUserPoi = new Button();
		this.textBoxRefundQQ = new TextBox();
		this.label81 = new Label();
		this.textBoxRefundRemark = new TextBox();
		this.textBoxRefundAmount = new TextBox();
		this.buttonBatchRefund = new Button();
		this.label77 = new Label();
		this.label76 = new Label();
		this.buttonRefund = new Button();
		this.textBoxSchRefundHisQQ = new TextBox();
		this.label75 = new Label();
		this.buttonSchRefundHis = new Button();
		this.buttonSchQQUser = new Button();
		this.buttonClrUser = new Button();
		this.label73 = new Label();
		this.textBoxUserSchQQ = new TextBox();
		this.label74 = new Label();
		this.tabPageSetUp = new TabPage();
		this.checkBoxAdd1212 = new CheckBox();
		this.groupBox41 = new GroupBox();
		this.checkBoxTempCInMdl = new CheckBox();
		this.checkBoxUseTemp = new CheckBox();
		this.label94 = new Label();
		this.buttonSetWxTemp = new Button();
		this.groupBox40 = new GroupBox();
		this.checkBoxWxPromot = new CheckBox();
		this.linkLabelGetWeixinPromot = new LinkLabel();
		this.comboBoxWxPPos = new ComboBox();
		this.comboBoxWxPUnit = new ComboBox();
		this.label89 = new Label();
		this.label91 = new Label();
		this.groupBoxQyAdmin = new GroupBox();
		this.button1 = new Button();
		this.buttonSaveToSvr = new Button();
		this.textBoxImgZipPer = new TextBox();
		this.checkBoxLoadDataNow = new CheckBox();
		this.label88 = new Label();
		this.groupBox1 = new GroupBox();
		this.textBoxQQPlusPath = new TextBox();
		this.label71 = new Label();
		this.buttonOpenQQPlus = new Button();
		this.groupBox27 = new GroupBox();
		this.linkLabelPromotPosition = new LinkLabel();
		this.comboBoxBrdgPPos = new ComboBox();
		this.comboBoxBrdgPUnit = new ComboBox();
		this.radioButtonBrdgMOth = new RadioButton();
		this.radioButtonBrdgMApp = new RadioButton();
		this.radioButtonBrdgMWeb = new RadioButton();
		this.label14 = new Label();
		this.label59 = new Label();
		this.groupBox23 = new GroupBox();
		this.radioButton2in1Qyu = new RadioButton();
		this.checkBoxShortUrl = new CheckBox();
		this.radioButtonShBD = new RadioButton();
		this.radioButtonShXL = new RadioButton();
		this.groupBox22 = new GroupBox();
		this.checkBoxQQKouling = new CheckBox();
		this.label101 = new Label();
		this.label72 = new Label();
		this.linkLabelHelpCMSPlan = new LinkLabel();
		this.checkBoxCouponItem = new CheckBox();
		this.label100 = new Label();
		this.radioButtonHiCms = new RadioButton();
		this.radioButtonNotAudit = new RadioButton();
		this.textBoxAppCmsReson = new TextBox();
		this.label44 = new Label();
		this.groupBox18 = new GroupBox();
		this.linkLabelGetPromot = new LinkLabel();
		this.comboBoxCmPPos = new ComboBox();
		this.comboBoxCmPUnit = new ComboBox();
		this.radioButtonCmMOth = new RadioButton();
		this.radioButtonCmMApp = new RadioButton();
		this.radioButtonCmMWeb = new RadioButton();
		this.label35 = new Label();
		this.label36 = new Label();
		this.buttonSaveConfig = new Button();
		this.groupBox5 = new GroupBox();
		this.buttonLoginAlimama2 = new Button();
		this.checkBoxAutoLogin = new CheckBox();
		this.textBoxAlimamaPwd = new TextBox();
		this.textBoxAlimamaAcc = new TextBox();
		this.label11 = new Label();
		this.label13 = new Label();
		this.groupBox8 = new GroupBox();
		this.buttonOpenUUHP = new Button();
		this.pictureBoxTest = new PictureBox();
		this.buttonTestCode = new Button();
		this.labelUUSts = new Label();
		this.textBoxUUPwd = new TextBox();
		this.textBoxUUUsername = new TextBox();
		this.label20 = new Label();
		this.label21 = new Label();
		this.buttonUUWiseLogin = new Button();
		this.tabPageAmaze = new TabPage();
		this.groupBox46 = new GroupBox();
		this.checkBoxAuditCms = new CheckBox();
		this.label98 = new Label();
		this.buttonAuditBridge = new Button();
		this.textBoxAuditBridgeId = new TextBox();
		this.label106 = new Label();
		this.textBoxSoldQuantity = new TextBox();
		this.groupBox45 = new GroupBox();
		this.buttonGenBridge = new Button();
		this.tabPageBridge = new TabPage();
		this.groupBox13 = new GroupBox();
		this.buttonLoginAlimama = new Button();
		this.groupBox12 = new GroupBox();
		this.buttonCompressDb = new Button();
		this.pictureBoxWaiting = new PictureBox();
		this.groupBox9 = new GroupBox();
		this.label24 = new Label();
		this.textBoxFEarn = new TextBox();
		this.label23 = new Label();
		this.textBoxRemainDay = new TextBox();
		this.label22 = new Label();
		this.textBoxItemTitle = new TextBox();
		this.label19 = new Label();
		this.buttonCpPromotLnk = new Button();
		this.textBoxPromotLnk = new TextBox();
		this.label17 = new Label();
		this.tabPageTaoQingQiang = new TabPage();
		this.pictureBoxTQQ = new PictureBox();
		this.groupBox24 = new GroupBox();
		this.label46 = new Label();
		this.textBoxTQQLCms = new TextBox();
		this.label47 = new Label();
		this.groupBoxTaobaoQiang = new GroupBox();
		this.webBrowserTaoQiang = new WebBrowser();
		this.dataGridViewTaobaoQiang = new DataGridView();
		this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.groupBoxTaobaoQing = new GroupBox();
		this.dataGridViewCmsPlan = new DataGridView();
		this.contextMenuStripHiCms = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.dataGridViewTaobaoQing = new DataGridView();
		this.contextMenuStripTaoQing = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.buttonClrLclTQQData = new Button();
		this.richTextBoxDscTQQ = new RichTextBox();
		this.buttonDownloadTaoQing = new Button();
		this.tabPageShareHotShare = new TabPage();
		this.tabPageMutualHotShare = new TabPage();
		this.contextMenuStripTask = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.notifyIcon_0 = new NotifyIcon(this.icontainer_0);
		this.skinEngine_0 = new SkinEngine(this);
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.label45 = new Label();
		this.linkLabel1 = new LinkLabel();
		this.linkLabelGuid = new LinkLabel();
		this.openFileDialog_0 = new OpenFileDialog();
		this.linkLabelCurUserNum = new LinkLabel();
		this.saveFileDialog_0 = new SaveFileDialog();
		this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.lblVip = new Label();
		this.toolTip_0 = new ToolTip(this.icontainer_0);
		this.linkLabelHot1 = new LinkLabel();
		this.linkLabelHot2 = new LinkLabel();
		this.linkLabelVipCharge = new LinkLabel();
		this.linkLabelBridgeHelp = new LinkLabel();
		((ISupportInitialize)this.dataGridViewBrdg).BeginInit();
		this.groupBox2.SuspendLayout();
		((ISupportInitialize)this.pictureBoxItemPic).BeginInit();
		this.groupBox3.SuspendLayout();
		this.groupBox4.SuspendLayout();
		this.tabControlMain.SuspendLayout();
		this.tabPageOnline.SuspendLayout();
		((ISupportInitialize)this.pictureBoxOnlineItemPic).BeginInit();
		this.groupBox25.SuspendLayout();
		((ISupportInitialize)this.dataGridViewOnlineBrdg).BeginInit();
		this.tabPageOrder.SuspendLayout();
		this.groupBox26.SuspendLayout();
		this.groupBox44.SuspendLayout();
		this.groupBox43.SuspendLayout();
		this.groupBox10.SuspendLayout();
		this.groupBox6.SuspendLayout();
		((ISupportInitialize)this.dataGridViewAliOdr).BeginInit();
		this.tabPageAutoSend.SuspendLayout();
		this.tabControlSnd.SuspendLayout();
		this.tabPageSndManual.SuspendLayout();
		this.groupBox11.SuspendLayout();
		this.groupBox14.SuspendLayout();
		this.tabPageFollowSend.SuspendLayout();
		this.groupBox30.SuspendLayout();
		((ISupportInitialize)this.dataGridViewFollowSnd).BeginInit();
		this.groupBox17.SuspendLayout();
		((ISupportInitialize)this.dataGridViewAutoSndTask).BeginInit();
		this.groupBox16.SuspendLayout();
		this.groupBox15.SuspendLayout();
		((ISupportInitialize)this.dataGridViewQQGrp).BeginInit();
		this.tabPageHotShare.SuspendLayout();
		this.groupBox37.SuspendLayout();
		((ISupportInitialize)this.dataGridViewHotShare).BeginInit();
		this.tabControlHotShare.SuspendLayout();
		this.groupBox19.SuspendLayout();
		this.tabPageTools.SuspendLayout();
		this.groupBox39.SuspendLayout();
		this.groupBox38.SuspendLayout();
		((ISupportInitialize)this.dgvQQGrpMonRep).BeginInit();
		this.groupBox29.SuspendLayout();
		this.groupBox42.SuspendLayout();
		this.groupBox28.SuspendLayout();
		this.groupBox21.SuspendLayout();
		this.groupBox20.SuspendLayout();
		this.tabPageQQGrpMng.SuspendLayout();
		this.groupBox33.SuspendLayout();
		((ISupportInitialize)this.dataGridViewSchQQGrpMember).BeginInit();
		this.groupBox32.SuspendLayout();
		((ISupportInitialize)this.dataGridViewQQGroup).BeginInit();
		this.groupBox31.SuspendLayout();
		((ISupportInitialize)this.dataGridViewQQGrpMember).BeginInit();
		this.tabPageQQGrpInvite.SuspendLayout();
		this.groupBox36.SuspendLayout();
		this.groupBox34.SuspendLayout();
		((ISupportInitialize)this.dataGridViewQQGrpInvite).BeginInit();
		this.tabPageOdrPoi.SuspendLayout();
		this.groupBox35.SuspendLayout();
		((ISupportInitialize)this.dataGridViewAliOdrPoi).BeginInit();
		this.tabPageUserMng.SuspendLayout();
		((ISupportInitialize)this.dataGridViewRtnFundUser).BeginInit();
		this.groupBox7.SuspendLayout();
		this.tabPageSetUp.SuspendLayout();
		this.groupBox41.SuspendLayout();
		this.groupBox40.SuspendLayout();
		this.groupBoxQyAdmin.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.groupBox27.SuspendLayout();
		this.groupBox23.SuspendLayout();
		this.groupBox22.SuspendLayout();
		this.groupBox18.SuspendLayout();
		this.groupBox5.SuspendLayout();
		this.groupBox8.SuspendLayout();
		((ISupportInitialize)this.pictureBoxTest).BeginInit();
		this.tabPageAmaze.SuspendLayout();
		this.groupBox46.SuspendLayout();
		this.groupBox45.SuspendLayout();
		this.tabPageBridge.SuspendLayout();
		this.groupBox13.SuspendLayout();
		this.groupBox12.SuspendLayout();
		((ISupportInitialize)this.pictureBoxWaiting).BeginInit();
		this.groupBox9.SuspendLayout();
		this.tabPageTaoQingQiang.SuspendLayout();
		((ISupportInitialize)this.pictureBoxTQQ).BeginInit();
		this.groupBox24.SuspendLayout();
		this.groupBoxTaobaoQiang.SuspendLayout();
		((ISupportInitialize)this.dataGridViewTaobaoQiang).BeginInit();
		this.groupBoxTaobaoQing.SuspendLayout();
		((ISupportInitialize)this.dataGridViewCmsPlan).BeginInit();
		((ISupportInitialize)this.dataGridViewTaobaoQing).BeginInit();
		base.SuspendLayout();
		this.richTextBoxSts.HideSelection = false;
		this.richTextBoxSts.Location = new Point(2, 586);
		this.richTextBoxSts.Name = "richTextBoxSts";
		this.richTextBoxSts.ReadOnly = true;
		this.richTextBoxSts.Size = new System.Drawing.Size(1263, 83);
		this.richTextBoxSts.TabIndex = 2;
		this.richTextBoxSts.Text = "";
		this.richTextBoxSts.LinkClicked += new LinkClickedEventHandler(this.richTextBoxSts_LinkClicked);
		this.dataGridViewBrdg.AllowUserToAddRows = false;
		this.dataGridViewBrdg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		this.dataGridViewBrdg.ContextMenuStrip = this.contextMenuStripBrdg;
		this.dataGridViewBrdg.Location = new Point(8, 221);
		this.dataGridViewBrdg.Name = "dataGridViewBrdg";
		this.dataGridViewBrdg.RowHeadersWidth = 80;
		this.dataGridViewBrdg.RowTemplate.Height = 23;
		this.dataGridViewBrdg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewBrdg.Size = new System.Drawing.Size(1239, 304);
		this.dataGridViewBrdg.TabIndex = 5;
		this.dataGridViewBrdg.DoubleClick += new EventHandler(this.dataGridViewBrdg_DoubleClick);
		this.dataGridViewBrdg.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewBrdg_CellMouseDown);
		this.dataGridViewBrdg.KeyDown += new KeyEventHandler(this.dataGridViewBrdg_KeyDown);
		this.dataGridViewBrdg.Click += new EventHandler(this.dataGridViewBrdg_Click);
		this.contextMenuStripBrdg.Name = "contextMenuStripBrdg";
		this.contextMenuStripBrdg.Size = new System.Drawing.Size(61, 4);
		this.groupBox2.Controls.Add(this.checkBoxNoNotStt);
		this.groupBox2.Controls.Add(this.checkBoxTmallOnly);
		this.groupBox2.Controls.Add(this.rdobtnOrderByPrice);
		this.groupBox2.Controls.Add(this.checkBoxSingle);
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.label8);
		this.groupBox2.Controls.Add(this.textBoxCMSHiP);
		this.groupBox2.Controls.Add(this.textBoxCMSLowP);
		this.groupBox2.Controls.Add(this.label9);
		this.groupBox2.Controls.Add(this.textBoxCms);
		this.groupBox2.Controls.Add(this.label10);
		this.groupBox2.Controls.Add(this.buttonSchByCms);
		this.groupBox2.Controls.Add(this.label6);
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Controls.Add(this.textBoxKWHiP);
		this.groupBox2.Controls.Add(this.textBoxKWLowP);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.textBoxKeyword);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.buttonSchByKW);
		this.groupBox2.Controls.Add(this.textBoxBrdgId);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Controls.Add(this.buttonSchByBrdgId);
		this.groupBox2.Controls.Add(this.textBoxItemId);
		this.groupBox2.Controls.Add(this.label1);
		this.groupBox2.Controls.Add(this.buttonSchByItemId);
		this.groupBox2.Controls.Add(this.rdobtnOrderByQnt);
		this.groupBox2.Controls.Add(this.rdobtnOrderByCms);
		this.groupBox2.Location = new Point(320, 8);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(481, 103);
		this.groupBox2.TabIndex = 6;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "搜索排序：";
		this.checkBoxNoNotStt.AutoSize = true;
		this.checkBoxNoNotStt.Location = new Point(371, -1);
		this.checkBoxNoNotStt.Name = "checkBoxNoNotStt";
		this.checkBoxNoNotStt.Size = new System.Drawing.Size(96, 16);
		this.checkBoxNoNotStt.TabIndex = 28;
		this.checkBoxNoNotStt.Text = "不显示未开始";
		this.checkBoxNoNotStt.UseVisualStyleBackColor = true;
		this.checkBoxTmallOnly.AutoSize = true;
		this.checkBoxTmallOnly.Location = new Point(227, -1);
		this.checkBoxTmallOnly.Name = "checkBoxTmallOnly";
		this.checkBoxTmallOnly.Size = new System.Drawing.Size(72, 16);
		this.checkBoxTmallOnly.TabIndex = 27;
		this.checkBoxTmallOnly.Text = "只搜天猫";
		this.checkBoxTmallOnly.UseVisualStyleBackColor = true;
		this.rdobtnOrderByPrice.AutoSize = true;
		this.rdobtnOrderByPrice.Location = new Point(161, 0);
		this.rdobtnOrderByPrice.Name = "rdobtnOrderByPrice";
		this.rdobtnOrderByPrice.Size = new System.Drawing.Size(47, 16);
		this.rdobtnOrderByPrice.TabIndex = 26;
		this.rdobtnOrderByPrice.TabStop = true;
		this.rdobtnOrderByPrice.Text = "价格";
		this.rdobtnOrderByPrice.UseVisualStyleBackColor = true;
		this.checkBoxSingle.AutoSize = true;
		this.checkBoxSingle.Checked = true;
		this.checkBoxSingle.CheckState = CheckState.Checked;
		this.checkBoxSingle.Location = new Point(302, -1);
		this.checkBoxSingle.Name = "checkBoxSingle";
		this.checkBoxSingle.Size = new System.Drawing.Size(60, 16);
		this.checkBoxSingle.TabIndex = 25;
		this.checkBoxSingle.Text = "去重复";
		this.checkBoxSingle.UseVisualStyleBackColor = true;
		this.label7.AutoSize = true;
		this.label7.Location = new Point(400, 76);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(17, 12);
		this.label7.TabIndex = 24;
		this.label7.Text = "元";
		this.label8.AutoSize = true;
		this.label8.Location = new Point(350, 77);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(17, 12);
		this.label8.TabIndex = 23;
		this.label8.Text = "到";
		this.textBoxCMSHiP.Location = new Point(368, 73);
		this.textBoxCMSHiP.Name = "textBoxCMSHiP";
		this.textBoxCMSHiP.Size = new System.Drawing.Size(31, 21);
		this.textBoxCMSHiP.TabIndex = 22;
		this.textBoxCMSHiP.TextAlign = HorizontalAlignment.Center;
		this.textBoxCMSHiP.DoubleClick += new EventHandler(this.textBoxCMSHiP_DoubleClick);
		this.textBoxCMSHiP.KeyDown += new KeyEventHandler(this.textBoxCMSHiP_KeyDown);
		this.textBoxCMSLowP.Location = new Point(317, 73);
		this.textBoxCMSLowP.Name = "textBoxCMSLowP";
		this.textBoxCMSLowP.Size = new System.Drawing.Size(31, 21);
		this.textBoxCMSLowP.TabIndex = 20;
		this.textBoxCMSLowP.TextAlign = HorizontalAlignment.Center;
		this.textBoxCMSLowP.DoubleClick += new EventHandler(this.textBoxCMSLowP_DoubleClick);
		this.textBoxCMSLowP.KeyDown += new KeyEventHandler(this.textBoxCMSLowP_KeyDown);
		this.label9.AutoSize = true;
		this.label9.Location = new Point(282, 77);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(41, 12);
		this.label9.TabIndex = 21;
		this.label9.Text = "价格：";
		this.textBoxCms.Location = new Point(67, 72);
		this.textBoxCms.Name = "textBoxCms";
		this.textBoxCms.Size = new System.Drawing.Size(209, 21);
		this.textBoxCms.TabIndex = 17;
		this.textBoxCms.TextAlign = HorizontalAlignment.Center;
		this.textBoxCms.DoubleClick += new EventHandler(this.textBoxCms_DoubleClick);
		this.textBoxCms.KeyDown += new KeyEventHandler(this.textBoxCms_KeyDown);
		this.label10.AutoSize = true;
		this.label10.Location = new Point(6, 75);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(65, 12);
		this.label10.TabIndex = 19;
		this.label10.Text = "搜索佣金：";
		this.buttonSchByCms.Location = new Point(419, 72);
		this.buttonSchByCms.Name = "buttonSchByCms";
		this.buttonSchByCms.Size = new System.Drawing.Size(53, 23);
		this.buttonSchByCms.TabIndex = 18;
		this.buttonSchByCms.Text = "搜索";
		this.buttonSchByCms.UseVisualStyleBackColor = true;
		this.buttonSchByCms.Click += new EventHandler(this.buttonSchByCms_Click);
		this.label6.AutoSize = true;
		this.label6.Location = new Point(400, 50);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(17, 12);
		this.label6.TabIndex = 16;
		this.label6.Text = "元";
		this.label5.AutoSize = true;
		this.label5.Location = new Point(350, 51);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(17, 12);
		this.label5.TabIndex = 15;
		this.label5.Text = "到";
		this.textBoxKWHiP.Location = new Point(368, 47);
		this.textBoxKWHiP.Name = "textBoxKWHiP";
		this.textBoxKWHiP.Size = new System.Drawing.Size(31, 21);
		this.textBoxKWHiP.TabIndex = 14;
		this.textBoxKWHiP.TextAlign = HorizontalAlignment.Center;
		this.textBoxKWHiP.DoubleClick += new EventHandler(this.textBoxKWHiP_DoubleClick);
		this.textBoxKWHiP.KeyDown += new KeyEventHandler(this.textBoxKWHiP_KeyDown);
		this.textBoxKWLowP.Location = new Point(317, 47);
		this.textBoxKWLowP.Name = "textBoxKWLowP";
		this.textBoxKWLowP.Size = new System.Drawing.Size(31, 21);
		this.textBoxKWLowP.TabIndex = 12;
		this.textBoxKWLowP.TextAlign = HorizontalAlignment.Center;
		this.textBoxKWLowP.DoubleClick += new EventHandler(this.textBoxKWLowP_DoubleClick);
		this.textBoxKWLowP.KeyDown += new KeyEventHandler(this.textBoxKWLowP_KeyDown);
		this.label4.AutoSize = true;
		this.label4.Location = new Point(282, 51);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(41, 12);
		this.label4.TabIndex = 13;
		this.label4.Text = "价格：";
		this.textBoxKeyword.Location = new Point(67, 46);
		this.textBoxKeyword.Name = "textBoxKeyword";
		this.textBoxKeyword.Size = new System.Drawing.Size(209, 21);
		this.textBoxKeyword.TabIndex = 9;
		this.textBoxKeyword.TextAlign = HorizontalAlignment.Center;
		this.textBoxKeyword.DoubleClick += new EventHandler(this.textBoxKeyword_DoubleClick);
		this.textBoxKeyword.KeyDown += new KeyEventHandler(this.textBoxKeyword_KeyDown);
		this.label3.AutoSize = true;
		this.label3.Location = new Point(6, 49);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(65, 12);
		this.label3.TabIndex = 11;
		this.label3.Text = "搜关键词：";
		this.buttonSchByKW.Location = new Point(419, 46);
		this.buttonSchByKW.Name = "buttonSchByKW";
		this.buttonSchByKW.Size = new System.Drawing.Size(53, 23);
		this.buttonSchByKW.TabIndex = 10;
		this.buttonSchByKW.Text = "搜索";
		this.buttonSchByKW.UseVisualStyleBackColor = true;
		this.buttonSchByKW.Click += new EventHandler(this.buttonSchByKW_Click);
		this.textBoxBrdgId.Location = new Point(341, 18);
		this.textBoxBrdgId.Name = "textBoxBrdgId";
		this.textBoxBrdgId.Size = new System.Drawing.Size(72, 21);
		this.textBoxBrdgId.TabIndex = 6;
		this.textBoxBrdgId.TextAlign = HorizontalAlignment.Center;
		this.textBoxBrdgId.DoubleClick += new EventHandler(this.textBoxBrdgId_DoubleClick);
		this.textBoxBrdgId.KeyDown += new KeyEventHandler(this.textBoxBrdgId_KeyDown);
		this.label2.AutoSize = true;
		this.label2.Location = new Point(283, 22);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(65, 12);
		this.label2.TabIndex = 8;
		this.label2.Text = "鹊桥编号：";
		this.buttonSchByBrdgId.Location = new Point(419, 17);
		this.buttonSchByBrdgId.Name = "buttonSchByBrdgId";
		this.buttonSchByBrdgId.Size = new System.Drawing.Size(53, 23);
		this.buttonSchByBrdgId.TabIndex = 7;
		this.buttonSchByBrdgId.Text = "搜索";
		this.buttonSchByBrdgId.UseVisualStyleBackColor = true;
		this.buttonSchByBrdgId.Click += new EventHandler(this.buttonSchByBrdgId_Click);
		this.textBoxItemId.Location = new Point(67, 19);
		this.textBoxItemId.Name = "textBoxItemId";
		this.textBoxItemId.Size = new System.Drawing.Size(151, 21);
		this.textBoxItemId.TabIndex = 3;
		this.textBoxItemId.TextAlign = HorizontalAlignment.Center;
		this.textBoxItemId.DoubleClick += new EventHandler(this.textBoxItemId_DoubleClick);
		this.textBoxItemId.KeyDown += new KeyEventHandler(this.textBoxItemId_KeyDown);
		this.label1.AutoSize = true;
		this.label1.Location = new Point(6, 22);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(65, 12);
		this.label1.TabIndex = 5;
		this.label1.Text = "链接或ID：";
		this.buttonSchByItemId.Location = new Point(224, 17);
		this.buttonSchByItemId.Name = "buttonSchByItemId";
		this.buttonSchByItemId.Size = new System.Drawing.Size(53, 23);
		this.buttonSchByItemId.TabIndex = 4;
		this.buttonSchByItemId.Text = "搜索";
		this.buttonSchByItemId.UseVisualStyleBackColor = true;
		this.buttonSchByItemId.Click += new EventHandler(this.buttonSchByItemId_Click);
		this.rdobtnOrderByQnt.AutoSize = true;
		this.rdobtnOrderByQnt.Location = new Point(115, 0);
		this.rdobtnOrderByQnt.Name = "rdobtnOrderByQnt";
		this.rdobtnOrderByQnt.Size = new System.Drawing.Size(47, 16);
		this.rdobtnOrderByQnt.TabIndex = 1;
		this.rdobtnOrderByQnt.TabStop = true;
		this.rdobtnOrderByQnt.Text = "销量";
		this.rdobtnOrderByQnt.UseVisualStyleBackColor = true;
		this.rdobtnOrderByCms.AutoSize = true;
		this.rdobtnOrderByCms.Checked = true;
		this.rdobtnOrderByCms.Location = new Point(69, -1);
		this.rdobtnOrderByCms.Name = "rdobtnOrderByCms";
		this.rdobtnOrderByCms.Size = new System.Drawing.Size(47, 16);
		this.rdobtnOrderByCms.TabIndex = 0;
		this.rdobtnOrderByCms.TabStop = true;
		this.rdobtnOrderByCms.Text = "佣金";
		this.rdobtnOrderByCms.UseVisualStyleBackColor = true;
		this.pictureBoxItemPic.BorderStyle = BorderStyle.FixedSingle;
		this.pictureBoxItemPic.Location = new Point(820, 13);
		this.pictureBoxItemPic.Name = "pictureBoxItemPic";
		this.pictureBoxItemPic.Size = new System.Drawing.Size(200, 200);
		this.pictureBoxItemPic.TabIndex = 7;
		this.pictureBoxItemPic.TabStop = false;
		this.pictureBoxItemPic.MouseLeave += new EventHandler(this.pictureBoxItemPic_MouseLeave);
		this.pictureBoxItemPic.MouseHover += new EventHandler(this.pictureBoxItemPic_MouseHover);
		this.checkBoxFcMnDl.AutoSize = true;
		this.checkBoxFcMnDl.Location = new Point(75, -1);
		this.checkBoxFcMnDl.Name = "checkBoxFcMnDl";
		this.checkBoxFcMnDl.Size = new System.Drawing.Size(72, 16);
		this.checkBoxFcMnDl.TabIndex = 24;
		this.checkBoxFcMnDl.Text = "强制采集";
		this.checkBoxFcMnDl.UseVisualStyleBackColor = true;
		this.buttonStt.Enabled = false;
		this.buttonStt.Location = new Point(124, 16);
		this.buttonStt.Name = "buttonStt";
		this.buttonStt.Size = new System.Drawing.Size(75, 23);
		this.buttonStt.TabIndex = 0;
		this.buttonStt.Text = "智能采集";
		this.buttonStt.UseVisualStyleBackColor = true;
		this.buttonStt.Click += new EventHandler(this.buttonStt_Click);
		this.groupBox3.Controls.Add(this.label42);
		this.groupBox3.Controls.Add(this.textBoxLowestCms);
		this.groupBox3.Controls.Add(this.label41);
		this.groupBox3.Controls.Add(this.buttonStt);
		this.groupBox3.Location = new Point(91, 56);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(207, 46);
		this.groupBox3.TabIndex = 22;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "全自动采集";
		this.label42.AutoSize = true;
		this.label42.Location = new Point(73, 21);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(47, 12);
		this.label42.TabIndex = 34;
		this.label42.Text = "%不采集";
		this.textBoxLowestCms.Location = new Point(41, 16);
		this.textBoxLowestCms.Name = "textBoxLowestCms";
		this.textBoxLowestCms.Size = new System.Drawing.Size(29, 21);
		this.textBoxLowestCms.TabIndex = 33;
		this.textBoxLowestCms.TextAlign = HorizontalAlignment.Center;
		this.label41.AutoSize = true;
		this.label41.Location = new Point(6, 21);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(41, 12);
		this.label41.TabIndex = 33;
		this.label41.Text = "低于：";
		this.label12.AutoSize = true;
		this.label12.Location = new Point(6, 23);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(53, 12);
		this.label12.TabIndex = 21;
		this.label12.Text = "鹊桥ID：";
		this.textBoxManulBrdgId.Location = new Point(52, 20);
		this.textBoxManulBrdgId.Name = "textBoxManulBrdgId";
		this.textBoxManulBrdgId.Size = new System.Drawing.Size(66, 21);
		this.textBoxManulBrdgId.TabIndex = 8;
		this.buttonDlByBrdgID.Location = new Point(124, 20);
		this.buttonDlByBrdgID.Name = "buttonDlByBrdgID";
		this.buttonDlByBrdgID.Size = new System.Drawing.Size(75, 23);
		this.buttonDlByBrdgID.TabIndex = 24;
		this.buttonDlByBrdgID.Text = "开始采集";
		this.buttonDlByBrdgID.UseVisualStyleBackColor = true;
		this.buttonDlByBrdgID.Click += new EventHandler(this.buttonDlByBrdgID_Click);
		this.groupBox4.Controls.Add(this.buttonDlByBrdgID);
		this.groupBox4.Controls.Add(this.textBoxManulBrdgId);
		this.groupBox4.Controls.Add(this.label12);
		this.groupBox4.Controls.Add(this.checkBoxFcMnDl);
		this.groupBox4.Location = new Point(91, 108);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(207, 52);
		this.groupBox4.TabIndex = 23;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "手动采集";
		this.tabControlMain.Controls.Add(this.tabPageOnline);
		this.tabControlMain.Controls.Add(this.tabPageOrder);
		this.tabControlMain.Controls.Add(this.tabPageAutoSend);
		this.tabControlMain.Controls.Add(this.tabPageHotShare);
		this.tabControlMain.Controls.Add(this.tabPageTools);
		this.tabControlMain.Controls.Add(this.tabPageQQGrpMng);
		this.tabControlMain.Controls.Add(this.tabPageQQGrpInvite);
		this.tabControlMain.Controls.Add(this.tabPageOdrPoi);
		this.tabControlMain.Controls.Add(this.tabPageUserMng);
		this.tabControlMain.Controls.Add(this.tabPageSetUp);
		this.tabControlMain.Controls.Add(this.tabPageAmaze);
		this.tabControlMain.ItemSize = new System.Drawing.Size(60, 25);
		this.tabControlMain.Location = new Point(4, -3);
		this.tabControlMain.Name = "tabControlMain";
		this.tabControlMain.SelectedIndex = 0;
		this.tabControlMain.Size = new System.Drawing.Size(1261, 564);
		this.tabControlMain.TabIndex = 26;
		this.tabPageOnline.Controls.Add(this.pictureBoxOnlineItemPic);
		this.tabPageOnline.Controls.Add(this.buttonNextPage);
		this.tabPageOnline.Controls.Add(this.buttonPrePage);
		this.tabPageOnline.Controls.Add(this.groupBox25);
		this.tabPageOnline.Controls.Add(this.dataGridViewOnlineBrdg);
		this.tabPageOnline.Location = new Point(4, 29);
		this.tabPageOnline.Name = "tabPageOnline";
		this.tabPageOnline.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageOnline.Size = new System.Drawing.Size(1253, 531);
		this.tabPageOnline.TabIndex = 8;
		this.tabPageOnline.Text = "鹊桥在线搜索";
		this.tabPageOnline.UseVisualStyleBackColor = true;
		this.pictureBoxOnlineItemPic.BorderStyle = BorderStyle.FixedSingle;
		this.pictureBoxOnlineItemPic.Location = new Point(1086, 6);
		this.pictureBoxOnlineItemPic.Name = "pictureBoxOnlineItemPic";
		this.pictureBoxOnlineItemPic.Size = new System.Drawing.Size(160, 160);
		this.pictureBoxOnlineItemPic.TabIndex = 28;
		this.pictureBoxOnlineItemPic.TabStop = false;
		this.pictureBoxOnlineItemPic.MouseLeave += new EventHandler(this.pictureBoxOnlineItemPic_MouseLeave);
		this.pictureBoxOnlineItemPic.MouseHover += new EventHandler(this.pictureBoxOnlineItemPic_MouseHover);
		this.buttonNextPage.Enabled = false;
		this.buttonNextPage.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonNextPage.Location = new Point(616, 126);
		this.buttonNextPage.Name = "buttonNextPage";
		this.buttonNextPage.Size = new System.Drawing.Size(92, 35);
		this.buttonNextPage.TabIndex = 27;
		this.buttonNextPage.Text = "下一页";
		this.buttonNextPage.UseVisualStyleBackColor = true;
		this.buttonNextPage.Click += new EventHandler(this.buttonNextPage_Click);
		this.buttonPrePage.Enabled = false;
		this.buttonPrePage.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonPrePage.Location = new Point(464, 126);
		this.buttonPrePage.Name = "buttonPrePage";
		this.buttonPrePage.Size = new System.Drawing.Size(92, 35);
		this.buttonPrePage.TabIndex = 26;
		this.buttonPrePage.Text = "上一页";
		this.buttonPrePage.UseVisualStyleBackColor = true;
		this.buttonPrePage.Click += new EventHandler(this.buttonPrePage_Click);
		this.groupBox25.Controls.Add(this.label49);
		this.groupBox25.Controls.Add(this.textBoxOSoldQu);
		this.groupBox25.Controls.Add(this.label54);
		this.groupBox25.Controls.Add(this.textBoxOLowestCms);
		this.groupBox25.Controls.Add(this.checkBoxOTmallOnly);
		this.groupBox25.Controls.Add(this.label55);
		this.groupBox25.Controls.Add(this.textBoxOSchKey);
		this.groupBox25.Controls.Add(this.textBoxOHiPrice);
		this.groupBox25.Controls.Add(this.label61);
		this.groupBox25.Controls.Add(this.label60);
		this.groupBox25.Controls.Add(this.textBoxOLowPrice);
		this.groupBox25.Controls.Add(this.label57);
		this.groupBox25.Controls.Add(this.buttonOFilter);
		this.groupBox25.Controls.Add(this.label56);
		this.groupBox25.Controls.Add(this.textBoxOItemId);
		this.groupBox25.Controls.Add(this.label63);
		this.groupBox25.Controls.Add(this.buttonOSchItemId);
		this.groupBox25.Controls.Add(this.buttonOSchKey);
		this.groupBox25.Location = new Point(352, 6);
		this.groupBox25.Name = "groupBox25";
		this.groupBox25.Size = new System.Drawing.Size(481, 109);
		this.groupBox25.TabIndex = 25;
		this.groupBox25.TabStop = false;
		this.groupBox25.Text = "搜索条件：";
		this.label49.AutoSize = true;
		this.label49.Location = new Point(110, 22);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(11, 12);
		this.label49.TabIndex = 26;
		this.label49.Text = "%";
		this.textBoxOSoldQu.Location = new Point(187, 18);
		this.textBoxOSoldQu.Name = "textBoxOSoldQu";
		this.textBoxOSoldQu.Size = new System.Drawing.Size(42, 21);
		this.textBoxOSoldQu.TabIndex = 12;
		this.textBoxOSoldQu.TextAlign = HorizontalAlignment.Center;
		this.label54.AutoSize = true;
		this.label54.Location = new Point(367, 20);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(17, 12);
		this.label54.TabIndex = 24;
		this.label54.Text = "元";
		this.textBoxOLowestCms.Location = new Point(67, 18);
		this.textBoxOLowestCms.Name = "textBoxOLowestCms";
		this.textBoxOLowestCms.Size = new System.Drawing.Size(42, 21);
		this.textBoxOLowestCms.TabIndex = 17;
		this.textBoxOLowestCms.TextAlign = HorizontalAlignment.Center;
		this.checkBoxOTmallOnly.AutoSize = true;
		this.checkBoxOTmallOnly.Location = new Point(67, -1);
		this.checkBoxOTmallOnly.Name = "checkBoxOTmallOnly";
		this.checkBoxOTmallOnly.Size = new System.Drawing.Size(72, 16);
		this.checkBoxOTmallOnly.TabIndex = 27;
		this.checkBoxOTmallOnly.Text = "只搜天猫";
		this.checkBoxOTmallOnly.UseVisualStyleBackColor = true;
		this.label55.AutoSize = true;
		this.label55.Location = new Point(317, 21);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(17, 12);
		this.label55.TabIndex = 23;
		this.label55.Text = "到";
		this.textBoxOSchKey.Location = new Point(67, 73);
		this.textBoxOSchKey.Name = "textBoxOSchKey";
		this.textBoxOSchKey.Size = new System.Drawing.Size(325, 21);
		this.textBoxOSchKey.TabIndex = 9;
		this.textBoxOSchKey.TextAlign = HorizontalAlignment.Center;
		this.textBoxOSchKey.DoubleClick += new EventHandler(this.textBoxOSchKey_DoubleClick);
		this.textBoxOSchKey.KeyDown += new KeyEventHandler(this.textBoxOSchKey_KeyDown);
		this.textBoxOHiPrice.Location = new Point(335, 17);
		this.textBoxOHiPrice.Name = "textBoxOHiPrice";
		this.textBoxOHiPrice.Size = new System.Drawing.Size(31, 21);
		this.textBoxOHiPrice.TabIndex = 22;
		this.textBoxOHiPrice.TextAlign = HorizontalAlignment.Center;
		this.textBoxOHiPrice.DoubleClick += new EventHandler(this.textBoxOHiPrice_DoubleClick);
		this.label61.AutoSize = true;
		this.label61.Location = new Point(6, 76);
		this.label61.Name = "label61";
		this.label61.Size = new System.Drawing.Size(65, 12);
		this.label61.TabIndex = 11;
		this.label61.Text = "搜关键词：";
		this.label60.AutoSize = true;
		this.label60.Location = new Point(129, 21);
		this.label60.Name = "label60";
		this.label60.Size = new System.Drawing.Size(65, 12);
		this.label60.TabIndex = 13;
		this.label60.Text = "最低销量：";
		this.textBoxOLowPrice.Location = new Point(284, 17);
		this.textBoxOLowPrice.Name = "textBoxOLowPrice";
		this.textBoxOLowPrice.Size = new System.Drawing.Size(31, 21);
		this.textBoxOLowPrice.TabIndex = 20;
		this.textBoxOLowPrice.TextAlign = HorizontalAlignment.Center;
		this.textBoxOLowPrice.DoubleClick += new EventHandler(this.textBoxOLowPrice_DoubleClick);
		this.label57.AutoSize = true;
		this.label57.Location = new Point(6, 21);
		this.label57.Name = "label57";
		this.label57.Size = new System.Drawing.Size(65, 12);
		this.label57.TabIndex = 19;
		this.label57.Text = "最低佣金：";
		this.buttonOFilter.Location = new Point(422, 13);
		this.buttonOFilter.Name = "buttonOFilter";
		this.buttonOFilter.Size = new System.Drawing.Size(53, 23);
		this.buttonOFilter.TabIndex = 7;
		this.buttonOFilter.Text = "筛选";
		this.buttonOFilter.UseVisualStyleBackColor = true;
		this.buttonOFilter.Click += new EventHandler(this.buttonOFilter_Click);
		this.label56.AutoSize = true;
		this.label56.Location = new Point(249, 21);
		this.label56.Name = "label56";
		this.label56.Size = new System.Drawing.Size(41, 12);
		this.label56.TabIndex = 21;
		this.label56.Text = "价格：";
		this.textBoxOItemId.Location = new Point(67, 44);
		this.textBoxOItemId.Name = "textBoxOItemId";
		this.textBoxOItemId.Size = new System.Drawing.Size(325, 21);
		this.textBoxOItemId.TabIndex = 3;
		this.textBoxOItemId.TextAlign = HorizontalAlignment.Center;
		this.textBoxOItemId.DoubleClick += new EventHandler(this.textBoxOItemId_DoubleClick);
		this.textBoxOItemId.KeyDown += new KeyEventHandler(this.textBoxOItemId_KeyDown);
		this.label63.AutoSize = true;
		this.label63.Location = new Point(6, 47);
		this.label63.Name = "label63";
		this.label63.Size = new System.Drawing.Size(65, 12);
		this.label63.TabIndex = 5;
		this.label63.Text = "链接或ID：";
		this.buttonOSchItemId.Location = new Point(422, 42);
		this.buttonOSchItemId.Name = "buttonOSchItemId";
		this.buttonOSchItemId.Size = new System.Drawing.Size(53, 23);
		this.buttonOSchItemId.TabIndex = 10;
		this.buttonOSchItemId.Text = "搜索";
		this.buttonOSchItemId.UseVisualStyleBackColor = true;
		this.buttonOSchItemId.Click += new EventHandler(this.buttonOSchItemId_Click);
		this.buttonOSchKey.Location = new Point(422, 71);
		this.buttonOSchKey.Name = "buttonOSchKey";
		this.buttonOSchKey.Size = new System.Drawing.Size(53, 23);
		this.buttonOSchKey.TabIndex = 18;
		this.buttonOSchKey.Text = "搜索";
		this.buttonOSchKey.UseVisualStyleBackColor = true;
		this.buttonOSchKey.Click += new EventHandler(this.buttonOSchKey_Click);
		this.dataGridViewOnlineBrdg.AllowUserToAddRows = false;
		this.dataGridViewOnlineBrdg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		this.dataGridViewOnlineBrdg.ContextMenuStrip = this.contextMenuStripOnBrdg;
		this.dataGridViewOnlineBrdg.Location = new Point(7, 171);
		this.dataGridViewOnlineBrdg.Name = "dataGridViewOnlineBrdg";
		this.dataGridViewOnlineBrdg.RowHeadersWidth = 80;
		this.dataGridViewOnlineBrdg.RowTemplate.Height = 23;
		this.dataGridViewOnlineBrdg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewOnlineBrdg.Size = new System.Drawing.Size(1239, 353);
		this.dataGridViewOnlineBrdg.TabIndex = 6;
		this.dataGridViewOnlineBrdg.DoubleClick += new EventHandler(this.dataGridViewOnlineBrdg_DoubleClick);
		this.dataGridViewOnlineBrdg.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewOnlineBrdg_CellMouseDown);
		this.dataGridViewOnlineBrdg.KeyDown += new KeyEventHandler(this.dataGridViewOnlineBrdg_KeyDown);
		this.dataGridViewOnlineBrdg.Click += new EventHandler(this.dataGridViewOnlineBrdg_Click);
		this.contextMenuStripOnBrdg.Name = "contextMenuStripOnBrdg";
		this.contextMenuStripOnBrdg.Size = new System.Drawing.Size(61, 4);
		this.tabPageOrder.Controls.Add(this.groupBox26);
		this.tabPageOrder.Controls.Add(this.groupBox10);
		this.tabPageOrder.Controls.Add(this.groupBox6);
		this.tabPageOrder.Controls.Add(this.dataGridViewAliOdr);
		this.tabPageOrder.Location = new Point(4, 29);
		this.tabPageOrder.Name = "tabPageOrder";
		this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageOrder.Size = new System.Drawing.Size(1253, 531);
		this.tabPageOrder.TabIndex = 1;
		this.tabPageOrder.Text = "订单查询";
		this.tabPageOrder.UseVisualStyleBackColor = true;
		this.groupBox26.Controls.Add(this.linkLabelHelpOrderCmb);
		this.groupBox26.Controls.Add(this.groupBox44);
		this.groupBox26.Controls.Add(this.groupBox43);
		this.groupBox26.Location = new Point(642, 8);
		this.groupBox26.Name = "groupBox26";
		this.groupBox26.Size = new System.Drawing.Size(433, 73);
		this.groupBox26.TabIndex = 66;
		this.groupBox26.TabStop = false;
		this.groupBox26.Text = "千语帐号联动查询订单 - （没有设定千语主账号的不会上传订单）";
		this.linkLabelHelpOrderCmb.AutoSize = true;
		this.linkLabelHelpOrderCmb.Location = new Point(402, 0);
		this.linkLabelHelpOrderCmb.Name = "linkLabelHelpOrderCmb";
		this.linkLabelHelpOrderCmb.Size = new System.Drawing.Size(23, 12);
		this.linkLabelHelpOrderCmb.TabIndex = 67;
		this.linkLabelHelpOrderCmb.TabStop = true;
		this.linkLabelHelpOrderCmb.Text = "(?)";
		this.linkLabelHelpOrderCmb.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelHelpOrderCmb_LinkClicked);
		this.groupBox44.Controls.Add(this.buttonCoSubOrder);
		this.groupBox44.Location = new Point(267, 14);
		this.groupBox44.Name = "groupBox44";
		this.groupBox44.Size = new System.Drawing.Size(151, 53);
		this.groupBox44.TabIndex = 1;
		this.groupBox44.TabStop = false;
		this.groupBox44.Text = "千语主账号收集";
		this.buttonCoSubOrder.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonCoSubOrder.Location = new Point(14, 17);
		this.buttonCoSubOrder.Name = "buttonCoSubOrder";
		this.buttonCoSubOrder.Size = new System.Drawing.Size(120, 27);
		this.buttonCoSubOrder.TabIndex = 4;
		this.buttonCoSubOrder.Text = "收集子帐号订单";
		this.buttonCoSubOrder.UseVisualStyleBackColor = true;
		this.buttonCoSubOrder.Click += new EventHandler(this.buttonCoSubOrder_Click);
		this.groupBox43.Controls.Add(this.buttonSetMainAcc);
		this.groupBox43.Controls.Add(this.textBoxOrderMainAcc);
		this.groupBox43.Controls.Add(this.label51);
		this.groupBox43.Location = new Point(17, 18);
		this.groupBox43.Name = "groupBox43";
		this.groupBox43.Size = new System.Drawing.Size(240, 49);
		this.groupBox43.TabIndex = 0;
		this.groupBox43.TabStop = false;
		this.groupBox43.Text = "千语子帐号设定";
		this.buttonSetMainAcc.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSetMainAcc.Location = new Point(150, 15);
		this.buttonSetMainAcc.Name = "buttonSetMainAcc";
		this.buttonSetMainAcc.Size = new System.Drawing.Size(82, 27);
		this.buttonSetMainAcc.TabIndex = 3;
		this.buttonSetMainAcc.Text = "设定主账号";
		this.buttonSetMainAcc.UseVisualStyleBackColor = true;
		this.buttonSetMainAcc.Click += new EventHandler(this.buttonSetMainAcc_Click);
		this.textBoxOrderMainAcc.Location = new Point(59, 19);
		this.textBoxOrderMainAcc.Name = "textBoxOrderMainAcc";
		this.textBoxOrderMainAcc.Size = new System.Drawing.Size(85, 21);
		this.textBoxOrderMainAcc.TabIndex = 2;
		this.label51.AutoSize = true;
		this.label51.Location = new Point(8, 22);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(53, 12);
		this.label51.TabIndex = 1;
		this.label51.Text = "主账号：";
		this.groupBox10.Controls.Add(this.label48);
		this.groupBox10.Controls.Add(this.dateTimePickerDlEnd);
		this.groupBox10.Controls.Add(this.dateTimePickerDlStt);
		this.groupBox10.Controls.Add(this.buttonClrAliOdrDb);
		this.groupBox10.Controls.Add(this.buttonUpdAliOder);
		this.groupBox10.Controls.Add(this.label25);
		this.groupBox10.Location = new Point(157, 10);
		this.groupBox10.Name = "groupBox10";
		this.groupBox10.Size = new System.Drawing.Size(471, 71);
		this.groupBox10.TabIndex = 65;
		this.groupBox10.TabStop = false;
		this.groupBox10.Text = "更新数据";
		this.label48.AutoSize = true;
		this.label48.Location = new Point(20, 42);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(65, 12);
		this.label48.TabIndex = 71;
		this.label48.Text = "结束时间：";
		this.dateTimePickerDlEnd.Location = new Point(91, 38);
		this.dateTimePickerDlEnd.Name = "dateTimePickerDlEnd";
		this.dateTimePickerDlEnd.Size = new System.Drawing.Size(104, 21);
		this.dateTimePickerDlEnd.TabIndex = 70;
		this.dateTimePickerDlEnd.MouseHover += new EventHandler(this.dateTimePickerDlEnd_MouseHover);
		this.dateTimePickerDlStt.Location = new Point(91, 16);
		this.dateTimePickerDlStt.Name = "dateTimePickerDlStt";
		this.dateTimePickerDlStt.Size = new System.Drawing.Size(104, 21);
		this.dateTimePickerDlStt.TabIndex = 69;
		this.dateTimePickerDlStt.MouseHover += new EventHandler(this.dateTimePickerDlStt_MouseHover);
		this.buttonClrAliOdrDb.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClrAliOdrDb.Location = new Point(331, 20);
		this.buttonClrAliOdrDb.Name = "buttonClrAliOdrDb";
		this.buttonClrAliOdrDb.Size = new System.Drawing.Size(123, 36);
		this.buttonClrAliOdrDb.TabIndex = 68;
		this.buttonClrAliOdrDb.Text = "清空数据库";
		this.buttonClrAliOdrDb.UseVisualStyleBackColor = true;
		this.buttonClrAliOdrDb.Click += new EventHandler(this.buttonClrAliOdrDb_Click);
		this.buttonUpdAliOder.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonUpdAliOder.Location = new Point(214, 20);
		this.buttonUpdAliOder.Name = "buttonUpdAliOder";
		this.buttonUpdAliOder.Size = new System.Drawing.Size(105, 36);
		this.buttonUpdAliOder.TabIndex = 67;
		this.buttonUpdAliOder.Text = "下载订单";
		this.buttonUpdAliOder.UseVisualStyleBackColor = true;
		this.buttonUpdAliOder.Click += new EventHandler(this.buttonUpdAliOder_Click);
		this.label25.AutoSize = true;
		this.label25.Location = new Point(20, 21);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(65, 12);
		this.label25.TabIndex = 66;
		this.label25.Text = "开始时间：";
		this.groupBox6.Controls.Add(this.textBoxProductID);
		this.groupBox6.Controls.Add(this.label62);
		this.groupBox6.Controls.Add(this.comboBoxPromotPsi);
		this.groupBox6.Controls.Add(this.label58);
		this.groupBox6.Controls.Add(this.buttonDlOnlineOdr);
		this.groupBox6.Controls.Add(this.label70);
		this.groupBox6.Controls.Add(this.buttonBatch);
		this.groupBox6.Controls.Add(this.dateTimePickerSchOdrStt);
		this.groupBox6.Controls.Add(this.dateTimePickerSchOdrEnd);
		this.groupBox6.Controls.Add(this.buttonSchAliOdr);
		this.groupBox6.Controls.Add(this.label26);
		this.groupBox6.Controls.Add(this.comboBoxOrderSts);
		this.groupBox6.Controls.Add(this.label15);
		this.groupBox6.Controls.Add(this.buttonClrOdrSchCond);
		this.groupBox6.Controls.Add(this.buttonLoadOrders);
		this.groupBox6.Controls.Add(this.textBoxOrderSch);
		this.groupBox6.Controls.Add(this.label16);
		this.groupBox6.Controls.Add(this.label18);
		this.groupBox6.Location = new Point(157, 85);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(918, 71);
		this.groupBox6.TabIndex = 59;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "查询条件";
		this.textBoxProductID.Location = new Point(455, 14);
		this.textBoxProductID.Name = "textBoxProductID";
		this.textBoxProductID.Size = new System.Drawing.Size(105, 21);
		this.textBoxProductID.TabIndex = 54;
		this.label62.AutoSize = true;
		this.label62.Location = new Point(409, 27);
		this.label62.Name = "label62";
		this.label62.Size = new System.Drawing.Size(53, 12);
		this.label62.TabIndex = 81;
		this.label62.Text = "关键词：";
		this.comboBoxPromotPsi.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxPromotPsi.FormattingEnabled = true;
		this.comboBoxPromotPsi.Location = new Point(73, 43);
		this.comboBoxPromotPsi.Name = "comboBoxPromotPsi";
		this.comboBoxPromotPsi.Size = new System.Drawing.Size(91, 20);
		this.comboBoxPromotPsi.TabIndex = 79;
		this.comboBoxPromotPsi.SelectedIndexChanged += new EventHandler(this.comboBoxPromotPsi_SelectedIndexChanged);
		this.label58.AutoSize = true;
		this.label58.Location = new Point(25, 47);
		this.label58.Name = "label58";
		this.label58.Size = new System.Drawing.Size(53, 12);
		this.label58.TabIndex = 80;
		this.label58.Text = "推广位：";
		this.buttonDlOnlineOdr.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonDlOnlineOdr.Location = new Point(683, 22);
		this.buttonDlOnlineOdr.Name = "buttonDlOnlineOdr";
		this.buttonDlOnlineOdr.Size = new System.Drawing.Size(108, 35);
		this.buttonDlOnlineOdr.TabIndex = 78;
		this.buttonDlOnlineOdr.Text = "查当天订单";
		this.buttonDlOnlineOdr.UseVisualStyleBackColor = true;
		this.buttonDlOnlineOdr.Click += new EventHandler(this.buttonDlOnlineOdr_Click);
		this.label70.AutoSize = true;
		this.label70.Location = new Point(422, 50);
		this.label70.Name = "label70";
		this.label70.Size = new System.Drawing.Size(11, 12);
		this.label70.TabIndex = 77;
		this.label70.Text = "~";
		this.buttonBatch.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
		this.buttonBatch.Location = new Point(170, 40);
		this.buttonBatch.Name = "buttonBatch";
		this.buttonBatch.Size = new System.Drawing.Size(79, 24);
		this.buttonBatch.TabIndex = 73;
		this.buttonBatch.Text = "批量查订单";
		this.buttonBatch.UseVisualStyleBackColor = true;
		this.buttonBatch.Click += new EventHandler(this.buttonBatch_Click);
		this.dateTimePickerSchOdrStt.Location = new Point(299, 42);
		this.dateTimePickerSchOdrStt.Name = "dateTimePickerSchOdrStt";
		this.dateTimePickerSchOdrStt.Size = new System.Drawing.Size(104, 21);
		this.dateTimePickerSchOdrStt.TabIndex = 76;
		this.dateTimePickerSchOdrStt.MouseHover += new EventHandler(this.dateTimePickerSchOdrStt_MouseHover);
		this.dateTimePickerSchOdrEnd.Location = new Point(455, 42);
		this.dateTimePickerSchOdrEnd.Name = "dateTimePickerSchOdrEnd";
		this.dateTimePickerSchOdrEnd.Size = new System.Drawing.Size(104, 21);
		this.dateTimePickerSchOdrEnd.TabIndex = 75;
		this.dateTimePickerSchOdrEnd.MouseHover += new EventHandler(this.dateTimePickerSchOdrEnd_MouseHover);
		this.buttonSchAliOdr.Location = new Point(170, 14);
		this.buttonSchAliOdr.Name = "buttonSchAliOdr";
		this.buttonSchAliOdr.Size = new System.Drawing.Size(79, 23);
		this.buttonSchAliOdr.TabIndex = 74;
		this.buttonSchAliOdr.Text = "搜订单号";
		this.buttonSchAliOdr.UseVisualStyleBackColor = true;
		this.buttonSchAliOdr.Click += new EventHandler(this.buttonSchAliOdr_Click);
		this.label26.AutoSize = true;
		this.label26.Location = new Point(264, 45);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(41, 12);
		this.label26.TabIndex = 65;
		this.label26.Text = "日期：";
		this.comboBoxOrderSts.FormattingEnabled = true;
		this.comboBoxOrderSts.Location = new Point(299, 14);
		this.comboBoxOrderSts.Name = "comboBoxOrderSts";
		this.comboBoxOrderSts.Size = new System.Drawing.Size(104, 20);
		this.comboBoxOrderSts.TabIndex = 62;
		this.label15.AutoSize = true;
		this.label15.Location = new Point(264, 21);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(41, 12);
		this.label15.TabIndex = 63;
		this.label15.Text = "状态：";
		this.buttonClrOdrSchCond.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClrOdrSchCond.Location = new Point(805, 20);
		this.buttonClrOdrSchCond.Name = "buttonClrOdrSchCond";
		this.buttonClrOdrSchCond.Size = new System.Drawing.Size(86, 36);
		this.buttonClrOdrSchCond.TabIndex = 57;
		this.buttonClrOdrSchCond.Text = "清空";
		this.buttonClrOdrSchCond.UseVisualStyleBackColor = true;
		this.buttonClrOdrSchCond.Click += new EventHandler(this.buttonClrOdrSchCond_Click);
		this.buttonLoadOrders.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonLoadOrders.Location = new Point(571, 23);
		this.buttonLoadOrders.Name = "buttonLoadOrders";
		this.buttonLoadOrders.Size = new System.Drawing.Size(106, 36);
		this.buttonLoadOrders.TabIndex = 50;
		this.buttonLoadOrders.Text = "查询";
		this.buttonLoadOrders.UseVisualStyleBackColor = true;
		this.buttonLoadOrders.Click += new EventHandler(this.buttonLoadOrders_Click);
		this.textBoxOrderSch.Location = new Point(73, 16);
		this.textBoxOrderSch.Name = "textBoxOrderSch";
		this.textBoxOrderSch.Size = new System.Drawing.Size(91, 21);
		this.textBoxOrderSch.TabIndex = 52;
		this.label16.AutoSize = true;
		this.label16.Location = new Point(25, 19);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(53, 12);
		this.label16.TabIndex = 51;
		this.label16.Text = "订单号：";
		this.label18.AutoSize = true;
		this.label18.Location = new Point(409, 12);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(53, 12);
		this.label18.TabIndex = 53;
		this.label18.Text = "产品ID：";
		this.dataGridViewAliOdr.AllowUserToAddRows = false;
		this.dataGridViewAliOdr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewAliOdr.Location = new Point(3, 168);
		this.dataGridViewAliOdr.Name = "dataGridViewAliOdr";
		this.dataGridViewAliOdr.RowHeadersWidth = 60;
		this.dataGridViewAliOdr.RowTemplate.Height = 23;
		this.dataGridViewAliOdr.Size = new System.Drawing.Size(1244, 357);
		this.dataGridViewAliOdr.TabIndex = 58;
		this.dataGridViewAliOdr.DoubleClick += new EventHandler(this.dataGridViewAliOdr_DoubleClick);
		this.tabPageAutoSend.Controls.Add(this.tabControlSnd);
		this.tabPageAutoSend.Controls.Add(this.groupBox17);
		this.tabPageAutoSend.Controls.Add(this.groupBox16);
		this.tabPageAutoSend.Controls.Add(this.groupBox15);
		this.tabPageAutoSend.Location = new Point(4, 29);
		this.tabPageAutoSend.Name = "tabPageAutoSend";
		this.tabPageAutoSend.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageAutoSend.Size = new System.Drawing.Size(1253, 531);
		this.tabPageAutoSend.TabIndex = 3;
		this.tabPageAutoSend.Text = "群发助手";
		this.tabPageAutoSend.UseVisualStyleBackColor = true;
		this.tabControlSnd.Controls.Add(this.tabPageSndManual);
		this.tabControlSnd.Controls.Add(this.tabPageFollowSend);
		this.tabControlSnd.ItemSize = new System.Drawing.Size(60, 25);
		this.tabControlSnd.Location = new Point(6, 6);
		this.tabControlSnd.Name = "tabControlSnd";
		this.tabControlSnd.SelectedIndex = 0;
		this.tabControlSnd.Size = new System.Drawing.Size(734, 519);
		this.tabControlSnd.TabIndex = 9;
		this.tabPageSndManual.Controls.Add(this.groupBox11);
		this.tabPageSndManual.Controls.Add(this.groupBox14);
		this.tabPageSndManual.Location = new Point(4, 29);
		this.tabPageSndManual.Name = "tabPageSndManual";
		this.tabPageSndManual.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageSndManual.Size = new System.Drawing.Size(726, 486);
		this.tabPageSndManual.TabIndex = 0;
		this.tabPageSndManual.Text = "手动群发";
		this.tabPageSndManual.UseVisualStyleBackColor = true;
		this.groupBox11.Controls.Add(this.checkBoxUpHotShare);
		this.groupBox11.Controls.Add(this.textBoxCouponLwNum);
		this.groupBox11.Controls.Add(this.label66);
		this.groupBox11.Controls.Add(this.checkBoxFollowSend);
		this.groupBox11.Controls.Add(this.checkBoxPreChkPid);
		this.groupBox11.Controls.Add(this.checkBoxChkCoupon);
		this.groupBox11.Controls.Add(this.webBrowserSendContent);
		this.groupBox11.Location = new Point(11, 88);
		this.groupBox11.Name = "groupBox11";
		this.groupBox11.Size = new System.Drawing.Size(700, 391);
		this.groupBox11.TabIndex = 4;
		this.groupBox11.TabStop = false;
		this.groupBox11.Text = "内容编辑区(复制图片失败，用QQ截图再粘贴)";
		this.checkBoxUpHotShare.AutoSize = true;
		this.checkBoxUpHotShare.Location = new Point(535, 0);
		this.checkBoxUpHotShare.Name = "checkBoxUpHotShare";
		this.checkBoxUpHotShare.Size = new System.Drawing.Size(72, 16);
		this.checkBoxUpHotShare.TabIndex = 7;
		this.checkBoxUpHotShare.Text = "爆款分享";
		this.checkBoxUpHotShare.UseVisualStyleBackColor = false;
		this.checkBoxUpHotShare.Visible = false;
		this.textBoxCouponLwNum.Location = new Point(430, 0);
		this.textBoxCouponLwNum.Name = "textBoxCouponLwNum";
		this.textBoxCouponLwNum.Size = new System.Drawing.Size(35, 21);
		this.textBoxCouponLwNum.TabIndex = 5;
		this.label66.AutoSize = true;
		this.label66.Location = new Point(468, 0);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(41, 12);
		this.label66.TabIndex = 6;
		this.label66.Text = "张不发";
		this.checkBoxFollowSend.AutoSize = true;
		this.checkBoxFollowSend.Location = new Point(637, 0);
		this.checkBoxFollowSend.Name = "checkBoxFollowSend";
		this.checkBoxFollowSend.Size = new System.Drawing.Size(48, 16);
		this.checkBoxFollowSend.TabIndex = 3;
		this.checkBoxFollowSend.Text = "跟发";
		this.checkBoxFollowSend.UseVisualStyleBackColor = true;
		this.checkBoxFollowSend.CheckedChanged += new EventHandler(this.checkBoxFollowSend_CheckedChanged);
		this.checkBoxPreChkPid.AutoSize = true;
		this.checkBoxPreChkPid.Location = new Point(257, 0);
		this.checkBoxPreChkPid.Name = "checkBoxPreChkPid";
		this.checkBoxPreChkPid.Size = new System.Drawing.Size(78, 16);
		this.checkBoxPreChkPid.TabIndex = 2;
		this.checkBoxPreChkPid.Text = "自动转PID";
		this.checkBoxPreChkPid.UseVisualStyleBackColor = true;
		this.checkBoxChkCoupon.AutoSize = true;
		this.checkBoxChkCoupon.Location = new Point(351, -1);
		this.checkBoxChkCoupon.Name = "checkBoxChkCoupon";
		this.checkBoxChkCoupon.Size = new System.Drawing.Size(84, 16);
		this.checkBoxChkCoupon.TabIndex = 4;
		this.checkBoxChkCoupon.Text = "优惠券低于";
		this.checkBoxChkCoupon.UseVisualStyleBackColor = true;
		this.webBrowserSendContent.ContextMenuStrip = this.contextMenuStripCtEdit;
		this.webBrowserSendContent.Dock = DockStyle.Fill;
		this.webBrowserSendContent.Location = new Point(3, 17);
		this.webBrowserSendContent.MinimumSize = new System.Drawing.Size(20, 20);
		this.webBrowserSendContent.Name = "webBrowserSendContent";
		this.webBrowserSendContent.Size = new System.Drawing.Size(694, 371);
		this.webBrowserSendContent.TabIndex = 0;
		this.webBrowserSendContent.PreviewKeyDown += new PreviewKeyDownEventHandler(this.webBrowserSendContent_PreviewKeyDown);
		this.contextMenuStripCtEdit.Name = "contextMenuStripCtEdit";
		this.contextMenuStripCtEdit.Size = new System.Drawing.Size(61, 4);
		this.groupBox14.Controls.Add(this.buttonAddToFollow);
		this.groupBox14.Controls.Add(this.buttonClearSndConten);
		this.groupBox14.Controls.Add(this.buttonPause);
		this.groupBox14.Controls.Add(this.buttonSend);
		this.groupBox14.Controls.Add(this.buttonStop);
		this.groupBox14.Location = new Point(11, 7);
		this.groupBox14.Name = "groupBox14";
		this.groupBox14.Size = new System.Drawing.Size(700, 66);
		this.groupBox14.TabIndex = 5;
		this.groupBox14.TabStop = false;
		this.groupBox14.Text = "发送控制区";
		this.buttonAddToFollow.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold);
		this.buttonAddToFollow.Location = new Point(542, 20);
		this.buttonAddToFollow.Name = "buttonAddToFollow";
		this.buttonAddToFollow.Size = new System.Drawing.Size(119, 33);
		this.buttonAddToFollow.TabIndex = 4;
		this.buttonAddToFollow.Text = "添加到跟发";
		this.buttonAddToFollow.UseVisualStyleBackColor = true;
		this.buttonAddToFollow.Click += new EventHandler(this.buttonAddToFollow_Click);
		this.buttonClearSndConten.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClearSndConten.Location = new Point(36, 20);
		this.buttonClearSndConten.Name = "buttonClearSndConten";
		this.buttonClearSndConten.Size = new System.Drawing.Size(89, 33);
		this.buttonClearSndConten.TabIndex = 3;
		this.buttonClearSndConten.Text = "清空";
		this.buttonClearSndConten.UseVisualStyleBackColor = true;
		this.buttonClearSndConten.Click += new EventHandler(this.buttonClearSndConten_Click);
		this.buttonPause.Enabled = false;
		this.buttonPause.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold);
		this.buttonPause.Location = new Point(237, 20);
		this.buttonPause.Name = "buttonPause";
		this.buttonPause.Size = new System.Drawing.Size(89, 33);
		this.buttonPause.TabIndex = 1;
		this.buttonPause.Text = "暂停";
		this.buttonPause.UseVisualStyleBackColor = true;
		this.buttonPause.Click += new EventHandler(this.buttonPause_Click);
		this.buttonSend.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold);
		this.buttonSend.Location = new Point(136, 20);
		this.buttonSend.Name = "buttonSend";
		this.buttonSend.Size = new System.Drawing.Size(89, 33);
		this.buttonSend.TabIndex = 0;
		this.buttonSend.Text = "发送";
		this.buttonSend.UseVisualStyleBackColor = true;
		this.buttonSend.Click += new EventHandler(this.buttonSend_Click);
		this.buttonStop.Enabled = false;
		this.buttonStop.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonStop.Location = new Point(342, 20);
		this.buttonStop.Name = "buttonStop";
		this.buttonStop.Size = new System.Drawing.Size(176, 33);
		this.buttonStop.TabIndex = 2;
		this.buttonStop.Text = "停止(CTRL+F12)";
		this.buttonStop.UseVisualStyleBackColor = true;
		this.buttonStop.Click += new EventHandler(this.buttonStop_Click);
		this.tabPageFollowSend.Controls.Add(this.label50);
		this.tabPageFollowSend.Controls.Add(this.textBoxLowestFwCms);
		this.tabPageFollowSend.Controls.Add(this.label105);
		this.tabPageFollowSend.Controls.Add(this.checkBoxQQGrpFw);
		this.tabPageFollowSend.Controls.Add(this.textBoxNotFwHour);
		this.tabPageFollowSend.Controls.Add(this.label95);
		this.tabPageFollowSend.Controls.Add(this.checkBoxNoLnkNoFw);
		this.tabPageFollowSend.Controls.Add(this.label84);
		this.tabPageFollowSend.Controls.Add(this.textBoxFwCouponLwNum);
		this.tabPageFollowSend.Controls.Add(this.groupBox30);
		this.tabPageFollowSend.Controls.Add(this.checkBoxChgFwSndPid);
		this.tabPageFollowSend.Controls.Add(this.label83);
		this.tabPageFollowSend.Controls.Add(this.buttonFwSndDelAll);
		this.tabPageFollowSend.Controls.Add(this.buttonFwSndDelSel);
		this.tabPageFollowSend.Controls.Add(this.label43);
		this.tabPageFollowSend.Controls.Add(this.textBoxFollowSndInteval);
		this.tabPageFollowSend.Controls.Add(this.label64);
		this.tabPageFollowSend.Controls.Add(this.buttonFollowSndStop);
		this.tabPageFollowSend.Controls.Add(this.buttonFollowSndStart);
		this.tabPageFollowSend.Controls.Add(this.dataGridViewFollowSnd);
		this.tabPageFollowSend.Location = new Point(4, 29);
		this.tabPageFollowSend.Name = "tabPageFollowSend";
		this.tabPageFollowSend.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageFollowSend.Size = new System.Drawing.Size(726, 486);
		this.tabPageFollowSend.TabIndex = 2;
		this.tabPageFollowSend.Text = "自动跟发";
		this.tabPageFollowSend.UseVisualStyleBackColor = true;
		this.label50.AutoSize = true;
		this.label50.Location = new Point(579, 136);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(53, 12);
		this.label50.TabIndex = 60;
		this.label50.Text = "佣金低于";
		this.textBoxLowestFwCms.Location = new Point(632, 132);
		this.textBoxLowestFwCms.Name = "textBoxLowestFwCms";
		this.textBoxLowestFwCms.Size = new System.Drawing.Size(47, 21);
		this.textBoxLowestFwCms.TabIndex = 58;
		this.textBoxLowestFwCms.TextAlign = HorizontalAlignment.Center;
		this.label105.AutoSize = true;
		this.label105.Location = new Point(682, 136);
		this.label105.Name = "label105";
		this.label105.Size = new System.Drawing.Size(35, 12);
		this.label105.TabIndex = 59;
		this.label105.Text = "%不发";
		this.checkBoxQQGrpFw.AutoSize = true;
		this.checkBoxQQGrpFw.Location = new Point(444, 156);
		this.checkBoxQQGrpFw.Name = "checkBoxQQGrpFw";
		this.checkBoxQQGrpFw.Size = new System.Drawing.Size(132, 16);
		this.checkBoxQQGrpFw.TabIndex = 57;
		this.checkBoxQQGrpFw.Text = "机器人采集上传跟发";
		this.checkBoxQQGrpFw.UseVisualStyleBackColor = true;
		this.textBoxNotFwHour.Location = new Point(263, 119);
		this.textBoxNotFwHour.Name = "textBoxNotFwHour";
		this.textBoxNotFwHour.Size = new System.Drawing.Size(36, 21);
		this.textBoxNotFwHour.TabIndex = 55;
		this.textBoxNotFwHour.TextAlign = HorizontalAlignment.Center;
		this.textBoxNotFwHour.MouseLeave += new EventHandler(this.textBoxNotFwHour_MouseLeave);
		this.textBoxNotFwHour.MouseEnter += new EventHandler(this.textBoxNotFwHour_MouseEnter);
		this.label95.AutoSize = true;
		this.label95.Location = new Point(301, 123);
		this.label95.Name = "label95";
		this.label95.Size = new System.Drawing.Size(125, 12);
		this.label95.TabIndex = 56;
		this.label95.Text = "个小时内重复产品不发";
		this.checkBoxNoLnkNoFw.AutoSize = true;
		this.checkBoxNoLnkNoFw.Location = new Point(444, 137);
		this.checkBoxNoLnkNoFw.Name = "checkBoxNoLnkNoFw";
		this.checkBoxNoLnkNoFw.Size = new System.Drawing.Size(108, 16);
		this.checkBoxNoLnkNoFw.TabIndex = 54;
		this.checkBoxNoLnkNoFw.Text = "没有链接不跟发";
		this.checkBoxNoLnkNoFw.UseVisualStyleBackColor = true;
		this.label84.AutoSize = true;
		this.label84.Location = new Point(579, 110);
		this.label84.Name = "label84";
		this.label84.Size = new System.Drawing.Size(65, 12);
		this.label84.TabIndex = 53;
		this.label84.Text = "优惠券低于";
		this.textBoxFwCouponLwNum.Location = new Point(644, 106);
		this.textBoxFwCouponLwNum.Name = "textBoxFwCouponLwNum";
		this.textBoxFwCouponLwNum.Size = new System.Drawing.Size(35, 21);
		this.textBoxFwCouponLwNum.TabIndex = 51;
		this.textBoxFwCouponLwNum.TextAlign = HorizontalAlignment.Center;
		this.groupBox30.Controls.Add(this.linkLabelFollowHelp);
		this.groupBox30.Controls.Add(this.radioButtonQYFcFollow);
		this.groupBox30.Controls.Add(this.radioButtonSelHotShare);
		this.groupBox30.Controls.Add(this.radioButtonQYFollow);
		this.groupBox30.Controls.Add(this.buttonStpFollowSend);
		this.groupBox30.Controls.Add(this.textBoxFwMainUser);
		this.groupBox30.Controls.Add(this.label65);
		this.groupBox30.Controls.Add(this.radioButtonQQFollow);
		this.groupBox30.Controls.Add(this.radioButtonSvrFollow);
		this.groupBox30.Controls.Add(this.buttonFollowSend);
		this.groupBox30.Location = new Point(6, 6);
		this.groupBox30.Name = "groupBox30";
		this.groupBox30.Size = new System.Drawing.Size(714, 97);
		this.groupBox30.TabIndex = 49;
		this.groupBox30.TabStop = false;
		this.groupBox30.Text = "跟发模式";
		this.linkLabelFollowHelp.AutoSize = true;
		this.linkLabelFollowHelp.Location = new Point(69, 0);
		this.linkLabelFollowHelp.Name = "linkLabelFollowHelp";
		this.linkLabelFollowHelp.Size = new System.Drawing.Size(23, 12);
		this.linkLabelFollowHelp.TabIndex = 70;
		this.linkLabelFollowHelp.TabStop = true;
		this.linkLabelFollowHelp.Text = "(?)";
		this.linkLabelFollowHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelFollowHelp_LinkClicked);
		this.radioButtonQYFcFollow.AutoSize = true;
		this.radioButtonQYFcFollow.Location = new Point(577, 54);
		this.radioButtonQYFcFollow.Name = "radioButtonQYFcFollow";
		this.radioButtonQYFcFollow.Size = new System.Drawing.Size(131, 16);
		this.radioButtonQYFcFollow.TabIndex = 50;
		this.radioButtonQYFcFollow.TabStop = true;
		this.radioButtonQYFcFollow.Text = "跟发千语官方暴力版";
		this.radioButtonQYFcFollow.UseVisualStyleBackColor = true;
		this.radioButtonSelHotShare.AutoSize = true;
		this.radioButtonSelHotShare.Location = new Point(241, 75);
		this.radioButtonSelHotShare.Name = "radioButtonSelHotShare";
		this.radioButtonSelHotShare.Size = new System.Drawing.Size(269, 16);
		this.radioButtonSelHotShare.TabIndex = 49;
		this.radioButtonSelHotShare.TabStop = true;
		this.radioButtonSelHotShare.Text = "只加载内容(免费，爆款分享添加到这里使用))";
		this.radioButtonSelHotShare.UseVisualStyleBackColor = true;
		this.radioButtonQYFollow.AutoSize = true;
		this.radioButtonQYFollow.Location = new Point(241, 54);
		this.radioButtonQYFollow.Name = "radioButtonQYFollow";
		this.radioButtonQYFollow.Size = new System.Drawing.Size(335, 16);
		this.radioButtonQYFollow.TabIndex = 48;
		this.radioButtonQYFollow.TabStop = true;
		this.radioButtonQYFollow.Text = "跟发千语官方群发内容(免费，记得勾选下面的自动换PID))";
		this.radioButtonQYFollow.UseVisualStyleBackColor = true;
		this.buttonStpFollowSend.Enabled = false;
		this.buttonStpFollowSend.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonStpFollowSend.Location = new Point(139, 35);
		this.buttonStpFollowSend.Name = "buttonStpFollowSend";
		this.buttonStpFollowSend.Size = new System.Drawing.Size(91, 36);
		this.buttonStpFollowSend.TabIndex = 47;
		this.buttonStpFollowSend.Text = "停止跟发";
		this.buttonStpFollowSend.UseVisualStyleBackColor = true;
		this.buttonStpFollowSend.Click += new EventHandler(this.buttonStpFollowSend_Click);
		this.textBoxFwMainUser.Location = new Point(632, 13);
		this.textBoxFwMainUser.Name = "textBoxFwMainUser";
		this.textBoxFwMainUser.Size = new System.Drawing.Size(73, 21);
		this.textBoxFwMainUser.TabIndex = 43;
		this.label65.AutoSize = true;
		this.label65.Location = new Point(547, 17);
		this.label65.Name = "label65";
		this.label65.Size = new System.Drawing.Size(89, 12);
		this.label65.TabIndex = 42;
		this.label65.Text = "主帐号用户名：";
		this.radioButtonQQFollow.AutoSize = true;
		this.radioButtonQQFollow.Location = new Point(241, 35);
		this.radioButtonQQFollow.Name = "radioButtonQQFollow";
		this.radioButtonQQFollow.Size = new System.Drawing.Size(377, 16);
		this.radioButtonQQFollow.TabIndex = 41;
		this.radioButtonQQFollow.TabStop = true;
		this.radioButtonQQFollow.Text = "QQ群跟发(机器人采集跟发，在【软件设置】页面配置机器人路径))";
		this.radioButtonQQFollow.UseVisualStyleBackColor = true;
		this.radioButtonSvrFollow.AutoSize = true;
		this.radioButtonSvrFollow.Location = new Point(241, 15);
		this.radioButtonSvrFollow.Name = "radioButtonSvrFollow";
		this.radioButtonSvrFollow.Size = new System.Drawing.Size(293, 16);
		this.radioButtonSvrFollow.TabIndex = 40;
		this.radioButtonSvrFollow.TabStop = true;
		this.radioButtonSvrFollow.Text = "主帐号跟发(免费，主帐号手动发送时，勾选跟发))";
		this.radioButtonSvrFollow.UseVisualStyleBackColor = true;
		this.buttonFollowSend.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonFollowSend.Location = new Point(15, 35);
		this.buttonFollowSend.Name = "buttonFollowSend";
		this.buttonFollowSend.Size = new System.Drawing.Size(118, 36);
		this.buttonFollowSend.TabIndex = 39;
		this.buttonFollowSend.Text = "加载跟发内容";
		this.buttonFollowSend.UseVisualStyleBackColor = true;
		this.buttonFollowSend.Click += new EventHandler(this.buttonFollowSend_Click);
		this.checkBoxChgFwSndPid.AutoSize = true;
		this.checkBoxChgFwSndPid.Location = new Point(444, 117);
		this.checkBoxChgFwSndPid.Name = "checkBoxChgFwSndPid";
		this.checkBoxChgFwSndPid.Size = new System.Drawing.Size(78, 16);
		this.checkBoxChgFwSndPid.TabIndex = 48;
		this.checkBoxChgFwSndPid.Text = "自动换PID";
		this.checkBoxChgFwSndPid.UseVisualStyleBackColor = true;
		this.label83.AutoSize = true;
		this.label83.Location = new Point(682, 110);
		this.label83.Name = "label83";
		this.label83.Size = new System.Drawing.Size(41, 12);
		this.label83.TabIndex = 52;
		this.label83.Text = "张不发";
		this.buttonFwSndDelAll.Location = new Point(347, 147);
		this.buttonFwSndDelAll.Name = "buttonFwSndDelAll";
		this.buttonFwSndDelAll.Size = new System.Drawing.Size(75, 23);
		this.buttonFwSndDelAll.TabIndex = 47;
		this.buttonFwSndDelAll.Text = "删除全部";
		this.buttonFwSndDelAll.UseVisualStyleBackColor = true;
		this.buttonFwSndDelAll.Click += new EventHandler(this.buttonFwSndDelAll_Click);
		this.buttonFwSndDelSel.Location = new Point(260, 147);
		this.buttonFwSndDelSel.Name = "buttonFwSndDelSel";
		this.buttonFwSndDelSel.Size = new System.Drawing.Size(75, 23);
		this.buttonFwSndDelSel.TabIndex = 46;
		this.buttonFwSndDelSel.Text = "删除选中";
		this.buttonFwSndDelSel.UseVisualStyleBackColor = true;
		this.buttonFwSndDelSel.Click += new EventHandler(this.buttonFwSndDelSel_Click);
		this.label43.AutoSize = true;
		this.label43.Location = new Point(698, 160);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(17, 12);
		this.label43.TabIndex = 45;
		this.label43.Text = "秒";
		this.textBoxFollowSndInteval.Location = new Point(635, 157);
		this.textBoxFollowSndInteval.Name = "textBoxFollowSndInteval";
		this.textBoxFollowSndInteval.Size = new System.Drawing.Size(58, 21);
		this.textBoxFollowSndInteval.TabIndex = 43;
		this.textBoxFollowSndInteval.TextAlign = HorizontalAlignment.Center;
		this.label64.AutoSize = true;
		this.label64.Location = new Point(578, 162);
		this.label64.Name = "label64";
		this.label64.Size = new System.Drawing.Size(53, 12);
		this.label64.TabIndex = 44;
		this.label64.Text = "间隔时间";
		this.buttonFollowSndStop.Enabled = false;
		this.buttonFollowSndStop.Font = new System.Drawing.Font("SimSun", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonFollowSndStop.Location = new Point(127, 118);
		this.buttonFollowSndStop.Name = "buttonFollowSndStop";
		this.buttonFollowSndStop.Size = new System.Drawing.Size(109, 45);
		this.buttonFollowSndStop.TabIndex = 42;
		this.buttonFollowSndStop.Text = "停止发送";
		this.buttonFollowSndStop.UseVisualStyleBackColor = true;
		this.buttonFollowSndStop.Click += new EventHandler(this.buttonFollowSndStop_Click);
		this.buttonFollowSndStart.Font = new System.Drawing.Font("SimSun", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonFollowSndStart.Location = new Point(12, 118);
		this.buttonFollowSndStart.Name = "buttonFollowSndStart";
		this.buttonFollowSndStart.Size = new System.Drawing.Size(109, 45);
		this.buttonFollowSndStart.TabIndex = 41;
		this.buttonFollowSndStart.Text = "开始发送";
		this.buttonFollowSndStart.UseVisualStyleBackColor = true;
		this.buttonFollowSndStart.Click += new EventHandler(this.buttonFollowSndStart_Click);
		this.dataGridViewFollowSnd.AllowUserToAddRows = false;
		this.dataGridViewFollowSnd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewFollowSnd.ContextMenuStrip = this.contextMenuStripFwSnd;
		this.dataGridViewFollowSnd.Location = new Point(6, 184);
		this.dataGridViewFollowSnd.Name = "dataGridViewFollowSnd";
		this.dataGridViewFollowSnd.RowHeadersWidth = 60;
		this.dataGridViewFollowSnd.RowTemplate.Height = 23;
		this.dataGridViewFollowSnd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewFollowSnd.Size = new System.Drawing.Size(714, 296);
		this.dataGridViewFollowSnd.TabIndex = 0;
		this.dataGridViewFollowSnd.DoubleClick += new EventHandler(this.dataGridViewFollowSnd_DoubleClick);
		this.dataGridViewFollowSnd.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewFollowSnd_CellMouseDown);
		this.contextMenuStripFwSnd.Name = "contextMenuStripFwSnd";
		this.contextMenuStripFwSnd.Size = new System.Drawing.Size(61, 4);
		this.groupBox17.Controls.Add(this.dateTimePickerTaskStart);
		this.groupBox17.Controls.Add(this.label93);
		this.groupBox17.Controls.Add(this.label34);
		this.groupBox17.Controls.Add(this.textBoxTaskInteval);
		this.groupBox17.Controls.Add(this.label28);
		this.groupBox17.Controls.Add(this.buttonDelAllTask);
		this.groupBox17.Controls.Add(this.buttonDelTask);
		this.groupBox17.Controls.Add(this.buttonAddTask);
		this.groupBox17.Controls.Add(this.dataGridViewAutoSndTask);
		this.groupBox17.Controls.Add(this.buttonStartTask);
		this.groupBox17.Controls.Add(this.buttonStopTask);
		this.groupBox17.Location = new Point(746, 254);
		this.groupBox17.Name = "groupBox17";
		this.groupBox17.Size = new System.Drawing.Size(485, 271);
		this.groupBox17.TabIndex = 8;
		this.groupBox17.TabStop = false;
		this.groupBox17.Text = "计划任务管理器";
		this.dateTimePickerTaskStart.CustomFormat = "yyyy年MM月dd日 HH:mm";
		this.dateTimePickerTaskStart.Format = DateTimePickerFormat.Custom;
		this.dateTimePickerTaskStart.Location = new Point(39, 245);
		this.dateTimePickerTaskStart.Name = "dateTimePickerTaskStart";
		this.dateTimePickerTaskStart.Size = new System.Drawing.Size(159, 21);
		this.dateTimePickerTaskStart.TabIndex = 78;
		this.label93.AutoSize = true;
		this.label93.Location = new Point(3, 248);
		this.label93.Name = "label93";
		this.label93.Size = new System.Drawing.Size(41, 12);
		this.label93.TabIndex = 77;
		this.label93.Text = "开始：";
		this.label34.AutoSize = true;
		this.label34.Location = new Point(291, 248);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(17, 12);
		this.label34.TabIndex = 47;
		this.label34.Text = "秒";
		this.textBoxTaskInteval.Location = new Point(262, 243);
		this.textBoxTaskInteval.Name = "textBoxTaskInteval";
		this.textBoxTaskInteval.Size = new System.Drawing.Size(27, 21);
		this.textBoxTaskInteval.TabIndex = 45;
		this.textBoxTaskInteval.TextAlign = HorizontalAlignment.Center;
		this.label28.AutoSize = true;
		this.label28.Location = new Point(204, 248);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(65, 12);
		this.label28.TabIndex = 46;
		this.label28.Text = "间隔时间：";
		this.buttonDelAllTask.Location = new Point(317, 18);
		this.buttonDelAllTask.Name = "buttonDelAllTask";
		this.buttonDelAllTask.Size = new System.Drawing.Size(89, 23);
		this.buttonDelAllTask.TabIndex = 11;
		this.buttonDelAllTask.Text = "删除全部任务";
		this.buttonDelAllTask.UseVisualStyleBackColor = true;
		this.buttonDelAllTask.Click += new EventHandler(this.buttonDelAllTask_Click);
		this.buttonDelTask.Location = new Point(218, 18);
		this.buttonDelTask.Name = "buttonDelTask";
		this.buttonDelTask.Size = new System.Drawing.Size(73, 23);
		this.buttonDelTask.TabIndex = 9;
		this.buttonDelTask.Text = "删除任务";
		this.buttonDelTask.UseVisualStyleBackColor = true;
		this.buttonDelTask.Click += new EventHandler(this.buttonDelTask_Click);
		this.buttonAddTask.Location = new Point(115, 18);
		this.buttonAddTask.Name = "buttonAddTask";
		this.buttonAddTask.Size = new System.Drawing.Size(73, 23);
		this.buttonAddTask.TabIndex = 5;
		this.buttonAddTask.Text = "添加任务";
		this.buttonAddTask.UseVisualStyleBackColor = true;
		this.buttonAddTask.Click += new EventHandler(this.buttonAddTask_Click);
		this.dataGridViewAutoSndTask.AllowUserToAddRows = false;
		this.dataGridViewAutoSndTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewAutoSndTask.Location = new Point(6, 50);
		this.dataGridViewAutoSndTask.Name = "dataGridViewAutoSndTask";
		this.dataGridViewAutoSndTask.RowHeadersWidth = 56;
		this.dataGridViewAutoSndTask.RowTemplate.Height = 23;
		this.dataGridViewAutoSndTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewAutoSndTask.Size = new System.Drawing.Size(475, 185);
		this.dataGridViewAutoSndTask.TabIndex = 4;
		this.dataGridViewAutoSndTask.DoubleClick += new EventHandler(this.dataGridViewAutoSndTask_DoubleClick);
		this.buttonStartTask.Location = new Point(327, 242);
		this.buttonStartTask.Name = "buttonStartTask";
		this.buttonStartTask.Size = new System.Drawing.Size(71, 23);
		this.buttonStartTask.TabIndex = 3;
		this.buttonStartTask.Text = "启动计划";
		this.buttonStartTask.UseVisualStyleBackColor = true;
		this.buttonStartTask.Click += new EventHandler(this.buttonStartTask_Click);
		this.buttonStopTask.Enabled = false;
		this.buttonStopTask.Location = new Point(406, 242);
		this.buttonStopTask.Name = "buttonStopTask";
		this.buttonStopTask.Size = new System.Drawing.Size(70, 23);
		this.buttonStopTask.TabIndex = 1;
		this.buttonStopTask.Text = "停止计划";
		this.buttonStopTask.UseVisualStyleBackColor = true;
		this.buttonStopTask.Click += new EventHandler(this.buttonStopTask_Click);
		this.groupBox16.Controls.Add(this.label96);
		this.groupBox16.Controls.Add(this.textBoxWxPicDelay);
		this.groupBox16.Controls.Add(this.label97);
		this.groupBox16.Controls.Add(this.checkBoxMinForm);
		this.groupBox16.Controls.Add(this.checkBoxCloseWinWhileSnded);
		this.groupBox16.Controls.Add(this.checkBoxSndAddStr);
		this.groupBox16.Controls.Add(this.textBoxSndAddStr);
		this.groupBox16.Controls.Add(this.checkBoxSndAddRdm);
		this.groupBox16.Controls.Add(this.checkBoxSndAddtime);
		this.groupBox16.Controls.Add(this.radioButtonSndCtrlEnter);
		this.groupBox16.Controls.Add(this.radioButtonSndEnter);
		this.groupBox16.Controls.Add(this.label32);
		this.groupBox16.Controls.Add(this.textBoxTmSnd);
		this.groupBox16.Controls.Add(this.label33);
		this.groupBox16.Controls.Add(this.label30);
		this.groupBox16.Controls.Add(this.textBoxTmPasete);
		this.groupBox16.Controls.Add(this.label31);
		this.groupBox16.Controls.Add(this.label29);
		this.groupBox16.Controls.Add(this.textBoxTmSwWindow);
		this.groupBox16.Controls.Add(this.label27);
		this.groupBox16.Location = new Point(1017, 10);
		this.groupBox16.Name = "groupBox16";
		this.groupBox16.Size = new System.Drawing.Size(210, 238);
		this.groupBox16.TabIndex = 7;
		this.groupBox16.TabStop = false;
		this.groupBox16.Text = "群发设置";
		this.label96.AutoSize = true;
		this.label96.Location = new Point(167, 101);
		this.label96.Name = "label96";
		this.label96.Size = new System.Drawing.Size(29, 12);
		this.label96.TabIndex = 24;
		this.label96.Text = "毫秒";
		this.textBoxWxPicDelay.Location = new Point(102, 97);
		this.textBoxWxPicDelay.Name = "textBoxWxPicDelay";
		this.textBoxWxPicDelay.Size = new System.Drawing.Size(60, 21);
		this.textBoxWxPicDelay.TabIndex = 23;
		this.textBoxWxPicDelay.TextAlign = HorizontalAlignment.Center;
		this.label97.AutoSize = true;
		this.label97.Location = new Point(14, 101);
		this.label97.Name = "label97";
		this.label97.Size = new System.Drawing.Size(89, 12);
		this.label97.TabIndex = 22;
		this.label97.Text = "微信图片延时：";
		this.checkBoxMinForm.AutoSize = true;
		this.checkBoxMinForm.Location = new Point(66, 0);
		this.checkBoxMinForm.Name = "checkBoxMinForm";
		this.checkBoxMinForm.Size = new System.Drawing.Size(132, 16);
		this.checkBoxMinForm.TabIndex = 21;
		this.checkBoxMinForm.Text = "发送结束最小化软件";
		this.checkBoxMinForm.UseVisualStyleBackColor = true;
		this.checkBoxCloseWinWhileSnded.AutoSize = true;
		this.checkBoxCloseWinWhileSnded.Location = new Point(16, 122);
		this.checkBoxCloseWinWhileSnded.Name = "checkBoxCloseWinWhileSnded";
		this.checkBoxCloseWinWhileSnded.Size = new System.Drawing.Size(132, 16);
		this.checkBoxCloseWinWhileSnded.TabIndex = 20;
		this.checkBoxCloseWinWhileSnded.Text = "发送完关闭聊天窗口";
		this.checkBoxCloseWinWhileSnded.UseVisualStyleBackColor = true;
		this.checkBoxSndAddStr.AutoSize = true;
		this.checkBoxSndAddStr.Location = new Point(16, 146);
		this.checkBoxSndAddStr.Name = "checkBoxSndAddStr";
		this.checkBoxSndAddStr.Size = new System.Drawing.Size(60, 16);
		this.checkBoxSndAddStr.TabIndex = 19;
		this.checkBoxSndAddStr.Text = "加结尾";
		this.checkBoxSndAddStr.UseVisualStyleBackColor = true;
		this.textBoxSndAddStr.Location = new Point(76, 143);
		this.textBoxSndAddStr.Name = "textBoxSndAddStr";
		this.textBoxSndAddStr.Size = new System.Drawing.Size(122, 21);
		this.textBoxSndAddStr.TabIndex = 18;
		this.checkBoxSndAddRdm.AutoSize = true;
		this.checkBoxSndAddRdm.Location = new Point(16, 192);
		this.checkBoxSndAddRdm.Name = "checkBoxSndAddRdm";
		this.checkBoxSndAddRdm.Size = new System.Drawing.Size(132, 16);
		this.checkBoxSndAddRdm.TabIndex = 16;
		this.checkBoxSndAddRdm.Text = "群发结尾加随机字符";
		this.checkBoxSndAddRdm.UseVisualStyleBackColor = true;
		this.checkBoxSndAddtime.AutoSize = true;
		this.checkBoxSndAddtime.Location = new Point(16, 170);
		this.checkBoxSndAddtime.Name = "checkBoxSndAddtime";
		this.checkBoxSndAddtime.Size = new System.Drawing.Size(132, 16);
		this.checkBoxSndAddtime.TabIndex = 15;
		this.checkBoxSndAddtime.Text = "群发结尾加当前时间";
		this.checkBoxSndAddtime.UseVisualStyleBackColor = true;
		this.radioButtonSndCtrlEnter.AutoSize = true;
		this.radioButtonSndCtrlEnter.Location = new Point(100, 213);
		this.radioButtonSndCtrlEnter.Name = "radioButtonSndCtrlEnter";
		this.radioButtonSndCtrlEnter.Size = new System.Drawing.Size(95, 16);
		this.radioButtonSndCtrlEnter.TabIndex = 14;
		this.radioButtonSndCtrlEnter.TabStop = true;
		this.radioButtonSndCtrlEnter.Text = "Ctrl+Enter键";
		this.radioButtonSndCtrlEnter.UseVisualStyleBackColor = true;
		this.radioButtonSndEnter.AutoSize = true;
		this.radioButtonSndEnter.Location = new Point(15, 213);
		this.radioButtonSndEnter.Name = "radioButtonSndEnter";
		this.radioButtonSndEnter.Size = new System.Drawing.Size(65, 16);
		this.radioButtonSndEnter.TabIndex = 13;
		this.radioButtonSndEnter.TabStop = true;
		this.radioButtonSndEnter.Text = "Enter键";
		this.radioButtonSndEnter.UseVisualStyleBackColor = true;
		this.label32.AutoSize = true;
		this.label32.Location = new Point(167, 75);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(29, 12);
		this.label32.TabIndex = 12;
		this.label32.Text = "毫秒";
		this.textBoxTmSnd.Location = new Point(102, 71);
		this.textBoxTmSnd.Name = "textBoxTmSnd";
		this.textBoxTmSnd.Size = new System.Drawing.Size(60, 21);
		this.textBoxTmSnd.TabIndex = 11;
		this.textBoxTmSnd.TextAlign = HorizontalAlignment.Center;
		this.label33.AutoSize = true;
		this.label33.Location = new Point(14, 75);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(89, 12);
		this.label33.TabIndex = 10;
		this.label33.Text = "发送消息延时：";
		this.label30.AutoSize = true;
		this.label30.Location = new Point(166, 50);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(29, 12);
		this.label30.TabIndex = 9;
		this.label30.Text = "毫秒";
		this.textBoxTmPasete.Location = new Point(102, 46);
		this.textBoxTmPasete.Name = "textBoxTmPasete";
		this.textBoxTmPasete.Size = new System.Drawing.Size(60, 21);
		this.textBoxTmPasete.TabIndex = 8;
		this.textBoxTmPasete.TextAlign = HorizontalAlignment.Center;
		this.label31.AutoSize = true;
		this.label31.Location = new Point(13, 50);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(89, 12);
		this.label31.TabIndex = 7;
		this.label31.Text = "粘贴消息延时：";
		this.label29.AutoSize = true;
		this.label29.Location = new Point(166, 24);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(29, 12);
		this.label29.TabIndex = 6;
		this.label29.Text = "毫秒";
		this.textBoxTmSwWindow.Location = new Point(102, 20);
		this.textBoxTmSwWindow.Name = "textBoxTmSwWindow";
		this.textBoxTmSwWindow.Size = new System.Drawing.Size(60, 21);
		this.textBoxTmSwWindow.TabIndex = 5;
		this.textBoxTmSwWindow.TextAlign = HorizontalAlignment.Center;
		this.label27.AutoSize = true;
		this.label27.Location = new Point(13, 24);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(89, 12);
		this.label27.TabIndex = 0;
		this.label27.Text = "切换窗口延时：";
		this.groupBox15.Controls.Add(this.linkLabelLnkHelp);
		this.groupBox15.Controls.Add(this.textBoxWxGrpName);
		this.groupBox15.Controls.Add(this.label92);
		this.groupBox15.Controls.Add(this.buttonAddWxGrp);
		this.groupBox15.Controls.Add(this.buttonOpenShortCutFolder);
		this.groupBox15.Controls.Add(this.buttonOpenAllGrp);
		this.groupBox15.Controls.Add(this.buttonLoadQQGrpList);
		this.groupBox15.Controls.Add(this.dataGridViewQQGrp);
		this.groupBox15.Location = new Point(746, 11);
		this.groupBox15.Name = "groupBox15";
		this.groupBox15.Size = new System.Drawing.Size(265, 237);
		this.groupBox15.TabIndex = 6;
		this.groupBox15.TabStop = false;
		this.groupBox15.Text = "群发列表-排序：左击上移↑，右击下移↓";
		this.linkLabelLnkHelp.AutoSize = true;
		this.linkLabelLnkHelp.Location = new Point(236, 0);
		this.linkLabelLnkHelp.Name = "linkLabelLnkHelp";
		this.linkLabelLnkHelp.Size = new System.Drawing.Size(23, 12);
		this.linkLabelLnkHelp.TabIndex = 69;
		this.linkLabelLnkHelp.TabStop = true;
		this.linkLabelLnkHelp.Text = "(?)";
		this.linkLabelLnkHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelLnkHelp_LinkClicked);
		this.textBoxWxGrpName.Location = new Point(73, 209);
		this.textBoxWxGrpName.Name = "textBoxWxGrpName";
		this.textBoxWxGrpName.Size = new System.Drawing.Size(88, 21);
		this.textBoxWxGrpName.TabIndex = 9;
		this.label92.AutoSize = true;
		this.label92.Location = new Point(6, 213);
		this.label92.Name = "label92";
		this.label92.Size = new System.Drawing.Size(71, 12);
		this.label92.TabIndex = 8;
		this.label92.Text = "微信群名称:";
		this.buttonAddWxGrp.Location = new Point(167, 208);
		this.buttonAddWxGrp.Name = "buttonAddWxGrp";
		this.buttonAddWxGrp.Size = new System.Drawing.Size(79, 23);
		this.buttonAddWxGrp.TabIndex = 4;
		this.buttonAddWxGrp.Text = "添加微信群";
		this.buttonAddWxGrp.UseVisualStyleBackColor = true;
		this.buttonAddWxGrp.MouseLeave += new EventHandler(this.buttonAddWxGrp_MouseLeave);
		this.buttonAddWxGrp.Click += new EventHandler(this.buttonAddWxGrp_Click);
		this.buttonAddWxGrp.MouseEnter += new EventHandler(this.buttonAddWxGrp_MouseEnter);
		this.buttonOpenShortCutFolder.Location = new Point(171, 182);
		this.buttonOpenShortCutFolder.Name = "buttonOpenShortCutFolder";
		this.buttonOpenShortCutFolder.Size = new System.Drawing.Size(75, 23);
		this.buttonOpenShortCutFolder.TabIndex = 3;
		this.buttonOpenShortCutFolder.Text = "打开文件夹";
		this.buttonOpenShortCutFolder.UseVisualStyleBackColor = true;
		this.buttonOpenShortCutFolder.Click += new EventHandler(this.buttonOpenShortCutFolder_Click);
		this.buttonOpenAllGrp.Location = new Point(89, 182);
		this.buttonOpenAllGrp.Name = "buttonOpenAllGrp";
		this.buttonOpenAllGrp.Size = new System.Drawing.Size(75, 23);
		this.buttonOpenAllGrp.TabIndex = 2;
		this.buttonOpenAllGrp.Text = "打开所有群";
		this.buttonOpenAllGrp.UseVisualStyleBackColor = true;
		this.buttonOpenAllGrp.Click += new EventHandler(this.buttonOpenAllGrp_Click);
		this.buttonLoadQQGrpList.Location = new Point(8, 182);
		this.buttonLoadQQGrpList.Name = "buttonLoadQQGrpList";
		this.buttonLoadQQGrpList.Size = new System.Drawing.Size(75, 23);
		this.buttonLoadQQGrpList.TabIndex = 1;
		this.buttonLoadQQGrpList.Text = "刷新群列表";
		this.buttonLoadQQGrpList.UseVisualStyleBackColor = true;
		this.buttonLoadQQGrpList.Click += new EventHandler(this.buttonLoadQQGrpList_Click);
		this.dataGridViewQQGrp.AllowUserToAddRows = false;
		this.dataGridViewQQGrp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewQQGrp.Location = new Point(7, 20);
		this.dataGridViewQQGrp.Name = "dataGridViewQQGrp";
		this.dataGridViewQQGrp.RowHeadersWidth = 61;
		this.dataGridViewQQGrp.RowTemplate.Height = 23;
		this.dataGridViewQQGrp.Size = new System.Drawing.Size(252, 160);
		this.dataGridViewQQGrp.TabIndex = 0;
		this.dataGridViewQQGrp.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewQQGrp_CellMouseDown);
		this.dataGridViewQQGrp.Click += new EventHandler(this.dataGridViewQQGrp_Click);
		this.tabPageHotShare.Controls.Add(this.groupBox37);
		this.tabPageHotShare.Controls.Add(this.dataGridViewHotShare);
		this.tabPageHotShare.Controls.Add(this.tabControlHotShare);
		this.tabPageHotShare.Controls.Add(this.groupBox19);
		this.tabPageHotShare.Location = new Point(4, 29);
		this.tabPageHotShare.Name = "tabPageHotShare";
		this.tabPageHotShare.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageHotShare.Size = new System.Drawing.Size(1253, 531);
		this.tabPageHotShare.TabIndex = 5;
		this.tabPageHotShare.Text = "爆款分享";
		this.tabPageHotShare.UseVisualStyleBackColor = true;
		this.groupBox37.Controls.Add(this.textBoxHotShareKW);
		this.groupBox37.Controls.Add(this.buttonSchHotShare);
		this.groupBox37.Controls.Add(this.label85);
		this.groupBox37.Controls.Add(this.label52);
		this.groupBox37.Location = new Point(16, 3);
		this.groupBox37.Name = "groupBox37";
		this.groupBox37.Size = new System.Drawing.Size(463, 49);
		this.groupBox37.TabIndex = 5;
		this.groupBox37.TabStop = false;
		this.textBoxHotShareKW.Location = new Point(80, 18);
		this.textBoxHotShareKW.Name = "textBoxHotShareKW";
		this.textBoxHotShareKW.Size = new System.Drawing.Size(166, 21);
		this.textBoxHotShareKW.TabIndex = 4;
		this.textBoxHotShareKW.DoubleClick += new EventHandler(this.textBoxHotShareKW_DoubleClick);
		this.textBoxHotShareKW.KeyDown += new KeyEventHandler(this.textBoxHotShareKW_KeyDown);
		this.buttonSchHotShare.Location = new Point(343, 16);
		this.buttonSchHotShare.Name = "buttonSchHotShare";
		this.buttonSchHotShare.Size = new System.Drawing.Size(75, 23);
		this.buttonSchHotShare.TabIndex = 2;
		this.buttonSchHotShare.Text = "搜云端爆款";
		this.buttonSchHotShare.UseVisualStyleBackColor = true;
		this.buttonSchHotShare.Click += new EventHandler(this.buttonSchHotShare_Click);
		this.label85.AutoSize = true;
		this.label85.Location = new Point(30, 22);
		this.label85.Name = "label85";
		this.label85.Size = new System.Drawing.Size(53, 12);
		this.label85.TabIndex = 3;
		this.label85.Text = "关键词：";
		this.label52.AutoSize = true;
		this.label52.Location = new Point(245, 22);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(83, 12);
		this.label52.TabIndex = 5;
		this.label52.Text = "(试试带空格）";
		this.dataGridViewHotShare.AllowUserToAddRows = false;
		this.dataGridViewHotShare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewHotShare.ContextMenuStrip = this.contextMenuStripHotShare;
		this.dataGridViewHotShare.Location = new Point(16, 58);
		this.dataGridViewHotShare.Name = "dataGridViewHotShare";
		this.dataGridViewHotShare.RowHeadersWidth = 60;
		this.dataGridViewHotShare.RowTemplate.Height = 23;
		this.dataGridViewHotShare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewHotShare.Size = new System.Drawing.Size(463, 464);
		this.dataGridViewHotShare.TabIndex = 1;
		this.dataGridViewHotShare.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewHotShare_CellMouseDown);
		this.dataGridViewHotShare.Click += new EventHandler(this.dataGridViewHotShare_Click);
		this.contextMenuStripHotShare.Name = "contextMenuStripHotShare";
		this.contextMenuStripHotShare.Size = new System.Drawing.Size(61, 4);
		this.tabControlHotShare.Controls.Add(this.tabPageSelfHotshare);
		this.tabControlHotShare.Controls.Add(this.tabPageSelHotShare);
		this.tabControlHotShare.ItemSize = new System.Drawing.Size(60, 25);
		this.tabControlHotShare.Location = new Point(21, 198);
		this.tabControlHotShare.Name = "tabControlHotShare";
		this.tabControlHotShare.SelectedIndex = 0;
		this.tabControlHotShare.Size = new System.Drawing.Size(385, 47);
		this.tabControlHotShare.TabIndex = 5;
		this.tabControlHotShare.Visible = false;
		this.tabControlHotShare.SelectedIndexChanged += new EventHandler(this.tabControlHotShare_SelectedIndexChanged);
		this.tabPageSelfHotshare.Location = new Point(4, 29);
		this.tabPageSelfHotshare.Name = "tabPageSelfHotshare";
		this.tabPageSelfHotshare.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageSelfHotshare.Size = new System.Drawing.Size(377, 14);
		this.tabPageSelfHotshare.TabIndex = 0;
		this.tabPageSelfHotshare.Text = "主推爆款";
		this.tabPageSelfHotshare.UseVisualStyleBackColor = true;
		this.tabPageSelHotShare.Location = new Point(4, 29);
		this.tabPageSelHotShare.Name = "tabPageSelHotShare";
		this.tabPageSelHotShare.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageSelHotShare.Size = new System.Drawing.Size(377, 14);
		this.tabPageSelHotShare.TabIndex = 1;
		this.tabPageSelHotShare.Text = "选品爆款";
		this.tabPageSelHotShare.UseVisualStyleBackColor = true;
		this.groupBox19.Controls.Add(this.buttonSelHotAddManul);
		this.groupBox19.Controls.Add(this.buttonSelHotAddFollow);
		this.groupBox19.Controls.Add(this.buttonRtnSelHotList);
		this.groupBox19.Controls.Add(this.webBrowserHotShare);
		this.groupBox19.Location = new Point(495, 3);
		this.groupBox19.Name = "groupBox19";
		this.groupBox19.Size = new System.Drawing.Size(751, 522);
		this.groupBox19.TabIndex = 0;
		this.groupBox19.TabStop = false;
		this.buttonSelHotAddManul.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSelHotAddManul.ForeColor = Color.FromArgb(255, 128, 255);
		this.buttonSelHotAddManul.Location = new Point(602, 115);
		this.buttonSelHotAddManul.Name = "buttonSelHotAddManul";
		this.buttonSelHotAddManul.Size = new System.Drawing.Size(125, 39);
		this.buttonSelHotAddManul.TabIndex = 3;
		this.buttonSelHotAddManul.Text = "添加到手动";
		this.buttonSelHotAddManul.UseVisualStyleBackColor = true;
		this.buttonSelHotAddManul.Visible = false;
		this.buttonSelHotAddManul.Click += new EventHandler(this.buttonSelHotAddManul_Click);
		this.buttonSelHotAddFollow.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSelHotAddFollow.ForeColor = Color.FromArgb(255, 128, 255);
		this.buttonSelHotAddFollow.Location = new Point(602, 70);
		this.buttonSelHotAddFollow.Name = "buttonSelHotAddFollow";
		this.buttonSelHotAddFollow.Size = new System.Drawing.Size(125, 39);
		this.buttonSelHotAddFollow.TabIndex = 2;
		this.buttonSelHotAddFollow.Text = "添加到跟发";
		this.buttonSelHotAddFollow.UseVisualStyleBackColor = true;
		this.buttonSelHotAddFollow.Visible = false;
		this.buttonSelHotAddFollow.Click += new EventHandler(this.buttonSelHotAddFollow_Click);
		this.buttonRtnSelHotList.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonRtnSelHotList.ForeColor = Color.FromArgb(255, 128, 255);
		this.buttonRtnSelHotList.Location = new Point(602, 25);
		this.buttonRtnSelHotList.Name = "buttonRtnSelHotList";
		this.buttonRtnSelHotList.Size = new System.Drawing.Size(125, 39);
		this.buttonRtnSelHotList.TabIndex = 1;
		this.buttonRtnSelHotList.Text = "返回列表";
		this.buttonRtnSelHotList.UseVisualStyleBackColor = true;
		this.buttonRtnSelHotList.Visible = false;
		this.buttonRtnSelHotList.Click += new EventHandler(this.buttonRtnSelHotList_Click);
		this.webBrowserHotShare.Dock = DockStyle.Fill;
		this.webBrowserHotShare.Location = new Point(3, 17);
		this.webBrowserHotShare.MinimumSize = new System.Drawing.Size(20, 20);
		this.webBrowserHotShare.Name = "webBrowserHotShare";
		this.webBrowserHotShare.Size = new System.Drawing.Size(745, 502);
		this.webBrowserHotShare.TabIndex = 0;
		this.webBrowserHotShare.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowserHotShare_DocumentCompleted);
		this.tabPageTools.Controls.Add(this.groupBox39);
		this.tabPageTools.Controls.Add(this.groupBox38);
		this.tabPageTools.Controls.Add(this.groupBox29);
		this.tabPageTools.Controls.Add(this.groupBox28);
		this.tabPageTools.Controls.Add(this.groupBox21);
		this.tabPageTools.Controls.Add(this.groupBox20);
		this.tabPageTools.Location = new Point(4, 29);
		this.tabPageTools.Name = "tabPageTools";
		this.tabPageTools.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTools.Size = new System.Drawing.Size(1253, 531);
		this.tabPageTools.TabIndex = 6;
		this.tabPageTools.Text = "实用工具";
		this.tabPageTools.UseVisualStyleBackColor = true;
		this.groupBox39.Controls.Add(this.buttonGenTaoKouLing);
		this.groupBox39.Controls.Add(this.textBoxTklUrl);
		this.groupBox39.Controls.Add(this.label90);
		this.groupBox39.Location = new Point(895, 11);
		this.groupBox39.Name = "groupBox39";
		this.groupBox39.Size = new System.Drawing.Size(350, 53);
		this.groupBox39.TabIndex = 8;
		this.groupBox39.TabStop = false;
		this.groupBox39.Text = "淘口令转换 - 允许优惠券短网址";
		this.buttonGenTaoKouLing.Location = new Point(269, 18);
		this.buttonGenTaoKouLing.Name = "buttonGenTaoKouLing";
		this.buttonGenTaoKouLing.Size = new System.Drawing.Size(75, 23);
		this.buttonGenTaoKouLing.TabIndex = 2;
		this.buttonGenTaoKouLing.Text = "复制淘口令";
		this.buttonGenTaoKouLing.UseVisualStyleBackColor = true;
		this.buttonGenTaoKouLing.Click += new EventHandler(this.buttonGenTaoKouLing_Click);
		this.textBoxTklUrl.Location = new Point(52, 20);
		this.textBoxTklUrl.Name = "textBoxTklUrl";
		this.textBoxTklUrl.Size = new System.Drawing.Size(200, 21);
		this.textBoxTklUrl.TabIndex = 2;
		this.textBoxTklUrl.DoubleClick += new EventHandler(this.textBoxTklUrl_DoubleClick);
		this.label90.AutoSize = true;
		this.label90.Location = new Point(6, 23);
		this.label90.Name = "label90";
		this.label90.Size = new System.Drawing.Size(53, 12);
		this.label90.TabIndex = 1;
		this.label90.Text = "原网址：";
		this.groupBox38.Controls.Add(this.buttonDelMsgReplace);
		this.groupBox38.Controls.Add(this.textBoxNewChar);
		this.groupBox38.Controls.Add(this.dgvQQGrpMonRep);
		this.groupBox38.Controls.Add(this.buttonAddMsgReplace);
		this.groupBox38.Controls.Add(this.label87);
		this.groupBox38.Controls.Add(this.textBoxOldChar);
		this.groupBox38.Controls.Add(this.label86);
		this.groupBox38.Location = new Point(1045, 129);
		this.groupBox38.Name = "groupBox38";
		this.groupBox38.Size = new System.Drawing.Size(200, 396);
		this.groupBox38.TabIndex = 7;
		this.groupBox38.TabStop = false;
		this.groupBox38.Text = "链接转换内容的关键词替换";
		this.buttonDelMsgReplace.Location = new Point(107, 74);
		this.buttonDelMsgReplace.Name = "buttonDelMsgReplace";
		this.buttonDelMsgReplace.Size = new System.Drawing.Size(75, 23);
		this.buttonDelMsgReplace.TabIndex = 6;
		this.buttonDelMsgReplace.Text = "删除";
		this.buttonDelMsgReplace.UseVisualStyleBackColor = true;
		this.buttonDelMsgReplace.Click += new EventHandler(this.buttonDelMsgReplace_Click);
		this.textBoxNewChar.Location = new Point(66, 44);
		this.textBoxNewChar.Name = "textBoxNewChar";
		this.textBoxNewChar.Size = new System.Drawing.Size(128, 21);
		this.textBoxNewChar.TabIndex = 2;
		this.dgvQQGrpMonRep.AllowUserToAddRows = false;
		this.dgvQQGrpMonRep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvQQGrpMonRep.Location = new Point(6, 103);
		this.dgvQQGrpMonRep.Name = "dgvQQGrpMonRep";
		this.dgvQQGrpMonRep.RowTemplate.Height = 23;
		this.dgvQQGrpMonRep.Size = new System.Drawing.Size(188, 287);
		this.dgvQQGrpMonRep.TabIndex = 5;
		this.buttonAddMsgReplace.Location = new Point(13, 74);
		this.buttonAddMsgReplace.Name = "buttonAddMsgReplace";
		this.buttonAddMsgReplace.Size = new System.Drawing.Size(75, 23);
		this.buttonAddMsgReplace.TabIndex = 4;
		this.buttonAddMsgReplace.Text = "增加";
		this.buttonAddMsgReplace.UseVisualStyleBackColor = true;
		this.buttonAddMsgReplace.Click += new EventHandler(this.buttonAddMsgReplace_Click);
		this.label87.AutoSize = true;
		this.label87.Location = new Point(6, 47);
		this.label87.Name = "label87";
		this.label87.Size = new System.Drawing.Size(65, 12);
		this.label87.TabIndex = 3;
		this.label87.Text = "替换文字：";
		this.textBoxOldChar.Location = new Point(66, 17);
		this.textBoxOldChar.Name = "textBoxOldChar";
		this.textBoxOldChar.Size = new System.Drawing.Size(128, 21);
		this.textBoxOldChar.TabIndex = 1;
		this.label86.AutoSize = true;
		this.label86.Location = new Point(7, 21);
		this.label86.Name = "label86";
		this.label86.Size = new System.Drawing.Size(53, 12);
		this.label86.TabIndex = 0;
		this.label86.Text = "原文字：";
		this.groupBox29.Controls.Add(this.label53);
		this.groupBox29.Controls.Add(this.buttonMutualHotShare);
		this.groupBox29.Controls.Add(this.buttonShareHotShare);
		this.groupBox29.Controls.Add(this.groupBox42);
		this.groupBox29.Controls.Add(this.checkBoxBatchConvert);
		this.groupBox29.Controls.Add(this.checkBoxClrAfterConvert);
		this.groupBox29.Controls.Add(this.buttonChkCoupon);
		this.groupBox29.Controls.Add(this.buttonConvertAndAddToSnd);
		this.groupBox29.Controls.Add(this.buttonConvertClr);
		this.groupBox29.Controls.Add(this.buttonConvert);
		this.groupBox29.Location = new Point(894, 129);
		this.groupBox29.Name = "groupBox29";
		this.groupBox29.Size = new System.Drawing.Size(147, 396);
		this.groupBox29.TabIndex = 6;
		this.groupBox29.TabStop = false;
		this.groupBox29.Text = "一键转链接操作";
		this.label53.AutoSize = true;
		this.label53.Location = new Point(24, 310);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(101, 12);
		this.label53.TabIndex = 12;
		this.label53.Text = "分享爆款暂时关闭";
		this.buttonMutualHotShare.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonMutualHotShare.Location = new Point(80, 318);
		this.buttonMutualHotShare.Name = "buttonMutualHotShare";
		this.buttonMutualHotShare.Size = new System.Drawing.Size(61, 33);
		this.buttonMutualHotShare.TabIndex = 11;
		this.buttonMutualHotShare.Text = "互推爆款";
		this.buttonMutualHotShare.UseVisualStyleBackColor = true;
		this.buttonMutualHotShare.Visible = false;
		this.buttonMutualHotShare.Click += new EventHandler(this.buttonMutualHotShare_Click);
		this.buttonShareHotShare.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonShareHotShare.Location = new Point(14, 318);
		this.buttonShareHotShare.Name = "buttonShareHotShare";
		this.buttonShareHotShare.Size = new System.Drawing.Size(61, 30);
		this.buttonShareHotShare.TabIndex = 10;
		this.buttonShareHotShare.Text = "分享爆款";
		this.buttonShareHotShare.UseVisualStyleBackColor = true;
		this.buttonShareHotShare.Visible = false;
		this.buttonShareHotShare.Click += new EventHandler(this.buttonShareHotShare_Click);
		this.groupBox42.Controls.Add(this.linkLabelPyq);
		this.groupBox42.Controls.Add(this.buttonCp2in1Tkl);
		this.groupBox42.Controls.Add(this.buttonCpPromotTkl);
		this.groupBox42.Controls.Add(this.buttonPengyouQuan);
		this.groupBox42.Controls.Add(this.buttonCpCouponTkl);
		this.groupBox42.Location = new Point(4, 124);
		this.groupBox42.Name = "groupBox42";
		this.groupBox42.Size = new System.Drawing.Size(140, 108);
		this.groupBox42.TabIndex = 9;
		this.groupBox42.TabStop = false;
		this.groupBox42.Text = "生成朋友圈评论";
		this.linkLabelPyq.AutoSize = true;
		this.linkLabelPyq.Location = new Point(109, 0);
		this.linkLabelPyq.Name = "linkLabelPyq";
		this.linkLabelPyq.Size = new System.Drawing.Size(23, 12);
		this.linkLabelPyq.TabIndex = 69;
		this.linkLabelPyq.TabStop = true;
		this.linkLabelPyq.Text = "(?)";
		this.linkLabelPyq.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelPyq_LinkClicked);
		this.buttonCp2in1Tkl.Enabled = false;
		this.buttonCp2in1Tkl.Location = new Point(5, 78);
		this.buttonCp2in1Tkl.Name = "buttonCp2in1Tkl";
		this.buttonCp2in1Tkl.Size = new System.Drawing.Size(129, 23);
		this.buttonCp2in1Tkl.TabIndex = 12;
		this.buttonCp2in1Tkl.Text = "2合1淘口令";
		this.buttonCp2in1Tkl.UseVisualStyleBackColor = true;
		this.buttonCp2in1Tkl.Click += new EventHandler(this.buttonCp2in1Tkl_Click);
		this.buttonCpPromotTkl.Enabled = false;
		this.buttonCpPromotTkl.Location = new Point(63, 53);
		this.buttonCpPromotTkl.Name = "buttonCpPromotTkl";
		this.buttonCpPromotTkl.Size = new System.Drawing.Size(69, 23);
		this.buttonCpPromotTkl.TabIndex = 11;
		this.buttonCpPromotTkl.Text = "推广口令";
		this.buttonCpPromotTkl.UseVisualStyleBackColor = true;
		this.buttonCpPromotTkl.Click += new EventHandler(this.buttonCpPromotTkl_Click);
		this.buttonPengyouQuan.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonPengyouQuan.Location = new Point(6, 20);
		this.buttonPengyouQuan.Name = "buttonPengyouQuan";
		this.buttonPengyouQuan.Size = new System.Drawing.Size(123, 30);
		this.buttonPengyouQuan.TabIndex = 9;
		this.buttonPengyouQuan.Text = "朋友圈评论";
		this.buttonPengyouQuan.UseVisualStyleBackColor = true;
		this.buttonPengyouQuan.Click += new EventHandler(this.buttonPengyouQuan_Click);
		this.buttonCpCouponTkl.Enabled = false;
		this.buttonCpCouponTkl.Location = new Point(3, 54);
		this.buttonCpCouponTkl.Name = "buttonCpCouponTkl";
		this.buttonCpCouponTkl.Size = new System.Drawing.Size(54, 23);
		this.buttonCpCouponTkl.TabIndex = 10;
		this.buttonCpCouponTkl.Text = "优惠券";
		this.buttonCpCouponTkl.UseVisualStyleBackColor = true;
		this.buttonCpCouponTkl.Click += new EventHandler(this.buttonCpCouponTkl_Click);
		this.checkBoxBatchConvert.AutoSize = true;
		this.checkBoxBatchConvert.Location = new Point(29, 48);
		this.checkBoxBatchConvert.Name = "checkBoxBatchConvert";
		this.checkBoxBatchConvert.Size = new System.Drawing.Size(108, 16);
		this.checkBoxBatchConvert.TabIndex = 8;
		this.checkBoxBatchConvert.Text = "批量转链接模式";
		this.checkBoxBatchConvert.UseVisualStyleBackColor = true;
		this.checkBoxClrAfterConvert.AutoSize = true;
		this.checkBoxClrAfterConvert.Location = new Point(29, 26);
		this.checkBoxClrAfterConvert.Name = "checkBoxClrAfterConvert";
		this.checkBoxClrAfterConvert.Size = new System.Drawing.Size(84, 16);
		this.checkBoxClrAfterConvert.TabIndex = 7;
		this.checkBoxClrAfterConvert.Text = "转换完清空";
		this.checkBoxClrAfterConvert.UseVisualStyleBackColor = true;
		this.buttonChkCoupon.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonChkCoupon.Location = new Point(14, 272);
		this.buttonChkCoupon.Name = "buttonChkCoupon";
		this.buttonChkCoupon.Size = new System.Drawing.Size(123, 28);
		this.buttonChkCoupon.TabIndex = 6;
		this.buttonChkCoupon.Text = "检查优惠券数";
		this.buttonChkCoupon.UseVisualStyleBackColor = true;
		this.buttonChkCoupon.Click += new EventHandler(this.buttonChkCoupon_Click);
		this.buttonConvertAndAddToSnd.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonConvertAndAddToSnd.Location = new Point(15, 70);
		this.buttonConvertAndAddToSnd.Name = "buttonConvertAndAddToSnd";
		this.buttonConvertAndAddToSnd.Size = new System.Drawing.Size(123, 48);
		this.buttonConvertAndAddToSnd.TabIndex = 4;
		this.buttonConvertAndAddToSnd.Text = "转换并添加到群发助手";
		this.buttonConvertAndAddToSnd.UseVisualStyleBackColor = true;
		this.buttonConvertAndAddToSnd.Click += new EventHandler(this.buttonConvertAndAddToSnd_Click);
		this.buttonConvertClr.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonConvertClr.Location = new Point(15, 358);
		this.buttonConvertClr.Name = "buttonConvertClr";
		this.buttonConvertClr.Size = new System.Drawing.Size(123, 29);
		this.buttonConvertClr.TabIndex = 5;
		this.buttonConvertClr.Text = "清空";
		this.buttonConvertClr.UseVisualStyleBackColor = true;
		this.buttonConvertClr.Click += new EventHandler(this.buttonConvertClr_Click);
		this.buttonConvert.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonConvert.Location = new Point(14, 237);
		this.buttonConvert.Name = "buttonConvert";
		this.buttonConvert.Size = new System.Drawing.Size(123, 30);
		this.buttonConvert.TabIndex = 3;
		this.buttonConvert.Text = "转换并拷贝";
		this.buttonConvert.UseVisualStyleBackColor = true;
		this.buttonConvert.Click += new EventHandler(this.buttonConvert_Click);
		this.groupBox28.Controls.Add(this.webBrowserConvert);
		this.groupBox28.Location = new Point(10, 129);
		this.groupBox28.Name = "groupBox28";
		this.groupBox28.Size = new System.Drawing.Size(878, 396);
		this.groupBox28.TabIndex = 2;
		this.groupBox28.TabStop = false;
		this.groupBox28.Text = "一键转链接内容编辑 - CTRL+V粘贴（可以包含图片文字和链接）";
		this.webBrowserConvert.ContextMenuStrip = this.contextMenuStripUrlTrans;
		this.webBrowserConvert.Dock = DockStyle.Fill;
		this.webBrowserConvert.Location = new Point(3, 17);
		this.webBrowserConvert.MinimumSize = new System.Drawing.Size(20, 20);
		this.webBrowserConvert.Name = "webBrowserConvert";
		this.webBrowserConvert.Size = new System.Drawing.Size(872, 376);
		this.webBrowserConvert.TabIndex = 0;
		this.contextMenuStripUrlTrans.Name = "contextMenuStripUrlTrans";
		this.contextMenuStripUrlTrans.Size = new System.Drawing.Size(61, 4);
		this.groupBox21.Controls.Add(this.buttonCouponTkl);
		this.groupBox21.Controls.Add(this.buttonCpShortCoupon);
		this.groupBox21.Controls.Add(this.buttonCpCoupon);
		this.groupBox21.Controls.Add(this.buttonPcToMbCoupon);
		this.groupBox21.Controls.Add(this.textBoxMbCoupon);
		this.groupBox21.Controls.Add(this.label39);
		this.groupBox21.Controls.Add(this.textBoxPcCoupon);
		this.groupBox21.Controls.Add(this.buttonClrCoupon);
		this.groupBox21.Controls.Add(this.label40);
		this.groupBox21.Location = new Point(10, 70);
		this.groupBox21.Name = "groupBox21";
		this.groupBox21.Size = new System.Drawing.Size(1031, 53);
		this.groupBox21.TabIndex = 1;
		this.groupBox21.TabStop = false;
		this.groupBox21.Text = "优惠券转换";
		this.buttonCouponTkl.Location = new Point(913, 18);
		this.buttonCouponTkl.Name = "buttonCouponTkl";
		this.buttonCouponTkl.Size = new System.Drawing.Size(75, 23);
		this.buttonCouponTkl.TabIndex = 8;
		this.buttonCouponTkl.Text = "复制淘口令";
		this.buttonCouponTkl.UseVisualStyleBackColor = true;
		this.buttonCouponTkl.Click += new EventHandler(this.buttonCouponTkl_Click);
		this.buttonCpShortCoupon.Location = new Point(808, 18);
		this.buttonCpShortCoupon.Name = "buttonCpShortCoupon";
		this.buttonCpShortCoupon.Size = new System.Drawing.Size(70, 23);
		this.buttonCpShortCoupon.TabIndex = 5;
		this.buttonCpShortCoupon.Text = "复制短链";
		this.buttonCpShortCoupon.UseVisualStyleBackColor = true;
		this.buttonCpShortCoupon.Click += new EventHandler(this.buttonCpShortCoupon_Click);
		this.buttonCpCoupon.Location = new Point(750, 18);
		this.buttonCpCoupon.Name = "buttonCpCoupon";
		this.buttonCpCoupon.Size = new System.Drawing.Size(46, 23);
		this.buttonCpCoupon.TabIndex = 3;
		this.buttonCpCoupon.Text = "复制";
		this.buttonCpCoupon.UseVisualStyleBackColor = true;
		this.buttonCpCoupon.Click += new EventHandler(this.buttonCpCoupon_Click);
		this.buttonPcToMbCoupon.Location = new Point(349, 18);
		this.buttonPcToMbCoupon.Name = "buttonPcToMbCoupon";
		this.buttonPcToMbCoupon.Size = new System.Drawing.Size(46, 23);
		this.buttonPcToMbCoupon.TabIndex = 2;
		this.buttonPcToMbCoupon.Text = "转换";
		this.buttonPcToMbCoupon.UseVisualStyleBackColor = true;
		this.buttonPcToMbCoupon.Click += new EventHandler(this.buttonPcToMbCoupon_Click);
		this.textBoxMbCoupon.Location = new Point(524, 20);
		this.textBoxMbCoupon.Name = "textBoxMbCoupon";
		this.textBoxMbCoupon.ReadOnly = true;
		this.textBoxMbCoupon.Size = new System.Drawing.Size(211, 21);
		this.textBoxMbCoupon.TabIndex = 4;
		this.label39.AutoSize = true;
		this.label39.Location = new Point(454, 23);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(77, 12);
		this.label39.TabIndex = 3;
		this.label39.Text = "手机优惠券：";
		this.textBoxPcCoupon.Location = new Point(79, 20);
		this.textBoxPcCoupon.Name = "textBoxPcCoupon";
		this.textBoxPcCoupon.Size = new System.Drawing.Size(253, 21);
		this.textBoxPcCoupon.TabIndex = 2;
		this.buttonClrCoupon.Location = new Point(401, 18);
		this.buttonClrCoupon.Name = "buttonClrCoupon";
		this.buttonClrCoupon.Size = new System.Drawing.Size(47, 23);
		this.buttonClrCoupon.TabIndex = 1;
		this.buttonClrCoupon.Text = "清空";
		this.buttonClrCoupon.UseVisualStyleBackColor = true;
		this.buttonClrCoupon.Click += new EventHandler(this.buttonClrCoupon_Click);
		this.label40.AutoSize = true;
		this.label40.Location = new Point(6, 23);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(77, 12);
		this.label40.TabIndex = 1;
		this.label40.Text = "优惠券链接：";
		this.groupBox20.Controls.Add(this.buttonCopyShortUrl);
		this.groupBox20.Controls.Add(this.buttonShortUrl);
		this.groupBox20.Controls.Add(this.textBoxShortUrl);
		this.groupBox20.Controls.Add(this.label38);
		this.groupBox20.Controls.Add(this.textBoxOrgUrl);
		this.groupBox20.Controls.Add(this.buttonClrBdShort);
		this.groupBox20.Controls.Add(this.label37);
		this.groupBox20.Location = new Point(10, 11);
		this.groupBox20.Name = "groupBox20";
		this.groupBox20.Size = new System.Drawing.Size(878, 53);
		this.groupBox20.TabIndex = 0;
		this.groupBox20.TabStop = false;
		this.groupBox20.Text = "短链转换";
		this.buttonCopyShortUrl.Location = new Point(750, 18);
		this.buttonCopyShortUrl.Name = "buttonCopyShortUrl";
		this.buttonCopyShortUrl.Size = new System.Drawing.Size(46, 23);
		this.buttonCopyShortUrl.TabIndex = 3;
		this.buttonCopyShortUrl.Text = "复制";
		this.buttonCopyShortUrl.UseVisualStyleBackColor = true;
		this.buttonCopyShortUrl.Click += new EventHandler(this.buttonCopyShortUrl_Click);
		this.buttonShortUrl.Location = new Point(349, 18);
		this.buttonShortUrl.Name = "buttonShortUrl";
		this.buttonShortUrl.Size = new System.Drawing.Size(46, 23);
		this.buttonShortUrl.TabIndex = 2;
		this.buttonShortUrl.Text = "转换";
		this.buttonShortUrl.UseVisualStyleBackColor = true;
		this.buttonShortUrl.Click += new EventHandler(this.buttonShortUrl_Click);
		this.textBoxShortUrl.Location = new Point(500, 20);
		this.textBoxShortUrl.Name = "textBoxShortUrl";
		this.textBoxShortUrl.ReadOnly = true;
		this.textBoxShortUrl.Size = new System.Drawing.Size(235, 21);
		this.textBoxShortUrl.TabIndex = 4;
		this.label38.AutoSize = true;
		this.label38.Location = new Point(454, 23);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(53, 12);
		this.label38.TabIndex = 3;
		this.label38.Text = "短网址：";
		this.textBoxOrgUrl.Location = new Point(52, 20);
		this.textBoxOrgUrl.Name = "textBoxOrgUrl";
		this.textBoxOrgUrl.Size = new System.Drawing.Size(280, 21);
		this.textBoxOrgUrl.TabIndex = 2;
		this.buttonClrBdShort.Location = new Point(401, 18);
		this.buttonClrBdShort.Name = "buttonClrBdShort";
		this.buttonClrBdShort.Size = new System.Drawing.Size(47, 23);
		this.buttonClrBdShort.TabIndex = 1;
		this.buttonClrBdShort.Text = "清空";
		this.buttonClrBdShort.UseVisualStyleBackColor = true;
		this.buttonClrBdShort.Click += new EventHandler(this.buttonClrBdShort_Click);
		this.label37.AutoSize = true;
		this.label37.Location = new Point(6, 23);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(53, 12);
		this.label37.TabIndex = 1;
		this.label37.Text = "原网址：";
		this.tabPageQQGrpMng.Controls.Add(this.groupBox33);
		this.tabPageQQGrpMng.Controls.Add(this.groupBox32);
		this.tabPageQQGrpMng.Controls.Add(this.groupBox31);
		this.tabPageQQGrpMng.Location = new Point(4, 29);
		this.tabPageQQGrpMng.Name = "tabPageQQGrpMng";
		this.tabPageQQGrpMng.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageQQGrpMng.Size = new System.Drawing.Size(1253, 531);
		this.tabPageQQGrpMng.TabIndex = 9;
		this.tabPageQQGrpMng.Text = "QQ群捉奸";
		this.tabPageQQGrpMng.UseVisualStyleBackColor = true;
		this.groupBox33.Controls.Add(this.textBoxSchQQ);
		this.groupBox33.Controls.Add(this.dataGridViewSchQQGrpMember);
		this.groupBox33.Controls.Add(this.buttonSchQQ);
		this.groupBox33.Controls.Add(this.buttonExpQQGrp);
		this.groupBox33.Location = new Point(841, 7);
		this.groupBox33.Name = "groupBox33";
		this.groupBox33.Size = new System.Drawing.Size(406, 518);
		this.groupBox33.TabIndex = 16;
		this.groupBox33.TabStop = false;
		this.groupBox33.Text = "QQ搜索";
		this.textBoxSchQQ.Location = new Point(41, 20);
		this.textBoxSchQQ.Name = "textBoxSchQQ";
		this.textBoxSchQQ.Size = new System.Drawing.Size(100, 21);
		this.textBoxSchQQ.TabIndex = 6;
		this.dataGridViewSchQQGrpMember.AllowUserToAddRows = false;
		this.dataGridViewSchQQGrpMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewSchQQGrpMember.Location = new Point(6, 49);
		this.dataGridViewSchQQGrpMember.Name = "dataGridViewSchQQGrpMember";
		this.dataGridViewSchQQGrpMember.RowHeadersWidth = 60;
		this.dataGridViewSchQQGrpMember.RowTemplate.Height = 23;
		this.dataGridViewSchQQGrpMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewSchQQGrpMember.Size = new System.Drawing.Size(394, 458);
		this.dataGridViewSchQQGrpMember.TabIndex = 3;
		this.buttonSchQQ.Location = new Point(147, 18);
		this.buttonSchQQ.Name = "buttonSchQQ";
		this.buttonSchQQ.Size = new System.Drawing.Size(75, 23);
		this.buttonSchQQ.TabIndex = 7;
		this.buttonSchQQ.Text = "查询QQ";
		this.buttonSchQQ.UseVisualStyleBackColor = true;
		this.buttonSchQQ.Click += new EventHandler(this.buttonSchQQ_Click);
		this.buttonExpQQGrp.Location = new Point(305, 18);
		this.buttonExpQQGrp.Name = "buttonExpQQGrp";
		this.buttonExpQQGrp.Size = new System.Drawing.Size(75, 23);
		this.buttonExpQQGrp.TabIndex = 8;
		this.buttonExpQQGrp.Text = "导出QQ群";
		this.buttonExpQQGrp.UseVisualStyleBackColor = true;
		this.buttonExpQQGrp.Click += new EventHandler(this.buttonExpQQGrp_Click);
		this.groupBox32.Controls.Add(this.checkBoxIsTaoke);
		this.groupBox32.Controls.Add(this.dataGridViewQQGroup);
		this.groupBox32.Controls.Add(this.checkBoxChkAllQQGrp);
		this.groupBox32.Controls.Add(this.buttonSynQQGrpMember);
		this.groupBox32.Controls.Add(this.buttonLoginQQ);
		this.groupBox32.Location = new Point(6, 6);
		this.groupBox32.Name = "groupBox32";
		this.groupBox32.Size = new System.Drawing.Size(455, 519);
		this.groupBox32.TabIndex = 16;
		this.groupBox32.TabStop = false;
		this.groupBox32.Text = "全部QQ群";
		this.checkBoxIsTaoke.AutoSize = true;
		this.checkBoxIsTaoke.Location = new Point(317, 25);
		this.checkBoxIsTaoke.Name = "checkBoxIsTaoke";
		this.checkBoxIsTaoke.Size = new System.Drawing.Size(132, 16);
		this.checkBoxIsTaoke.TabIndex = 19;
		this.checkBoxIsTaoke.Text = "同步时查询是否淘客";
		this.checkBoxIsTaoke.UseVisualStyleBackColor = true;
		this.dataGridViewQQGroup.AllowUserToAddRows = false;
		this.dataGridViewQQGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewQQGroup.Location = new Point(6, 55);
		this.dataGridViewQQGroup.Name = "dataGridViewQQGroup";
		this.dataGridViewQQGroup.RowHeadersWidth = 60;
		this.dataGridViewQQGroup.RowTemplate.Height = 23;
		this.dataGridViewQQGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewQQGroup.Size = new System.Drawing.Size(443, 453);
		this.dataGridViewQQGroup.TabIndex = 1;
		this.checkBoxChkAllQQGrp.AutoSize = true;
		this.checkBoxChkAllQQGrp.Location = new Point(401, 0);
		this.checkBoxChkAllQQGrp.Name = "checkBoxChkAllQQGrp";
		this.checkBoxChkAllQQGrp.Size = new System.Drawing.Size(48, 16);
		this.checkBoxChkAllQQGrp.TabIndex = 18;
		this.checkBoxChkAllQQGrp.Text = "全选";
		this.checkBoxChkAllQQGrp.UseVisualStyleBackColor = true;
		this.checkBoxChkAllQQGrp.CheckedChanged += new EventHandler(this.checkBoxChkAllQQGrp_CheckedChanged);
		this.buttonSynQQGrpMember.Location = new Point(200, 14);
		this.buttonSynQQGrpMember.Name = "buttonSynQQGrpMember";
		this.buttonSynQQGrpMember.Size = new System.Drawing.Size(83, 35);
		this.buttonSynQQGrpMember.TabIndex = 4;
		this.buttonSynQQGrpMember.Text = "同步QQ";
		this.buttonSynQQGrpMember.UseVisualStyleBackColor = true;
		this.buttonSynQQGrpMember.Click += new EventHandler(this.buttonSynQQGrpMember_Click);
		this.buttonLoginQQ.Location = new Point(88, 15);
		this.buttonLoginQQ.Name = "buttonLoginQQ";
		this.buttonLoginQQ.Size = new System.Drawing.Size(91, 35);
		this.buttonLoginQQ.TabIndex = 0;
		this.buttonLoginQQ.Text = "手动登录QQ";
		this.buttonLoginQQ.UseVisualStyleBackColor = true;
		this.buttonLoginQQ.Click += new EventHandler(this.buttonLoginQQ_Click);
		this.groupBox31.Controls.Add(this.buttonSchLclTaokeQQ);
		this.groupBox31.Controls.Add(this.buttonLoadTaokeData);
		this.groupBox31.Controls.Add(this.buttonExpAllQQ);
		this.groupBox31.Controls.Add(this.dataGridViewQQGrpMember);
		this.groupBox31.Controls.Add(this.checkBoxAllTaokeQQ);
		this.groupBox31.Controls.Add(this.checkBoxAllQQ);
		this.groupBox31.Location = new Point(467, 7);
		this.groupBox31.Name = "groupBox31";
		this.groupBox31.Size = new System.Drawing.Size(368, 518);
		this.groupBox31.TabIndex = 14;
		this.groupBox31.TabStop = false;
		this.groupBox31.Text = "全部QQ号";
		this.buttonSchLclTaokeQQ.Location = new Point(102, 20);
		this.buttonSchLclTaokeQQ.Name = "buttonSchLclTaokeQQ";
		this.buttonSchLclTaokeQQ.Size = new System.Drawing.Size(115, 23);
		this.buttonSchLclTaokeQQ.TabIndex = 15;
		this.buttonSchLclTaokeQQ.Text = "查询本地淘客数据";
		this.buttonSchLclTaokeQQ.UseVisualStyleBackColor = true;
		this.buttonSchLclTaokeQQ.Click += new EventHandler(this.buttonSchLclTaokeQQ_Click);
		this.buttonLoadTaokeData.Location = new Point(6, 20);
		this.buttonLoadTaokeData.Name = "buttonLoadTaokeData";
		this.buttonLoadTaokeData.Size = new System.Drawing.Size(90, 23);
		this.buttonLoadTaokeData.TabIndex = 14;
		this.buttonLoadTaokeData.Text = "导入淘客数据";
		this.buttonLoadTaokeData.UseVisualStyleBackColor = true;
		this.buttonLoadTaokeData.Click += new EventHandler(this.buttonLoadTaokeData_Click);
		this.buttonExpAllQQ.Location = new Point(272, 22);
		this.buttonExpAllQQ.Name = "buttonExpAllQQ";
		this.buttonExpAllQQ.Size = new System.Drawing.Size(75, 23);
		this.buttonExpAllQQ.TabIndex = 9;
		this.buttonExpAllQQ.Text = "导出选中QQ";
		this.buttonExpAllQQ.UseVisualStyleBackColor = true;
		this.buttonExpAllQQ.Click += new EventHandler(this.buttonExpAllQQ_Click);
		this.dataGridViewQQGrpMember.AllowUserToAddRows = false;
		this.dataGridViewQQGrpMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewQQGrpMember.Location = new Point(6, 54);
		this.dataGridViewQQGrpMember.Name = "dataGridViewQQGrpMember";
		this.dataGridViewQQGrpMember.RowHeadersWidth = 70;
		this.dataGridViewQQGrpMember.RowTemplate.Height = 23;
		this.dataGridViewQQGrpMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewQQGrpMember.Size = new System.Drawing.Size(356, 453);
		this.dataGridViewQQGrpMember.TabIndex = 2;
		this.dataGridViewQQGrpMember.Click += new EventHandler(this.dataGridViewQQGrpMember_Click);
		this.checkBoxAllTaokeQQ.AutoSize = true;
		this.checkBoxAllTaokeQQ.Location = new Point(282, 0);
		this.checkBoxAllTaokeQQ.Name = "checkBoxAllTaokeQQ";
		this.checkBoxAllTaokeQQ.Size = new System.Drawing.Size(84, 16);
		this.checkBoxAllTaokeQQ.TabIndex = 12;
		this.checkBoxAllTaokeQQ.Text = "全选淘客QQ";
		this.checkBoxAllTaokeQQ.UseVisualStyleBackColor = true;
		this.checkBoxAllTaokeQQ.CheckedChanged += new EventHandler(this.checkBoxAllTaokeQQ_CheckedChanged);
		this.checkBoxAllQQ.AutoSize = true;
		this.checkBoxAllQQ.Location = new Point(228, 0);
		this.checkBoxAllQQ.Name = "checkBoxAllQQ";
		this.checkBoxAllQQ.Size = new System.Drawing.Size(48, 16);
		this.checkBoxAllQQ.TabIndex = 13;
		this.checkBoxAllQQ.Text = "全选";
		this.checkBoxAllQQ.UseVisualStyleBackColor = true;
		this.checkBoxAllQQ.CheckedChanged += new EventHandler(this.checkBoxAllQQ_CheckedChanged);
		this.tabPageQQGrpInvite.Controls.Add(this.groupBox36);
		this.tabPageQQGrpInvite.Controls.Add(this.groupBox34);
		this.tabPageQQGrpInvite.Controls.Add(this.dataGridViewQQGrpInvite);
		this.tabPageQQGrpInvite.Location = new Point(4, 29);
		this.tabPageQQGrpInvite.Name = "tabPageQQGrpInvite";
		this.tabPageQQGrpInvite.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageQQGrpInvite.Size = new System.Drawing.Size(1253, 531);
		this.tabPageQQGrpInvite.TabIndex = 10;
		this.tabPageQQGrpInvite.Text = "QQ群邀请";
		this.tabPageQQGrpInvite.UseVisualStyleBackColor = true;
		this.groupBox36.Controls.Add(this.textBoxVipTryQQ);
		this.groupBox36.Controls.Add(this.buttonSchVipTry);
		this.groupBox36.Controls.Add(this.label82);
		this.groupBox36.Controls.Add(this.buttonVipTry);
		this.groupBox36.Location = new Point(1103, 6);
		this.groupBox36.Name = "groupBox36";
		this.groupBox36.Size = new System.Drawing.Size(142, 130);
		this.groupBox36.TabIndex = 13;
		this.groupBox36.TabStop = false;
		this.groupBox36.Text = "VIP试用权限查询";
		this.textBoxVipTryQQ.Location = new Point(26, 22);
		this.textBoxVipTryQQ.Name = "textBoxVipTryQQ";
		this.textBoxVipTryQQ.Size = new System.Drawing.Size(101, 21);
		this.textBoxVipTryQQ.TabIndex = 15;
		this.buttonSchVipTry.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSchVipTry.Location = new Point(13, 58);
		this.buttonSchVipTry.Name = "buttonSchVipTry";
		this.buttonSchVipTry.Size = new System.Drawing.Size(123, 32);
		this.buttonSchVipTry.TabIndex = 11;
		this.buttonSchVipTry.Text = "查询邀请";
		this.buttonSchVipTry.UseVisualStyleBackColor = true;
		this.buttonSchVipTry.Click += new EventHandler(this.buttonSchVipTry_Click);
		this.label82.AutoSize = true;
		this.label82.Location = new Point(6, 26);
		this.label82.Name = "label82";
		this.label82.Size = new System.Drawing.Size(29, 12);
		this.label82.TabIndex = 14;
		this.label82.Text = "QQ：";
		this.buttonVipTry.Enabled = false;
		this.buttonVipTry.Location = new Point(13, 96);
		this.buttonVipTry.Name = "buttonVipTry";
		this.buttonVipTry.Size = new System.Drawing.Size(123, 23);
		this.buttonVipTry.TabIndex = 12;
		this.buttonVipTry.Text = "开通VIP试用权限";
		this.buttonVipTry.UseVisualStyleBackColor = true;
		this.buttonVipTry.Click += new EventHandler(this.buttonVipTry_Click);
		this.groupBox34.Controls.Add(this.buttonSetQQGroup);
		this.groupBox34.Controls.Add(this.comboBoxQQGroup);
		this.groupBox34.Controls.Add(this.buttonClrQQGrpInvite);
		this.groupBox34.Controls.Add(this.textBoxQQ);
		this.groupBox34.Controls.Add(this.buttonSchQQInvite);
		this.groupBox34.Controls.Add(this.label67);
		this.groupBox34.Controls.Add(this.textBoxQQInvite);
		this.groupBox34.Controls.Add(this.label68);
		this.groupBox34.Controls.Add(this.label69);
		this.groupBox34.Location = new Point(154, 6);
		this.groupBox34.Name = "groupBox34";
		this.groupBox34.Size = new System.Drawing.Size(940, 56);
		this.groupBox34.TabIndex = 9;
		this.groupBox34.TabStop = false;
		this.buttonSetQQGroup.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSetQQGroup.Location = new Point(778, 15);
		this.buttonSetQQGroup.Name = "buttonSetQQGroup";
		this.buttonSetQQGroup.Size = new System.Drawing.Size(73, 32);
		this.buttonSetQQGroup.TabIndex = 13;
		this.buttonSetQQGroup.Text = "设置QQ群";
		this.buttonSetQQGroup.UseVisualStyleBackColor = true;
		this.buttonSetQQGroup.Click += new EventHandler(this.buttonSetQQGroup_Click);
		this.comboBoxQQGroup.FormattingEnabled = true;
		this.comboBoxQQGroup.Location = new Point(91, 22);
		this.comboBoxQQGroup.Name = "comboBoxQQGroup";
		this.comboBoxQQGroup.Size = new System.Drawing.Size(204, 20);
		this.comboBoxQQGroup.TabIndex = 12;
		this.buttonClrQQGrpInvite.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClrQQGrpInvite.Location = new Point(712, 15);
		this.buttonClrQQGrpInvite.Name = "buttonClrQQGrpInvite";
		this.buttonClrQQGrpInvite.Size = new System.Drawing.Size(48, 32);
		this.buttonClrQQGrpInvite.TabIndex = 7;
		this.buttonClrQQGrpInvite.Text = "清空";
		this.buttonClrQQGrpInvite.UseVisualStyleBackColor = true;
		this.buttonClrQQGrpInvite.Click += new EventHandler(this.buttonClrQQGrpInvite_Click);
		this.textBoxQQ.Location = new Point(529, 22);
		this.textBoxQQ.Name = "textBoxQQ";
		this.textBoxQQ.Size = new System.Drawing.Size(100, 21);
		this.textBoxQQ.TabIndex = 4;
		this.buttonSchQQInvite.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSchQQInvite.Location = new Point(643, 15);
		this.buttonSchQQInvite.Name = "buttonSchQQInvite";
		this.buttonSchQQInvite.Size = new System.Drawing.Size(50, 32);
		this.buttonSchQQInvite.TabIndex = 0;
		this.buttonSchQQInvite.Text = "搜索";
		this.buttonSchQQInvite.UseVisualStyleBackColor = true;
		this.buttonSchQQInvite.Click += new EventHandler(this.buttonSchQQInvite_Click);
		this.label67.AutoSize = true;
		this.label67.Location = new Point(58, 25);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(41, 12);
		this.label67.TabIndex = 1;
		this.label67.Text = "QQ群：";
		this.textBoxQQInvite.Location = new Point(349, 22);
		this.textBoxQQInvite.Name = "textBoxQQInvite";
		this.textBoxQQInvite.Size = new System.Drawing.Size(111, 21);
		this.textBoxQQInvite.TabIndex = 6;
		this.label68.AutoSize = true;
		this.label68.Location = new Point(304, 26);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(53, 12);
		this.label68.TabIndex = 5;
		this.label68.Text = "邀请者：";
		this.label69.AutoSize = true;
		this.label69.Location = new Point(471, 26);
		this.label69.Name = "label69";
		this.label69.Size = new System.Drawing.Size(65, 12);
		this.label69.TabIndex = 3;
		this.label69.Text = "QQ群成员：";
		this.dataGridViewQQGrpInvite.AllowUserToAddRows = false;
		this.dataGridViewQQGrpInvite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewQQGrpInvite.Location = new Point(154, 69);
		this.dataGridViewQQGrpInvite.Name = "dataGridViewQQGrpInvite";
		this.dataGridViewQQGrpInvite.RowHeadersWidth = 80;
		this.dataGridViewQQGrpInvite.RowTemplate.Height = 23;
		this.dataGridViewQQGrpInvite.Size = new System.Drawing.Size(940, 456);
		this.dataGridViewQQGrpInvite.TabIndex = 10;
		this.tabPageOdrPoi.Controls.Add(this.groupBox35);
		this.tabPageOdrPoi.Controls.Add(this.dataGridViewAliOdrPoi);
		this.tabPageOdrPoi.Location = new Point(4, 29);
		this.tabPageOdrPoi.Name = "tabPageOdrPoi";
		this.tabPageOdrPoi.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageOdrPoi.Size = new System.Drawing.Size(1253, 531);
		this.tabPageOdrPoi.TabIndex = 11;
		this.tabPageOdrPoi.Text = "订单积分";
		this.tabPageOdrPoi.UseVisualStyleBackColor = true;
		this.groupBox35.Controls.Add(this.buttonOdrPoiSort);
		this.groupBox35.Controls.Add(this.label104);
		this.groupBox35.Controls.Add(this.checkBoxOdrDate);
		this.groupBox35.Controls.Add(this.dateTimePickerOdrPoiEndDate);
		this.groupBox35.Controls.Add(this.label102);
		this.groupBox35.Controls.Add(this.dateTimePickerOdrPoiSttDate);
		this.groupBox35.Controls.Add(this.label103);
		this.groupBox35.Controls.Add(this.buttonClrOdrPoi);
		this.groupBox35.Controls.Add(this.textBoxSchOdrPid);
		this.groupBox35.Controls.Add(this.buttonSch);
		this.groupBox35.Controls.Add(this.textBoxSchAliOdrPoi);
		this.groupBox35.Controls.Add(this.label78);
		this.groupBox35.Controls.Add(this.textBoxOdrSchQQNum);
		this.groupBox35.Controls.Add(this.label79);
		this.groupBox35.Controls.Add(this.label80);
		this.groupBox35.Location = new Point(62, 5);
		this.groupBox35.Name = "groupBox35";
		this.groupBox35.Size = new System.Drawing.Size(1131, 71);
		this.groupBox35.TabIndex = 59;
		this.groupBox35.TabStop = false;
		this.groupBox35.Text = "查询条件";
		this.buttonOdrPoiSort.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonOdrPoiSort.Location = new Point(876, 21);
		this.buttonOdrPoiSort.Name = "buttonOdrPoiSort";
		this.buttonOdrPoiSort.Size = new System.Drawing.Size(137, 28);
		this.buttonOdrPoiSort.TabIndex = 83;
		this.buttonOdrPoiSort.Text = "积分排行榜";
		this.buttonOdrPoiSort.UseVisualStyleBackColor = true;
		this.buttonOdrPoiSort.Click += new EventHandler(this.buttonOdrPoiSort_Click);
		this.label104.AutoSize = true;
		this.label104.Location = new Point(882, 49);
		this.label104.Name = "label104";
		this.label104.Size = new System.Drawing.Size(113, 12);
		this.label104.TabIndex = 84;
		this.label104.Text = "(根据日期范围排行)";
		this.checkBoxOdrDate.AutoSize = true;
		this.checkBoxOdrDate.Location = new Point(644, 53);
		this.checkBoxOdrDate.Name = "checkBoxOdrDate";
		this.checkBoxOdrDate.Size = new System.Drawing.Size(84, 16);
		this.checkBoxOdrDate.TabIndex = 82;
		this.checkBoxOdrDate.Text = "按日期查询";
		this.checkBoxOdrDate.UseVisualStyleBackColor = true;
		this.dateTimePickerOdrPoiEndDate.Location = new Point(189, 41);
		this.dateTimePickerOdrPoiEndDate.Name = "dateTimePickerOdrPoiEndDate";
		this.dateTimePickerOdrPoiEndDate.Size = new System.Drawing.Size(104, 21);
		this.dateTimePickerOdrPoiEndDate.TabIndex = 79;
		this.label102.AutoSize = true;
		this.label102.Location = new Point(128, 44);
		this.label102.Name = "label102";
		this.label102.Size = new System.Drawing.Size(65, 12);
		this.label102.TabIndex = 81;
		this.label102.Text = "结束日期：";
		this.dateTimePickerOdrPoiSttDate.Location = new Point(189, 18);
		this.dateTimePickerOdrPoiSttDate.Name = "dateTimePickerOdrPoiSttDate";
		this.dateTimePickerOdrPoiSttDate.Size = new System.Drawing.Size(104, 21);
		this.dateTimePickerOdrPoiSttDate.TabIndex = 80;
		this.label103.AutoSize = true;
		this.label103.Location = new Point(128, 21);
		this.label103.Name = "label103";
		this.label103.Size = new System.Drawing.Size(65, 12);
		this.label103.TabIndex = 78;
		this.label103.Text = "开始日期：";
		this.buttonClrOdrPoi.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClrOdrPoi.Location = new Point(760, 21);
		this.buttonClrOdrPoi.Name = "buttonClrOdrPoi";
		this.buttonClrOdrPoi.Size = new System.Drawing.Size(104, 28);
		this.buttonClrOdrPoi.TabIndex = 57;
		this.buttonClrOdrPoi.Text = "清空";
		this.buttonClrOdrPoi.UseVisualStyleBackColor = true;
		this.buttonClrOdrPoi.Click += new EventHandler(this.buttonClrOdrPoi_Click);
		this.textBoxSchOdrPid.Location = new Point(354, 41);
		this.textBoxSchOdrPid.Name = "textBoxSchOdrPid";
		this.textBoxSchOdrPid.Size = new System.Drawing.Size(115, 21);
		this.textBoxSchOdrPid.TabIndex = 54;
		this.buttonSch.Font = new System.Drawing.Font("SimSun", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSch.Location = new Point(638, 21);
		this.buttonSch.Name = "buttonSch";
		this.buttonSch.Size = new System.Drawing.Size(111, 28);
		this.buttonSch.TabIndex = 50;
		this.buttonSch.Text = "查询";
		this.buttonSch.UseVisualStyleBackColor = true;
		this.buttonSch.Click += new EventHandler(this.buttonSch_Click);
		this.textBoxSchAliOdrPoi.Location = new Point(355, 16);
		this.textBoxSchAliOdrPoi.Name = "textBoxSchAliOdrPoi";
		this.textBoxSchAliOdrPoi.Size = new System.Drawing.Size(244, 21);
		this.textBoxSchAliOdrPoi.TabIndex = 52;
		this.label78.AutoSize = true;
		this.label78.Location = new Point(307, 21);
		this.label78.Name = "label78";
		this.label78.Size = new System.Drawing.Size(53, 12);
		this.label78.TabIndex = 51;
		this.label78.Text = "订单号：";
		this.textBoxOdrSchQQNum.Location = new Point(511, 41);
		this.textBoxOdrSchQQNum.Name = "textBoxOdrSchQQNum";
		this.textBoxOdrSchQQNum.Size = new System.Drawing.Size(88, 21);
		this.textBoxOdrSchQQNum.TabIndex = 56;
		this.label79.AutoSize = true;
		this.label79.Location = new Point(475, 45);
		this.label79.Name = "label79";
		this.label79.Size = new System.Drawing.Size(41, 12);
		this.label79.TabIndex = 55;
		this.label79.Text = "QQ号：";
		this.label80.AutoSize = true;
		this.label80.Location = new Point(307, 45);
		this.label80.Name = "label80";
		this.label80.Size = new System.Drawing.Size(53, 12);
		this.label80.TabIndex = 53;
		this.label80.Text = "产品ID：";
		this.dataGridViewAliOdrPoi.AllowUserToAddRows = false;
		this.dataGridViewAliOdrPoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewAliOdrPoi.Location = new Point(62, 82);
		this.dataGridViewAliOdrPoi.Name = "dataGridViewAliOdrPoi";
		this.dataGridViewAliOdrPoi.RowHeadersWidth = 60;
		this.dataGridViewAliOdrPoi.RowTemplate.Height = 23;
		this.dataGridViewAliOdrPoi.Size = new System.Drawing.Size(1131, 443);
		this.dataGridViewAliOdrPoi.TabIndex = 58;
		this.tabPageUserMng.Controls.Add(this.dataGridViewRtnFundUser);
		this.tabPageUserMng.Controls.Add(this.groupBox7);
		this.tabPageUserMng.Location = new Point(4, 29);
		this.tabPageUserMng.Name = "tabPageUserMng";
		this.tabPageUserMng.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageUserMng.Size = new System.Drawing.Size(1253, 531);
		this.tabPageUserMng.TabIndex = 12;
		this.tabPageUserMng.Text = "用户管理";
		this.tabPageUserMng.UseVisualStyleBackColor = true;
		this.dataGridViewRtnFundUser.AllowUserToAddRows = false;
		this.dataGridViewRtnFundUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewRtnFundUser.ContextMenuStrip = this.contextMenuStripOdrPoi;
		this.dataGridViewRtnFundUser.Location = new Point(89, 74);
		this.dataGridViewRtnFundUser.Name = "dataGridViewRtnFundUser";
		this.dataGridViewRtnFundUser.RowHeadersWidth = 60;
		this.dataGridViewRtnFundUser.RowTemplate.Height = 23;
		this.dataGridViewRtnFundUser.Size = new System.Drawing.Size(1071, 451);
		this.dataGridViewRtnFundUser.TabIndex = 17;
		this.dataGridViewRtnFundUser.DoubleClick += new EventHandler(this.dataGridViewRtnFundUser_DoubleClick);
		this.dataGridViewRtnFundUser.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewRtnFundUser_CellMouseDown);
		this.dataGridViewRtnFundUser.Click += new EventHandler(this.dataGridViewRtnFundUser_Click);
		this.contextMenuStripOdrPoi.Name = "contextMenuStripOdrPoi";
		this.contextMenuStripOdrPoi.Size = new System.Drawing.Size(61, 4);
		this.contextMenuStripOdrPoi.Opening += new CancelEventHandler(this.contextMenuStripOdrPoi_Opening);
		this.groupBox7.Controls.Add(this.buttonSchUserAddPoi);
		this.groupBox7.Controls.Add(this.buttonAddUserPoi);
		this.groupBox7.Controls.Add(this.textBoxRefundQQ);
		this.groupBox7.Controls.Add(this.label81);
		this.groupBox7.Controls.Add(this.textBoxRefundRemark);
		this.groupBox7.Controls.Add(this.textBoxRefundAmount);
		this.groupBox7.Controls.Add(this.buttonBatchRefund);
		this.groupBox7.Controls.Add(this.label77);
		this.groupBox7.Controls.Add(this.label76);
		this.groupBox7.Controls.Add(this.buttonRefund);
		this.groupBox7.Controls.Add(this.textBoxSchRefundHisQQ);
		this.groupBox7.Controls.Add(this.label75);
		this.groupBox7.Controls.Add(this.buttonSchRefundHis);
		this.groupBox7.Controls.Add(this.buttonSchQQUser);
		this.groupBox7.Controls.Add(this.buttonClrUser);
		this.groupBox7.Controls.Add(this.label73);
		this.groupBox7.Controls.Add(this.textBoxUserSchQQ);
		this.groupBox7.Controls.Add(this.label74);
		this.groupBox7.Location = new Point(89, 10);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(1071, 58);
		this.groupBox7.TabIndex = 16;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "搜索用户";
		this.buttonSchUserAddPoi.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSchUserAddPoi.Location = new Point(223, 16);
		this.buttonSchUserAddPoi.Name = "buttonSchUserAddPoi";
		this.buttonSchUserAddPoi.Size = new System.Drawing.Size(86, 30);
		this.buttonSchUserAddPoi.TabIndex = 85;
		this.buttonSchUserAddPoi.Text = "搜加积分";
		this.buttonSchUserAddPoi.UseVisualStyleBackColor = true;
		this.buttonSchUserAddPoi.Click += new EventHandler(this.buttonSchUserAddPoi_Click);
		this.buttonAddUserPoi.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonAddUserPoi.Location = new Point(988, 16);
		this.buttonAddUserPoi.Name = "buttonAddUserPoi";
		this.buttonAddUserPoi.Size = new System.Drawing.Size(77, 30);
		this.buttonAddUserPoi.TabIndex = 84;
		this.buttonAddUserPoi.Text = "加积分";
		this.buttonAddUserPoi.UseVisualStyleBackColor = true;
		this.buttonAddUserPoi.Click += new EventHandler(this.buttonAddUserPoi_Click);
		this.textBoxRefundQQ.Location = new Point(765, 10);
		this.textBoxRefundQQ.Name = "textBoxRefundQQ";
		this.textBoxRefundQQ.Size = new System.Drawing.Size(72, 21);
		this.textBoxRefundQQ.TabIndex = 83;
		this.label81.AutoSize = true;
		this.label81.Location = new Point(732, 13);
		this.label81.Name = "label81";
		this.label81.Size = new System.Drawing.Size(41, 12);
		this.label81.TabIndex = 82;
		this.label81.Text = "Q  Q：";
		this.textBoxRefundRemark.Location = new Point(765, 33);
		this.textBoxRefundRemark.Name = "textBoxRefundRemark";
		this.textBoxRefundRemark.Size = new System.Drawing.Size(159, 21);
		this.textBoxRefundRemark.TabIndex = 81;
		this.textBoxRefundAmount.Location = new Point(888, 10);
		this.textBoxRefundAmount.Name = "textBoxRefundAmount";
		this.textBoxRefundAmount.Size = new System.Drawing.Size(35, 21);
		this.textBoxRefundAmount.TabIndex = 79;
		this.buttonBatchRefund.Enabled = false;
		this.buttonBatchRefund.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonBatchRefund.Location = new Point(616, 16);
		this.buttonBatchRefund.Name = "buttonBatchRefund";
		this.buttonBatchRefund.Size = new System.Drawing.Size(86, 30);
		this.buttonBatchRefund.TabIndex = 69;
		this.buttonBatchRefund.Text = "批量返现";
		this.buttonBatchRefund.UseVisualStyleBackColor = true;
		this.buttonBatchRefund.Click += new EventHandler(this.buttonBatchRefund_Click);
		this.label77.AutoSize = true;
		this.label77.Location = new Point(732, 36);
		this.label77.Name = "label77";
		this.label77.Size = new System.Drawing.Size(41, 12);
		this.label77.TabIndex = 80;
		this.label77.Text = "备注：";
		this.label76.AutoSize = true;
		this.label76.Location = new Point(841, 13);
		this.label76.Name = "label76";
		this.label76.Size = new System.Drawing.Size(53, 12);
		this.label76.TabIndex = 78;
		this.label76.Text = "积分数：";
		this.buttonRefund.Enabled = false;
		this.buttonRefund.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonRefund.Location = new Point(929, 16);
		this.buttonRefund.Name = "buttonRefund";
		this.buttonRefund.Size = new System.Drawing.Size(53, 30);
		this.buttonRefund.TabIndex = 77;
		this.buttonRefund.Text = "返现";
		this.buttonRefund.UseVisualStyleBackColor = true;
		this.buttonRefund.Click += new EventHandler(this.buttonRefund_Click);
		this.textBoxSchRefundHisQQ.Location = new Point(45, 21);
		this.textBoxSchRefundHisQQ.Name = "textBoxSchRefundHisQQ";
		this.textBoxSchRefundHisQQ.Size = new System.Drawing.Size(88, 21);
		this.textBoxSchRefundHisQQ.TabIndex = 72;
		this.label75.AutoSize = true;
		this.label75.Location = new Point(8, 24);
		this.label75.Name = "label75";
		this.label75.Size = new System.Drawing.Size(41, 12);
		this.label75.TabIndex = 71;
		this.label75.Text = "QQ号：";
		this.buttonSchRefundHis.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSchRefundHis.Location = new Point(143, 16);
		this.buttonSchRefundHis.Name = "buttonSchRefundHis";
		this.buttonSchRefundHis.Size = new System.Drawing.Size(74, 30);
		this.buttonSchRefundHis.TabIndex = 70;
		this.buttonSchRefundHis.Text = "搜返现";
		this.buttonSchRefundHis.UseVisualStyleBackColor = true;
		this.buttonSchRefundHis.Click += new EventHandler(this.buttonSchRefundHis_Click);
		this.buttonSchQQUser.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSchQQUser.Location = new Point(471, 16);
		this.buttonSchQQUser.Name = "buttonSchQQUser";
		this.buttonSchQQUser.Size = new System.Drawing.Size(67, 30);
		this.buttonSchQQUser.TabIndex = 68;
		this.buttonSchQQUser.Text = "搜用户";
		this.buttonSchQQUser.UseVisualStyleBackColor = true;
		this.buttonSchQQUser.Click += new EventHandler(this.buttonSchQQUser_Click);
		this.buttonClrUser.Font = new System.Drawing.Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClrUser.Location = new Point(546, 16);
		this.buttonClrUser.Name = "buttonClrUser";
		this.buttonClrUser.Size = new System.Drawing.Size(61, 30);
		this.buttonClrUser.TabIndex = 50;
		this.buttonClrUser.Text = "清空";
		this.buttonClrUser.UseVisualStyleBackColor = true;
		this.buttonClrUser.Click += new EventHandler(this.buttonClrUser_Click);
		this.label73.AutoSize = true;
		this.label73.Location = new Point(422, 57);
		this.label73.Name = "label73";
		this.label73.Size = new System.Drawing.Size(0, 12);
		this.label73.TabIndex = 49;
		this.textBoxUserSchQQ.Location = new Point(358, 21);
		this.textBoxUserSchQQ.Name = "textBoxUserSchQQ";
		this.textBoxUserSchQQ.Size = new System.Drawing.Size(102, 21);
		this.textBoxUserSchQQ.TabIndex = 8;
		this.label74.AutoSize = true;
		this.label74.Location = new Point(321, 24);
		this.label74.Name = "label74";
		this.label74.Size = new System.Drawing.Size(41, 12);
		this.label74.TabIndex = 7;
		this.label74.Text = "QQ号：";
		this.tabPageSetUp.Controls.Add(this.checkBoxAdd1212);
		this.tabPageSetUp.Controls.Add(this.groupBox41);
		this.tabPageSetUp.Controls.Add(this.groupBox40);
		this.tabPageSetUp.Controls.Add(this.groupBoxQyAdmin);
		this.tabPageSetUp.Controls.Add(this.groupBox1);
		this.tabPageSetUp.Controls.Add(this.groupBox27);
		this.tabPageSetUp.Controls.Add(this.groupBox23);
		this.tabPageSetUp.Controls.Add(this.groupBox22);
		this.tabPageSetUp.Controls.Add(this.groupBox18);
		this.tabPageSetUp.Controls.Add(this.buttonSaveConfig);
		this.tabPageSetUp.Controls.Add(this.groupBox5);
		this.tabPageSetUp.Controls.Add(this.groupBox8);
		this.tabPageSetUp.Location = new Point(4, 29);
		this.tabPageSetUp.Name = "tabPageSetUp";
		this.tabPageSetUp.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageSetUp.Size = new System.Drawing.Size(1253, 531);
		this.tabPageSetUp.TabIndex = 2;
		this.tabPageSetUp.Text = "软件设置";
		this.tabPageSetUp.UseVisualStyleBackColor = true;
		this.checkBoxAdd1212.AutoSize = true;
		this.checkBoxAdd1212.Location = new Point(913, 280);
		this.checkBoxAdd1212.Name = "checkBoxAdd1212";
		this.checkBoxAdd1212.Size = new System.Drawing.Size(132, 16);
		this.checkBoxAdd1212.TabIndex = 59;
		this.checkBoxAdd1212.Text = "群发添加双12主会场";
		this.checkBoxAdd1212.UseVisualStyleBackColor = true;
		this.groupBox41.Controls.Add(this.checkBoxTempCInMdl);
		this.groupBox41.Controls.Add(this.checkBoxUseTemp);
		this.groupBox41.Controls.Add(this.label94);
		this.groupBox41.Controls.Add(this.buttonSetWxTemp);
		this.groupBox41.Location = new Point(913, 136);
		this.groupBox41.Name = "groupBox41";
		this.groupBox41.Size = new System.Drawing.Size(313, 114);
		this.groupBox41.TabIndex = 58;
		this.groupBox41.TabStop = false;
		this.groupBox41.Text = "发送模板设置";
		this.checkBoxTempCInMdl.AutoSize = true;
		this.checkBoxTempCInMdl.Location = new Point(139, 91);
		this.checkBoxTempCInMdl.Name = "checkBoxTempCInMdl";
		this.checkBoxTempCInMdl.Size = new System.Drawing.Size(36, 16);
		this.checkBoxTempCInMdl.TabIndex = 74;
		this.checkBoxTempCInMdl.Text = "是";
		this.checkBoxTempCInMdl.UseVisualStyleBackColor = true;
		this.checkBoxUseTemp.AutoSize = true;
		this.checkBoxUseTemp.Location = new Point(100, -1);
		this.checkBoxUseTemp.Name = "checkBoxUseTemp";
		this.checkBoxUseTemp.Size = new System.Drawing.Size(72, 16);
		this.checkBoxUseTemp.TabIndex = 57;
		this.checkBoxUseTemp.Text = "使用模板";
		this.checkBoxUseTemp.UseVisualStyleBackColor = true;
		this.label94.AutoSize = true;
		this.label94.Location = new Point(6, 92);
		this.label94.Name = "label94";
		this.label94.Size = new System.Drawing.Size(137, 12);
		this.label94.TabIndex = 73;
		this.label94.Text = "使用模版的内容放中间：";
		this.buttonSetWxTemp.Location = new Point(109, 31);
		this.buttonSetWxTemp.Name = "buttonSetWxTemp";
		this.buttonSetWxTemp.Size = new System.Drawing.Size(130, 43);
		this.buttonSetWxTemp.TabIndex = 56;
		this.buttonSetWxTemp.Text = "设置模版";
		this.buttonSetWxTemp.UseVisualStyleBackColor = true;
		this.buttonSetWxTemp.Click += new EventHandler(this.buttonSetWxTemp_Click);
		this.groupBox40.Controls.Add(this.checkBoxWxPromot);
		this.groupBox40.Controls.Add(this.linkLabelGetWeixinPromot);
		this.groupBox40.Controls.Add(this.comboBoxWxPPos);
		this.groupBox40.Controls.Add(this.comboBoxWxPUnit);
		this.groupBox40.Controls.Add(this.label89);
		this.groupBox40.Controls.Add(this.label91);
		this.groupBox40.Location = new Point(913, 16);
		this.groupBox40.Name = "groupBox40";
		this.groupBox40.Size = new System.Drawing.Size(313, 112);
		this.groupBox40.TabIndex = 54;
		this.groupBox40.TabStop = false;
		this.groupBox40.Text = "微信推广位设置";
		this.checkBoxWxPromot.AutoSize = true;
		this.checkBoxWxPromot.Location = new Point(203, -1);
		this.checkBoxWxPromot.Name = "checkBoxWxPromot";
		this.checkBoxWxPromot.Size = new System.Drawing.Size(96, 16);
		this.checkBoxWxPromot.TabIndex = 0;
		this.checkBoxWxPromot.Text = "微信推广模式";
		this.checkBoxWxPromot.UseVisualStyleBackColor = true;
		this.checkBoxWxPromot.CheckedChanged += new EventHandler(this.checkBoxWxPromot_CheckedChanged);
		this.linkLabelGetWeixinPromot.AutoSize = true;
		this.linkLabelGetWeixinPromot.LinkColor = Color.Red;
		this.linkLabelGetWeixinPromot.Location = new Point(104, 0);
		this.linkLabelGetWeixinPromot.Name = "linkLabelGetWeixinPromot";
		this.linkLabelGetWeixinPromot.Size = new System.Drawing.Size(89, 12);
		this.linkLabelGetWeixinPromot.TabIndex = 55;
		this.linkLabelGetWeixinPromot.TabStop = true;
		this.linkLabelGetWeixinPromot.Text = "获取微信推广位";
		this.linkLabelGetWeixinPromot.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelGetWeixinPromot_LinkClicked);
		this.comboBoxWxPPos.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxWxPPos.FormattingEnabled = true;
		this.comboBoxWxPPos.Location = new Point(109, 66);
		this.comboBoxWxPPos.Name = "comboBoxWxPPos";
		this.comboBoxWxPPos.Size = new System.Drawing.Size(152, 20);
		this.comboBoxWxPPos.TabIndex = 16;
		this.comboBoxWxPUnit.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxWxPUnit.FormattingEnabled = true;
		this.comboBoxWxPUnit.Location = new Point(109, 34);
		this.comboBoxWxPUnit.Name = "comboBoxWxPUnit";
		this.comboBoxWxPUnit.Size = new System.Drawing.Size(152, 20);
		this.comboBoxWxPUnit.TabIndex = 15;
		this.comboBoxWxPUnit.SelectedIndexChanged += new EventHandler(this.comboBoxWxPUnit_SelectedIndexChanged);
		this.label89.AutoSize = true;
		this.label89.Location = new Point(38, 69);
		this.label89.Name = "label89";
		this.label89.Size = new System.Drawing.Size(53, 12);
		this.label89.TabIndex = 10;
		this.label89.Text = "推广位：";
		this.label91.AutoSize = true;
		this.label91.Location = new Point(37, 37);
		this.label91.Name = "label91";
		this.label91.Size = new System.Drawing.Size(65, 12);
		this.label91.TabIndex = 6;
		this.label91.Text = "推广单元：";
		this.groupBoxQyAdmin.Controls.Add(this.button1);
		this.groupBoxQyAdmin.Controls.Add(this.buttonSaveToSvr);
		this.groupBoxQyAdmin.Controls.Add(this.textBoxImgZipPer);
		this.groupBoxQyAdmin.Controls.Add(this.checkBoxLoadDataNow);
		this.groupBoxQyAdmin.Controls.Add(this.label88);
		this.groupBoxQyAdmin.Location = new Point(6, 387);
		this.groupBoxQyAdmin.Name = "groupBoxQyAdmin";
		this.groupBoxQyAdmin.Size = new System.Drawing.Size(345, 100);
		this.groupBoxQyAdmin.TabIndex = 53;
		this.groupBoxQyAdmin.TabStop = false;
		this.groupBoxQyAdmin.Text = "千语管理专用";
		this.groupBoxQyAdmin.Visible = false;
		this.button1.Location = new Point(243, 34);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 56;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new EventHandler(this.button1_Click);
		this.buttonSaveToSvr.Location = new Point(6, 23);
		this.buttonSaveToSvr.Name = "buttonSaveToSvr";
		this.buttonSaveToSvr.Size = new System.Drawing.Size(102, 23);
		this.buttonSaveToSvr.TabIndex = 33;
		this.buttonSaveToSvr.Text = "保存到服务器";
		this.buttonSaveToSvr.UseVisualStyleBackColor = true;
		this.buttonSaveToSvr.Visible = false;
		this.buttonSaveToSvr.Click += new EventHandler(this.buttonSaveToSvr_Click);
		this.textBoxImgZipPer.Location = new Point(66, 60);
		this.textBoxImgZipPer.Name = "textBoxImgZipPer";
		this.textBoxImgZipPer.Size = new System.Drawing.Size(42, 21);
		this.textBoxImgZipPer.TabIndex = 52;
		this.checkBoxLoadDataNow.AutoSize = true;
		this.checkBoxLoadDataNow.Location = new Point(122, 24);
		this.checkBoxLoadDataNow.Name = "checkBoxLoadDataNow";
		this.checkBoxLoadDataNow.Size = new System.Drawing.Size(72, 16);
		this.checkBoxLoadDataNow.TabIndex = 37;
		this.checkBoxLoadDataNow.Text = "立即上传";
		this.checkBoxLoadDataNow.UseVisualStyleBackColor = true;
		this.checkBoxLoadDataNow.Visible = false;
		this.label88.AutoSize = true;
		this.label88.Location = new Point(6, 63);
		this.label88.Name = "label88";
		this.label88.Size = new System.Drawing.Size(65, 12);
		this.label88.TabIndex = 51;
		this.label88.Text = "图片比例：";
		this.groupBox1.Controls.Add(this.textBoxQQPlusPath);
		this.groupBox1.Controls.Add(this.label71);
		this.groupBox1.Controls.Add(this.buttonOpenQQPlus);
		this.groupBox1.Location = new Point(357, 256);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(531, 46);
		this.groupBox1.TabIndex = 50;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "机器人路径";
		this.textBoxQQPlusPath.Enabled = false;
		this.textBoxQQPlusPath.Location = new Point(80, 17);
		this.textBoxQQPlusPath.Name = "textBoxQQPlusPath";
		this.textBoxQQPlusPath.Size = new System.Drawing.Size(388, 21);
		this.textBoxQQPlusPath.TabIndex = 49;
		this.label71.AutoSize = true;
		this.label71.Location = new Point(6, 20);
		this.label71.Name = "label71";
		this.label71.Size = new System.Drawing.Size(77, 12);
		this.label71.TabIndex = 47;
		this.label71.Text = "机器人路径：";
		this.buttonOpenQQPlus.Location = new Point(474, 17);
		this.buttonOpenQQPlus.Name = "buttonOpenQQPlus";
		this.buttonOpenQQPlus.Size = new System.Drawing.Size(45, 23);
		this.buttonOpenQQPlus.TabIndex = 48;
		this.buttonOpenQQPlus.Text = "打开";
		this.buttonOpenQQPlus.UseVisualStyleBackColor = true;
		this.buttonOpenQQPlus.Click += new EventHandler(this.buttonOpenQQPlus_Click);
		this.groupBox27.Controls.Add(this.linkLabelPromotPosition);
		this.groupBox27.Controls.Add(this.comboBoxBrdgPPos);
		this.groupBox27.Controls.Add(this.comboBoxBrdgPUnit);
		this.groupBox27.Controls.Add(this.radioButtonBrdgMOth);
		this.groupBox27.Controls.Add(this.radioButtonBrdgMApp);
		this.groupBox27.Controls.Add(this.radioButtonBrdgMWeb);
		this.groupBox27.Controls.Add(this.label14);
		this.groupBox27.Controls.Add(this.label59);
		this.groupBox27.Location = new Point(357, 136);
		this.groupBox27.Name = "groupBox27";
		this.groupBox27.Size = new System.Drawing.Size(259, 114);
		this.groupBox27.TabIndex = 36;
		this.groupBox27.TabStop = false;
		this.groupBox27.Text = "鹊桥推广位设置";
		this.linkLabelPromotPosition.AutoSize = true;
		this.linkLabelPromotPosition.Location = new Point(164, 0);
		this.linkLabelPromotPosition.Name = "linkLabelPromotPosition";
		this.linkLabelPromotPosition.Size = new System.Drawing.Size(89, 12);
		this.linkLabelPromotPosition.TabIndex = 17;
		this.linkLabelPromotPosition.TabStop = true;
		this.linkLabelPromotPosition.Text = "推广位设置教程";
		this.linkLabelPromotPosition.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelPromotPosition_LinkClicked);
		this.comboBoxBrdgPPos.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxBrdgPPos.FormattingEnabled = true;
		this.comboBoxBrdgPPos.Location = new Point(81, 80);
		this.comboBoxBrdgPPos.Name = "comboBoxBrdgPPos";
		this.comboBoxBrdgPPos.Size = new System.Drawing.Size(152, 20);
		this.comboBoxBrdgPPos.TabIndex = 16;
		this.comboBoxBrdgPUnit.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxBrdgPUnit.FormattingEnabled = true;
		this.comboBoxBrdgPUnit.Location = new Point(81, 54);
		this.comboBoxBrdgPUnit.Name = "comboBoxBrdgPUnit";
		this.comboBoxBrdgPUnit.Size = new System.Drawing.Size(152, 20);
		this.comboBoxBrdgPUnit.TabIndex = 15;
		this.comboBoxBrdgPUnit.SelectedIndexChanged += new EventHandler(this.comboBoxBrdgPUnit_SelectedIndexChanged);
		this.radioButtonBrdgMOth.AutoSize = true;
		this.radioButtonBrdgMOth.Location = new Point(162, 23);
		this.radioButtonBrdgMOth.Name = "radioButtonBrdgMOth";
		this.radioButtonBrdgMOth.Size = new System.Drawing.Size(71, 16);
		this.radioButtonBrdgMOth.TabIndex = 14;
		this.radioButtonBrdgMOth.TabStop = true;
		this.radioButtonBrdgMOth.Text = "导购推广";
		this.radioButtonBrdgMOth.UseVisualStyleBackColor = true;
		this.radioButtonBrdgMOth.CheckedChanged += new EventHandler(this.radioButtonBrdgMOth_CheckedChanged);
		this.radioButtonBrdgMApp.AutoSize = true;
		this.radioButtonBrdgMApp.Location = new Point(89, 25);
		this.radioButtonBrdgMApp.Name = "radioButtonBrdgMApp";
		this.radioButtonBrdgMApp.Size = new System.Drawing.Size(65, 16);
		this.radioButtonBrdgMApp.TabIndex = 13;
		this.radioButtonBrdgMApp.TabStop = true;
		this.radioButtonBrdgMApp.Text = "APP推广";
		this.radioButtonBrdgMApp.UseVisualStyleBackColor = true;
		this.radioButtonBrdgMApp.CheckedChanged += new EventHandler(this.radioButtonBrdgMApp_CheckedChanged);
		this.radioButtonBrdgMWeb.AutoSize = true;
		this.radioButtonBrdgMWeb.Location = new Point(12, 25);
		this.radioButtonBrdgMWeb.Name = "radioButtonBrdgMWeb";
		this.radioButtonBrdgMWeb.Size = new System.Drawing.Size(71, 16);
		this.radioButtonBrdgMWeb.TabIndex = 12;
		this.radioButtonBrdgMWeb.TabStop = true;
		this.radioButtonBrdgMWeb.Text = "网站推广";
		this.radioButtonBrdgMWeb.UseVisualStyleBackColor = true;
		this.radioButtonBrdgMWeb.CheckedChanged += new EventHandler(this.radioButtonBrdgMWeb_CheckedChanged);
		this.label14.AutoSize = true;
		this.label14.Location = new Point(10, 83);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(53, 12);
		this.label14.TabIndex = 10;
		this.label14.Text = "推广位：";
		this.label59.AutoSize = true;
		this.label59.Location = new Point(9, 57);
		this.label59.Name = "label59";
		this.label59.Size = new System.Drawing.Size(65, 12);
		this.label59.TabIndex = 6;
		this.label59.Text = "推广单元：";
		this.groupBox23.Controls.Add(this.radioButton2in1Qyu);
		this.groupBox23.Controls.Add(this.checkBoxShortUrl);
		this.groupBox23.Controls.Add(this.radioButtonShBD);
		this.groupBox23.Controls.Add(this.radioButtonShXL);
		this.groupBox23.Location = new Point(629, 138);
		this.groupBox23.Name = "groupBox23";
		this.groupBox23.Size = new System.Drawing.Size(259, 112);
		this.groupBox23.TabIndex = 32;
		this.groupBox23.TabStop = false;
		this.groupBox23.Text = "短网址平台";
		this.radioButton2in1Qyu.AutoSize = true;
		this.radioButton2in1Qyu.Location = new Point(84, 71);
		this.radioButton2in1Qyu.Name = "radioButton2in1Qyu";
		this.radioButton2in1Qyu.Size = new System.Drawing.Size(83, 16);
		this.radioButton2in1Qyu.TabIndex = 40;
		this.radioButton2in1Qyu.TabStop = true;
		this.radioButton2in1Qyu.Text = "千语短网址";
		this.radioButton2in1Qyu.UseVisualStyleBackColor = true;
		this.checkBoxShortUrl.AutoSize = true;
		this.checkBoxShortUrl.Font = new System.Drawing.Font("SimSun", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.checkBoxShortUrl.ForeColor = Color.Red;
		this.checkBoxShortUrl.Location = new Point(114, -1);
		this.checkBoxShortUrl.Name = "checkBoxShortUrl";
		this.checkBoxShortUrl.Size = new System.Drawing.Size(101, 18);
		this.checkBoxShortUrl.TabIndex = 38;
		this.checkBoxShortUrl.Text = "使用短链接";
		this.checkBoxShortUrl.UseVisualStyleBackColor = true;
		this.radioButtonShBD.AutoSize = true;
		this.radioButtonShBD.Location = new Point(128, 36);
		this.radioButtonShBD.Name = "radioButtonShBD";
		this.radioButtonShBD.Size = new System.Drawing.Size(83, 16);
		this.radioButtonShBD.TabIndex = 1;
		this.radioButtonShBD.TabStop = true;
		this.radioButtonShBD.Text = "百度短网址";
		this.radioButtonShBD.UseVisualStyleBackColor = true;
		this.radioButtonShXL.AutoSize = true;
		this.radioButtonShXL.Location = new Point(13, 36);
		this.radioButtonShXL.Name = "radioButtonShXL";
		this.radioButtonShXL.Size = new System.Drawing.Size(83, 16);
		this.radioButtonShXL.TabIndex = 0;
		this.radioButtonShXL.TabStop = true;
		this.radioButtonShXL.Text = "新浪短网址";
		this.radioButtonShXL.UseVisualStyleBackColor = true;
		this.groupBox22.Controls.Add(this.checkBoxQQKouling);
		this.groupBox22.Controls.Add(this.label101);
		this.groupBox22.Controls.Add(this.label72);
		this.groupBox22.Controls.Add(this.linkLabelHelpCMSPlan);
		this.groupBox22.Controls.Add(this.checkBoxCouponItem);
		this.groupBox22.Controls.Add(this.label100);
		this.groupBox22.Controls.Add(this.radioButtonHiCms);
		this.groupBox22.Controls.Add(this.radioButtonNotAudit);
		this.groupBox22.Controls.Add(this.textBoxAppCmsReson);
		this.groupBox22.Controls.Add(this.label44);
		this.groupBox22.Location = new Point(631, 11);
		this.groupBox22.Name = "groupBox22";
		this.groupBox22.Size = new System.Drawing.Size(257, 109);
		this.groupBox22.TabIndex = 31;
		this.groupBox22.TabStop = false;
		this.groupBox22.Text = "其他设置";
		this.checkBoxQQKouling.AutoSize = true;
		this.checkBoxQQKouling.Location = new Point(200, 89);
		this.checkBoxQQKouling.Name = "checkBoxQQKouling";
		this.checkBoxQQKouling.Size = new System.Drawing.Size(36, 16);
		this.checkBoxQQKouling.TabIndex = 72;
		this.checkBoxQQKouling.Text = "是";
		this.checkBoxQQKouling.UseVisualStyleBackColor = true;
		this.label101.AutoSize = true;
		this.label101.Location = new Point(6, 91);
		this.label101.Name = "label101";
		this.label101.Size = new System.Drawing.Size(89, 12);
		this.label101.TabIndex = 71;
		this.label101.Text = "QQ添加淘口令：";
		this.label72.AutoSize = true;
		this.label72.Location = new Point(6, 52);
		this.label72.Name = "label72";
		this.label72.Size = new System.Drawing.Size(65, 12);
		this.label72.TabIndex = 21;
		this.label72.Text = "定向计划：";
		this.linkLabelHelpCMSPlan.AutoSize = true;
		this.linkLabelHelpCMSPlan.Location = new Point(222, 52);
		this.linkLabelHelpCMSPlan.Name = "linkLabelHelpCMSPlan";
		this.linkLabelHelpCMSPlan.Size = new System.Drawing.Size(23, 12);
		this.linkLabelHelpCMSPlan.TabIndex = 68;
		this.linkLabelHelpCMSPlan.TabStop = true;
		this.linkLabelHelpCMSPlan.Text = "(?)";
		this.linkLabelHelpCMSPlan.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelHelpCMSPlan_LinkClicked);
		this.checkBoxCouponItem.AutoSize = true;
		this.checkBoxCouponItem.Location = new Point(200, 72);
		this.checkBoxCouponItem.Name = "checkBoxCouponItem";
		this.checkBoxCouponItem.Size = new System.Drawing.Size(36, 16);
		this.checkBoxCouponItem.TabIndex = 24;
		this.checkBoxCouponItem.Text = "是";
		this.checkBoxCouponItem.UseVisualStyleBackColor = true;
		this.checkBoxCouponItem.CheckedChanged += new EventHandler(this.checkBoxCouponItem_CheckedChanged);
		this.label100.AutoSize = true;
		this.label100.Location = new Point(6, 74);
		this.label100.Name = "label100";
		this.label100.Size = new System.Drawing.Size(161, 12);
		this.label100.TabIndex = 23;
		this.label100.Text = "使用优惠券和产品2合1页面：";
		this.radioButtonHiCms.AutoSize = true;
		this.radioButtonHiCms.Location = new Point(73, 50);
		this.radioButtonHiCms.Name = "radioButtonHiCms";
		this.radioButtonHiCms.Size = new System.Drawing.Size(71, 16);
		this.radioButtonHiCms.TabIndex = 20;
		this.radioButtonHiCms.TabStop = true;
		this.radioButtonHiCms.Text = "最高佣金";
		this.radioButtonHiCms.UseVisualStyleBackColor = true;
		this.radioButtonNotAudit.AutoSize = true;
		this.radioButtonNotAudit.Location = new Point(151, 51);
		this.radioButtonNotAudit.Name = "radioButtonNotAudit";
		this.radioButtonNotAudit.Size = new System.Drawing.Size(71, 16);
		this.radioButtonNotAudit.TabIndex = 19;
		this.radioButtonNotAudit.TabStop = true;
		this.radioButtonNotAudit.Text = "智能审核";
		this.radioButtonNotAudit.UseVisualStyleBackColor = true;
		this.textBoxAppCmsReson.Location = new Point(104, 17);
		this.textBoxAppCmsReson.Name = "textBoxAppCmsReson";
		this.textBoxAppCmsReson.Size = new System.Drawing.Size(131, 21);
		this.textBoxAppCmsReson.TabIndex = 17;
		this.label44.AutoSize = true;
		this.label44.Location = new Point(6, 22);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(101, 12);
		this.label44.TabIndex = 18;
		this.label44.Text = "高佣金申请理由：";
		this.groupBox18.Controls.Add(this.linkLabelGetPromot);
		this.groupBox18.Controls.Add(this.comboBoxCmPPos);
		this.groupBox18.Controls.Add(this.comboBoxCmPUnit);
		this.groupBox18.Controls.Add(this.radioButtonCmMOth);
		this.groupBox18.Controls.Add(this.radioButtonCmMApp);
		this.groupBox18.Controls.Add(this.radioButtonCmMWeb);
		this.groupBox18.Controls.Add(this.label35);
		this.groupBox18.Controls.Add(this.label36);
		this.groupBox18.Location = new Point(357, 11);
		this.groupBox18.Name = "groupBox18";
		this.groupBox18.Size = new System.Drawing.Size(259, 109);
		this.groupBox18.TabIndex = 30;
		this.groupBox18.TabStop = false;
		this.groupBox18.Text = "通用推广位设置";
		this.linkLabelGetPromot.AutoSize = true;
		this.linkLabelGetPromot.LinkColor = Color.Red;
		this.linkLabelGetPromot.Location = new Point(164, 0);
		this.linkLabelGetPromot.Name = "linkLabelGetPromot";
		this.linkLabelGetPromot.Size = new System.Drawing.Size(89, 12);
		this.linkLabelGetPromot.TabIndex = 17;
		this.linkLabelGetPromot.TabStop = true;
		this.linkLabelGetPromot.Text = "获取最新推广位";
		this.linkLabelGetPromot.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelGetPromot_LinkClicked);
		this.comboBoxCmPPos.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxCmPPos.FormattingEnabled = true;
		this.comboBoxCmPPos.Location = new Point(81, 80);
		this.comboBoxCmPPos.Name = "comboBoxCmPPos";
		this.comboBoxCmPPos.Size = new System.Drawing.Size(152, 20);
		this.comboBoxCmPPos.TabIndex = 16;
		this.comboBoxCmPUnit.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBoxCmPUnit.FormattingEnabled = true;
		this.comboBoxCmPUnit.Location = new Point(81, 54);
		this.comboBoxCmPUnit.Name = "comboBoxCmPUnit";
		this.comboBoxCmPUnit.Size = new System.Drawing.Size(152, 20);
		this.comboBoxCmPUnit.TabIndex = 15;
		this.comboBoxCmPUnit.SelectedIndexChanged += new EventHandler(this.comboBoxCmPUnit_SelectedIndexChanged);
		this.radioButtonCmMOth.AutoSize = true;
		this.radioButtonCmMOth.Location = new Point(162, 23);
		this.radioButtonCmMOth.Name = "radioButtonCmMOth";
		this.radioButtonCmMOth.Size = new System.Drawing.Size(71, 16);
		this.radioButtonCmMOth.TabIndex = 14;
		this.radioButtonCmMOth.TabStop = true;
		this.radioButtonCmMOth.Text = "导购推广";
		this.radioButtonCmMOth.UseVisualStyleBackColor = true;
		this.radioButtonCmMOth.CheckedChanged += new EventHandler(this.radioButtonCmMOth_CheckedChanged);
		this.radioButtonCmMApp.AutoSize = true;
		this.radioButtonCmMApp.Location = new Point(89, 25);
		this.radioButtonCmMApp.Name = "radioButtonCmMApp";
		this.radioButtonCmMApp.Size = new System.Drawing.Size(65, 16);
		this.radioButtonCmMApp.TabIndex = 13;
		this.radioButtonCmMApp.TabStop = true;
		this.radioButtonCmMApp.Text = "APP推广";
		this.radioButtonCmMApp.UseVisualStyleBackColor = true;
		this.radioButtonCmMApp.CheckedChanged += new EventHandler(this.radioButtonCmMApp_CheckedChanged);
		this.radioButtonCmMWeb.AutoSize = true;
		this.radioButtonCmMWeb.Location = new Point(12, 25);
		this.radioButtonCmMWeb.Name = "radioButtonCmMWeb";
		this.radioButtonCmMWeb.Size = new System.Drawing.Size(71, 16);
		this.radioButtonCmMWeb.TabIndex = 12;
		this.radioButtonCmMWeb.TabStop = true;
		this.radioButtonCmMWeb.Text = "网站推广";
		this.radioButtonCmMWeb.UseVisualStyleBackColor = true;
		this.radioButtonCmMWeb.CheckedChanged += new EventHandler(this.radioButtonCmMWeb_CheckedChanged);
		this.label35.AutoSize = true;
		this.label35.Location = new Point(10, 83);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(53, 12);
		this.label35.TabIndex = 10;
		this.label35.Text = "推广位：";
		this.label36.AutoSize = true;
		this.label36.Location = new Point(9, 57);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(65, 12);
		this.label36.TabIndex = 6;
		this.label36.Text = "推广单元：";
		this.buttonSaveConfig.Font = new System.Drawing.Font("SimSun", 24f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonSaveConfig.Location = new Point(518, 350);
		this.buttonSaveConfig.Name = "buttonSaveConfig";
		this.buttonSaveConfig.Size = new System.Drawing.Size(144, 46);
		this.buttonSaveConfig.TabIndex = 28;
		this.buttonSaveConfig.Text = "保存";
		this.buttonSaveConfig.UseVisualStyleBackColor = true;
		this.buttonSaveConfig.Click += new EventHandler(this.buttonSaveConfig_Click);
		this.groupBox5.Controls.Add(this.buttonLoginAlimama2);
		this.groupBox5.Controls.Add(this.checkBoxAutoLogin);
		this.groupBox5.Controls.Add(this.textBoxAlimamaPwd);
		this.groupBox5.Controls.Add(this.textBoxAlimamaAcc);
		this.groupBox5.Controls.Add(this.label11);
		this.groupBox5.Controls.Add(this.label13);
		this.groupBox5.Location = new Point(83, 11);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(259, 117);
		this.groupBox5.TabIndex = 25;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "阿里妈妈账号密码";
		this.buttonLoginAlimama2.Location = new Point(92, 82);
		this.buttonLoginAlimama2.Name = "buttonLoginAlimama2";
		this.buttonLoginAlimama2.Size = new System.Drawing.Size(93, 27);
		this.buttonLoginAlimama2.TabIndex = 29;
		this.buttonLoginAlimama2.Text = "登录阿里妈妈";
		this.buttonLoginAlimama2.UseVisualStyleBackColor = true;
		this.buttonLoginAlimama2.Click += new EventHandler(this.buttonLoginAlimama2_Click);
		this.checkBoxAutoLogin.AutoSize = true;
		this.checkBoxAutoLogin.Location = new Point(184, 0);
		this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
		this.checkBoxAutoLogin.Size = new System.Drawing.Size(72, 16);
		this.checkBoxAutoLogin.TabIndex = 28;
		this.checkBoxAutoLogin.Text = "自动登录";
		this.checkBoxAutoLogin.UseVisualStyleBackColor = true;
		this.textBoxAlimamaPwd.Location = new Point(92, 51);
		this.textBoxAlimamaPwd.Name = "textBoxAlimamaPwd";
		this.textBoxAlimamaPwd.PasswordChar = '*';
		this.textBoxAlimamaPwd.Size = new System.Drawing.Size(151, 21);
		this.textBoxAlimamaPwd.TabIndex = 9;
		this.textBoxAlimamaAcc.Location = new Point(92, 24);
		this.textBoxAlimamaAcc.Name = "textBoxAlimamaAcc";
		this.textBoxAlimamaAcc.Size = new System.Drawing.Size(151, 21);
		this.textBoxAlimamaAcc.TabIndex = 7;
		this.label11.AutoSize = true;
		this.label11.Location = new Point(7, 29);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(89, 12);
		this.label11.TabIndex = 6;
		this.label11.Text = "阿里妈妈账号：";
		this.label13.AutoSize = true;
		this.label13.Location = new Point(8, 55);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(89, 12);
		this.label13.TabIndex = 8;
		this.label13.Text = "阿里妈妈密码：";
		this.groupBox8.Controls.Add(this.buttonOpenUUHP);
		this.groupBox8.Controls.Add(this.pictureBoxTest);
		this.groupBox8.Controls.Add(this.buttonTestCode);
		this.groupBox8.Controls.Add(this.labelUUSts);
		this.groupBox8.Controls.Add(this.textBoxUUPwd);
		this.groupBox8.Controls.Add(this.textBoxUUUsername);
		this.groupBox8.Controls.Add(this.label20);
		this.groupBox8.Controls.Add(this.label21);
		this.groupBox8.Controls.Add(this.buttonUUWiseLogin);
		this.groupBox8.Location = new Point(83, 134);
		this.groupBox8.Name = "groupBox8";
		this.groupBox8.Size = new System.Drawing.Size(259, 168);
		this.groupBox8.TabIndex = 27;
		this.groupBox8.TabStop = false;
		this.groupBox8.Text = "打码兔";
		this.buttonOpenUUHP.Location = new Point(153, 130);
		this.buttonOpenUUHP.Name = "buttonOpenUUHP";
		this.buttonOpenUUHP.Size = new System.Drawing.Size(82, 32);
		this.buttonOpenUUHP.TabIndex = 14;
		this.buttonOpenUUHP.Text = "打码兔官网";
		this.buttonOpenUUHP.UseVisualStyleBackColor = true;
		this.buttonOpenUUHP.Click += new EventHandler(this.buttonOpenUUHP_Click);
		this.pictureBoxTest.BackColor = Color.LightGray;
		this.pictureBoxTest.BorderStyle = BorderStyle.FixedSingle;
		this.pictureBoxTest.Location = new Point(9, 98);
		this.pictureBoxTest.Name = "pictureBoxTest";
		this.pictureBoxTest.Size = new System.Drawing.Size(131, 50);
		this.pictureBoxTest.TabIndex = 0;
		this.pictureBoxTest.TabStop = false;
		this.buttonTestCode.Enabled = false;
		this.buttonTestCode.Location = new Point(153, 92);
		this.buttonTestCode.Name = "buttonTestCode";
		this.buttonTestCode.Size = new System.Drawing.Size(82, 32);
		this.buttonTestCode.TabIndex = 12;
		this.buttonTestCode.Text = "打码测试";
		this.buttonTestCode.UseVisualStyleBackColor = true;
		this.buttonTestCode.Click += new EventHandler(this.buttonTestCode_Click);
		this.labelUUSts.AutoSize = true;
		this.labelUUSts.ForeColor = Color.Lime;
		this.labelUUSts.Location = new Point(13, 75);
		this.labelUUSts.Name = "labelUUSts";
		this.labelUUSts.Size = new System.Drawing.Size(0, 12);
		this.labelUUSts.TabIndex = 9;
		this.textBoxUUPwd.Location = new Point(42, 45);
		this.textBoxUUPwd.Name = "textBoxUUPwd";
		this.textBoxUUPwd.PasswordChar = '*';
		this.textBoxUUPwd.Size = new System.Drawing.Size(98, 21);
		this.textBoxUUPwd.TabIndex = 7;
		this.textBoxUUUsername.Location = new Point(42, 19);
		this.textBoxUUUsername.Name = "textBoxUUUsername";
		this.textBoxUUUsername.Size = new System.Drawing.Size(98, 21);
		this.textBoxUUUsername.TabIndex = 5;
		this.label20.AutoSize = true;
		this.label20.Location = new Point(6, 48);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(41, 12);
		this.label20.TabIndex = 8;
		this.label20.Text = "密码：";
		this.label21.AutoSize = true;
		this.label21.Location = new Point(6, 22);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(41, 12);
		this.label21.TabIndex = 6;
		this.label21.Text = "账号：";
		this.buttonUUWiseLogin.Location = new Point(153, 29);
		this.buttonUUWiseLogin.Name = "buttonUUWiseLogin";
		this.buttonUUWiseLogin.Size = new System.Drawing.Size(82, 32);
		this.buttonUUWiseLogin.TabIndex = 0;
		this.buttonUUWiseLogin.Text = "登录打码兔";
		this.buttonUUWiseLogin.UseVisualStyleBackColor = true;
		this.buttonUUWiseLogin.Click += new EventHandler(this.buttonUUWiseLogin_Click);
		this.tabPageAmaze.Controls.Add(this.groupBox46);
		this.tabPageAmaze.Controls.Add(this.groupBox45);
		this.tabPageAmaze.Location = new Point(4, 29);
		this.tabPageAmaze.Name = "tabPageAmaze";
		this.tabPageAmaze.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageAmaze.Size = new System.Drawing.Size(1253, 531);
		this.tabPageAmaze.TabIndex = 13;
		this.tabPageAmaze.Text = "精品小软件";
		this.tabPageAmaze.UseVisualStyleBackColor = true;
		this.groupBox46.Controls.Add(this.checkBoxAuditCms);
		this.groupBox46.Controls.Add(this.label98);
		this.groupBox46.Controls.Add(this.buttonAuditBridge);
		this.groupBox46.Controls.Add(this.textBoxAuditBridgeId);
		this.groupBox46.Controls.Add(this.label106);
		this.groupBox46.Controls.Add(this.textBoxSoldQuantity);
		this.groupBox46.Location = new Point(26, 136);
		this.groupBox46.Name = "groupBox46";
		this.groupBox46.Size = new System.Drawing.Size(320, 156);
		this.groupBox46.TabIndex = 18;
		this.groupBox46.TabStop = false;
		this.groupBox46.Text = "审核鹊桥";
		this.checkBoxAuditCms.AutoSize = true;
		this.checkBoxAuditCms.Location = new Point(11, 59);
		this.checkBoxAuditCms.Name = "checkBoxAuditCms";
		this.checkBoxAuditCms.Size = new System.Drawing.Size(204, 16);
		this.checkBoxAuditCms.TabIndex = 18;
		this.checkBoxAuditCms.Text = "拒绝低于鹊桥搜索最高佣金的产品";
		this.checkBoxAuditCms.UseVisualStyleBackColor = true;
		this.label98.AutoSize = true;
		this.label98.Location = new Point(9, 26);
		this.label98.Name = "label98";
		this.label98.Size = new System.Drawing.Size(47, 12);
		this.label98.TabIndex = 15;
		this.label98.Text = "鹊桥ID:";
		this.buttonAuditBridge.Location = new Point(94, 92);
		this.buttonAuditBridge.Name = "buttonAuditBridge";
		this.buttonAuditBridge.Size = new System.Drawing.Size(112, 49);
		this.buttonAuditBridge.TabIndex = 1;
		this.buttonAuditBridge.Text = "审核鹊桥";
		this.buttonAuditBridge.UseVisualStyleBackColor = true;
		this.buttonAuditBridge.Click += new EventHandler(this.buttonAuditBridge_Click);
		this.textBoxAuditBridgeId.Location = new Point(56, 23);
		this.textBoxAuditBridgeId.Name = "textBoxAuditBridgeId";
		this.textBoxAuditBridgeId.Size = new System.Drawing.Size(56, 21);
		this.textBoxAuditBridgeId.TabIndex = 14;
		this.label106.AutoSize = true;
		this.label106.Location = new Point(141, 26);
		this.label106.Name = "label106";
		this.label106.Size = new System.Drawing.Size(83, 12);
		this.label106.TabIndex = 17;
		this.label106.Text = "拒绝销量低于:";
		this.textBoxSoldQuantity.Location = new Point(224, 22);
		this.textBoxSoldQuantity.Name = "textBoxSoldQuantity";
		this.textBoxSoldQuantity.Size = new System.Drawing.Size(45, 21);
		this.textBoxSoldQuantity.TabIndex = 16;
		this.groupBox45.Controls.Add(this.linkLabelBridgeHelp);
		this.groupBox45.Controls.Add(this.buttonGenBridge);
		this.groupBox45.Location = new Point(26, 21);
		this.groupBox45.Name = "groupBox45";
		this.groupBox45.Size = new System.Drawing.Size(320, 100);
		this.groupBox45.TabIndex = 1;
		this.groupBox45.TabStop = false;
		this.groupBox45.Text = "必须先获得发布鹊桥活动权限- 购买后不退款";
		this.buttonGenBridge.Location = new Point(94, 32);
		this.buttonGenBridge.Name = "buttonGenBridge";
		this.buttonGenBridge.Size = new System.Drawing.Size(112, 49);
		this.buttonGenBridge.TabIndex = 0;
		this.buttonGenBridge.Text = "发布鹊桥";
		this.buttonGenBridge.UseVisualStyleBackColor = true;
		this.buttonGenBridge.Click += new EventHandler(this.buttonGenBridge_Click);
		this.tabPageBridge.Controls.Add(this.groupBox13);
		this.tabPageBridge.Controls.Add(this.groupBox12);
		this.tabPageBridge.Controls.Add(this.pictureBoxWaiting);
		this.tabPageBridge.Controls.Add(this.pictureBoxItemPic);
		this.tabPageBridge.Controls.Add(this.groupBox9);
		this.tabPageBridge.Controls.Add(this.groupBox2);
		this.tabPageBridge.Controls.Add(this.groupBox3);
		this.tabPageBridge.Controls.Add(this.dataGridViewBrdg);
		this.tabPageBridge.Controls.Add(this.groupBox4);
		this.tabPageBridge.Font = new System.Drawing.Font("SimSun", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
		this.tabPageBridge.Location = new Point(4, 29);
		this.tabPageBridge.Name = "tabPageBridge";
		this.tabPageBridge.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageBridge.Size = new System.Drawing.Size(1253, 531);
		this.tabPageBridge.TabIndex = 0;
		this.tabPageBridge.Text = "鹊桥本地数据";
		this.tabPageBridge.UseVisualStyleBackColor = true;
		this.groupBox13.Controls.Add(this.buttonLoginAlimama);
		this.groupBox13.Location = new Point(97, 8);
		this.groupBox13.Name = "groupBox13";
		this.groupBox13.Size = new System.Drawing.Size(200, 42);
		this.groupBox13.TabIndex = 28;
		this.groupBox13.TabStop = false;
		this.groupBox13.Text = "登录阿里妈妈";
		this.buttonLoginAlimama.Location = new Point(62, 14);
		this.buttonLoginAlimama.Name = "buttonLoginAlimama";
		this.buttonLoginAlimama.Size = new System.Drawing.Size(89, 23);
		this.buttonLoginAlimama.TabIndex = 0;
		this.buttonLoginAlimama.Text = "登录阿里妈妈";
		this.buttonLoginAlimama.UseVisualStyleBackColor = true;
		this.buttonLoginAlimama.Click += new EventHandler(this.buttonLoginAlimama_Click);
		this.groupBox12.Controls.Add(this.buttonCompressDb);
		this.groupBox12.Location = new Point(91, 162);
		this.groupBox12.Name = "groupBox12";
		this.groupBox12.Size = new System.Drawing.Size(207, 51);
		this.groupBox12.TabIndex = 27;
		this.groupBox12.TabStop = false;
		this.groupBox12.Text = "搜索非常慢，经常出错点这里";
		this.buttonCompressDb.Location = new Point(68, 20);
		this.buttonCompressDb.Name = "buttonCompressDb";
		this.buttonCompressDb.Size = new System.Drawing.Size(75, 23);
		this.buttonCompressDb.TabIndex = 27;
		this.buttonCompressDb.Text = "优化数据库";
		this.buttonCompressDb.UseVisualStyleBackColor = true;
		this.buttonCompressDb.Click += new EventHandler(this.buttonCompressDb_Click);
		this.pictureBoxWaiting.Location = new Point(484, 285);
		this.pictureBoxWaiting.Name = "pictureBoxWaiting";
		this.pictureBoxWaiting.Size = new System.Drawing.Size(343, 199);
		this.pictureBoxWaiting.TabIndex = 25;
		this.pictureBoxWaiting.TabStop = false;
		this.pictureBoxWaiting.Visible = false;
		this.groupBox9.Controls.Add(this.label24);
		this.groupBox9.Controls.Add(this.textBoxFEarn);
		this.groupBox9.Controls.Add(this.label23);
		this.groupBox9.Controls.Add(this.textBoxRemainDay);
		this.groupBox9.Controls.Add(this.label22);
		this.groupBox9.Controls.Add(this.textBoxItemTitle);
		this.groupBox9.Controls.Add(this.label19);
		this.groupBox9.Controls.Add(this.buttonCpPromotLnk);
		this.groupBox9.Controls.Add(this.textBoxPromotLnk);
		this.groupBox9.Controls.Add(this.label17);
		this.groupBox9.Location = new Point(320, 114);
		this.groupBox9.Name = "groupBox9";
		this.groupBox9.Size = new System.Drawing.Size(481, 101);
		this.groupBox9.TabIndex = 24;
		this.groupBox9.TabStop = false;
		this.groupBox9.Text = "产品信息";
		this.label24.AutoSize = true;
		this.label24.Location = new Point(143, 47);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(17, 12);
		this.label24.TabIndex = 26;
		this.label24.Text = "天";
		this.textBoxFEarn.BackColor = Color.White;
		this.textBoxFEarn.ForeColor = SystemColors.WindowText;
		this.textBoxFEarn.Location = new Point(401, 44);
		this.textBoxFEarn.Name = "textBoxFEarn";
		this.textBoxFEarn.ReadOnly = true;
		this.textBoxFEarn.Size = new System.Drawing.Size(71, 21);
		this.textBoxFEarn.TabIndex = 24;
		this.textBoxFEarn.TextAlign = HorizontalAlignment.Center;
		this.label23.AutoSize = true;
		this.label23.Location = new Point(341, 47);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(65, 12);
		this.label23.TabIndex = 25;
		this.label23.Text = "最终收入：";
		this.textBoxRemainDay.BackColor = Color.White;
		this.textBoxRemainDay.ForeColor = SystemColors.WindowText;
		this.textBoxRemainDay.Location = new Point(67, 44);
		this.textBoxRemainDay.Name = "textBoxRemainDay";
		this.textBoxRemainDay.ReadOnly = true;
		this.textBoxRemainDay.Size = new System.Drawing.Size(71, 21);
		this.textBoxRemainDay.TabIndex = 22;
		this.textBoxRemainDay.TextAlign = HorizontalAlignment.Center;
		this.label22.AutoSize = true;
		this.label22.Location = new Point(7, 47);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(65, 12);
		this.label22.TabIndex = 23;
		this.label22.Text = "剩余天数：";
		this.textBoxItemTitle.BackColor = Color.White;
		this.textBoxItemTitle.ForeColor = SystemColors.WindowText;
		this.textBoxItemTitle.Location = new Point(67, 15);
		this.textBoxItemTitle.Name = "textBoxItemTitle";
		this.textBoxItemTitle.ReadOnly = true;
		this.textBoxItemTitle.Size = new System.Drawing.Size(405, 21);
		this.textBoxItemTitle.TabIndex = 20;
		this.label19.AutoSize = true;
		this.label19.Location = new Point(6, 18);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(65, 12);
		this.label19.TabIndex = 21;
		this.label19.Text = "产品标题：";
		this.buttonCpPromotLnk.Location = new Point(422, 70);
		this.buttonCpPromotLnk.Name = "buttonCpPromotLnk";
		this.buttonCpPromotLnk.Size = new System.Drawing.Size(53, 23);
		this.buttonCpPromotLnk.TabIndex = 19;
		this.buttonCpPromotLnk.Text = "复制";
		this.buttonCpPromotLnk.UseVisualStyleBackColor = true;
		this.buttonCpPromotLnk.Click += new EventHandler(this.buttonCpPromotLnk_Click);
		this.textBoxPromotLnk.BackColor = Color.White;
		this.textBoxPromotLnk.ForeColor = SystemColors.WindowText;
		this.textBoxPromotLnk.Location = new Point(67, 72);
		this.textBoxPromotLnk.Name = "textBoxPromotLnk";
		this.textBoxPromotLnk.ReadOnly = true;
		this.textBoxPromotLnk.Size = new System.Drawing.Size(346, 21);
		this.textBoxPromotLnk.TabIndex = 12;
		this.label17.AutoSize = true;
		this.label17.Location = new Point(4, 75);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(65, 12);
		this.label17.TabIndex = 13;
		this.label17.Text = "推广链接：";
		this.tabPageTaoQingQiang.Controls.Add(this.pictureBoxTQQ);
		this.tabPageTaoQingQiang.Controls.Add(this.groupBox24);
		this.tabPageTaoQingQiang.Controls.Add(this.groupBoxTaobaoQiang);
		this.tabPageTaoQingQiang.Controls.Add(this.groupBoxTaobaoQing);
		this.tabPageTaoQingQiang.Controls.Add(this.buttonClrLclTQQData);
		this.tabPageTaoQingQiang.Controls.Add(this.richTextBoxDscTQQ);
		this.tabPageTaoQingQiang.Controls.Add(this.buttonDownloadTaoQing);
		this.tabPageTaoQingQiang.Location = new Point(4, 29);
		this.tabPageTaoQingQiang.Name = "tabPageTaoQingQiang";
		this.tabPageTaoQingQiang.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTaoQingQiang.Size = new System.Drawing.Size(1253, 531);
		this.tabPageTaoQingQiang.TabIndex = 7;
		this.tabPageTaoQingQiang.Text = "淘清仓淘抢购";
		this.tabPageTaoQingQiang.UseVisualStyleBackColor = true;
		this.pictureBoxTQQ.BorderStyle = BorderStyle.FixedSingle;
		this.pictureBoxTQQ.Location = new Point(1177, 3);
		this.pictureBoxTQQ.Name = "pictureBoxTQQ";
		this.pictureBoxTQQ.Size = new System.Drawing.Size(70, 70);
		this.pictureBoxTQQ.TabIndex = 29;
		this.pictureBoxTQQ.TabStop = false;
		this.pictureBoxTQQ.Visible = false;
		this.groupBox24.Controls.Add(this.label46);
		this.groupBox24.Controls.Add(this.textBoxTQQLCms);
		this.groupBox24.Controls.Add(this.label47);
		this.groupBox24.Location = new Point(479, 16);
		this.groupBox24.Name = "groupBox24";
		this.groupBox24.Size = new System.Drawing.Size(155, 47);
		this.groupBox24.TabIndex = 12;
		this.groupBox24.TabStop = false;
		this.groupBox24.Text = "过滤设置";
		this.label46.AutoSize = true;
		this.label46.Location = new Point(28, 21);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(65, 12);
		this.label46.TabIndex = 7;
		this.label46.Text = "不显示低于";
		this.textBoxTQQLCms.Location = new Point(94, 17);
		this.textBoxTQQLCms.Name = "textBoxTQQLCms";
		this.textBoxTQQLCms.Size = new System.Drawing.Size(22, 21);
		this.textBoxTQQLCms.TabIndex = 8;
		this.label47.AutoSize = true;
		this.label47.Location = new Point(122, 22);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(11, 12);
		this.label47.TabIndex = 9;
		this.label47.Text = "%";
		this.groupBoxTaobaoQiang.Controls.Add(this.webBrowserTaoQiang);
		this.groupBoxTaobaoQiang.Controls.Add(this.dataGridViewTaobaoQiang);
		this.groupBoxTaobaoQiang.Location = new Point(566, 69);
		this.groupBoxTaobaoQiang.Name = "groupBoxTaobaoQiang";
		this.groupBoxTaobaoQiang.Size = new System.Drawing.Size(681, 459);
		this.groupBoxTaobaoQiang.TabIndex = 11;
		this.groupBoxTaobaoQiang.TabStop = false;
		this.groupBoxTaobaoQiang.Text = "淘抢购";
		this.webBrowserTaoQiang.Location = new Point(19, 320);
		this.webBrowserTaoQiang.MinimumSize = new System.Drawing.Size(20, 20);
		this.webBrowserTaoQiang.Name = "webBrowserTaoQiang";
		this.webBrowserTaoQiang.Size = new System.Drawing.Size(235, 127);
		this.webBrowserTaoQiang.TabIndex = 2;
		this.webBrowserTaoQiang.Visible = false;
		this.dataGridViewTaobaoQiang.AllowUserToAddRows = false;
		this.dataGridViewTaobaoQiang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewTaobaoQiang.ContextMenuStrip = this.contextMenuStrip2;
		this.dataGridViewTaobaoQiang.Location = new Point(6, 16);
		this.dataGridViewTaobaoQiang.Name = "dataGridViewTaobaoQiang";
		this.dataGridViewTaobaoQiang.RowHeadersWidth = 55;
		this.dataGridViewTaobaoQiang.RowTemplate.Height = 23;
		this.dataGridViewTaobaoQiang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewTaobaoQiang.Size = new System.Drawing.Size(669, 437);
		this.dataGridViewTaobaoQiang.TabIndex = 1;
		this.dataGridViewTaobaoQiang.DoubleClick += new EventHandler(this.dataGridViewTaobaoQiang_DoubleClick);
		this.dataGridViewTaobaoQiang.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewTaobaoQiang_CellMouseDown);
		this.contextMenuStrip2.Name = "contextMenuStrip2";
		this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
		this.groupBoxTaobaoQing.Controls.Add(this.dataGridViewCmsPlan);
		this.groupBoxTaobaoQing.Controls.Add(this.dataGridViewTaobaoQing);
		this.groupBoxTaobaoQing.Location = new Point(6, 69);
		this.groupBoxTaobaoQing.Name = "groupBoxTaobaoQing";
		this.groupBoxTaobaoQing.Size = new System.Drawing.Size(554, 459);
		this.groupBoxTaobaoQing.TabIndex = 10;
		this.groupBoxTaobaoQing.TabStop = false;
		this.groupBoxTaobaoQing.Text = "淘清仓";
		this.dataGridViewCmsPlan.AllowUserToAddRows = false;
		this.dataGridViewCmsPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewCmsPlan.ContextMenuStrip = this.contextMenuStripHiCms;
		this.dataGridViewCmsPlan.Location = new Point(7, 320);
		this.dataGridViewCmsPlan.Name = "dataGridViewCmsPlan";
		this.dataGridViewCmsPlan.RowHeadersWidth = 50;
		this.dataGridViewCmsPlan.RowTemplate.Height = 23;
		this.dataGridViewCmsPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewCmsPlan.Size = new System.Drawing.Size(541, 118);
		this.dataGridViewCmsPlan.TabIndex = 4;
		this.dataGridViewCmsPlan.Visible = false;
		this.dataGridViewCmsPlan.DoubleClick += new EventHandler(this.dataGridViewCmsPlan_DoubleClick);
		this.dataGridViewCmsPlan.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewCmsPlan_CellMouseDown);
		this.dataGridViewCmsPlan.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewCmsPlan_CellContentClick);
		this.contextMenuStripHiCms.Name = "contextMenuStripHiCms";
		this.contextMenuStripHiCms.Size = new System.Drawing.Size(61, 4);
		this.contextMenuStripHiCms.Opening += new CancelEventHandler(this.contextMenuStripHiCms_Opening);
		this.dataGridViewTaobaoQing.AllowUserToAddRows = false;
		this.dataGridViewTaobaoQing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewTaobaoQing.ContextMenuStrip = this.contextMenuStripTaoQing;
		this.dataGridViewTaobaoQing.Location = new Point(6, 16);
		this.dataGridViewTaobaoQing.Name = "dataGridViewTaobaoQing";
		this.dataGridViewTaobaoQing.RowHeadersWidth = 55;
		this.dataGridViewTaobaoQing.RowTemplate.Height = 23;
		this.dataGridViewTaobaoQing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewTaobaoQing.Size = new System.Drawing.Size(542, 437);
		this.dataGridViewTaobaoQing.TabIndex = 0;
		this.dataGridViewTaobaoQing.DoubleClick += new EventHandler(this.dataGridViewTaobaoQing_DoubleClick);
		this.dataGridViewTaobaoQing.CellMouseDown += new DataGridViewCellMouseEventHandler(this.dataGridViewTaobaoQing_CellMouseDown);
		this.contextMenuStripTaoQing.Name = "contextMenuStripTaoQing";
		this.contextMenuStripTaoQing.Size = new System.Drawing.Size(61, 4);
		this.buttonClrLclTQQData.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonClrLclTQQData.Location = new Point(845, 21);
		this.buttonClrLclTQQData.Name = "buttonClrLclTQQData";
		this.buttonClrLclTQQData.Size = new System.Drawing.Size(154, 37);
		this.buttonClrLclTQQData.TabIndex = 6;
		this.buttonClrLclTQQData.Text = "清空本地数据";
		this.buttonClrLclTQQData.UseVisualStyleBackColor = true;
		this.buttonClrLclTQQData.Click += new EventHandler(this.buttonClrLclTQQData_Click);
		this.richTextBoxDscTQQ.Enabled = false;
		this.richTextBoxDscTQQ.Location = new Point(6, 0);
		this.richTextBoxDscTQQ.Name = "richTextBoxDscTQQ";
		this.richTextBoxDscTQQ.Size = new System.Drawing.Size(459, 63);
		this.richTextBoxDscTQQ.TabIndex = 5;
		this.richTextBoxDscTQQ.Text = "";
		this.buttonDownloadTaoQing.Font = new System.Drawing.Font("SimSun", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
		this.buttonDownloadTaoQing.Location = new Point(653, 21);
		this.buttonDownloadTaoQing.Name = "buttonDownloadTaoQing";
		this.buttonDownloadTaoQing.Size = new System.Drawing.Size(154, 37);
		this.buttonDownloadTaoQing.TabIndex = 2;
		this.buttonDownloadTaoQing.Text = "显示最新数据";
		this.buttonDownloadTaoQing.UseVisualStyleBackColor = true;
		this.buttonDownloadTaoQing.Click += new EventHandler(this.buttonDownloadTaoQing_Click);
		this.tabPageShareHotShare.Location = new Point(4, 29);
		this.tabPageShareHotShare.Name = "tabPageShareHotShare";
		this.tabPageShareHotShare.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageShareHotShare.Size = new System.Drawing.Size(475, 489);
		this.tabPageShareHotShare.TabIndex = 2;
		this.tabPageShareHotShare.Text = "分享爆款";
		this.tabPageShareHotShare.UseVisualStyleBackColor = true;
		this.tabPageMutualHotShare.Location = new Point(4, 29);
		this.tabPageMutualHotShare.Name = "tabPageMutualHotShare";
		this.tabPageMutualHotShare.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageMutualHotShare.Size = new System.Drawing.Size(475, 489);
		this.tabPageMutualHotShare.TabIndex = 3;
		this.tabPageMutualHotShare.Text = "互推爆款";
		this.tabPageMutualHotShare.UseVisualStyleBackColor = true;
		this.contextMenuStripTask.Name = "contextMenuStripTask";
		this.contextMenuStripTask.Size = new System.Drawing.Size(61, 4);
		this.notifyIcon_0.ContextMenuStrip = this.contextMenuStripTask;
		this.notifyIcon_0.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("notifyIconTask.Icon");
		this.notifyIcon_0.Text = "千语淘客助手";
		this.notifyIcon_0.Visible = true;
		this.notifyIcon_0.MouseClick += new MouseEventHandler(this.notifyIcon_0_MouseClick);
		this.skinEngine_0.set_SerialNumber("");
		this.skinEngine_0.set_SkinFile(null);
		this.label45.AutoSize = true;
		this.label45.Location = new Point(901, 5);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(0, 12);
		this.label45.TabIndex = 33;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
		this.linkLabel1.Location = new Point(905, 4);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(29, 12);
		this.linkLabel1.TabIndex = 33;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "官网";
		this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		this.linkLabelGuid.AutoSize = true;
		this.linkLabelGuid.LinkBehavior = LinkBehavior.HoverUnderline;
		this.linkLabelGuid.Location = new Point(813, 4);
		this.linkLabelGuid.Name = "linkLabelGuid";
		this.linkLabelGuid.Size = new System.Drawing.Size(89, 12);
		this.linkLabelGuid.TabIndex = 35;
		this.linkLabelGuid.TabStop = true;
		this.linkLabelGuid.Text = "使用教程和视频";
		this.linkLabelGuid.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelGuid_LinkClicked);
		this.linkLabelCurUserNum.AutoSize = true;
		this.linkLabelCurUserNum.LinkBehavior = LinkBehavior.NeverUnderline;
		this.linkLabelCurUserNum.Location = new Point(1158, 4);
		this.linkLabelCurUserNum.Name = "linkLabelCurUserNum";
		this.linkLabelCurUserNum.Size = new System.Drawing.Size(95, 12);
		this.linkLabelCurUserNum.TabIndex = 36;
		this.linkLabelCurUserNum.TabStop = true;
		this.linkLabelCurUserNum.Text = "当前在线人数[-]";
		this.lblVip.AutoSize = true;
		this.lblVip.Location = new Point(1019, 4);
		this.lblVip.Name = "lblVip";
		this.lblVip.Size = new System.Drawing.Size(0, 12);
		this.lblVip.TabIndex = 51;
		this.linkLabelHot1.AutoSize = true;
		this.linkLabelHot1.LinkBehavior = LinkBehavior.NeverUnderline;
		this.linkLabelHot1.LinkColor = Color.Blue;
		this.linkLabelHot1.Location = new Point(6, 566);
		this.linkLabelHot1.Name = "linkLabelHot1";
		this.linkLabelHot1.Size = new System.Drawing.Size(0, 12);
		this.linkLabelHot1.TabIndex = 52;
		this.linkLabelHot1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelHot1_LinkClicked);
		this.linkLabelHot2.AutoSize = true;
		this.linkLabelHot2.LinkBehavior = LinkBehavior.NeverUnderline;
		this.linkLabelHot2.Location = new Point(620, 566);
		this.linkLabelHot2.Name = "linkLabelHot2";
		this.linkLabelHot2.Size = new System.Drawing.Size(0, 12);
		this.linkLabelHot2.TabIndex = 53;
		this.linkLabelHot2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelHot2_LinkClicked);
		this.linkLabelVipCharge.AutoSize = true;
		this.linkLabelVipCharge.LinkBehavior = LinkBehavior.HoverUnderline;
		this.linkLabelVipCharge.Location = new Point(944, 4);
		this.linkLabelVipCharge.Name = "linkLabelVipCharge";
		this.linkLabelVipCharge.Size = new System.Drawing.Size(47, 12);
		this.linkLabelVipCharge.TabIndex = 79;
		this.linkLabelVipCharge.TabStop = true;
		this.linkLabelVipCharge.Text = "VIP充值";
		this.linkLabelVipCharge.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelVipCharge_LinkClicked);
		this.linkLabelBridgeHelp.AutoSize = true;
		this.linkLabelBridgeHelp.Location = new Point(255, 1);
		this.linkLabelBridgeHelp.Name = "linkLabelBridgeHelp";
		this.linkLabelBridgeHelp.Size = new System.Drawing.Size(53, 12);
		this.linkLabelBridgeHelp.TabIndex = 19;
		this.linkLabelBridgeHelp.TabStop = true;
		this.linkLabelBridgeHelp.Text = "使用教程";
		this.linkLabelBridgeHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabelBridgeHelp_LinkClicked);
		base.AutoScaleDimensions = new SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1272, 674);
		base.Controls.Add(this.linkLabelVipCharge);
		base.Controls.Add(this.linkLabelHot2);
		base.Controls.Add(this.linkLabelHot1);
		base.Controls.Add(this.lblVip);
		base.Controls.Add(this.linkLabelCurUserNum);
		base.Controls.Add(this.linkLabelGuid);
		base.Controls.Add(this.linkLabel1);
		base.Controls.Add(this.label45);
		base.Controls.Add(this.tabControlMain);
		base.Controls.Add(this.richTextBoxSts);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "AliBridgeForm";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "千语淘客助手V161";
		base.Load += new EventHandler(this.AliBridgeForm_Load);
		((ISupportInitialize)this.dataGridViewBrdg).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((ISupportInitialize)this.pictureBoxItemPic).EndInit();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		this.tabControlMain.ResumeLayout(false);
		this.tabPageOnline.ResumeLayout(false);
		((ISupportInitialize)this.pictureBoxOnlineItemPic).EndInit();
		this.groupBox25.ResumeLayout(false);
		this.groupBox25.PerformLayout();
		((ISupportInitialize)this.dataGridViewOnlineBrdg).EndInit();
		this.tabPageOrder.ResumeLayout(false);
		this.groupBox26.ResumeLayout(false);
		this.groupBox26.PerformLayout();
		this.groupBox44.ResumeLayout(false);
		this.groupBox43.ResumeLayout(false);
		this.groupBox43.PerformLayout();
		this.groupBox10.ResumeLayout(false);
		this.groupBox10.PerformLayout();
		this.groupBox6.ResumeLayout(false);
		this.groupBox6.PerformLayout();
		((ISupportInitialize)this.dataGridViewAliOdr).EndInit();
		this.tabPageAutoSend.ResumeLayout(false);
		this.tabControlSnd.ResumeLayout(false);
		this.tabPageSndManual.ResumeLayout(false);
		this.groupBox11.ResumeLayout(false);
		this.groupBox11.PerformLayout();
		this.groupBox14.ResumeLayout(false);
		this.tabPageFollowSend.ResumeLayout(false);
		this.tabPageFollowSend.PerformLayout();
		this.groupBox30.ResumeLayout(false);
		this.groupBox30.PerformLayout();
		((ISupportInitialize)this.dataGridViewFollowSnd).EndInit();
		this.groupBox17.ResumeLayout(false);
		this.groupBox17.PerformLayout();
		((ISupportInitialize)this.dataGridViewAutoSndTask).EndInit();
		this.groupBox16.ResumeLayout(false);
		this.groupBox16.PerformLayout();
		this.groupBox15.ResumeLayout(false);
		this.groupBox15.PerformLayout();
		((ISupportInitialize)this.dataGridViewQQGrp).EndInit();
		this.tabPageHotShare.ResumeLayout(false);
		this.groupBox37.ResumeLayout(false);
		this.groupBox37.PerformLayout();
		((ISupportInitialize)this.dataGridViewHotShare).EndInit();
		this.tabControlHotShare.ResumeLayout(false);
		this.groupBox19.ResumeLayout(false);
		this.tabPageTools.ResumeLayout(false);
		this.groupBox39.ResumeLayout(false);
		this.groupBox39.PerformLayout();
		this.groupBox38.ResumeLayout(false);
		this.groupBox38.PerformLayout();
		((ISupportInitialize)this.dgvQQGrpMonRep).EndInit();
		this.groupBox29.ResumeLayout(false);
		this.groupBox29.PerformLayout();
		this.groupBox42.ResumeLayout(false);
		this.groupBox42.PerformLayout();
		this.groupBox28.ResumeLayout(false);
		this.groupBox21.ResumeLayout(false);
		this.groupBox21.PerformLayout();
		this.groupBox20.ResumeLayout(false);
		this.groupBox20.PerformLayout();
		this.tabPageQQGrpMng.ResumeLayout(false);
		this.groupBox33.ResumeLayout(false);
		this.groupBox33.PerformLayout();
		((ISupportInitialize)this.dataGridViewSchQQGrpMember).EndInit();
		this.groupBox32.ResumeLayout(false);
		this.groupBox32.PerformLayout();
		((ISupportInitialize)this.dataGridViewQQGroup).EndInit();
		this.groupBox31.ResumeLayout(false);
		this.groupBox31.PerformLayout();
		((ISupportInitialize)this.dataGridViewQQGrpMember).EndInit();
		this.tabPageQQGrpInvite.ResumeLayout(false);
		this.groupBox36.ResumeLayout(false);
		this.groupBox36.PerformLayout();
		this.groupBox34.ResumeLayout(false);
		this.groupBox34.PerformLayout();
		((ISupportInitialize)this.dataGridViewQQGrpInvite).EndInit();
		this.tabPageOdrPoi.ResumeLayout(false);
		this.groupBox35.ResumeLayout(false);
		this.groupBox35.PerformLayout();
		((ISupportInitialize)this.dataGridViewAliOdrPoi).EndInit();
		this.tabPageUserMng.ResumeLayout(false);
		((ISupportInitialize)this.dataGridViewRtnFundUser).EndInit();
		this.groupBox7.ResumeLayout(false);
		this.groupBox7.PerformLayout();
		this.tabPageSetUp.ResumeLayout(false);
		this.tabPageSetUp.PerformLayout();
		this.groupBox41.ResumeLayout(false);
		this.groupBox41.PerformLayout();
		this.groupBox40.ResumeLayout(false);
		this.groupBox40.PerformLayout();
		this.groupBoxQyAdmin.ResumeLayout(false);
		this.groupBoxQyAdmin.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox27.ResumeLayout(false);
		this.groupBox27.PerformLayout();
		this.groupBox23.ResumeLayout(false);
		this.groupBox23.PerformLayout();
		this.groupBox22.ResumeLayout(false);
		this.groupBox22.PerformLayout();
		this.groupBox18.ResumeLayout(false);
		this.groupBox18.PerformLayout();
		this.groupBox5.ResumeLayout(false);
		this.groupBox5.PerformLayout();
		this.groupBox8.ResumeLayout(false);
		this.groupBox8.PerformLayout();
		((ISupportInitialize)this.pictureBoxTest).EndInit();
		this.tabPageAmaze.ResumeLayout(false);
		this.groupBox46.ResumeLayout(false);
		this.groupBox46.PerformLayout();
		this.groupBox45.ResumeLayout(false);
		this.groupBox45.PerformLayout();
		this.tabPageBridge.ResumeLayout(false);
		this.groupBox13.ResumeLayout(false);
		this.groupBox12.ResumeLayout(false);
		((ISupportInitialize)this.pictureBoxWaiting).EndInit();
		this.groupBox9.ResumeLayout(false);
		this.groupBox9.PerformLayout();
		this.tabPageTaoQingQiang.ResumeLayout(false);
		((ISupportInitialize)this.pictureBoxTQQ).EndInit();
		this.groupBox24.ResumeLayout(false);
		this.groupBox24.PerformLayout();
		this.groupBoxTaobaoQiang.ResumeLayout(false);
		((ISupportInitialize)this.dataGridViewTaobaoQiang).EndInit();
		this.groupBoxTaobaoQing.ResumeLayout(false);
		((ISupportInitialize)this.dataGridViewCmsPlan).EndInit();
		((ISupportInitialize)this.dataGridViewTaobaoQing).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			this.linkLabel1.Links[0].LinkData = string.Concat("http://", ᝮ.ᜆ);
			Process.Start(e.Link.LinkData.ToString());
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[linkLabel1_LinkClicked]出错，", exception.ToString()));
		}
	}

	private void linkLabelBridgeHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.smgz.com/3768.html");
	}

	private void linkLabelFollowHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_391(3);
	}

	private void linkLabelGetPromot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				this.ᝡ_0 = null;
				this.ᝡ_1 = null;
				this.method_297(0);
				this.method_299(0);
			}
			else
			{
				this.method_115("登录以后再查看和修改PID！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[linkLabelGetPromot_LinkClicked]出错：", exception.ToString()));
		}
	}

	private void linkLabelGetWeixinPromot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				this.ᝡ_2 = null;
				this.method_301(0);
			}
			else
			{
				this.method_115("登录以后再查看和修改微信推广位！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[linkLabelGetWeixinPromot_LinkClicked]出错：", exception.ToString()));
		}
	}

	private void linkLabelGuid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(string.Concat("http://", ᝮ.ᜆ, "/7.html"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[linkLabelGuid_LinkClicked]出错，", exception.ToString()));
		}
	}

	private void linkLabelHelpCMSPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_391(1);
	}

	private void linkLabelHelpOrderCmb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_391(5);
	}

	private void linkLabelHot1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_178((GClass16)this.linkLabelHot1.Tag);
	}

	private void linkLabelHot2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_178((GClass16)this.linkLabelHot2.Tag);
	}

	private void linkLabelLnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_391(2);
	}

	private void linkLabelPromotPosition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(string.Concat("http://", ᝮ.ᜆ, "/7.html#%E9%98%BF%E9%87%8C%E5%A6%88%E5%A6%88PID%E8%AE%BE%E7%BD%AE"));
	}

	private void linkLabelPyq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		this.method_391(4);
	}

	private void linkLabelVipCharge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			this.linkLabelVipCharge.Links[0].LinkData = "http://vip.smgz.com/";
			Process.Start(e.Link.LinkData.ToString());
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[linkLabelVipCharge_LinkClicked]出错，", exception.ToString()));
		}
	}

	public void method_0()
	{
		this.string_17 = GClass13.smethod_27(string.Concat(this.string_41, "\\config\\微信发群模板"), 1);
		this.string_18 = GClass13.smethod_27(string.Concat(this.string_41, "\\config\\微信发群模板"), 2);
		this.string_19 = GClass13.smethod_27(string.Concat(this.string_41, "\\config\\微信发群模板"), 3);
	}

	private void method_1()
	{
		while (true)
		{
			try
			{
				if (this.ᜐ_0.ᜊ <= 0)
				{
					this.method_2("当前在线人数[-]");
				}
				else
				{
					this.method_2(string.Concat("当前在线人数[", this.ᜐ_0.ᜊ, "]"));
				}
			}
			catch
			{
			}
			Thread.Sleep(60000);
		}
	}

	public string method_10()
	{
		string str;
		try
		{
			if (base.InvokeRequired)
			{
				AliBridgeForm.GDelegate56 gDelegate56 = new AliBridgeForm.GDelegate56(this.method_10);
				base.BeginInvoke(gDelegate56, new object[0]);
			}
			string text = this.Text;
			str = (!text.Contains(this.string_55) ? text : text.Replace(this.string_55, ""));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[GetFormTitle]出错，", exception.ToString()));
			str = "";
		}
		return str;
	}

	private double method_100(double double_1)
	{
		return Math.Round(double_1, 2);
	}

	private void method_101()
	{
		try
		{
			this.method_115("开始下载阿里妈妈订单。");
			ArrayList arrayLists = this.method_104(this.string_24, this.string_25);
			if (arrayLists != null)
			{
				this.method_115(string.Concat("下载阿里妈妈订单成功！共【", arrayLists.Count, "】条数据。"));
				this.method_115("开始更新阿里妈妈订单。");
				int num = this.method_105(arrayLists, this.string_33);
				this.method_115(string.Concat("更新阿里妈妈订单成功！更新【", num, "】条数据。"));
				this.method_103();
			}
			else
			{
				this.method_103();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[syncDataByDays]", exception.ToString()));
			this.method_103();
		}
	}

	public void method_102()
	{
		try
		{
			if (!base.InvokeRequired)
			{
				this.buttonDlOnlineOdr.Enabled = false;
				this.buttonSchAliOdr.Enabled = false;
				this.buttonBatch.Enabled = false;
				this.buttonUpdAliOder.Enabled = false;
				this.buttonLoadOrders.Enabled = false;
				this.buttonClrOdrSchCond.Enabled = false;
				this.buttonClrAliOdrDb.Enabled = false;
			}
			else
			{
				AliBridgeForm.GDelegate62 gDelegate62 = new AliBridgeForm.GDelegate62(this.method_102);
				base.BeginInvoke(gDelegate62, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[DisableBtn]出错啦", exception.ToString()));
		}
	}

	public void method_103()
	{
		try
		{
			if (!this.buttonUpdAliOder.InvokeRequired)
			{
				this.buttonDlOnlineOdr.Enabled = true;
				this.buttonSchAliOdr.Enabled = true;
				this.buttonBatch.Enabled = true;
				this.buttonUpdAliOder.Enabled = true;
				this.buttonUpdAliOder.Text = "下载订单";
				this.buttonLoadOrders.Enabled = true;
				this.buttonClrOdrSchCond.Enabled = true;
				this.buttonClrAliOdrDb.Enabled = true;
			}
			else
			{
				AliBridgeForm.GDelegate63 gDelegate63 = new AliBridgeForm.GDelegate63(this.method_103);
				base.BeginInvoke(gDelegate63, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[EnableBtn]出错啦", exception.ToString()));
		}
	}

	public ArrayList method_104(string string_96, string string_97)
	{
		ArrayList arrayLists;
		ArrayList arrayLists1 = new ArrayList();
		try
		{
			this.method_115("检查阿里妈妈登录！");
			if (ᜃ.ᜋ(this.string_20))
			{
				this.method_115("登录阿里妈妈成功！");
				this.method_115("正在下载数据。。。*****【大牛请注意：阿里妈妈一次最多下载10000条数据，选择好下载范围】******");
				DateTime now = DateTime.Now;
				string str = string.Concat("temp", now.ToString("yyyyMMddHHmmss"), ".xls");
				string str1 = string.Concat(this.string_41, "\\config\\", str);
				if (File.Exists(str1))
				{
					File.Delete(str1);
				}
				string str2 = "http://pub.alimama.com/report/getTbkPaymentDetails.json?queryType=1&payStatus=&DownloadID=DOWNLOAD_REPORT_INCOME_NEW&startTime={startTime}&endTime={endTime}";
				str2 = str2.Replace("{startTime}", string_96).Replace("{endTime}", string_97);
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
				webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
				webClient.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
				webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
				webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
				webClient.Headers.Add("Cookie", this.string_20);
				webClient.DownloadFile(str2, str1);
				arrayLists1 = GClass41.smethod_1(str1, out this.string_23);
				if (!"".Equals(this.string_23))
				{
					this.method_115(string.Concat("解析订单EXCEL文件出错，", this.string_23));
					if ((!File.Exists(string.Concat(this.string_41, "\\Microsoft.Office.Interop.Excel.dll")) ? true : !File.Exists(string.Concat(this.string_41, "\\office.dll"))))
					{
						this.method_115("联系作者解决此问题,462389496!");
					}
					else
					{
						arrayLists1 = GClass3.smethod_0(str1, out this.string_23);
						if (!"".Equals(this.string_23))
						{
							this.method_115(string.Concat("解析订单EXCEL文件出错2，", this.string_23));
						}
					}
				}
				File.Delete(str1);
			}
			else
			{
				this.method_115("没有登录阿里妈妈！");
				this.bool_0 = false;
				this.method_7();
				arrayLists = null;
				return arrayLists;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[downloadAlimama]", exception.ToString()));
		}
		arrayLists = arrayLists1;
		return arrayLists;
	}

	private int method_105(ArrayList arrayList_26, string string_96)
	{
		int num;
		int num1 = 0;
		try
		{
			for (int i = 0; i < arrayList_26.Count; i++)
			{
				int num2 = this.method_106(i, arrayList_26);
				if (num2 <= 1)
				{
					᜴ item = (᜴)arrayList_26[i];
					string str = "select * from aliorder where taobaoTradeId='{taobaoTradeId}' and auctionId='{auctionId}';";
					str = str.Replace("{taobaoTradeId}", item.ᜁ).Replace("{auctionId}", item.ᜂ);
					ArrayList arrayLists = this.gclass42_0.method_3(str, out this.string_23);
					if (arrayLists == null)
					{
						this.method_115(string.Concat("搜索订单出错：", this.string_23));
						num = 0;
						return num;
					}
					else if (arrayLists.Count != 0)
					{
						᜴ _᜴ = (᜴)arrayLists[0];
						if (item.ᜅ != _᜴.ᜅ)
						{
							string str1 = "";
							if (item.ᜅ.Equals("12"))
							{
								if (_᜴.ᜅ.Equals("11"))
								{
									str1 = "update aliorder set payStatus=12,totalAlipayFeeString='{totalAlipayFeeString}',feeString='{feeString}',payPubTime='{payPubTime}' where oid={oid};";
									str1 = str1.Replace("{totalAlipayFeeString}", item.ᜇ).Replace("{feeString}", item.ᜈ).Replace("{oid}", string.Concat(_᜴.ᜀ, ""));
								}
							}
							else if (!(item.ᜅ.Equals("14") ? false : !item.ᜅ.Equals("3")))
							{
								if ((_᜴.ᜅ.Equals("11") || _᜴.ᜅ.Equals("12") ? true : _᜴.ᜅ.Equals("14")))
								{
									str1 = "update aliorder set payStatus={payStatus},totalAlipayFeeString='{totalAlipayFeeString}',feeString='{feeString}',payPubTime='{payPubTime}' where oid={oid};";
									str1 = str1.Replace("{payStatus}", item.ᜅ).Replace("{totalAlipayFeeString}", item.ᜇ).Replace("{feeString}", item.ᜈ).Replace("{payPubTime}", item.ᜋ).Replace("{oid}", string.Concat(_᜴.ᜀ, ""));
								}
							}
							else if (item.ᜅ.Equals("13"))
							{
								if ((_᜴.ᜅ.Equals("11") || _᜴.ᜅ.Equals("12") || _᜴.ᜅ.Equals("14") ? true : _᜴.ᜅ.Equals("3")))
								{
									str1 = "update aliorder set payStatus=13,totalAlipayFeeString='0',feeString='0',payPubTime='{payPubTime}' where oid={oid};";
									str1 = str1.Replace("{payPubTime}", _᜴.ᜋ).Replace("{oid}", string.Concat(_᜴.ᜀ, ""));
								}
							}
							if (str1.Equals(""))
							{
								string[] strArrays = new string[] { "订单状态判断错误！订单号：【", item.ᜁ, "】，订单创建时间：【", item.ᜊ, "】数据库订单状态【", _᜴.ᜅ, "】阿里妈妈订单状态【", item.ᜅ, "】" };
								this.method_115(string.Concat(strArrays));
							}
							else if (!this.gclass42_0.method_7(str1, out this.string_23))
							{
								this.method_115(string.Concat("插入订单出错，订单号【", item.ᜁ, "】：", this.string_23));
								num = 0;
								return num;
							}
							else
							{
								num1++;
							}
						}
					}
					else
					{
						item.ᜎ = string_96;
						if (!this.gclass42_0.method_2(item, out this.string_23))
						{
							this.method_115(string.Concat("插入订单出错，订单号【", item.ᜁ, "】：", this.string_23));
							num = 0;
							return num;
						}
						else
						{
							num1++;
						}
					}
				}
				else
				{
					i = i + num2 - 1;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[syncData]", exception.ToString()));
		}
		num = num1;
		return num;
	}

	public int method_106(int int_28, ArrayList arrayList_26)
	{
		int num;
		int num1 = 0;
		try
		{
			᜴ item = (᜴)arrayList_26[int_28];
			for (int i = int_28; i < arrayList_26.Count; i++)
			{
				᜴ _᜴ = (᜴)arrayList_26[i];
				if ((!item.ᜁ.Equals(_᜴.ᜁ) ? true : !item.ᜂ.Equals(_᜴.ᜂ)))
				{
					break;
				}
				num1++;
			}
			if (num1 > 1)
			{
				string str = "delete from aliorder where taobaoTradeId='{taobaoTradeId}' and auctionId='{auctionId}';";
				str = str.Replace("{taobaoTradeId}", item.ᜁ).Replace("{auctionId}", item.ᜂ);
				if (this.gclass42_0.method_7(str, out this.string_23))
				{
					int num2 = 0;
					while (num2 < num1)
					{
						᜴ string33 = (᜴)arrayList_26[int_28 + num2];
						string33.ᜎ = this.string_33;
						if (!this.gclass42_0.method_2(string33, out this.string_23))
						{
							this.method_115(string.Concat("插入订单出错，订单号【", string33.ᜁ, "】：", this.string_23));
							num = 0;
							return num;
						}
						else
						{
							num2++;
						}
					}
				}
				else
				{
					this.method_115(string.Concat("插入订单出错，订单号【", item.ᜁ, "】：", this.string_23));
					num = 0;
					return num;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[doNextDup]出错：", exception.ToString()));
		}
		num = num1;
		return num;
	}

	private void method_107()
	{
		try
		{
			this.dateTimePickerSchOdrStt.MaxDate = DateTime.Now;
			this.dateTimePickerSchOdrEnd.MaxDate = DateTime.Now;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[setSchAliOdrDateTimeePicker]出错，", exception.ToString()));
		}
	}

	public void method_108()
	{
		try
		{
			this.method_102();
			string str = DateTime.Now.ToString("yyyy-MM-dd");
			this.arrayList_2 = this.method_104(str, str);
			if (this.arrayList_2 != null)
			{
				this.method_115(string.Concat("下载阿里妈妈订单成功！共【", this.arrayList_2.Count, "】条数据。"));
				this.method_115("开始更新阿里妈妈订单。");
				int num = this.method_105(this.arrayList_2, this.string_33);
				this.method_115(string.Concat("更新阿里妈妈订单成功！更新【", num, "】条数据。"));
				string str1 = "select * from aliorder ";
				string str2 = string.Concat(str, " 00:00:00");
				string str3 = string.Concat(str, " 23:59:59");
				string[] strArrays = new string[] { " where tbTradeCreateTime >= '", str2, "' and tbTradeCreateTime <='", str3, "' " };
				string str4 = string.Concat(strArrays);
				if (!"".Equals(this.textBoxOrderSch.Text.Trim()))
				{
					str4 = string.Concat(str4, " and  taobaoTradeId like '%", this.textBoxOrderSch.Text.Trim(), "'  ");
				}
				if (!"".Equals(this.textBoxProductID.Text.Trim()))
				{
					strArrays = new string[] { str4, " and ( auctionId='", this.textBoxProductID.Text.Trim(), "' or auctionTitle like '%", this.textBoxProductID.Text.Trim(), "%' ) " };
					str4 = string.Concat(strArrays);
				}
				str1 = string.Concat(str1, str4, " order by tbTradeCreateTime desc");
				this.arrayList_2 = this.gclass42_0.method_3(str1, out this.string_23);
				if (this.arrayList_2 == null)
				{
					this.method_115(string.Concat("搜索订单出错：", this.string_23));
					this.arrayList_2 = new ArrayList();
				}
				this.method_114(this.arrayList_2);
				this.method_103();
			}
			else
			{
				this.method_103();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[schTodayOrder]出错啦！", exception.ToString()));
		}
	}

	private void method_109()
	{
		try
		{
			this.method_115("开始搜索订单！");
			this.arrayList_2 = this.method_111();
			if (this.arrayList_2 != null)
			{
				this.method_114(this.arrayList_2);
				this.method_115("搜索完成！");
			}
			else
			{
				this.method_115("搜索订单出错，请重新搜索！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dlOrderList]出错啦！", exception.ToString()));
		}
	}

	public void method_11(FormWindowState formWindowState_0)
	{
		try
		{
			if (!base.InvokeRequired)
			{
				base.WindowState = formWindowState_0;
				if (formWindowState_0 == FormWindowState.Normal)
				{
					base.Activate();
				}
			}
			else
			{
				AliBridgeForm.GDelegate57 gDelegate57 = new AliBridgeForm.GDelegate57(this.method_11);
				object[] formWindowState0 = new object[] { formWindowState_0 };
				base.BeginInvoke(gDelegate57, formWindowState0);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[SetFormState]出错，", exception.ToString()));
		}
	}

	public int method_110(int int_28, ArrayList arrayList_26)
	{
		int num = 0;
		try
		{
			᜴ item = (᜴)arrayList_26[int_28];
			for (int i = int_28; i < arrayList_26.Count; i++)
			{
				᜴ _᜴ = (᜴)arrayList_26[i];
				if ((!item.ᜁ.Equals(_᜴.ᜁ) ? true : !item.ᜂ.Equals(_᜴.ᜂ)))
				{
					break;
				}
				num++;
			}
			if (num > 1)
			{
				for (int j = 0; j < this.arrayList_2.Count; j++)
				{
					᜴ item1 = (᜴)arrayList_26[j];
					if ((!item.ᜁ.Equals(item1.ᜁ) ? false : item.ᜂ.Equals(item1.ᜂ)))
					{
						this.arrayList_2.RemoveAt(j);
						j--;
					}
				}
				for (int k = 0; k < num; k++)
				{
					᜴ _᜴1 = (᜴)arrayList_26[int_28 + k];
					this.arrayList_2.Add(_᜴1);
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkdup]出错：", exception.ToString()));
		}
		return num;
	}

	private ArrayList method_111()
	{
		ArrayList arrayLists;
		try
		{
			string str = "select * from aliorder ";
			DateTime value = this.dateTimePickerSchOdrStt.Value;
			string str1 = string.Concat(value.ToString("yyyy-MM-dd"), " 00:00:00");
			value = this.dateTimePickerSchOdrEnd.Value;
			string str2 = string.Concat(value.ToString("yyyy-MM-dd"), " 23:59:59");
			string[] strArrays = new string[] { " where tbTradeCreateTime >= '", str1, "' and tbTradeCreateTime <='", str2, "' ", GClass13.smethod_8(this.comboBoxOrderSts.Text) };
			string str3 = string.Concat(strArrays);
			if (!"".Equals(this.textBoxProductID.Text))
			{
				strArrays = new string[] { str3, " and ( auctionId='", this.textBoxProductID.Text.Trim(), "' or auctionTitle like '%", this.textBoxProductID.Text.Trim(), "%' ) " };
				str3 = string.Concat(strArrays);
			}
			str = string.Concat(str, str3, " order by tbTradeCreateTime desc");
			ArrayList arrayLists1 = this.gclass42_0.method_3(str, out this.string_23);
			if (arrayLists1 == null)
			{
				this.method_115(string.Concat("搜索订单出错：", this.string_23));
				arrayLists1 = new ArrayList();
			}
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[schOrderFromDb]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	private string method_112(ArrayList arrayList_26)
	{
		string str;
		try
		{
			string str1 = "";
			foreach (string arrayList26 in arrayList_26)
			{
				bool flag = false;
				IEnumerator enumerator = this.arrayList_2.GetEnumerator();
				try
				{
					while (true)
					{
						if (!enumerator.MoveNext())
						{
							break;
						}
						else if (arrayList26.Equals(((᜴)enumerator.Current).ᜁ))
						{
							flag = true;
							break;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				if (flag)
				{
					continue;
				}
				if (!str1.Equals(""))
				{
					str1 = string.Concat(str1, ",");
				}
				str1 = string.Concat(str1, arrayList26);
			}
			str = str1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getNotExistOrder]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	public ArrayList method_113(ArrayList arrayList_26)
	{
		ArrayList arrayLists;
		try
		{
			string str = "";
			foreach (string arrayList26 in arrayList_26)
			{
				str = (!str.Equals("") ? string.Concat(str, ", '", arrayList26, "'") : string.Concat("'", arrayList26, "'"));
			}
			string str1 = string.Concat("select * from aliorder where taobaoTradeId in (", str, ");");
			ArrayList arrayLists1 = this.gclass42_0.method_3(str1, out this.string_23);
			if (arrayLists1 == null)
			{
				this.method_115(string.Concat("搜索订单出错：", this.string_23));
				arrayLists1 = new ArrayList();
			}
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[schOrderBatch]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	public void method_114(ArrayList arrayList_26)
	{
		object[] arrayList26;
		try
		{
			if (!base.InvokeRequired)
			{
				this.dataGridViewAliOdr.Rows.Clear();
				this.arrayList_3 = new ArrayList();
				this.arrayList_3.Add("全部");
				this.hashtable_1 = new Hashtable();
				float single = 0f;
				float single1 = 0f;
				int num = 0;
				foreach (᜴ _᜴ in arrayList_26)
				{
					if (!GClass13.smethod_9(_᜴.ᜅ, this.comboBoxOrderSts.Text))
					{
						continue;
					}
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewAliOdr.Rows.Add(dataGridViewRow);
					this.dataGridViewAliOdr.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
					this.dataGridViewAliOdr[0, num].Value = _᜴.ᜊ;
					this.dataGridViewAliOdr[1, num].Value = _᜴.ᜃ;
					this.dataGridViewAliOdr[2, num].Value = _᜴.ᜂ;
					this.dataGridViewAliOdr[3, num].Value = _᜴.ᜁ;
					this.dataGridViewAliOdr[4, num].Value = GClass13.smethod_7(string.Concat(_᜴.ᜅ, ""));
					this.dataGridViewAliOdr[4, num].Style.ForeColor = GClass13.smethod_6(string.Concat(_᜴.ᜅ, ""));
					this.dataGridViewAliOdr[5, num].Value = _᜴.ᜇ;
					single = single + float.Parse(_᜴.ᜇ);
					this.dataGridViewAliOdr[6, num].Value = _᜴.ᜉ;
					this.dataGridViewAliOdr[7, num].Value = _᜴.ᜈ;
					single1 = single1 + float.Parse(_᜴.ᜈ);
					this.dataGridViewAliOdr[8, num].Value = _᜴.ᜍ;
					this.dataGridViewAliOdr[9, num].Value = _᜴.ᜎ;
					num++;
					if (this.hashtable_1.ContainsKey(_᜴.ᜍ))
					{
						continue;
					}
					this.hashtable_1.Add(_᜴.ᜍ, _᜴.ᜍ);
					this.arrayList_3.Add(_᜴.ᜍ);
				}
				if (this.arrayList_3.Count > 2)
				{
					this.comboBoxPromotPsi.Items.Clear();
					foreach (string arrayList3 in this.arrayList_3)
					{
						this.comboBoxPromotPsi.Items.Add(arrayList3);
					}
				}
				double num1 = this.method_100((double)(single1 * 100f / (single == 0f ? 1f : single)));
				arrayList26 = new object[] { "共【", num, "】条订单，付款金额：【", this.method_100((double)single), "】元，效果估计：【", this.method_100((double)single1), "】元，平均佣金比例：【", num1, "%】，", null, null };
				arrayList26[9] = (num1 > 30 ? "佣金比例不错，继续加油" : "该加加油提高佣金比例啦");
				arrayList26[10] = "！";
				this.method_115(string.Concat(arrayList26));
			}
			else
			{
				AliBridgeForm.GDelegate64 gDelegate64 = new AliBridgeForm.GDelegate64(this.method_114);
				arrayList26 = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate64, arrayList26);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showAliOrder]出错：", exception.ToString()));
		}
	}

	private void method_115(string string_96)
	{
		string[] str;
		DateTime now;
		try
		{
			string text = this.richTextBoxSts.Text;
			if (text.Length <= 5000)
			{
				RichTextBox richTextBox = this.richTextBoxSts;
				str = new string[5];
				now = DateTime.Now;
				str[0] = now.ToString("yyyy年MM月dd日 HH:mm:ss");
				str[1] = "----";
				str[2] = string_96;
				str[3] = "\n";
				str[4] = text;
				richTextBox.Text = string.Concat(str);
			}
			else
			{
				RichTextBox richTextBox1 = this.richTextBoxSts;
				str = new string[5];
				now = DateTime.Now;
				str[0] = now.ToString("yyyy年MM月dd日 HH:mm:ss");
				str[1] = "----";
				str[2] = string_96;
				str[3] = "\n";
				str[4] = text.Substring(0, 2000);
				richTextBox1.Text = string.Concat(str);
			}
		}
		catch
		{
			this.method_116(string_96);
		}
	}

	public void method_116(string string_96)
	{
		try
		{
			if (!this.richTextBoxSts.InvokeRequired)
			{
				this.method_115(string_96);
			}
			else
			{
				AliBridgeForm.GDelegate65 gDelegate65 = new AliBridgeForm.GDelegate65(this.method_116);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate65, string96);
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			MessageBox.Show(string.Concat("[messageForThread]出错：", exception.ToString()));
		}
	}

	private bool method_117()
	{
		bool flag;
		try
		{
			string str = this.method_124();
			this.string_26 = ᝉ.ᜀ(str, 0, "\"sid\":", ",");
			this.string_27 = ᝉ.ᜀ(str, 0, "\"aid\":", ",");
			if ((this.string_35 == null || this.string_35.Equals("") || this.string_26 == null || this.string_26.Equals("") || this.string_27 == null || this.string_27.Equals("") ? this.bool_32 : true))
			{
				string[] string35 = new string[] { "mm_", this.string_35, "_", this.string_26, "_", this.string_27 };
				this.string_28 = string.Concat(string35);
				flag = true;
			}
			else
			{
				this.method_115("通用推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【软件设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【http://www.smgz.com/7.html#%E9%98%BF%E9%87%8C%E5%A6%88%E5%A6%88PID%E8%AE%BE%E7%BD%AE】");
				flag = false;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkCmAliPid]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private bool method_118()
	{
		bool flag;
		try
		{
			string str = this.method_125();
			string str1 = ᝉ.ᜀ(str, 0, "\"sid\":", ",");
			string str2 = ᝉ.ᜀ(str, 0, "\"aid\":", ",");
			if ((this.string_35 == null || this.string_35.Equals("") || str1 == null || str1.Equals("") || str2 == null || str2.Equals("") ? this.bool_32 : true))
			{
				string[] string35 = new string[] { "mm_", this.string_35, "_", str1, "_", str2 };
				this.string_29 = string.Concat(string35);
				GClass9.string_0 = this.string_29;
				flag = true;
			}
			else
			{
				this.method_115("鹊桥推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【软件设置】界面的【获取最新推广位】；\n也可以参考网页设置推广位：【http://www.smgz.com/7.html#%E9%98%BF%E9%87%8C%E5%A6%88%E5%A6%88PID%E8%AE%BE%E7%BD%AE】");
				flag = false;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkBrdgAliPid]出错：", exception.ToString()));
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
			this.string_30 = ᝉ.ᜀ(str, 0, "\"sid\":", ",");
			this.string_31 = ᝉ.ᜀ(str, 0, "\"aid\":", ",");
			if ((this.string_35 == null || this.string_35.Equals("") || this.string_30 == null || this.string_30.Equals("") || this.string_31 == null || this.string_31.Equals("") ? !this.bool_32 : true))
			{
				string[] string35 = new string[] { "mm_", this.string_35, "_", this.string_30, "_", this.string_31 };
				this.string_32 = string.Concat(string35);
				flag = true;
			}
			else
			{
				this.method_115("微信推广 - 阿里妈妈推广位设置错误！请在软件登录阿里妈妈成功后，点击【软件设置】界面的【获取微信推广位】；\n也可以参考网页设置微信推广位：【http://www.smgz.com/7.html#%E9%98%BF%E9%87%8C%E5%A6%88%E5%A6%88PID%E8%AE%BE%E7%BD%AE】");
				flag = false;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkWxAliPid]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public void method_12(int int_28, string string_96)
	{
		try
		{
			this.bool_1 = true;
			this.method_11(FormWindowState.Normal);
			if (int_28 == ᝮ.ᜀ)
			{
				this.bool_0 = true;
				this.string_20 = string_96;
				this.method_115(string.Concat("阿里妈妈登录完成，返回状态：【", (ᜃ.ᜋ(string_96) ? "登录成功" : "登录失败"), "】！"));
				if (this.thread_0 != null)
				{
					try
					{
						this.thread_0.Abort();
						this.thread_0 = null;
					}
					catch
					{
					}
				}
				this.thread_0 = new Thread(new ParameterizedThreadStart(ᜃ.ᜀ));
				this.thread_0.Start(this.string_20);
			}
			else if (int_28 == ᝮ.ᜁ)
			{
				this.bool_0 = false;
				this.method_115("网页无法打开！");
				if (this.checkBoxAutoLogin.Checked)
				{
					this.method_7();
				}
			}
			else if (int_28 == ᝮ.ᜂ)
			{
				this.bool_0 = false;
				this.method_115("检查登录成功页面超过8秒！");
				if (this.checkBoxAutoLogin.Checked)
				{
					this.method_7();
				}
			}
			else if (int_28 == ᝮ.ᜃ)
			{
				this.bool_0 = false;
				this.method_115("登录窗口被手动关闭，并且没有登录成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[processFormMsg]出错，", exception.ToString()));
		}
	}

	public bool method_120()
	{
		bool flag;
		int num = 0;
		while (true)
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				flag = true;
				break;
			}
			else
			{
				Thread.Sleep(100);
				if (num > 50)
				{
					flag = false;
					break;
				}
				else
				{
					num++;
				}
			}
		}
		return flag;
	}

	public bool method_121(IntPtr intptr_1, IntPtr intptr_2)
	{
		bool flag;
		StringBuilder stringBuilder = new StringBuilder();
		AliBridgeForm.GetWindowText(intptr_1, stringBuilder, stringBuilder.Capacity);
		if ((stringBuilder.ToString() == string.Empty ? false : stringBuilder.ToString().Contains("微信")))
		{
			StringBuilder stringBuilder1 = new StringBuilder();
			AliBridgeForm.GetClassName(intptr_1, stringBuilder1, 1000);
			if (!"WeChatMainWndForPC".Equals(stringBuilder1.ToString()))
			{
				flag = true;
				return flag;
			}
			this.intptr_0 = intptr_1;
			flag = true;
			return flag;
		}
		flag = true;
		return flag;
	}

	private void method_122()
	{
		try
		{
			if (File.Exists(this.string_42))
			{
				File.Delete(this.string_42);
			}
			FileStream fileStream = new FileStream(this.string_42, FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding("GB2312"));
			streamWriter.WriteLine(string.Concat("tmallonly=", (this.checkBoxTmallOnly.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("nonotstt=", (this.checkBoxNoNotStt.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("lowestcms=", this.textBoxLowestCms.Text.Trim()));
			streamWriter.WriteLine(string.Concat("otmallonly=", (this.checkBoxOTmallOnly.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("olowestcms=", this.textBoxOLowestCms.Text.Trim()));
			streamWriter.WriteLine(string.Concat("olowestsoldq=", this.textBoxOSoldQu.Text.Trim()));
			streamWriter.WriteLine(string.Concat("alimamaacc=", this.textBoxAlimamaAcc.Text.Trim()));
			streamWriter.WriteLine(string.Concat("alimamapwd=", this.textBoxAlimamaPwd.Text.Trim()));
			this.string_33 = this.textBoxAlimamaAcc.Text.Trim();
			this.string_34 = this.textBoxAlimamaPwd.Text.Trim();
			streamWriter.WriteLine(string.Concat("autologin=", (this.checkBoxAutoLogin.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("ordermainacc=", this.textBoxOrderMainAcc.Text.Trim()));
			this.string_39 = this.textBoxOrderMainAcc.Text.Trim();
			streamWriter.WriteLine(string.Concat("wxpromot=", (this.checkBoxWxPromot.Checked ? "1" : "0")));
			if (this.checkBoxWxPromot.Checked)
			{
				this.method_119();
			}
			int num = 0;
			if (this.radioButtonCmMWeb.Checked)
			{
				num = 1;
			}
			if (this.radioButtonCmMApp.Checked)
			{
				num = 2;
			}
			if (this.radioButtonCmMOth.Checked)
			{
				num = 3;
			}
			streamWriter.WriteLine(string.Concat("alimamacmmedia=", num));
			streamWriter.WriteLine(string.Concat("alimamacmpid=", this.method_124()));
			this.method_117();
			int num1 = 0;
			if (this.radioButtonBrdgMWeb.Checked)
			{
				num1 = 1;
			}
			if (this.radioButtonBrdgMApp.Checked)
			{
				num1 = 2;
			}
			if (this.radioButtonBrdgMOth.Checked)
			{
				num1 = 3;
			}
			streamWriter.WriteLine(string.Concat("alimamabrdgmedia=", num1));
			streamWriter.WriteLine(string.Concat("alimamabrdgpid=", this.method_125()));
			this.method_118();
			streamWriter.WriteLine(string.Concat("alimamawxpid=", this.method_126()));
			streamWriter.WriteLine(string.Concat("couponitemcmb=", (this.checkBoxCouponItem.Checked ? "1" : "0")));
			this.bool_3 = this.checkBoxCouponItem.Checked;
			streamWriter.WriteLine(string.Concat("qqaddkouling=", (this.checkBoxQQKouling.Checked ? "1" : "0")));
			this.bool_4 = this.checkBoxQQKouling.Checked;
			streamWriter.WriteLine(string.Concat("shorturl=", (this.checkBoxShortUrl.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("uuWiseAcc=", this.textBoxUUUsername.Text.Trim()));
			streamWriter.WriteLine(string.Concat("uuWisePwd=", this.textBoxUUPwd.Text.Trim()));
			this.string_44 = this.textBoxUUUsername.Text.Trim();
			this.string_45 = this.textBoxUUPwd.Text.Trim();
			streamWriter.WriteLine(string.Concat("tmswwindow=", this.textBoxTmSwWindow.Text.Trim()));
			streamWriter.WriteLine(string.Concat("tmpaste=", this.textBoxTmPasete.Text.Trim()));
			streamWriter.WriteLine(string.Concat("tmsnd=", this.textBoxTmSnd.Text.Trim()));
			streamWriter.WriteLine(string.Concat("wxpicdelay=", this.textBoxWxPicDelay.Text.Trim()));
			streamWriter.WriteLine(string.Concat("sndctrlenter=", (this.radioButtonSndCtrlEnter.Checked ? "1" : "0")));
			this.int_6 = int.Parse(this.textBoxTmSwWindow.Text.Trim());
			this.int_7 = int.Parse(this.textBoxTmPasete.Text.Trim());
			this.int_8 = int.Parse(this.textBoxTmSnd.Text.Trim());
			this.int_9 = int.Parse(this.textBoxWxPicDelay.Text.Trim());
			this.bool_8 = this.radioButtonSndEnter.Checked;
			streamWriter.WriteLine(string.Concat("couponcheck=", (this.checkBoxChkCoupon.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("couponlwnum=", this.textBoxCouponLwNum.Text.Trim()));
			if (this.radioButtonSvrFollow.Checked)
			{
				this.int_4 = 0;
			}
			else if (this.radioButtonQQFollow.Checked)
			{
				this.int_4 = 1;
			}
			else if (this.radioButtonQYFollow.Checked)
			{
				this.int_4 = 2;
			}
			else if (this.radioButtonSelHotShare.Checked)
			{
				this.int_4 = 3;
			}
			else if (this.radioButtonQYFcFollow.Checked)
			{
				this.int_4 = 4;
			}
			streamWriter.WriteLine(string.Concat("followsndtype=", this.int_4));
			streamWriter.WriteLine(string.Concat("qqpluspath=", this.textBoxQQPlusPath.Text));
			streamWriter.WriteLine(string.Concat("followsndinteval=", this.textBoxFollowSndInteval.Text.Trim()));
			streamWriter.WriteLine(string.Concat("chgfwsndpid=", (this.checkBoxChgFwSndPid.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("nolnknofw=", (this.checkBoxNoLnkNoFw.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("qqgrpfw=", (this.checkBoxQQGrpFw.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("fwmainuser=", this.textBoxFwMainUser.Text.Trim()));
			streamWriter.WriteLine(string.Concat("notfwhour=", this.textBoxNotFwHour.Text.Trim()));
			streamWriter.WriteLine(string.Concat("fwcouponlwnum=", this.textBoxFwCouponLwNum.Text.Trim()));
			streamWriter.WriteLine(string.Concat("lowestfwcms=", this.textBoxLowestFwCms.Text.Trim()));
			streamWriter.WriteLine(string.Concat("uphotshare=", (this.checkBoxUpHotShare.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("followsend=", (this.checkBoxFollowSend.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("minform=", (this.checkBoxMinForm.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("closewinwhilesnded=", (this.checkBoxCloseWinWhileSnded.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("sndaddstrflg=", (this.checkBoxSndAddStr.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("sndaddstr=", this.textBoxSndAddStr.Text));
			streamWriter.WriteLine(string.Concat("sndaddtime=", (this.checkBoxSndAddtime.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("sndaddrdm=", (this.checkBoxSndAddRdm.Checked ? "1" : "0")));
			this.bool_9 = this.checkBoxSndAddStr.Checked;
			this.string_40 = this.textBoxSndAddStr.Text;
			this.bool_10 = this.checkBoxSndAddtime.Checked;
			this.bool_11 = this.checkBoxSndAddRdm.Checked;
			streamWriter.WriteLine(string.Concat("runningTask=", (this.bool_21 ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("taskinteval=", this.textBoxTaskInteval.Text.Trim()));
			if (!this.bool_21)
			{
				streamWriter.WriteLine("taskstarttime=0");
			}
			else
			{
				DateTime value = this.dateTimePickerTaskStart.Value;
				streamWriter.WriteLine(string.Concat("taskstarttime=", value.ToString("yyyy-MM-dd HH:mm")));
			}
			streamWriter.WriteLine(string.Concat("clrafterconvert=", (this.checkBoxClrAfterConvert.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("batchconvert=", (this.checkBoxBatchConvert.Checked ? "1" : "0")));
			streamWriter.WriteLine(string.Concat("appcmsreson=", this.textBoxAppCmsReson.Text.Trim()));
			this.string_36 = this.textBoxAppCmsReson.Text.Trim();
			streamWriter.WriteLine(string.Concat("cmsplanpriority=", (this.radioButtonHiCms.Checked ? "1" : "2")));
			if (this.radioButtonShXL.Checked)
			{
				this.int_5 = 0;
			}
			else if (this.radioButtonShBD.Checked)
			{
				this.int_5 = 1;
			}
			else if (this.radioButton2in1Qyu.Checked)
			{
				this.int_5 = 2;
			}
			streamWriter.WriteLine(string.Concat("shorturltype=", this.int_5));
			try
			{
				this.double_0 = double.Parse(this.textBoxTQQLCms.Text.Trim());
				streamWriter.WriteLine(string.Concat("tqqlcms=", this.textBoxTQQLCms.Text.Trim()));
			}
			catch
			{
				streamWriter.WriteLine("tqqlcms=10");
				this.double_0 = 10;
			}
			streamWriter.WriteLine(string.Concat("imgzipper=", this.textBoxImgZipPer.Text));
			streamWriter.WriteLine(string.Concat("usetemplate=", (this.checkBoxUseTemp.Checked ? "1" : "0")));
			this.bool_6 = this.checkBoxUseTemp.Checked;
			streamWriter.WriteLine(string.Concat("tempcinmdl=", (this.checkBoxTempCInMdl.Checked ? "1" : "0")));
			this.bool_7 = this.checkBoxTempCInMdl.Checked;
			streamWriter.WriteLine(string.Concat("adddb12=", (this.checkBoxAdd1212.Checked ? "1" : "0")));
			this.bool_13 = this.checkBoxAdd1212.Checked;
			streamWriter.Flush();
			streamWriter.Close();
			streamWriter.Dispose();
			fileStream.Close();
			fileStream.Dispose();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[saveConfig]", exception.ToString()));
		}
	}

	private void method_123()
	{
		// 
		// Current member / type: System.Void AliBridgeForm::method_123()
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void method_123()
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private string method_124()
	{
		string str;
		try
		{
			GClass24 selectedItem = (GClass24)this.comboBoxCmPUnit.SelectedItem;
			if (selectedItem == null)
			{
				selectedItem = new GClass24();
			}
			object[] objArray = new object[] { "\"sid\":", selectedItem.method_2(), ",\"sname\":\"", selectedItem.method_0(), "\"" };
			string str1 = string.Concat(objArray);
			GClass24 gClass24 = (GClass24)this.comboBoxCmPPos.SelectedItem;
			if (gClass24 == null)
			{
				gClass24 = new GClass24();
			}
			objArray = new object[] { "\"aid\":", gClass24.method_2(), ",\"aname\":\"", gClass24.method_0(), "\"" };
			string str2 = string.Concat(objArray);
			string[] string35 = new string[] { "\"memid\":", this.string_35, ",", str1, ",", str2 };
			str = string.Concat(string35);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getCmPidStr]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private string method_125()
	{
		string str;
		try
		{
			GClass24 selectedItem = (GClass24)this.comboBoxBrdgPUnit.SelectedItem;
			if (selectedItem == null)
			{
				selectedItem = new GClass24();
			}
			object[] objArray = new object[] { "\"sid\":", selectedItem.method_2(), ",\"sname\":\"", selectedItem.method_0(), "\"" };
			string str1 = string.Concat(objArray);
			GClass24 gClass24 = (GClass24)this.comboBoxBrdgPPos.SelectedItem;
			if (gClass24 == null)
			{
				gClass24 = new GClass24();
			}
			objArray = new object[] { "\"aid\":", gClass24.method_2(), ",\"aname\":\"", gClass24.method_0(), "\"" };
			string str2 = string.Concat(objArray);
			string[] string35 = new string[] { "\"memid\":", this.string_35, ",", str1, ",", str2 };
			str = string.Concat(string35);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBrdgPidStr]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private string method_126()
	{
		string str;
		try
		{
			GClass24 selectedItem = (GClass24)this.comboBoxWxPUnit.SelectedItem;
			if (selectedItem == null)
			{
				selectedItem = new GClass24();
			}
			object[] objArray = new object[] { "\"sid\":", selectedItem.method_2(), ",\"sname\":\"", selectedItem.method_0(), "\"" };
			string str1 = string.Concat(objArray);
			GClass24 gClass24 = (GClass24)this.comboBoxWxPPos.SelectedItem;
			if (gClass24 == null)
			{
				gClass24 = new GClass24();
			}
			objArray = new object[] { "\"aid\":", gClass24.method_2(), ",\"aname\":\"", gClass24.method_0(), "\"" };
			string str2 = string.Concat(objArray);
			string[] string35 = new string[] { "\"memid\":", this.string_35, ",", str1, ",", str2 };
			str = string.Concat(string35);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getWxPidStr]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private void method_127()
	{
		try
		{
			this.method_115("正在登录打码兔平台！");
			uint num = 0;
			ᜱ.D2Balance(this.string_43, this.string_44, this.string_45, ref num);
			this.method_115(string.Concat("登录成功！分数：【", num, "】"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[uuWiseLogin]出错了！", exception.ToString()));
		}
	}

	private void method_128()
	{
		try
		{
			if (!(!this.bool_18 ? true : this.method_136(this.string_80, 0)))
			{
				if (ᜃ.ᜋ(this.string_20))
				{
					int num = this.method_139();
					if (num == -1)
					{
						this.method_134();
						this.method_115("PID转换失败，取消发送！");
						return;
					}
					else if (num == 1)
					{
						this.method_134();
						this.method_115("产品的佣金计划处于【审核中】状态，用户选择取消发送！");
						return;
					}
				}
				else
				{
					this.method_134();
					this.method_115("PID不正确，登录阿里妈妈以后再点发送！");
					this.bool_0 = false;
					this.method_7();
					return;
				}
			}
			else if ((this.int_26 == 2 ? false : this.int_26 != 4))
			{
				this.bool_34 = this.method_135(this.string_80);
			}
			else
			{
				this.bool_34 = true;
			}
			if ((!this.bool_18 ? true : this.method_131()))
			{
				if (this.bool_34)
				{
					try
					{
						᝕ _u1755 = ᜤ.ᜅ(this.string_83);
						if (!this.bool_16)
						{
							this.method_115(string.Concat("优惠券数量提醒！******", _u1755.ᜄ(), "******"));
						}
						else if (_u1755.ᜁ < this.int_10)
						{
							this.method_115(string.Concat("优惠券数量不够，停止发送！******", _u1755.ᜄ(), "******"));
							return;
						}
					}
					catch
					{
						this.method_115("没有查出来优惠券数量，请人工检查！");
					}
				}
				this.string_48 = this.string_81;
				if (this.bool_14)
				{
					this.method_130();
				}
				if (this.bool_15)
				{
					this.method_132(1);
				}
				if (this.bool_13)
				{
					this.string_47 = this.method_129();
					this.string_48 = string.Concat(this.string_48, "<BR>点击进入双12主会场抢红包：", this.string_47);
				}
				if (this.bool_19)
				{
					this.thread_1.Resume();
					this.bool_19 = false;
					this.bool_20 = false;
				}
				else
				{
					this.int_11 = 0;
					if (!this.bool_32)
					{
						this.thread_1 = new Thread(new ThreadStart(this.method_148));
					}
					else
					{
						this.thread_1 = new Thread(new ThreadStart(this.method_150));
					}
					this.thread_1.Start();
					this.bool_20 = false;
				}
			}
			else
			{
				this.method_115("出错啦，重新点【发送】！");
				this.method_134();
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_134();
			this.method_115(string.Concat("[doSend]出错：", exception.ToString()));
		}
	}

	public string method_129()
	{
		string[] string35;
		if (this.string_47.Equals(""))
		{
			if (this.bool_32)
			{
				string string46 = this.string_46;
				string35 = new string[] { "mm_", this.string_35, "_", this.string_30, "_", this.string_31 };
				this.string_47 = string46.Replace("{pid}", string.Concat(string35));
			}
			else
			{
				string str = this.string_46;
				string35 = new string[] { "mm_", this.string_35, "_", this.string_26, "_", this.string_27 };
				this.string_47 = str.Replace("{pid}", string.Concat(string35));
			}
			this.string_47 = this.method_205(this.string_47, 3);
		}
		return this.string_47;
	}

	private void method_13()
	{
		try
		{
			this.webBrowserConvert.ScriptErrorsSuppressed = true;
			this.webBrowserConvert.Navigate("about:blank");
			this.webBrowserConvert.IsWebBrowserContextMenuEnabled = false;
			this.webBrowserConvert.Document.ExecCommand("EditMode", false, null);
			this.webBrowserConvert.Document.ExecCommand("LiveResize", false, null);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initWbConvert]出错，", exception.ToString()));
		}
	}

	public void method_130()
	{
		if (!GClass0.smethod_0(this.ᜐ_0.ᜁ, this.string_48, out this.string_23))
		{
			this.method_115(string.Concat("跟发上传失败！", this.string_23));
		}
		else
		{
			this.method_115("跟发上传成功！");
		}
	}

	public bool method_131()
	{
		bool flag;
		foreach (GClass25 arrayList5 in this.arrayList_5)
		{
			if (!arrayList5.string_2.Contains("err.taobao.com"))
			{
				continue;
			}
			flag = false;
			return flag;
		}
		flag = true;
		return flag;
	}

	public void method_132(int int_28)
	{
		if (!"".Equals(this.string_78))
		{
			object[] int28 = new object[] { "type=checkhotshareitemid&hottype=", int_28, "&itemid=", this.string_78 };
			string str = string.Concat(int28);
			if (!"ok".Equals(this.method_17(this.ᝠ_0, this.string_3, str)))
			{
				this.method_115(string.Concat("爆款分享内容已经存在，不上传！", this.string_79));
			}
			else if ((this.arrayList_5 == null ? false : this.arrayList_5.Count != 0))
			{
				GClass16 gClass16 = new GClass16()
				{
					int_0 = int_28,
					string_1 = this.string_78,
					string_2 = this.string_79,
					string_3 = string.Concat(this.method_100((double)(this.float_2 - this.float_3)), ""),
					string_4 = string.Concat(this.method_100((double)this.float_4), "")
				};
				if (!GClass0.smethod_1(this.ᜐ_0.ᜁ, gClass16, this.string_48, out this.string_23))
				{
					this.method_115(string.Concat("爆款上传失败！", this.string_23));
				}
				else
				{
					int28 = new object[] { "爆款上传成功！【标题：", this.string_79, "，优惠券：", this.float_3, "，价格：", this.float_2 - this.float_3, "，爆款佣金比例：", this.float_4, "】" };
					this.method_115(string.Concat(int28));
				}
			}
			else
			{
				this.method_115("爆款分享内容没有产品链接，不上传！");
			}
		}
		else
		{
			this.method_115("没有产品不上传爆款！");
		}
	}

	public void method_133()
	{
		this.method_154(1, false, "发送");
		this.method_154(2, true, "");
		this.method_154(3, true, "");
	}

	public void method_134()
	{
		this.method_154(1, true, "发送");
		this.method_154(2, false, "");
		this.method_154(3, false, "");
	}

	public bool method_135(string string_96)
	{
		bool flag;
		try
		{
			foreach (Match match in (new Regex(this.string_82)).Matches(string_96))
			{
				string str = match.Value.ToString();
				if ((!str.Contains("coupon") || !str.Contains("taobao.com") ? false : !str.Contains("uland.taobao.com")))
				{
					this.string_83 = str;
					flag = true;
					return flag;
				}
				else
				{
					string str1 = ᜤ.ᜀ(str, str);
					if ((!str1.Contains("coupon") || !str1.Contains("taobao.com") ? false : !str.Contains("uland.taobao.com")))
					{
						this.string_83 = str1;
						flag = true;
						return flag;
					}
					else
					{
						Thread.Sleep(150);
					}
				}
			}
			flag = false;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[couponUrlCheck]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public bool method_136(string string_96, int int_28)
	{
		bool flag;
		try
		{
			this.arrayList_5 = new ArrayList();
			foreach (Match match in (new Regex(this.string_82)).Matches(string_96))
			{
				string str = match.Value.ToString();
				if (((str.Contains("taobao.com") || str.Contains("tmall.com") || str.Contains("yao.95095.com")) && str.Contains("item.htm") && str.Contains("id=") ? true : str.Contains("detail.ju.taobao.com")))
				{
					this.method_137(str, GClass13.smethod_0(str));
					flag = false;
					return flag;
				}
				else
				{
					string str1 = ᜤ.ᜀ(str, str);
					if ((!str1.Contains("coupon") ? true : !str1.Contains("taobao.com")))
					{
						if (str1.Contains("detail.ju.taobao.com"))
						{
							this.method_137(str, GClass13.smethod_0(str1));
							if (!this.method_138(str1))
							{
								flag = false;
								return flag;
							}
						}
						else if (str1.Contains("item.htm?id="))
						{
							this.method_137(str, GClass13.smethod_0(str1));
							if (!this.method_138(str1))
							{
								flag = false;
								return flag;
							}
						}
						else if (((str1.Contains("taobao.com") || str1.Contains("tmall.com") || str1.Contains("yao.95095.com")) && str1.Contains("item.htm") ? str1.Contains("id=") : false))
						{
							this.method_137(str, GClass13.smethod_0(str1));
							flag = false;
							return flag;
						}
						else if (str1.Contains("shop/view_shop.htm?user_number_id="))
						{
							this.method_137(str, GClass13.smethod_0(str1));
							if (!this.method_138(str1))
							{
								flag = false;
								return flag;
							}
						}
						else if (!str1.Contains("temai.taobao.com"))
						{
							if ((str1.Contains("taobao.com") || str1.Contains("tmall.com") || str1.Contains("yao.95095.com") ? true : str1.Contains("alitrip.com")))
							{
								this.method_137(str, GClass13.smethod_0(str1));
								if (!this.method_138(str1))
								{
									flag = false;
									return flag;
								}
							}
						}
					}
					Thread.Sleep(200);
				}
			}
			flag = true;
			return flag;
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if ((!exception.ToString().Contains("System.Net.WebException") ? true : int_28 >= 5))
			{
				this.method_115(string.Concat("[preCheck]出错：", exception.ToString()));
				flag = false;
			}
			else
			{
				this.method_115("网络一时问题，正在重试。。。。");
				Thread.Sleep(1200);
				int_28++;
				flag = this.method_136(string_96, int_28);
			}
		}
		return flag;
	}

	public void method_137(string string_96, string string_97)
	{
		GClass25 gClass25 = new GClass25()
		{
			string_1 = string_96,
			string_2 = GClass13.smethod_0(string_97)
		};
		gClass25.string_2 = GClass13.smethod_1(gClass25.string_2);
		if (gClass25.string_2.Contains("pvid="))
		{
			string str = string.Concat("&pvid=", ᝉ.ᜀ(gClass25.string_2, 0, "pvid=", "&"));
			gClass25.string_2 = gClass25.string_2.Replace(str, "");
		}
		this.arrayList_5.Add(gClass25);
	}

	private bool method_138(string string_96)
	{
		bool flag;
		try
		{
			Regex regex = new Regex("mm_\\d+_\\d+_\\d+");
			if ((string_96.Contains("ali_trackid") || string_96.Contains("pid=") ? regex.IsMatch(string_96) : false))
			{
				string value = regex.Match(string_96).Value;
				if (this.bool_32)
				{
					if (value.Equals(this.string_32))
					{
						flag = true;
						return flag;
					}
				}
				else if ((value.Equals(this.string_29) ? true : value.Equals(this.string_28)))
				{
					flag = true;
					return flag;
				}
			}
			flag = false;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkPid]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private int method_139()
	{
		int num;
		try
		{
			this.bool_34 = false;
			this.string_83 = "";
			this.bool_17 = false;
			ArrayList arrayLists = this.method_324(this.string_80);
			if (arrayLists != null)
			{
				this.int_26 = this.method_325(arrayLists);
				this.string_81 = this.string_81.Replace("￥", "$");
				GClass30 gClass30 = null;
				this.bool_5 = false;
				if ((this.bool_3 ? false : !this.bool_6))
				{
					this.string_81 = this.method_317(arrayLists);
				}
				else
				{
					gClass30 = this.method_140(this.string_81);
					if (this.bool_6)
					{
						this.method_311(gClass30, arrayLists, this.int_26);
					}
					else if (!this.bool_5)
					{
						this.string_81 = this.method_317(arrayLists);
					}
					else
					{
						this.string_81 = gClass30.string_1.Replace("{couponItemUrl}", string.Concat("【领券下单地址】", this.method_315(gClass30)));
						if ((this.bool_32 || !this.bool_4 ? false : this.int_26 == 4))
						{
							this.string_81 = string.Concat(this.string_81, "<BR>复制这条消息，", gClass30.᜞_0.ᜀ, "，打开【手机淘宝】即可领券并下单");
						}
					}
				}
				this.method_147(this.string_81);
				num = (!this.bool_17 || MessageBox.Show("产品佣金计划已经申请，正在审核中，立即发送吗？", "计划审核状态提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != System.Windows.Forms.DialogResult.Cancel ? 0 : 1);
			}
			else
			{
				num = -1;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[urlTransForSndProcess]出错：", exception.ToString()));
			num = -1;
		}
		return num;
	}

	private void method_14()
	{
		try
		{
			this.webBrowserSendContent.ScriptErrorsSuppressed = true;
			this.webBrowserSendContent.Navigate("about:blank");
			this.webBrowserSendContent.IsWebBrowserContextMenuEnabled = false;
			this.webBrowserSendContent.Document.ExecCommand("EditMode", false, null);
			this.webBrowserSendContent.Document.ExecCommand("LiveResize", false, null);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initWbSndContent]出错，", exception.ToString()));
		}
	}

	public GClass30 method_140(string string_96)
	{
		GClass30 gClass30;
		try
		{
			GClass30 gClass301 = new GClass30();
			this.method_141(string_96, gClass301);
			if (("".Equals(gClass301.string_2) ? false : !"".Equals(gClass301.string_3)))
			{
				string[] string35 = new string[] { "mm_", this.string_35, "_", this.string_26, "_", this.string_27 };
				string str = string.Concat(string35);
				if (this.bool_32)
				{
					string35 = new string[] { "mm_", this.string_35, "_", this.string_30, "_", this.string_31 };
					str = string.Concat(string35);
				}
				string str1 = this.method_81(gClass301.string_3);
				string str2 = gClass301.string_2.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
				string str3 = ᝉ.ᜀ(str2, 0, "activityId=", "&");
				string str4 = (this.bool_35 ? "1" : "0");
				string str5 = "https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=njrt_qytk&dx={dx}";
				str5 = str5.Replace("{activityId}", str3).Replace("{pid}", str).Replace("{itemId}", str1).Replace("{dx}", str4);
				this.bool_5 = true;
				gClass301.string_4 = str5;
				gClass301.᜞_0 = ᜃ.ᜁ(str3, str1, str, str4, ref this.string_23);
				this.string_77 = gClass301.᜞_0.ᜀ;
			}
			gClass30 = gClass301;
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_115(string.Concat("[getCouponItemContent]出错：", this.string_23, exception.ToString()));
			gClass30 = null;
		}
		return gClass30;
	}

	public void method_141(string string_96, GClass30 gclass30_0)
	{
		try
		{
			string_96 = this.method_144(string_96);
			string_96 = string_96.Replace("</span>", "</SPAN>").Replace("</div>", "</DIV>").Replace("<img", "<IMG").Replace("\n", "").Replace("\r", "").Replace("<br>", "\n").Replace("<BR>", "\n").Replace("<BR", "\n<BR").Replace("</DIV>", "\n").Replace("</SPAN>", "\n").Replace("</P>", "\n").Replace("</p>", "\n");
			string_96 = ᜸.ᜄ(string_96);
			this.method_145(this.method_142(string_96), gclass30_0, 3);
			string_96 = this.method_143(string_96);
			string_96 = string_96.Replace("{image}", "<IMG src=\"").Replace("{/image}", "\">");
			string_96 = string_96.Replace("\n", "<BR>");
			gclass30_0.string_1 = string_96;
			gclass30_0.string_0 = string_96.Replace("{couponItemUrl}<BR>", "").Replace("{couponItemUrl}", "");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[contentTransForCouponItemCmb]出错：", exception.ToString()));
		}
	}

	public string method_142(string string_96)
	{
		string i;
		int num = 0;
		int num1 = 0;
		for (i = string.Concat(string_96, ""); i.Contains("{image}"); i = i.Replace(i.Substring(num, num1), ""))
		{
			num = i.IndexOf("{image}");
			num1 = i.IndexOf("{/image}") + 8 - num;
		}
		return i;
	}

	public string method_143(string string_96)
	{
		string str;
		try
		{
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder();
			string[] strArrays = string_96.Split(new char[] { '\n' });
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				string str1 = strArrays[i];
				if ((str1 == null ? false : !"".Equals(str1.Trim())))
				{
					if (!(str1.Contains("http://") || str1.Contains("https://") ? str1.Contains(".jpg") : true))
					{
						if (!flag)
						{
							stringBuilder.Append("{couponItemUrl}\n");
							flag = true;
						}
					}
					else if ((str1.Contains("优惠券地址") || str1.Contains("下单地址") ? false : !str1.Contains("下单链接")))
					{
						stringBuilder.Append(string.Concat(str1, "\n"));
					}
				}
			}
			string str2 = stringBuilder.ToString();
			str = str2.Substring(0, str2.Length - 1);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[removeEmptyAndHttpLineForCouponItemCmb]出错：", exception.ToString()));
			str = null;
		}
		return str;
	}

	public string method_144(string string_96)
	{
		string string96;
		bool flag;
		try
		{
			string_96 = string_96.Replace("<img", "<IMG").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>");
			int num = 0;
			while (true)
			{
				int num1 = string_96.IndexOf("<IMG", num);
				num = num1;
				if (num1 == -1)
				{
					break;
				}
				string str = "";
				int num2 = string_96.IndexOf("src", num);
				int num3 = string_96.IndexOf("SRC", num);
				int num4 = num2;
				if (num4 == -1)
				{
					flag = false;
				}
				else
				{
					flag = (num4 <= num3 ? true : num3 == -1);
				}
				if (!flag)
				{
					num4 = num3;
				}
				int num5 = string_96.IndexOf("\"", num4) + 1;
				string str1 = string_96.Substring(num5, string_96.IndexOf("\"", num5) - num5);
				str = string.Concat("{image}", str1, "{/image}");
				int num6 = string_96.IndexOf(">", num) - num;
				string str2 = string_96.Substring(num, num6 + 1);
				string_96 = string_96.Replace(str2, str);
			}
			string96 = string_96;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[processImageTag]出错：", exception.ToString()));
			string96 = null;
		}
		return string96;
	}

	public void method_145(string string_96, GClass30 gclass30_0, int int_28)
	{
		try
		{
			string_96 = string_96.Replace("&nbsp;", " ").Replace("&amp;", "&");
			foreach (Match match in (new Regex(this.string_82)).Matches(string_96))
			{
				string str = match.Value.ToString();
				if (!((str.Contains("taobao.com") || str.Contains("tmall.com") || str.Contains("yao.95095.com")) && str.Contains("item.htm") && str.Contains("id=") ? false : !str.Contains("detail.ju.taobao.com")))
				{
					gclass30_0.string_3 = GClass13.smethod_0(str);
				}
				else if ((!str.Contains("coupon") || !str.Contains("taobao.com") ? true : str.Contains("uland.taobao.com")))
				{
					string str1 = ᜤ.ᜀ(str, str);
					if (!(!str1.Contains("coupon") || !str1.Contains("taobao.com") ? true : str.Contains("uland.taobao.com")))
					{
						gclass30_0.string_2 = GClass13.smethod_0(str1);
					}
					else if (str1.Contains("detail.ju.taobao.com"))
					{
						gclass30_0.string_3 = GClass13.smethod_0(str1);
					}
					else if (str1.Contains("item.htm?id="))
					{
						gclass30_0.string_3 = GClass13.smethod_0(str1);
					}
					else if (!((str1.Contains("taobao.com") || str1.Contains("tmall.com") || str1.Contains("yao.95095.com")) && str1.Contains("item.htm") ? !str1.Contains("id=") : true))
					{
						gclass30_0.string_3 = GClass13.smethod_0(str1);
					}
					else if (str1.Contains("shop/view_shop.htm?user_number_id="))
					{
						gclass30_0.string_3 = GClass13.smethod_0(str1);
					}
					else if (!str1.Contains("temai.taobao.com"))
					{
						if ((str1.Contains("taobao.com") || str1.Contains("tmall.com") || str1.Contains("yao.95095.com") ? true : str1.Contains("alitrip.com")))
						{
							gclass30_0.string_3 = GClass13.smethod_0(str1);
						}
					}
					Thread.Sleep(200);
				}
				else
				{
					gclass30_0.string_2 = str;
				}
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if ((!exception.ToString().Contains("System.Net.WebException") ? true : int_28 >= 5))
			{
				this.method_115(string.Concat("[checkCouponAndItemUrl]出错：", exception.ToString()));
			}
			else
			{
				this.method_115("网络一时问题，正在重试。。。。");
				Thread.Sleep(1200);
				int_28++;
				this.method_145(string_96, gclass30_0, int_28);
			}
		}
	}

	public bool method_146(string string_96, string string_97, string string_98, string string_99)
	{
		bool flag;
		try
		{
			string str = "http://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=njrt_qytk&dx={dx}";
			str = str.Replace("{activityId}", string_97).Replace("{pid}", string_98).Replace("{itemId}", string_96).Replace("{dx}", string_99);
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			webClient.Headers.Add("Upgrade-Insecure-Requests", "1");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			string str1 = ᜈ.ᜀ("http://www.taobao.com");
			webClient.Headers.Add("Cookie", str1);
			string str2 = "";
			byte[] numArray = webClient.DownloadData(str);
			string item = webClient.ResponseHeaders["Content-Encoding"];
			string item1 = webClient.ResponseHeaders["Set-Cookie"];
			string str3 = ᝉ.ᜀ(item1, 0, "ctoken=", ";");
			webClient.Headers.Clear();
			webClient.Headers.Add("Accept", "*/*");
			webClient.Headers.Add("X-Requested-With", "XMLHttpRequest");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Referer", str);
			webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			webClient.Headers.Add("Cookie", string.Concat(str1, ";ctoken=", str3));
			str2 = "";
			string str4 = "http://uland.taobao.com/cp/coupon?ctoken={ctoken}&activityId={activityId}&pid={pid}&itemId={itemId}&src=njrt_qytk&dx={dx}";
			str4 = str4.Replace("{ctoken}", str3).Replace("{activityId}", string_97).Replace("{pid}", string_98).Replace("{itemId}", string_96).Replace("{dx}", string_99);
			numArray = webClient.DownloadData(str4);
			str2 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : ᜸.ᜀ(numArray, Encoding.UTF8));
			flag = (!str2.Contains("\"retStatus\":1") ? true : false);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkCouponItem]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public void method_147(string string_96)
	{
		try
		{
			if (!base.InvokeRequired)
			{
				((IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument).body.innerHTML = string_96;
			}
			else
			{
				AliBridgeForm.GDelegate67 gDelegate67 = new AliBridgeForm.GDelegate67(this.method_147);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate67, string96);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ChgSendWbContent]出错：", exception.ToString()));
		}
	}

	private void method_148()
	{
		try
		{
			while (this.int_11 < this.arrayList_4.Count)
			{
				if (this.bool_20)
				{
					this.method_115("群发被强制停止！");
					return;
				}
				else
				{
					this.method_155(string.Concat(this.string_48, this.method_166()));
					string item = (string)this.arrayList_4[this.int_11];
					IntPtr intPtr = AliBridgeForm.FindWindow(null, item);
					if (intPtr == IntPtr.Zero)
					{
						string str = string.Concat(this.string_51, "\\", item, ".lnk");
						if (!File.Exists(str))
						{
							goto Label1;
						}
						try
						{
							Process.Start(str);
						}
						catch
						{
							this.method_115(string.Concat("自动打开QQ群快捷方式有问题，请手动打开！【", str, "】"));
						}
						Thread.Sleep(1000);
						intPtr = AliBridgeForm.FindWindow(null, item);
						if (intPtr == IntPtr.Zero)
						{
						}
					}
					StringBuilder stringBuilder = new StringBuilder(256);
					AliBridgeForm.GetClassName(intPtr, stringBuilder, 500);
					if (!"ChatWnd".Equals(stringBuilder.ToString()))
					{
						AliBridgeForm.SetForegroundWindow(intPtr);
						Thread.Sleep(this.int_6);
						ᝬ.ᜃ();
						Thread.Sleep(this.int_7);
						if (!this.bool_8)
						{
							ᝬ.ᜆ();
						}
						else
						{
							ᝬ.ᜂ();
						}
						Thread.Sleep(this.int_8);
						if (this.checkBoxCloseWinWhileSnded.Checked)
						{
							ᝬ.ᜀ();
							Thread.Sleep(100);
						}
					}
					else
					{
						this.method_149(intPtr);
					}
				Label1:
					AliBridgeForm int11 = this;
					int11.int_11 = int11.int_11 + 1;
				}
			}
			this.bool_34 = false;
			this.string_76 = "";
			this.int_26 = 0;
			if (!this.checkBoxMinForm.Checked)
			{
				this.method_167();
			}
			else
			{
				this.method_168();
			}
			this.method_156();
			this.method_134();
			this.method_115("群发完成！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[autoSend]出错：", exception.ToString()));
		}
	}

	public void method_149(IntPtr intptr_1)
	{
		GStruct0 gStruct0;
		try
		{
			this.string_50 = this.method_151();
			᝚.ᜃ(this.string_50);
			AliBridgeForm.ShowWindowAsync(intptr_1, GClass13.int_13);
			Thread.Sleep(150);
			AliBridgeForm.SetForegroundWindow(intptr_1);
			Thread.Sleep(150);
			AliBridgeForm.GetWindowRect(intptr_1, out gStruct0);
			ᝬ.ᜀ(intptr_1, gStruct0.int_2 - 60, gStruct0.int_3 - 70);
			GClass27 gClass27 = this.method_152(this.string_48);
			if (!"".Equals(gClass27.string_0))
			{
				this.method_155(gClass27.string_0);
				Thread.Sleep(this.int_6);
				ᝬ.ᜃ();
				Thread.Sleep(this.int_7);
				if (!this.bool_8)
				{
					ᝬ.ᜆ();
				}
				else
				{
					ᝬ.ᜂ();
				}
			}
			if ((gClass27.string_1 == null ? false : !gClass27.string_1.Equals("")))
			{
				this.method_155(string.Concat(gClass27.string_1, this.method_166()));
				Thread.Sleep(this.int_9);
				ᝬ.ᜃ();
				Thread.Sleep(this.int_7);
				if (!this.bool_8)
				{
					ᝬ.ᜆ();
				}
				else
				{
					ᝬ.ᜂ();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[sendWeixin]出错：", exception.ToString()));
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		this.ᜐ_0.ᜑ();
		this.method_122();
		this.notifyIcon_0.Visible = false;
		Environment.Exit(0);
	}

	private void method_150()
	{
		GStruct0 gStruct0;
		try
		{
			this.string_50 = this.method_151();
			᝚.ᜃ(this.string_50);
			GClass27 gClass27 = this.method_152(this.string_48);
			while (this.int_11 < this.arrayList_4.Count)
			{
				if (this.bool_20)
				{
					this.method_115("群发被强制停止！");
					return;
				}
				else
				{
					string item = (string)this.arrayList_4[this.int_11];
					IntPtr intPtr = AliBridgeForm.FindWindow(null, item);
					if (intPtr == IntPtr.Zero)
					{
						this.method_115(string.Concat("微信群【", item, "】窗口没有打开，软件自动拖动微信群成为独立的窗口！"));
						AliBridgeForm.EnumWindows(new AliBridgeForm.GDelegate66(this.method_121), IntPtr.Zero);
						if (!this.method_120())
						{
							goto Label2;
						}
						this.method_115("微信已经打开！正在拖动。。。。");
						AliBridgeForm.ShowWindowAsync(this.intptr_0, GClass13.int_13);
						Thread.Sleep(150);
						AliBridgeForm.SetForegroundWindow(this.intptr_0);
						Thread.Sleep(150);
						AliBridgeForm.GetWindowRect(this.intptr_0, out gStruct0);
						ᝬ.ᜀ(this.intptr_0, gStruct0.int_0 + 100, gStruct0.int_1 + 25);
						Thread.Sleep(200);
						SendKeys.SendWait("{BACKSPACE}");
						Thread.Sleep(200);
						SendKeys.SendWait(item);
						Thread.Sleep(200);
						SendKeys.SendWait("{ENTER}");
						Thread.Sleep(250);
						ᝬ.ᜀ(gStruct0.int_0 + 100, gStruct0.int_1 + 75, gStruct0.int_0 + 400);
						Thread.Sleep(150);
					}
					intPtr = AliBridgeForm.FindWindow(null, item);
					if (intPtr != IntPtr.Zero)
					{
						AliBridgeForm.ShowWindowAsync(intPtr, GClass13.int_13);
						Thread.Sleep(150);
						AliBridgeForm.SetForegroundWindow(intPtr);
						Thread.Sleep(150);
						AliBridgeForm.GetWindowRect(intPtr, out gStruct0);
						ᝬ.ᜀ(intPtr, gStruct0.int_2 - 60, gStruct0.int_3 - 70);
						if (!"".Equals(gClass27.string_0))
						{
							this.method_155(gClass27.string_0);
							Thread.Sleep(this.int_6);
							ᝬ.ᜃ();
							Thread.Sleep(this.int_7);
							if (!this.bool_8)
							{
								ᝬ.ᜆ();
							}
							else
							{
								ᝬ.ᜂ();
							}
						}
						if ((gClass27.string_1 == null ? false : !gClass27.string_1.Equals("")))
						{
							this.method_155(string.Concat(gClass27.string_1, this.method_166()));
							Thread.Sleep(this.int_9);
							ᝬ.ᜃ();
							Thread.Sleep(this.int_7);
							if (!this.bool_8)
							{
								ᝬ.ᜆ();
							}
							else
							{
								ᝬ.ᜂ();
							}
						}
						Thread.Sleep(this.int_8);
					}
					else
					{
						this.method_115(string.Concat("微信群【", item, "】窗口没有打开，软件拖动失败，跳过跟发！"));
					}
				Label1:
					AliBridgeForm int11 = this;
					int11.int_11 = int11.int_11 + 1;
				}
			}
			this.bool_34 = false;
			this.string_76 = "";
			this.int_26 = 0;
			if (!this.checkBoxMinForm.Checked)
			{
				this.method_167();
			}
			else
			{
				this.method_168();
			}
			this.method_156();
			this.method_134();
			this.method_115("群发完成！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[autoSendWeixin]出错：", exception.ToString()));
		}
		return;
	Label2:
		this.method_115("微信没有打开！");
		goto Label1;
	}

	public string method_151()
	{
		string str = string.Concat(this.string_41.Substring(0, 2), "\\qianyuweixinimg");
		if (!File.Exists(str))
		{
			Directory.CreateDirectory(str);
		}
		return str;
	}

	public GClass27 method_152(string string_96)
	{
		DateTime now;
		string str;
		bool i;
		object[] string50;
		string str1;
		int num;
		int num1;
		string str2;
		string str3;
		int num2;
		string str4;
		bool flag;
		string str5 = "";
		try
		{
			string_96 = string_96.Replace("<img", "<IMG").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>");
			int num3 = 0;
			while (true)
			{
				int num4 = string_96.IndexOf("<IMG", num3);
				num3 = num4;
				if (num4 == -1)
				{
					break;
				}
				int num5 = string_96.IndexOf("src", num3);
				int num6 = string_96.IndexOf("SRC", num3);
				int num7 = num5;
				if (num7 == -1)
				{
					flag = false;
				}
				else
				{
					flag = (num7 <= num6 ? true : num6 == -1);
				}
				if (!flag)
				{
					num7 = num6;
				}
				int num8 = string_96.IndexOf("\"", num7) + 1;
				string str6 = string_96.Substring(num8, string_96.IndexOf("\"", num8) - num8);
				if (str6.StartsWith("file:///"))
				{
					string str7 = HttpUtility.UrlDecode(str6.Replace("file:///", "").Replace("/", "\\")).Replace("%20", " ");
					string string501 = this.string_50;
					now = DateTime.Now;
					str = string.Concat(string501, "\\", now.ToString("yyyyMMddHHmmssfff"), str7.Substring(str7.LastIndexOf(".")));
					for (i = File.Exists(str); i; i = File.Exists(str))
					{
						string50 = new object[] { this.string_50, "\\", null, null, null };
						now = DateTime.Now;
						string50[2] = now.ToString("yyyyMMddHHmmss");
						now = DateTime.Now;
						string50[3] = int.Parse(now.ToString("fff")) + 1;
						string50[4] = str7.Substring(str7.LastIndexOf("."));
						str = string.Concat(string50);
					}
					try
					{
						File.Copy(str7, str);
						str1 = string.Concat("file:///", str.Replace(" ", "%20").Replace("{", "%7B").Replace("}", "%7D").Replace("%", "%25").Replace("\\", "/"));
						str5 = string.Concat(str5, "<IMG src=\"", str1, "\">");
						num = string_96.IndexOf(">", num3);
						num1 = string_96.IndexOf("<BR>", num + 1);
						if (num1 != -1 && "".Equals(string_96.Substring(num + 1, num1 - num - 1).Replace(" ", "").Replace("&nbsp;", "").Replace("\r", "").Replace("\n", "")))
						{
							str2 = string_96.Substring(0, num + 1);
							str3 = string_96.Substring(num1 + 4, string_96.Length - num1 - 4);
							string_96 = string.Concat(str2, str3);
						}
						num2 = num - num3;
						str4 = string_96.Substring(num3, num2 + 1);
						string_96 = string_96.Replace(str4, "");
					}
					catch
					{
						num3++;
					}
				}
				else if ((str6.StartsWith("http://") ? true : str6.StartsWith("https://")))
				{
					string string502 = this.string_50;
					now = DateTime.Now;
					str = string.Concat(string502, "\\", now.ToString("yyyyMMddHHmmssfff"), ".jpg");
					for (i = File.Exists(str); i; i = File.Exists(str))
					{
						string50 = new object[] { this.string_50, "\\", null, null, null };
						now = DateTime.Now;
						string50[2] = now.ToString("yyyyMMddHHmmss");
						now = DateTime.Now;
						string50[3] = int.Parse(now.ToString("fff")) + 1;
						string50[4] = ".jpg";
						str = string.Concat(string50);
					}
					(new WebClient()).DownloadFile(str6, str);
					str1 = string.Concat("file:///", str.Replace(" ", "%20").Replace("{", "%7B").Replace("}", "%7D").Replace("%", "%25").Replace("\\", "/"));
					str5 = string.Concat(str5, "<IMG src=\"", str1, "\">");
					num = string_96.IndexOf(">", num3);
					num1 = string_96.IndexOf("<BR>", num + 1);
					if (num1 != -1 && "".Equals(string_96.Substring(num + 1, num1 - num - 1).Replace(" ", "").Replace("&nbsp;", "").Replace("\r", "").Replace("\n", "")))
					{
						str2 = string_96.Substring(0, num + 1);
						str3 = string_96.Substring(num1 + 4, string_96.Length - num1 - 4);
						string_96 = string.Concat(str2, str3);
					}
					num2 = num - num3;
					str4 = string_96.Substring(num3, num2 + 1);
					string_96 = string_96.Replace(str4, "");
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getWxSendContent]出错：", exception.ToString()));
		}
		return new GClass27()
		{
			string_0 = str5,
			string_1 = string_96
		};
	}

	private void method_153()
	{
		try
		{
			foreach (string arrayList4 in this.arrayList_4)
			{
				IntPtr intPtr = AliBridgeForm.FindWindow(null, arrayList4);
				int num = 0;
				if (intPtr == IntPtr.Zero)
				{
					try
					{
						Process.Start(string.Concat(this.string_51, "\\", arrayList4, ".lnk"));
					}
					catch
					{
					}
					Thread.Sleep(800);
					intPtr = AliBridgeForm.FindWindow(null, arrayList4);
					if (intPtr != IntPtr.Zero)
					{
						AliBridgeForm.SetForegroundWindow(intPtr);
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
			this.method_115(string.Concat("[openAllQQGrp]出错：", exception.ToString()));
		}
	}

	public void method_154(int int_28, bool bool_40, string string_96)
	{
		AliBridgeForm.GDelegate68 gDelegate68;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonSend.InvokeRequired)
				{
					this.buttonSend.Enabled = bool_40;
					this.buttonSend.Text = string_96;
				}
				else
				{
					gDelegate68 = new AliBridgeForm.GDelegate68(this.method_154);
					int28 = new object[] { int_28, bool_40, string_96 };
					base.BeginInvoke(gDelegate68, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonPause.InvokeRequired)
				{
					this.buttonPause.Enabled = bool_40;
				}
				else
				{
					gDelegate68 = new AliBridgeForm.GDelegate68(this.method_154);
					int28 = new object[] { int_28, bool_40, string_96 };
					base.BeginInvoke(gDelegate68, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.buttonStop.InvokeRequired)
				{
					this.buttonStop.Enabled = bool_40;
				}
				else
				{
					gDelegate68 = new AliBridgeForm.GDelegate68(this.method_154);
					int28 = new object[] { int_28, bool_40, string_96 };
					base.BeginInvoke(gDelegate68, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[BtnGrpSnd]出错：", exception.ToString()));
		}
	}

	public void method_155(string string_96)
	{
		try
		{
			if (!base.InvokeRequired)
			{
				bool flag = GClass13.smethod_23(string_96, out this.string_23);
				bool flag1 = flag;
				if (!flag)
				{
					bool flag2 = GClass13.smethod_23(string_96, out this.string_23);
					flag1 = flag2;
					if (!flag2 && !flag1)
					{
						bool flag3 = GClass13.smethod_23(string_96, out this.string_23);
						flag1 = flag3;
						if (!flag3)
						{
							this.method_115(string.Concat("复制失败！", this.string_23));
						}
					}
				}
			}
			else
			{
				AliBridgeForm.GDelegate69 gDelegate69 = new AliBridgeForm.GDelegate69(this.method_155);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate69, string96);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CopySndContent]出错：", exception.ToString()));
		}
	}

	public void method_156()
	{
		try
		{
			if (!this.webBrowserSendContent.InvokeRequired)
			{
				base.Activate();
				((IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument).body.innerHTML = "";
			}
			else
			{
				AliBridgeForm.GDelegate70 gDelegate70 = new AliBridgeForm.GDelegate70(this.method_156);
				base.BeginInvoke(gDelegate70, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ClearEditContent]出错：", exception.ToString()));
		}
	}

	private void method_157(string string_96, int int_28)
	{
		int j;
		try
		{
			for (int i = 0; i < this.arrayList_4.Count; i++)
			{
				string item = (string)this.arrayList_4[i];
				if (item.Equals(string_96))
				{
					if (int_28 != 0)
					{
						if (int_28 == 1)
						{
							if (i != this.arrayList_4.Count - 1)
							{
								for (j = i; j < this.arrayList_4.Count - 1; j++)
								{
									this.arrayList_4[j] = this.arrayList_4[j + 1];
								}
								this.arrayList_4[this.arrayList_4.Count - 1] = item;
								return;
							}
							else
							{
								return;
							}
						}
					}
					else if (i != 0)
					{
						for (j = i; j > 0; j--)
						{
							this.arrayList_4[j] = this.arrayList_4[j - 1];
						}
						this.arrayList_4[0] = item;
						return;
					}
					else
					{
						return;
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[processOrder]出错：", exception.ToString()));
		}
	}

	public void method_158(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate71 gDelegate71;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonStartTask.InvokeRequired)
				{
					this.buttonStartTask.Enabled = bool_40;
				}
				else
				{
					gDelegate71 = new AliBridgeForm.GDelegate71(this.method_158);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate71, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonStopTask.InvokeRequired)
				{
					this.buttonStopTask.Enabled = bool_40;
				}
				else
				{
					gDelegate71 = new AliBridgeForm.GDelegate71(this.method_158);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate71, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[BtnAutoSnd]出错：", exception.ToString()));
		}
	}

	private void method_159()
	{
		try
		{
			if (!this.dataGridViewAutoSndTask.InvokeRequired)
			{
				this.dataGridViewAutoSndTask.Rows.Clear();
				string str = "select * from sendtask order by taskdt asc";
				this.arrayList_6 = this.gclass42_0.method_12(str, out this.string_23);
				if (this.string_23.Equals(""))
				{
					int num = 0;
					foreach (GClass15 arrayList6 in this.arrayList_6)
					{
						DataGridViewRow dataGridViewRow = new DataGridViewRow();
						this.dataGridViewAutoSndTask.Rows.Add(dataGridViewRow);
						this.dataGridViewAutoSndTask.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
						string str1 = string.Concat(this.string_52, "\\", arrayList6.string_0);
						this.dataGridViewAutoSndTask[0, num].Value = ᜸.ᜄ(᝚.ᜀ(string.Concat(str1, "\\task.txt"), Encoding.GetEncoding("GB2312")));
						this.dataGridViewAutoSndTask[1, num].Value = (arrayList6.string_1.Equals("1") ? "已发送" : "未发送");
						this.dataGridViewAutoSndTask.Rows[num].Tag = arrayList6;
						num++;
					}
				}
				else
				{
					this.method_115(string.Concat("加载群发任务失败，", this.string_23));
				}
			}
			else
			{
				AliBridgeForm.GDelegate72 gDelegate72 = new AliBridgeForm.GDelegate72(this.method_159);
				base.BeginInvoke(gDelegate72, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadTask]出错：", exception.ToString()));
		}
	}

	public string method_16(ᝠ ᝠ_2, string string_96, string string_97)
	{
		string str;
		int num = 0;
		while (true)
		{
			try
			{
				str = ᝠ_2.ᜂ(string_96, string_97);
				break;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				string str1 = exception.ToString();
				if ((str1.Contains("System.Net.WebException") ? false : !str1.Contains("System.IO.IOException")))
				{
					throw exception;
				}
				num++;
				if (num <= 2)
				{
					Thread.Sleep(1000);
				}
				else
				{
					str = "noplan";
					break;
				}
			}
		}
		return str;
	}

	private void method_160()
	{
		try
		{
			if (this.int_12 <= 0)
			{
				this.int_12 = 300;
			}
			this.bool_14 = this.checkBoxFollowSend.Checked;
			this.bool_15 = this.checkBoxUpHotShare.Checked;
			this.bool_21 = true;
			this.thread_2 = new Thread(new ThreadStart(this.method_161));
			this.thread_2.SetApartmentState(ApartmentState.MTA);
			this.thread_2.Start();
			this.method_158(1, false);
			this.method_158(2, true);
			this.buttonLoadQQGrpList.Focus();
			this.method_122();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[startTask]出错：", exception.ToString()));
		}
	}

	private void method_161()
	{
		object[] days;
		try
		{
			TimeSpan value = this.dateTimePickerTaskStart.Value - DateTime.Now;
			if (value.TotalSeconds <= 0)
			{
				this.method_115("启动群发计划！开始时间小于当前时间，立即发送！");
			}
			else
			{
				days = new object[] { "启动群发计划！开始时间大于当前时间，等待【", value.Days, "日", value.Hours, "时", value.Minutes, "分", value.Seconds, "秒】后开始发送" };
				this.method_115(string.Concat(days));
				Thread.Sleep((int)(value.TotalSeconds * 1000));
			}
			while (true)
			{
				ArrayList arrayLists = this.gclass42_0.method_12("select * from sendtask where taskname ='0' order by taskdt asc", out this.string_23);
				if (arrayLists == null)
				{
					this.method_115(string.Concat("数据库出错了！", this.string_23));
					this.bool_21 = false;
					this.method_158(1, true);
					this.method_158(2, false);
					return;
				}
				if (arrayLists.Count != 0)
				{
					GClass15 item = (GClass15)arrayLists[0];
					this.method_167();
					this.method_115(string.Concat("离执行计划[", item.string_0, "]还有2秒。。。。。。。。。。。。。。。。。。。请停止手里的工作！"));
					Thread.Sleep(2000);
					this.method_165(item);
					this.int_11 = 0;
					this.bool_20 = false;
					if (!this.bool_32)
					{
						this.method_148();
					}
					else
					{
						this.method_150();
					}
					item.string_1 = "1";
					if (!this.gclass42_0.method_9(item, out this.string_23))
					{
						break;
					}
					this.method_159();
					if (arrayLists.Count > 1)
					{
						days = new object[] { "【", arrayLists.Count - 1, "】个正在执行的计划，离下次执行群发任务还有【", this.int_12, "】秒" };
						this.method_115(string.Concat(days));
						if (this.int_12 - 2 > 0)
						{
							Thread.Sleep((this.int_12 - 2) * 1000);
						}
					}
				}
				else
				{
					this.method_115(string.Concat("任务执行完毕，等待添加新任务，离下次检查群发任务还有【", this.int_12, "】秒"));
					Thread.Sleep(this.int_12 * 1000);
				}
			}
			this.method_115(string.Concat("数据库出错了！", this.string_23));
			this.bool_21 = false;
			this.method_158(1, true);
			this.method_158(2, false);
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if (!exception.ToString().Contains("System.Threading.ThreadAbortException"))
			{
				this.method_115(string.Concat("[runTask]出错：", exception.ToString()));
			}
			this.bool_21 = false;
			this.method_158(1, true);
			this.method_158(2, false);
		}
	}

	private void method_162()
	{
		try
		{
			this.thread_2.Abort();
		}
		catch
		{
		}
		this.method_158(1, true);
		this.method_158(2, false);
		this.method_115("停止计划成功！");
		this.buttonLoadQQGrpList.Focus();
	}

	private void method_163()
	{
		this.method_162();
		this.method_160();
	}

	public void method_164(GClass15 gclass15_0)
	{
		try
		{
			if (!this.webBrowserSendContent.InvokeRequired)
			{
				base.Activate();
				StreamReader streamReader = new StreamReader(string.Concat(this.string_52, "\\", gclass15_0.string_0, "\\task.txt"), Encoding.GetEncoding("GB2312"));
				string end = streamReader.ReadToEnd();
				streamReader.Close();
				streamReader.Dispose();
				((IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument).body.innerHTML = end;
			}
			else
			{
				AliBridgeForm.GDelegate73 gDelegate73 = new AliBridgeForm.GDelegate73(this.method_164);
				object[] gclass150 = new object[] { gclass15_0 };
				base.BeginInvoke(gDelegate73, gclass150);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showAutoSndTaskContent]出错：", exception.ToString()));
		}
	}

	public void method_165(GClass15 gclass15_0)
	{
		string str;
		try
		{
			string str1 = string.Concat(this.string_52, "\\", gclass15_0.string_0);
			string str2 = ᝚.ᜀ(string.Concat(str1, "\\task.txt"), Encoding.GetEncoding("GB2312"));
			this.string_48 = str2;
			string str3 = string.Concat(str1, "\\淘口令.txt");
			if (File.Exists(str3))
			{
				this.string_76 = ᝚.ᜀ(str3, Encoding.GetEncoding("GB2312"));
				this.int_26 = 4;
			}
			if (this.bool_14)
			{
				if (File.Exists(string.Concat(this.string_41, "\\admin.txt")))
				{
					str = ᝚.ᜀ(string.Concat(str1, "\\followContentWithoutPid.txt"));
					if (!GClass0.smethod_0(this.ᜐ_0.ᜁ, str, out this.string_23))
					{
						this.method_115(string.Concat("跟发上传失败！", this.string_23));
					}
					else
					{
						this.method_115("跟发上传成功！");
					}
				}
				else if (!GClass0.smethod_0(this.ᜐ_0.ᜁ, this.string_48, out this.string_23))
				{
					this.method_115(string.Concat("跟发上传失败！", this.string_23));
				}
				else
				{
					this.method_115("跟发上传成功！");
				}
			}
			if (this.bool_15)
			{
				str = ᝚.ᜀ(string.Concat(str1, "\\followContentWithoutPid.txt"));
				string str4 = ᝚.ᜀ(string.Concat(str1, "\\hotshare.txt"));
				if ((str4.Equals("") ? false : !str4.Contains("nocontent")))
				{
					string[] strArrays = str4.Split(new char[] { '\n' });
					GClass16 gClass16 = new GClass16()
					{
						string_2 = strArrays[0],
						string_3 = strArrays[1],
						string_4 = strArrays[2]
					};
					if (!GClass0.smethod_1(this.ᜐ_0.ᜁ, gClass16, str, out this.string_23))
					{
						this.method_115(string.Concat("爆款上传失败！", this.string_23));
					}
					else
					{
						object[] string79 = new object[] { "爆款上传成功！【标题：", this.string_79, "，价格：", this.float_2 - this.float_3, "，爆款佣金比例：", this.float_4, "】" };
						this.method_115(string.Concat(string79));
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadTaskSendContent]出错：", exception.ToString()));
		}
	}

	private string method_166()
	{
		DateTime now;
		string str;
		try
		{
			string str1 = "";
			if ((!this.bool_9 || this.string_40 == null ? false : !"".Equals(this.string_40.Trim())))
			{
				str1 = string.Concat("\n<BR><P>", this.string_40, "</P>");
			}
			if (this.bool_10)
			{
				if (!str1.Equals(""))
				{
					now = DateTime.Now;
					str1 = string.Concat(str1, "\n<BR><P>", now.ToString("yyyy年MM月dd日 HH:mm:ss"), "</P>");
				}
				else
				{
					now = DateTime.Now;
					str1 = string.Concat("\n<BR><P>", now.ToString("yyyy年MM月dd日 HH:mm:ss"), "</P>");
				}
			}
			if (this.bool_11)
			{
				str1 = (!str1.Equals("") ? string.Concat(str1, "\t<P>", ᜸.ᜀ(10), "</P>") : string.Concat("\n<BR><P>", ᜸.ᜀ(10), "</P>"));
			}
			str = str1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getRdmContent]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	public void method_167()
	{
		try
		{
			if (!base.InvokeRequired)
			{
				base.Visible = true;
				base.WindowState = FormWindowState.Normal;
				Thread.Sleep(100);
				base.Activate();
				Thread.Sleep(100);
				this.tabControlMain.SelectedIndex = GClass13.int_3;
				Thread.Sleep(100);
			}
			else
			{
				AliBridgeForm.GDelegate74 gDelegate74 = new AliBridgeForm.GDelegate74(this.method_167);
				base.BeginInvoke(gDelegate74, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[WindowNomal]出错：", exception.ToString()));
		}
	}

	public void method_168()
	{
		try
		{
			if (!base.InvokeRequired)
			{
				base.Visible = true;
				base.WindowState = FormWindowState.Minimized;
			}
			else
			{
				AliBridgeForm.GDelegate75 gDelegate75 = new AliBridgeForm.GDelegate75(this.method_168);
				base.BeginInvoke(gDelegate75, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[WindowMin]出错：", exception.ToString()));
		}
	}

	private void method_169(object sender, EventArgs e)
	{
		try
		{
			if (this.method_117())
			{
				if (this.method_119())
				{
					if (this.dataGridViewHotShare.CurrentCell != null)
					{
						if (ᜃ.ᜋ(this.string_20))
						{
							GClass16 tag = (GClass16)this.dataGridViewHotShare.CurrentRow.Tag;
							string str = this.method_171(tag.int_0);
							string end = "";
							StreamReader streamReader = new StreamReader(string.Concat(str, "/", tag.string_0, "/hot.html"), Encoding.GetEncoding("GB2312"));
							end = streamReader.ReadToEnd();
							streamReader.Close();
							streamReader.Dispose();
							((IHTMLDocument2)this.webBrowserConvert.Document.DomDocument).body.innerHTML = end;
							this.int_25 = 3;
							this.method_306();
						}
						else
						{
							this.method_115("没有登录阿里妈妈！");
							this.bool_0 = false;
							this.method_7();
						}
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[AddManualSend_Click]出错：", exception.ToString()));
		}
	}

	public string method_17(ᝠ ᝠ_2, string string_96, string string_97)
	{
		return this.method_18(ᝠ_2, string_96, string_97, 6);
	}

	private void method_170(object sender, EventArgs e)
	{
		string str;
		try
		{
			if (this.dataGridViewHotShare.CurrentCell != null)
			{
				GClass16 tag = (GClass16)this.dataGridViewHotShare.CurrentRow.Tag;
				string str1 = this.method_171(tag.int_0);
				while (true)
				{
					string str2 = DateTime.Now.ToString("yyyyMMddHHmmss");
					str = string.Concat(this.string_68, "\\", str2);
					if (!Directory.Exists(str))
					{
						break;
					}
					Thread.Sleep(1000);
				}
				᝚.ᜂ(string.Concat(str1, "\\", tag.string_0, "\\"), string.Concat(str, "\\"));
				File.Move(string.Concat(str, "\\hot.html"), string.Concat(str, "\\content.html"));
				᝚.ᜁ(string.Concat(str, "\\0.txt"), "");
				this.method_115(string.Concat("【", tag.string_2, "】添加到跟发成功！"));
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[AddFollowSend_Click]出错：", exception.ToString()));
		}
	}

	public string method_171(int int_28)
	{
		string string5;
		if (int_28 == 1)
		{
			string5 = this.string_5;
		}
		else if (int_28 != 2)
		{
			string5 = (int_28 != 3 ? this.string_13 : this.string_11);
		}
		else
		{
			string5 = this.string_7;
		}
		return string5;
	}

	public string method_172(int int_28)
	{
		string string4;
		if (int_28 == 1)
		{
			string4 = this.string_4;
		}
		else if (int_28 != 2)
		{
			string4 = (int_28 != 3 ? this.string_12 : this.string_10);
		}
		else
		{
			string4 = this.string_6;
		}
		return string4;
	}

	private void method_173()
	{
		while (true)
		{
			try
			{
				this.method_177(1, ref this.string_56, ref this.string_57, ref this.string_5, ref this.arrayList_7);
			}
			catch
			{
			}
			Thread.Sleep(this.int_13);
		}
	}

	private void method_174()
	{
		while (true)
		{
			try
			{
				this.method_177(2, ref this.string_58, ref this.string_59, ref this.string_7, ref this.arrayList_8);
			}
			catch
			{
			}
			Thread.Sleep(this.int_14);
		}
	}

	private void method_175()
	{
		while (true)
		{
			try
			{
				this.method_177(3, ref this.string_60, ref this.string_61, ref this.string_11, ref this.arrayList_9);
			}
			catch
			{
			}
			Thread.Sleep(this.int_15);
		}
	}

	private void method_176()
	{
	}

	private void method_177(int int_28, ref string string_96, ref string string_97, ref string string_98, ref ArrayList arrayList_26)
	{
		try
		{
			ᝠ ᝠ0 = this.ᝠ_0;
			string string3 = this.string_3;
			object[] int28 = new object[] { "softwarename=alibridge&type=getlasthotid&hottype=", int_28, "&user=", this.ᜐ_0.ᜁ, "&loginid=", this.ᜐ_0.ᜀ };
			string str = ᝠ0.ᜃ(string3, string.Concat(int28));
			if ((str == null ? false : !"".Equals(str)))
			{
				if (!str.Equals(string_96))
				{
					string_96 = str;
					ArrayList arrayLists = new ArrayList();
					ᝠ _ᝠ = this.ᝠ_0;
					string string31 = this.string_3;
					int28 = new object[] { "softwarename=alibridge&type=gethotsharelist&hottype=", int_28, "&user=", this.ᜐ_0.ᜁ, "&loginid=", this.ᜐ_0.ᜀ };
					string[] strArrays = _ᝠ.ᜃ(string31, string.Concat(int28)).Split(new char[] { ';' });
					if ((this.method_183(strArrays, this.arrayList_7) || (int)strArrays.Length == 0 ? false : !strArrays[0].Equals("")))
					{
						string[] strArrays1 = strArrays;
						for (int i = 0; i < (int)strArrays1.Length; i++)
						{
							string str1 = strArrays1[i];
							GClass16 gClass16 = new GClass16()
							{
								string_0 = ᝉ.ᜀ(str1, 0, "hid:", ","),
								int_0 = int.Parse(ᝉ.ᜀ(str1, 0, "hottype:", ",")),
								string_1 = ᝉ.ᜀ(str1, 0, "itemid:", ","),
								string_2 = ᝉ.ᜀ(str1, 0, "title:", ","),
								string_3 = ᝉ.ᜀ(str1, 0, "price:", ","),
								string_4 = ᝉ.ᜀ(str1, 0, "cmsRate:", ","),
								int_1 = int.Parse(ᝉ.ᜀ(str1, 0, "hot:", ","))
							};
							if (int_28 == 1)
							{
								gClass16.bool_0 = this.method_185(gClass16.string_0);
							}
							arrayLists.Add(gClass16);
						}
						arrayList_26 = arrayLists;
						this.method_196(string_97, arrayList_26);
						this.method_184(string_98, arrayList_26);
						if (int_28 == 1)
						{
							this.method_179(arrayList_26);
							if (this.method_182())
							{
								this.method_187(arrayList_26);
							}
							this.method_186();
						}
					}
				}
			}
		}
		catch (Exception exception)
		{
		}
	}

	public void method_178(GClass16 gclass16_0)
	{
		int i;
		try
		{
			this.tabControlMain.SelectedIndex = GClass13.int_4;
			this.tabControlHotShare.SelectedIndex = 0;
			this.textBoxHotShareKW.Text = "";
			if (this.dataGridViewHotShare.Rows.Count > 0)
			{
				for (i = 0; i < this.dataGridViewHotShare.Rows.Count; i++)
				{
					this.dataGridViewHotShare.Rows[i].Selected = false;
				}
				i = 0;
				while (i < this.dataGridViewHotShare.Rows.Count)
				{
					if (((GClass16)this.dataGridViewHotShare.Rows[i].Tag).string_0.Equals(gclass16_0.string_0))
					{
						this.dataGridViewHotShare.Rows[i].Selected = true;
						this.dataGridViewHotShare.CurrentCell = this.dataGridViewHotShare.Rows[i].Cells[0];
						this.method_188();
						return;
					}
					else
					{
						i++;
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showClickHotShare]出错：", exception.ToString()));
		}
	}

	public void method_179(ArrayList arrayList_26)
	{
		try
		{
			int num = 0;
			this.method_180(this.linkLabelHot1, "");
			this.method_180(this.linkLabelHot2, "");
			foreach (GClass16 arrayList26 in arrayList_26)
			{
				if (arrayList26.int_1 <= 0)
				{
					continue;
				}
				if (num != 0)
				{
					this.method_181(this.linkLabelHot2, arrayList26);
				}
				else
				{
					this.method_181(this.linkLabelHot1, arrayList26);
				}
				num++;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ShowHotClick]出错：", exception.ToString()));
		}
	}

	public string method_18(ᝠ ᝠ_2, string string_96, string string_97, int int_28)
	{
		string str;
		int num = 0;
		while (true)
		{
			try
			{
				str = ᝠ_2.ᜂ(string_96, string_97);
				break;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				string str1 = exception.ToString();
				if ((str1.Contains("System.Net.WebException") ? false : !str1.Contains("System.IO.IOException")))
				{
					throw exception;
				}
				num++;
				if (num > int_28)
				{
					this.method_115(string.Concat("已重试", int_28, "次，服务器累成狗，等一会再试咯～～～"));
					throw exception;
				}
				this.method_115(string.Concat("等待3秒重试第【", num, "】次！"));
				Thread.Sleep(3000);
			}
		}
		return str;
	}

	public void method_180(LinkLabel linkLabel_0, string string_96)
	{
		try
		{
			if (!linkLabel_0.InvokeRequired)
			{
				linkLabel_0.Text = string_96;
			}
			else
			{
				AliBridgeForm.GDelegate76 gDelegate76 = new AliBridgeForm.GDelegate76(this.method_180);
				object[] linkLabel0 = new object[] { linkLabel_0, string_96 };
				base.BeginInvoke(gDelegate76, linkLabel0);
			}
		}
		catch (Exception exception)
		{
			this.method_115("[SetHotTxt]出点小错，不影响使用！");
		}
	}

	public void method_181(LinkLabel linkLabel_0, GClass16 gclass16_0)
	{
		try
		{
			if (!linkLabel_0.InvokeRequired)
			{
				string[] string2 = new string[] { "重要通知：", gclass16_0.string_2, " 价格【", gclass16_0.string_3, "】佣金【", gclass16_0.string_4, "%】" };
				linkLabel_0.Text = string.Concat(string2);
				linkLabel_0.Tag = gclass16_0;
			}
			else
			{
				AliBridgeForm.GDelegate77 gDelegate77 = new AliBridgeForm.GDelegate77(this.method_181);
				object[] linkLabel0 = new object[] { linkLabel_0, gclass16_0 };
				base.BeginInvoke(gDelegate77, linkLabel0);
			}
		}
		catch (Exception exception)
		{
			this.method_115("[ShowHotTxt]出点小错，不影响使用！");
		}
	}

	public bool method_182()
	{
		bool flag;
		try
		{
			if (!base.InvokeRequired)
			{
				flag = ((this.tabControlHotShare.SelectedIndex != 0 ? true : !this.textBoxHotShareKW.Text.Trim().Equals("")) ? false : true);
			}
			else
			{
				AliBridgeForm.GDelegate78 gDelegate78 = new AliBridgeForm.GDelegate78(this.method_182);
				IAsyncResult asyncResult = base.BeginInvoke(gDelegate78, new object[0]);
				flag = bool.Parse(base.EndInvoke(asyncResult).ToString());
			}
		}
		catch (Exception exception)
		{
			flag = false;
		}
		return flag;
	}

	private bool method_183(string[] string_96, ArrayList arrayList_26)
	{
		bool flag;
		try
		{
			string str = "";
			string[] string96 = string_96;
			for (int i = 0; i < (int)string96.Length; i++)
			{
				string str1 = string96[i];
				str = string.Concat(str, ᝉ.ᜀ(str1, 0, "hid:", ","));
			}
			string str2 = "";
			foreach (GClass16 arrayList26 in arrayList_26)
			{
				if (arrayList26.string_2.Equals(""))
				{
					flag = false;
					return flag;
				}
				else
				{
					str2 = string.Concat(str2, arrayList26.string_0);
				}
			}
			flag = str.Equals(str2);
		}
		catch (Exception exception)
		{
			this.method_115("[isNotModified]出点小错，不影响使用！");
			flag = false;
		}
		return flag;
	}

	private void method_184(string string_96, ArrayList arrayList_26)
	{
		try
		{
			string[] directories = Directory.GetDirectories(string_96);
			if (directories != null)
			{
				string[] strArrays = directories;
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					string str = strArrays[i];
					string str1 = str.Substring(str.LastIndexOf("\\") + 1);
					bool flag = false;
					IEnumerator enumerator = arrayList_26.GetEnumerator();
					try
					{
						while (true)
						{
							if (!enumerator.MoveNext())
							{
								break;
							}
							else if (str1.Equals(((GClass16)enumerator.Current).string_0))
							{
								flag = true;
								break;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					if (!flag)
					{
						Directory.Delete(str, true);
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115("[deleteInvalidHotShare]出点小错，不影响使用！");
		}
	}

	private bool method_185(string string_96)
	{
		bool flag;
		try
		{
			foreach (GClass16 arrayList7 in this.arrayList_7)
			{
				if ((!arrayList7.string_0.Equals(string_96) ? true : arrayList7.bool_0))
				{
					continue;
				}
				flag = false;
				return flag;
			}
			flag = true;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[isNew]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public void method_186()
	{
		try
		{
			int num = 0;
			while (num < this.arrayList_7.Count)
			{
				if (((GClass16)this.arrayList_7[num]).bool_0)
				{
					this.bool_22 = true;
					return;
				}
				else
				{
					num++;
				}
			}
			this.bool_22 = false;
		}
		catch
		{
			this.method_115("[CheckNewHotShare]出点小错，不影响使用！");
		}
	}

	public void method_187(ArrayList arrayList_26)
	{
		try
		{
			if (!this.dataGridViewHotShare.InvokeRequired)
			{
				this.dataGridViewHotShare.Rows.Clear();
				int string2 = 0;
				foreach (GClass16 arrayList26 in arrayList_26)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewHotShare.Rows.Add(dataGridViewRow);
					this.dataGridViewHotShare.Rows[string2].HeaderCell.Value = string.Concat(string2 + 1, (arrayList26.bool_0 ? "*" : ""));
					this.dataGridViewHotShare.Rows[string2].Tag = arrayList26;
					this.dataGridViewHotShare[0, string2].Value = arrayList26.string_2;
					this.dataGridViewHotShare[1, string2].Value = arrayList26.string_3;
					this.dataGridViewHotShare[2, string2].Value = arrayList26.string_4;
					DataGridViewCell item = this.dataGridViewHotShare[3, string2];
					string[] strArrays = new string[] { arrayList26.string_0.Substring(4, 2), "月", arrayList26.string_0.Substring(6, 2), "日 ", arrayList26.string_0.Substring(8, 2), ":", arrayList26.string_0.Substring(10, 2) };
					item.Value = string.Concat(strArrays);
					arrayList26.string_5 = string.Concat(string2 + 1, "");
					if (arrayList26.int_1 > 0)
					{
						this.dataGridViewHotShare.Rows[string2].DefaultCellStyle.ForeColor = Color.Red;
					}
					string2++;
				}
			}
			else
			{
				AliBridgeForm.GDelegate79 gDelegate79 = new AliBridgeForm.GDelegate79(this.method_187);
				object[] objArray = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate79, objArray);
			}
		}
		catch (Exception exception)
		{
			this.method_115("[ShowHotShare]出点小错，不影响使用！");
		}
	}

	private void method_188()
	{
		GClass16 tag = null;
		try
		{
			if (this.dataGridViewHotShare.CurrentCell != null)
			{
				tag = (GClass16)this.dataGridViewHotShare.CurrentRow.Tag;
				string str = this.method_171(tag.int_0);
				if (!Directory.Exists(string.Concat(str, "\\", tag.string_0)))
				{
					if (tag.int_0 != 2)
					{
						this.method_189(tag);
					}
					else
					{
						this.method_190(tag);
					}
				}
				string str1 = ᝚.ᜀ(string.Concat(str, "/", tag.string_0, "/hot.html"), Encoding.GetEncoding("GB2312"));
				((IHTMLDocument2)this.webBrowserHotShare.Document.DomDocument).body.innerHTML = str1;
				tag.bool_0 = false;
				this.dataGridViewHotShare.CurrentRow.HeaderCell.Value = this.dataGridViewHotShare.CurrentRow.HeaderCell.Value.ToString().Replace("*", "");
				this.method_186();
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if (!exception.ToString().Contains("System.IO.FileNotFoundException"))
			{
				this.method_115(string.Concat("[dataGridViewHotShare_Click]出错：", exception.ToString()));
			}
			else
			{
				if (tag.int_0 != 2)
				{
					this.method_189(tag);
				}
				else
				{
					this.method_190(tag);
				}
				this.method_115("[dataGridViewHotShare_Click]爆款已经重新下载，再点一次试试！");
			}
		}
	}

	public void method_189(GClass16 gclass16_0)
	{
		try
		{
			if (!this.bool_23)
			{
				this.bool_23 = true;
				string str = this.method_172(gclass16_0.int_0);
				string str1 = this.method_171(gclass16_0.int_0);
				string str2 = string.Concat(str1, "\\", gclass16_0.string_0);
				if (!Directory.Exists(str2))
				{
					Directory.CreateDirectory(str2);
				}
				string str3 = this.webClient_0.DownloadString(string.Concat(str, "/", gclass16_0.string_0, "/hot.html"));
				int num = 0;
				while (true)
				{
					int num1 = str3.IndexOf("{LCL_DIR}", num);
					num = num1;
					if (num1 == -1)
					{
						break;
					}
					int num2 = str3.IndexOf("\"", num) - num - 9;
					string str4 = str3.Substring(num + 9, num2);
					string str5 = string.Concat(str2, "\\", str4);
					if (File.Exists(str5))
					{
						File.Delete(str5);
					}
					WebClient webClient0 = this.webClient_0;
					string[] string0 = new string[] { str, "/", gclass16_0.string_0, "/", str4 };
					webClient0.DownloadFile(string.Concat(string0), str5);
					num++;
				}
				string str6 = str2.Replace("\\", "/").Replace(" ", "%20");
				str3 = str3.Replace("{LCL_DIR}", string.Concat("file:///", str6, "/"));
				str3 = str3.Replace("<IMG", "<IMG width=\"100%\" ");
				string str7 = string.Concat(str2, "\\hot.html");
				᝚.ᜁ(str7, str3, Encoding.GetEncoding("GB2312"));
				this.bool_23 = false;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.bool_23 = false;
			this.method_115(string.Concat("[downloadHotShare]出错：", exception.ToString()));
		}
	}

	private void method_19()
	{
		try
		{
			this.dataGridViewBrdg.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewBrdg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewBrdg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewBrdg.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "鹊桥编号",
				Width = 60
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "产品ID",
				Width = 85
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "店铺",
				Width = 40
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "标题",
				Width = 466
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn3);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "佣金(%)",
				Width = 60
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn4);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "分成(%)",
				Width = 60
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn5);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "实得(%)",
				Width = 60
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn6);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "特价",
				Width = 50
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn7);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "实际收入",
				Width = 60
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn8);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "销量",
				Width = 55
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn9);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "开始时间",
				Width = 80
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn10);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "结束时间",
				Width = 80
			};
			this.dataGridViewBrdg.Columns.Add(dataGridViewTextBoxColumn11);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initdataBrdgGridView]出错，", exception.ToString()));
		}
	}

	public void method_190(GClass16 gclass16_0)
	{
		bool flag;
		try
		{
			if (!this.bool_23)
			{
				this.bool_23 = true;
				string str = string.Concat(this.string_7, "\\", gclass16_0.string_0);
				if (!Directory.Exists(str))
				{
					Directory.CreateDirectory(str);
				}
				string str1 = this.webClient_0.DownloadString(string.Concat(this.string_6, "/", gclass16_0.string_0, "/hot.html"));
				str1 = str1.Replace("<img", "<IMG");
				int num = 0;
				while (true)
				{
					int num1 = str1.IndexOf("<IMG", num);
					num = num1;
					if (num1 == -1)
					{
						break;
					}
					int num2 = str1.IndexOf("src", num);
					int num3 = str1.IndexOf("SRC", num);
					int num4 = num2;
					if (num4 == -1)
					{
						flag = false;
					}
					else
					{
						flag = (num4 <= num3 ? true : num3 == -1);
					}
					if (!flag)
					{
						num4 = num3;
					}
					int num5 = str1.IndexOf("\"", num4) + 1;
					string str2 = str1.Substring(num5, str1.IndexOf("\"", num5) - num5);
					DateTime now = DateTime.Now;
					string str3 = string.Concat(str, "\\", now.ToString("yyyyMMddHHmmssfff"), str2.Substring(str2.LastIndexOf(".")));
					for (bool i = File.Exists(str3); i; i = File.Exists(str3))
					{
						object[] objArray = new object[] { str, "\\", null, null, null };
						now = DateTime.Now;
						objArray[2] = now.ToString("yyyyMMddHHmmss");
						now = DateTime.Now;
						objArray[3] = int.Parse(now.ToString("fff")) + 1;
						objArray[4] = str2.Substring(str2.LastIndexOf("."));
						str3 = string.Concat(objArray);
					}
					this.webClient_0.DownloadFile(str2, str3);
					string str4 = str3.Replace("\\", "/").Replace(" ", "%20");
					str1 = str1.Replace(str2, string.Concat("file:///", str4));
					num++;
				}
				string str5 = string.Concat(str, "\\hot.html");
				᝚.ᜁ(str5, str1, Encoding.GetEncoding("GB2312"));
				this.bool_23 = false;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.bool_23 = false;
			this.method_115(string.Concat("[downloadSelHotShare]出错：", exception.ToString()));
		}
	}

	public void method_191(object sender, EventArgs e)
	{
		this.webBrowserHotShare.Focus();
	}

	public void method_192()
	{
		this.webBrowserHotShare.Navigate(string.Concat(this.string_8, "?&q=", HttpUtility.UrlEncode(this.textBoxHotShareKW.Text)));
		this.method_390(false);
		this.webBrowserHotShare.Focus();
	}

	public void method_193()
	{
		string str = this.textBoxHotShareKW.Text.Trim();
		if (!str.Equals(""))
		{
			ArrayList arrayLists = new ArrayList();
			this.method_194(str, this.arrayList_7, arrayLists);
			this.method_194(str, this.arrayList_8, arrayLists);
			this.method_194(str, this.arrayList_9, arrayLists);
			this.method_194(str, this.arrayList_10, arrayLists);
			this.method_187(arrayLists);
		}
		else if (this.tabControlHotShare.SelectedIndex == 0)
		{
			this.method_187(this.arrayList_7);
		}
		else if (this.tabControlHotShare.SelectedIndex == 1)
		{
			this.method_187(this.arrayList_8);
		}
		else if (this.tabControlHotShare.SelectedIndex == 2)
		{
			this.method_187(this.arrayList_9);
		}
		else if (this.tabControlHotShare.SelectedIndex == 3)
		{
			this.method_187(this.arrayList_10);
		}
	}

	public ArrayList method_194(string string_96, ArrayList arrayList_26, ArrayList arrayList_27)
	{
		string_96 = string_96.Replace("\u3000", " ");
		string[] strArrays = string_96.Split(new char[] { ' ' });
		foreach (GClass16 arrayList26 in arrayList_26)
		{
			int num = 0;
			string[] strArrays1 = strArrays;
			for (int i = 0; i < (int)strArrays1.Length; i++)
			{
				string str = strArrays1[i];
				if (!arrayList26.string_2.Contains(str))
				{
					break;
				}
				num++;
			}
			if (num != (int)strArrays.Length)
			{
				continue;
			}
			arrayList_27.Add(arrayList26);
		}
		return arrayList_27;
	}

	private void method_195()
	{
		try
		{
			this.arrayList_7 = new ArrayList();
			if (File.Exists(this.string_57))
			{
				StreamReader streamReader = new StreamReader(this.string_57, Encoding.GetEncoding("GB2312"));
				string str = null;
				while (true)
				{
					string str1 = streamReader.ReadLine();
					str = str1;
					if (str1 == null)
					{
						break;
					}
					if (!str.Equals(""))
					{
						GClass16 gClass16 = new GClass16()
						{
							string_0 = str
						};
						this.arrayList_7.Add(gClass16);
					}
				}
				streamReader.Close();
				streamReader.Dispose();
			}
		}
		catch (Exception exception)
		{
			this.method_115("[loadSavedHotShareHid]出点小错，不影响使用！");
		}
	}

	private void method_196(string string_96, ArrayList arrayList_26)
	{
		try
		{
			if (File.Exists(string_96))
			{
				File.Delete(string_96);
			}
			FileStream fileStream = new FileStream(string_96, FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding("GB2312"));
			foreach (GClass16 arrayList26 in arrayList_26)
			{
				streamWriter.WriteLine(arrayList26.string_0);
			}
			streamWriter.Flush();
			streamWriter.Close();
			streamWriter.Dispose();
			fileStream.Close();
			fileStream.Dispose();
		}
		catch (Exception exception)
		{
			this.method_115("[saveHotShareHid]出点小错，不影响使用！");
		}
	}

	private void method_197()
	{
		try
		{
			this.webBrowserHotShare.ScriptErrorsSuppressed = true;
			this.webBrowserHotShare.Navigate(this.string_8);
			this.webBrowserHotShare.IsWebBrowserContextMenuEnabled = false;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initWebBrowserHotSharee]出错：", exception.ToString()));
		}
	}

	private string method_198(string string_96)
	{
		string string96;
		try
		{
			if (!this.checkBoxShortUrl.Checked)
			{
				string96 = string_96;
			}
			else
			{
				int num = 0;
				while (num < 3)
				{
					string str = this.method_204(string_96);
					if (!"error".Equals(str))
					{
						string96 = str;
						return string96;
					}
					else
					{
						Thread.Sleep(1000);
						num++;
					}
				}
				string96 = "error";
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getLink]出错：", exception.ToString()));
			string96 = "";
		}
		return string96;
	}

	private string method_199(string string_96)
	{
		string string96;
		try
		{
			if (string_96 == null)
			{
				string96 = null;
			}
			else if (!this.checkBoxShortUrl.Checked)
			{
				string96 = string_96;
			}
			else
			{
				string96 = (string_96.Length <= 50 ? string_96 : this.method_204(string_96));
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getOnLink]出错：", exception.ToString()));
			string96 = "";
		}
		return string96;
	}

	public void method_2(string string_96)
	{
		try
		{
			if (!this.linkLabelCurUserNum.InvokeRequired)
			{
				this.linkLabelCurUserNum.Text = string_96;
			}
			else
			{
				AliBridgeForm.GDelegate54 gDelegate54 = new AliBridgeForm.GDelegate54(this.method_2);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate54, string96);
			}
		}
		catch
		{
		}
	}

	private void method_20()
	{
		try
		{
			this.dataGridViewOnlineBrdg.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewOnlineBrdg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewOnlineBrdg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewOnlineBrdg.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "鹊桥编号",
				Width = 65
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "产品ID",
				Width = 85
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "店铺",
				Width = 50
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "标题",
				Width = 506
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn3);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "佣金(%)",
				Width = 70
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn4);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "分成(%)",
				Width = 60
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn5);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "实得(%)",
				Width = 60
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn6);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "特价",
				Width = 60
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn7);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "实际收入",
				Width = 60
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn8);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "销量",
				Width = 58
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn9);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "剩余天数",
				Width = 80
			};
			this.dataGridViewOnlineBrdg.Columns.Add(dataGridViewTextBoxColumn10);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initOnlinedataBrdgGridView]出错，", exception.ToString()));
		}
	}

	private string method_200(string string_96)
	{
		string str;
		try
		{
			WebClient webClient = new WebClient();
			string str1 = string.Concat("url=", HttpUtility.UrlEncode(string_96));
			string str2 = "http://www.dwz.cn/create.php";
			webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
			string str3 = webClient.UploadString(str2, "POST", str1);
			if (!str3.Contains("\"status\":0"))
			{
				this.method_115(string.Concat("[百度短链接]获取出错！原网址：【", string_96, "】"));
				str = "error";
			}
			else
			{
				str = ᝉ.ᜀ(str3, 0, "\"tinyurl\":\"", "\"").Replace("\\", "");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBaiduShortUrl]出错：", exception.ToString()));
			str = "error";
		}
		return str;
	}

	private string method_201(string string_96)
	{
		string str;
		try
		{
			if (!string_96.StartsWith("http"))
			{
				string_96 = string.Concat("http://", string_96);
			}
			string str1 = string.Concat("http://api.t.sina.com.cn/short_url/shorten.json?source=3271760578&url_long=", HttpUtility.UrlEncode(string_96));
			string str2 = (new WebClient()).DownloadString(str1);
			str = ᝉ.ᜀ(str2, 0, "\"url_short\":\"", "\"");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getXinlangShortUrl]出错：", exception.ToString()));
			str = "error";
		}
		return str;
	}

	private string method_202(string string_96)
	{
		string str;
		try
		{
			if (!string_96.StartsWith("http"))
			{
				string_96 = string.Concat("http://", string_96);
			}
			string str1 = "http://ymb.bz";
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			this.webClient_0.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
			byte[] numArray = webClient.UploadData(str1, "POST", Encoding.UTF8.GetBytes(string.Concat("url=", HttpUtility.UrlEncode(string_96))));
			string str2 = "";
			str2 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : ᜸.ᜀ(numArray, Encoding.UTF8));
			int num = 0;
			if (!(!string_96.Contains("shop.m.taobao.com") ? true : !string_96.Contains("coupon")))
			{
				num = str2.IndexOf("手机券");
			}
			else if ((!string_96.Contains("taobao.com") ? false : string_96.Contains("coupon")))
			{
				num = str2.IndexOf("电脑券");
			}
			int num1 = str2.IndexOf("http://ymb.bz/", str2.IndexOf("txt-copy", num));
			int num2 = str2.IndexOf("</b>", num1) - num1;
			str = str2.Substring(num1, num2);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getYMBShortUrl]出错：", exception.ToString()));
			str = "error";
		}
		return str;
	}

	private void method_203(object sender, EventArgs e)
	{
		(new SoundPlayer()
		{
			SoundLocation = "e:\\2.wav"
		}).Play();
	}

	private string method_204(string string_96)
	{
		string str;
		if (this.int_5 == 0)
		{
			str = this.method_201(string_96);
		}
		else if (this.int_5 != 1)
		{
			str = (this.int_5 != 2 ? "error" : this.method_289(string_96));
		}
		else
		{
			str = this.method_200(string_96);
		}
		return str;
	}

	private string method_205(string string_96, int int_28)
	{
		string string96;
		try
		{
			string str = "user={user}&type=shorturl&url={url}";
			str = str.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{url}", HttpUtility.UrlEncode(string_96));
			string str1 = this.method_17(this.ᝠ_1, this.string_2, str);
			Hashtable hashtables = this.method_206(str1);
			if (!"ng".Equals(hashtables["result"]))
			{
				string item = (string)hashtables["taoshorturl"];
				string96 = item.Replace("http://", "https://");
			}
			else
			{
				this.method_115(string.Concat("生成淘宝短网址失败：", (string)hashtables["errmsg"]));
				string96 = null;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if (int_28 <= 2)
			{
				string96 = this.method_205(string_96, int_28 + 1);
			}
			else
			{
				this.method_115(string.Concat("生成淘宝短网址失败！", exception.ToString()));
				string96 = string_96;
			}
		}
		return string96;
	}

	public Hashtable method_206(string string_96)
	{
		char[] chrArray = new char[] { '&' };
		string[] strArrays = string_96.Split(chrArray);
		Hashtable hashtables = new Hashtable();
		string[] strArrays1 = strArrays;
		for (int i = 0; i < (int)strArrays1.Length; i++)
		{
			string str = strArrays1[i];
			chrArray = new char[] { '=' };
			string[] strArrays2 = str.Split(chrArray);
			hashtables.Add(strArrays2[0], strArrays2[1]);
		}
		return hashtables;
	}

	public void method_207()
	{
		string str = this.method_17(this.ᝠ_0, this.string_0, "type=getsysdate");
		this.method_208(str);
	}

	public bool method_208(string string_96)
	{
		bool flag;
		try
		{
			this.string_65 = string.Concat(this.string_41, "\\config\\taobaoqiang.txt");
			bool flag1 = false;
			ArrayList arrayLists = this.gclass10_0.method_5(GClass13.string_2, out this.string_23);
			if (arrayLists.Count != 0 && long.Parse(((GClass19)arrayLists[0]).string_1.Substring(0, 8)) >= long.Parse(string_96.Substring(0, 8)))
			{
				flag1 = true;
			}
			if (!flag1)
			{
				string str = this.method_17(this.ᝠ_0, this.string_0, string.Concat("type=gettqq&datatype=", GClass13.string_2));
				char[] chrArray = new char[] { ';' };
				string[] strArrays = str.Split(chrArray);
				string str1 = strArrays[0];
				chrArray = new char[] { '=' };
				string str2 = str1.Split(chrArray)[1];
				string str3 = strArrays[1];
				chrArray = new char[] { '=' };
				string str4 = str3.Split(chrArray)[1];
				string str5 = strArrays[2];
				chrArray = new char[] { '=' };
				string str6 = str5.Split(chrArray)[1];
				if (long.Parse(str4.Substring(0, 8)) >= long.Parse(string_96.Substring(0, 8)))
				{
					string str7 = string.Concat("http://", ᝮ.ᜄ, ":80/tqqdata/", str6);
					ᝣ.ᜀ(string.Concat(str7, "/taobaoqiang.txt"), this.string_65);
				}
				else if (MessageBox.Show("服务器没有最新的数据，自己下载吗？", "采集数据提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Cancel)
				{
					flag = false;
					return flag;
				}
				else if (ᜃ.ᜋ(this.string_20))
				{
					this.bool_24 = true;
					this.timer_1 = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
					this.timer_1.Start();
					while (this.bool_24)
					{
						Thread.Sleep(1000);
					}
					str4 = DateTime.Now.ToString("yyyyMMddHHmmss");
				}
				else
				{
					this.method_115("登录阿里妈妈以后再采集淘清仓！");
					this.bool_0 = false;
					this.method_7();
					flag = false;
					return flag;
				}
				this.gclass10_0.method_11(out this.string_23);
				this.gclass10_0.method_6(GClass13.string_2, out this.string_23);
				this.method_237();
				GClass19 gClass19 = new GClass19()
				{
					string_0 = GClass13.string_2,
					string_1 = str4,
					string_2 = str6
				};
				this.gclass10_0.method_4(gClass19, out this.string_23);
				File.Delete(this.string_65);
				this.method_115("更新淘抢购数据成功！");
				flag = true;
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[processTaobaoQiang]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public bool method_209(string string_96)
	{
		bool flag;
		try
		{
			this.string_64 = string.Concat(this.string_41, "\\config\\taobaoqing.txt");
			bool flag1 = false;
			ArrayList arrayLists = this.gclass10_0.method_5(GClass13.string_1, out this.string_23);
			if (arrayLists.Count != 0 && long.Parse(((GClass19)arrayLists[0]).string_1.Substring(0, 8)) >= long.Parse(string_96.Substring(0, 8)))
			{
				flag1 = true;
			}
			if (!flag1)
			{
				string str = this.method_17(this.ᝠ_0, this.string_0, string.Concat("type=gettqq&datatype=", GClass13.string_1));
				char[] chrArray = new char[] { ';' };
				string[] strArrays = str.Split(chrArray);
				string str1 = strArrays[0];
				chrArray = new char[] { '=' };
				string str2 = str1.Split(chrArray)[1];
				string str3 = strArrays[1];
				chrArray = new char[] { '=' };
				string str4 = str3.Split(chrArray)[1];
				string str5 = strArrays[2];
				chrArray = new char[] { '=' };
				string str6 = str5.Split(chrArray)[1];
				if (long.Parse(str4.Substring(0, 8)) >= long.Parse(string_96.Substring(0, 8)))
				{
					string str7 = string.Concat("http://", ᝮ.ᜄ, ":80/tqqdata/", str6);
					ᝣ.ᜀ(string.Concat(str7, "/taobaoqing.txt"), this.string_64);
				}
				else if (MessageBox.Show("服务器没有最新的数据，自己下载吗？", "采集数据提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Cancel)
				{
					flag = false;
					return flag;
				}
				else if (ᜃ.ᜋ(this.string_20))
				{
					this.method_210();
					str4 = DateTime.Now.ToString("yyyyMMddHHmmss");
				}
				else
				{
					this.method_115("登录阿里妈妈以后再采集淘清仓！");
					this.bool_0 = false;
					this.method_7();
					flag = false;
					return flag;
				}
				this.gclass10_0.method_16(out this.string_23);
				this.gclass10_0.method_6(GClass13.string_1, out this.string_23);
				this.method_236();
				GClass19 gClass19 = new GClass19()
				{
					string_0 = GClass13.string_1,
					string_1 = str4,
					string_2 = str6
				};
				this.gclass10_0.method_4(gClass19, out this.string_23);
				File.Delete(this.string_64);
				this.method_115("更新淘清仓数据成功！");
				flag = true;
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[processTaobaoQing]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private void method_21()
	{
		try
		{
			this.dataGridViewFollowSnd.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewFollowSnd.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewFollowSnd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewFollowSnd.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "时间",
				Width = 100
			};
			this.dataGridViewFollowSnd.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "内容",
				Width = 475
			};
			this.dataGridViewFollowSnd.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "状态",
				Width = 60
			};
			this.dataGridViewFollowSnd.Columns.Add(dataGridViewTextBoxColumn2);
			for (int i = 0; i < this.dataGridViewFollowSnd.Columns.Count; i++)
			{
				this.dataGridViewFollowSnd.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initFollowSndGridView]出错，", exception.ToString()));
		}
	}

	public bool method_210()
	{
		bool flag;
		try
		{
			this.arrayList_11 = ᜤ.ᜄ(ᜈ.ᜀ("http://www.taobao.com"));
			int num = 1;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 10; i++)
			{
				try
				{
					ᜥ item = (ᜥ)this.arrayList_11[i];
					object[] count = new object[] { "第【", num, "/", this.arrayList_11.Count, "】个开始处理。。。" };
					this.method_115(string.Concat(count));
					double num1 = 0;
					int num2 = 0;
					string str = "";
					double num3 = 0;
					if (this.method_215(item.ᜀ, out num1, out num2, out str, out num3))
					{
						item.ᜅ = num1;
						item.ᜄ = num2;
						item.ᜆ = str;
						item.ᜇ = num3;
						if (num != 1)
						{
							stringBuilder.Append(string.Concat("\n", item.ᜉ()));
						}
						else
						{
							stringBuilder.Append(item.ᜉ());
						}
						count = new object[] { "第【", num, "/", this.arrayList_11.Count, "】个处理完成！计划佣金【", num1, "】鹊桥ID【", str, "】鹊桥佣金【", num3, "】" };
						this.method_115(string.Concat(count));
						num++;
					}
					else
					{
						flag = false;
						return flag;
					}
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					if (!exception.ToString().Contains("System.Net.WebException"))
					{
						this.method_115(string.Concat("【collectTaoBaoQing】出错", exception.ToString()));
					}
					else
					{
						this.method_115("网络一时问题，正在重试!【采集淘清仓】出错【System.Net.WebException】");
						Thread.Sleep(2000);
						i--;
					}
				}
				Thread.Sleep(1000);
			}
			᝚.ᜁ(this.string_64, stringBuilder.ToString());
			this.method_115("开始上传淘清仓。。。");
			string str1 = ᜸.ᜀ(8);
			string str2 = "";
			ᝯ _ᝯ = new ᝯ();
			_ᝯ.ᜀ("data", string.Concat("type=uploadfile&destfolder=tqqdata/", str1));
			_ᝯ.ᜀ("upfile", this.string_64, "application/octet-stream");
			_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/uploadfile.php"), ref str2);
			if (!"ok".Equals(str2))
			{
				_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/uploadfile.php"), ref str2);
			}
			_ᝯ = new ᝯ();
			_ᝯ.ᜀ("data", string.Concat("type=completeupload&datatype=taobaoqing&username=", this.ᜐ_0.ᜁ, "&folderName=", str1));
			_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/uploadfile.php"), ref str2);
			if (!"ok".Equals(str2))
			{
				_ᝯ = new ᝯ();
				_ᝯ.ᜀ("data", string.Concat("type=completeupload&datatype=taobaoqing&username=", this.ᜐ_0.ᜁ, "&folderName=", str1));
				_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/uploadfile.php"), ref str2);
			}
			this.method_115("上传淘清仓完成！");
			flag = true;
		}
		catch (Exception exception2)
		{
			this.method_115(string.Concat("[collectTaoBaoQing]出错！", exception2.ToString()));
			flag = false;
		}
		return flag;
	}

	public void method_211()
	{
		try
		{
			bool flag = true;
			string str = this.method_17(this.ᝠ_0, this.string_0, string.Concat("type=gettqq&datatype=", GClass13.string_1));
			char[] chrArray = new char[] { ';' };
			string[] strArrays = str.Split(chrArray);
			string str1 = strArrays[0];
			chrArray = new char[] { '=' };
			string str2 = str1.Split(chrArray)[1];
			string str3 = strArrays[1];
			chrArray = new char[] { '=' };
			string str4 = str3.Split(chrArray)[1];
			ArrayList arrayLists = this.gclass10_0.method_5(GClass13.string_1, out this.string_23);
			if (arrayLists.Count != 0 && long.Parse(((GClass19)arrayLists[0]).string_1) >= long.Parse(str2))
			{
				flag = false;
			}
			if (flag)
			{
				this.method_115("有新数据，正在更新淘清仓淘抢购数据！");
				this.string_64 = string.Concat(this.string_41, "\\config\\taobaoqing.txt");
				this.string_65 = string.Concat(this.string_41, "\\config\\taobaoqiang.txt");
				if (File.Exists(this.string_64))
				{
					File.Delete(this.string_64);
				}
				if (File.Exists(this.string_65))
				{
					File.Delete(this.string_65);
				}
				string str5 = string.Concat("http://", ᝮ.ᜄ, ":80/tqqdata/", str4);
				ᝣ.ᜀ(string.Concat(str5, "/taobaoqing.txt"), this.string_64);
				ᝣ.ᜀ(string.Concat(str5, "/taobaoqiang.txt"), this.string_65);
				this.gclass10_0.method_16(out this.string_23);
				this.gclass10_0.method_11(out this.string_23);
				this.gclass10_0.method_6(GClass13.string_1, out this.string_23);
				this.method_236();
				this.method_237();
				GClass19 gClass19 = new GClass19()
				{
					string_1 = str2,
					string_2 = str4
				};
				this.gclass10_0.method_4(gClass19, out this.string_23);
				File.Delete(this.string_64);
				File.Delete(this.string_65);
				this.method_115("更新淘清仓淘抢购数据成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[updTaoQingQiang]出错：", exception.ToString()));
		}
	}

	private void method_212()
	{
		this.timer_1 = new System.Windows.Forms.Timer()
		{
			Interval = 20000
		};
		this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
		this.timer_1.Start();
	}

	public void method_213()
	{
		ᝰ arrayList0 = null;
		string str = string.Concat(this.string_41, "\\config\\临时文件夹\\taobaoqiang.txt");
		ArrayList arrayLists = new ArrayList();
		foreach (GClass18 arrayList13 in this.arrayList_13)
		{
			foreach (ᝰ arrayList0 in arrayList13.arrayList_0)
			{
				arrayLists.Add(arrayList0);
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		while (true)
		{
			if (num >= arrayLists.Count)
			{
				᝚.ᜁ(str, stringBuilder.ToString());
				string str1 = "";
				this.method_115("开始上传。。。");
				string str2 = ᜸.ᜀ(8);
				ᝯ _ᝯ = new ᝯ();
				_ᝯ.ᜀ("data", string.Concat("type=uploadfile&destfolder=tqqdata/", str2));
				_ᝯ.ᜀ("upfile", str, "application/octet-stream");
				_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/uploadfile.php"), ref str1);
				this.method_115("上传完成");
				break;
			}
			else
			{
				try
				{
					arrayList0 = (ᝰ)arrayLists[num];
					object[] count = new object[] { "第【", num + 1, "/", arrayLists.Count, "】个开始处理。。。" };
					this.method_115(string.Concat(count));
					double num1 = 0;
					int num2 = 0;
					string str3 = "";
					double num3 = 0;
					if (this.method_215(arrayList0.ᜀ, out num1, out num2, out str3, out num3))
					{
						arrayList0.ᜈ = num1;
						arrayList0.ᜇ = num2;
						arrayList0.ᜉ = str3;
						arrayList0.ᜊ = num3;
						if (num != 0)
						{
							stringBuilder.Append(string.Concat("\n", arrayList0.ᜌ()));
						}
						else
						{
							stringBuilder.Append(arrayList0.ᜌ());
						}
						count = new object[] { "第【", num + 1, "/", arrayLists.Count, "】个处理完成！计划佣金【", num1, "】鹊桥ID【", str3, "】鹊桥佣金【", num3, "】" };
						this.method_115(string.Concat(count));
						Thread.Sleep(200);
					}
					else
					{
						break;
					}
				}
				catch
				{
					num--;
				}
				num++;
			}
		}
	}

	private HtmlElement method_214(HtmlElement htmlElement_0, string string_96, string string_97, string string_98)
	{
		HtmlElement htmlElement;
		foreach (HtmlElement elementsByTagName in htmlElement_0.GetElementsByTagName(string_96))
		{
			if (!string_98.Equals(elementsByTagName.GetAttribute(string_97)))
			{
				continue;
			}
			htmlElement = elementsByTagName;
			return htmlElement;
		}
		htmlElement = null;
		return htmlElement;
	}

	private bool method_215(string string_96, out double double_1, out int int_28, out string string_97, out double double_2)
	{
		bool flag;
		IEnumerator enumerator;
		double_1 = 0;
		int_28 = 0;
		string_97 = "";
		double_2 = 0;
		try
		{
			ArrayList arrayLists = this.method_273(string_96);
			ArrayList arrayLists1 = this.method_332(string_96, true);
			if ((arrayLists1 == null ? false : arrayLists1.Count != 0))
			{
				int_28 = 0;
				if ((arrayLists == null ? false : arrayLists.Count != 0))
				{
					int num = 0;
					enumerator = arrayLists.GetEnumerator();
					try
					{
						while (true)
						{
							if (enumerator.MoveNext())
							{
								GClass21 current = (GClass21)enumerator.Current;
								if (num > 4)
								{
									break;
								}
								num++;
								if (this.method_288(current.string_1, (float)current.double_1) != null)
								{
									if ((double)((float)(current.double_2 / current.double_1)) >= 0.95)
									{
										double_2 = (double)((float)current.double_2);
									}
									else
									{
										double_2 = (double)((float)(current.double_1 * 0.95));
									}
									string_97 = current.string_0;
									break;
								}
								else
								{
									Thread.Sleep(400);
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
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
				foreach (᝘ _u1758 in arrayLists1)
				{
					double_1 = (double)((float)_u1758.ᜁ);
					if ((_u1758.ᜊ == null || _u1758.ᜊ.Equals("") || _u1758.ᜊ.Equals("1") || _u1758.ᜊ.Equals("2") || _u1758.ᜊ.Equals("3") ? true : _u1758.ᜊ.Equals("5")))
					{
						break;
					}
					_u1758.ᜊ.Equals("4");
				}
				flag = true;
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_115(string.Concat("[getItemHighestCms]出错！产品ID：【", string_96, "】，", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public void method_216()
	{
		try
		{
			bool flag = true;
			string str = this.method_17(this.ᝠ_0, this.string_0, string.Concat("type=gettqq&datatype=", GClass13.string_1));
			char[] chrArray = new char[] { ';' };
			string[] strArrays = str.Split(chrArray);
			string str1 = strArrays[0];
			chrArray = new char[] { '=' };
			string str2 = str1.Split(chrArray)[1];
			string str3 = strArrays[1];
			chrArray = new char[] { '=' };
			string str4 = str3.Split(chrArray)[1];
			ArrayList arrayLists = this.gclass10_0.method_5(GClass13.string_1, out this.string_23);
			if (arrayLists.Count != 0 && long.Parse(((GClass19)arrayLists[0]).string_1) >= long.Parse(str2))
			{
				flag = false;
			}
			if (flag)
			{
				this.method_115("有新数据，正在更新淘清仓淘抢购数据！");
				this.string_64 = string.Concat(this.string_41, "\\config\\taobaoqing.txt");
				this.string_65 = string.Concat(this.string_41, "\\config\\taobaoqiang.txt");
				if (File.Exists(this.string_64))
				{
					File.Delete(this.string_64);
				}
				if (File.Exists(this.string_65))
				{
					File.Delete(this.string_65);
				}
				string str5 = string.Concat("http://", ᝮ.ᜄ, ":80/tqqdata/", str4);
				ᝣ.ᜀ(string.Concat(str5, "/taobaoqing.txt"), this.string_64);
				ᝣ.ᜀ(string.Concat(str5, "/taobaoqiang.txt"), this.string_65);
				this.gclass10_0.method_16(out this.string_23);
				this.gclass10_0.method_11(out this.string_23);
				this.gclass10_0.method_6(GClass13.string_1, out this.string_23);
				this.method_236();
				this.method_237();
				GClass19 gClass19 = new GClass19()
				{
					string_1 = str2,
					string_2 = str4
				};
				this.gclass10_0.method_4(gClass19, out this.string_23);
				File.Delete(this.string_64);
				File.Delete(this.string_65);
				this.method_115("更新淘清仓淘抢购数据成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[updTaoQingQiang]出错：", exception.ToString()));
		}
	}

	private void method_217()
	{
		try
		{
			try
			{
				this.double_0 = double.Parse(this.textBoxTQQLCms.Text.Trim());
			}
			catch
			{
				this.double_0 = 10;
				this.textBoxTQQLCms.Text = "10";
			}
			this.arrayList_11 = this.gclass10_0.method_13(this.double_0, out this.string_23);
			this.arrayList_12 = this.gclass10_0.method_8(this.double_0, out this.string_23);
			object[] count = new object[] { "淘清仓【", this.arrayList_11.Count, "】个产品，淘抢购【", this.arrayList_12.Count, "】个产品。" };
			this.method_115(string.Concat(count));
			this.method_233();
			this.method_234();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showTaoQingQiangData]出错：", exception.ToString()));
		}
	}

	private void method_218(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQing.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQing[0, this.dataGridViewTaobaoQing.CurrentCell.RowIndex].Value.ToString();
				ᜥ _ᜥ = this.method_231(str);
				this.textBoxOItemId.Text = _ᜥ.ᜀ;
				this.tabControlMain.SelectedIndex = GClass13.int_0;
				this.method_271();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenTaoQingBridge_Click]出错：", exception.ToString()));
		}
	}

	private void method_219(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQing.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQing[0, this.dataGridViewTaobaoQing.CurrentCell.RowIndex].Value.ToString();
				ᜥ _ᜥ = this.method_231(str);
				this.dataGridViewCmsPlan.Visible = false;
				this.string_67 = _ᜥ.ᜀ;
				this.int_20 = 2;
				this.method_240();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenTaoQingHiCms_Click]出错：", exception.ToString()));
		}
	}

	private void method_22()
	{
		try
		{
			this.dataGridViewAliOdr.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewAliOdr.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewAliOdr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewAliOdr.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "创建时间",
				Width = 140
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "宝贝标题",
				Width = 323
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "产品ID",
				Width = 80
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "订单编号",
				Width = 121
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn3);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "订单状态",
				Width = 75
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn4);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "付款金额",
				Width = 75
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn5);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "收入比率",
				Width = 75
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn6);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "实际收入",
				Width = 75
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn7);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "推广位",
				Width = 100
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn8);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "阿里妈妈账号",
				Width = 100
			};
			this.dataGridViewAliOdr.Columns.Add(dataGridViewTextBoxColumn9);
			this.method_23();
			this.method_107();
			this.comboBoxOrderSts.Items.Add("全部订单");
			this.comboBoxOrderSts.Items.Add("有效订单");
			this.comboBoxOrderSts.Items.Add("订单创建");
			this.comboBoxOrderSts.Items.Add("订单付款");
			this.comboBoxOrderSts.Items.Add("订单成功");
			this.comboBoxOrderSts.Items.Add("订单结算");
			this.comboBoxOrderSts.Items.Add("订单失效");
			this.comboBoxOrderSts.SelectedIndex = 1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initAliOdrGridView]出错，", exception.ToString()));
		}
	}

	private void method_220(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQing.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQing[0, this.dataGridViewTaobaoQing.CurrentCell.RowIndex].Value.ToString();
				ᜥ _ᜥ = this.method_231(str);
				Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", _ᜥ.ᜀ));
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenTaoQingProduct_Click]出错：", exception.ToString()));
		}
	}

	private void method_221(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQiang.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQiang[0, this.dataGridViewTaobaoQiang.CurrentCell.RowIndex].Value.ToString();
				ᝰ _ᝰ = this.method_232(str);
				this.textBoxOItemId.Text = _ᝰ.ᜀ;
				this.tabControlMain.SelectedIndex = GClass13.int_0;
				this.method_271();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenTaoQiangBridge_Click]出错：", exception.ToString()));
		}
	}

	private void method_222(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQiang.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQiang[0, this.dataGridViewTaobaoQiang.CurrentCell.RowIndex].Value.ToString();
				ᝰ _ᝰ = this.method_232(str);
				this.dataGridViewCmsPlan.Visible = false;
				this.string_67 = _ᝰ.ᜀ;
				this.int_20 = 3;
				this.method_240();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenTaoQiangHiCms_Click]出错：", exception.ToString()));
		}
	}

	private void method_223(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewTaobaoQiang.CurrentCell != null)
			{
				string str = this.dataGridViewTaobaoQiang[0, this.dataGridViewTaobaoQiang.CurrentCell.RowIndex].Value.ToString();
				ᝰ _ᝰ = this.method_232(str);
				if (this.dataGridViewTaobaoQiang.CurrentCell.ColumnIndex == 0)
				{
					Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", _ᝰ.ᜀ, "&umpChannel=qianggou&u_channel=qianggou"));
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenTaoQiangProduct_Click]出错：", exception.ToString()));
		}
	}

	public void method_224()
	{
		try
		{
			while (!ᜃ.ᜋ(this.string_20))
			{
				Thread.Sleep(180000);
			}
			int num = 1;
			do
			{
				ArrayList arrayLists = ᜃ.ᜀ(num, this.string_20, ref this.string_23);
				if (arrayLists.Count == 0)
				{
					break;
				}
				string str = "";
				foreach (᝘ _u1758 in arrayLists)
				{
					if ((_u1758.ᜎ ? true : !"1".Equals(_u1758.ᜏ)) || this.gclass42_0.method_14(_u1758.ᜇ, _u1758.ᜈ, _u1758.ᜃ, out this.string_23) != null)
					{
						continue;
					}
					ArrayList arrayLists1 = ᜃ.ᜂ(_u1758.ᜈ, this.string_20, ref this.string_23);
					if (this.method_225(_u1758.ᜃ, arrayLists1))
					{
						string[] strArrays = new string[] { _u1758.ᜇ, "_", _u1758.ᜈ, "_", _u1758.ᜃ };
						str = string.Concat(strArrays);
						this.method_17(this.ᝠ_0, this.string_71, string.Concat("user=", this.ᜐ_0.ᜁ, "&type=uphide&data=", str));
					}
					Thread.Sleep(10000);
					this.gclass42_0.method_13(_u1758.ᜇ, _u1758.ᜈ, _u1758.ᜃ, out this.string_23);
				}
				num++;
			}
			while (ᜃ.ᜋ(this.string_20));
		}
		catch
		{
		}
	}

	private bool method_225(string string_96, ArrayList arrayList_26)
	{
		bool flag;
		try
		{
			bool flag1 = true;
			IEnumerator enumerator = arrayList_26.GetEnumerator();
			try
			{
				while (true)
				{
					if (!enumerator.MoveNext())
					{
						break;
					}
					else if (string_96.Equals(((᝘)enumerator.Current).ᜃ))
					{
						flag1 = false;
						break;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			flag = flag1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkHiden]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private void method_226(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewCmsPlan.CurrentCell != null)
			{
				string str = this.dataGridViewCmsPlan[0, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				᝘ _u1758 = this.method_245(str);
				if (!ᜃ.ᜋ(this.string_20))
				{
					this.method_115("没有登录阿里妈妈！");
					this.bool_0 = false;
					this.method_7();
				}
				else if ((this.string_36 == null ? false : !"".Equals(this.string_36)))
				{
					ᜃ.ᜂ(_u1758.ᜃ, _u1758.ᜇ, this.string_37, this.string_36, this.string_20, ref this.string_23);
					this.method_115(string.Concat("【", _u1758.ᜄ, "】", this.string_23));
					this.method_240();
				}
				else
				{
					this.method_115("没有申请理由！在【软件设置】页面【申请高佣金理由】栏填上申请高佣金理由，点【保存】。");
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[AppHiCms_Click]出错：", exception.ToString()));
		}
	}

	private void method_227(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewCmsPlan.CurrentCell != null)
			{
				string str = this.dataGridViewCmsPlan[0, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				this.method_245(str);
				if (ᜃ.ᜋ(this.string_20))
				{
					Clipboard.Clear();
					string str1 = ᜃ.ᜅ(ᜃ.ᜀ(this.string_67, this.string_27, this.string_26, this.string_20));
					try
					{
						Clipboard.SetText(str1);
						this.method_115(string.Concat("获取推广链接成功！已经复制到剪切板，可以直接粘贴！【", str1, "】"));
					}
					catch
					{
						this.method_115(string.Concat("获取推广链接成功！【", str1, "】"));
					}
				}
				else
				{
					this.method_115("没有登录阿里妈妈！");
					this.bool_0 = false;
					this.method_7();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[PromotHiCms_Click]出错：", exception.ToString()));
		}
	}

	private void method_228(object sender, EventArgs e)
	{
		this.method_244(2);
	}

	private void method_229(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewCmsPlan.CurrentCell != null)
			{
				string str = this.dataGridViewCmsPlan[0, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				᝘ _u1758 = this.method_245(str);
				if (ᜃ.ᜋ(this.string_20))
				{
					ᜃ.ᜁ(_u1758.ᜂ, this.string_20, ref this.string_23);
					this.method_115(string.Concat("【", _u1758.ᜄ, "】", this.string_23));
					this.method_240();
				}
				else
				{
					this.method_115("没有登录阿里妈妈！");
					this.bool_0 = false;
					this.method_7();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[QuitHiCms_Click]出错：", exception.ToString()));
		}
	}

	private void method_23()
	{
		try
		{
			this.dateTimePickerDlStt.MaxDate = DateTime.Now;
			DateTimePicker dateTimePicker = this.dateTimePickerDlStt;
			DateTime now = DateTime.Now;
			dateTimePicker.MinDate = now.AddDays(-90);
			this.dateTimePickerDlEnd.MaxDate = DateTime.Now;
			DateTimePicker dateTimePicker1 = this.dateTimePickerDlEnd;
			now = DateTime.Now;
			dateTimePicker1.MinDate = now.AddDays(-90);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[setDLAliOdrDateTimeePicker]出错，", exception.ToString()));
		}
	}

	private void method_230(object sender, EventArgs e)
	{
		this.dataGridViewCmsPlan.Visible = false;
	}

	public ᜥ method_231(string string_96)
	{
		ᜥ _ᜥ;
		try
		{
			foreach (ᜥ arrayList11 in this.arrayList_11)
			{
				if (!arrayList11.ᜁ.Equals(string_96))
				{
					continue;
				}
				_ᜥ = arrayList11;
				return _ᜥ;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getTaobaoQingFromList]出错：", exception.ToString()));
		}
		_ᜥ = null;
		return _ᜥ;
	}

	public ᝰ method_232(string string_96)
	{
		ᝰ _ᝰ;
		try
		{
			foreach (ᝰ arrayList12 in this.arrayList_12)
			{
				if (!arrayList12.ᜄ.Equals(string_96))
				{
					continue;
				}
				_ᝰ = arrayList12;
				return _ᝰ;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getTaobaoQingFromList]出错：", exception.ToString()));
		}
		_ᝰ = null;
		return _ᝰ;
	}

	public void method_233()
	{
		try
		{
			this.dataGridViewTaobaoQing.Rows.Clear();
			int num = 0;
			foreach (ᜥ arrayList11 in this.arrayList_11)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				this.dataGridViewTaobaoQing.Rows.Add(dataGridViewRow);
				this.dataGridViewTaobaoQing.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
				this.dataGridViewTaobaoQing[0, num].Value = arrayList11.ᜁ;
				this.dataGridViewTaobaoQing[0, num].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				this.dataGridViewTaobaoQing[1, num].Value = double.Parse(arrayList11.ᜂ);
				this.dataGridViewTaobaoQing[2, num].Value = Math.Round(arrayList11.ᜇ);
				this.dataGridViewTaobaoQing[3, num].Value = Math.Round(arrayList11.ᜅ);
				num++;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showTaobaoQingList]出错：", exception.ToString()));
		}
	}

	public void method_234()
	{
		try
		{
			this.dataGridViewTaobaoQiang.Rows.Clear();
			int num = 0;
			foreach (ᝰ arrayList12 in this.arrayList_12)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				this.dataGridViewTaobaoQiang.Rows.Add(dataGridViewRow);
				this.dataGridViewTaobaoQiang.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
				this.dataGridViewTaobaoQiang[0, num].Value = arrayList12.ᜄ;
				this.dataGridViewTaobaoQiang[0, num].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				this.dataGridViewTaobaoQiang[1, num].Value = arrayList12.ᜅ;
				this.dataGridViewTaobaoQiang[2, num].Value = double.Parse(arrayList12.ᜆ);
				this.dataGridViewTaobaoQiang[3, num].Value = this.method_235(arrayList12.ᜂ);
				this.dataGridViewTaobaoQiang[4, num].Value = Math.Round(arrayList12.ᜊ);
				this.dataGridViewTaobaoQiang[5, num].Value = Math.Round(arrayList12.ᜈ);
				num++;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showTaobaoQiangList]出错：", exception.ToString()));
		}
	}

	public string method_235(string string_96)
	{
		string str;
		try
		{
			str = string.Concat(string_96.Substring(6, 2), "日", string_96.Substring(8, 2), "点");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getTaobaoQiangStartTime]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	public void method_236()
	{
		try
		{
			foreach (ᜥ _ᜥ in this.method_238())
			{
				this.gclass10_0.method_12(_ᜥ, out this.string_23);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadTaobaoQing]出错：", exception.ToString()));
		}
	}

	public void method_237()
	{
		try
		{
			foreach (ᝰ _ᝰ in this.method_239())
			{
				this.gclass10_0.method_7(_ᝰ, out this.string_23);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadTaobaoQiang]出错：", exception.ToString()));
		}
	}

	public ArrayList method_238()
	{
		ArrayList arrayLists;
		try
		{
			ArrayList arrayLists1 = new ArrayList();
			StreamReader streamReader = new StreamReader(this.string_64, Encoding.GetEncoding("GB2312"));
			string str = null;
			while (true)
			{
				string str1 = streamReader.ReadLine();
				str = str1;
				if (str1 == null)
				{
					break;
				}
				if (!str.ToString().Equals(""))
				{
					ᜥ _ᜥ = new ᜥ();
					char[] chrArray = new char[] { '\t' };
					_ᜥ.ᜀ = str.Split(chrArray)[0];
					chrArray = new char[] { '\t' };
					_ᜥ.ᜁ = str.Split(chrArray)[1];
					chrArray = new char[] { '\t' };
					_ᜥ.ᜂ = str.Split(chrArray)[2];
					chrArray = new char[] { '\t' };
					_ᜥ.ᜃ = str.Split(chrArray)[3];
					chrArray = new char[] { '\t' };
					_ᜥ.ᜄ = int.Parse(str.Split(chrArray)[4]);
					chrArray = new char[] { '\t' };
					_ᜥ.ᜅ = double.Parse(str.Split(chrArray)[5]);
					chrArray = new char[] { '\t' };
					_ᜥ.ᜆ = str.Split(chrArray)[6];
					chrArray = new char[] { '\t' };
					_ᜥ.ᜇ = double.Parse(str.Split(chrArray)[7]);
					chrArray = new char[] { '\t' };
					_ᜥ.ᜈ = str.Split(chrArray)[8];
					arrayLists1.Add(_ᜥ);
				}
			}
			streamReader.Close();
			streamReader.Dispose();
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[readTaobaoQing]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	public ArrayList method_239()
	{
		ArrayList arrayLists;
		try
		{
			ArrayList arrayLists1 = new ArrayList();
			StreamReader streamReader = new StreamReader(this.string_65, Encoding.GetEncoding("GB2312"));
			string str = null;
			while (true)
			{
				string str1 = streamReader.ReadLine();
				str = str1;
				if (str1 == null)
				{
					break;
				}
				if (!str.ToString().Equals(""))
				{
					ᝰ _ᝰ = new ᝰ();
					char[] chrArray = new char[] { '\t' };
					_ᝰ.ᜀ = str.Split(chrArray)[0];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜁ = str.Split(chrArray)[1];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜂ = str.Split(chrArray)[2];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜃ = str.Split(chrArray)[3];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜄ = str.Split(chrArray)[4];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜅ = str.Split(chrArray)[5];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜆ = str.Split(chrArray)[6];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜇ = int.Parse(str.Split(chrArray)[7]);
					chrArray = new char[] { '\t' };
					_ᝰ.ᜈ = double.Parse(str.Split(chrArray)[8]);
					chrArray = new char[] { '\t' };
					_ᝰ.ᜉ = str.Split(chrArray)[9];
					chrArray = new char[] { '\t' };
					_ᝰ.ᜊ = double.Parse(str.Split(chrArray)[10]);
					chrArray = new char[] { '\t' };
					_ᝰ.ᜋ = str.Split(chrArray)[11];
					arrayLists1.Add(_ᝰ);
				}
			}
			streamReader.Close();
			streamReader.Dispose();
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[readTaobaoQiang]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	private void method_24()
	{
		try
		{
			this.dataGridViewQQGrp.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewQQGrp.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			this.dataGridViewQQGrp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewQQGrp.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "QQ群名称",
				Width = 120
			};
			this.dataGridViewQQGrp.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn green = new DataGridViewTextBoxColumn()
			{
				HeaderText = "排序",
				Width = 50,
				ReadOnly = true
			};
			green.DefaultCellStyle.ForeColor = Color.Green;
			green.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewQQGrp.Columns.Add(green);
			this.method_26();
			this.method_28();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initQQGrpGridView]出错，", exception.ToString()));
		}
	}

	public void method_240()
	{
		// 
		// Current member / type: System.Void AliBridgeForm::method_240()
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void method_240()
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private double method_241(string string_96, ᝘ u1758_0, string string_97, int int_28)
	{
		double u17580;
		try
		{
			if (!"通用计划".Equals(u1758_0.ᜄ))
			{
				try
				{
					ᜦ _ᜦ = ᜃ.ᜀ(this.string_20, string_96, u1758_0.ᜃ, u1758_0.ᜇ, u1758_0.ᜈ, int_28, ref this.string_23);
					u17580 = (double)float.Parse(_ᜦ.ᜈ);
					return u17580;
				}
				catch
				{
				}
				u17580 = u1758_0.ᜆ;
			}
			else
			{
				u17580 = double.Parse(string_97);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getActCms]出错：", exception.ToString()));
			u17580 = 0;
		}
		return u17580;
	}

	public void method_242()
	{
		try
		{
			if (!this.dataGridViewCmsPlan.InvokeRequired)
			{
				this.dataGridViewCmsPlan.Rows.Clear();
			}
			else
			{
				AliBridgeForm.GDelegate80 gDelegate80 = new AliBridgeForm.GDelegate80(this.method_242);
				base.BeginInvoke(gDelegate80, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[clearShowCmsList]出错：", exception.ToString()));
		}
	}

	public void method_243(᝘ u1758_0)
	{
		Point location;
		try
		{
			if (!this.dataGridViewCmsPlan.InvokeRequired)
			{
				this.dataGridViewCmsPlan.Visible = true;
				int count = 20 + this.arrayList_14.Count * 24;
				if (this.int_20 == 1)
				{
					this.tabPageBridge.Controls.Add(this.dataGridViewCmsPlan);
					this.tabPageBridge.Controls.SetChildIndex(this.dataGridViewCmsPlan, 0);
					DataGridView point = this.dataGridViewCmsPlan;
					int x = this.dataGridViewBrdg.Location.X;
					location = this.dataGridViewBrdg.Location;
					point.Location = new Point(x, location.Y + this.dataGridViewBrdg.Height - count - 10);
					this.dataGridViewCmsPlan.Width = 600;
				}
				else if (this.int_20 == 2)
				{
					this.groupBoxTaobaoQing.Controls.Add(this.dataGridViewCmsPlan);
					this.groupBoxTaobaoQing.Controls.SetChildIndex(this.dataGridViewCmsPlan, 0);
					DataGridView dataGridView = this.dataGridViewCmsPlan;
					int num = this.dataGridViewTaobaoQing.Location.X;
					location = this.dataGridViewTaobaoQing.Location;
					dataGridView.Location = new Point(num, location.Y + this.dataGridViewTaobaoQing.Height - count - 10);
					this.dataGridViewCmsPlan.Width = 556;
				}
				else if (this.int_20 == 3)
				{
					this.groupBoxTaobaoQiang.Controls.Add(this.dataGridViewCmsPlan);
					this.groupBoxTaobaoQiang.Controls.SetChildIndex(this.dataGridViewCmsPlan, 0);
					DataGridView point1 = this.dataGridViewCmsPlan;
					int x1 = this.dataGridViewTaobaoQiang.Location.X;
					location = this.dataGridViewTaobaoQiang.Location;
					point1.Location = new Point(x1, location.Y + this.dataGridViewTaobaoQiang.Height - count - 10);
					this.dataGridViewCmsPlan.Width = 600;
				}
				else if (this.int_20 == 4)
				{
					this.tabPageOnline.Controls.Add(this.dataGridViewCmsPlan);
					this.tabPageOnline.Controls.SetChildIndex(this.dataGridViewCmsPlan, 0);
					DataGridView dataGridView1 = this.dataGridViewCmsPlan;
					int num1 = this.dataGridViewOnlineBrdg.Location.X;
					location = this.dataGridViewOnlineBrdg.Location;
					dataGridView1.Location = new Point(num1, location.Y + this.dataGridViewOnlineBrdg.Height - count - 10);
					this.dataGridViewCmsPlan.Width = 600;
				}
				this.dataGridViewCmsPlan.Height = count;
				int u17580 = this.dataGridViewCmsPlan.Rows.Count;
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				this.dataGridViewCmsPlan.Rows.Add(dataGridViewRow);
				this.dataGridViewCmsPlan.Rows[u17580].HeaderCell.Value = string.Concat(u17580 + 1, "");
				this.dataGridViewCmsPlan[0, u17580].Value = u1758_0.ᜄ;
				if ((u1758_0.ᜍ == null || "".Equals(u1758_0.ᜍ.Trim()) ? false : !"通用计划".Equals(u1758_0.ᜍ.Trim())))
				{
					this.dataGridViewCmsPlan[0, u17580].ToolTipText = string.Concat("计划说明：【", GClass13.smethod_24(u1758_0.ᜍ), "】");
					this.dataGridViewCmsPlan[0, u17580].Style.BackColor = Color.Yellow;
				}
				this.dataGridViewCmsPlan[0, u17580].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				this.dataGridViewCmsPlan[1, u17580].Value = GClass13.smethod_11(u1758_0.ᜅ);
				this.dataGridViewCmsPlan[2, u17580].Value = GClass13.smethod_12(u1758_0.ᜋ);
				if ((!"1".Equals(u1758_0.ᜋ) ? false : !"通用计划".Equals(u1758_0.ᜄ)))
				{
					this.dataGridViewCmsPlan[2, u17580].Style.ForeColor = Color.Green;
				}
				this.dataGridViewCmsPlan[3, u17580].Value = GClass13.smethod_13(u1758_0.ᜊ);
				this.dataGridViewCmsPlan[3, u17580].Style.ForeColor = GClass13.smethod_14(u1758_0.ᜊ);
				if ("3".Equals(u1758_0.ᜊ))
				{
					this.dataGridViewCmsPlan[3, u17580].ToolTipText = string.Concat("拒绝理由：【", u1758_0.ᜌ, "】");
					this.dataGridViewCmsPlan[3, u17580].Style.BackColor = Color.Yellow;
				}
				this.dataGridViewCmsPlan[4, u17580].Value = string.Concat(Math.Round(u1758_0.ᜁ, 2), "%");
				if ("通用计划".Equals(u1758_0.ᜄ))
				{
					this.dataGridViewCmsPlan[5, u17580].Value = "推广";
					this.dataGridViewCmsPlan[5, u17580].Style.ForeColor = Color.Red;
					this.dataGridViewCmsPlan[5, u17580].Tag = u1758_0.ᜃ;
				}
				else if ("".Equals(u1758_0.ᜊ))
				{
					this.dataGridViewCmsPlan[5, u17580].Value = "申请";
					this.dataGridViewCmsPlan[5, u17580].Tag = u1758_0.ᜃ;
				}
				else if (!("1".Equals(u1758_0.ᜊ) ? false : !"2".Equals(u1758_0.ᜊ)))
				{
					this.dataGridViewCmsPlan[5, u17580].Value = "退出";
					this.dataGridViewCmsPlan[5, u17580].Tag = u1758_0.ᜃ;
				}
				else if (!"5".Equals(u1758_0.ᜊ))
				{
					this.dataGridViewCmsPlan.Rows[u17580].Cells[5].ReadOnly = true;
					DataGridViewCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
					dataGridViewTextBoxCell.Style.BackColor = Color.Wheat;
					dataGridViewTextBoxCell.Value = false;
					dataGridViewTextBoxCell.Style.BackColor = Color.White;
					this.dataGridViewCmsPlan.Rows[u17580].Cells[5] = dataGridViewTextBoxCell;
					this.dataGridViewCmsPlan.Rows[u17580].Cells[5].Style.ForeColor = Color.White;
					this.dataGridViewCmsPlan.Rows[u17580].Cells[5].Style.SelectionBackColor = Color.White;
					this.dataGridViewCmsPlan.Rows[u17580].Cells[5].Style.SelectionForeColor = Color.White;
					this.dataGridViewCmsPlan[5, u17580].Tag = u1758_0.ᜃ;
				}
				else
				{
					this.dataGridViewCmsPlan[5, u17580].Value = "申请";
					this.dataGridViewCmsPlan[5, u17580].Tag = u1758_0.ᜃ;
				}
				if (this.dataGridViewCmsPlan.Rows.Count > 0)
				{
					this.dataGridViewCmsPlan.Rows[0].Selected = false;
				}
			}
			else
			{
				AliBridgeForm.GDelegate81 gDelegate81 = new AliBridgeForm.GDelegate81(this.method_243);
				object[] objArray = new object[] { u1758_0 };
				base.BeginInvoke(gDelegate81, objArray);
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.bool_26 = false;
			this.method_115(string.Concat("[showCmsList]出错了！", exception.ToString()));
		}
	}

	private void method_244(int int_28)
	{
		try
		{
			if (this.dataGridViewCmsPlan.CurrentCell != null)
			{
				string str = this.dataGridViewCmsPlan[0, this.dataGridViewCmsPlan.CurrentCell.RowIndex].Value.ToString();
				᝘ _u1758 = this.method_245(str);
				if ((this.dataGridViewCmsPlan.CurrentCell.ColumnIndex == 0 ? true : int_28 == 2))
				{
					string[] strArrays = new string[] { "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.aMV6Mc#!/promo/self/campaign?campaignId=", _u1758.ᜃ, "&shopkeeperId=", _u1758.ᜇ, "&userNumberId=", _u1758.ᜈ };
					Process.Start(string.Concat(strArrays));
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[openCmsPlan]出错了！", exception.ToString()));
		}
	}

	public ᝘ method_245(string string_96)
	{
		᝘ _u1758;
		try
		{
			foreach (᝘ arrayList14 in this.arrayList_14)
			{
				if (!arrayList14.ᜄ.Equals(string_96))
				{
					continue;
				}
				_u1758 = arrayList14;
				return _u1758;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getCmsPlanFromList]出错：", exception.ToString()));
		}
		_u1758 = null;
		return _u1758;
	}

	public void method_246()
	{
		DateTime now;
		object[] hours;
		try
		{
			if (!this.checkBoxLoadDataNow.Checked)
			{
				now = DateTime.Now.AddDays(1);
				DateTime dateTime = DateTime.ParseExact(string.Concat(now.ToString("yyyyMMdd"), "010000"), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
				TimeSpan timeSpan = dateTime - DateTime.Now;
				hours = new object[] { "离上传数据还有【", timeSpan.Hours, "】时【", timeSpan.Minutes, "】分【", timeSpan.Seconds, "】秒" };
				this.method_115(string.Concat(hours));
				int num = timeSpan.Hours * 60 * 60 + timeSpan.Minutes * 60 + timeSpan.Seconds;
				Thread.Sleep(num * 1000);
			}
			this.method_115("开始删除失效的鹊桥！");
			int num1 = this.method_92();
			this.method_115(string.Concat("删除失效的鹊桥成功！共删除【", num1, "】个过期鹊桥"));
			if (num1 != 0)
			{
				this.method_91();
			}
			string string0 = GClass9.string_0;
			now = DateTime.Now.AddDays(-1);
			now.ToString("yyyyMMddHHmmss");
			if (File.Exists(string.Concat(this.string_41, "\\bridgeitem.txt")))
			{
				File.Delete(string.Concat(this.string_41, "\\bridgeitem.txt"));
			}
			if (File.Exists(string.Concat(this.string_41, "\\alibridge.txt")))
			{
				File.Delete(string.Concat(this.string_41, "\\alibridge.txt"));
			}
			FileStream fileStream = new FileStream(string.Concat(this.string_41, "\\bridgeitem.txt"), FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
			FileStream fileStream1 = new FileStream(string.Concat(this.string_41, "\\alibridge.txt"), FileMode.Create);
			StreamWriter streamWriter1 = new StreamWriter(fileStream1, Encoding.UTF8);
			now = DateTime.Now;
			string str = string.Concat("select * from bridgeinfo where startTime<=", now.ToString("yyyyMMdd"));
			ArrayList arrayLists = this.gclass1_0.method_11(str, out this.string_23);
			Hashtable hashtables = new Hashtable();
			foreach (ᜉ _ᜉ in arrayLists)
			{
				hashtables.Add(_ᜉ.ᜁ, _ᜉ);
			}
			now = DateTime.Now;
			string str1 = string.Concat("select distinct itemId from bridgeitem where actCmsRate>=10 and startTime<=", now.ToString("yyyyMMdd"));
			ArrayList arrayLists1 = this.gclass1_0.method_7(str1, out this.string_23);
			this.method_115(string.Concat("共【", arrayLists1.Count, "】个产品！"));
			for (int i = 0; i < arrayLists1.Count; i++)
			{
				ᜑ item = (ᜑ)arrayLists1[i];
				GClass1 gclass10 = this.gclass1_0;
				string str2 = item.ᜂ;
				now = DateTime.Now;
				ArrayList arrayLists2 = gclass10.method_4(str2, string.Concat(" and startTime<=", now.ToString("yyyyMMdd"), " order by actCmsRate desc "), out this.string_23);
				if (i % 100 == 99)
				{
					hours = new object[] { "【", i + 1, "/", arrayLists1.Count, "】个产品！" };
					this.method_115(string.Concat(hours));
				}
				bool flag = false;
				for (int j = 0; j < arrayLists2.Count; j++)
				{
					ᜑ _ᜑ = (ᜑ)arrayLists2[j];
					if (hashtables[_ᜑ.ᜁ] != null)
					{
						if (!flag)
						{
							GClass12 gClass12 = this.method_248(_ᜑ.ᜁ, _ᜑ.ᜂ);
							if (gClass12 != null)
							{
								flag = true;
								hours = new object[] { _ᜑ.ᜂ, "\t", _ᜑ.ᜃ, "\t", _ᜑ.ᜌ, "\t", _ᜑ.ᜉ, "\t", _ᜑ.ᜍ, "\t", _ᜑ.ᜁ, "\t", _ᜑ.ᜇ, "\t", _ᜑ.ᜎ, "\t", this.method_249(((ᜉ)hashtables[_ᜑ.ᜁ]).ᜃ), "\t", gClass12.string_4.Replace(GClass13.string_4, "") };
								streamWriter.WriteLine(string.Concat(hours));
							}
							if (i % 100 == 1)
							{
								streamWriter.Flush();
							}
						}
						hours = new object[] { _ᜑ.ᜁ, "\t", _ᜑ.ᜂ, "\t", _ᜑ.ᜇ, "\t", _ᜑ.ᜎ, "\t", this.method_249(((ᜉ)hashtables[_ᜑ.ᜁ]).ᜃ) };
						streamWriter1.WriteLine(string.Concat(hours));
						if (i % 100 == 1)
						{
							streamWriter1.Flush();
						}
					}
				}
			}
			streamWriter.Flush();
			streamWriter.Close();
			streamWriter.Dispose();
			fileStream.Close();
			fileStream.Dispose();
			streamWriter1.Flush();
			streamWriter1.Close();
			streamWriter1.Dispose();
			fileStream1.Close();
			fileStream1.Dispose();
			this.method_115("导出完成！启动上传程序！");
			GClass9.string_0 = string0;
			Process.Start(string.Concat(this.string_41, "\\自动上传数据\\鹊桥助手辅助工具.exe"));
			this.method_247();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadData]出错：", exception.ToString()));
		}
	}

	public void method_247()
	{
		try
		{
			if (!this.buttonSaveToSvr.InvokeRequired)
			{
				this.buttonSaveToSvr.Enabled = true;
				this.buttonSaveToSvr.Text = "保存到服务器";
			}
			else
			{
				AliBridgeForm.GDelegate82 gDelegate82 = new AliBridgeForm.GDelegate82(this.method_247);
				base.BeginInvoke(gDelegate82, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[EnUpData]出错：", exception.ToString()));
		}
	}

	private GClass12 method_248(string string_96, string string_97)
	{
		GClass12 gclass120;
		try
		{
			if ((this.gclass12_0 == null || !this.gclass12_0.string_0.Equals(string_96) ? true : !this.gclass12_0.string_1.Equals(string_97)))
			{
				ArrayList arrayLists = this.class1_0.method_4(string_96, string_97, out this.string_23);
				if (arrayLists.Count <= 0)
				{
					this.gclass12_0 = GClass9.smethod_1(string_96, string_97);
					if (this.gclass12_0 == null)
					{
						string string0 = GClass9.string_0;
						string str = string.Concat(this.string_41, "\\config\\鹊桥数据\\");
						string[] directories = Directory.GetDirectories(str);
						int num = 0;
						while (num < (int)directories.Length)
						{
							string str1 = directories[num];
							GClass9.string_0 = str1.Substring(str1.LastIndexOf("\\") + 1);
							this.gclass12_0 = GClass9.smethod_1(string_96, string_97);
							if (this.gclass12_0 != null)
							{
								string[] strArrays = new string[] { "切换PID成功，旧【", string0, "】 -> 新【", GClass9.string_0, "】" };
								this.method_115(string.Concat(strArrays));
								goto Label0;
							}
							else
							{
								num++;
							}
						}
					}
				}
				else
				{
					this.gclass12_0 = (GClass12)arrayLists[0];
				}
			}
		Label0:
			gclass120 = this.gclass12_0;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getUrlItemForUpload]出错：", exception.ToString()));
			gclass120 = null;
		}
		return gclass120;
	}

	private string method_249(int int_28)
	{
		string str;
		try
		{
			string str1 = string.Concat(int_28, "");
			str = str1.Substring(2, 6);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[gST]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private void method_25()
	{
		try
		{
			this.dataGridViewHotShare.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewHotShare.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			this.dataGridViewHotShare.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewHotShare.TopLeftHeaderCell.Value = "序号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "爆款标题",
				Width = 208
			};
			this.dataGridViewHotShare.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "价格",
				Width = 40
			};
			this.dataGridViewHotShare.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "佣金",
				Width = 40
			};
			this.dataGridViewHotShare.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "分享时间",
				Width = 95
			};
			this.dataGridViewHotShare.Columns.Add(dataGridViewTextBoxColumn3);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initHotShareGridView]出错，", exception.ToString()));
		}
	}

	private void method_250()
	{
		try
		{
			try
			{
				if (((int)Process.GetProcessesByName("QQPlus").Length != 0 ? true : (int)Process.GetProcessesByName("Coco").Length != 0))
				{
					bool flag = false;
					int num = 1;
					while (true)
					{
						if (num >= 100)
						{
							break;
						}
						else if (AliBridgeForm.FindWindow(null, string.Concat("QQ群智能机器人V", num)) != IntPtr.Zero)
						{
							flag = true;
							break;
						}
						else
						{
							num++;
						}
					}
					if (!flag)
					{
						try
						{
							Process.GetProcessesByName("Coco")[0].Kill();
						}
						catch
						{
						}
						try
						{
							Process.GetProcessesByName("QQPlus")[0].Kill();
						}
						catch
						{
						}
						Thread.Sleep(3000);
						Process.Start(this.textBoxQQPlusPath.Text);
						Thread.Sleep(30000);
					}
				}
				else
				{
					Process.Start(this.textBoxQQPlusPath.Text);
					Thread.Sleep(30000);
				}
			}
			catch (Exception exception)
			{
				this.method_115(string.Concat("[checkQQPlusFollowProcess]出错1：", exception.ToString()));
			}
		}
		catch (Exception exception2)
		{
			Exception exception1 = exception2;
			if (!exception1.ToString().Contains("System.Threading.ThreadAbortException"))
			{
				this.method_115(string.Concat("[checkQQPlusFollowProcess]出错2：", exception1.ToString()));
			}
		}
	}

	private void method_251()
	{
		object[] string0;
		try
		{
			while (true)
			{
				try
				{
					if (this.dataGridViewFollowSnd.Rows.Count <= 0)
					{
						Thread.Sleep(1000);
					}
					else
					{
						for (int i = 0; i < this.dataGridViewFollowSnd.Rows.Count; i++)
						{
							try
							{
								if (!"失败".Equals(this.dataGridViewFollowSnd[2, i].Value))
								{
									GClass23 tag = (GClass23)this.dataGridViewFollowSnd[0, i].Tag;
									if (this.checkBoxNoLnkNoFw.Checked)
									{
										if ((tag.string_1.Contains("http://") ? false : !tag.string_1.Contains("https://")))
										{
											this.method_115(string.Concat("跟发【", tag.string_0, "】没有链接不跟发，跳过！"));
											᝚.ᜁ(string.Concat(this.string_68, "\\", tag.string_0, "\\2.txt"), "");
											this.method_263(tag.string_0);
											Thread.Sleep(2000);
											goto Label1;
										}
									}
									int num = this.method_252(tag);
									if (num == 0)
									{
										Thread.Sleep(this.int_21);
										break;
									}
									else if (num == 1)
									{
										Thread.Sleep(1000);
										break;
									}
									else if (num == 2)
									{
										string0 = new object[] { "跟发【", tag.string_0, "】产品ID【", this.string_70, "】距离上次发送不足【", this.int_23, "】小时，跳过！" };
										this.method_115(string.Concat(string0));
										᝚.ᜁ(string.Concat(this.string_68, "\\", tag.string_0, "\\2.txt"), "");
										this.method_263(tag.string_0);
										Thread.Sleep(2000);
										break;
									}
									else if (num != 3)
									{
										return;
									}
									else
									{
										string0 = new object[] { "跟发【", tag.string_0, "】产品ID【", this.string_70, "】佣金比例【", this.float_4, "】<最低佣金比例【", this.float_1, "】，跳过！" };
										this.method_115(string.Concat(string0));
										᝚.ᜁ(string.Concat(this.string_68, "\\", tag.string_0, "\\2.txt"), "");
										this.method_263(tag.string_0);
										Thread.Sleep(2000);
										break;
									}
								}
							}
							catch (Exception exception)
							{
								this.method_115(string.Concat("跟发中出点问题ex2，", exception.ToString()));
								this.method_264();
								break;
							}
						Label1:
						}
					}
				}
				catch (Exception exception2)
				{
					Exception exception1 = exception2;
					if (!exception1.ToString().Contains("System.Threading.ThreadAbortException"))
					{
						this.method_115(string.Concat("跟发中出点问题ex1，", exception1.ToString()));
						this.method_264();
					}
				}
			}
		}
		catch (Exception exception4)
		{
			Exception exception3 = exception4;
			if (!exception3.ToString().Contains("System.Threading.ThreadAbortException"))
			{
				this.method_115(string.Concat("[followSend]出错：", exception3.ToString()));
			}
		}
	}

	public int method_252(GClass23 gclass23_0)
	{
		int num;
		if (!this.checkBoxChgFwSndPid.Checked)
		{
			this.string_48 = gclass23_0.string_1;
		}
		else
		{
			this.string_70 = "";
			this.string_48 = this.method_257(gclass23_0.string_1);
			if (this.string_48 == null)
			{
				this.method_263(gclass23_0.string_0);
				᝚.ᜁ(string.Concat(this.string_68, "\\", gclass23_0.string_0, "\\2.txt"), "");
				num = 0;
				return num;
			}
			else if ("notlogin".Equals(this.string_48))
			{
				this.method_260(1, true);
				this.method_260(2, false);
				num = -1;
				return num;
			}
			else if (!"lowestcms".Equals(this.string_48))
			{
				if (!this.method_253(this.string_70))
				{
					num = 2;
					return num;
				}
				if (!"".Equals(this.string_70))
				{
					this.method_254(this.string_70);
				}
			}
			else
			{
				num = 3;
				return num;
			}
		}
		this.bool_34 = this.method_135(᜸.ᜄ(gclass23_0.string_1.Replace("<", " <").Replace(">", "> ")).Replace("&nbsp;", " "));
		if (this.bool_34)
		{
			try
			{
				᝕ _u1755 = ᜤ.ᜅ(this.string_83);
				this.float_3 = (float)_u1755.ᜀ;
				if (_u1755.ᜁ >= this.int_22)
				{
					this.method_115(string.Concat("优惠券数量提醒！******", _u1755.ᜄ(), "******"));
				}
				else
				{
					this.method_115(string.Concat("优惠券数量不够，跳过发送！******", _u1755.ᜄ(), "******"));
					᝚.ᜁ(string.Concat(this.string_68, "\\", gclass23_0.string_0, "\\2.txt"), "");
					this.method_263(gclass23_0.string_0);
					num = 1;
					return num;
				}
			}
			catch
			{
				this.method_115("没有查出来优惠券数量，但是继续发送！");
			}
		}
		if (this.bool_27)
		{
			this.method_130();
		}
		if (this.bool_15)
		{
			this.method_132(1);
		}
		if (this.bool_13)
		{
			this.string_47 = this.method_129();
			this.string_48 = string.Concat(this.string_48, "<BR>点击进入双12主会场抢红包：", this.string_47);
		}
		this.int_11 = 0;
		this.bool_20 = false;
		if (!this.bool_32)
		{
			this.method_148();
		}
		else
		{
			this.method_150();
		}
		᝚.ᜁ(string.Concat(this.string_68, "\\", gclass23_0.string_0, "\\1.txt"), "");
		this.method_263(gclass23_0.string_0);
		num = 0;
		return num;
	}

	public bool method_253(string string_96)
	{
		bool flag;
		if (!"".Equals(string_96))
		{
			foreach (GClass28 arrayList15 in this.arrayList_15)
			{
				if (!arrayList15.string_0.Equals(string_96))
				{
					continue;
				}
				DateTime dateTime = DateTime.ParseExact(arrayList15.string_1, "yyyyMMddHHmmss", CultureInfo.CurrentCulture);
				if ((DateTime.Now - dateTime).TotalMinutes >= (double)(this.int_23 * 60))
				{
					continue;
				}
				flag = false;
				return flag;
			}
			flag = true;
		}
		else
		{
			flag = true;
		}
		return flag;
	}

	public void method_254(string string_96)
	{
		int i;
		GClass28 gClass28 = new GClass28()
		{
			string_0 = string_96,
			string_1 = DateTime.Now.ToString("yyyyMMddHHmmss")
		};
		this.arrayList_15.Add(gClass28);
		bool flag = false;
		for (i = 0; i < this.arrayList_15.Count; i++)
		{
			if (!((GClass28)this.arrayList_15[i]).string_1.StartsWith(DateTime.Now.ToString("yyyyMMdd")))
			{
				this.arrayList_15.RemoveAt(i);
				flag = true;
				i--;
			}
		}
		if (flag)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (i = 0; i < this.arrayList_15.Count; i++)
			{
				GClass28 item = (GClass28)this.arrayList_15[i];
				stringBuilder.Append(string.Concat(item.string_0, "\t", item.string_1, "\n"));
			}
			᝚.ᜁ(this.string_69, stringBuilder.ToString());
		}
		else
		{
			᝚.ᜀ(this.string_69, string.Concat(gClass28.string_0, "\t", gClass28.string_1, "\n"));
		}
	}

	public void method_255()
	{
		this.arrayList_15 = new ArrayList();
		this.string_69 = string.Concat(this.string_41, "\\config\\临时文件夹\\dupfwfile.txt");
		string str = ᝚.ᜀ(this.string_69);
		char[] chrArray = new char[] { '\n' };
		string[] strArrays = str.Split(chrArray);
		for (int i = 0; i < (int)strArrays.Length; i++)
		{
			string str1 = strArrays[i];
			if (!str1.Trim().Equals(""))
			{
				chrArray = new char[] { '\t' };
				string[] strArrays1 = str1.Split(chrArray);
				GClass28 gClass28 = new GClass28()
				{
					string_0 = strArrays1[0],
					string_1 = strArrays1[1]
				};
				this.arrayList_15.Add(gClass28);
			}
		}
	}

	public void method_256()
	{
	}

	private string method_257(string string_96)
	{
		string string81;
		ArrayList arrayLists;
		bool flag;
		try
		{
			int num = 0;
			while (!ᜃ.ᜀ(this.string_20, ref this.bool_28))
			{
				if (this.bool_28)
				{
					this.method_115("阿里妈妈显示请求频繁，等待30秒再试！");
					Thread.Sleep(30000);
				}
				else if (num >= 30)
				{
					this.method_115("登录阿里妈妈失败！");
					string81 = "notlogin";
					return string81;
				}
				else
				{
					num++;
					this.method_8(true);
					Thread.Sleep(20000);
				}
			}
			string_96 = ᝛.ᜀ(string_96);
			string_96 = ᝛.ᜂ(string_96);
			string str = this.method_307(string_96);
			if (str != null)
			{
				string_96 = str;
				this.string_80 = ᜸.ᜄ(string_96.Replace("<", " <").Replace(">", "> ")).Replace("&nbsp;", " ");
				this.string_81 = string_96;
				this.string_49 = this.string_81;
				this.arrayList_5 = new ArrayList();
				this.bool_34 = false;
				this.string_83 = "";
				int num1 = 0;
				arrayLists = null;
				while (true)
				{
					ArrayList arrayLists1 = this.method_324(this.string_80);
					arrayLists = arrayLists1;
					if (arrayLists1 != null)
					{
						goto Label1;
					}
					if (num1 >= 3)
					{
						break;
					}
					this.method_115(string.Concat("PID转换第【", num1 + 1, "】次失败，正在重试！"));
					Thread.Sleep(1000);
					num1++;
				}
				this.method_115("PID转换失败【3】次，跳过！");
				string81 = null;
			}
			else
			{
				string81 = null;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[changeFollowSndPid]出错：", exception.ToString()));
			string81 = null;
		}
		return string81;
	Label1:
		flag = (this.float_1 <= this.float_4 ? true : "".Equals(this.string_70));
		if (flag)
		{
			this.int_26 = this.method_325(arrayLists);
			this.string_81 = this.string_81.Replace("￥", "$");
			GClass30 gClass30 = null;
			this.bool_5 = false;
			if ((this.bool_3 ? false : !this.bool_6))
			{
				this.string_81 = this.method_317(arrayLists);
			}
			else
			{
				gClass30 = this.method_140(this.string_81);
				if (this.bool_6)
				{
					this.method_311(gClass30, arrayLists, this.int_26);
				}
				else if (!this.bool_5)
				{
					this.string_81 = this.method_317(arrayLists);
				}
				else
				{
					this.string_81 = gClass30.string_1.Replace("{couponItemUrl}", string.Concat("【领券下单地址】", this.method_315(gClass30)));
					if ((this.bool_32 || !this.bool_4 ? false : this.int_26 == 4))
					{
						this.string_81 = string.Concat(this.string_81, "<BR>复制这条消息，", gClass30.᜞_0.ᜀ, "，打开【手机淘宝】即可领券并下单");
					}
				}
			}
			string81 = this.string_81;
			return string81;
		}
		else
		{
			string81 = "lowestcms";
			return string81;
		}
	}

	private string method_258(string string_96)
	{
		string str;
		try
		{
			StreamReader streamReader = new StreamReader(string_96, Encoding.GetEncoding("GB2312"));
			string end = streamReader.ReadToEnd();
			streamReader.Close();
			streamReader.Dispose();
			str = end;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadFollowSendContent]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private void method_259()
	{
		try
		{
			if (!Directory.Exists(this.string_68))
			{
				Directory.CreateDirectory(this.string_68);
			}
			while (true)
			{
				ArrayList arrayLists = new ArrayList();
				try
				{
					ArrayList arrayLists1 = new ArrayList(Directory.GetDirectories(this.string_68));
					arrayLists1.Sort();
					foreach (string arrayList in arrayLists1)
					{
						string str = arrayList.Substring(arrayList.LastIndexOf("\\") + 1);
						if (str.StartsWith(DateTime.Now.ToString("yyyyMMdd")))
						{
							if (!File.Exists(string.Concat(arrayList, "\\0.txt")) || File.Exists(string.Concat(arrayList, "\\1.txt")) || File.Exists(string.Concat(arrayList, "\\2.txt")))
							{
								continue;
							}
							bool flag = false;
							IEnumerator enumerator = this.method_262().GetEnumerator();
							try
							{
								while (true)
								{
									if (!enumerator.MoveNext())
									{
										break;
									}
									else if (((GClass23)enumerator.Current).string_0.Equals(str))
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
							if (flag)
							{
								continue;
							}
							string str1 = this.method_258(string.Concat(arrayList, "\\content.html"));
							if ((!str1.Contains("setTimeout") ? true : !str1.Contains("XMLHttpRequest")))
							{
								GClass23 gClass23 = new GClass23()
								{
									string_0 = str,
									string_1 = str1
								};
								if (File.Exists(string.Concat(arrayList, "\\1.txt")))
								{
									gClass23.string_2 = "1";
								}
								if (!File.Exists(string.Concat(arrayList, "\\2.txt")))
								{
									gClass23.string_2 = "0";
								}
								else
								{
									gClass23.string_2 = "2";
								}
								if (!File.Exists(string.Concat(arrayList, "\\5.txt")))
								{
									gClass23.int_0 = 0;
								}
								else
								{
									gClass23.int_0 = 1;
								}
								arrayLists.Add(gClass23);
							}
							else
							{
								this.method_115("此跟发内容有乱码，跳过！");
								᝚.ᜁ(string.Concat(this.string_68, "\\", str, "\\2.txt"), "");
								Thread.Sleep(100);
							}
						}
						else
						{
							Directory.Delete(arrayList, true);
						}
					}
				}
				catch
				{
				}
				this.method_261(arrayLists);
				Thread.Sleep(1000);
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if (!exception.ToString().Contains("System.Threading.ThreadAbortException"))
			{
				this.method_115(string.Concat("[loadFollowSnd]出错：", exception.ToString()));
			}
		}
	}

	private void method_26()
	{
		string arrayList;
		bool flag;
		IEnumerator enumerator;
		string current;
		IDisposable disposable;
		try
		{
			this.arrayList_4 = new ArrayList();
			this.method_27();
			this.dataGridViewQQGrp.Rows.Clear();
			string[] files = Directory.GetFiles(this.string_51);
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
			for (int j = this.arrayList_4.Count - 1; j >= 0; j--)
			{
				string item = (string)this.arrayList_4[j];
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
					this.arrayList_4.RemoveAt(j);
				}
			}
			foreach (string arrayList in arrayLists)
			{
				flag = false;
				IEnumerator enumerator1 = this.arrayList_4.GetEnumerator();
				try
				{
					while (true)
					{
						if (enumerator1.MoveNext())
						{
							current = (string)enumerator1.Current;
							if (arrayList.Equals(current))
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
				this.arrayList_4.Add(arrayList);
			}
			int num = 0;
			foreach (string arrayList4 in this.arrayList_4)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				this.dataGridViewQQGrp.Rows.Add(dataGridViewRow);
				this.dataGridViewQQGrp.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
				this.dataGridViewQQGrp[0, num].Value = arrayList4;
				this.dataGridViewQQGrp[1, num].Value = "  ↑↓";
				num++;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadQQGrpList]出错：", exception.ToString()));
		}
	}

	public void method_260(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate83 gDelegate83;
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
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonFollowSndStop.InvokeRequired)
				{
					this.buttonFollowSndStop.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.textBoxNotFwHour.InvokeRequired)
				{
					this.textBoxNotFwHour.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 4)
			{
				if (!this.checkBoxChgFwSndPid.InvokeRequired)
				{
					this.checkBoxChgFwSndPid.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 5)
			{
				if (!this.checkBoxNoLnkNoFw.InvokeRequired)
				{
					this.checkBoxNoLnkNoFw.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 6)
			{
				if (!this.checkBoxQQGrpFw.InvokeRequired)
				{
					this.checkBoxQQGrpFw.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 7)
			{
				if (!this.textBoxFwCouponLwNum.InvokeRequired)
				{
					this.textBoxFwCouponLwNum.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 8)
			{
				if (!this.textBoxFollowSndInteval.InvokeRequired)
				{
					this.textBoxFollowSndInteval.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
			else if (int_28 == 9)
			{
				if (!this.textBoxLowestFwCms.InvokeRequired)
				{
					this.textBoxLowestFwCms.Enabled = bool_40;
				}
				else
				{
					gDelegate83 = new AliBridgeForm.GDelegate83(this.method_260);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate83, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[FollowSendBtnCtl]出错：", exception.ToString()));
		}
	}

	public void method_261(ArrayList arrayList_26)
	{
		try
		{
			if (!this.dataGridViewFollowSnd.InvokeRequired)
			{
				int count = this.dataGridViewFollowSnd.Rows.Count;
				foreach (GClass23 arrayList26 in arrayList_26)
				{
					bool flag = false;
					IEnumerator enumerator = ((IEnumerable)this.dataGridViewFollowSnd.Rows).GetEnumerator();
					try
					{
						while (true)
						{
							if (enumerator.MoveNext())
							{
								DataGridViewRow current = (DataGridViewRow)enumerator.Current;
								if (arrayList26.string_0.Equals(current.Cells[0].Value.ToString()))
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
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					if (flag)
					{
						continue;
					}
					int string0 = 0;
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					if (arrayList26.int_0 != 1)
					{
						this.dataGridViewFollowSnd.Rows.Add(dataGridViewRow);
						string0 = count;
					}
					else
					{
						this.dataGridViewFollowSnd.Rows.Insert(0, dataGridViewRow);
						string0 = 0;
					}
					this.dataGridViewFollowSnd.Rows[string0].HeaderCell.Value = string.Concat(string0 + 1, "");
					this.dataGridViewFollowSnd[0, string0].Value = arrayList26.string_0;
					this.dataGridViewFollowSnd[1, string0].Value = ᜸.ᜄ(arrayList26.string_1);
					this.dataGridViewFollowSnd[2, string0].Value = GClass13.smethod_15(arrayList26.string_2);
					this.dataGridViewFollowSnd[2, string0].Style.ForeColor = GClass13.smethod_16(arrayList26.string_2);
					this.dataGridViewFollowSnd[0, string0].Tag = arrayList26;
					count++;
				}
				for (int i = 0; i < this.dataGridViewFollowSnd.Rows.Count; i++)
				{
					this.dataGridViewFollowSnd.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
				}
			}
			else
			{
				AliBridgeForm.GDelegate84 gDelegate84 = new AliBridgeForm.GDelegate84(this.method_261);
				object[] objArray = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate84, objArray);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[addDataGridViewFollowSnd]出错了！只是小错，吓吓你们的：", exception.ToString()));
		}
	}

	public ArrayList method_262()
	{
		ArrayList arrayLists = new ArrayList();
		foreach (DataGridViewRow row in (IEnumerable)this.dataGridViewFollowSnd.Rows)
		{
			arrayLists.Add((GClass23)row.Cells[0].Tag);
		}
		return arrayLists;
	}

	public void method_263(string string_96)
	{
		try
		{
			if (!this.dataGridViewFollowSnd.InvokeRequired)
			{
				int num = 0;
				while (true)
				{
					if (num >= this.dataGridViewFollowSnd.Rows.Count)
					{
						break;
					}
					else if (string_96.Equals(((GClass23)this.dataGridViewFollowSnd[0, num].Tag).string_0))
					{
						this.dataGridViewFollowSnd.Rows.RemoveAt(num);
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
				AliBridgeForm.GDelegate85 gDelegate85 = new AliBridgeForm.GDelegate85(this.method_263);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate85, string96);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[deleteDataGridViewFollowSnd]出错了！只是小错，吓吓你们的：", exception.ToString()));
		}
	}

	public void method_264()
	{
		try
		{
			if (!this.dataGridViewFollowSnd.InvokeRequired)
			{
				this.dataGridViewFollowSnd.Rows.Clear();
			}
			else
			{
				AliBridgeForm.GDelegate86 gDelegate86 = new AliBridgeForm.GDelegate86(this.method_264);
				base.BeginInvoke(gDelegate86, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[deleteDataGridViewFollowSnd]出错了！只是小错，吓吓你们的：", exception.ToString()));
		}
	}

	public void method_265(string string_96)
	{
		try
		{
			if (!this.dataGridViewFollowSnd.InvokeRequired)
			{
				int red = 0;
				while (red < this.dataGridViewFollowSnd.Rows.Count)
				{
					if (string_96.Equals(((GClass23)this.dataGridViewFollowSnd[0, red].Tag).string_0))
					{
						this.dataGridViewFollowSnd[2, red].Value = "失败";
						this.dataGridViewFollowSnd[2, red].Style.ForeColor = Color.Red;
						goto Label0;
					}
					else
					{
						red++;
					}
				}
			}
			else
			{
				AliBridgeForm.GDelegate87 gDelegate87 = new AliBridgeForm.GDelegate87(this.method_265);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate87, string96);
			}
		Label0:
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[deleteDataGridViewFollowSnd]出错了！只是小错，吓吓你们的：", exception.ToString()));
		}
	}

	private void method_266()
	{
		try
		{
			this.contextMenuStripFwSnd.Items.Add("查看跟发内容(双击)");
			this.contextMenuStripFwSnd.Items[0].Click += new EventHandler(this.method_267);
			this.contextMenuStripFwSnd.Items.Add("删除跟发内容");
			this.contextMenuStripFwSnd.Items[1].Click += new EventHandler(this.method_268);
			this.contextMenuStripFwSnd.Items.Add("发送选中内容");
			this.contextMenuStripFwSnd.Items[2].Click += new EventHandler(this.method_269);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContentMenuTripFwSnd]出错：", exception.ToString()));
		}
	}

	private void method_267(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewFollowSnd.CurrentCell != null)
			{
				this.method_122();
				GClass23 tag = (GClass23)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
				(new ShowFwSndForm(tag.string_0)).ShowDialog();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ViewFwSnd_Click]出错：", exception.ToString()));
		}
	}

	private void method_268(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewFollowSnd.CurrentCell != null)
			{
				this.method_122();
				GClass23 tag = (GClass23)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
				this.method_270(tag.string_0);
				this.method_263(tag.string_0);
				this.method_115("删除跟发内容成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[DelFwSnd_Click]出错：", exception.ToString()));
		}
	}

	private void method_269(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewFollowSnd.CurrentCell != null)
			{
				GClass23 tag = (GClass23)this.dataGridViewFollowSnd[0, this.dataGridViewFollowSnd.CurrentCell.RowIndex].Tag;
				this.method_252(tag);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[FwSnd_Click]出错：", exception.ToString()));
		}
	}

	private void method_27()
	{
		try
		{
			this.string_21 = string.Concat(this.string_41, "\\config\\QQ群顺序.txt");
			this.arrayList_4 = new ArrayList();
			if (File.Exists(this.string_21))
			{
				StreamReader streamReader = new StreamReader(this.string_21, Encoding.GetEncoding("GB2312"));
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
						this.arrayList_4.Add(str.Trim());
					}
				}
				streamReader.Close();
				streamReader.Dispose();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadQQGrpOrder]出错：", exception.ToString()));
		}
	}

	private void method_270(string string_96)
	{
		FileStream fileStream = File.Create(string.Concat(this.string_68, "\\", string_96, "\\2.txt"));
		fileStream.Close();
		fileStream.Dispose();
	}

	private void method_271()
	{
		try
		{
			this.pictureBoxOnlineItemPic.Image = null;
			this.dataGridViewCmsPlan.Visible = false;
			if (!this.textBoxOItemId.Text.Trim().Equals(""))
			{
				this.string_72 = this.method_81(this.textBoxOItemId.Text.Trim());
				if ((this.string_72 == null || "".Equals(this.string_72) ? false : this.regex_0.IsMatch(this.string_72)))
				{
					this.method_115("开始搜产品！");
					this.method_286();
					this.dataGridViewOnlineBrdg.Rows.Clear();
					(new Thread(new ThreadStart(this.method_272))).Start();
				}
				else
				{
					this.method_115("产品ID输入错误！");
				}
			}
			else
			{
				this.method_115("别忘了填产品链接！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[onlineByItemId]出错：", exception.ToString()));
		}
	}

	private void method_272()
	{
		try
		{
			this.arrayList_16 = this.method_273(this.string_72);
			if (this.arrayList_16 != null)
			{
				if (this.arrayList_16.Count != 0)
				{
					this.method_115(string.Concat("搜索完成！【", this.arrayList_16.Count, "】条产品！"));
					this.method_278(this.arrayList_16);
				}
				else
				{
					this.method_115("搜索完成！【0】条产品！");
				}
				this.string_67 = this.string_72;
				this.int_20 = 4;
				this.method_240();
			}
			this.method_285();
			this.method_296(4, false);
			this.method_296(5, false);
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_285();
			this.method_296(4, false);
			this.method_296(5, false);
			this.method_115(string.Concat("[processOSchByItemId]出错了！", exception.ToString()));
		}
	}

	private ArrayList method_273(string string_96)
	{
		ArrayList arrayLists;
		try
		{
			arrayLists = ᜃ.ᜄ(this.string_20, string.Concat("&q=", HttpUtility.UrlEncode(string.Concat("https://item.taobao.com/item.htm?id=", string_96))), ref this.string_23);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[schOnlineByItemId]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	public void method_274()
	{
		try
		{
			if (!this.textBoxOSchKey.Text.Trim().Equals(""))
			{
				this.method_115("开始按关键词搜索！");
				this.method_275(string.Concat("&q=", HttpUtility.UrlEncode(this.textBoxOSchKey.Text.Trim())));
			}
			else
			{
				this.method_115("别忘了填关键词！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OSchKey]出错：", exception.ToString()));
		}
	}

	private void method_275(string string_96)
	{
		try
		{
			this.int_24 = 1;
			this.method_122();
			this.pictureBoxOnlineItemPic.Image = null;
			this.dataGridViewCmsPlan.Visible = false;
			this.method_286();
			this.dataGridViewOnlineBrdg.Rows.Clear();
			this.string_73 = this.method_277();
			this.string_73 = this.string_73.Replace("{schkey}", string_96);
			(new Thread(new ThreadStart(this.method_276))).Start();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[schOnlineByKWFilter]出错：", exception.ToString()));
		}
	}

	private void method_276()
	{
		try
		{
			this.arrayList_16 = ᜃ.ᜄ(this.string_20, this.string_73, ref this.string_23);
			this.method_278(this.arrayList_16);
			this.method_285();
			if (this.int_24 <= 1)
			{
				this.method_296(4, false);
			}
			else
			{
				this.method_296(4, true);
			}
			if ((this.arrayList_16 == null ? true : this.arrayList_16.Count != 50))
			{
				this.method_296(5, false);
			}
			else
			{
				this.method_296(5, true);
			}
			object[] int24 = new object[] { "【", this.int_24, "】页搜索完成！【", this.arrayList_16.Count, "】条产品！" };
			this.method_115(string.Concat(int24));
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_285();
			this.method_296(4, false);
			this.method_296(5, false);
			this.method_115(string.Concat("[processOSchBySchKey]出错了！", exception.ToString()));
		}
	}

	private string method_277()
	{
		string str;
		try
		{
			string str1 = (this.checkBoxOTmallOnly.Checked ? "&userType=1" : "");
			string str2 = "";
			if (!this.textBoxOLowestCms.Text.Trim().Equals(""))
			{
				str2 = string.Concat("&startTkRate=", this.textBoxOLowestCms.Text.Trim());
			}
			string str3 = "";
			if (!this.textBoxOSoldQu.Text.Trim().Equals(""))
			{
				str3 = string.Concat("&startBiz30day=", this.textBoxOSoldQu.Text.Trim());
			}
			string str4 = "";
			if (!this.textBoxOLowPrice.Text.Trim().Equals(""))
			{
				str4 = string.Concat("&startPrice=", this.textBoxOLowPrice.Text.Trim());
			}
			string str5 = "";
			if (!this.textBoxOHiPrice.Text.Trim().Equals(""))
			{
				str5 = string.Concat("&endPrice=", this.textBoxOHiPrice.Text.Trim());
			}
			string str6 = "{schkey}&toPage=1{schactcms}{tmallonly}{schsoldquanlity}{schpricelow}{schpricehigh}";
			str6 = str6.Replace("{schactcms}", string.Concat(str2, "")).Replace("{tmallonly}", str1).Replace("{schsoldquanlity}", string.Concat(str3, "")).Replace("{schpricelow}", str4).Replace("{schpricehigh}", str5);
			str = str6;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getFilterStr]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	public void method_278(ArrayList arrayList_26)
	{
		try
		{
			if (!this.dataGridViewOnlineBrdg.InvokeRequired)
			{
				if (arrayList_26.Count <= 13)
				{
					this.dataGridViewOnlineBrdg.Columns[3].Width = 506;
				}
				else
				{
					this.dataGridViewOnlineBrdg.Columns[3].Width = 488;
				}
				int num = 0;
				foreach (ᜭ arrayList26 in arrayList_26)
				{
					int num1 = 0;
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewOnlineBrdg.Rows.Add(dataGridViewRow);
					this.dataGridViewOnlineBrdg.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
					this.dataGridViewOnlineBrdg[0, num].Value = "-";
					num1 = 1;
					this.dataGridViewOnlineBrdg[1, num].Value = arrayList26.ᜀ;
					num1 = 2;
					this.dataGridViewOnlineBrdg[2, num].Value = (arrayList26.ᜆ == 1 ? "天猫" : "淘宝");
					int num2 = num1 + 1;
					num1 = num2;
					this.dataGridViewOnlineBrdg[num2, num].Value = arrayList26.ᜁ;
					int num3 = num1 + 1;
					num1 = num3;
					this.dataGridViewOnlineBrdg[num3, num].Value = arrayList26.ᜉ;
					int num4 = num1 + 1;
					num1 = num4;
					this.dataGridViewOnlineBrdg[num4, num].Value = 95;
					int num5 = num1 + 1;
					num1 = num5;
					this.dataGridViewOnlineBrdg[num5, num].Value = this.method_100(arrayList26.ᜉ);
					int num6 = num1 + 1;
					num1 = num6;
					this.dataGridViewOnlineBrdg[num6, num].Value = arrayList26.ᜈ;
					int num7 = num1 + 1;
					num1 = num7;
					this.dataGridViewOnlineBrdg[num7, num].Value = this.method_100(arrayList26.ᜉ * arrayList26.ᜈ / 100);
					int num8 = num1 + 1;
					num1 = num8;
					this.dataGridViewOnlineBrdg[num8, num].Value = arrayList26.ᜇ;
					int num9 = num1 + 1;
					num1 = num9;
					this.dataGridViewOnlineBrdg[num9, num].Value = string.Concat(arrayList26.ᜅ, "天");
					this.dataGridViewOnlineBrdg.Rows[num].Tag = arrayList26;
					num++;
				}
			}
			else
			{
				AliBridgeForm.GDelegate88 gDelegate88 = new AliBridgeForm.GDelegate88(this.method_278);
				object[] objArray = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate88, objArray);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dispOnlineDataGridViewBrdg]出错了！只是小错，吓吓你们的：", exception.ToString()));
		}
	}

	private ArrayList method_279(string string_96)
	{
		ArrayList arrayLists;
		try
		{
			ArrayList arrayLists1 = new ArrayList();
			char[] chrArray = new char[] { '\n' };
			string[] strArrays = string_96.Split(chrArray);
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				string str = strArrays[i];
				if (!str.Equals(""))
				{
					GClass21 gClass21 = new GClass21();
					chrArray = new char[] { '\t' };
					gClass21.string_1 = str.Split(chrArray)[0];
					chrArray = new char[] { '\t' };
					gClass21.string_2 = str.Split(chrArray)[1];
					chrArray = new char[] { '\t' };
					gClass21.int_0 = int.Parse(str.Split(chrArray)[2]);
					chrArray = new char[] { '\t' };
					gClass21.double_0 = double.Parse(str.Split(chrArray)[3]);
					chrArray = new char[] { '\t' };
					gClass21.int_1 = int.Parse(str.Split(chrArray)[4]);
					chrArray = new char[] { '\t' };
					gClass21.string_0 = str.Split(chrArray)[5];
					chrArray = new char[] { '\t' };
					gClass21.double_1 = double.Parse(str.Split(chrArray)[6]);
					chrArray = new char[] { '\t' };
					gClass21.double_2 = double.Parse(str.Split(chrArray)[7]);
					chrArray = new char[] { '\t' };
					gClass21.int_2 = int.Parse(str.Split(chrArray)[8]);
					chrArray = new char[] { '\t' };
					gClass21.string_3 = str.Split(chrArray)[9];
					arrayLists1.Add(gClass21);
				}
			}
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBridgeItemList]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	private void method_28()
	{
		try
		{
			if (File.Exists(this.string_21))
			{
				File.Delete(this.string_21);
			}
			FileStream fileStream = new FileStream(this.string_21, FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding("GB2312"));
			foreach (string arrayList4 in this.arrayList_4)
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
			this.method_115(string.Concat("[saveQQGrpOrderList]出错：", exception.ToString()));
		}
	}

	private ArrayList method_280(string string_96)
	{
		ArrayList arrayLists;
		try
		{
			char[] chrArray = new char[] { '\n' };
			string_96.Split(chrArray);
			ArrayList arrayLists1 = new ArrayList();
			chrArray = new char[] { '\n' };
			string[] strArrays = string_96.Split(chrArray);
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				string str = strArrays[i];
				if (!str.Equals(""))
				{
					GClass20 gClass20 = new GClass20();
					chrArray = new char[] { '\t' };
					gClass20.string_0 = str.Split(chrArray)[0];
					chrArray = new char[] { '\t' };
					gClass20.string_1 = str.Split(chrArray)[1];
					chrArray = new char[] { '\t' };
					gClass20.double_0 = double.Parse(str.Split(chrArray)[2]);
					chrArray = new char[] { '\t' };
					gClass20.double_1 = double.Parse(str.Split(chrArray)[3]);
					chrArray = new char[] { '\t' };
					gClass20.int_0 = int.Parse(str.Split(chrArray)[4]);
					arrayLists1.Add(gClass20);
				}
			}
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getAlibridgeList]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	private void method_281(string string_96)
	{
		try
		{
			Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", string_96));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[doubleClickToOpenOnlineItem]出错：", exception.ToString()));
		}
	}

	private void method_282(string string_96)
	{
		try
		{
			ᜭ _ᜭ = this.method_284(string_96);
			this.method_283(string.Concat(GClass13.string_4, _ᜭ.ᜄ, "_160x160.jpg"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[clickToShowOnlineSchPic]出错：", exception.ToString()));
		}
	}

	private void method_283(string string_96)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			byte[] numArray = webClient.DownloadData(string_96);
			this.pictureBoxOnlineItemPic.Image = Image.FromStream(new MemoryStream(numArray));
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if ((!exception.ToString().Contains("System.Net.WebException") ? true : !exception.ToString().Contains("404")))
			{
				this.method_115(string.Concat("[downloOnlineItemPic]出错了！", exception.ToString()));
			}
			else
			{
				this.method_115("产品图片已经不存在或者修改过，无法查看！");
			}
		}
	}

	private ᜭ method_284(string string_96)
	{
		ᜭ _ᜭ;
		try
		{
			foreach (ᜭ arrayList16 in this.arrayList_16)
			{
				if (!arrayList16.ᜀ.Equals(string_96))
				{
					continue;
				}
				_ᜭ = arrayList16;
				return _ᜭ;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBridgeItem]出错：", exception.ToString()));
		}
		_ᜭ = null;
		return _ᜭ;
	}

	private void method_285()
	{
		this.method_296(1, true);
		this.method_296(2, true);
		this.method_296(3, true);
		this.method_296(4, true);
		this.method_296(5, true);
	}

	private void method_286()
	{
		this.method_296(1, false);
		this.method_296(2, false);
		this.method_296(3, false);
		this.method_296(4, false);
		this.method_296(5, false);
	}

	private void method_287(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewOnlineBrdg.CurrentCell != null)
			{
				if (this.method_118())
				{
					this.method_122();
					this.dataGridViewOnlineBrdg[0, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex].Value.ToString();
					string str = this.dataGridViewOnlineBrdg[1, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex].Value.ToString();
					float single = float.Parse(this.dataGridViewOnlineBrdg[4, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex].Value.ToString());
					Clipboard.Clear();
					string str1 = this.method_199(this.method_288(str, single));
					if (str1 != null)
					{
						try
						{
							Clipboard.SetText(str1);
							this.method_115(string.Concat("推广链接复制成功，可以直接粘贴！推广链接【", str1, "】"));
						}
						catch
						{
							this.method_115(string.Concat("推广链接复制失败，请重新获取！推广链接【", str1, "】"));
						}
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[GetOnPub_Click]出错：", exception.ToString()));
		}
	}

	private string method_288(string string_96, float float_5)
	{
		᜵ _u1735;
		string str = null;
		try
		{
			ᜭ _ᜭ = ᜃ.ᜅ(this.string_20, string_96, ref this.string_23);
			if (!(_ᜭ != null ? true : !"".Equals(this.string_23)))
			{
				this.method_115(string.Concat("【", string_96, "】该产品已经退出当前鹊桥活动，请推广定向计划或者选取其他产品推广！"));
			}
			else if (!(_ᜭ != null ? true : "".Equals(this.string_23)))
			{
				this.method_115(string.Concat("【", string_96, "】搜索鹊桥活动产品失败！", this.string_23));
			}
			else if (!this.bool_32)
			{
				_u1735 = ᜃ.ᜂ(this.string_20, string_96, this.string_27, this.string_26, ref this.string_23);
				if (_u1735 != null)
				{
					str = _u1735.ᜁ;
				}
			}
			else
			{
				_u1735 = ᜃ.ᜂ(this.string_20, string_96, this.string_31, this.string_30, ref this.string_23);
				if (_u1735 != null)
				{
					str = _u1735.ᜁ;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getPromotLink]出错：", exception.ToString()));
		}
		return str;
	}

	public string method_289(string string_96)
	{
		string string96;
		try
		{
			if (!this.method_290(string_96))
			{
				string96 = "error";
			}
			else if ((this.string_38 == null ? false : !"".Equals(this.string_38)))
			{
				string str = "urltype={urltype}&url={url}".Replace("{urltype}", (this.bool_29 ? "1" : "0")).Replace("{url}", HttpUtility.UrlEncode(string_96));
				string str1 = this.ᝠ_0.ᜁ(string.Concat("http://", this.string_38, "/createurl.php"), "POST", str);
				string96 = string.Concat("http://", this.string_38, "/", str1);
			}
			else
			{
				string96 = "error";
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getQyShortUrl]出错：", exception.ToString()));
			string96 = string_96;
		}
		return string96;
	}

	private void method_29()
	{
		try
		{
			this.dataGridViewAutoSndTask.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewAutoSndTask.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			this.dataGridViewAutoSndTask.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewAutoSndTask.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "计划ID",
				Width = 283
			};
			this.dataGridViewAutoSndTask.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "计划状态",
				Width = 115
			};
			this.dataGridViewAutoSndTask.Columns.Add(dataGridViewTextBoxColumn1);
			this.method_159();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initAutoSndTaskGridView]出错：", exception.ToString()));
		}
	}

	public bool method_290(string string_96)
	{
		bool flag;
		if ((string_96.StartsWith("http://") ? true : string_96.StartsWith("https://")))
		{
			string str = string_96.Substring(0, string_96.IndexOf("/", 9));
			if ((str.EndsWith("taobao.com") || str.EndsWith("tmall.com") || str.EndsWith("tmall.hk") || str.EndsWith("95095.com") ? true : str.EndsWith("alimama.com")))
			{
				flag = true;
			}
			else
			{
				this.method_115("千语短网址只能转淘宝天猫的地址！");
				flag = false;
			}
		}
		else
		{
			this.method_115("原网址错误，不是有效的网址格式！");
			flag = false;
		}
		return flag;
	}

	private void method_291(object sender, EventArgs e)
	{
		try
		{
			if (this.method_118())
			{
				if (this.dataGridViewOnlineBrdg.CurrentCell != null)
				{
					if (this.dataGridViewOnlineBrdg.SelectedRows.Count <= 3)
					{
						this.method_115("检查阿里妈妈登录！");
						if (ᜃ.ᜋ(this.string_20))
						{
							string str = "";
							int num = 0;
							for (int i = 0; i < this.dataGridViewOnlineBrdg.SelectedRows.Count; i++)
							{
								ᜭ tag = (ᜭ)this.dataGridViewOnlineBrdg.SelectedRows[i].Tag;
								string str1 = this.method_292(tag.ᜀ, (float)tag.ᜉ);
								if (str1 != null)
								{
									str = (!str.Equals("") ? string.Concat(str, "\n\n<BR><BR>", str1) : str1);
								}
								else
								{
									num++;
								}
							}
							((IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument).body.innerHTML = str;
							if (num != 0)
							{
								this.method_115(string.Concat("添加到手动群发完成！失败【", num, "】个。"));
							}
							else
							{
								this.method_115("添加到手动群发成功！");
							}
						}
						else
						{
							this.method_115("没有登录阿里妈妈！");
							this.bool_0 = false;
							this.method_7();
						}
					}
					else
					{
						this.method_115("选中行多于3个，无法添加到手动群发！");
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[AddOnToSend_Click]出错：", exception.ToString()));
		}
	}

	private string method_292(string string_96, float float_5)
	{
		string str;
		try
		{
			string str1 = this.method_199(this.method_288(string_96, float_5));
			if (str1 != null)
			{
				this.dataGridViewOnlineBrdg[3, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex].Value.ToString();
				ArrayList arrayLists = ᜃ.ᜇ(string_96, this.string_20, ref this.string_23);
				if (arrayLists.Count != 0)
				{
					ᜦ item = (ᜦ)arrayLists[0];
					string str2 = item.ᜄ;
					ᜭ _ᜭ = this.method_284(string_96);
					string str3 = string.Concat(GClass13.string_4, _ᜭ.ᜄ, "_400x400.jpg");
					string str4 = "<DIV>{title}   {price}</DIV><DIV><IMG src=\"{imgsrc}\"></DIV><DIV>{promlink}</DIV>";
					str4 = str4.Replace("{title}", item.ᜁ).Replace("{price}", string.Concat("特价", str2, "元")).Replace("{imgsrc}", string.Concat("file:///", this.method_295(str3).Replace(" ", "%20").Replace("{", "%7b").Replace("}", "%7d").Replace("\\", "/"))).Replace("{promlink}", str1);
					str = str4;
				}
				else
				{
					str = null;
				}
			}
			else
			{
				str = null;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getOnSelectPromotInfo]出错：", exception.ToString()));
			str = null;
		}
		return str;
	}

	private void method_293(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenOnBrdg_Click]出错：", exception.ToString()));
		}
	}

	private void method_294(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewOnlineBrdg.CurrentCell != null)
			{
				string str = this.dataGridViewOnlineBrdg[1, this.dataGridViewOnlineBrdg.CurrentCell.RowIndex].Value.ToString();
				this.method_282(str);
				this.method_281(str);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenOnProduct_Click]出错：", exception.ToString()));
		}
	}

	private string method_295(string string_96)
	{
		string str;
		try
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			string string53 = this.string_53;
			DateTime now = DateTime.Now;
			string str1 = string.Concat(string53, "\\", now.ToString("yyyyMMddHHmmssffff"), ".jpg");
			webClient.DownloadFile(string_96, str1);
			str = str1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[downloadOnItemPicForCopy]出错了！", exception.ToString()));
			str = null;
		}
		return str;
	}

	public void method_296(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate89 gDelegate89;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonOFilter.InvokeRequired)
				{
					this.buttonOFilter.Enabled = bool_40;
				}
				else
				{
					gDelegate89 = new AliBridgeForm.GDelegate89(this.method_296);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate89, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonOSchItemId.InvokeRequired)
				{
					this.buttonOSchItemId.Enabled = bool_40;
				}
				else
				{
					gDelegate89 = new AliBridgeForm.GDelegate89(this.method_296);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate89, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.buttonOSchKey.InvokeRequired)
				{
					this.buttonOSchKey.Enabled = bool_40;
				}
				else
				{
					gDelegate89 = new AliBridgeForm.GDelegate89(this.method_296);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate89, int28);
					return;
				}
			}
			else if (int_28 == 4)
			{
				if (!this.buttonPrePage.InvokeRequired)
				{
					this.buttonPrePage.Enabled = bool_40;
				}
				else
				{
					gDelegate89 = new AliBridgeForm.GDelegate89(this.method_296);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate89, int28);
					return;
				}
			}
			else if (int_28 == 5)
			{
				if (!this.buttonNextPage.InvokeRequired)
				{
					this.buttonNextPage.Enabled = bool_40;
				}
				else
				{
					gDelegate89 = new AliBridgeForm.GDelegate89(this.method_296);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate89, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OnlineBtnCtl]出错：", exception.ToString()));
		}
	}

	public void method_297(int int_28)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				if (this.ᝡ_0 == null)
				{
					this.ᝡ_0 = ᜃ.ᜈ("29", this.string_20);
					this.string_35 = this.ᝡ_0.ᜀ;
				}
				if (this.radioButtonCmMWeb.Checked)
				{
					this.arrayList_17 = this.ᝡ_0.ᜃ;
				}
				else if (!this.radioButtonCmMApp.Checked)
				{
					this.radioButtonCmMOth.Checked = true;
					this.arrayList_17 = this.ᝡ_0.ᜁ;
				}
				else
				{
					this.arrayList_17 = this.ᝡ_0.ᜂ;
				}
				this.method_303(this.ᝡ_0, ᜃ.ᜊ(this.string_20));
				if (!(this.arrayList_17 == null ? false : this.arrayList_17.Count != 0))
				{
					if (int_28 <= 5)
					{
						GenQQPromotMediaForm genQQPromotMediaForm = new GenQQPromotMediaForm();
						genQQPromotMediaForm.ShowDialog();
						string string0 = genQQPromotMediaForm.string_0;
						string string1 = genQQPromotMediaForm.string_1;
						if ((string0.Equals("") ? false : !string1.Equals("")))
						{
							string str = string.Concat(string0, "&account2=", string1);
							ᜃ.ᜆ("QQ群推广", "13", str, this.string_20, ref this.string_23);
							this.ᝡ_0 = null;
							this.method_297(int_28 + 1);
						}
						else
						{
							this.method_115("没有输入QQ号或者QQ群号，无法自动创建推广位！");
						}
					}
				}
				else if (int_28 <= 5)
				{
					int count = 0;
					foreach (᜝ arrayList17 in this.arrayList_17)
					{
						count = count + arrayList17.ᜂ.Count;
					}
					if (count != 0)
					{
						this.method_298();
					}
					else
					{
						string item = ((᜝)this.arrayList_17[0]).ᜀ;
						ᜃ.ᜅ("29", item, "千语创建通用推广位", this.string_20, ref this.string_23);
						this.ᝡ_0 = null;
						this.method_297(int_28 + 1);
					}
				}
			}
			else
			{
				this.method_115("登录以后再查看和修改PID！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[promotCmTypeManage]出错：", exception.ToString()));
		}
	}

	public void method_298()
	{
		GClass24 gClass24;
		try
		{
			this.comboBoxCmPUnit.Items.Clear();
			this.comboBoxCmPPos.Items.Clear();
			foreach (᜝ arrayList17 in this.arrayList_17)
			{
				gClass24 = new GClass24();
				gClass24.method_3(arrayList17.ᜀ);
				gClass24.method_1(arrayList17.ᜁ);
				gClass24.method_5(arrayList17.ᜂ);
				this.comboBoxCmPUnit.Items.Add(gClass24);
			}
			IEnumerator enumerator = this.comboBoxCmPUnit.Items.GetEnumerator();
			try
			{
				while (true)
				{
					if (enumerator.MoveNext())
					{
						gClass24 = (GClass24)enumerator.Current;
						ArrayList arrayLists = (ArrayList)gClass24.method_4();
						if ((arrayLists == null ? false : arrayLists.Count != 0))
						{
							this.comboBoxCmPUnit.SelectedItem = gClass24;
							this.comboBoxCmPPos.SelectedIndex = 0;
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
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showCmPromotPostion]出错：", exception.ToString()));
		}
	}

	public void method_299(int int_28)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				if (this.ᝡ_1 == null)
				{
					this.ᝡ_1 = ᜃ.ᜈ("59", this.string_20);
					this.string_35 = this.ᝡ_1.ᜀ;
				}
				if (this.radioButtonBrdgMWeb.Checked)
				{
					this.arrayList_18 = this.ᝡ_1.ᜃ;
				}
				else if (!this.radioButtonBrdgMApp.Checked)
				{
					this.radioButtonBrdgMOth.Checked = true;
					this.arrayList_18 = this.ᝡ_1.ᜁ;
				}
				else
				{
					this.arrayList_18 = this.ᝡ_1.ᜂ;
				}
				this.method_303(this.ᝡ_1, ᜃ.ᜊ(this.string_20));
				if (!(this.arrayList_18 == null ? false : this.arrayList_18.Count != 0))
				{
					if (int_28 <= 5)
					{
						GenQQPromotMediaForm genQQPromotMediaForm = new GenQQPromotMediaForm();
						genQQPromotMediaForm.ShowDialog();
						string string0 = genQQPromotMediaForm.string_0;
						string string1 = genQQPromotMediaForm.string_1;
						if ((string0.Equals("") ? false : !string1.Equals("")))
						{
							string str = string.Concat(string0, "&account2=", string1);
							ᜃ.ᜆ("QQ群推广", "13", str, this.string_20, ref this.string_23);
							this.ᝡ_1 = null;
							this.method_299(int_28 + 1);
						}
						else
						{
							this.method_115("没有输入QQ号或者QQ群号，无法自动创建推广位！");
						}
					}
				}
				else if (int_28 <= 5)
				{
					int count = 0;
					foreach (᜝ arrayList18 in this.arrayList_18)
					{
						count = count + arrayList18.ᜂ.Count;
					}
					if (count != 0)
					{
						this.method_300();
					}
					else
					{
						string item = ((᜝)this.arrayList_17[0]).ᜀ;
						ᜃ.ᜅ("59", item, "千语创建鹊桥推广位", this.string_20, ref this.string_23);
						this.ᝡ_1 = null;
						this.method_299(int_28 + 1);
					}
				}
			}
			else
			{
				this.method_115("登录以后再查看和修改PID！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[promotBrdgTypeManage]出错：", exception.ToString()));
		}
	}

	private void method_3()
	{
		try
		{
			Thread.Sleep(2000);
			ᝠ ᝠ1 = this.ᝠ_1;
			string string0 = this.string_0;
			object[] ᜐ0 = new object[] { "softwarename=alibridge&type=checkvip&user=", this.ᜐ_0.ᜁ, "&viptype=", 1 };
			string str = this.method_17(ᝠ1, string0, string.Concat(ᜐ0));
			char[] chrArray = new char[] { '&' };
			string[] strArrays = str.Split(chrArray);
			Hashtable hashtables = new Hashtable();
			string[] strArrays1 = strArrays;
			for (int i = 0; i < (int)strArrays1.Length; i++)
			{
				string str1 = strArrays1[i];
				chrArray = new char[] { '=' };
				string[] strArrays2 = str1.Split(chrArray);
				hashtables.Add(strArrays2[0], strArrays2[1]);
			}
			if ("ok".Equals(hashtables["result"]))
			{
				string str2 = ((string)hashtables["expiredate"]).Substring(0, 10);
				this.method_4(string.Concat("VIP有效期：", str2, ""));
			}
		}
		catch
		{
		}
	}

	private void method_30()
	{
		try
		{
			this.contextMenuStripBrdg.Items.Add("获取推广信息");
			this.contextMenuStripBrdg.Items[0].Click += new EventHandler(this.method_51);
			this.contextMenuStripBrdg.Items.Add("添加到群发助手");
			this.contextMenuStripBrdg.Items[1].Click += new EventHandler(this.method_52);
			this.contextMenuStripBrdg.Items.Add(new ToolStripSeparator());
			this.contextMenuStripBrdg.Items.Add("打开产品(双击)");
			this.contextMenuStripBrdg.Items[3].Click += new EventHandler(this.method_55);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContentMenuTripBrdg]出错：", exception.ToString()));
		}
	}

	public void method_300()
	{
		GClass24 gClass24;
		try
		{
			this.comboBoxBrdgPUnit.Items.Clear();
			this.comboBoxBrdgPPos.Items.Clear();
			foreach (᜝ arrayList18 in this.arrayList_18)
			{
				gClass24 = new GClass24();
				gClass24.method_3(arrayList18.ᜀ);
				gClass24.method_1(arrayList18.ᜁ);
				gClass24.method_5(arrayList18.ᜂ);
				this.comboBoxBrdgPUnit.Items.Add(gClass24);
			}
			IEnumerator enumerator = this.comboBoxBrdgPUnit.Items.GetEnumerator();
			try
			{
				while (true)
				{
					if (enumerator.MoveNext())
					{
						gClass24 = (GClass24)enumerator.Current;
						ArrayList arrayLists = (ArrayList)gClass24.method_4();
						if ((arrayLists == null ? false : arrayLists.Count != 0))
						{
							this.comboBoxBrdgPUnit.SelectedItem = gClass24;
							this.comboBoxBrdgPPos.SelectedIndex = 0;
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
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showBrdgPromotPostion]出错：", exception.ToString()));
		}
	}

	public void method_301(int int_28)
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				if (this.ᝡ_2 == null)
				{
					this.ᝡ_2 = ᜃ.ᜈ("29", this.string_20);
					this.string_35 = this.ᝡ_2.ᜀ;
				}
				this.method_302(this.ᝡ_2, ᜃ.ᜊ(this.string_20));
				this.arrayList_19 = this.ᝡ_2.ᜁ;
				if (!(this.arrayList_19 == null ? false : this.arrayList_19.Count != 0))
				{
					if (int_28 <= 5)
					{
						GenWxPromotMediaForm genWxPromotMediaForm = new GenWxPromotMediaForm();
						genWxPromotMediaForm.ShowDialog();
						string string0 = genWxPromotMediaForm.string_0;
						if (!string0.Equals(""))
						{
							ᜃ.ᜆ("微信推广", "14", string0, this.string_20, ref this.string_23);
							this.ᝡ_2 = null;
							this.method_301(int_28 + 1);
						}
						else
						{
							this.method_115("没有输入微信帐号，无法自动创建推广位！");
						}
					}
				}
				else if (int_28 <= 5)
				{
					int count = 0;
					foreach (᜝ arrayList19 in this.arrayList_19)
					{
						count = count + arrayList19.ᜂ.Count;
					}
					if (count != 0)
					{
						this.method_304();
					}
					else
					{
						string item = ((᜝)this.arrayList_19[0]).ᜀ;
						ᜃ.ᜅ("29", item, "千语创建微信推广位", this.string_20, ref this.string_23);
						this.ᝡ_2 = null;
						this.method_301(int_28 + 1);
					}
				}
			}
			else
			{
				this.method_115("登录以后再查看和修改PID！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[promotWxTypeManage]出错：", exception.ToString()));
		}
	}

	public void method_302(ᝡ ᝡ_3, ArrayList arrayList_26)
	{
	Label0:
		foreach (᜿ arrayList26 in arrayList_26)
		{
			if (arrayList26.ᜃ.Equals("14"))
			{
				continue;
			}
			int num = 0;
			while (num < ᝡ_3.ᜁ.Count)
			{
				᜝ item = (᜝)ᝡ_3.ᜁ[num];
				if (arrayList26.ᜂ.Equals(item.ᜀ))
				{
					ᝡ_3.ᜁ.RemoveAt(num);
					goto Label0;
				}
				else
				{
					num++;
				}
			}
		}
	}

	public void method_303(ᝡ ᝡ_3, ArrayList arrayList_26)
	{
	Label0:
		foreach (᜿ arrayList26 in arrayList_26)
		{
			if (!arrayList26.ᜃ.Equals("14"))
			{
				continue;
			}
			int num = 0;
			while (num < ᝡ_3.ᜁ.Count)
			{
				᜝ item = (᜝)ᝡ_3.ᜁ[num];
				if (arrayList26.ᜂ.Equals(item.ᜀ))
				{
					ᝡ_3.ᜁ.RemoveAt(num);
					goto Label0;
				}
				else
				{
					num++;
				}
			}
		}
	}

	public void method_304()
	{
		GClass24 gClass24;
		try
		{
			this.comboBoxWxPUnit.Items.Clear();
			this.comboBoxWxPPos.Items.Clear();
			foreach (᜝ arrayList19 in this.arrayList_19)
			{
				gClass24 = new GClass24();
				gClass24.method_3(arrayList19.ᜀ);
				gClass24.method_1(arrayList19.ᜁ);
				gClass24.method_5(arrayList19.ᜂ);
				this.comboBoxWxPUnit.Items.Add(gClass24);
			}
			IEnumerator enumerator = this.comboBoxWxPUnit.Items.GetEnumerator();
			try
			{
				while (true)
				{
					if (enumerator.MoveNext())
					{
						gClass24 = (GClass24)enumerator.Current;
						ArrayList arrayLists = (ArrayList)gClass24.method_4();
						if ((arrayLists == null ? false : arrayLists.Count != 0))
						{
							this.comboBoxWxPUnit.SelectedItem = gClass24;
							this.comboBoxWxPPos.SelectedIndex = 0;
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
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showWxPromotPostion]出错：", exception.ToString()));
		}
	}

	public void method_305()
	{
		if (!this.checkBoxWxPromot.Checked)
		{
			this.bool_32 = false;
			this.buttonCpPromotTkl.Enabled = false;
		}
		else
		{
			this.bool_32 = true;
			this.method_119();
		}
	}

	private void method_306()
	{
		try
		{
			if (!ᜃ.ᜋ(this.string_20))
			{
				this.method_115("登录阿里妈妈以后再转换链接！");
				this.bool_0 = false;
				this.method_7();
			}
			else if (!(this.webBrowserConvert.Document.Body.InnerHtml == null ? false : !this.webBrowserConvert.Document.Body.InnerHtml.Equals("")))
			{
				this.method_115("没有要转化的内容！");
			}
			else if (this.method_117())
			{
				if (this.method_119())
				{
					this.method_322(false);
					this.method_320(᝛.ᜀ(this.webBrowserConvert.Document.Body.InnerHtml));
					this.method_320(᝛.ᜂ(this.webBrowserConvert.Document.Body.InnerHtml));
					string str = this.method_307(this.webBrowserConvert.Document.Body.InnerHtml);
					if (str != null)
					{
						this.method_320(str);
						this.string_49 = this.webBrowserConvert.Document.Body.InnerHtml;
						this.string_80 = this.webBrowserConvert.Document.Body.InnerText;
						this.string_81 = this.webBrowserConvert.Document.Body.InnerHtml;
						if (this.string_80 == null)
						{
							this.string_80 = "";
						}
						(new Thread(new ThreadStart(this.method_310))).Start();
					}
					else
					{
						this.method_322(true);
					}
				}
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_322(true);
			this.method_115(string.Concat("[convertUrl]出错：", exception.ToString()));
		}
	}

	public string method_307(string string_96)
	{
		string string96;
		try
		{
			GClass30 gClass30 = new GClass30();
			this.method_308(string_96, gClass30);
			if (!"".Equals(gClass30.string_4))
			{
				if (!this.method_138(gClass30.string_4))
				{
					string str = ᝉ.ᜀ(gClass30.string_4, 0, "activityId=", "&");
					string str1 = ᝉ.ᜀ(gClass30.string_4, 0, "itemId=", "&");
					ArrayList arrayLists = ᜃ.ᜇ(str1, this.string_20, ref this.string_23);
					if ((arrayLists == null ? false : arrayLists.Count != 0))
					{
						ᜦ item = (ᜦ)arrayLists[0];
						string str2 = "优惠券：http://shop.m.taobao.com/shop/coupon.htm?activityId={activityId}&sellerId={sellerId}<BR>下单：http://item.taobao.com/item.htm?id={itemId}";
						str2 = str2.Replace("{activityId}", str).Replace("{sellerId}", item.ᜀ).Replace("{itemId}", str1);
						string_96 = gClass30.string_0.Replace("{couponItemUrl}", str2);
					}
					else
					{
						this.method_115("2合1链接出错！");
						string96 = null;
						return string96;
					}
				}
				else
				{
					string96 = string_96;
					return string96;
				}
			}
			string96 = string_96;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[parseCouponItemContentUrl]出错：", exception.ToString()));
			string96 = null;
		}
		return string96;
	}

	public void method_308(string string_96, GClass30 gclass30_0)
	{
		try
		{
			string_96 = this.method_144(string_96);
			string_96 = string_96.Replace("</span>", "</SPAN>").Replace("</div>", "</DIV>").Replace("<img", "<IMG").Replace("\n", "").Replace("\r", "").Replace("<br>", "\n").Replace("<BR>", "\n").Replace("<BR", "\n<BR").Replace("</DIV>", "\n").Replace("</SPAN>", "\n").Replace("</P>", "\n").Replace("</p>", "\n");
			string_96 = ᜸.ᜄ(string_96);
			this.method_309(this.method_142(string_96), gclass30_0, 3);
			string_96 = this.method_143(string_96);
			string_96 = string_96.Replace("{image}", "<IMG src=\"").Replace("{/image}", "\">");
			string_96 = string_96.Replace("\n", "<BR>");
			gclass30_0.string_0 = string_96;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[transCouponItemCmbToTwo]出错：", exception.ToString()));
		}
	}

	public void method_309(string string_96, GClass30 gclass30_0, int int_28)
	{
		try
		{
			string_96 = string_96.Replace("&nbsp;", " ").Replace("&amp;", "&");
			foreach (Match match in (new Regex(this.string_82)).Matches(string_96))
			{
				string str = match.Value.ToString();
				if (!str.Contains("uland.taobao.com"))
				{
					string str1 = ᜤ.ᜀ(str, str);
					if (str1.Contains("uland.taobao.com"))
					{
						gclass30_0.string_4 = str1;
					}
					Thread.Sleep(200);
				}
				else
				{
					gclass30_0.string_4 = str;
				}
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if ((!exception.ToString().Contains("System.Net.WebException") ? true : int_28 >= 5))
			{
				this.method_115(string.Concat("[checkCouponAndItemCmbUrl]出错：", exception.ToString()));
			}
			else
			{
				this.method_115("网络一时问题，正在重试。。。。");
				Thread.Sleep(1200);
				int_28++;
				this.method_309(string_96, gclass30_0, int_28);
			}
		}
	}

	private void method_31()
	{
		try
		{
			this.contextMenuStripOnBrdg.Items.Add("复制推广链接");
			this.contextMenuStripOnBrdg.Items[0].Click += new EventHandler(this.method_287);
			this.contextMenuStripOnBrdg.Items.Add("选中行添加到手动群发");
			this.contextMenuStripOnBrdg.Items[1].Click += new EventHandler(this.method_291);
			this.contextMenuStripOnBrdg.Items.Add(new ToolStripSeparator());
			this.contextMenuStripOnBrdg.Items.Add("打开产品(双击)");
			this.contextMenuStripOnBrdg.Items[3].Click += new EventHandler(this.method_294);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContentMenuTripOnBrdg]出错：", exception.ToString()));
		}
	}

	private void method_310()
	{
		try
		{
			this.bool_34 = false;
			this.string_83 = "";
			this.bool_17 = false;
			ArrayList arrayLists = this.method_324(this.string_80);
			if (arrayLists != null)
			{
				this.int_26 = this.method_325(arrayLists);
				this.string_81 = this.string_81.Replace("￥", "$");
				GClass30 gClass30 = null;
				this.bool_5 = false;
				if ((this.bool_3 ? false : !this.bool_6))
				{
					this.string_81 = this.method_317(arrayLists);
				}
				else
				{
					gClass30 = this.method_140(this.string_81);
					if (this.bool_6)
					{
						this.method_311(gClass30, arrayLists, this.int_26);
					}
					else if (!this.bool_5)
					{
						this.string_81 = this.method_317(arrayLists);
					}
					else
					{
						this.string_81 = gClass30.string_1.Replace("{couponItemUrl}", string.Concat("【领券下单地址】", this.method_315(gClass30)));
						if ((this.bool_32 || !this.bool_4 ? false : this.int_26 == 4))
						{
							this.string_81 = string.Concat(this.string_81, "<BR>复制这条消息，", gClass30.᜞_0.ᜀ, "，打开【手机淘宝】即可领券并下单");
						}
					}
				}
				foreach (GClass29 arrayList25 in this.arrayList_25)
				{
					this.string_81 = this.string_81.Replace(arrayList25.string_0, arrayList25.string_1);
				}
				this.method_321(this.string_81);
				if (this.bool_17)
				{
					MessageBox.Show("产品佣金计划已经申请，正在审核中", "计划审核状态提醒");
				}
				if (!this.bool_34)
				{
					this.method_115("PID转换完成！");
				}
				else
				{
					try
					{
						᝕ _u1755 = ᜤ.ᜅ(this.string_83);
						this.float_3 = (float)_u1755.ᜀ;
						this.method_115(string.Concat("PID转换完成！******", _u1755.ᜄ(), "******"));
					}
					catch
					{
						this.method_115("PID转换完成！没有查出来优惠券数量，请人工检查！");
					}
				}
				this.method_322(true);
				this.method_323(1, false);
				this.method_323(2, false);
				this.method_323(3, false);
				if (this.bool_32)
				{
					if ((this.string_76 == null ? false : !"".Equals(this.string_76)))
					{
						this.method_323(1, true);
					}
					if (this.bool_34)
					{
						this.method_323(2, true);
					}
					if ((this.string_77 == null ? false : !"".Equals(this.string_77)))
					{
						this.method_323(3, true);
					}
				}
			}
			else
			{
				this.method_322(true);
				this.method_115("PID转换失败！");
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_322(true);
			this.method_115(string.Concat("[processConvertUrl]出错：", exception.ToString()));
		}
	}

	public string method_311(GClass30 gclass30_0, ArrayList arrayList_26, int int_28)
	{
		if (!this.bool_7)
		{
			if (int_28 == 2)
			{
				this.string_81 = string.Concat(gclass30_0.string_0, "<BR>", this.method_312(gclass30_0));
			}
			else if (int_28 == 3)
			{
				this.string_81 = string.Concat(gclass30_0.string_0, "<BR>", this.method_313(gclass30_0, arrayList_26));
			}
			else if (int_28 == 4)
			{
				this.string_81 = string.Concat(gclass30_0.string_0, "<BR>", this.method_314(gclass30_0));
			}
		}
		else if (int_28 == 2)
		{
			this.string_81 = gclass30_0.string_1.Replace("{couponItemUrl}", this.method_312(gclass30_0));
		}
		else if (int_28 == 3)
		{
			this.string_81 = gclass30_0.string_1.Replace("{couponItemUrl}", this.method_313(gclass30_0, arrayList_26));
		}
		else if (int_28 == 4)
		{
			this.string_81 = gclass30_0.string_1.Replace("{couponItemUrl}", this.method_314(gclass30_0));
		}
		return this.string_81;
	}

	public string method_312(GClass30 gclass30_0)
	{
		string str = this.string_17.Replace("\n", "<BR>");
		if (str.Contains("#优惠券面额#"))
		{
			str = str.Replace("#优惠券面额#", this.method_316(gclass30_0.string_2));
		}
		if (str.Contains("#淘口令#"))
		{
			str = str.Replace("#淘口令#", this.method_331(gclass30_0.string_2));
		}
		if (str.Contains("#优惠券链接#"))
		{
			str = str.Replace("#优惠券链接#", gclass30_0.string_2);
		}
		return str;
	}

	public string method_313(GClass30 gclass30_0, ArrayList arrayList_26)
	{
		string str = this.string_18.Replace("\n", "<BR>");
		GClass25 gClass25 = this.method_318(gclass30_0.string_3, arrayList_26);
		if (gClass25.string_5.Equals(""))
		{
			gClass25.string_5 = this.method_331(gClass25.string_2);
		}
		if (str.Contains("#淘口令#"))
		{
			str = str.Replace("#淘口令#", gClass25.string_5);
		}
		if (str.Contains("#推广链接#"))
		{
			str = str.Replace("#推广链接#", gClass25.string_2);
		}
		return str;
	}

	public string method_314(GClass30 gclass30_0)
	{
		string str = this.string_19.Replace("\n", "<BR>");
		if (str.Contains("#优惠券面额#"))
		{
			str = str.Replace("#优惠券面额#", this.method_316(gclass30_0.string_2));
		}
		if (str.Contains("#淘口令#"))
		{
			str = str.Replace("#淘口令#", gclass30_0.᜞_0.ᜀ);
		}
		if (str.Contains("#手淘短网址#"))
		{
			str = str.Replace("#手淘短网址#", gclass30_0.᜞_0.ᜁ);
		}
		if (str.Contains("#2合1短网址#"))
		{
			str = str.Replace("#2合1短网址#", this.method_315(gclass30_0));
		}
		return str;
	}

	public string method_315(GClass30 gclass30_0)
	{
		if (gclass30_0.string_4.Contains("uland.taobao.com"))
		{
			gclass30_0.string_4 = this.method_205(gclass30_0.string_4, 0);
		}
		return gclass30_0.string_4;
	}

	public string method_316(string string_96)
	{
		string str;
		᝕ _u1755 = ᜤ.ᜅ(string_96);
		if (_u1755 == null)
		{
			_u1755 = new ᝕();
		}
		str = (_u1755.ᜀ <= 0 ? "" : string.Concat(_u1755.ᜀ, ""));
		return str;
	}

	public string method_317(ArrayList arrayList_26)
	{
		foreach (GClass25 arrayList26 in arrayList_26)
		{
			this.string_81 = this.string_81.Replace(arrayList26.string_1, arrayList26.string_2).Replace(arrayList26.string_1.Replace("&", "&amp;"), arrayList26.string_2);
		}
		if ((this.bool_32 ? false : this.bool_4))
		{
			this.string_77 = "";
			this.method_140(this.string_81);
			if (!"".Equals(this.string_77))
			{
				this.string_81 = string.Concat(this.string_81, "<BR>复制这条消息，", this.string_77, "，打开【手机淘宝】即可领券并下单");
			}
		}
		return this.string_81;
	}

	public GClass25 method_318(string string_96, ArrayList arrayList_26)
	{
		GClass25 gClass25;
		string str = this.method_81(string_96);
		foreach (GClass25 arrayList26 in arrayList_26)
		{
			if (!arrayList26.string_0.Contains(str))
			{
				continue;
			}
			gClass25 = arrayList26;
			return gClass25;
		}
		gClass25 = null;
		return gClass25;
	}

	private bool method_319(int int_28)
	{
		bool flag;
		try
		{
			ᝠ ᝠ1 = this.ᝠ_1;
			string string3 = this.string_3;
			object[] ᜐ0 = new object[] { "softwarename=alibridge&type=checkhotshareauth&username=", this.ᜐ_0.ᜁ, "&hottype=", int_28 };
			string str = this.method_17(ᝠ1, string3, string.Concat(ᜐ0));
			char[] chrArray = new char[] { '&' };
			string[] strArrays = str.Split(chrArray);
			Hashtable hashtables = new Hashtable();
			string[] strArrays1 = strArrays;
			for (int i = 0; i < (int)strArrays1.Length; i++)
			{
				string str1 = strArrays1[i];
				chrArray = new char[] { '=' };
				string[] strArrays2 = str1.Split(chrArray);
				hashtables.Add(strArrays2[0], strArrays2[1]);
			}
			if (!"ng".Equals(hashtables["result"]))
			{
				string item = (string)hashtables["timeleft"];
				flag = true;
			}
			else
			{
				this.method_115((string)hashtables["errmsg"]);
				flag = false;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkHotShareAuth]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private void method_32()
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
			this.method_115(string.Concat("[initContextMenuStripCtEdit]出错：", exception.ToString()));
		}
	}

	public void method_320(string string_96)
	{
		try
		{
			if (!base.InvokeRequired)
			{
				((IHTMLDocument2)this.webBrowserConvert.Document.DomDocument).body.innerHTML = string_96;
			}
			else
			{
				AliBridgeForm.GDelegate90 gDelegate90 = new AliBridgeForm.GDelegate90(this.method_320);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate90, string96);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ChgConvertWbContent]出错：", exception.ToString()));
		}
	}

	public void method_321(string string_96)
	{
		IHTMLDocument2 domDocument;
		try
		{
			if (!base.InvokeRequired)
			{
				IHTMLDocument2 string96 = (IHTMLDocument2)this.webBrowserConvert.Document.DomDocument;
				if (!this.checkBoxClrAfterConvert.Checked)
				{
					string96.body.innerHTML = string_96;
				}
				else
				{
					string96.body.innerHTML = "";
				}
				if (this.int_25 == 1)
				{
					domDocument = (IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument;
					domDocument.body.innerHTML = string_96;
					this.tabControlMain.SelectedIndex = GClass13.int_3;
				}
				else if (this.int_25 == 2)
				{
					if (GClass13.smethod_23(string_96, out this.string_23))
					{
						this.method_115("复制成功，可以直接粘贴！");
					}
					else
					{
						this.method_115(string.Concat("复制失败！", this.string_23));
					}
				}
				else if (this.int_25 == 3)
				{
					domDocument = (IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument;
					domDocument.body.innerHTML = string_96;
					this.tabControlMain.SelectedIndex = GClass13.int_3;
					this.tabControlSnd.SelectedIndex = 0;
					((IHTMLDocument2)this.webBrowserConvert.Document.DomDocument).body.innerHTML = "";
				}
				else if (this.int_25 == 4)
				{
					if (GClass13.smethod_23(string_96, out this.string_23))
					{
						this.method_115("生成朋友圈淘口令完成，可以点击下面的【优惠券】和【推广链接】直接复制！");
					}
					else
					{
						this.method_115(string.Concat("复制失败！", this.string_23));
					}
				}
				else if (this.int_25 == 5)
				{
					this.method_132(3);
				}
				else if (this.int_25 == 6)
				{
					this.method_132(4);
				}
			}
			else
			{
				AliBridgeForm.GDelegate91 gDelegate91 = new AliBridgeForm.GDelegate91(this.method_321);
				object[] objArray = new object[] { string_96 };
				base.BeginInvoke(gDelegate91, objArray);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[UrlConvert]出错：", exception.ToString()));
		}
	}

	public void method_322(bool bool_40)
	{
		try
		{
			if (!base.InvokeRequired)
			{
				this.bool_33 = !bool_40;
				this.buttonConvertAndAddToSnd.Enabled = bool_40;
				this.buttonConvert.Enabled = bool_40;
				this.buttonChkCoupon.Enabled = bool_40;
				this.buttonShareHotShare.Enabled = bool_40;
				this.buttonMutualHotShare.Enabled = bool_40;
				this.buttonConvertClr.Enabled = bool_40;
				if (this.bool_32)
				{
					this.buttonCpCouponTkl.Enabled = bool_40;
					this.buttonCpPromotTkl.Enabled = bool_40;
					this.buttonCp2in1Tkl.Enabled = bool_40;
					this.buttonPengyouQuan.Enabled = bool_40;
				}
			}
			else
			{
				AliBridgeForm.GDelegate92 gDelegate92 = new AliBridgeForm.GDelegate92(this.method_322);
				object[] bool40 = new object[] { bool_40 };
				base.BeginInvoke(gDelegate92, bool40);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CtrlUrlConvertBtn]出错：", exception.ToString()));
		}
	}

	public void method_323(int int_28, bool bool_40)
	{
		try
		{
			if (base.InvokeRequired)
			{
				AliBridgeForm.GDelegate93 gDelegate93 = new AliBridgeForm.GDelegate93(this.method_323);
				object[] int28 = new object[] { int_28, bool_40 };
				base.BeginInvoke(gDelegate93, int28);
			}
			else if (int_28 == 1)
			{
				this.buttonCpPromotTkl.Enabled = bool_40;
			}
			else if (int_28 != 2)
			{
				this.buttonCp2in1Tkl.Enabled = bool_40;
			}
			else
			{
				this.buttonCpCouponTkl.Enabled = bool_40;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CtrlWXPYQBtn]出错：", exception.ToString()));
		}
	}

	private ArrayList method_324(string string_96)
	{
		ArrayList arrayLists;
		try
		{
			this.string_78 = "";
			this.string_79 = "";
			this.float_2 = 0f;
			this.float_3 = 0f;
			this.float_4 = 0f;
			this.string_75 = "";
			this.string_76 = "";
			this.string_77 = "";
			ArrayList arrayLists1 = new ArrayList();
			MatchCollection matchCollections = (new Regex(this.string_82)).Matches(string_96);
			int num = 1;
			foreach (Match match in matchCollections)
			{
				this.method_115(string.Concat("正在处理第【", num, "】个链接！"));
				GClass25 gClass25 = new GClass25()
				{
					string_1 = match.Value.ToString()
				};
				gClass25 = this.method_326(gClass25, this.radioButtonHiCms.Checked);
				if ((gClass25 == null || gClass25.string_2 == null ? true : "".Equals(gClass25.string_2.Trim())))
				{
					if ((!this.checkBoxBatchConvert.Checked ? true : !this.bool_33))
					{
						arrayLists = null;
						return arrayLists;
					}
					else
					{
						gClass25 = new GClass25()
						{
							string_1 = match.Value.ToString(),
							string_2 = string.Concat("***链接转换失败，原链接：【", gClass25.string_1, "】***")
						};
					}
				}
				arrayLists1.Add(gClass25);
				num++;
			}
			arrayLists = arrayLists1;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[parseUrl]出错！", exception.ToString()));
			arrayLists = null;
		}
		return arrayLists;
	}

	public int method_325(ArrayList arrayList_26)
	{
		int num;
		if ((arrayList_26 == null ? false : arrayList_26.Count != 0))
		{
			bool flag = false;
			bool flag1 = false;
			foreach (GClass25 arrayList26 in arrayList_26)
			{
				if (arrayList26.int_0 == 1)
				{
					flag = true;
				}
				if (arrayList26.int_0 != 2)
				{
					continue;
				}
				flag1 = true;
			}
			if (!(!flag ? true : !flag1))
			{
				num = 4;
			}
			else if ((!flag ? true : flag1))
			{
				num = ((flag ? true : !flag1) ? 1 : 3);
			}
			else
			{
				num = 2;
			}
		}
		else
		{
			num = 0;
		}
		return num;
	}

	private GClass25 method_326(GClass25 gclass25_0, bool bool_40)
	{
		GClass26 gClass26;
		GClass25 gclass250;
		string string1 = gclass25_0.string_1;
		try
		{
			if (!((string1.Contains("taobao.com") || string1.Contains("tmall.com") || string1.Contains("yao.95095.com")) && string1.Contains("item.htm") ? !string1.Contains("id=") : true))
			{
				this.method_115(string.Concat("产品链接：", string1));
				gclass25_0.int_0 = 2;
				this.method_137(string1, GClass13.smethod_0(string1));
				gClass26 = this.method_329(string1, bool_40, this.string_20);
				gclass25_0.string_2 = gClass26.string_0;
				gclass25_0.string_0 = string1;
				gclass25_0.string_5 = gClass26.string_1;
				gclass250 = gclass25_0;
			}
			else if (string1.Contains("detail.ju.taobao.com"))
			{
				this.method_115(string.Concat("聚划算链接：", string1));
				gclass25_0.int_0 = 2;
				this.method_137(string1, GClass13.smethod_0(string1));
				if (!this.bool_32)
				{
					gclass25_0.string_2 = ᜃ.ᜃ(this.string_26, this.string_27, GClass13.smethod_0(string1), this.string_20);
					gclass250 = gclass25_0;
				}
				else
				{
					gclass25_0.string_2 = ᜃ.ᜃ(this.string_30, this.string_31, GClass13.smethod_0(string1), this.string_20);
					this.string_76 = this.method_330(gclass25_0.string_2);
					gclass25_0.string_5 = this.string_76;
					gclass250 = gclass25_0;
				}
			}
			else if ((!string1.Contains("coupon") ? true : !string1.Contains("taobao.com")))
			{
				string str = ᜤ.ᜀ(string1, string1);
				if (!(!str.Contains("coupon") ? true : !str.Contains("taobao.com")))
				{
					this.method_115(string.Concat("优惠券链接：", str));
					gclass25_0.int_0 = 1;
					this.bool_34 = true;
					this.string_83 = str;
					gclass25_0.string_2 = string1;
					gclass25_0.string_3 = this.method_328(str);
					gclass25_0.string_4 = this.method_327(str);
					if (this.bool_32)
					{
						this.string_75 = this.method_330(str.Replace("&amp;", "&"));
						gclass25_0.string_5 = this.string_75;
					}
					gclass250 = gclass25_0;
				}
				else if (str.Contains("detail.ju.taobao.com"))
				{
					this.method_115(string.Concat("聚划算链接：", str));
					gclass25_0.int_0 = 2;
					this.method_137(string1, GClass13.smethod_0(str));
					if (!this.bool_32)
					{
						gclass25_0.string_2 = ᜃ.ᜃ(this.string_26, this.string_27, GClass13.smethod_0(str), this.string_20);
						gclass250 = gclass25_0;
					}
					else
					{
						gclass25_0.string_2 = ᜃ.ᜃ(this.string_30, this.string_31, GClass13.smethod_0(str), this.string_20);
						this.string_76 = this.method_330(gclass25_0.string_2);
						gclass25_0.string_5 = this.string_76;
						gclass250 = gclass25_0;
					}
				}
				else if (!((str.Contains("taobao.com") || str.Contains("tmall.com") || str.Contains("yao.95095.com")) && str.Contains("item.htm") ? !str.Contains("id=") : true))
				{
					this.method_115(string.Concat("产品链接：", str));
					gclass25_0.int_0 = 2;
					this.method_137(string1, GClass13.smethod_0(str));
					gClass26 = this.method_329(str, bool_40, this.string_20);
					gclass25_0.string_2 = gClass26.string_0;
					gclass25_0.string_0 = str;
					gclass25_0.string_5 = gClass26.string_1;
					gclass250 = gclass25_0;
				}
				else if (str.Contains("item.htm?id="))
				{
					this.method_115(string.Concat("产品推广链接：", str));
					gclass25_0.int_0 = 2;
					this.method_137(string1, GClass13.smethod_0(str));
					gClass26 = this.method_329(str, bool_40, this.string_20);
					gclass25_0.string_2 = gClass26.string_0;
					gclass25_0.string_5 = gClass26.string_1;
					gclass250 = gclass25_0;
				}
				else if (str.Contains("shop/view_shop.htm?user_number_id="))
				{
					this.method_115(string.Concat("店铺推广链接：", str));
					gclass25_0.int_0 = 3;
					this.method_137(string1, GClass13.smethod_0(str));
					if (!this.bool_32)
					{
						gclass25_0.string_2 = ᜃ.ᜃ(this.string_26, this.string_27, GClass13.smethod_0(str), this.string_20);
						gclass250 = gclass25_0;
					}
					else
					{
						gclass25_0.string_2 = ᜃ.ᜃ(this.string_30, this.string_31, GClass13.smethod_0(str), this.string_20);
						gclass250 = gclass25_0;
					}
				}
				else if (str.Contains("temai.taobao.com"))
				{
					this.method_115(string.Concat("鹊桥链接(无法转换)：", string1));
					gclass25_0.int_0 = 0;
					gclass25_0.string_2 = string1;
					gclass250 = gclass25_0;
				}
				else if (str.Contains("err.taobao.com"))
				{
					this.method_115(string.Concat("淘宝错误页面：", str));
					gclass250 = null;
				}
				else if (!(str.Contains("pages.tmall.com") || str.Contains("1111.tmall.com") ? false : !str.Contains("huodong.taobao.com")))
				{
					this.method_115(string.Concat("双11活动推广链接：", str));
					if (this.hashtable_3 == null)
					{
						this.hashtable_3 = ᜃ.ᜇ(this.string_20);
					}
					gclass25_0.int_0 = 3;
					this.method_137(string1, GClass13.smethod_0(str));
					if (!this.bool_32)
					{
						gclass25_0.string_2 = ᜃ.ᜀ(this.string_26, this.string_27, GClass13.smethod_0(str), this.hashtable_3, this.string_20);
						gclass250 = gclass25_0;
					}
					else
					{
						gclass25_0.string_2 = ᜃ.ᜀ(this.string_30, this.string_31, GClass13.smethod_0(str), this.hashtable_3, this.string_20);
						gclass250 = gclass25_0;
					}
				}
				else if ((str.Contains("taobao.com") || str.Contains("tmall.com") || str.Contains("yao.95095.com") ? false : !str.Contains("alitrip.com")))
				{
					this.method_115(string.Concat("一般链接(无需转换)：", str));
					gclass25_0.int_0 = 0;
					gclass25_0.string_2 = string1;
					gclass250 = gclass25_0;
				}
				else
				{
					this.method_115(string.Concat("活动推广链接：", str));
					gclass25_0.int_0 = 3;
					this.method_137(string1, GClass13.smethod_0(str));
					if (!this.bool_32)
					{
						gclass25_0.string_2 = ᜃ.ᜃ(this.string_26, this.string_27, GClass13.smethod_0(str), this.string_20);
						gclass250 = gclass25_0;
					}
					else
					{
						gclass25_0.string_2 = ᜃ.ᜃ(this.string_30, this.string_31, GClass13.smethod_0(str), this.string_20);
						gclass250 = gclass25_0;
					}
				}
			}
			else
			{
				this.method_115(string.Concat("优惠券链接：", string1));
				gclass25_0.int_0 = 1;
				this.bool_34 = true;
				this.string_83 = string1;
				gclass25_0.string_2 = string1;
				gclass25_0.string_3 = this.method_328(string1);
				gclass25_0.string_4 = this.method_327(string1);
				if (this.bool_32)
				{
					this.string_75 = this.method_330(string1.Replace("&amp;", "&"));
					gclass25_0.string_5 = this.string_75;
				}
				gclass250 = gclass25_0;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if (!exception.ToString().Contains("System.Net.WebException"))
			{
				this.method_115(string.Concat("[changeUrl]出错！需要转换的链接：【", string1, "】，", exception.ToString()));
				gclass250 = null;
			}
			else
			{
				this.method_115(string.Concat("[changeUrl]出错，估计是一时网络问题，也可能是短网址问题，一般重试即可解决问题，需要转换的链接：【", string1, "】，"));
				gclass250 = null;
			}
		}
		return gclass250;
	}

	public string method_327(string string_96)
	{
		string str = HttpUtility.UrlDecode(string_96).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
		string str1 = ᝉ.ᜀ(str, 0, "sellerId=", "&");
		string str2 = ᝉ.ᜀ(str, 0, "activityId=", "&");
		return "http://taoquan.taobao.com/coupon/unify_apply.htm?sellerId={seller_id}&activityId={activity_id}&scene=taobao_shop".Replace("{seller_id}", str1).Replace("{activity_id}", str2);
	}

	public string method_328(string string_96)
	{
		string str = HttpUtility.UrlDecode(string_96).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
		string str1 = ᝉ.ᜀ(str, 0, "sellerId=", "&");
		string str2 = ᝉ.ᜀ(str, 0, "activityId=", "&");
		return "http://shop.m.taobao.com/shop/coupon.htm?seller_id={seller_id}&activity_id={activity_id}".Replace("{seller_id}", str1).Replace("{activity_id}", str2);
	}

	private GClass26 method_329(string string_96, bool bool_40, string string_97)
	{
		᜵ _u1735;
		GClass26 gClass26;
		IDisposable disposable;
		object[] string23;
		bool flag;
		bool flag1;
		try
		{
			this.bool_35 = false;
			string str = this.method_81(string_96);
			this.string_78 = str;
			this.string_70 = str;
			GClass26 string96 = new GClass26();
			float single = 0f;
			ᜭ _ᜭ = ᜃ.ᜅ(string_97, str, ref this.string_23);
			if (_ᜭ != null)
			{
				single = (float)(_ᜭ.ᜉ * 0.95);
				if (!this.bool_32)
				{
					_u1735 = ᜃ.ᜂ(string_97, str, this.string_27, this.string_26, ref this.string_23);
					if (_u1735 != null)
					{
						string96.string_0 = _u1735.ᜁ;
					}
				}
				else
				{
					_u1735 = ᜃ.ᜂ(string_97, str, this.string_31, this.string_30, ref this.string_23);
					if (_u1735 != null)
					{
						string96.string_0 = _u1735.ᜁ;
						string96.string_1 = _u1735.ᜀ;
						this.string_76 = _u1735.ᜀ;
					}
				}
			}
			ArrayList arrayLists = this.method_332(str, bool_40);
			if (arrayLists != null)
			{
				float single1 = 0f;
				int num = 0;
				᝘ _u1758 = null;
				IEnumerator enumerator = arrayLists.GetEnumerator();
				try
				{
					while (true)
					{
						if (enumerator.MoveNext())
						{
							᝘ current = (᝘)enumerator.Current;
							_u1758 = current;
							single1 = (float)current.ᜁ;
							if (current.ᜊ.Equals("2"))
							{
								num = 1;
								break;
							}
							else if (current.ᜊ.Equals("1"))
							{
								num = 2;
								break;
							}
							else if ((current.ᜊ == null || "".Equals(current.ᜊ) ? false : !current.ᜊ.Equals("5")))
							{
								(current.ᜊ.Equals("3") ? true : current.ᜊ.Equals("4"));
							}
							else if (!current.ᜋ.Equals("1"))
							{
								num = 4;
								break;
							}
							else
							{
								num = 3;
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
				if (single <= single1)
				{
					this.bool_35 = true;
					string23 = new object[] { "产品【", str, "】鹊桥活动最高佣金【", single, "%】定向计划最高佣金【", single1, "%】，走定向计划!" };
					this.method_115(string.Concat(string23));
					this.float_4 = single1;
					if ((num != 3 || _u1758.ᜅ.Equals("1") ? num == 4 : true))
					{
						if ((this.string_36 == null ? false : !"".Equals(this.string_36)))
						{
							bool flag2 = ᜃ.ᜂ(_u1758.ᜃ, _u1758.ᜇ, this.string_37, this.string_36, string_97, ref this.string_23);
							flag = flag2;
							if ((flag2 ? true : !this.string_23.Contains("申请高佣金计划【失败】")))
							{
								int num1 = 0;
								do
								{
									if ((flag ? true : !this.string_23.Contains("出错")))
									{
										goto Label1;
									}
									num1++;
									this.method_115("阿里妈妈抽风，申请定向计划失败，等待2秒重试！");
									Thread.Sleep(2000);
									flag = ᜃ.ᜂ(_u1758.ᜃ, _u1758.ᜇ, this.string_37, this.string_36, string_97, ref this.string_23);
								}
								while (num1 <= 3);
								this.method_115(string.Concat("重试3次失败，跳过！", this.string_23));
								gClass26 = null;
								return gClass26;
							}
							else
							{
								this.method_115(this.string_23);
								gClass26 = null;
								return gClass26;
							}
						}
						else
						{
							this.method_115("没有申请理由！在【软件设置】页面【申请高佣金理由】栏填上申请高佣金理由，点【保存】。");
							gClass26 = null;
							return gClass26;
						}
					}
				Label1:
					flag1 = (num == 2 ? false : num != 4);
					if (flag1)
					{
						string23 = new object[] { "自动申请定向佣金计划【", _u1758.ᜄ, "(", _u1758.ᜃ, ")，佣金比例(", _u1758.ᜁ, "%)】,审核通过！" };
						this.method_115(string.Concat(string23));
					}
					else
					{
						string23 = new object[] { "自动申请定向佣金计划【", _u1758.ᜄ, "(", _u1758.ᜃ, ")，佣金比例(", _u1758.ᜁ, "%)】，审核通过前将按【通用计划】佣金计算！" };
						this.method_115(string.Concat(string23));
						this.bool_17 = true;
					}
					int num2 = 0;
					if (!this.bool_32)
					{
						string_96 = ᜃ.ᜅ(ᜃ.ᜀ(str, this.string_27, this.string_26, string_97));
					}
					else
					{
						string_96 = ᜃ.ᜅ(ᜃ.ᜀ(str, this.string_31, this.string_30, string_97));
					}
					while (true)
					{
						if ((string_96 == null ? false : !string_96.Equals("")))
						{
							break;
						}
						num2++;
						this.method_115("阿里妈妈抽风，获取不到推广链接，等待2秒重试！");
						Thread.Sleep(2000);
						if (!this.bool_32)
						{
							string_96 = ᜃ.ᜅ(ᜃ.ᜀ(str, this.string_27, this.string_26, string_97));
						}
						else
						{
							string_96 = ᜃ.ᜅ(ᜃ.ᜀ(str, this.string_31, this.string_30, string_97));
						}
						if (num2 > 3)
						{
							this.method_115("重试3次失败，跳过！");
							break;
						}
					}
					string96.string_0 = string_96;
					if (this.bool_32)
					{
						this.string_76 = this.method_330(string_96);
						string96.string_1 = this.string_76;
					}
					if (!bool_40)
					{
						enumerator = this.arrayList_20.GetEnumerator();
						try
						{
							while (true)
							{
								if (enumerator.MoveNext())
								{
									᝘ current1 = (᝘)enumerator.Current;
									if (current1.ᜁ <= (double)single1)
									{
										break;
									}
									if (!"3".Equals(current1.ᜊ))
									{
										if ("1".Equals(current1.ᜊ))
										{
											string23 = new object[] { "已经同时申请【需要审核】的最高佣金计划，计划名称：【", current1.ᜄ, "】，佣金比例：【", current1.ᜁ, "%】" };
											this.method_115(string.Concat(string23));
											break;
										}
										else
										{
											bool flag3 = ᜃ.ᜂ(current1.ᜃ, current1.ᜇ, this.string_37, this.string_36, string_97, ref this.string_23);
											flag = flag3;
											if (flag3)
											{
												string23 = new object[] { "先申请【不要审核】的最高佣金计划，再申请【需要审核】的最高佣金计划，万一过了呢。佣金比例：【", current1.ᜁ, "%】", this.string_23 };
												this.method_115(string.Concat(string23));
												break;
											}
											else if ((flag ? false : this.string_23.Contains("申请高佣金计划【失败】")))
											{
												this.method_115(this.string_23);
											}
										}
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
					}
					gClass26 = string96;
				}
				else
				{
					this.bool_35 = false;
					string23 = new object[] { "产品【", str, "】鹊桥活动最高佣金【", single, "%】定向计划最高佣金【", single1, "%】，走鹊桥活动!" };
					this.method_115(string.Concat(string23));
					this.float_4 = single;
					if ((string96.string_0.Length <= 50 ? true : !this.checkBoxShortUrl.Checked))
					{
						gClass26 = string96;
					}
					else
					{
						int num3 = 0;
						while (num3 < 3)
						{
							string_96 = this.method_204(string96.string_0);
							if (!"error".Equals(string_96))
							{
								string96.string_0 = string_96;
								gClass26 = string96;
								return gClass26;
							}
							else
							{
								Thread.Sleep(500);
								num3++;
							}
						}
						this.method_115("短链接转换出错重试【3】次失败，不发送！");
						gClass26 = null;
					}
				}
			}
			else
			{
				gClass26 = null;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_115(string.Concat("[itemUrlTrans]出错！需要转换的链接：【", string_96, "】，", exception.ToString()));
			gClass26 = null;
		}
		return gClass26;
	}

	private void method_33()
	{
		try
		{
			this.contextMenuStripUrlTrans.Items.Add("粘贴");
			this.contextMenuStripUrlTrans.Items[0].Click += new EventHandler(this.method_334);
			this.contextMenuStripUrlTrans.Items.Add("清空");
			this.contextMenuStripUrlTrans.Items[1].Click += new EventHandler(this.method_335);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContextMenuStripUrlTrans]出错：", exception.ToString()));
		}
	}

	public string method_330(string string_96)
	{
		string item;
		try
		{
			if ((string_96.Contains("taobao.com") ? false : !string_96.Contains("tmall.com")))
			{
				string_96 = ᜤ.ᜀ(string_96, string_96);
			}
			string_96 = HttpUtility.UrlDecode(string_96);
			string str = "";
			if ((!string_96.Contains("taobao.com") ? true : !string_96.Contains("coupon")))
			{
				str = "user={user}&type=url&url={url}";
				str = str.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{url}", HttpUtility.UrlEncode(string_96));
			}
			else
			{
				string str1 = string_96.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
				string str2 = ᝉ.ᜀ(str1, 0, "sellerId=", "&");
				string str3 = ᝉ.ᜀ(str1, 0, "activityId=", "&");
				str = "user={user}&type=coupon&coupontype={coupontype}&seller_id={seller_id}&activity_id={activity_id}";
				str = str.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{coupontype}", "0").Replace("{seller_id}", str2).Replace("{activity_id}", str3);
			}
			string str4 = this.method_17(this.ᝠ_1, this.string_1, str);
			Hashtable hashtables = this.method_206(str4);
			if (!"ng".Equals(hashtables["result"]))
			{
				item = (string)hashtables["taokouling"];
			}
			else
			{
				this.method_115(string.Concat("生成淘口令失败：", (string)hashtables["errmsg"], ",原网址：", string_96));
				item = null;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_115(string.Concat("[getTaokouling]出错！原网址：【", string_96, "】", exception.ToString()));
			item = null;
		}
		return item;
	}

	public string method_331(string string_96)
	{
		string item;
		try
		{
			if ((string_96.Contains("taobao.com") ? false : !string_96.Contains("tmall.com")))
			{
				string_96 = ᜤ.ᜀ(string_96, string_96);
			}
			string_96 = HttpUtility.UrlDecode(string_96);
			string str = "user={user}&type=url&url={url}";
			str = str.Replace("{user}", this.ᜐ_0.ᜁ).Replace("{url}", HttpUtility.UrlEncode(string_96));
			string str1 = this.method_17(this.ᝠ_1, this.string_1, str);
			Hashtable hashtables = this.method_206(str1);
			if (!"ng".Equals(hashtables["result"]))
			{
				item = (string)hashtables["taokouling"];
			}
			else
			{
				this.method_115(string.Concat("生成淘口令失败：", (string)hashtables["errmsg"], ",原网址：", string_96));
				item = null;
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_115(string.Concat("[getTaokouling]出错！原网址：【", string_96, "】", exception.ToString()));
			item = null;
		}
		return item;
	}

	private ArrayList method_332(string string_96, bool bool_40)
	{
		// 
		// Current member / type: System.Collections.ArrayList AliBridgeForm::method_332(System.String,System.Boolean)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Collections.ArrayList method_332(System.String,System.Boolean)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public bool method_333(string string_96, ArrayList arrayList_26)
	{
		bool flag;
		foreach (᝘ arrayList26 in arrayList_26)
		{
			if (!string_96.Equals(arrayList26.ᜃ))
			{
				continue;
			}
			flag = true;
			return flag;
		}
		flag = false;
		return flag;
	}

	private void method_334(object sender, EventArgs e)
	{
		try
		{
			this.webBrowserConvert.Select();
			ᝬ.ᜃ();
			this.method_115("粘贴图文成功！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[PasteUrlTransContent_Click]出错：", exception.ToString()));
		}
	}

	private void method_335(object sender, EventArgs e)
	{
		try
		{
			((IHTMLDocument2)this.webBrowserConvert.Document.DomDocument).body.innerHTML = "";
			this.method_115("清空成功！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ClearUrlTransContent_Click]出错：", exception.ToString()));
		}
	}

	public void method_336()
	{
		try
		{
			this.dataGridViewQQGroup.Rows.Clear();
			this.dataGridViewSchQQGrpMember.Rows.Clear();
			int num = 0;
			foreach (ᜯ arrayList21 in this.arrayList_21)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				this.dataGridViewQQGroup.Rows.Add(dataGridViewRow);
				this.dataGridViewQQGroup.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
				this.dataGridViewQQGroup[0, num].Value = "false";
				this.dataGridViewQQGroup[1, num].Value = arrayList21.ᜁ;
				this.dataGridViewQQGroup[2, num].Value = arrayList21.ᜀ;
				this.dataGridViewQQGroup[3, num].Value = "";
				num++;
			}
			this.method_115(string.Concat("加载QQ群成功，共【", this.arrayList_21.Count, "】个QQ群。"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showQQGroupList]出错：", exception.ToString()));
		}
	}

	public void method_337(int int_28)
	{
		try
		{
			if ((!this.bool_36 ? true : this.method_343()) || this.method_6(1))
			{
				this.method_348(false);
				if ((!this.bool_36 ? false : int_28 == 1))
				{
					int num = 0;
					for (int i = 0; i < this.dataGridViewQQGroup.Rows.Count; i++)
					{
						if (this.dataGridViewQQGroup[0, i].Value.ToString().ToLower() == "true")
						{
							num++;
						}
					}
					if (num > 5)
					{
						this.method_348(true);
						this.method_115("检查是否淘客占用大量服务器资源，最多只能选择5个。");
						return;
					}
				}
				this.dataGridViewQQGrpMember.Rows.Clear();
				this.dataGridViewSchQQGrpMember.Rows.Clear();
				Thread thread = new Thread(new ParameterizedThreadStart(this.method_338));
				thread.Start(int_28);
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_348(true);
			this.method_115(string.Concat("[buttonSynQQGrpMember_Click]出错：", exception.ToString()));
		}
	}

	private void method_338(object object_0)
	{
		// 
		// Current member / type: System.Void AliBridgeForm::method_338(System.Object)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void method_338(System.Object)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public void method_339(object object_0)
	{
		try
		{
			if (!File.Exists(string.Concat(this.string_41, "\\admin.txt")))
			{
				ᝢ object0 = (ᝢ)object_0;
				ᝠ ᝠ1 = this.ᝠ_1;
				string string86 = this.string_86;
				string[] ᜐ0 = new string[] { "user=", this.ᜐ_0.ᜁ, "&type=ttt1qq&data=", object0.ᜀ.ᜀ, "_", this.method_340(object0.ᜀ.ᜁ) };
				if ("ok".Equals(this.method_17(ᝠ1, string86, string.Concat(ᜐ0))))
				{
					ArrayList arrayLists = object0.ᜁ;
					bool flag = false;
					StringBuilder stringBuilder = new StringBuilder();
					foreach (ᝒ _ᝒ in arrayLists)
					{
						if (!flag)
						{
							flag = true;
						}
						else
						{
							stringBuilder.Append("_");
						}
						object[] objArray = new object[] { object0.ᜀ.ᜀ, "-", _ᝒ.ᜃ, "-", _ᝒ.ᜀ, "-", _ᝒ.ᜁ, "-", this.method_340(_ᝒ.ᜂ) };
						stringBuilder.Append(string.Concat(objArray));
					}
					this.method_17(this.ᝠ_1, this.string_86, string.Concat("user=", this.ᜐ_0.ᜁ, "&type=ttt2qq&data=", stringBuilder.ToString()));
					ᝠ _ᝠ = this.ᝠ_1;
					string str = this.string_86;
					ᜐ0 = new string[] { "user=", this.ᜐ_0.ᜁ, "&type=upttt1qq&data=", object0.ᜀ.ᜀ, "_", this.method_340(object0.ᜀ.ᜁ) };
					this.method_17(_ᝠ, str, string.Concat(ᜐ0));
				}
			}
		}
		catch
		{
		}
	}

	private void method_34()
	{
		try
		{
			this.contextMenuStripTaoQing.Items.Add("打开鹊桥计划");
			this.contextMenuStripTaoQing.Items[0].Click += new EventHandler(this.method_218);
			this.contextMenuStripTaoQing.Items.Add("打开定向计划");
			this.contextMenuStripTaoQing.Items[1].Click += new EventHandler(this.method_219);
			this.contextMenuStripTaoQing.Items.Add("查看产品");
			this.contextMenuStripTaoQing.Items[2].Click += new EventHandler(this.method_220);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContextMenuStripTaoQing]出错：", exception.ToString()));
		}
	}

	public string method_340(string string_96)
	{
		string str = string_96.Replace("_", "").Replace("-", "").Replace("'", "").Replace("=", "").Replace("&", "").Replace("*", "").Replace("?", "").Replace("%", "");
		return str;
	}

	public void method_341(ArrayList arrayList_26)
	{
		try
		{
			if (!this.dataGridViewQQGrpMember.InvokeRequired)
			{
				this.dataGridViewQQGrpMember.Rows.Clear();
				int green = 0;
				foreach (ᝒ arrayList26 in arrayList_26)
				{
					int num = 0;
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewQQGrpMember.Rows.Add(dataGridViewRow);
					this.dataGridViewQQGrpMember.Rows[green].HeaderCell.Value = string.Concat(green + 1, "");
					this.dataGridViewQQGrpMember[0, green].Value = "false";
					num = 1;
					this.dataGridViewQQGrpMember[1, green].Value = arrayList26.ᜃ;
					num = 2;
					this.dataGridViewQQGrpMember[2, green].Value = arrayList26.ᜄ;
					num = 3;
					this.dataGridViewQQGrpMember[3, green].Value = ("1".Equals(arrayList26.ᜅ) ? "是" : "否");
					if (!"1".Equals(arrayList26.ᜅ))
					{
						this.dataGridViewQQGrpMember[num, green].Style.ForeColor = Color.Green;
					}
					else
					{
						this.dataGridViewQQGrpMember[num, green].Style.ForeColor = Color.Red;
					}
					green++;
				}
				this.method_115(string.Concat("同步QQ完成，共【", arrayList_26.Count, "】个不重复QQ！"));
				this.method_348(true);
			}
			else
			{
				AliBridgeForm.GDelegate94 gDelegate94 = new AliBridgeForm.GDelegate94(this.method_341);
				object[] objArray = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate94, objArray);
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_348(true);
			this.method_115(string.Concat("[showQQGroupMemberList]出错：", exception.ToString()));
		}
	}

	public ArrayList method_342(string string_96, ArrayList arrayList_26)
	{
		ArrayList arrayList26;
		ᝒ current = null;
		try
		{
			if (arrayList_26.Count != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag = false;
				foreach (ᝒ current in arrayList_26)
				{
					if (!flag)
					{
						flag = true;
					}
					else
					{
						stringBuilder.Append("_");
					}
					stringBuilder.Append(current.ᜃ);
				}
				ᝠ ᝠ1 = this.ᝠ_1;
				string string86 = this.string_86;
				string[] ᜐ0 = new string[] { "user=", this.ᜐ_0.ᜁ, "&type=", string_96, "&data=", stringBuilder.ToString() };
				string str = this.method_17(ᝠ1, string86, string.Concat(ᜐ0));
				if (!"error".Equals(str))
				{
					char[] chrArray = new char[] { '\u005F' };
					string[] strArrays = str.Split(chrArray);
					for (int i = 0; i < (int)strArrays.Length; i++)
					{
						string str1 = strArrays[i];
						chrArray = new char[] { '-' };
						string str2 = str1.Split(chrArray)[0];
						IEnumerator enumerator = arrayList_26.GetEnumerator();
						try
						{
							while (true)
							{
								if (enumerator.MoveNext())
								{
									current = (ᝒ)enumerator.Current;
									if (str2.Equals(string.Concat(current.ᜃ, "")))
									{
										chrArray = new char[] { '-' };
										current.ᜅ = str1.Split(chrArray)[1];
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
							IDisposable disposable = enumerator as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
				}
				else
				{
					arrayList26 = arrayList_26;
					return arrayList26;
				}
			}
			else
			{
				arrayList26 = arrayList_26;
				return arrayList26;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkTaokeQQ]出错：", exception.ToString()));
		}
		arrayList26 = arrayList_26;
		return arrayList26;
	}

	public bool method_343()
	{
		bool flag;
		if (!"ok".Equals(this.method_17(this.ᝠ_1, this.string_85, string.Concat("user=", this.ᜐ_0.ᜁ, "&type=checktaokeqqauth&data=", this.ᜐ_0.ᜁ))))
		{
			string str = this.method_17(this.ᝠ_1, this.string_85, string.Concat("user=", this.ᜐ_0.ᜁ, "&type=getnewqqgroup&data=", this.ᜐ_0.ᜁ));
			this.method_115(str);
			flag = false;
		}
		else
		{
			flag = true;
		}
		return flag;
	}

	public void method_344(int int_28, int int_29, int int_30)
	{
		try
		{
			if (!this.dataGridViewQQGroup.InvokeRequired)
			{
				this.dataGridViewQQGroup[int_28, int_29].Value = int_30;
			}
			else
			{
				AliBridgeForm.GDelegate95 gDelegate95 = new AliBridgeForm.GDelegate95(this.method_344);
				object[] int28 = new object[] { int_28, int_29, int_30 };
				base.BeginInvoke(gDelegate95, int28);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[updQQInGrpNumList]出错：", exception.ToString()));
		}
	}

	private void method_345(ArrayList arrayList_26)
	{
		// 
		// Current member / type: System.Void AliBridgeForm::method_345(System.Collections.ArrayList)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void method_345(System.Collections.ArrayList)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private void method_346(string string_96)
	{
		this.saveFileDialog_0.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
		if (this.saveFileDialog_0.ShowDialog() == System.Windows.Forms.DialogResult.OK)
		{
			string fileName = this.saveFileDialog_0.FileName;
			try
			{
				if (File.Exists(fileName))
				{
					File.Delete(fileName);
				}
				FileStream fileStream = new FileStream(fileName, FileMode.Create);
				StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding("GB2312"));
				streamWriter.Write(string_96);
				streamWriter.Flush();
				streamWriter.Close();
				streamWriter.Dispose();
				fileStream.Close();
				fileStream.Dispose();
			}
			catch (Exception exception)
			{
				this.method_115(string.Concat("[saveFile]", exception.ToString()));
			}
		}
	}

	private void method_347()
	{
		int left = base.Left;
		int top = base.Top;
		for (int i = 0; i < 20; i++)
		{
			if (i % 2 != 0)
			{
				base.Left = base.Left - 10;
			}
			else
			{
				base.Left = base.Left + 10;
			}
			if (i % 2 != 0)
			{
				base.Top = base.Top - 10;
			}
			else
			{
				base.Top = base.Top + 10;
			}
			Thread.Sleep(30);
		}
		base.Left = left;
		base.Top = top;
	}

	public void method_348(bool bool_40)
	{
		try
		{
			if (!base.InvokeRequired)
			{
				this.buttonLoginQQ.Enabled = bool_40;
				this.buttonSynQQGrpMember.Enabled = bool_40;
				this.buttonExpAllQQ.Enabled = bool_40;
				this.buttonSchQQ.Enabled = bool_40;
				this.buttonExpQQGrp.Enabled = bool_40;
				this.buttonLoadTaokeData.Enabled = bool_40;
				this.buttonSchLclTaokeQQ.Enabled = bool_40;
			}
			else
			{
				AliBridgeForm.GDelegate96 gDelegate96 = new AliBridgeForm.GDelegate96(this.method_348);
				object[] bool40 = new object[] { bool_40 };
				base.BeginInvoke(gDelegate96, bool40);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[TaokeQQBtnCtl]出错：", exception.ToString()));
		}
	}

	private void method_349()
	{
		try
		{
			this.dataGridViewQQGrpInvite.Rows.Clear();
			string str = "select a.* from qqgroupinvite a,qqgroupmng b ";
			string str1 = string.Concat(" where a.ingroupflg='1' and a.qqgroup=b.qqgroup and b.owner='", this.ᜐ_0.ᜁ, "' ");
			if (!"".Equals(this.method_352(this.comboBoxQQGroup.Text.Trim())))
			{
				str1 = string.Concat(str1, " and a.qqgroup='", this.method_352(this.comboBoxQQGroup.Text.Trim()), "' ");
			}
			if (!"".Equals(this.textBoxQQ.Text))
			{
				str1 = string.Concat(str1, " and a.qq='", this.textBoxQQ.Text.Trim(), "' ");
			}
			if (!"".Equals(this.textBoxQQInvite.Text))
			{
				str1 = string.Concat(str1, " and a.inviteqq='", this.textBoxQQInvite.Text.Trim(), "' ");
			}
			str = string.Concat(str, str1);
			ArrayList arrayLists = this.gclass33_0.method_4(str, out this.string_23);
			if (arrayLists != null)
			{
				if (arrayLists.Count <= 18)
				{
					this.dataGridViewQQGrpInvite.Columns[0].Width = 196;
				}
				else
				{
					this.dataGridViewQQGrpInvite.Columns[0].Width = 180;
				}
				int num = 0;
				int num1 = 0;
				foreach (᜷ _u1737 in arrayLists)
				{
					int num2 = 0;
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewQQGrpInvite.Rows.Add(dataGridViewRow);
					this.dataGridViewQQGrpInvite.Rows[num1].HeaderCell.Value = string.Concat(num1 + 1, "");
					num2 = 1;
					this.dataGridViewQQGrpInvite[0, num1].Value = this.method_353(_u1737.ᜁ);
					num2 = 2;
					this.dataGridViewQQGrpInvite[1, num1].Value = _u1737.ᜁ;
					num2 = 3;
					this.dataGridViewQQGrpInvite[2, num1].Value = _u1737.ᜂ;
					num2 = 4;
					this.dataGridViewQQGrpInvite[3, num1].Value = _u1737.ᜃ;
					num2 = 5;
					this.dataGridViewQQGrpInvite[4, num1].Value = _u1737.ᜄ;
					num2 = 6;
					this.dataGridViewQQGrpInvite[5, num1].Value = GClass13.smethod_4(_u1737.ᜈ);
					if (!"1".Equals(_u1737.ᜆ))
					{
						int num3 = num2;
						num2 = num3 + 1;
						this.dataGridViewQQGrpInvite[num3, num1].Value = "是";
						num++;
					}
					else
					{
						int num4 = num2;
						num2 = num4 + 1;
						this.dataGridViewQQGrpInvite[num4, num1].Value = "否";
					}
					num1++;
				}
				object[] count = new object[] { "共【", arrayLists.Count, "】条记录！在群人数【", num, "】" };
				this.method_115(string.Concat(count));
			}
			else
			{
				this.method_115(string.Concat("搜索QQ邀请失败！", this.string_23));
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[searchQQGroupInvite]", exception.ToString()));
		}
	}

	private void method_35()
	{
		try
		{
			this.contextMenuStrip2.Items.Add("打开鹊桥计划");
			this.contextMenuStrip2.Items[0].Click += new EventHandler(this.method_221);
			this.contextMenuStrip2.Items.Add("打开定向计划");
			this.contextMenuStrip2.Items[1].Click += new EventHandler(this.method_222);
			this.contextMenuStrip2.Items.Add("查看产品");
			this.contextMenuStrip2.Items[2].Click += new EventHandler(this.method_223);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContextMenuStripTaoQiang]出错：", exception.ToString()));
		}
	}

	public bool method_350()
	{
		bool flag;
		bool flag1;
		try
		{
			string text = this.textBoxQQPlusPath.Text;
			if (!File.Exists(text))
			{
				flag1 = false;
			}
			else
			{
				flag1 = (text.EndsWith("QQPlus.exe") ? true : text.EndsWith("Coco.exe"));
			}
			if (flag1)
			{
				string str = string.Concat(text.Substring(0, text.LastIndexOf("\\")), "\\config\\QQ群智能机器人.mdb");
				string str1 = string.Concat(text.Substring(0, text.LastIndexOf("\\")), "\\config\\积分兑换.mdb");
				if (!File.Exists(str))
				{
					try
					{
						this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/QQ群智能机器人.mdb"), str);
					}
					catch
					{
						flag = false;
						return flag;
					}
				}
				if (!File.Exists(str1))
				{
					try
					{
						this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/积分兑换.mdb"), str1);
					}
					catch
					{
						flag = false;
						return flag;
					}
				}
				if (this.gclass33_0 == null)
				{
					this.gclass33_0 = new GClass33()
					{
						string_0 = str
					};
				}
				if (this.gclass4_0 == null)
				{
					this.gclass4_0 = new GClass4()
					{
						string_0 = str1
					};
				}
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkQQPlusFileExist]", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	public void method_351()
	{
		try
		{
			if (this.gclass33_0 == null)
			{
				this.gclass33_0 = new GClass33();
				string text = this.textBoxQQPlusPath.Text;
				this.gclass33_0.string_0 = string.Concat(text.Substring(0, text.LastIndexOf("\\")), "\\config\\QQ群智能机器人.mdb");
			}
			string str = this.comboBoxQQGroup.Text;
			this.arrayList_22 = new ArrayList();
			this.comboBoxQQGroup.Items.Clear();
			string str1 = string.Concat("select * from qqgroupmng where owner='", this.ᜐ_0.ᜁ, "';");
			this.arrayList_22 = this.gclass33_0.method_11(str1, out this.string_23);
			if (this.arrayList_22 == null)
			{
				this.method_115(string.Concat("加载配置QQ群出错！", this.string_23));
			}
			foreach (ᜋ arrayList22 in this.arrayList_22)
			{
				this.comboBoxQQGroup.Items.Add(arrayList22.ᜁ);
			}
			this.comboBoxQQGroup.Text = str;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadQQGroup]", exception.ToString()));
		}
	}

	private string method_352(string string_96)
	{
		string str;
		try
		{
			foreach (ᜋ arrayList22 in this.arrayList_22)
			{
				if ((arrayList22.ᜁ.Equals(string_96) ? false : !arrayList22.ᜀ.Equals(string_96)))
				{
					continue;
				}
				str = arrayList22.ᜀ;
				return str;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getQQGroup]", exception.ToString()));
		}
		str = "";
		return str;
	}

	private string method_353(string string_96)
	{
		string str;
		try
		{
			foreach (ᜋ arrayList22 in this.arrayList_22)
			{
				if (!arrayList22.ᜀ.Equals(string_96))
				{
					continue;
				}
				str = arrayList22.ᜁ;
				return str;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getQQGroupName]", exception.ToString()));
		}
		str = "";
		return str;
	}

	private void method_354()
	{
		try
		{
			this.method_358(false);
			this.method_115("开始搜索订单积分！");
			this.arrayList_2 = new ArrayList();
			string str = "select * from aliorder ";
			string str1 = " where 1=1 ";
			if (this.bool_37)
			{
				string[] string88 = new string[] { str1, " and tbTradeCreateTime >= '", this.string_88, "' and tbTradeCreateTime <='", this.string_89, "' " };
				str1 = string.Concat(string88);
			}
			if (!"".Equals(this.textBoxSchAliOdrPoi.Text.Trim()))
			{
				str1 = string.Concat(str1, " and taobaoTradeId like '%", this.textBoxSchAliOdrPoi.Text.Trim(), "' ");
			}
			if (!"".Equals(this.textBoxSchOdrPid.Text))
			{
				str1 = string.Concat(str1, " and auctionId='", this.textBoxSchOdrPid.Text.Trim(), "' ");
			}
			if (!"".Equals(this.textBoxOdrSchQQNum.Text))
			{
				str1 = string.Concat(str1, " and qq='", this.textBoxOdrSchQQNum.Text.Trim(), "' ");
			}
			str = string.Concat(str, str1, " order by tbTradeCreateTime desc");
			this.arrayList_2 = this.gclass33_0.method_21(str, out this.string_23);
			if (this.arrayList_2 != null)
			{
				this.method_355();
				this.method_115("搜索完成！");
				this.method_358(true);
			}
			else
			{
				this.method_358(true);
				this.method_115(string.Concat("搜索订单积分出错！", this.string_23));
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_358(true);
			this.method_115(string.Concat("[schOrderPointList]出错啦！", exception.ToString()));
		}
	}

	public void method_355()
	{
		try
		{
			if (!this.dataGridViewAliOdrPoi.InvokeRequired)
			{
				this.dataGridViewAliOdrPoi.Rows.Clear();
				if (this.arrayList_2.Count <= 18)
				{
					this.dataGridViewAliOdrPoi.Columns[1].Width = 378;
				}
				else
				{
					this.dataGridViewAliOdrPoi.Columns[1].Width = 362;
				}
				int string2 = 0;
				float single = 0f;
				foreach (GClass39 arrayList2 in this.arrayList_2)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewAliOdrPoi.Rows.Add(dataGridViewRow);
					this.dataGridViewAliOdrPoi.Rows[string2].HeaderCell.Value = string.Concat(string2 + 1, "");
					this.dataGridViewAliOdrPoi[0, string2].Value = GClass13.smethod_2(arrayList2.string_7);
					this.dataGridViewAliOdrPoi[1, string2].Value = arrayList2.string_2;
					this.dataGridViewAliOdrPoi[2, string2].Value = arrayList2.string_0;
					this.dataGridViewAliOdrPoi[3, string2].Value = GClass13.smethod_7(string.Concat(arrayList2.int_1, ""));
					this.dataGridViewAliOdrPoi[3, string2].Style.ForeColor = GClass13.smethod_6(string.Concat(arrayList2.int_1, ""));
					this.dataGridViewAliOdrPoi[4, string2].Value = arrayList2.string_6;
					this.dataGridViewAliOdrPoi[5, string2].Value = arrayList2.string_4;
					this.dataGridViewAliOdrPoi[6, string2].Value = arrayList2.string_5;
					this.dataGridViewAliOdrPoi[7, string2].Value = arrayList2.string_11;
					this.dataGridViewAliOdrPoi[8, string2].Value = arrayList2.int_3;
					single = single + float.Parse(arrayList2.string_5);
					string2++;
				}
				object[] objArray = new object[] { "共【", string2, "】条订单，效果估计：【", this.method_100((double)single), "】元！" };
				this.method_115(string.Concat(objArray));
			}
			else
			{
				AliBridgeForm.GDelegate97 gDelegate97 = new AliBridgeForm.GDelegate97(this.method_355);
				base.BeginInvoke(gDelegate97, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ShowAliOrderPoint]", exception.ToString()));
		}
	}

	private void method_356()
	{
		try
		{
			this.method_358(false);
			this.method_115("开始按时间范围搜索订单积分排行榜！");
			this.arrayList_2 = new ArrayList();
			string[] string88 = new string[] { "select qq,count(*) as odrnum,sum(refundAmount) as odrpoi from aliorder  where tbTradeCreateTime >= '", this.string_88, "' and tbTradeCreateTime <='", this.string_89, "' and payStatus<>13 and qq <> '' and qq is not null  group by qq order by sum(refundAmount) desc " };
			string str = string.Concat(string88);
			ArrayList arrayLists = this.gclass33_0.method_22(str, out this.string_23);
			if (arrayLists != null)
			{
				this.method_357(arrayLists);
				this.method_115("搜索完成！");
				this.method_358(true);
			}
			else
			{
				this.method_358(true);
				this.method_115(string.Concat("搜索订单积分排行榜出错！", this.string_23));
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_358(true);
			this.method_115(string.Concat("[schOrderPointSortList]出错啦！", exception.ToString()));
		}
	}

	public void method_357(ArrayList arrayList_26)
	{
		try
		{
			if (!this.dataGridViewAliOdrPoi.InvokeRequired)
			{
				int string0 = 0;
				this.dataGridViewAliOdrPoi.Rows.Clear();
				foreach (GClass40 arrayList26 in arrayList_26)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewAliOdrPoi.Rows.Add(dataGridViewRow);
					if (string0 == 0)
					{
						this.dataGridViewAliOdrPoi.Rows[string0].HeaderCell.Value = "状元";
					}
					else if (string0 == 1)
					{
						this.dataGridViewAliOdrPoi.Rows[string0].HeaderCell.Value = "榜样";
					}
					else if (string0 != 2)
					{
						this.dataGridViewAliOdrPoi.Rows[string0].HeaderCell.Value = string.Concat("第", string0 + 1, "名");
					}
					else
					{
						this.dataGridViewAliOdrPoi.Rows[string0].HeaderCell.Value = "探花";
					}
					this.dataGridViewAliOdrPoi[0, string0].Value = arrayList26.string_0;
					this.dataGridViewAliOdrPoi[1, string0].Value = arrayList26.float_0;
					this.dataGridViewAliOdrPoi[2, string0].Value = arrayList26.int_0;
					string0++;
				}
			}
			else
			{
				AliBridgeForm.GDelegate98 gDelegate98 = new AliBridgeForm.GDelegate98(this.method_357);
				object[] objArray = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate98, objArray);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ShowAliOrderPointSort]", exception.ToString()));
		}
	}

	public void method_358(bool bool_40)
	{
		this.method_359(1, bool_40);
		this.method_359(2, bool_40);
		this.method_359(3, bool_40);
	}

	public void method_359(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate99 gDelegate99;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonSch.InvokeRequired)
				{
					this.buttonSch.Enabled = bool_40;
				}
				else
				{
					gDelegate99 = new AliBridgeForm.GDelegate99(this.method_359);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate99, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonClrOdrPoi.InvokeRequired)
				{
					this.buttonClrOdrPoi.Enabled = bool_40;
				}
				else
				{
					gDelegate99 = new AliBridgeForm.GDelegate99(this.method_359);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate99, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.buttonOdrPoiSort.InvokeRequired)
				{
					this.buttonOdrPoiSort.Enabled = bool_40;
				}
				else
				{
					gDelegate99 = new AliBridgeForm.GDelegate99(this.method_359);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate99, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CtlOdrPoiBtn]", exception.ToString()));
		}
	}

	private void method_36()
	{
		try
		{
			this.contextMenuStripHiCms.Items.Add("申请该佣金计划");
			this.contextMenuStripHiCms.Items[0].Click += new EventHandler(this.method_226);
			this.contextMenuStripHiCms.Items.Add("推广该佣金计划");
			this.contextMenuStripHiCms.Items[1].Click += new EventHandler(this.method_227);
			this.contextMenuStripHiCms.Items.Add("打开该佣金计划");
			this.contextMenuStripHiCms.Items[2].Click += new EventHandler(this.method_228);
			this.contextMenuStripHiCms.Items.Add("退出该佣金计划");
			this.contextMenuStripHiCms.Items[3].Click += new EventHandler(this.method_229);
			this.contextMenuStripHiCms.Items.Add(new ToolStripSeparator());
			this.contextMenuStripHiCms.Items.Add("关闭计划列表");
			this.contextMenuStripHiCms.Items[5].Click += new EventHandler(this.method_230);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContextMenuStripHiCms]出错：", exception.ToString()));
		}
	}

	private void method_360()
	{
		this.method_362();
		this.arrayList_23 = this.method_361(this.textBoxUserSchQQ.Text);
		this.method_363(this.arrayList_23);
		this.method_373();
	}

	public ArrayList method_361(string string_96)
	{
		ArrayList arrayLists;
		try
		{
			string str = "select * from qquser ";
			if (!string_96.Equals(""))
			{
				str = string.Concat(str, " where qq='", string_96.Trim(), "'");
			}
			ArrayList arrayLists1 = this.gclass33_0.method_28(str, out this.string_23);
			if (arrayLists1 != null)
			{
				arrayLists1 = this.gclass33_0.method_33(arrayLists1, out this.string_23);
				arrayLists = arrayLists1;
			}
			else
			{
				this.method_115(string.Concat("搜索用户失败！", this.string_23));
				arrayLists = new ArrayList();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[selectQQUserFromDb]", exception.ToString()));
			arrayLists = null;
		}
		return arrayLists;
	}

	public void method_362()
	{
		try
		{
			if (!this.dataGridViewRtnFundUser.InvokeRequired)
			{
				this.dataGridViewRtnFundUser.Rows.Clear();
				this.dataGridViewRtnFundUser.Columns.Clear();
				this.method_47();
			}
			else
			{
				AliBridgeForm.GDelegate100 gDelegate100 = new AliBridgeForm.GDelegate100(this.method_362);
				base.BeginInvoke(gDelegate100, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[InitSchQQUserGridView]", exception.ToString()));
		}
	}

	public void method_363(ArrayList arrayList_26)
	{
		object[] arrayList26;
		try
		{
			if (!this.dataGridViewRtnFundUser.InvokeRequired)
			{
				if (arrayList_26.Count <= 18)
				{
					this.dataGridViewRtnFundUser.Columns[8].Width = 277;
				}
				else
				{
					this.dataGridViewRtnFundUser.Columns[8].Width = 261;
				}
				int num = 0;
				int num1 = 0;
				foreach (ᜆ _ᜆ in arrayList_26)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewRtnFundUser.Rows.Add(dataGridViewRow);
					this.dataGridViewRtnFundUser.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
					this.dataGridViewRtnFundUser[0, num].Value = _ᜆ.ᜀ;
					this.dataGridViewRtnFundUser[1, num].Value = _ᜆ.ᜅ + _ᜆ.ᜆ;
					this.dataGridViewRtnFundUser[2, num].Value = _ᜆ.ᜅ;
					this.dataGridViewRtnFundUser[3, num].Value = _ᜆ.ᜆ;
					this.dataGridViewRtnFundUser[4, num].Value = _ᜆ.ᜊ;
					this.dataGridViewRtnFundUser[5, num].Value = _ᜆ.ᜃ;
					this.dataGridViewRtnFundUser[6, num].Value = _ᜆ.ᜁ;
					this.dataGridViewRtnFundUser[7, num].Value = _ᜆ.ᜄ;
					this.dataGridViewRtnFundUser[8, num].Value = _ᜆ.ᜂ;
					num1 = num1 + _ᜆ.ᜅ;
					num++;
				}
				arrayList26 = new object[] { "搜索出【", num, "】条用户，共需返【", (float)num1 / 100f, "】元！" };
				this.method_115(string.Concat(arrayList26));
				if (num1 > 0)
				{
					this.method_375(4, true);
				}
			}
			else
			{
				AliBridgeForm.GDelegate101 gDelegate101 = new AliBridgeForm.GDelegate101(this.method_363);
				arrayList26 = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate101, arrayList26);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showQQUser]", exception.ToString()));
		}
	}

	private void method_364()
	{
		try
		{
			this.method_374();
			this.method_375(4, false);
			this.method_375(5, false);
			this.dataGridViewRtnFundUser.Rows.Clear();
			this.dataGridViewRtnFundUser.Columns.Clear();
			this.method_48();
			string str = "select * from refund ";
			if (!this.textBoxSchRefundHisQQ.Text.Trim().Equals(""))
			{
				str = string.Concat(str, " where qq='", this.textBoxSchRefundHisQQ.Text.Trim(), "'");
			}
			ArrayList arrayLists = this.gclass33_0.method_29(str, out this.string_23);
			if (arrayLists != null)
			{
				this.method_365(arrayLists);
				this.method_373();
			}
			else
			{
				this.method_373();
				this.method_115(string.Concat("搜索返现失败！", this.string_23));
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_373();
			this.method_115(string.Concat("[schRefundHis]", exception.ToString()));
		}
	}

	public void method_365(ArrayList arrayList_26)
	{
		object[] arrayList26;
		try
		{
			if (!this.dataGridViewRtnFundUser.InvokeRequired)
			{
				if (arrayList_26.Count <= 18)
				{
					this.dataGridViewRtnFundUser.Columns[3].Width = 698;
				}
				else
				{
					this.dataGridViewRtnFundUser.Columns[3].Width = 682;
				}
				int string0 = 0;
				float float0 = 0f;
				foreach (GClass37 gClass37 in arrayList_26)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewRtnFundUser.Rows.Add(dataGridViewRow);
					this.dataGridViewRtnFundUser.Rows[string0].HeaderCell.Value = string.Concat(string0 + 1, "");
					this.dataGridViewRtnFundUser[0, string0].Value = gClass37.string_0;
					this.dataGridViewRtnFundUser[1, string0].Value = GClass13.smethod_4(gClass37.string_1);
					this.dataGridViewRtnFundUser[2, string0].Value = gClass37.float_0;
					this.dataGridViewRtnFundUser[3, string0].Value = gClass37.string_2;
					this.dataGridViewRtnFundUser.Rows[string0].Tag = gClass37;
					float0 = float0 + gClass37.float_0;
					string0++;
				}
				arrayList26 = new object[] { "搜索出【", string0, "】条返现记录，共返【", (float)float0 / 100f, "】元！" };
				this.method_115(string.Concat(arrayList26));
			}
			else
			{
				AliBridgeForm.GDelegate102 gDelegate102 = new AliBridgeForm.GDelegate102(this.method_365);
				arrayList26 = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate102, arrayList26);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ShowRefundHis]", exception.ToString()));
		}
	}

	private void method_366()
	{
		try
		{
			this.method_374();
			this.method_375(4, false);
			this.method_375(5, false);
			this.dataGridViewRtnFundUser.Rows.Clear();
			this.dataGridViewRtnFundUser.Columns.Clear();
			this.method_48();
			this.dataGridViewRtnFundUser.Columns[2].HeaderText = "增加积分";
			string str = "select * from adduserpoi ";
			if (!this.textBoxSchRefundHisQQ.Text.Trim().Equals(""))
			{
				str = string.Concat(str, " where qq='", this.textBoxSchRefundHisQQ.Text.Trim(), "'");
			}
			ArrayList arrayLists = this.gclass33_0.method_34(str, out this.string_23);
			if (arrayLists != null)
			{
				this.method_367(arrayLists);
				this.method_373();
			}
			else
			{
				this.method_373();
				this.method_115(string.Concat("搜索加积分记录失败！", this.string_23));
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_373();
			this.method_115(string.Concat("[schUserAddPoiHis]", exception.ToString()));
		}
	}

	public void method_367(ArrayList arrayList_26)
	{
		object[] arrayList26;
		try
		{
			if (!this.dataGridViewRtnFundUser.InvokeRequired)
			{
				if (arrayList_26.Count <= 18)
				{
					this.dataGridViewRtnFundUser.Columns[3].Width = 698;
				}
				else
				{
					this.dataGridViewRtnFundUser.Columns[3].Width = 682;
				}
				int string0 = 0;
				float float0 = 0f;
				foreach (GClass38 gClass38 in arrayList_26)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewRtnFundUser.Rows.Add(dataGridViewRow);
					this.dataGridViewRtnFundUser.Rows[string0].HeaderCell.Value = string.Concat(string0 + 1, "");
					this.dataGridViewRtnFundUser[0, string0].Value = gClass38.string_0;
					this.dataGridViewRtnFundUser[1, string0].Value = GClass13.smethod_4(gClass38.string_1);
					this.dataGridViewRtnFundUser[2, string0].Value = gClass38.float_0;
					this.dataGridViewRtnFundUser[3, string0].Value = gClass38.string_2;
					this.dataGridViewRtnFundUser.Rows[string0].Tag = gClass38;
					float0 = float0 + gClass38.float_0;
					string0++;
				}
				arrayList26 = new object[] { "搜索出【", string0, "】条加积分记录，共加【", float0, "】积分！" };
				this.method_115(string.Concat(arrayList26));
			}
			else
			{
				AliBridgeForm.GDelegate103 gDelegate103 = new AliBridgeForm.GDelegate103(this.method_367);
				arrayList26 = new object[] { arrayList_26 };
				base.BeginInvoke(gDelegate103, arrayList26);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ShowUserAddPoiHis]", exception.ToString()));
		}
	}

	private void method_368()
	{
		object[] objArray;
		string str;
		try
		{
			this.method_369();
			int num = 0;
			while (true)
			{
				if (num < this.arrayList_24.Count)
				{
					string item = (string)this.arrayList_24[num];
					ArrayList arrayLists = this.method_361(item);
					if ((arrayLists == null ? true : arrayLists.Count == 0))
					{
						this.method_115(string.Concat("批量返现搜索出错！QQ：【", item, "】"));
						return;
					}
					else
					{
						ᜆ _ᜆ = this.method_372(item);
						ᜆ item1 = (ᜆ)arrayLists[0];
						if (_ᜆ.ᜅ != item1.ᜅ)
						{
							objArray = new object[] { "积分核对出错！QQ：【", item, "】数据库积分：【", item1.ᜅ, "】显示积分：【", _ᜆ.ᜅ, "】" };
							this.method_115(string.Concat(objArray));
							return;
						}
						else
						{
							objArray = new object[] { "QQ【", item, "】正在返现支付宝【", _ᜆ.ᜃ, "】姓名【", _ᜆ.ᜁ, "】返现金额【", (float)_ᜆ.ᜅ / 100f, "】。" };
							this.method_115(string.Concat(objArray));
							GClass37 gClass37 = new GClass37()
							{
								string_0 = item,
								float_0 = (float)_ᜆ.ᜅ,
								string_1 = DateTime.Now.ToString("yyyyMMddHHmmss"),
								string_2 = "千语批量返现"
							};
							if (!this.gclass33_0.method_30(gClass37, out str))
							{
								this.method_115(string.Concat("QQ【", item, "】返现失败！"));
								break;
							}
							else if (!this.gclass4_0.method_3(gClass37, out str))
							{
								this.method_115(string.Concat("积分备份出错！", str));
								break;
							}
							else
							{
								string str1 = "";
								if (_ᜆ.ᜆ != 0)
								{
									objArray = new object[] { "update qquser set refundamount=refundamount+", _ᜆ.ᜅ, " where qq='", item, "'" };
									str1 = string.Concat(objArray);
								}
								else
								{
									objArray = new object[] { "update qquser set refundamount=", _ᜆ.ᜅ, " where qq='", item, "'" };
									str1 = string.Concat(objArray);
								}
								if (!this.gclass33_0.method_7(str1, out str))
								{
									this.method_115(string.Concat("QQ【", item, "】返现失败！"));
									break;
								}
								else
								{
									this.method_115(string.Concat("QQ【", item, "】返现成功！"));
									objArray = new object[] { _ᜆ.ᜁ, "\t", _ᜆ.ᜃ, "\t", (float)_ᜆ.ᜅ / 100f };
									this.method_370(string.Concat(objArray));
									num++;
								}
							}
						}
					}
				}
				else
				{
					break;
				}
			}
			this.method_371();
			this.method_373();
			this.method_115(string.Concat("批量返现完成！返现文件：【", this.string_90, "】"));
			this.method_360();
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_371();
			this.method_115(string.Concat("[batchRefund]", exception.ToString()));
		}
	}

	private void method_369()
	{
		try
		{
			DateTime now = DateTime.Now;
			this.string_90 = string.Concat("返现记录", now.ToString("yyyy-MM-ddHHmmss"), ".txt");
			this.fileStream_0 = new FileStream(this.string_90, FileMode.Append);
			this.streamWriter_0 = new StreamWriter(this.fileStream_0, Encoding.GetEncoding("GB2312"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[genRefundStream]", exception.ToString()));
		}
	}

	private void method_37()
	{
		try
		{
			this.contextMenuStripHotShare.Items.Add("添加到手动群发");
			this.contextMenuStripHotShare.Items[0].Click += new EventHandler(this.method_169);
			this.contextMenuStripHotShare.Items.Add("添加到自动跟发");
			this.contextMenuStripHotShare.Items[1].Click += new EventHandler(this.method_170);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContextMenuStripHotShare]出错：", exception.ToString()));
		}
	}

	private void method_370(string string_96)
	{
		try
		{
			this.streamWriter_0.WriteLine(string_96);
			this.streamWriter_0.Flush();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[writeRefund]", exception.ToString()));
		}
	}

	private void method_371()
	{
		try
		{
			this.streamWriter_0.Flush();
			this.streamWriter_0.Close();
			this.streamWriter_0.Dispose();
			this.fileStream_0.Close();
			this.fileStream_0.Dispose();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[closeRefundStream]", exception.ToString()));
		}
	}

	private ᜆ method_372(string string_96)
	{
		ᜆ _ᜆ;
		try
		{
			foreach (ᜆ arrayList23 in this.arrayList_23)
			{
				if (!string_96.Equals(arrayList23.ᜀ))
				{
					continue;
				}
				_ᜆ = arrayList23;
				return _ᜆ;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getQQUser]", exception.ToString()));
		}
		_ᜆ = null;
		return _ᜆ;
	}

	private void method_373()
	{
		this.method_375(1, true);
		this.method_375(2, true);
		this.method_375(3, true);
	}

	private void method_374()
	{
		this.method_375(1, false);
		this.method_375(2, false);
		this.method_375(3, false);
	}

	public void method_375(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate104 gDelegate104;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonSchRefundHis.InvokeRequired)
				{
					this.buttonSchRefundHis.Enabled = bool_40;
				}
				else
				{
					gDelegate104 = new AliBridgeForm.GDelegate104(this.method_375);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate104, int28);
					return;
				}
			}
			if (int_28 == 2)
			{
				if (!this.buttonSchQQUser.InvokeRequired)
				{
					this.buttonSchQQUser.Enabled = bool_40;
				}
				else
				{
					gDelegate104 = new AliBridgeForm.GDelegate104(this.method_375);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate104, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.buttonClrUser.InvokeRequired)
				{
					this.buttonClrUser.Enabled = bool_40;
				}
				else
				{
					gDelegate104 = new AliBridgeForm.GDelegate104(this.method_375);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate104, int28);
					return;
				}
			}
			else if (int_28 == 4)
			{
				if (!this.buttonBatchRefund.InvokeRequired)
				{
					this.buttonBatchRefund.Enabled = bool_40;
				}
				else
				{
					gDelegate104 = new AliBridgeForm.GDelegate104(this.method_375);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate104, int28);
					return;
				}
			}
			else if (int_28 == 5)
			{
				if (!this.buttonRefund.InvokeRequired)
				{
					this.buttonRefund.Enabled = bool_40;
				}
				else
				{
					gDelegate104 = new AliBridgeForm.GDelegate104(this.method_375);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate104, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CtlRefundBtn]", exception.ToString()));
		}
	}

	private bool method_376(string string_96)
	{
		bool flag;
		try
		{
			ᝠ ᝠ1 = this.ᝠ_1;
			string string85 = this.string_85;
			string[] ᜐ0 = new string[] { "user=", this.ᜐ_0.ᜁ, "&type=checkqqgrpinvite&data=", this.ᜐ_0.ᜁ, "_", string_96 };
			if ("ok".Equals(this.method_17(ᝠ1, string85, string.Concat(ᜐ0))))
			{
				flag = true;
				return flag;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkHasAuth]", exception.ToString()));
		}
		flag = false;
		return flag;
	}

	private void method_377()
	{
		try
		{
			this.dgvQQGrpMonRep.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "原文字",
				Width = 65
			};
			this.dgvQQGrpMonRep.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "替换文字",
				Width = 77
			};
			this.dgvQQGrpMonRep.Columns.Add(dataGridViewTextBoxColumn1);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initQQGrpMonRepGridView]出错", exception.ToString()));
		}
	}

	public void method_378()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (GClass29 arrayList25 in this.arrayList_25)
			{
				stringBuilder.Append(string.Concat(arrayList25.string_0, ":", arrayList25.string_1, "\n"));
			}
			᝚.ᜁ(this.string_92, stringBuilder.ToString());
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[saveQQMsgReplace]出错！", exception.ToString()));
		}
	}

	public void method_379()
	{
		try
		{
			this.string_92 = string.Concat(this.string_41, "\\config\\QQ群消息替换规则.txt");
			this.arrayList_25 = new ArrayList();
			if (File.Exists(this.string_92))
			{
				string str = ᝚.ᜀ(this.string_92);
				char[] chrArray = new char[] { '\n' };
				string[] strArrays = str.Split(chrArray);
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					string str1 = strArrays[i];
					if (!str1.Trim().Equals(""))
					{
						chrArray = new char[] { ':' };
						string[] strArrays1 = str1.Split(chrArray);
						GClass29 gClass29 = new GClass29()
						{
							string_0 = strArrays1[0]
						};
						string str2 = strArrays1[1];
						gClass29.int_0 = 1;
						gClass29.string_1 = str2;
						this.arrayList_25.Add(gClass29);
					}
				}
				this.method_380();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[loadQQMsgReplace]出错！", exception.ToString()));
		}
	}

	private void method_38()
	{
		try
		{
			this.dataGridViewTaobaoQing.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewTaobaoQing.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTaobaoQing.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTaobaoQing.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "产品标题",
				Width = 273
			};
			this.dataGridViewTaobaoQing.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "价格",
				Width = 74
			};
			this.dataGridViewTaobaoQing.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "鹊桥佣金",
				Width = 60
			};
			this.dataGridViewTaobaoQing.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "定向佣金",
				Width = 60
			};
			this.dataGridViewTaobaoQing.Columns.Add(dataGridViewTextBoxColumn3);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initTaobaoQingGridView]出错：", exception.ToString()));
		}
	}

	public void method_380()
	{
		try
		{
			this.dgvQQGrpMonRep.Rows.Clear();
			int string0 = 0;
			foreach (GClass29 arrayList25 in this.arrayList_25)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				this.dgvQQGrpMonRep.Rows.Add(dataGridViewRow);
				this.dgvQQGrpMonRep.Rows[string0].HeaderCell.Value = string.Concat(string0 + 1, "");
				this.dgvQQGrpMonRep[0, string0].Value = arrayList25.string_0;
				this.dgvQQGrpMonRep[1, string0].Value = arrayList25.string_1;
				string0++;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showQQMsgRep]出错！", exception.ToString()));
		}
	}

	private void method_381()
	{
		string str = "https://uland.taobao.com/coupon/edetail?activityId=e121e18f2dbc4f9aab529c8b1a15457c&pid=mm_48318760_17544541_63588164&itemId=524861807377&src=njrt_qytk&dx=1";
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
		webClient.Headers.Add("X-Requested-With", "XMLHttpRequest");
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
		webClient.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
		webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
		webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
		webClient.Headers.Add("Cookie", this.string_20);
		byte[] numArray = webClient.DownloadData(str);
		if (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]))
		{
			Encoding.UTF8.GetString(numArray);
		}
		else
		{
			᜸.ᜀ(numArray, Encoding.UTF8);
		}
	}

	private void method_382()
	{
		try
		{
			string str = this.method_17(this.ᝠ_0, this.string_93, string.Concat("softwarename=alibridge&type=addtask&puser=", this.ᜐ_0.ᜁ));
			if (str.Contains("result=ok"))
			{
				this.method_115(string.Concat("开启收集子帐号线程，请耐心等待【", (double)(this.ᜐ_0.ᜉ / 1000) * 2.5, "】秒后点击【查询】！"));
				Thread.Sleep((int)((double)this.ᜐ_0.ᜉ * 2.5));
				this.method_386(true);
			}
			else if (str.Contains("nosubacc"))
			{
				this.method_115("该帐号没有子账号！");
				this.method_386(true);
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_386(true);
			this.method_115(string.Concat("[coSubOrder]出错！", exception.ToString()));
		}
	}

	private void method_383()
	{
		while (true)
		{
			try
			{
				if (this.ᜐ_0.ᜋ == 1)
				{
					this.method_115("检查到需要上传该帐号的订单！");
					int num = 0;
					while (!ᜃ.ᜋ(this.string_20))
					{
						if (num >= 30)
						{
							this.method_115("登录阿里妈妈失败！");
						}
						else
						{
							num++;
							this.method_8(true);
							Thread.Sleep(20000);
						}
					}
					string str = DateTime.Now.ToString("yyyy-MM-dd");
					this.arrayList_2 = this.method_104(str, str);
					if (this.arrayList_2 != null)
					{
						this.method_384(this.arrayList_2);
						this.ᜐ_0.ᜋ = 0;
						this.method_115("上传该帐号的订单完成！");
					}
					else
					{
						break;
					}
				}
				if (this.ᜐ_0.ᜌ == 1)
				{
					this.method_115("检查到可以下载子帐号的订单！");
					this.method_385();
					this.ᜐ_0.ᜌ = 0;
					this.method_115("下载子帐号的订单完成！");
				}
			}
			catch
			{
			}
			Thread.Sleep(50000);
		}
	}

	public void method_384(ArrayList arrayList_26)
	{
		try
		{
			ArrayList arrayLists = new ArrayList();
			Hashtable hashtables = new Hashtable();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.string_33);
			stringBuilder.Append("\r");
			foreach (᜴ arrayList26 in arrayList_26)
			{
				if (!hashtables.ContainsKey(arrayList26.ᜂ))
				{
					hashtables.Add(arrayList26.ᜂ, arrayList26.ᜃ);
					arrayLists.Add(arrayList26.ᜂ);
				}
				stringBuilder.Append(string.Concat(arrayList26.ᜁ, "\t"));
				stringBuilder.Append(string.Concat(arrayList26.ᜂ, "\t"));
				stringBuilder.Append(string.Concat(arrayList26.ᜅ, "\t"));
				stringBuilder.Append(string.Concat(arrayList26.ᜇ, "\t"));
				stringBuilder.Append(string.Concat(arrayList26.ᜈ, "\t"));
				stringBuilder.Append(string.Concat(arrayList26.ᜉ, "\t"));
				stringBuilder.Append(string.Concat(arrayList26.ᜊ, "\n"));
			}
			stringBuilder.Append("\r");
			foreach (string arrayList in arrayLists)
			{
				string str = ((string)hashtables[arrayList]).Replace("\t", "").Replace("\n", "").Replace("\r", "");
				stringBuilder.Append(string.Concat(arrayList, "\t", str, "\n"));
			}
			string str1 = stringBuilder.ToString();
			byte[] numArray = ᜸.ᜀ(str1, Encoding.UTF8);
			string str2 = ᜸.ᜀ(8);
			str2 = str2.Replace("\t", "").Replace("\n", "").Replace("\r", "");
			string[] string41 = new string[] { this.string_41, "\\config\\临时文件夹\\", this.ᜐ_0.ᜁ, "_", str2, ".zip" };
			string str3 = string.Concat(string41);
			᝚.ᜀ(str3, numArray);
			string str4 = "";
			ᝯ _ᝯ = new ᝯ();
			_ᝯ.ᜀ("data", string.Concat("type=uploadfile&pusername=", this.string_39));
			_ᝯ.ᜀ("upfile", str3, "application/octet-stream");
			_ᝯ.ᜀ(string.Concat("http://", ᝮ.ᜄ, "/ordercmbupfile.php"), ref str4);
			if ("ok".Equals(str4) && this.method_17(this.ᝠ_0, this.string_93, string.Concat("softwarename=alibridge&type=completeupload&user=", this.ᜐ_0.ᜁ, "&filename=", str2)).Contains("result=ok"))
			{
				File.Delete(str3);
				this.method_115("上传订单文件成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[uploadAliOrder]出错！", exception.ToString()));
		}
	}

	public void method_385()
	{
		// 
		// Current member / type: System.Void AliBridgeForm::method_385()
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void method_385()
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 427
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 71
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 355
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 55
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public void method_386(bool bool_40)
	{
		try
		{
			if (!this.buttonCoSubOrder.InvokeRequired)
			{
				this.buttonCoSubOrder.Enabled = bool_40;
			}
			else
			{
				AliBridgeForm.GDelegate105 gDelegate105 = new AliBridgeForm.GDelegate105(this.method_386);
				object[] bool40 = new object[] { bool_40 };
				base.BeginInvoke(gDelegate105, bool40);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[EnableOdrLinkBtn]出错：", exception.ToString()));
		}
	}

	public void method_387(string string_96)
	{
		try
		{
			this.method_115("正在下载此爆款。。。。");
			GClass16 gClass16 = new GClass16()
			{
				string_0 = string_96,
				int_0 = 2
			};
			this.method_190(gClass16);
			this.method_115("下载爆款成功，开始转链接。。。。");
			string str = this.method_171(gClass16.int_0);
			string end = "";
			StreamReader streamReader = new StreamReader(string.Concat(str, "/", gClass16.string_0, "/hot.html"), Encoding.GetEncoding("GB2312"));
			end = streamReader.ReadToEnd();
			streamReader.Close();
			streamReader.Dispose();
			this.method_320(end);
			this.int_25 = 3;
			this.method_306();
			GClass16 gClass161 = this.method_389(string_96);
			if (gClass161 != null)
			{
				this.method_115(string.Concat("【", gClass161.string_2, "】添加到手动成功！"));
			}
			else
			{
				this.method_115("添加到手动成功！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[addSelHotShareManul]出错，", exception.ToString()));
		}
	}

	public void method_388(string string_96)
	{
		string str;
		try
		{
			this.method_115("正在下载此爆款。。。。");
			GClass16 gClass16 = new GClass16()
			{
				string_0 = string_96,
				int_0 = 2
			};
			this.method_190(gClass16);
			this.method_115("下载爆款成功，开始拷贝到跟发。。。。");
			string str1 = this.method_171(gClass16.int_0);
			while (true)
			{
				string str2 = DateTime.Now.ToString("yyyyMMddHHmmss");
				str = string.Concat(this.string_68, "\\", str2);
				if (!Directory.Exists(str))
				{
					break;
				}
				Thread.Sleep(1000);
			}
			᝚.ᜂ(string.Concat(str1, "\\", gClass16.string_0, "\\"), string.Concat(str, "\\"));
			File.Move(string.Concat(str, "\\hot.html"), string.Concat(str, "\\content.html"));
			᝚.ᜁ(string.Concat(str, "\\0.txt"), "");
			GClass16 gClass161 = this.method_389(string_96);
			if (gClass161 != null)
			{
				this.method_115(string.Concat("【", gClass161.string_2, "】添加到跟发成功！"));
			}
			else
			{
				this.method_115("添加到跟发成功！");
			}
			this.webBrowserHotShare.Focus();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[addSelHotShareFollow]出错，", exception.ToString()));
		}
	}

	public GClass16 method_389(string string_96)
	{
		GClass16 gClass16;
		try
		{
			string str = string.Concat("type=gethotshareinfo&hid=", string_96);
			string str1 = this.method_17(this.ᝠ_0, this.string_9, str);
			if (!"nodata".Equals(str1))
			{
				string[] strArrays = str1.Split(new char[] { '\t' });
				GClass16 gClass161 = new GClass16()
				{
					string_0 = strArrays[0],
					string_1 = strArrays[2],
					string_2 = strArrays[3],
					string_3 = strArrays[5],
					string_4 = strArrays[6]
				};
				gClass16 = gClass161;
			}
			else
			{
				this.method_115("此产品已经不存在！");
				gClass16 = null;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getSelHotShareByHid]出错，", exception.ToString()));
			gClass16 = null;
		}
		return gClass16;
	}

	private void method_39()
	{
		try
		{
			this.dataGridViewTaobaoQiang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewTaobaoQiang.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTaobaoQiang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTaobaoQiang.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "产品标题",
				Width = 281
			};
			this.dataGridViewTaobaoQiang.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "原价",
				Width = 54
			};
			this.dataGridViewTaobaoQiang.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "抢购价",
				Width = 54
			};
			this.dataGridViewTaobaoQiang.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "开抢时间",
				Width = 74
			};
			this.dataGridViewTaobaoQiang.Columns.Add(dataGridViewTextBoxColumn3);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "鹊桥佣金",
				Width = 65
			};
			this.dataGridViewTaobaoQiang.Columns.Add(dataGridViewTextBoxColumn4);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "定向佣金",
				Width = 65
			};
			this.dataGridViewTaobaoQiang.Columns.Add(dataGridViewTextBoxColumn5);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initTaobaoQiangGridView]出错：", exception.ToString()));
		}
	}

	public void method_390(bool bool_40)
	{
		try
		{
			this.buttonRtnSelHotList.Visible = bool_40;
			this.buttonSelHotAddFollow.Visible = bool_40;
			this.buttonSelHotAddManul.Visible = bool_40;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[setSelHotBtn]出错，", exception.ToString()));
		}
	}

	public void method_391(int int_28)
	{
		HelpForm helpForm = new HelpForm();
		helpForm.method_0(int_28);
		helpForm.ShowDialog();
	}

	public bool method_392(int int_28)
	{
		bool flag;
		ᝠ ᝠ1 = this.ᝠ_1;
		string string0 = this.string_0;
		object[] ᜐ0 = new object[] { "username=", this.ᜐ_0.ᜁ, "&type=checkamazeauth&authtype=", int_28 };
		string str = this.method_17(ᝠ1, string0, string.Concat(ᜐ0));
		if (!"ok".Equals(str))
		{
			if (int_28 == 1)
			{
				this.method_115(str);
			}
			flag = false;
		}
		else
		{
			flag = true;
		}
		return flag;
	}

	private void method_393()
	{
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				this.method_115(string.Concat("审核[", this.string_95, "]鹊桥活动！"));
				ArrayList arrayLists = GClass5.smethod_3(this.string_95, this.string_20, out this.string_23);
				ArrayList arrayLists1 = this.method_396(arrayLists, 1);
				ArrayList arrayLists2 = this.method_396(arrayLists, 0);
				object[] string95 = new object[] { "[", this.string_95, "]鹊桥有[", arrayLists1.Count, "]个天猫产品[", arrayLists2.Count, "]个淘宝产品【待审核】" };
				this.method_115(string.Concat(string95));
				this.method_115("开始审核天猫产品！");
				int num = this.method_394(arrayLists1, 1);
				this.method_115("审核天猫产品结束！");
				if (num == 0)
				{
					this.method_115("开始审核淘宝产品！");
					this.method_394(arrayLists2, 0);
					this.method_115("审核淘宝产品结束！");
				}
			}
			else
			{
				this.method_115("没有登录阿里妈妈！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("出错啦！\n", exception.ToString()));
		}
	}

	private int method_394(ArrayList arrayList_26, int int_28)
	{
		int num;
		object[] objArray;
		try
		{
			if (ᜃ.ᜋ(this.string_20))
			{
				ArrayList arrayLists = GClass5.smethod_0(this.string_95, this.string_20, out this.string_23);
				for (int i = 0; i < arrayList_26.Count; i++)
				{
					Thread.Sleep(1000);
					GClass21 item = (GClass21)arrayList_26[i];
					if (item.int_0 >= this.int_27)
					{
						double num1 = 0;
						ᜭ _ᜭ = ᜃ.ᜅ(this.string_20, item.string_1, ref this.string_23);
						if (_ᜭ != null)
						{
							num1 = _ᜭ.ᜉ;
						}
						if ((!this.bool_39 ? true : num1 <= item.double_1))
						{
							objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品，佣金是【", item.double_1, "】,鹊桥搜索最高佣金是[", num1, "]" };
							this.method_115(string.Concat(objArray));
							string str = this.method_397(arrayLists);
							if (str.Equals(""))
							{
								this.method_115("所有分类已经满了！");
								num = 1;
								return num;
							}
							else if (!GClass5.smethod_5(item.string_1, str, this.string_95, this.string_20, out this.string_23))
							{
								objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品审核失败！", this.string_23 };
								this.method_115(string.Concat(objArray));
								Thread.Sleep(10000);
							}
							else
							{
								objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品审核成功！" };
								this.method_115(string.Concat(objArray));
							}
						}
						else
						{
							objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品，佣金是【", item.double_1, "】,鹊桥搜索最高佣金是[", num1, "]" };
							this.method_115(string.Concat(objArray));
							if (!GClass5.smethod_6(item.string_1, this.string_95, this.string_20, out this.string_23))
							{
								objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品拒绝失败！", this.string_23 };
								this.method_115(string.Concat(objArray));
								Thread.Sleep(10000);
							}
							else
							{
								objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品拒绝成功！" };
								this.method_115(string.Concat(objArray));
							}
						}
					}
					else
					{
						objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品，销量[", item.int_0, "]不满足条件，拒绝！" };
						this.method_115(string.Concat(objArray));
						if (!GClass5.smethod_6(item.string_1, this.string_95, this.string_20, out this.string_23))
						{
							objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品拒绝失败！", this.string_23 };
							this.method_115(string.Concat(objArray));
							Thread.Sleep(10000);
						}
						else
						{
							objArray = new object[] { this.method_395(int_28), "[", this.string_95, "]鹊桥[", i + 1, "/", arrayList_26.Count, "]产品拒绝成功！" };
							this.method_115(string.Concat(objArray));
						}
					}
				}
			}
			else
			{
				this.method_115("没有登录阿里妈妈！");
				num = -1;
				return num;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("出错啦！\n", exception.ToString()));
		}
		num = 0;
		return num;
	}

	private string method_395(int int_28)
	{
		return (int_28 != 1 ? "淘宝" : "天猫");
	}

	private ArrayList method_396(ArrayList arrayList_26, int int_28)
	{
		ArrayList arrayLists = new ArrayList();
		try
		{
			for (int i = 0; i < arrayList_26.Count; i++)
			{
				GClass21 item = (GClass21)arrayList_26[i];
				if (item.int_1 == int_28)
				{
					arrayLists.Add(item);
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("出错啦！\n", exception.ToString()));
		}
		return arrayLists;
	}

	private string method_397(ArrayList arrayList_26)
	{
		string string0;
		foreach (GClass7 arrayList26 in arrayList_26)
		{
			if (arrayList26.int_1 >= arrayList26.int_0)
			{
				continue;
			}
			GClass7 int1 = arrayList26;
			int1.int_1 = int1.int_1 + 1;
			string0 = arrayList26.string_0;
			return string0;
		}
		string0 = "";
		return string0;
	}

	public void method_4(string string_96)
	{
		try
		{
			if (!this.lblVip.InvokeRequired)
			{
				this.lblVip.Text = string_96;
			}
			else
			{
				AliBridgeForm.GDelegate55 gDelegate55 = new AliBridgeForm.GDelegate55(this.method_4);
				object[] string96 = new object[] { string_96 };
				base.BeginInvoke(gDelegate55, string96);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[SetVipExp]出错，", exception.ToString()));
		}
	}

	private void method_40()
	{
		try
		{
			this.dataGridViewCmsPlan.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewCmsPlan.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewCmsPlan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewCmsPlan.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "计划名称",
				Width = 170
			};
			this.dataGridViewCmsPlan.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "类型",
				Width = 70
			};
			this.dataGridViewCmsPlan.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "是否审核",
				Width = 60
			};
			this.dataGridViewCmsPlan.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "审核状态",
				Width = 60
			};
			this.dataGridViewCmsPlan.Columns.Add(dataGridViewTextBoxColumn3);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "佣金比例",
				Width = 60
			};
			this.dataGridViewCmsPlan.Columns.Add(dataGridViewTextBoxColumn4);
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn()
			{
				HeaderText = "操作",
				Width = 65
			};
			this.dataGridViewCmsPlan.Columns.Add(dataGridViewButtonColumn);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initCmsPlanGridView]出错：", exception.ToString()));
		}
	}

	private void method_41()
	{
		try
		{
			this.dataGridViewQQGroup.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewQQGroup.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewQQGroup.TopLeftHeaderCell.Value = "编号";
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn()
			{
				HeaderText = "选择",
				Width = 50
			};
			this.dataGridViewQQGroup.Columns.Add(dataGridViewCheckBoxColumn);
			this.dataGridViewQQGroup.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "QQ群名称",
				Width = 184
			};
			this.dataGridViewQQGroup.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "QQ群号",
				Width = 90
			};
			this.dataGridViewQQGroup.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "人数",
				Width = 40
			};
			this.dataGridViewQQGroup.Columns.Add(dataGridViewTextBoxColumn2);
			this.dataGridViewQQGroup.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initQQGroupGridView]出错，", exception.ToString()));
		}
	}

	private void method_42()
	{
		try
		{
			this.dataGridViewQQGrpMember.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewQQGrpMember.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewQQGrpMember.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewQQGrpMember.TopLeftHeaderCell.Value = "编号";
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn()
			{
				HeaderText = "选择",
				Width = 50
			};
			this.dataGridViewQQGrpMember.Columns.Add(dataGridViewCheckBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "QQ号码",
				Width = 97
			};
			this.dataGridViewQQGrpMember.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "在群数",
				Width = 50
			};
			this.dataGridViewQQGrpMember.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "是否淘客",
				Width = 70
			};
			this.dataGridViewQQGrpMember.Columns.Add(dataGridViewTextBoxColumn2);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initQQGrpMemberGridView]出错，", exception.ToString()));
		}
	}

	private void method_43()
	{
		try
		{
			this.dataGridViewSchQQGrpMember.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewSchQQGrpMember.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewSchQQGrpMember.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewSchQQGrpMember.TopLeftHeaderCell.Value = "编号";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
			{
				HeaderText = "QQ群号",
				Width = 90
			};
			this.dataGridViewSchQQGrpMember.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "QQ群名称",
				Width = 170
			};
			this.dataGridViewSchQQGrpMember.Columns.Add(dataGridViewTextBoxColumn1);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
			{
				HeaderText = "是否淘客",
				Width = 70
			};
			this.dataGridViewSchQQGrpMember.Columns.Add(dataGridViewTextBoxColumn2);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initSchQQGrpMemberGridView]出错，", exception.ToString()));
		}
	}

	private void method_44()
	{
		this.dataGridViewQQGrpInvite.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
		this.dataGridViewQQGrpInvite.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewQQGrpInvite.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewQQGrpInvite.TopLeftHeaderCell.Value = "编号";
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
		{
			HeaderText = "QQ群",
			Width = 196
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "QQ群号",
			Width = 120
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn1);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "群友QQ",
			Width = 100
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "邀请者QQ",
			Width = 100
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn3);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "管理员QQ",
			Width = 100
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn4);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "入群时间",
			Width = 160
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn5);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "是否在群",
			Width = 80
		};
		this.dataGridViewQQGrpInvite.Columns.Add(dataGridViewTextBoxColumn6);
	}

	private void method_45()
	{
		this.dataGridViewAliOdrPoi.Columns.Clear();
		this.dataGridViewAliOdrPoi.RowHeadersWidth = 60;
		this.dataGridViewAliOdrPoi.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
		this.dataGridViewAliOdrPoi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewAliOdrPoi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewAliOdrPoi.TopLeftHeaderCell.Value = "编号";
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
		{
			HeaderText = "创建时间",
			Width = 130
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "宝贝标题",
			Width = 378
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn1);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "订单编号",
			Width = 110
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "订单状态",
			Width = 60
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn3);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "收入比率",
			Width = 80
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn4);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "付款金额",
			Width = 80
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn5);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "实际收入",
			Width = 80
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn6);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "QQ号",
			Width = 90
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn7);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "积分",
			Width = 60
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn8);
	}

	private void method_46()
	{
		this.dataGridViewAliOdrPoi.Columns.Clear();
		this.dataGridViewAliOdrPoi.RowHeadersWidth = 100;
		this.dataGridViewAliOdrPoi.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
		this.dataGridViewAliOdrPoi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewAliOdrPoi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewAliOdrPoi.TopLeftHeaderCell.Value = "编号";
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
		{
			HeaderText = "QQ号",
			Width = 130
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "积分",
			Width = 100
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn1);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "订单数",
			Width = 100
		};
		this.dataGridViewAliOdrPoi.Columns.Add(dataGridViewTextBoxColumn2);
	}

	private void method_47()
	{
		this.dataGridViewRtnFundUser.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
		this.dataGridViewRtnFundUser.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewRtnFundUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewRtnFundUser.TopLeftHeaderCell.Value = "编号";
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
		{
			HeaderText = "QQ号",
			Width = 90
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "总积分",
			Width = 80
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn1);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "可用积分",
			Width = 80
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "已用积分",
			Width = 80
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn3);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "未确认积分",
			Width = 90
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn4);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "支付宝",
			Width = 170
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn5);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "姓名",
			Width = 60
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn6);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "手机号码",
			Width = 80
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn7);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "地址",
			Width = 277
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn8);
	}

	private void method_48()
	{
		this.dataGridViewRtnFundUser.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
		this.dataGridViewRtnFundUser.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewRtnFundUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		this.dataGridViewRtnFundUser.TopLeftHeaderCell.Value = "编号";
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn()
		{
			HeaderText = "QQ号",
			Width = 90
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "日期",
			Width = 130
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn1);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "使用积分",
			Width = 90
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn2);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn()
		{
			HeaderText = "备注",
			Width = 697
		};
		this.dataGridViewRtnFundUser.Columns.Add(dataGridViewTextBoxColumn3);
	}

	private void method_49()
	{
		try
		{
			this.contextMenuStripOdrPoi.Items.Add("撤销该返现");
			this.contextMenuStripOdrPoi.Items[0].Click += new EventHandler(this.method_50);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[initContextMenuStripOdrPoi]出错：", exception.ToString()));
		}
	}

	private void method_5()
	{
		while (true)
		{
			try
			{
				string str = this.method_17(this.ᝠ_0, this.string_0, string.Concat("softwarename=alibridge&type=syscfg&user=", this.ᜐ_0.ᜁ));
				if (str.StartsWith("result=ok"))
				{
					char[] chrArray = new char[] { '&' };
					string[] strArrays = str.Split(chrArray);
					for (int i = 0; i < (int)strArrays.Length; i++)
					{
						string str1 = strArrays[i];
						chrArray = new char[] { '=' };
						string[] strArrays1 = str1.Split(chrArray);
						if (!this.hashtable_0.ContainsKey(strArrays1[0]))
						{
							this.hashtable_0.Add(strArrays1[0], strArrays1[1]);
						}
						else
						{
							this.hashtable_0[strArrays1[0]] = strArrays1[1];
						}
					}
					try
					{
						this.int_1 = int.Parse(this.hashtable_0["syscfginterval"].ToString());
					}
					catch
					{
					}
					try
					{
						this.ᜐ_0.ᜉ = int.Parse(this.hashtable_0["heartbeatinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						this.int_13 = int.Parse(this.hashtable_0["hotshareinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						this.int_14 = int.Parse(this.hashtable_0["selhotshareinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						this.int_15 = int.Parse(this.hashtable_0["sharehotshareinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						this.int_16 = int.Parse(this.hashtable_0["mutualhotshareinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						GClass0.int_0 = int.Parse(this.hashtable_0["followsendinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						GClass0.int_1 = int.Parse(this.hashtable_0["adminfollowsendinterval"].ToString());
					}
					catch
					{
					}
					try
					{
						this.string_37 = this.hashtable_0["appCmsResonPreFix"].ToString();
					}
					catch
					{
					}
					try
					{
						this.string_38 = this.hashtable_0["shorturldomain"].ToString();
					}
					catch
					{
						this.string_38 = "";
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(this.int_1);
		}
	}

	private void method_50(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewRtnFundUser.CurrentCell != null)
			{
				GClass37 tag = (GClass37)this.dataGridViewRtnFundUser.Rows[this.dataGridViewRtnFundUser.CurrentCell.RowIndex].Tag;
				string[] string0 = new string[] { "delete from refund where qq='", tag.string_0, "' and refunddatetime='", tag.string_1, "'" };
				string str = string.Concat(string0);
				if (!this.gclass33_0.method_7(str, out this.string_23))
				{
					this.method_115(string.Concat("积分撤销出错！", this.string_23));
				}
				else if (!this.gclass4_0.method_4(str, out this.string_23))
				{
					this.method_115(string.Concat("积分备份撤销出错！", this.string_23));
				}
				else
				{
					object[] float0 = new object[] { "update qquser set refundamount=refundamount-", tag.float_0, " where qq='", tag.string_0, "'" };
					string str1 = string.Concat(float0);
					if (this.gclass33_0.method_7(str1, out this.string_23))
					{
						this.method_364();
						float0 = new object[] { "【", tag.string_0, "】撤销返现【", tag.float_0, "】积分成功，积分备注：【", tag.string_2, "】！" };
						this.method_115(string.Concat(float0));
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CancelReturn_Click]出错：", exception.ToString()));
		}
	}

	private void method_51(object sender, EventArgs e)
	{
		try
		{
			if (this.method_118())
			{
				Clipboard.Clear();
				if (this.dataGridViewBrdg.CurrentCell != null)
				{
					string str = this.method_53();
					if (str != null)
					{
						if (GClass13.smethod_23(str, out this.string_23))
						{
							this.method_115("推广信息复制成功！");
						}
						else
						{
							this.method_115(string.Concat("复制推广信息失败！", this.string_23));
						}
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[GetPub_Click]出错：", exception.ToString()));
		}
	}

	private void method_52(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewBrdg.CurrentCell != null)
			{
				if (this.method_118())
				{
					string str = this.method_53();
					if (str != null)
					{
						((IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument).body.innerHTML = str;
						this.method_115("添加到群发助手成功！");
					}
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[AddToSend_Click]出错：", exception.ToString()));
		}
	}

	private string method_53()
	{
		string str;
		try
		{
			string str1 = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
			string str2 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
			GClass12 gClass12 = this.method_57(str1, str2);
			if (gClass12 == null)
			{
				if (ᜃ.ᜋ(this.string_20))
				{
					string str3 = "";
					ᜃ.ᜂ(str1, this.string_29, this.string_20, ref str3);
					GClass9.smethod_0(str1, str3);
					gClass12 = this.method_57(str1, str2);
					if (gClass12 == null)
					{
						string[] strArrays = new string[] { "该产品【", str2, "】已经退出鹊桥计划【", str1, "】！" };
						this.method_115(string.Concat(strArrays));
						str = null;
						return str;
					}
				}
				else
				{
					this.method_115("获取推广链接失败，【登录阿里妈妈】以后重试一次重新获取！");
					this.bool_0 = false;
					this.method_7();
					str = null;
					return str;
				}
			}
			string str4 = string.Concat(gClass12.string_2, gClass12.string_3);
			string str5 = this.method_62(str1, str2);
			if (str5 != null)
			{
				string str6 = this.dataGridViewBrdg[3, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				ArrayList arrayLists = ᜃ.ᜇ(str2, this.string_20, ref this.string_23);
				if (arrayLists.Count != 0)
				{
					string item = ((ᜦ)arrayLists[0]).ᜄ;
					string str7 = "<DIV>{title}   {price}</DIV><DIV><IMG src=\"{imgsrc}\"></DIV><DIV>{promlink}</DIV>";
					str7 = str7.Replace("{title}", str6).Replace("{price}", string.Concat("特价", item, "元")).Replace("{imgsrc}", string.Concat("file:///", str5.Replace(" ", "%20").Replace("{", "%7b").Replace("}", "%7d").Replace("\\", "/"))).Replace("{promlink}", this.method_198(str4));
					str = str7;
				}
				else
				{
					str = null;
				}
			}
			else
			{
				str = null;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getSelectPromotInfo]出错：", exception.ToString()));
			str = null;
		}
		return str;
	}

	private void method_54(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewBrdg.CurrentCell != null)
			{
				string str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				Process.Start(string.Concat("http://pub.alimama.com/myunion.htm?#!/promo/act/activity_detail?eventId=", str));
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenBrdg_Click]出错：", exception.ToString()));
		}
	}

	private void method_55(object sender, EventArgs e)
	{
		try
		{
			if (this.dataGridViewBrdg.CurrentCell != null)
			{
				string str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				string str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				if (this.method_58(str, str1))
				{
					this.method_61(str, str1);
					this.method_56(1, this.dataGridViewBrdg.CurrentCell.RowIndex);
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[OpenProduct_Click]出错：", exception.ToString()));
		}
	}

	private void method_56(int int_28, int int_29)
	{
		try
		{
			string str = this.dataGridViewBrdg[int_28, int_29].Value.ToString();
			Process.Start(string.Concat("https://item.taobao.com/item.htm?id=", str));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[doubleClickToOpenItem]出错：", exception.ToString()));
		}
	}

	private GClass12 method_57(string string_96, string string_97)
	{
		GClass12 gclass120;
		try
		{
			if ((this.gclass12_0 == null || !this.gclass12_0.string_0.Equals(string_96) ? true : !this.gclass12_0.string_1.Equals(string_97)))
			{
				ArrayList arrayLists = this.class1_0.method_4(string_96, string_97, out this.string_23);
				if (arrayLists.Count <= 0)
				{
					this.gclass12_0 = GClass9.smethod_1(string_96, string_97);
				}
				else
				{
					this.gclass12_0 = (GClass12)arrayLists[0];
				}
			}
			gclass120 = this.gclass12_0;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getUrlItem]出错：", exception.ToString()));
			gclass120 = null;
		}
		return gclass120;
	}

	private bool method_58(string string_96, string string_97)
	{
		bool flag;
		try
		{
			GClass12 gClass12 = this.method_57(string_96, string_97);
			if (gClass12 == null)
			{
				if (ᜃ.ᜋ(this.string_20))
				{
					string str = "";
					ᜃ.ᜂ(string_96, this.string_29, this.string_20, ref str);
					GClass9.smethod_0(string_96, str);
					gClass12 = this.method_57(string_96, string_97);
					if (gClass12 == null)
					{
						string[] string97 = new string[] { "该产品【", string_97, "】已经退出鹊桥计划【", string_96, "】！" };
						this.method_115(string.Concat(string97));
						flag = false;
						return flag;
					}
				}
				else
				{
					this.method_115("获取推广链接失败，【登录阿里妈妈】以后重试一次重新获取！");
					this.bool_0 = false;
					this.method_7();
					flag = false;
					return flag;
				}
			}
			string str1 = string.Concat(gClass12.string_2, gClass12.string_3);
			this.textBoxPromotLnk.Text = str1;
			ᜑ _ᜑ = this.method_86(string_96, string_97);
			this.textBoxItemTitle.Text = _ᜑ.ᜃ;
			string str2 = this.dataGridViewBrdg[10, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
			string str3 = this.dataGridViewBrdg[11, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
			int num = this.method_59(str2, str3);
			if (num == -1)
			{
				this.textBoxRemainDay.ForeColor = Color.Red;
				this.textBoxRemainDay.Text = "未开始";
				this.buttonCpPromotLnk.Enabled = false;
			}
			else if (num != 1)
			{
				DateTime dateTime = Convert.ToDateTime(str3);
				DateTime now = DateTime.Now;
				DateTime dateTime1 = Convert.ToDateTime(now.ToString("yyyy-MM-dd"));
				int days = dateTime.Subtract(dateTime1).Days + 16;
				this.textBoxRemainDay.ForeColor = Color.Black;
				this.textBoxRemainDay.Text = string.Concat(days, "");
				this.buttonCpPromotLnk.Enabled = true;
			}
			else
			{
				this.textBoxRemainDay.ForeColor = Color.Red;
				this.textBoxRemainDay.Text = "已失效";
				this.buttonCpPromotLnk.Enabled = false;
			}
			this.textBoxFEarn.Text = string.Concat(this.method_100(_ᜑ.ᜏ), "");
			flag = true;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showProductInfo]出错了！", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private int method_59(string string_96, string string_97)
	{
		int num;
		try
		{
			DateTime now = DateTime.Now;
			DateTime dateTime = Convert.ToDateTime(now.ToString("yyyy-MM-dd"));
			if (Convert.ToDateTime(string_96).Subtract(dateTime).Days > 0)
			{
				num = -1;
				return num;
			}
			else if (Convert.ToDateTime(string_97).Subtract(dateTime).Days + 16 <= 0)
			{
				num = 1;
				return num;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getValidType]出错：", exception.ToString()));
		}
		num = 0;
		return num;
	}

	private bool method_6(int int_28)
	{
		bool flag;
		try
		{
			if (this.int_2 <= 0)
			{
				ᝠ ᝠ1 = this.ᝠ_1;
				string string0 = this.string_0;
				object[] ᜐ0 = new object[] { "softwarename=alibridge&type=checkvip&user=", this.ᜐ_0.ᜁ, "&viptype=", int_28 };
				string str = this.method_17(ᝠ1, string0, string.Concat(ᜐ0));
				char[] chrArray = new char[] { '&' };
				string[] strArrays = str.Split(chrArray);
				Hashtable hashtables = new Hashtable();
				string[] strArrays1 = strArrays;
				for (int i = 0; i < (int)strArrays1.Length; i++)
				{
					string str1 = strArrays1[i];
					chrArray = new char[] { '=' };
					string[] strArrays2 = str1.Split(chrArray);
					hashtables.Add(strArrays2[0], strArrays2[1]);
				}
				if ("ng".Equals(hashtables["result"]))
				{
					this.method_115((string)hashtables["errmsg"]);
					flag = false;
				}
				else if (int.Parse(((string)hashtables["expiredate"]).Substring(0, 10).Replace("-", "")) >= int.Parse(((string)hashtables["sysdate"]).Substring(0, 10).Replace("-", "")))
				{
					this.int_2 = 100;
					flag = true;
				}
				else
				{
					this.method_115((string)hashtables["errmsg"]);
					flag = false;
				}
			}
			else
			{
				AliBridgeForm int2 = this;
				int2.int_2 = int2.int_2 - 1;
				flag = true;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[checkUserVip]出错：", exception.ToString()));
			flag = false;
		}
		return flag;
	}

	private void method_60()
	{
		this.textBoxItemTitle.Text = "";
		this.textBoxRemainDay.Text = "";
		this.textBoxFEarn.Text = "";
		this.textBoxPromotLnk.Text = "";
	}

	private void method_61(string string_96, string string_97)
	{
		try
		{
			GClass12 gClass12 = this.method_57(string_96, string_97);
			if (gClass12 == null)
			{
				if (ᜃ.ᜋ(this.string_20))
				{
					string str = "";
					ᜃ.ᜂ(string_96, this.string_29, this.string_20, ref str);
					GClass9.smethod_0(string_96, str);
					gClass12 = this.method_57(string_96, string_97);
					if (gClass12 == null)
					{
						string[] string97 = new string[] { "该产品【", string_97, "】已经退出鹊桥计划【", string_96, "】！" };
						this.method_115(string.Concat(string97));
						return;
					}
				}
				else
				{
					this.method_115("获取推广链接失败，【登录阿里妈妈】以后重试一次重新获取！");
					this.bool_0 = false;
					this.method_7();
					return;
				}
			}
			this.method_63(string.Concat(gClass12.string_4, "_200x200.jpg"));
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[clickToShowPic]出错：", exception.ToString()));
		}
	}

	private string method_62(string string_96, string string_97)
	{
		string str;
		try
		{
			GClass12 gClass12 = this.method_57(string_96, string_97);
			if (gClass12 == null)
			{
				if (ᜃ.ᜋ(this.string_20))
				{
					string str1 = "";
					ᜃ.ᜂ(string_96, this.string_29, this.string_20, ref str1);
					GClass9.smethod_0(string_96, str1);
					gClass12 = this.method_57(string_96, string_97);
					if (gClass12 == null)
					{
						string[] string97 = new string[] { "该产品【", string_97, "】已经退出鹊桥计划【", string_96, "】！" };
						this.method_115(string.Concat(string97));
						str = null;
						return str;
					}
				}
				else
				{
					this.method_115("获取推广链接失败，【登录阿里妈妈】以后重试一次重新获取！");
					this.bool_0 = false;
					this.method_7();
					str = null;
					return str;
				}
			}
			string str2 = string.Concat(gClass12.string_4, "_400x400.jpg");
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			string string53 = this.string_53;
			DateTime now = DateTime.Now;
			string str3 = string.Concat(string53, "\\", now.ToString("yyyyMMddHHmmssffff"), ".jpg");
			webClient.DownloadFile(str2, str3);
			str = str3;
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if ((!exception.ToString().Contains("System.Net.WebException") ? true : !exception.ToString().Contains("404")))
			{
				this.method_115(string.Concat("[downloItemPicForCopy]出错了！", exception.ToString()));
			}
			else
			{
				this.method_115("产品图片已经不存在或者修改过，无法查看！");
			}
			str = null;
		}
		return str;
	}

	private void method_63(string string_96)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			byte[] numArray = webClient.DownloadData(string_96);
			this.pictureBoxItemPic.Image = Image.FromStream(new MemoryStream(numArray));
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			if ((!exception.ToString().Contains("System.Net.WebException") ? true : !exception.ToString().Contains("404")))
			{
				this.method_115(string.Concat("[downloItemPic]出错了！", exception.ToString()));
			}
			else
			{
				this.method_115("产品图片已经不存在或者修改过，无法查看！");
			}
		}
	}

	private void method_64(object sender, EventArgs e)
	{
		try
		{
			this.webBrowserSendContent.Select();
			ᝬ.ᜃ();
			this.method_115("粘贴图文成功！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[PasteContent_Click]出错：", exception.ToString()));
		}
	}

	private void method_65(object sender, EventArgs e)
	{
		try
		{
			if (GClass13.smethod_23(this.webBrowserSendContent.Document.Body.InnerHtml, out this.string_23))
			{
				this.method_115("复制全部成功！");
			}
			else
			{
				this.method_115(string.Concat("复制全部失败！", this.string_23));
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[CopyContent_Click]出错：", exception.ToString()));
		}
	}

	private void method_66(object sender, EventArgs e)
	{
		try
		{
			((IHTMLDocument2)this.webBrowserSendContent.Document.DomDocument).body.innerHTML = "";
			this.method_115("清空成功！");
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[ClearContent_Click]出错：", exception.ToString()));
		}
	}

	private void method_67()
	{
		try
		{
			this.dataGridViewCmsPlan.Visible = false;
			if (!this.textBoxItemId.Text.Trim().Equals(""))
			{
				this.method_79();
				this.dataGridViewBrdg.Rows.Clear();
				this.pictureBoxItemPic.Image = null;
				this.method_60();
				string str = this.method_84();
				string str1 = this.method_81(this.textBoxItemId.Text.Trim());
				this.arrayList_0 = this.gclass1_0.method_4(str1, str, out this.string_23);
				ArrayList arrayLists = this.method_85(this.arrayList_0);
				this.method_72(this.arrayList_0, arrayLists);
				this.string_67 = str1;
				this.int_20 = 1;
				this.method_240();
				this.method_78();
			}
			else
			{
				this.method_115("别忘了填产品链接！");
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_78();
			this.method_115(string.Concat("[schByItemId]出错了！", exception.ToString()));
		}
	}

	private void method_68()
	{
		try
		{
			this.dataGridViewCmsPlan.Visible = false;
			if (!this.textBoxBrdgId.Text.Trim().Equals(""))
			{
				this.method_79();
				this.dataGridViewBrdg.Rows.Clear();
				this.pictureBoxItemPic.Image = null;
				this.method_60();
				string str = this.method_84();
				this.arrayList_0 = this.gclass1_0.method_3(this.textBoxBrdgId.Text.Trim(), str, out this.string_23);
				ArrayList arrayLists = this.gclass1_0.method_10(this.textBoxBrdgId.Text.Trim(), out this.string_23);
				this.method_72(this.arrayList_0, arrayLists);
				this.method_78();
			}
			else
			{
				this.method_115("别忘了填鹊桥ID！");
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_78();
			this.method_115(string.Concat("[schByBrdgId]出错了！", exception.ToString()));
		}
	}

	private void method_69()
	{
		try
		{
			this.dataGridViewCmsPlan.Visible = false;
			if (!this.textBoxKeyword.Text.Trim().Equals(""))
			{
				this.method_115("开始按关键词搜索！");
				this.dataGridViewBrdg.Rows.Clear();
				this.pictureBoxItemPic.Image = null;
				this.pictureBoxWaiting.Visible = true;
				this.method_79();
				this.method_60();
				string str = this.textBoxKWLowP.Text.Trim();
				string str1 = this.textBoxKWHiP.Text.Trim();
				string str2 = "";
				if (!str.Equals(""))
				{
					str2 = string.Concat(" and discountPrice>=", str);
				}
				if (!str1.Equals(""))
				{
					string str3 = string.Concat(" and discountPrice<=", str1);
					str2 = (str2.Equals("") ? str3 : string.Concat(str2, str3));
				}
				string str4 = this.method_84();
				string[] strArrays = new string[] { "select * from bridgeitem where itemTitle like '%", this.textBoxKeyword.Text.Trim(), "%' ", str2, str4 };
				this.string_22 = string.Concat(strArrays);
				(new Thread(new ThreadStart(this.method_71))).Start();
			}
			else
			{
				this.method_115("别忘了填关键词！");
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_78();
			this.method_115(string.Concat("[schByKW]出错了！", exception.ToString()));
		}
	}

	private void method_7()
	{
		this.method_8((!this.checkBoxAutoLogin.Checked || this.string_33.Equals("") ? false : !this.string_34.Equals("")));
	}

	private void method_70()
	{
		try
		{
			this.dataGridViewCmsPlan.Visible = false;
			if (!this.textBoxCms.Text.Trim().Equals(""))
			{
				this.method_115("开始按佣金比例搜索！");
				this.dataGridViewBrdg.Rows.Clear();
				this.pictureBoxItemPic.Image = null;
				this.pictureBoxWaiting.Visible = true;
				this.method_79();
				this.method_60();
				string str = this.textBoxCMSLowP.Text.Trim();
				string str1 = this.textBoxCMSHiP.Text.Trim();
				string str2 = "";
				if (!str.Equals(""))
				{
					str2 = string.Concat(" and discountPrice>=", str);
				}
				if (!str1.Equals(""))
				{
					string str3 = string.Concat(" and discountPrice<=", str1);
					str2 = (str2.Equals("") ? str3 : string.Concat(str2, str3));
				}
				string str4 = this.method_84();
				string[] strArrays = new string[] { "select * from bridgeitem where commissionRate>=", this.textBoxCms.Text.Trim(), " ", str2, str4 };
				this.string_22 = string.Concat(strArrays);
				(new Thread(new ThreadStart(this.method_71))).Start();
			}
			else
			{
				this.method_115("别忘了填佣金比例！");
			}
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_78();
			this.method_115(string.Concat("[schByCms]出错了！", exception.ToString()));
		}
	}

	private void method_71()
	{
		try
		{
			this.arrayList_0 = this.gclass1_0.method_6(this.string_22, out this.string_23);
			ArrayList arrayLists = this.method_85(this.arrayList_0);
			this.method_72(this.arrayList_0, arrayLists);
			this.method_95();
			this.method_78();
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.method_78();
			this.method_115(string.Concat("[schThread]出错了！", exception.ToString()));
		}
	}

	private void method_72(ArrayList arrayList_26, ArrayList arrayList_27)
	{
		try
		{
			this.method_115(string.Concat("共【", arrayList_26.Count, "】条鹊桥产品（含有重复）！"));
			if (this.checkBoxSingle.Checked)
			{
				this.method_115(string.Concat("开始除去重复数据！", (arrayList_26.Count > 20000 ? "数据量大于2万条，处理时间比较长！" : "")));
				arrayList_26 = this.method_75(arrayList_26);
				this.method_115(string.Concat("【", arrayList_26.Count, "】条鹊桥产品（不含重复）！"));
			}
			if (arrayList_26.Count <= 100000)
			{
				this.method_73(arrayList_26, arrayList_27);
			}
			else
			{
				this.method_115("搜索结果的个数大于10万个，无法显示，重新设定条件再搜索！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[showBrdgInfos]出错了！", exception.ToString()));
		}
	}

	public void method_73(ArrayList arrayList_26, ArrayList arrayList_27)
	{
		try
		{
			if (!this.dataGridViewBrdg.InvokeRequired)
			{
				if (arrayList_26.Count <= 13)
				{
					this.dataGridViewBrdg.Columns[3].Width = 466;
				}
				else
				{
					this.dataGridViewBrdg.Columns[3].Width = 448;
				}
				int num = 0;
				foreach (ᜑ arrayList26 in arrayList_26)
				{
					ᜉ _ᜉ = this.method_87(arrayList26.ᜁ, arrayList_27);
					if (_ᜉ == null)
					{
						continue;
					}
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					this.dataGridViewBrdg.Rows.Add(dataGridViewRow);
					this.dataGridViewBrdg.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
					this.dataGridViewBrdg[0, num].Value = arrayList26.ᜁ;
					this.dataGridViewBrdg[1, num].Value = arrayList26.ᜂ;
					this.dataGridViewBrdg[2, num].Value = (arrayList26.ᜍ == 1 ? "天猫" : "淘宝");
					this.dataGridViewBrdg[3, num].Value = arrayList26.ᜃ;
					this.dataGridViewBrdg[4, num].Value = arrayList26.ᜇ;
					this.dataGridViewBrdg[5, num].Value = _ᜉ.ᜅ;
					this.dataGridViewBrdg[6, num].Value = this.method_100(arrayList26.ᜎ);
					this.dataGridViewBrdg[7, num].Value = arrayList26.ᜉ;
					this.dataGridViewBrdg[8, num].Value = this.method_100(arrayList26.ᜏ);
					this.dataGridViewBrdg[9, num].Value = arrayList26.ᜌ;
					this.dataGridViewBrdg[10, num].Value = this.method_74(_ᜉ.ᜂ);
					this.dataGridViewBrdg[11, num].Value = this.method_74(_ᜉ.ᜃ);
					num++;
				}
			}
			else
			{
				AliBridgeForm.GDelegate58 gDelegate58 = new AliBridgeForm.GDelegate58(this.method_73);
				object[] objArray = new object[] { arrayList_26, arrayList_27 };
				base.BeginInvoke(gDelegate58, objArray);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[dispDataGridViewBrdg]出错了！只是小错，吓吓你们的：", exception.ToString()));
		}
	}

	private string method_74(int int_28)
	{
		string str = string.Concat(int_28, "");
		string[] strArrays = new string[] { str.Substring(0, 4), "-", str.Substring(4, 2), "-", str.Substring(6, 2) };
		return string.Concat(strArrays);
	}

	private ArrayList method_75(ArrayList arrayList_26)
	{
		GClass14 gClass14;
		try
		{
			Hashtable hashtables = new Hashtable();
			int num = 0;
			int num1 = 0;
			while (num < arrayList_26.Count)
			{
				ᜑ item = (ᜑ)arrayList_26[num];
				if (!hashtables.ContainsKey(item.ᜂ))
				{
					gClass14 = new GClass14()
					{
						int_0 = num1,
						string_0 = item.ᜂ,
						bool_0 = false
					};
					gClass14.arrayList_0.Add(item);
					hashtables.Add(item.ᜂ, gClass14);
					num1++;
				}
				else
				{
					gClass14 = (GClass14)hashtables[item.ᜂ];
					gClass14.arrayList_0.Add(item);
				}
				num++;
			}
			this.arrayList_1 = new ArrayList();
			IDictionaryEnumerator enumerator = hashtables.GetEnumerator();
			while (enumerator.MoveNext())
			{
				gClass14 = (GClass14)enumerator.Value;
				this.arrayList_1.Add(gClass14);
				if (gClass14.arrayList_0.Count <= 1)
				{
					gClass14.bool_0 = true;
				}
				else
				{
					(new Thread(new ParameterizedThreadStart(this.method_76))).Start(gClass14);
				}
			}
			while (true)
			{
				int num2 = 0;
				for (int i = 0; i < this.arrayList_1.Count; i++)
				{
					gClass14 = (GClass14)this.arrayList_1[i];
					if (gClass14.bool_0)
					{
						num2++;
					}
				}
				if (num2 == this.arrayList_1.Count)
				{
					break;
				}
				Thread.Sleep(100);
			}
			this.arrayList_1.Sort(new GClass17());
			arrayList_26 = new ArrayList();
			foreach (GClass14 gClass14 in this.arrayList_1)
			{
				arrayList_26.Add((ᜑ)gClass14.arrayList_0[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[removeDupMultiThread]出错：", exception.ToString()));
		}
		return arrayList_26;
	}

	public void method_76(object object_0)
	{
		try
		{
			GClass14 object0 = (GClass14)object_0;
			ArrayList arrayList0 = object0.arrayList_0;
			for (int i = 0; i < arrayList0.Count; i++)
			{
				ᜑ item = (ᜑ)arrayList0[i];
				int num = i + 1;
				while (true)
				{
					if (num < arrayList0.Count)
					{
						ᜑ _ᜑ = (ᜑ)arrayList0[num];
						if (item.ᜇ == _ᜑ.ᜇ)
						{
							if (item.ᜐ == 1)
							{
								arrayList0.RemoveAt(i);
								i--;
								break;
							}
							else
							{
								arrayList0.RemoveAt(num);
								num--;
							}
						}
						else if (item.ᜇ < _ᜑ.ᜇ)
						{
							arrayList0.RemoveAt(i);
							i--;
							break;
						}
						else
						{
							arrayList0.RemoveAt(num);
							num--;
						}
						num++;
					}
					else
					{
						break;
					}
				}
			}
			object0.bool_0 = true;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[removeDupSameItemId]出错：", exception.ToString()));
		}
	}

	private ArrayList method_77(ArrayList arrayList_26)
	{
		ArrayList arrayList26;
		try
		{
			for (int i = 0; i < arrayList_26.Count; i++)
			{
				ᜑ item = (ᜑ)arrayList_26[i];
				int num = i + 1;
				while (true)
				{
					if (num < arrayList_26.Count)
					{
						ᜑ _ᜑ = (ᜑ)arrayList_26[num];
						if (item.ᜂ.Equals(_ᜑ.ᜂ))
						{
							if (item.ᜇ < _ᜑ.ᜇ)
							{
								arrayList_26.RemoveAt(i);
								i--;
								break;
							}
							else
							{
								arrayList_26.RemoveAt(num);
								num--;
							}
						}
						num++;
					}
					else
					{
						break;
					}
				}
			}
			arrayList26 = arrayList_26;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[removeDup]出错：", exception.ToString()));
			arrayList26 = new ArrayList();
		}
		return arrayList26;
	}

	private void method_78()
	{
		this.method_80(1, true);
		this.method_80(2, true);
		this.method_80(3, true);
		this.method_80(4, true);
		this.method_80(5, true);
	}

	private void method_79()
	{
		this.method_80(1, false);
		this.method_80(2, false);
		this.method_80(3, false);
		this.method_80(4, false);
		this.method_80(5, false);
	}

	private void method_8(bool bool_40)
	{
		this.method_9(bool_40, this.string_33, this.string_34);
	}

	public void method_80(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate59 gDelegate59;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonSchByItemId.InvokeRequired)
				{
					this.buttonSchByItemId.Enabled = bool_40;
				}
				else
				{
					gDelegate59 = new AliBridgeForm.GDelegate59(this.method_80);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate59, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonSchByBrdgId.InvokeRequired)
				{
					this.buttonSchByBrdgId.Enabled = bool_40;
				}
				else
				{
					gDelegate59 = new AliBridgeForm.GDelegate59(this.method_80);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate59, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.buttonSchByKW.InvokeRequired)
				{
					this.buttonSchByKW.Enabled = bool_40;
				}
				else
				{
					gDelegate59 = new AliBridgeForm.GDelegate59(this.method_80);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate59, int28);
					return;
				}
			}
			else if (int_28 == 4)
			{
				if (!this.buttonSchByCms.InvokeRequired)
				{
					this.buttonSchByCms.Enabled = bool_40;
				}
				else
				{
					gDelegate59 = new AliBridgeForm.GDelegate59(this.method_80);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate59, int28);
					return;
				}
			}
			else if (int_28 == 5)
			{
				if (!this.buttonCpPromotLnk.InvokeRequired)
				{
					this.buttonCpPromotLnk.Enabled = bool_40;
				}
				else
				{
					gDelegate59 = new AliBridgeForm.GDelegate59(this.method_80);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate59, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[BtnCtl]出错：", exception.ToString()));
		}
	}

	private string method_81(string string_96)
	{
		string str;
		try
		{
			string str1 = string_96.Replace("&amp;", "&").Replace("&nbsp;", "&");
			int num = str1.IndexOf("?id=");
			if (num == -1)
			{
				num = str1.IndexOf("&id=");
			}
			if (num != -1)
			{
				num = num + 4;
				int length = str1.IndexOf("&", num);
				if (length == -1)
				{
					length = string_96.Length;
				}
				str = str1.Substring(num, length - num);
			}
			else
			{
				str = str1;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getItemId]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private string method_82(string string_96)
	{
		string string96;
		try
		{
			int num = string_96.IndexOf("?item_id=");
			if (num == -1)
			{
				num = string_96.IndexOf("&item_id=");
			}
			if (num != -1)
			{
				num = num + 9;
				int length = string_96.IndexOf("&", num);
				if (length == -1)
				{
					length = string_96.Length;
				}
				string96 = string_96.Substring(num, length - num);
			}
			else
			{
				string96 = string_96;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getItemId]出错：", exception.ToString()));
			string96 = "";
		}
		return string96;
	}

	private string method_83(string string_96)
	{
		string string96;
		try
		{
			int num = string_96.IndexOf("?user_number_id=");
			if (num == -1)
			{
				num = string_96.IndexOf("&user_number_id=");
			}
			if (num != -1)
			{
				num = num + 16;
				int length = string_96.IndexOf("&", num);
				if (length == -1)
				{
					length = string_96.Length;
				}
				string96 = string_96.Substring(num, length - num);
			}
			else
			{
				string96 = string_96;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getShopId]出错：", exception.ToString()));
			string96 = "";
		}
		return string96;
	}

	private string method_84()
	{
		string str;
		try
		{
			string str1 = "";
			if (this.rdobtnOrderByCms.Checked)
			{
				str1 = " order by actCmsRate desc, commissionRate desc ";
			}
			else if (this.rdobtnOrderByQnt.Checked)
			{
				str1 = " order by soldQuantity desc ";
			}
			else if (this.rdobtnOrderByPrice.Checked)
			{
				str1 = " order by discountPrice desc ";
			}
			string str2 = "";
			if (this.checkBoxTmallOnly.Checked)
			{
				str2 = " and mall=1 ";
			}
			if (this.checkBoxNoNotStt.Checked)
			{
				DateTime now = DateTime.Now;
				str2 = string.Concat(str2, " and startTime<=", now.ToString("yyyyMMdd"));
			}
			str = string.Concat(str2, str1);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getSchPlusSql]出错：", exception.ToString()));
			str = "";
		}
		return str;
	}

	private ArrayList method_85(ArrayList arrayList_26)
	{
		ArrayList arrayLists;
		try
		{
			if (arrayList_26.Count != 0)
			{
				string str = "";
				foreach (ᜑ arrayList26 in arrayList_26)
				{
					if (str.Contains(string.Concat("'", arrayList26.ᜁ, "'")))
					{
						continue;
					}
					str = (!str.Equals("") ? string.Concat(str, ", '", arrayList26.ᜁ, "'") : string.Concat("'", arrayList26.ᜁ, "'"));
				}
				string str1 = string.Concat("select * from bridgeinfo where eventId in ( ", str, ")");
				arrayLists = this.gclass1_0.method_11(str1, out this.string_23);
			}
			else
			{
				arrayLists = new ArrayList();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBrdgInfoSqlByBrdgItemLst]出错：", exception.ToString()));
			arrayLists = new ArrayList();
		}
		return arrayLists;
	}

	private ᜑ method_86(string string_96, string string_97)
	{
		ᜑ _ᜑ;
		try
		{
			foreach (ᜑ arrayList0 in this.arrayList_0)
			{
				if ((!string_96.Equals(arrayList0.ᜁ) ? true : !string_97.Equals(arrayList0.ᜂ)))
				{
					continue;
				}
				_ᜑ = arrayList0;
				return _ᜑ;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBrdgItem]出错：", exception.ToString()));
		}
		_ᜑ = null;
		return _ᜑ;
	}

	private ᜉ method_87(string string_96, ArrayList arrayList_26)
	{
		ᜉ _ᜉ;
		try
		{
			foreach (ᜉ arrayList26 in arrayList_26)
			{
				if (!arrayList26.ᜁ.Equals(string_96))
				{
					continue;
				}
				_ᜉ = arrayList26;
				return _ᜉ;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[getBridgInfoByEventId]出错：", exception.ToString()));
		}
		_ᜉ = null;
		return _ᜉ;
	}

	public bool method_88()
	{
		bool flag;
		if (this.class0_0 == null)
		{
			this.class0_0 = new Class0();
		}
		if (!this.class0_0.method_15(out this.string_23))
		{
			(new Thread(new ThreadStart(this.method_89))).Start();
			flag = false;
		}
		else
		{
			flag = true;
		}
		return flag;
	}

	public void method_89()
	{
		ᜉ _ᜉ = null;
		string str = "";
		DbTransaction dbTransaction = this.gclass1_0.sqliteConnection_0.BeginTransaction();
		ArrayList arrayLists = this.class0_0.method_16();
		int num = 0;
		while (true)
		{
			if (num < arrayLists.Count)
			{
				bool flag = false;
				string item = (string)arrayLists[num];
				foreach (ᜑ _ᜑ in this.class0_0.method_4(item, "", out this.string_23))
				{
					bool flag1 = this.gclass1_0.method_1(_ᜑ, out this.string_23);
					flag = flag1;
					if (flag1 || this.string_23.Contains("UNIQUE constraint failed: bridgeitem.eventId, bridgeitem.itemId"))
					{
						continue;
					}
					this.method_115(string.Concat("数据移植出错！", this.string_23));
					return;
				}
				str = string.Concat("update bridgeitem set movflg=1 where eventId='", item, "'");
				this.class0_0.method_14(str, out this.string_23);
				foreach (ᜉ _ᜉ in this.class0_0.method_11(item, out this.string_23))
				{
					this.gclass1_0.method_9(_ᜉ, out this.string_23);
					if (flag || this.string_23.Contains("UNIQUE constraint failed: bridgeinfo.eventId"))
					{
						continue;
					}
					this.method_115(string.Concat("数据移植出错！", this.string_23));
					return;
				}
				str = string.Concat("update bridgeinfo set movflg=1 where eventId='", item, "'");
				this.class0_0.method_14(str, out this.string_23);
				if (num % 100 == 99)
				{
					object[] count = new object[] { "正在转移【", num + 1, "/", arrayLists.Count, "】个。" };
					this.method_115(string.Concat(count));
					dbTransaction.Commit();
					dbTransaction = this.gclass1_0.sqliteConnection_0.BeginTransaction();
				}
				num++;
			}
			else
			{
				if (dbTransaction.Connection != null)
				{
					dbTransaction.Commit();
				}
				dbTransaction = this.gclass1_0.sqliteConnection_0.BeginTransaction();
				foreach (ᜉ _ᜉ1 in this.class0_0.method_12("select * from bridgeinfo where movflg<>1 or movflg is null;", out this.string_23))
				{
					this.gclass1_0.method_9(_ᜉ1, out this.string_23);
					str = string.Concat("update bridgeinfo set movflg=1 where eventId='", _ᜉ1.ᜁ, "'");
					this.class0_0.method_14(str, out this.string_23);
				}
				dbTransaction.Commit();
				if (this.class0_0.method_14("delete from bridgeitem;", out this.string_23))
				{
					this.class0_0.method_14("delete from bridgeinfo;", out this.string_23);
				}
				this.class0_0.method_17();
				this.method_115("数据移植完成，重启程序！");
				MessageBox.Show("数据移植完成，重启软件！");
				break;
			}
		}
	}

	private void method_9(bool bool_40, string string_96, string string_97)
	{
		try
		{
			if ((int)Process.GetProcessesByName("AlimamaLogin").Length <= 0)
			{
				this.method_11(FormWindowState.Minimized);
				this.method_115("正在打开登录窗口。。。。");
				string str = (bool_40 ? "1" : "0");
				string str1 = " 0";
				if ((this.string_44.Equals("") ? false : !this.string_45.Equals("")))
				{
					str1 = string.Concat(" 1 ", this.string_44, " ", this.string_45);
				}
				string[] strArrays = new string[] { "\"", this.method_10(), "\" ", str, " ", string_96, " ", string_97, " ", str1 };
				string str2 = string.Concat(strArrays);
				try
				{
					Process.Start(string.Concat(this.string_41, "\\AlimamaLogin.exe"), str2);
					this.bool_1 = false;
				}
				catch
				{
					if (File.Exists(string.Concat(this.string_41, "\\AlimamaLogin.exe")))
					{
						File.Delete(string.Concat(this.string_41, "\\AlimamaLogin.exe"));
					}
					try
					{
						this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/AlimamaLogin.exe"), string.Concat(this.string_41, "\\AlimamaLogin.exe"));
					}
					catch
					{
						this.webClient_0.DownloadFile(string.Concat("http://", ᝮ.ᜄ, "/update/AlimamaLogin.exe"), string.Concat(this.string_41, "\\AlimamaLogin.exe"));
					}
					Process.Start(string.Concat(this.string_41, "\\AlimamaLogin.exe"), str2);
					this.bool_1 = false;
				}
			}
			else
			{
				this.method_115("登录窗口已经打开。。。。请稍候！");
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[openLoginForm]出错，", exception.ToString()));
		}
	}

	private void method_90()
	{
		ᜉ item = null;
		try
		{
			this.method_115("开始删除失效的鹊桥！");
			int num = this.method_92();
			this.method_115(string.Concat("删除失效的鹊桥成功！共删除【", num, "】个过期鹊桥"));
			if (num != 0)
			{
				this.method_91();
			}
			this.method_115("正在采集【鹊桥活动】");
			this.method_115("检查阿里妈妈登录！");
			if (ᜃ.ᜋ(this.string_20))
			{
				ArrayList arrayLists = new ArrayList();
				int num1 = 1;
				bool flag = true;
				while (flag)
				{
					this.method_115(string.Concat("正在采集【鹊桥活动】第【", num1, "】页！"));
					ArrayList arrayLists1 = null;
					try
					{
						arrayLists1 = ᜃ.ᜀ(num1, ref flag, this.string_20);
					}
					catch
					{
						this.method_115("累了，休息一会再采集");
						Thread.Sleep(1500);
						arrayLists1 = ᜃ.ᜀ(num1, ref flag, this.string_20);
					}
					foreach (ᜉ item in arrayLists1)
					{
						if (this.gclass1_0.method_10(item.ᜁ, out this.string_23).Count != 0)
						{
							continue;
						}
						arrayLists.Add(item);
					}
					num1++;
					Thread.Sleep(300);
				}
				this.method_115(string.Concat("采集【鹊桥活动】完成，【", arrayLists.Count, "】个新鹊桥！"));
				DbTransaction dbTransaction = this.gclass1_0.sqliteConnection_0.BeginTransaction();
				this.method_115("开始采集【鹊桥产品】！");
				for (int i = 0; i < arrayLists.Count; i++)
				{
					item = (ᜉ)arrayLists[i];
					object[] count = new object[] { "正在采集【", i + 1, "/", arrayLists.Count, "】个【鹊桥产品】，鹊桥编号【", item.ᜁ, "】！" };
					this.method_115(string.Concat(count));
					this.method_97(item.ᜁ);
					try
					{
						int num2 = 0;
						bool flag1 = false;
						while (true)
						{
							bool flag2 = ᜃ.ᜋ(this.string_20);
							flag1 = flag2;
							if (flag2 || num2 > 3)
							{
								break;
							}
							this.method_115("没有登录阿里妈妈！");
							this.bool_0 = false;
							this.method_7();
							Thread.Sleep(20000);
							num2++;
						}
						if (flag1)
						{
							string str = "";
							ArrayList arrayLists2 = null;
							try
							{
								arrayLists2 = ᜃ.ᜂ(item.ᜁ, this.string_29, this.string_20, ref str);
							}
							catch
							{
								this.method_115("累了，休息一会再采集");
								Thread.Sleep(1500);
								arrayLists2 = ᜃ.ᜂ(item.ᜁ, this.string_29, this.string_20, ref str);
							}
							foreach (ᜑ _ᜑ in arrayLists2)
							{
								if (_ᜑ.ᜇ < (double)this.float_0 || this.method_98(_ᜑ, item))
								{
									continue;
								}
								this.method_115(string.Concat("数据插入鹊桥产品失败！", this.string_23));
								return;
							}
							if (!GClass9.smethod_0(item.ᜁ, str))
							{
								this.method_115("保存鹊桥数据失败！");
								return;
							}
							else if (this.gclass1_0.method_9(item, out this.string_23))
							{
								if ((i % 100 != 1 ? false : i != 1))
								{
									dbTransaction.Commit();
									dbTransaction = this.gclass1_0.sqliteConnection_0.BeginTransaction();
								}
								Thread.Sleep(300);
							}
							else
							{
								this.method_115(string.Concat("数据插入鹊桥活动失败！", this.string_23));
								return;
							}
						}
						else
						{
							this.method_93();
							this.method_115("登录阿里妈妈失败，退出采集！");
							this.bool_0 = false;
							this.method_7();
							return;
						}
					}
					catch (Exception exception1)
					{
						Exception exception = exception1;
						if (!exception.ToString().Contains("System.Net.WebException"))
						{
							throw exception;
						}
						i--;
						this.method_115(string.Concat("鹊桥编号【", item.ᜁ, "】采集出错，重新采集！"));
						Thread.Sleep(800);
						goto Label1;
					}
					Thread.Sleep(10);
				Label1:
				}
				if (dbTransaction.Connection != null)
				{
					dbTransaction.Commit();
				}
				this.method_115("采集【鹊桥产品】完成！");
				this.method_91();
				this.method_93();
			}
			else
			{
				this.method_93();
				this.method_115("没有登录阿里妈妈！");
				this.bool_0 = false;
				this.method_7();
			}
		}
		catch (Exception exception2)
		{
			this.method_115(string.Concat("[collectBridge]采集出错！", exception2.ToString()));
			this.method_93();
		}
	}

	private void method_91()
	{
		this.method_115("开始优化数据库！");
		this.method_79();
		this.gclass1_0.method_14();
		this.class1_0.method_10();
		this.method_78();
		this.method_115("优化数据库成功！");
	}

	public int method_92()
	{
		int count;
		try
		{
			DateTime dateTime = DateTime.Now.AddDays(-15);
			string str = dateTime.ToString("yyyyMMdd");
			string str1 = string.Concat("select * from bridgeinfo where endTime<", str);
			ArrayList arrayLists = this.gclass1_0.method_11(str1, out this.string_23);
			if (arrayLists.Count != 0)
			{
				string str2 = "";
				foreach (ᜉ _ᜉ in arrayLists)
				{
					GClass9.smethod_3(_ᜉ.ᜁ);
					str2 = (!str2.Equals("") ? string.Concat(str2, ", '", _ᜉ.ᜁ, "'") : string.Concat("'", _ᜉ.ᜁ, "'"));
				}
				string str3 = string.Concat("delete from bridgeitemurl where eventId in (", str2, ")");
				if (this.class1_0.method_9(str3, out this.string_23))
				{
					string str4 = string.Concat("delete from bridgeitem where eventId in (", str2, ")");
					if (this.gclass1_0.method_13(str4, out this.string_23))
					{
						string str5 = string.Concat("delete from bridgeinfo where eventId in (", str2, ")");
						this.gclass1_0.method_13(str5, out this.string_23);
						count = arrayLists.Count;
						return count;
					}
				}
			}
			else
			{
				count = 0;
				return count;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[delDisableBrdgData]出错：", exception.ToString()));
		}
		count = 0;
		return count;
	}

	private void method_93()
	{
		this.method_94(1, true);
		this.method_94(2, true);
		this.method_94(3, true);
	}

	public void method_94(int int_28, bool bool_40)
	{
		AliBridgeForm.GDelegate60 gDelegate60;
		object[] int28;
		try
		{
			if (int_28 == 1)
			{
				if (!this.buttonStt.InvokeRequired)
				{
					this.buttonStt.Enabled = bool_40;
					this.buttonStt.Text = "智能采集";
					this.method_95();
				}
				else
				{
					gDelegate60 = new AliBridgeForm.GDelegate60(this.method_94);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate60, int28);
					return;
				}
			}
			else if (int_28 == 2)
			{
				if (!this.buttonDlByBrdgID.InvokeRequired)
				{
					this.buttonDlByBrdgID.Enabled = bool_40;
					this.buttonDlByBrdgID.Text = "开始采集";
					this.method_95();
				}
				else
				{
					gDelegate60 = new AliBridgeForm.GDelegate60(this.method_94);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate60, int28);
					return;
				}
			}
			else if (int_28 == 3)
			{
				if (!this.buttonCompressDb.InvokeRequired)
				{
					this.buttonCompressDb.Enabled = bool_40;
					this.buttonCompressDb.Text = "优化数据库";
					this.method_95();
				}
				else
				{
					gDelegate60 = new AliBridgeForm.GDelegate60(this.method_94);
					int28 = new object[] { int_28, bool_40 };
					base.BeginInvoke(gDelegate60, int28);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[EnableCltBtn]出错：", exception.ToString()));
		}
	}

	public void method_95()
	{
		try
		{
			if (!this.pictureBoxWaiting.InvokeRequired)
			{
				this.pictureBoxWaiting.Visible = false;
			}
			else
			{
				AliBridgeForm.GDelegate61 gDelegate61 = new AliBridgeForm.GDelegate61(this.method_95);
				base.BeginInvoke(gDelegate61, new object[0]);
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[HideWaitingPic]出错：", exception.ToString()));
		}
	}

	private void method_96()
	{
		try
		{
			string str = this.textBoxManulBrdgId.Text.Trim();
			ArrayList arrayLists = this.gclass1_0.method_10(str, out this.string_23);
			if ((arrayLists.Count == 0 ? true : this.checkBoxFcMnDl.Checked))
			{
				DbTransaction dbTransaction = this.gclass1_0.sqliteConnection_0.BeginTransaction();
				if (arrayLists.Count != 0)
				{
					this.method_97(str);
				}
				this.method_115("检查阿里妈妈登录！");
				if (ᜃ.ᜋ(this.string_20))
				{
					ArrayList arrayLists1 = ᜃ.ᜁ(str, this.string_20);
					if (arrayLists1.Count != 0)
					{
						ᜉ item = (ᜉ)arrayLists1[0];
						string str1 = "";
						ArrayList arrayLists2 = ᜃ.ᜂ(item.ᜁ, this.string_29, this.string_20, ref str1);
						foreach (ᜑ _ᜑ in arrayLists2)
						{
							if (this.method_98(_ᜑ, item))
							{
								continue;
							}
							this.method_115("数据插入鹊桥产品失败！");
							this.method_93();
							return;
						}
						if (!GClass9.smethod_0(item.ᜁ, str1))
						{
							this.method_115("保存鹊桥数据失败！");
						}
						else if (this.gclass1_0.method_9(item, out this.string_23))
						{
							dbTransaction.Commit();
							this.method_115(string.Concat("鹊桥【", str, "】采集完成！"));
							this.method_93();
						}
						else
						{
							this.method_115("数据插入鹊桥活动失败！");
						}
					}
					else
					{
						this.method_115(string.Concat("鹊桥【", str, "】不存在！"));
						this.method_93();
					}
				}
				else
				{
					this.method_93();
					this.method_115("没有登录阿里妈妈！");
					this.bool_0 = false;
					this.method_7();
				}
			}
			else
			{
				this.method_115(string.Concat("鹊桥【", str, "】已经存在，如果需要更新请选择强制更新！"));
				this.method_93();
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[collectSingle]采集出错！", exception.ToString()));
			this.method_93();
		}
	}

	private void method_97(string string_96)
	{
		try
		{
			string str = string.Concat("delete from bridgeinfo where eventId='", string_96, "'");
			this.gclass1_0.method_13(str, out this.string_23);
			str = string.Concat("delete from bridgeitem where eventId='", string_96, "'");
			this.gclass1_0.method_13(str, out this.string_23);
			str = string.Concat("delete from bridgeitemurl where eventId='", string_96, "'");
			this.class1_0.method_9(str, out this.string_23);
			GClass9.smethod_3(string_96);
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[deleteDataByEventId]出错：", exception.ToString()));
		}
	}

	private bool method_98(ᜑ ᜑ_0, ᜉ ᜉ_0)
	{
		bool flag;
		try
		{
			ᜑ_0.ᜎ = (double)ᜑ_0.ᜇ * ᜉ_0.ᜅ / 100;
			ᜑ_0.ᜏ = (double)ᜑ_0.ᜎ * ᜑ_0.ᜉ / 100;
			ᜑ_0.ᜑ = ᜉ_0.ᜂ;
			flag = this.gclass1_0.method_1(ᜑ_0, out this.string_23);
			return flag;
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[insertNewBrdgItem]出错：", exception.ToString()));
		}
		flag = false;
		return flag;
	}

	private void method_99()
	{
		try
		{
			this.method_115("开始优化数据库！");
			this.method_79();
			this.gclass1_0.method_14();
			this.class1_0.method_10();
			this.method_78();
			this.method_115("优化数据库成功！");
			this.method_93();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[compactDb]出错：", exception.ToString()));
		}
	}

	[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=false)]
	public static extern int MoveWindow(IntPtr intptr_1, int int_28, int int_29, int int_30, int int_31, bool bool_40);

	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				base.Activate();
				base.Visible = true;
				base.WindowState = FormWindowState.Normal;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[notifyIconTask_MouseClick]出错，", exception.ToString()));
		}
	}

	private void pictureBoxItemPic_MouseHover(object sender, EventArgs e)
	{
		try
		{
			if ((this.dataGridViewBrdg.CurrentCell == null ? false : this.pictureBoxItemPic.Image != null))
			{
				string str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				string str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				GClass12 gClass12 = this.method_57(str, str1);
				if (gClass12 == null)
				{
					if (ᜃ.ᜋ(this.string_20))
					{
						string str2 = "";
						ᜃ.ᜂ(str, this.string_29, this.string_20, ref str2);
						GClass9.smethod_0(str, str2);
						gClass12 = this.method_57(str, str1);
						if (gClass12 == null)
						{
							string[] strArrays = new string[] { "该产品【", str1, "】已经退出鹊桥计划【", str, "】！" };
							this.method_115(string.Concat(strArrays));
							return;
						}
					}
					else
					{
						this.method_115("获取推广链接失败，【登录阿里妈妈】以后重试一次重新获取！");
						this.bool_0 = false;
						this.method_7();
						return;
					}
				}
				this.method_63(string.Concat(gClass12.string_4, "_400x400.jpg"));
				this.pictureBoxItemPic.Width = 400;
				this.pictureBoxItemPic.Height = 400;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[pictureBoxItemPic_MouseHover]出错了！", exception.ToString()));
		}
	}

	private void pictureBoxItemPic_MouseLeave(object sender, EventArgs e)
	{
		try
		{
			if ((this.dataGridViewBrdg.CurrentCell == null ? false : this.pictureBoxItemPic.Image != null))
			{
				string str = this.dataGridViewBrdg[0, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				string str1 = this.dataGridViewBrdg[1, this.dataGridViewBrdg.CurrentCell.RowIndex].Value.ToString();
				GClass12 gClass12 = this.method_57(str, str1);
				if (gClass12 == null)
				{
					if (ᜃ.ᜋ(this.string_20))
					{
						string str2 = "";
						ᜃ.ᜂ(str, this.string_29, this.string_20, ref str2);
						GClass9.smethod_0(str, str2);
						gClass12 = this.method_57(str, str1);
						if (gClass12 == null)
						{
							string[] strArrays = new string[] { "该产品【", str1, "】已经退出鹊桥计划【", str, "】！" };
							this.method_115(string.Concat(strArrays));
							return;
						}
					}
					else
					{
						this.method_115("获取推广链接失败，【登录阿里妈妈】以后重试一次重新获取！");
						this.bool_0 = false;
						this.method_7();
						return;
					}
				}
				this.method_63(string.Concat(gClass12.string_4, "_200x200.jpg"));
				this.pictureBoxItemPic.Width = 200;
				this.pictureBoxItemPic.Height = 200;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[pictureBoxItemPic_MouseLeave]出错了！", exception.ToString()));
		}
	}

	private void pictureBoxOnlineItemPic_MouseHover(object sender, EventArgs e)
	{
		try
		{
			if ((this.dataGridViewOnlineBrdg.CurrentCell == null ? false : this.pictureBoxOnlineItemPic.Image != null))
			{
				ᜭ tag = (ᜭ)this.dataGridViewOnlineBrdg.CurrentRow.Tag;
				this.method_283(string.Concat(GClass13.string_4, tag.ᜄ, "_400x400.jpg"));
				PictureBox point = this.pictureBoxOnlineItemPic;
				Point location = this.pictureBoxOnlineItemPic.Location;
				point.Location = new Point(846, location.Y);
				this.pictureBoxOnlineItemPic.Width = 400;
				this.pictureBoxOnlineItemPic.Height = 400;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[pictureBoxOnlineItemPic_MouseHover]出错了！", exception.ToString()));
		}
	}

	private void pictureBoxOnlineItemPic_MouseLeave(object sender, EventArgs e)
	{
		try
		{
			if ((this.dataGridViewOnlineBrdg.CurrentCell == null ? false : this.pictureBoxOnlineItemPic.Image != null))
			{
				ᜭ tag = (ᜭ)this.dataGridViewOnlineBrdg.CurrentRow.Tag;
				this.method_283(string.Concat(GClass13.string_4, tag.ᜄ, "_160x160.jpg"));
				PictureBox point = this.pictureBoxOnlineItemPic;
				Point location = this.pictureBoxOnlineItemPic.Location;
				point.Location = new Point(1086, location.Y);
				this.pictureBoxOnlineItemPic.Width = 160;
				this.pictureBoxOnlineItemPic.Height = 160;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[pictureBoxOnlineItemPic_MouseLeave]出错了！", exception.ToString()));
		}
	}

	private void radioButtonBrdgMApp_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.radioButtonBrdgMApp.Checked ? false : !this.bool_31))
		{
			this.method_299(0);
		}
	}

	private void radioButtonBrdgMOth_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.radioButtonBrdgMOth.Checked ? false : !this.bool_31))
		{
			this.method_299(0);
		}
	}

	private void radioButtonBrdgMWeb_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.radioButtonBrdgMWeb.Checked ? false : !this.bool_31))
		{
			this.method_299(0);
		}
	}

	private void radioButtonCmMApp_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.radioButtonCmMApp.Checked ? false : !this.bool_30))
		{
			this.method_297(0);
		}
	}

	private void radioButtonCmMOth_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.radioButtonCmMOth.Checked ? false : !this.bool_30))
		{
			this.method_297(0);
		}
	}

	private void radioButtonCmMWeb_CheckedChanged(object sender, EventArgs e)
	{
		if ((!this.radioButtonCmMWeb.Checked ? false : !this.bool_30))
		{
			this.method_297(0);
		}
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern bool RegisterHotKey(IntPtr intptr_1, int int_28, AliBridgeForm.GEnum2 genum2_0, Keys keys_0);

	public void richTextBoxSts_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		Process.Start(e.LinkText);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern void SetForegroundWindow(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern bool ShowWindowAsync(IntPtr intptr_1, int int_28);

	private void tabControlHotShare_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.int_17 == 0)
		{
			this.tabPageSelfHotshare.Controls.Remove(this.groupBox37);
			this.tabPageSelfHotshare.Controls.Remove(this.dataGridViewHotShare);
		}
		else if (this.int_17 == 1)
		{
			this.tabPageSelHotShare.Controls.Remove(this.groupBox37);
			this.tabPageSelHotShare.Controls.Remove(this.dataGridViewHotShare);
		}
		else if (this.int_17 == 2)
		{
			this.tabPageShareHotShare.Controls.Remove(this.groupBox37);
			this.tabPageShareHotShare.Controls.Remove(this.dataGridViewHotShare);
		}
		else if (this.int_17 == 3)
		{
			this.tabPageMutualHotShare.Controls.Remove(this.groupBox37);
			this.tabPageMutualHotShare.Controls.Remove(this.dataGridViewHotShare);
		}
		if (this.tabControlHotShare.SelectedIndex == 0)
		{
			this.tabPageSelfHotshare.Controls.Add(this.groupBox37);
			this.tabPageSelfHotshare.Controls.Add(this.dataGridViewHotShare);
			if (this.textBoxHotShareKW.Text.Trim().Equals(""))
			{
				this.method_187(this.arrayList_7);
			}
		}
		else if (this.tabControlHotShare.SelectedIndex == 1)
		{
			this.tabPageSelHotShare.Controls.Add(this.groupBox37);
			this.tabPageSelHotShare.Controls.Add(this.dataGridViewHotShare);
			if (this.textBoxHotShareKW.Text.Trim().Equals(""))
			{
				this.method_187(this.arrayList_8);
			}
		}
		else if (this.tabControlHotShare.SelectedIndex == 2)
		{
			this.tabPageShareHotShare.Controls.Add(this.groupBox37);
			this.tabPageShareHotShare.Controls.Add(this.dataGridViewHotShare);
			if (this.textBoxHotShareKW.Text.Trim().Equals(""))
			{
				this.method_187(this.arrayList_9);
			}
		}
		else if (this.tabControlHotShare.SelectedIndex == 3)
		{
			this.tabPageMutualHotShare.Controls.Add(this.groupBox37);
			this.tabPageMutualHotShare.Controls.Add(this.dataGridViewHotShare);
			if (this.textBoxHotShareKW.Text.Trim().Equals(""))
			{
				this.method_187(this.arrayList_10);
			}
		}
		this.int_17 = this.tabControlHotShare.SelectedIndex;
	}

	private void textBoxBrdgId_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxBrdgId.Text = "";
	}

	private void textBoxBrdgId_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_68();
		}
	}

	private void textBoxCms_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxCms.Text = "";
	}

	private void textBoxCms_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_70();
		}
	}

	private void textBoxCMSHiP_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxCMSHiP.Text = "";
	}

	private void textBoxCMSHiP_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_70();
		}
	}

	private void textBoxCMSLowP_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxCMSLowP.Text = "";
	}

	private void textBoxCMSLowP_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_70();
		}
	}

	private void textBoxHotShareKW_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxHotShareKW.Text = "";
		this.method_192();
	}

	private void textBoxHotShareKW_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_192();
		}
	}

	private void textBoxItemId_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxItemId.Text = "";
	}

	private void textBoxItemId_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_67();
		}
	}

	private void textBoxKeyword_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxKeyword.Text = "";
	}

	private void textBoxKeyword_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_69();
		}
	}

	private void textBoxKWHiP_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxKWHiP.Text = "";
	}

	private void textBoxKWHiP_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_69();
		}
	}

	private void textBoxKWLowP_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxKWLowP.Text = "";
	}

	private void textBoxKWLowP_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_69();
		}
	}

	private void textBoxNotFwHour_MouseEnter(object sender, EventArgs e)
	{
		this.toolTip_0.ToolTipTitle = "请输入多长时间内重复的产品不发送";
		this.toolTip_0.IsBalloon = false;
		this.toolTip_0.UseFading = true;
		this.toolTip_0.Show("如果不需要去重复功能，填数字【0】！", this.textBoxNotFwHour);
	}

	private void textBoxNotFwHour_MouseLeave(object sender, EventArgs e)
	{
		this.toolTip_0.Hide(this.textBoxNotFwHour);
	}

	private void textBoxOHiPrice_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxOHiPrice.Text = "";
	}

	private void textBoxOItemId_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxOItemId.Text = "";
	}

	private void textBoxOItemId_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_271();
		}
	}

	private void textBoxOLowPrice_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxOLowPrice.Text = "";
	}

	private void textBoxOSchKey_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxOSchKey.Text = "";
	}

	private void textBoxOSchKey_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			this.method_274();
		}
	}

	private void textBoxTklUrl_DoubleClick(object sender, EventArgs e)
	{
		this.textBoxTklUrl.Text = "";
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!this.bool_22)
		{
			this.Text = this.string_54;
		}
		else if (!this.Text.Contains(this.string_55))
		{
			this.Text = string.Concat(this.string_54, this.string_55);
		}
		else
		{
			this.Text = this.string_54;
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		try
		{
			this.timer_1.Stop();
			this.webBrowserTaoQiang.Navigate("https://qiang.taobao.com");
			DateTime now = DateTime.Now;
			this.long_0 = long.Parse(string.Concat(now.ToString("yyyyMMdd"), "00"));
			this.timer_1 = new System.Windows.Forms.Timer()
			{
				Interval = 5000
			};
			this.timer_1.Tick += new EventHandler(this.timer_1_Tick_1);
			this.timer_1.Start();
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[startCollectTaoQiang]出错：", exception.ToString()));
		}
	}

	public void timer_1_Tick_1(object sender, EventArgs e)
	{
		try
		{
			this.timer_1.Stop();
			this.method_115("正在获取所有时间轴DIV！");
			this.int_18 = 0;
			this.arrayList_13 = new ArrayList();
			HtmlElement htmlElement = this.method_214(this.webBrowserTaoQiang.Document.Body, "DIV", "className", "scrollable-wrap");
			foreach (HtmlElement child in htmlElement.Children)
			{
				GClass18 gClass18 = new GClass18()
				{
					string_0 = child.GetAttribute("data-batchId"),
					string_1 = child.GetAttribute("data-starttime"),
					string_2 = child.GetAttribute("data-endtime")
				};
				if (long.Parse(gClass18.string_1.Substring(0, 10)) < this.long_0)
				{
					continue;
				}
				this.arrayList_13.Add(gClass18);
			}
			this.method_115(string.Concat("获取所有时间轴DIV成功，共【", this.arrayList_13.Count, "】个时间点！"));
			this.timer_1 = new System.Windows.Forms.Timer()
			{
				Interval = 8000
			};
			this.timer_1.Tick += new EventHandler(this.timer_1_Tick_2);
			this.timer_1.Start();
		}
		catch
		{
			this.method_212();
		}
	}

	public void timer_1_Tick_2(object sender, EventArgs e)
	{
		try
		{
			this.timer_1.Stop();
			if (this.int_18 < this.arrayList_13.Count)
			{
				GClass18 item = (GClass18)this.arrayList_13[this.int_18];
				object[] int18 = new object[] { "正在获取第【", this.int_18 + 1, "】个时间点产品【", item.string_1, "】！" };
				this.method_115(string.Concat(int18));
				HtmlElement htmlElement = null;
				HtmlElement htmlElement1 = this.method_214(this.webBrowserTaoQiang.Document.Body, "DIV", "className", "scrollable-wrap");
				IEnumerator enumerator = htmlElement1.Children.GetEnumerator();
				try
				{
					while (true)
					{
						if (enumerator.MoveNext())
						{
							HtmlElement current = (HtmlElement)enumerator.Current;
							if (item.string_0.Equals(current.GetAttribute("data-batchid")))
							{
								htmlElement = current;
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
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				htmlElement.InvokeMember("click");
				this.timer_1 = new System.Windows.Forms.Timer()
				{
					Interval = 8000
				};
				this.timer_1.Tick += new EventHandler(this.timer_1_Tick_3);
				this.timer_1.Start();
			}
			else
			{
				(new Thread(new ThreadStart(this.method_213))).Start();
			}
		}
		catch
		{
			this.method_212();
		}
	}

	public void timer_1_Tick_3(object sender, EventArgs e)
	{
		// 
		// Current member / type: System.Void AliBridgeForm::timer_1_Tick_3(System.Object,System.EventArgs)
		// File path: E:\taoke\千语淘客助手\千语淘客助手-cleaned.exe
		// 
		// Product version: 2016.3.1003.0
		// Exception in: System.Void timer_1_Tick_3(System.Object,System.EventArgs)
		// 
		// 未将对象引用设置到对象的实例。
		//    在 ..( , Int32 , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\ObjectInitialisationPattern.cs:行号 78
		//    在 ..( , Int32& , & , Int32& ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatterns\BaseInitialisationPattern.cs:行号 33
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 57
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 436
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 73
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 477
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 83
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..Visit[,]( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 280
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 311
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 331
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 39
		//    在 ..( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 49
		//    在 ..Visit( ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:行号 270
		//    在 ..( ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Steps\CodePatternsStep.cs:行号 33
		//    在 ..(MethodBody ,  , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 88
		//    在 ..(MethodBody , ILanguage ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:行号 70
		//    在 ..( , ILanguage , MethodBody , & ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 95
		//    在 ..(MethodBody , ILanguage , & ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:行号 58
		//    在 ..(ILanguage , MethodDefinition ,  ) 位置 c:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:行号 117
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public void timer_1_Tick_4(object sender, EventArgs e)
	{
		try
		{
			this.timer_1.Stop();
			if (!this.bool_25)
			{
				this.timer_1 = new System.Windows.Forms.Timer()
				{
					Interval = 1000
				};
				this.timer_1.Tick += new EventHandler(this.timer_1_Tick_4);
				this.timer_1.Start();
			}
			else
			{
				this.method_115("采集完成！");
			}
		}
		catch
		{
			this.method_212();
		}
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern bool UnregisterHotKey(IntPtr intptr_1, int int_28);

	private void webBrowserHotShare_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		char[] chrArray;
		try
		{
			if (this.webBrowserHotShare.ReadyState == WebBrowserReadyState.Complete)
			{
				if (e.Url.ToString() == this.webBrowserHotShare.Url.ToString())
				{
					string str = this.webBrowserHotShare.Url.ToString();
					if ((!str.Contains("#") ? false : !this.string_94.Contains("selhotshare")))
					{
						if (str.Contains(";"))
						{
							chrArray = new char[] { ';' };
							this.method_388(str.Split(chrArray)[1]);
						}
						else if (!str.Contains("$"))
						{
							chrArray = new char[] { '#' };
							string str1 = str.Split(chrArray)[1];
							string[] strArrays = new string[] { "http://", ᝮ.ᜅ, "/selhotshare/", str1, "/hot.html" };
							string str2 = string.Concat(strArrays);
							this.webBrowserHotShare.Navigate(str2);
							this.buttonSelHotAddManul.Tag = str1;
							this.buttonSelHotAddFollow.Tag = str1;
							this.method_390(true);
						}
						else
						{
							chrArray = new char[] { '$' };
							this.method_387(str.Split(chrArray)[1]);
						}
					}
					this.string_94 = str;
				}
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[webBrowserHotShare_DocumentCompleted]出错，", exception.ToString()));
		}
	}

	private void webBrowserSendContent_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		try
		{
			if ((e.Modifiers != Keys.Control ? false : e.KeyCode == Keys.V))
			{
				try
				{
					Image image = null;
					Image image1 = Clipboard.GetImage();
					image = image1;
					if (image1 != null)
					{
						DateTime now = DateTime.Now;
						string str = string.Concat(now.ToString("yyyyMMddHHmmssfff"), ".png");
						string str1 = string.Concat(this.string_53, "\\", str);
						image.Save(str1, ImageFormat.Png);
						string str2 = "<IMG src=\"file:///{imgfile}\">".Replace("{imgfile}", str1);
						Clipboard.SetData(DataFormats.Html, str2);
					}
				}
				catch (Exception exception)
				{
					this.method_115(exception.ToString());
				}
			}
		}
		catch (Exception exception1)
		{
			this.method_115(string.Concat("[webBrowserSendContent_PreviewKeyDown]出错：", exception1.ToString()));
		}
	}

	protected override void WndProc(ref Message message_0)
	{
		try
		{
			if (message_0.Msg != 786)
			{
				base.WndProc(ref message_0);
			}
			else if (message_0.WParam.ToInt32() == 10)
			{
				this.method_115("按CTRL+F12，停止！");
				this.bool_20 = true;
				try
				{
					this.thread_1.Resume();
				}
				catch
				{
				}
				try
				{
					this.thread_1.Abort();
				}
				catch
				{
				}
				this.method_154(1, true, "发送");
				this.method_154(2, false, "");
				this.method_154(3, false, "");
				this.bool_19 = false;
			}
		}
		catch (Exception exception)
		{
			this.method_115(string.Concat("[WndProc]出错，", exception.ToString()));
		}
	}

	public delegate void GDelegate100();

	public delegate void GDelegate101(ArrayList arrayList_0);

	public delegate void GDelegate102(ArrayList arrayList_0);

	public delegate void GDelegate103(ArrayList arrayList_0);

	public delegate void GDelegate104(int int_0, bool bool_0);

	public delegate void GDelegate105(bool bool_0);

	public delegate void GDelegate54(string string_0);

	public delegate void GDelegate55(string string_0);

	public delegate string GDelegate56();

	public delegate void GDelegate57(FormWindowState formWindowState_0);

	public delegate void GDelegate58(ArrayList arrayList_0, ArrayList arrayList_1);

	public delegate void GDelegate59(int int_0, bool bool_0);

	public delegate void GDelegate60(int int_0, bool bool_0);

	public delegate void GDelegate61();

	public delegate void GDelegate62();

	public delegate void GDelegate63();

	public delegate void GDelegate64(ArrayList arrayList_0);

	public delegate void GDelegate65(string string_0);

	public delegate bool GDelegate66(IntPtr intptr_0, IntPtr intptr_1);

	public delegate void GDelegate67(string string_0);

	public delegate void GDelegate68(int int_0, bool bool_0, string string_0);

	public delegate void GDelegate69(string string_0);

	public delegate void GDelegate70();

	public delegate void GDelegate71(int int_0, bool bool_0);

	public delegate void GDelegate72();

	public delegate void GDelegate73(GClass15 gclass15_0);

	public delegate void GDelegate74();

	public delegate void GDelegate75();

	public delegate void GDelegate76(LinkLabel linkLabel_0, string string_0);

	public delegate void GDelegate77(LinkLabel linkLabel_0, GClass16 gclass16_0);

	public delegate bool GDelegate78();

	public delegate void GDelegate79(ArrayList arrayList_0);

	public delegate void GDelegate80();

	public delegate void GDelegate81(᝘ u1758_0);

	public delegate void GDelegate82();

	public delegate void GDelegate83(int int_0, bool bool_0);

	public delegate void GDelegate84(ArrayList arrayList_0);

	public delegate void GDelegate85(string string_0);

	public delegate void GDelegate86();

	public delegate void GDelegate87(string string_0);

	public delegate void GDelegate88(ArrayList arrayList_0);

	public delegate void GDelegate89(int int_0, bool bool_0);

	public delegate void GDelegate90(string string_0);

	public delegate void GDelegate91(string string_0);

	public delegate void GDelegate92(bool bool_0);

	public delegate void GDelegate93(int int_0, bool bool_0);

	public delegate void GDelegate94(ArrayList arrayList_0);

	public delegate void GDelegate95(int int_0, int int_1, int int_2);

	public delegate void GDelegate96(bool bool_0);

	public delegate void GDelegate97();

	public delegate void GDelegate98(ArrayList arrayList_0);

	public delegate void GDelegate99(int int_0, bool bool_0);

	[Flags]
	public enum GEnum2
	{
		flag_0 = 0,
		flag_1 = 1,
		flag_2 = 2,
		flag_3 = 4,
		flag_4 = 8
	}
}