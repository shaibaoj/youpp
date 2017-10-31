using mshtml;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 阿里妈妈登录
{
	public class AlimamaLoginForm : Form
	{
		private IContainer icontainer_0 = null;

		private RichTextBox richTextBoxSts;

		private WebBrowser webBrowserLoginAlimama;

		private System.Windows.Forms.Timer timer_login;

		private GroupBox groupBoxUUCode;

		private PictureBox pictureBoxVerify;

		private TextBox textBoxVerify;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripLoginPage;

		private System.Windows.Forms.Timer timer_restart;

		private int verision = 13;

		public string basePath = Application.StartupPath;

		public string username = "";
		public string password = "";
		private string uu_username = "";
		private string uu_pwd = "";
		public string mainFormTitle = "";

        //private string string_2 = "https://login.taobao.com/member/login.jhtml?style=mini&from=alimama&redirectURL=http%3A%2F%2Flogin.taobao.com%2Fmember%2Ftaobaoke%2Flogin.htm%3Fis_login%3d1&amp;full_redirect=true&disableQuickLogin=true";
        //private string string_3 = "https://login.taobao.com/member/login.jhtml?style=mini&newMini2=true&css_style=alimama&from=alimama&redirectURL=http%3A%2F%2Fwww.alimama.com&full_redirect=true&disableQuickLogin=true";
        //private string string_4 = "https://login.taobao.com/member/login.jhtml?from=alimama&redirectURL=http%3A%2F%2Flogin.taobao.com%2Fmember%2Ftaobaoke%2Flogin.htm%3Fis_login%3d1";
        private string login_url_manual = "http://login.taobao.com/member/login.jhtml?&css_style=pinxiaobao&style=mini&newMini2=true&from=alimama&redirectURL=http%3A%2F%2Flogin.taobao.com%2Fmember%2Ftaobaoke%2Flogin.htm%3Fis_login%3d1&full_redirect=true";
        private string login_url = "http://login.taobao.com/member/login.jhtml?&css_style=pinxiaobao&style=mini&newMini2=true&from=alimama&redirectURL=http%3A%2F%2Flogin.taobao.com%2Fmember%2Ftaobaoke%2Flogin.htm%3Fis_login%3d1&full_redirect=true";
        private string login_url_scan = "http://login.taobao.com/member/login.jhtml?style=mini&newMini2=true&from=alimama&redirectURL=http%3A%2F%2Flogin.taobao.com%2Fmember%2Ftaobaoke%2Flogin.htm%3Fis_login%3d1&full_redirect=true";

		public bool logined = false;

		public int loginErrCnt = 0;

		private string string_4 = "";

		private int int_1 = 0;

		private int int_2 = 0;

		public Image clipboard = null;

		public bool completeWordVerrify = false;

		public int wordx = 0;

		public int wordy = 0;

		private string string_5 = "43b8acbd05a773df1f335a33f0e2f4fb";

		public string img1 = "";

		public string img2 = "";

		private IHTMLDocument2 ihtmldocument2_0 = null;

		private string string_6 = "";

		private string string_7 = "";

		private UUWise uuwise_0 = new UUWise();

		private bool bool_0 = false;

		private Image image_0 = null;

		public AlimamaLoginForm(string[] args)
		{
			try
			{
				if ((args == null ? true : (int)args.Length == 0))
				{
					MessageBox.Show(string.Concat("版本：[V", this.verision, "]，本程序不能手动打开！"));
					Environment.Exit(-1);
				}
				if (args[0].Contains("CheckUpdVersion"))
				{
					Environment.Exit(this.verision);
				}
				this.InitializeComponent();
				base.FormClosing += new FormClosingEventHandler(this.AlimamaLoginForm_FormClosing);
				UserAgentHelper.AppendUserAgent("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
				this.webBrowserLoginAlimama.ScriptErrorsSuppressed = true;
				this.webBrowserLoginAlimama.IsWebBrowserContextMenuEnabled = false;
				this.method_0();
				this.method_10(string.Concat("当前IE版本：[", this.webBrowserLoginAlimama.Version.ToString(), "]"));
				int num = 0;
				int num1 = 0;
                num = num1 + 1;
                this.mainFormTitle = args[num1];

                //this.method_10(string.Concat("mainFormTitle：[", this.mainFormTitle, "]"));

				int num2 = 2;
				num = num2 + 1;
				if (int.Parse(args[num2]) != 1)
				{
                    //this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
                    this.webBrowserLoginAlimama.Navigate(this.login_url_manual, "_self", null, "Referer:https://www.alimama.com/index.htm");

                    (new Thread(new ThreadStart(this.checkManualLogin))).Start();
				}
				else
				{
                    //this.webBrowserLoginAlimama.Navigate(this.login_url);
                    this.webBrowserLoginAlimama.Navigate(this.login_url, "_self", null, "Referer:https://www.alimama.com/index.htm");
					int num3 = num;
					num = num3 + 1;
					this.username = args[num3];
					int num4 = num;
					num = num4 + 1;
					this.password = args[num4];
					int num5 = num;
					num = num5 + 1;
					if (int.Parse(args[num5]) != 1)
					{
						this.uu_username = "";
						this.uu_pwd = "";
					}
					else
					{
						int num6 = num;
						num = num6 + 1;
						this.uu_username = args[num6];
						int num7 = num;
						num = num7 + 1;
						this.uu_pwd = args[num7];
					}
					this.Text = string.Concat(this.Text, " - 自动登录模式，如果没出错，不要手动操作");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_login_Tick);
					this.timer_login.Start();

					this.timer_restart = new System.Windows.Forms.Timer()
					{
						Interval = 90000
					};
					this.timer_restart.Tick += new EventHandler(this.timer_restart_Tick);
					this.timer_restart.Start();
					(new Thread(new ThreadStart(this.checkAutoLogin))).Start();
				}
				(new Thread(new ThreadStart(this.setWindowFront))).Start();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				if (!exception.ToString().Contains("System.IndexOutOfRangeException"))
				{
					this.method_10(string.Concat("[AlimamaLoginForm]出错！", exception.ToString()));
				}
				else
				{
					this.sendMsgToMainFormAndExit("close", CUtil.FORM_MSG_TYPE_CLOSENOTLOGINED);
				}
			}
		}

		private void AlimamaLoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				base.Visible = true;
				string cookieString = GetCookie.GetCookieString("http://www.alimama.com");
				if (!AlimamaSvc.checkAlimamaLogin(cookieString))
				{
					this.sendMsgToMainFormAndExit("close", CUtil.FORM_MSG_TYPE_CLOSENOTLOGINED);
				}
				else
				{
					this.sendMsgToMainFormAndExit(cookieString, CUtil.FORM_MSG_TYPE_LOGINED);
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[FormClosingProcess]出错，", exception.ToString()));
			}
		}

		public void checkAutoLogin()
		{
			try
			{
				while (true)
				{
					if (!this.logined)
					{
						Thread.Sleep(100);
					}
					else
					{
						this.sendMsgToMainFormAndExit(GetCookie.GetCookieString("http://www.alimama.com"), CUtil.FORM_MSG_TYPE_LOGINED);
					}
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[checkAutoLogin]出错！", exception.ToString()));
			}
		}

		public void checkManualLogin()
		{
			try
			{
				while (true)
				{
					string cookieString = GetCookie.GetCookieString("http://www.alimama.com");
					if (!AlimamaSvc.checkAlimamaLogin(cookieString))
					{
						Thread.Sleep(2000);
					}
					else
					{
						base.Visible = true;
						this.sendMsgToMainFormAndExit(cookieString, CUtil.FORM_MSG_TYPE_LOGINED);
					}
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[checkManualLogin]出错！", exception.ToString()));
			}
		}

		public void cleanCookie()
		{
			try
			{
				GetCookie.clearIECookie();
				string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies), "*", SearchOption.AllDirectories);
				string[] strArrays = files;
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					string str = strArrays[i];
					try
					{
						File.Delete(str);
					}
					catch
					{
					}
				}
				this.webBrowserLoginAlimama.Document.Cookie.Remove(0, this.webBrowserLoginAlimama.Document.Cookie.Length);
			}
			catch (Exception exception)
			{
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

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern IntPtr FindWindow(string string_8, string string_9);

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern IntPtr FindWindowEx(IntPtr intptr_0, uint uint_0, string string_8, string string_9);

		public void GetClipboardImage()
		{
			try
			{
				if (!base.InvokeRequired)
				{
					this.clipboard = Clipboard.GetImage();
				}
				else
				{
					AlimamaLoginForm.GetClipboardImageDelegate getClipboardImageDelegate = new AlimamaLoginForm.GetClipboardImageDelegate(this.GetClipboardImage);
					base.BeginInvoke(getClipboardImageDelegate, new object[0]);
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[GetClipboardImage]出错：", exception.ToString()));
			}
		}

		public Point GetOffset(HtmlElement htmlElement_0)
		{
			Point point;
			try
			{
				int left = htmlElement_0.OffsetRectangle.Left;
				Rectangle offsetRectangle = htmlElement_0.OffsetRectangle;
				Point top = new Point(left, offsetRectangle.Top);
				for (HtmlElement i = htmlElement_0.OffsetParent; i != null; i = i.OffsetParent)
				{
					int x = top.X;
					offsetRectangle = i.OffsetRectangle;
					top.X = x + offsetRectangle.Left;
					int y = top.Y;
					offsetRectangle = i.OffsetRectangle;
					top.Y = y + offsetRectangle.Top;
				}
				point = top;
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[GetOffset]出错！", exception.ToString()));
				point = new Point(0, 0);
			}
			return point;
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AlimamaLoginForm));
			this.groupBoxUUCode = new GroupBox();
			this.pictureBoxVerify = new PictureBox();
			this.textBoxVerify = new TextBox();
			this.richTextBoxSts = new RichTextBox();
			this.webBrowserLoginAlimama = new WebBrowser();
			this.contextMenuStripLoginPage = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.timer_login = new System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_restart = new System.Windows.Forms.Timer(this.icontainer_0);
			this.groupBoxUUCode.SuspendLayout();
			((ISupportInitialize)this.pictureBoxVerify).BeginInit();
			base.SuspendLayout();
			this.groupBoxUUCode.Controls.Add(this.pictureBoxVerify);
			this.groupBoxUUCode.Controls.Add(this.textBoxVerify);
			this.groupBoxUUCode.Location = new Point(8, 12);
			this.groupBoxUUCode.Name = "groupBoxUUCode";
			this.groupBoxUUCode.Size = new System.Drawing.Size(258, 66);
			this.groupBoxUUCode.TabIndex = 27;
			this.groupBoxUUCode.TabStop = false;
			this.groupBoxUUCode.Text = "打码区";
			this.groupBoxUUCode.Visible = false;
			this.pictureBoxVerify.BackColor = Color.LightGray;
			this.pictureBoxVerify.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBoxVerify.Location = new Point(14, 18);
			this.pictureBoxVerify.Name = "pictureBoxVerify";
			this.pictureBoxVerify.Size = new System.Drawing.Size(150, 40);
			this.pictureBoxVerify.TabIndex = 16;
			this.pictureBoxVerify.TabStop = false;
			this.textBoxVerify.Location = new Point(170, 28);
			this.textBoxVerify.Name = "textBoxVerify";
			this.textBoxVerify.ReadOnly = true;
			this.textBoxVerify.Size = new System.Drawing.Size(71, 21);
			this.textBoxVerify.TabIndex = 17;
			this.richTextBoxSts.Location = new Point(4, 471);
			this.richTextBoxSts.Name = "richTextBoxSts";
			this.richTextBoxSts.ReadOnly = true;
			this.richTextBoxSts.Size = new System.Drawing.Size(767, 73);
			this.richTextBoxSts.TabIndex = 30;
			this.richTextBoxSts.Text = "";
			this.webBrowserLoginAlimama.ContextMenuStrip = this.contextMenuStripLoginPage;
			this.webBrowserLoginAlimama.Location = new Point(8, 12);
			this.webBrowserLoginAlimama.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowserLoginAlimama.Name = "webBrowserLoginAlimama";
			this.webBrowserLoginAlimama.Size = new System.Drawing.Size(767, 453);
			this.webBrowserLoginAlimama.TabIndex = 29;
			this.contextMenuStripLoginPage.Name = "contextMenuStripLoginPage";
			this.contextMenuStripLoginPage.Size = new System.Drawing.Size(61, 4);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(783, 553);
			base.Controls.Add(this.groupBoxUUCode);
			base.Controls.Add(this.richTextBoxSts);
			base.Controls.Add(this.webBrowserLoginAlimama);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AlimamaLoginForm";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "阿里妈妈登录V"+this.verision;
			this.groupBoxUUCode.ResumeLayout(false);
			this.groupBoxUUCode.PerformLayout();
			((ISupportInitialize)this.pictureBoxVerify).EndInit();
			base.ResumeLayout(false);
		}

		public void messageForThread(string string_8)
		{
			try
			{
				if (!this.richTextBoxSts.InvokeRequired)
				{
					this.method_10(string_8);
				}
				else
				{
					AlimamaLoginForm.MsgDelegate msgDelegate = new AlimamaLoginForm.MsgDelegate(this.messageForThread);
					object[] string8 = new object[] { string_8 };
					base.BeginInvoke(msgDelegate, string8);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				MessageBox.Show(string.Concat("[messageForThread]出错：", exception.ToString()));
			}
		}

		private void method_0()
		{
			try
			{
				this.contextMenuStripLoginPage.Items.Add("刷新页面");
				this.contextMenuStripLoginPage.Items[0].Click += new EventHandler(this.method_1);
				this.contextMenuStripLoginPage.Items.Add("重新打开");
				this.contextMenuStripLoginPage.Items[1].Click += new EventHandler(this.method_2);
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[initContextMenuStripLoginPage]出错：", exception.ToString()));
			}
		}

		private void method_1(object sender, EventArgs e)
		{
			try
			{
				this.webBrowserLoginAlimama.Refresh();
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[RefreshPage_Click]出错：", exception.ToString()));
			}
		}

		private void method_10(string string_8)
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
					str[2] = string_8;
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
					str[2] = string_8;
					str[3] = "\n";
					str[4] = text.Substring(0, 5000);
					richTextBox1.Text = string.Concat(str);
				}
			}
			catch
			{
				this.messageForThread(string_8);
			}
		}

		private void method_2(object sender, EventArgs e)
		{
			try
			{
				this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[RefreshPage_Click]出错：", exception.ToString()));
			}
		}

		private void method_3(object sender, EventArgs e)
		{
			try
			{
				this.timer_login.Stop();
				this.sendMsgToMainFormAndExit("close", CUtil.FORM_MSG_TYPE_CLOSENOTLOGINED);
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[exitWithOutLogin]出错！", exception.ToString()));
			}
		}

		private Point method_4(Control control_0)
		{
			Point point;
			try
			{
				Point x = new Point(control_0.Left, control_0.Top);
				for (Control i = control_0.Parent; i != null; i = i.Parent)
				{
					x.X = x.X + i.Left;
					x.Y = x.Y + i.Top;
				}
				point = x;
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[GetFormOffset]出错！", exception.ToString()));
				point = new Point(0, 0);
			}
			return point;
		}

		private void method_5(object object_0)
		{
			int num = int.Parse(object_0.ToString());
			try
			{
				MockInput.mouseMove(this.int_1, this.int_2, this.int_1 + num);
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[drag]出错了！", exception.ToString()));
			}
		}

		private void method_6()
		{
			this.method_10("正在【打码】，一般需要5-30秒！");
			this.saveCodeImage();
			int num = 0;
			while (true)
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder(100);
					Dama2.D2File(this.string_5, this.uu_username, this.uu_pwd, this.img2, 30, 285, stringBuilder);
					if (!stringBuilder.ToString().Contains(","))
					{
						this.method_10("打码结果不正确，等待10秒重新打码！");
					}
					else
					{
						this.completeWordVerrify = true;
						string str = stringBuilder.ToString();
						char[] chrArray = new char[] { ',' };
						this.wordx = int.Parse(str.Split(chrArray)[0]);
						string str1 = stringBuilder.ToString();
						chrArray = new char[] { ',' };
						this.wordy = int.Parse(str1.Split(chrArray)[1]);
						this.method_10("打码完成！");
						break;
					}
				}
				catch (Exception exception)
				{
					this.method_10(string.Concat("[recogniseWord]出错了，等待10秒重新打码！", exception.ToString()));
				}
				if (num <= 3)
				{
					Thread.Sleep(10000);
				}
				else
				{
					this.completeWordVerrify = true;
					this.wordx = 0;
					this.wordy = 0;
					break;
				}
			}
		}

		private void method_7(object sender, EventArgs e)
		{
			try
			{
				if (this.textBoxVerify.Text.Length > 0)
				{
					this.method_10("完成【验证码】输入！");
					HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("J_CodeInput_i");
					elementById.InvokeMember("focue");
					elementById.InvokeMember("click");
					elementById.SetAttribute("value", this.textBoxVerify.Text);
					HtmlElement htmlElement = this.webBrowserLoginAlimama.Document.GetElementById("TPL_password_1");
					htmlElement.InvokeMember("click");
					htmlElement.SetAttribute("value", this.password);
					HtmlElement elementById1 = this.webBrowserLoginAlimama.Document.GetElementById("J_SubmitStatic");
					elementById1.InvokeMember("click");
					this.textBoxVerify.Text = "";
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 800
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
					this.SetVerifyVisible(false);
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[textBoxVerify_TextChanged]出错了！", exception.ToString()));
			}
		}

		private void method_8()
		{
			try
			{
				this.method_10("正在登录UU打码平台！");
				string str = this.uuwise_0.login(this.string_6, this.string_7);
				this.bool_0 = true;
				this.method_10(str);
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[uuWiseLogin]出错了！", exception.ToString()));
			}
		}

		private void method_9()
		{
			try
			{
				this.method_10("正在识别验证码！");
				string str = this.uuwise_0.recogniseImg(this.image_0);
				if (!str.Equals("TIMEOUT"))
				{
					this.SetTextBoxVerify(str);
					this.method_10(string.Concat("验证码识别成功，验证码：【", str, "】！"));
				}
				else
				{
					this.method_10("打码超时，正在重新打码。");
					Thread.Sleep(100);
					this.method_9();
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[recogniseCode]打码出错，正在重新打。", exception.ToString()));
				Thread.Sleep(100);
				this.method_9();
			}
		}

		public void saveCodeImage()
		{
			try
			{
				this.method_10("开始获取图片");
				Thread.Sleep(1500);
				this.clipboard = null;
				this.GetClipboardImage();
				Thread.Sleep(300);
				Image image = this.clipboard;
				if (image != null)
				{
					this.method_10("获取图片成功！");
				}
				else
				{
					this.method_10("获取图片为空！");
				}
				Thread.Sleep(500);
				if (File.Exists(this.img1))
				{
					File.Delete(this.img1);
				}
				image.Save(this.img1);
				this.method_10("保存图片成功！");
				Thread.Sleep(500);
				Bitmap bitmap = new Bitmap(this.img1);
				Graphics graphic = Graphics.FromImage(bitmap);
				string str = string.Concat("请点图中【", this.string_4, "】");
				System.Drawing.Font font = new System.Drawing.Font("宋体", 12f);
				SolidBrush solidBrush = new SolidBrush(Color.Black);
				graphic.DrawString(str, font, solidBrush, new PointF(10f, 10f));
				bitmap.Save(this.img2, ImageFormat.Png);
				bitmap.Dispose();
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[saveCodeImage]出错！ex1:", exception.ToString()));
			}
		}

		[DllImport("User32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SendMessage(IntPtr intptr_0, int int_3, int int_4, int int_5);

		public void sendMsgToMainFormAndExit(string string_8, int msgtyp)
		{
			IntPtr intPtr;
			try
			{
				int num = 0;
				while (true)
				{
					IntPtr intPtr1 = AlimamaLoginForm.FindWindow(null, this.mainFormTitle);
					intPtr = intPtr1;
					if (!(intPtr1 == IntPtr.Zero) || num > 40)
					{
						break;
					}
					num++;
					Thread.Sleep(100);
				}
				if (intPtr == IntPtr.Zero)
				{
					Environment.Exit(0);
				}
				UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
				char[] chars = unicodeEncoding.GetChars(unicodeEncoding.GetBytes(string_8));
				for (int i = 0; i < (int)chars.Length; i++)
				{
					char chr = chars[i];
					AlimamaLoginForm.SendMessage(intPtr, 1125, chr, 0);
				}
				AlimamaLoginForm.SendMessage(intPtr, 1125, 0, msgtyp);
				Environment.Exit(0);
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[sendMessgeToMainForm]出错！", exception.ToString()));
			}
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void SetCursorPos(int int_3, int int_4);

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern void SetForegroundWindow(IntPtr intptr_0);

		public void SetTextBoxVerify(string string_8)
		{
			try
			{
				if (!this.textBoxVerify.InvokeRequired)
				{
					this.textBoxVerify.Text = string_8;
				}
				else
				{
					AlimamaLoginForm.SetTextBoxVerifyDelegate setTextBoxVerifyDelegate = new AlimamaLoginForm.SetTextBoxVerifyDelegate(this.SetTextBoxVerify);
					object[] string8 = new object[] { string_8 };
					base.BeginInvoke(setTextBoxVerifyDelegate, string8);
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[SetTextBoxVerify]出错：", exception.ToString()));
			}
		}

		public void SetVerifyVisible(bool visible)
		{
			try
			{
				if (!this.groupBoxUUCode.InvokeRequired)
				{
					this.groupBoxUUCode.Visible = visible;
				}
				else
				{
					AlimamaLoginForm.SetVerifyVisibleDelegate setVerifyVisibleDelegate = new AlimamaLoginForm.SetVerifyVisibleDelegate(this.SetVerifyVisible);
					object[] objArray = new object[] { visible };
					base.BeginInvoke(setVerifyVisibleDelegate, objArray);
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[SetVerifyVisible]出错：", exception.ToString()));
			}
		}

		public void setWindowFront()
		{
			try
			{
				while (true)
				{
					AlimamaLoginForm.SetForegroundWindow(AlimamaLoginForm.FindWindow(null, this.Text));
					base.Activate();
					Thread.Sleep(300);
				}
			}
			catch
			{
			}
		}

		private void timer_login_Tick(object sender, EventArgs e)
		{
			try
			{
				this.timer_login.Stop();
				bool flag = false;
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("J_QuickLogin");
				if (elementById.Style.Contains("block"))
				{
					IEnumerator enumerator = elementById.GetElementsByTagName("div").GetEnumerator();
					try
					{
						while (true)
						{
							if (enumerator.MoveNext())
							{
								HtmlElement current = (HtmlElement)enumerator.Current;
								string attribute = current.GetAttribute("className");

                                //this.method_10(string.Concat("HtmlElement：[", attribute, "]"));
								if ((attribute == null ? false : attribute.Contains("item-sso-user")) 
                                    //&& current.InnerHtml.Contains(string.Concat(">", this.username, "<"))
                                    )
								{
									if (!attribute.Contains("current"))
									{
										current.InvokeMember("click");
									}
                                    //this.method_10(string.Concat("J_SubmitQuick：[", webBrowserLoginAlimama.Document.GetElementById("J_SubmitQuick").Style, "]"));

									this.webBrowserLoginAlimama.Document.GetElementById("J_SubmitQuick").InvokeMember("click");
									flag = true;
									this.timer_login = new System.Windows.Forms.Timer()
									{
										Interval = 2000
									};
									this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
									this.timer_login.Start();
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
				if (!flag)
				{
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
			}
			catch (Exception exception)
			{
				this.timer_login = new System.Windows.Forms.Timer()
				{
					Interval = 3000
				};
				this.timer_login.Tick += new EventHandler(this.timer_login_Tick);
				this.timer_login.Start();
			}
		}

		private void timer_0_Tick_1(object sender, EventArgs e)
		{
			try
			{
				this.timer_login.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("TPL_username_1");
				if (!(!(elementById != null) || this.username.Equals("") ? true : this.password.Equals("")))
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					IntPtr intPtr = AlimamaLoginForm.FindWindow(null, this.Text);
					AlimamaLoginForm.SetForegroundWindow(intPtr);
					HtmlElement htmlElement = this.webBrowserLoginAlimama.Document.GetElementById("TPL_username_1");
					Point offset = this.GetOffset(htmlElement);
					Point point = this.method_4(this.webBrowserLoginAlimama);
					this.int_1 = point.X + offset.X + 100;
					this.int_2 = point.Y + offset.Y + 35;
					MockInput.click(intPtr, this.int_1, this.int_2);
					elementById.InvokeMember("click");
					elementById.SetAttribute("value", this.username);
					Thread.Sleep(400);
					SendKeys.Send("{TAB}");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1500
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_2);
					this.timer_login.Start();
				}
				else if (this.loginErrCnt < 5)
				{
					AlimamaLoginForm alimamaLoginForm = this;
                    alimamaLoginForm.loginErrCnt = alimamaLoginForm.loginErrCnt + 1;
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				else
				{
					this.cleanCookie();
					this.method_10("等待【登录页面打开】超过5次！");
					this.loginErrCnt = 0;
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.cleanCookie();
					this.method_10(string.Concat("[inputAlimamaUserName]出错，等待3秒重试！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				catch (Exception exception1)
				{
					this.method_10(string.Concat("[inputAlimamaUserName]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_2(object sender, EventArgs e)
		{
			try
			{
				this.timer_login.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("TPL_password_1");
				elementById.InvokeMember("click");
				elementById.SetAttribute("value", this.password);
				this.timer_login = new System.Windows.Forms.Timer()
				{
					Interval = 1000
				};
				this.timer_login.Tick += new EventHandler(this.timer_0_Tick_3);
				this.timer_login.Start();
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.cleanCookie();
					this.method_10(string.Concat("[inputPassword]出错！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				catch (Exception exception1)
				{
					this.method_10(string.Concat("[inputPassword]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_3(object sender, EventArgs e)
		{
			Point offset;
			Thread thread;
			try
			{
				this.timer_login.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("nocaptcha");
				if (elementById == null)
				{
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 400
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_3);
					this.timer_login.Start();
				}
				else if (!(elementById.Style == null || !elementById.Style.ToLower().Contains("block") || this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证通过")))
				{
					this.method_10("拖动验证通过！");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 100
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_login.Start();
				}
				else if ((elementById.Style == null || !elementById.Style.ToLower().Contains("block") || this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请按住滑块，拖动到最右边")))
				{
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 100
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_login.Start();
				}
				else
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					AlimamaLoginForm.SetForegroundWindow(AlimamaLoginForm.FindWindow(null, this.Text));
					this.method_10("开始拖动滑块。。。。。请等待！");
					Point point = this.method_4(this.webBrowserLoginAlimama);
					HtmlElement htmlElement = this.webBrowserLoginAlimama.Document.GetElementById("_n1z");
					if (htmlElement == null)
					{
						this.method_10("新拖动模式，阿里妈妈又疯了！");
						htmlElement = this.webBrowserLoginAlimama.Document.GetElementById("nc_1_n1z");
						offset = this.GetOffset(htmlElement);
                        offset.X = offset.X + new Random().Next(1, 10);
                        offset.Y = offset.Y + new Random().Next(35, 45);
						this.int_1 = offset.X + point.X;
						this.int_2 = offset.Y + point.Y;
						thread = new Thread(new ParameterizedThreadStart(this.method_5));
                        thread.Start(string.Concat(new Random().Next(255, 270), ""));
					}
					else
					{
						this.method_10("旧拖动模式，软件能搞的定！");
						offset = this.GetOffset(htmlElement);
						offset.X = offset.X + 10;
						offset.Y = offset.Y + 45;
						this.int_1 = offset.X + point.X;
						this.int_2 = offset.Y + point.Y;
						thread = new Thread(new ParameterizedThreadStart(this.method_5));
						thread.Start(string.Concat(220, ""));
					}
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_3);
					this.timer_login.Start();
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[checkPreDrag]出错！ex1:", exception.ToString()));
			}
		}

		private void timer_0_Tick_4(object sender, EventArgs e)
		{
			try
			{
				this.timer_login.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("J_SubmitStatic");
				elementById.InvokeMember("click");
				this.timer_login = new System.Windows.Forms.Timer()
				{
					Interval = 3000
				};
				this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
				this.timer_login.Start();
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.cleanCookie();
					this.method_10(string.Concat("[submitLogin]出错！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				catch (Exception exception1)
				{
					this.method_10(string.Concat("[submitLogin]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_5(object sender, EventArgs e)
		{
			Point offset;
			Thread thread;
			try
			{
				this.timer_login.Stop();
				if (AlimamaSvc.checkAlimamaLogin())
				{
					this.method_10("阿里妈妈登录成功！");
					this.logined = true;
					try
					{
						this.timer_login.Stop();
					}
					catch
					{
					}
				}
                //else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请输入验证码"))
                //{
                //    if ((this.uu_username.Equals("") ? true : this.uu_pwd.Equals("")))
                //    {
                //        this.method_10("出现验证码，没有设置UU打码打码账号和密码，请手动输入！");
                //    }
                //    else
                //    {
                //        this.method_10("出现验证码,开始打码！");
                //        this.timer_login = new System.Windows.Forms.Timer()
                //        {
                //            Interval = 500
                //        };
                //        this.timer_login.Tick += new EventHandler(this.timer_0_Tick_7);
                //        this.timer_login.Start();
                //    }
                //}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请点击图中的") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证通过")))
				{
					this.method_10("点图中文字，验证通过！");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 100
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请点击图中的"))
				{
					if ((this.uu_username.Equals("") ? true : this.uu_pwd.Equals("")))
					{
						this.method_10("点图中文字，没有设置【打码兔】账号和密码，请手动点击！");
						this.timer_login = new System.Windows.Forms.Timer()
						{
							Interval = 5000
						};
						this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
						this.timer_login.Start();
					}
					else
					{
						string startupPath = Application.StartupPath;
						DateTime now = DateTime.Now;
						this.img1 = string.Concat(startupPath, "\\config\\临时文件夹\\alimama1", now.ToString("yyyyMMddHHmmss"), ".jpg");
						string str = Application.StartupPath;
						now = DateTime.Now;
						this.img2 = string.Concat(str, "\\config\\临时文件夹\\alimama2", now.ToString("yyyyMMddHHmmss"), ".jpg");
						string[] files = Directory.GetFiles(string.Concat(Application.StartupPath, "\\config\\临时文件夹"), "alimama*.jpg");
						string[] strArrays = files;
						for (int i = 0; i < (int)strArrays.Length; i++)
						{
							string str1 = strArrays[i];
							try
							{
								File.Delete(str1);
							}
							catch
							{
							}
						}
						this.ihtmldocument2_0 = (IHTMLDocument2)this.webBrowserLoginAlimama.Document.DomDocument;
						IHTMLControlRange hTMLControlRange = (IHTMLControlRange)((HTMLBody)this.ihtmldocument2_0.body).createControlRange();
						HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("nc_1_clickCaptcha");
						HtmlElementCollection elementsByTagName = elementById.GetElementsByTagName("IMG");
						IHTMLControlElement domElement = (IHTMLControlElement)elementsByTagName[0].DomElement;
						Clipboard.Clear();
						hTMLControlRange.@add(domElement);
						hTMLControlRange.execCommand("Copy", false, null);
						HtmlElementCollection htmlElementCollections = elementById.GetElementsByTagName("P");
						this.string_4 = htmlElementCollections[0].InnerText.Replace("请点击图中的", "").Replace("“", "").Replace("”", "").Replace("字", "");
						this.completeWordVerrify = false;
						this.wordx = 0;
						this.wordy = 0;
						(new Thread(new ThreadStart(this.method_6))).Start();
						this.timer_login = new System.Windows.Forms.Timer()
						{
							Interval = 1000
						};
						this.timer_login.Tick += new EventHandler(this.timer_0_Tick_6);
						this.timer_login.Start();
					}
				}
				else if (!(this.webBrowserLoginAlimama.Document.Body.OuterHtml.Contains("ERROR_NEED_CHECK_CODE") || this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证通过") : true))
				{
					this.method_10("拖动验证通过！");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 100
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				else if (!(this.webBrowserLoginAlimama.Document.Body.OuterHtml.Contains("ERROR_NEED_CHECK_CODE") || this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请按住滑块，拖动到最右边") : true))
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					AlimamaLoginForm.SetForegroundWindow(AlimamaLoginForm.FindWindow(null, this.Text));
					this.method_10("开始拖动滑块。。。。。请等待！");
					Point point = this.method_4(this.webBrowserLoginAlimama);
					HtmlElement htmlElement = this.webBrowserLoginAlimama.Document.GetElementById("_n1z");
					if (htmlElement == null)
					{
						this.method_10("新拖动模式，阿里妈妈又疯了！");
						htmlElement = this.webBrowserLoginAlimama.Document.GetElementById("nc_1_n1z");
						offset = this.GetOffset(htmlElement);
						offset.X = offset.X + 10;
						offset.Y = offset.Y + 45;
						this.int_1 = offset.X + point.X;
						this.int_2 = offset.Y + point.Y;
						thread = new Thread(new ParameterizedThreadStart(this.method_5));
						thread.Start(string.Concat(270, ""));
					}
					else
					{
						this.method_10("旧拖动模式，软件能搞的定！");
						offset = this.GetOffset(htmlElement);
						offset.X = offset.X + 10;
						offset.Y = offset.Y + 45;
						this.int_1 = offset.X + point.X;
						this.int_2 = offset.Y + point.Y;
						thread = new Thread(new ParameterizedThreadStart(this.method_5));
						thread.Start(string.Concat(220, ""));
					}
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("加载中")))
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					AlimamaLoginForm.SetForegroundWindow(AlimamaLoginForm.FindWindow(null, this.Text));
					this.method_10("需要拖动滑块，加载滑块中，请等待！");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("网络不给力")))
				{
					this.method_10("拖动滑块验证失败，重新登录！");
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 2000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证码错误，请重新输入"))
				{
					this.method_10("验证码错误，请重新输入！");
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 500
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_7);
					this.timer_login.Start();
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("账户名和密码不匹配"))
				{
					this.method_10("你输入的账户名和密码不匹配，请手动输入！");
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("网站无法显示该页面"))
				{
					this.method_10("网站无法显示该页面，登录程序重新启动！");
					this.cleanCookie();
					this.sendMsgToMainFormAndExit("restart", CUtil.FORM_MSG_TYPE_NOTOPEN);
				}
				else if (this.loginErrCnt < 8)
				{
					AlimamaLoginForm alimamaLoginForm = this;
                    alimamaLoginForm.loginErrCnt = alimamaLoginForm.loginErrCnt + 1;
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
				}
				else
				{
					this.method_10("等待检查登录超过8次！");
					this.loginErrCnt = 0;
					this.sendMsgToMainFormAndExit("restart", CUtil.FORM_MSG_TYPE_CHKTMOUT);
				}
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.method_10(string.Concat("[checkLoginSuccess]出错！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.login_url_manual);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 2000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_login.Start();
				}
				catch (Exception exception1)
				{
					this.method_10(string.Concat("[checkLoginSuccess]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_6(object sender, EventArgs e)
		{
			try
			{
				this.timer_login.Stop();
				if (!(!this.completeWordVerrify ? true : this.wordx == 0))
				{
					Point point = this.method_4(this.webBrowserLoginAlimama);
					HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("nc_1_clickCaptcha");
					HtmlElement item = elementById.GetElementsByTagName("IMG")[0];
					if (item != null)
					{
						Point offset = this.GetOffset(item);
						offset.X = offset.X + this.wordx;
						offset.Y = offset.Y + this.wordy;
						this.int_1 = offset.X + point.X + 5;
						this.int_2 = offset.Y + point.Y + 25;
					}
					IntPtr intPtr = AlimamaLoginForm.FindWindow(null, this.Text);
					AlimamaLoginForm.SetForegroundWindow(intPtr);
					MockInput.click(intPtr, this.int_1, this.int_2);
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
				}
				else if ((!this.completeWordVerrify ? true : this.wordx != 0))
				{
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_6);
					this.timer_login.Start();
				}
				else
				{
					this.timer_login = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_login.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_login.Start();
				}
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[clickWord]出错：", exception.ToString()));
			}
		}

		private void timer_0_Tick_7(object sender, EventArgs e)
		{
			try
			{
				this.SetVerifyVisible(true);
				this.timer_login.Stop();
				if (!this.bool_0)
				{
					this.method_8();
				}
				this.method_10("正在【打码】！");
				this.ihtmldocument2_0 = (IHTMLDocument2)this.webBrowserLoginAlimama.Document.DomDocument;
				IHTMLControlRange hTMLControlRange = (IHTMLControlRange)((HTMLBody)this.ihtmldocument2_0.body).createControlRange();
				IHTMLControlElement hTMLControlElement = (IHTMLControlElement)this.ihtmldocument2_0.all.item("J_StandardCode_m", 0);
				hTMLControlRange.@add(hTMLControlElement);
				hTMLControlRange.execCommand("Copy", false, null);
				Image image = Clipboard.GetImage();
				this.pictureBoxVerify.Image = image;
				this.textBoxVerify.Focus();
				this.image_0 = image;
				(new Thread(new ThreadStart(this.method_9))).Start();
			}
			catch (Exception exception)
			{
				this.method_10(string.Concat("[inputVerifyCode]出错了！", exception.ToString()));
			}
		}

		private void timer_restart_Tick(object sender, EventArgs e)
		{
			this.timer_restart.Stop();
			this.sendMsgToMainFormAndExit("restart", CUtil.FORM_MSG_TYPE_CHKTMOUT);
		}

		public delegate void GetClipboardImageDelegate();

		public delegate void MsgDelegate(string string_0);

		public delegate void SetTextBoxVerifyDelegate(string string_0);

		public delegate void SetVerifyVisibleDelegate(bool visible);
	}
}