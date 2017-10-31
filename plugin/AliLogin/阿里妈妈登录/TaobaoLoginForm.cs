using mshtml;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 阿里妈妈登录
{
	public class TaobaoLoginForm : Form
	{
		private IContainer icontainer_0 = null;

		private RichTextBox richTextBoxSts;

		private WebBrowser webBrowserLoginAlimama;

		private System.Windows.Forms.Timer timer_0;

		private GroupBox groupBoxUUCode;

		private PictureBox pictureBoxVerify;

		private TextBox textBoxVerify;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripLoginPage;

		private int int_0 = 1;

		public string basePath = Application.StartupPath;

		public string username = "";

		public string password = "";

		private string string_0 = "";

		private string string_1 = "";

		public string mainFormTitle = "";

		private string string_2 = "https://login.taobao.com/member/login.jhtml?style=mini&from=taobao&redirectURL=http%3A%2F%2Fwww.taobao.com&amp;full_redirect=true&disableQuickLogin=true";

		private string string_3 = "https://login.taobao.com/member/login.jhtml?redirectURL=http%3A%2F%2Fwww.taobao.com";

		public bool logined = false;

		public int loginErrCnt = 0;

		private int int_1 = 0;

		private int int_2 = 0;

		private IHTMLDocument2 ihtmldocument2_0 = null;

		private UUWise uuwise_0 = new UUWise();

		private bool bool_0 = false;

		private Image image_0 = null;

		public TaobaoLoginForm(string[] args)
		{
			try
			{
				if ((args == null ? true : (int)args.Length == 0))
				{
					MessageBox.Show(string.Concat("版本：[V", this.int_0, "]，本程序不能手动打开！"));
					Environment.Exit(-1);
				}
				if (args[0].Contains("CheckUpdVersion"))
				{
					Environment.Exit(this.int_0);
				}
				this.InitializeComponent();
				base.FormClosing += new FormClosingEventHandler(this.TaobaoLoginForm_FormClosing);
				UserAgentHelper.AppendUserAgent("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
				this.webBrowserLoginAlimama.ScriptErrorsSuppressed = true;
				this.webBrowserLoginAlimama.IsWebBrowserContextMenuEnabled = false;
				this.method_0();
				this.method_9(string.Concat("当前IE版本：[", this.webBrowserLoginAlimama.Version.ToString(), "]"));
				int num = 0;
				int num1 = 0;
				num = num1 + 1;
				this.mainFormTitle = args[num1];
				int num2 = 1;
				num = num2 + 1;
				if (int.Parse(args[num2]) != 1)
				{
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					(new Thread(new ThreadStart(this.checkManualLogin))).Start();
				}
				else
				{
					this.webBrowserLoginAlimama.Navigate(this.string_3);
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
						this.string_0 = "";
						this.string_1 = "";
					}
					else
					{
						int num6 = num;
						num = num6 + 1;
						this.string_0 = args[num6];
						int num7 = num;
						num = num7 + 1;
						this.string_1 = args[num7];
					}
					this.Text = string.Concat(this.Text, " - 自动登录模式，如果没出错，不要手动操作");
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
					this.timer_0.Start();
					(new Thread(new ThreadStart(this.checkAutoLogin))).Start();
				}
				(new Thread(new ThreadStart(this.setWindowFront))).Start();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				if (!exception.ToString().Contains("System.IndexOutOfRangeException"))
				{
					this.method_9(string.Concat("[AlimamaLoginForm]出错！", exception.ToString()));
				}
				else
				{
					this.sendMsgToMainFormAndExit("close", CUtil.FORM_MSG_TYPE_CLOSENOTLOGINED);
				}
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
						this.sendMsgToMainFormAndExit(GetCookie.GetCookieString("http://www.taobao.com"), CUtil.FORM_MSG_TYPE_LOGINED);
					}
				}
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[checkAutoLogin]出错！", exception.ToString()));
			}
		}

		public void checkManualLogin()
		{
			try
			{
				while (true)
				{
					string cookieString = GetCookie.GetCookieString("http://www.taobao.com");
					if (!TaobaoSvc.checkTaobaoLogin(cookieString))
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
				this.method_9(string.Concat("[checkManualLogin]出错！", exception.ToString()));
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
		private static extern IntPtr FindWindow(string string_4, string string_5);

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern IntPtr FindWindowEx(IntPtr intptr_0, uint uint_0, string string_4, string string_5);

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
				this.method_9(string.Concat("[GetOffset]出错！", exception.ToString()));
				point = new Point(0, 0);
			}
			return point;
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TaobaoLoginForm));
			this.groupBoxUUCode = new GroupBox();
			this.pictureBoxVerify = new PictureBox();
			this.textBoxVerify = new TextBox();
			this.richTextBoxSts = new RichTextBox();
			this.webBrowserLoginAlimama = new WebBrowser();
			this.contextMenuStripLoginPage = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
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
			base.Name = "TaobaoLoginForm";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "淘宝登录V1";
			this.groupBoxUUCode.ResumeLayout(false);
			this.groupBoxUUCode.PerformLayout();
			((ISupportInitialize)this.pictureBoxVerify).EndInit();
			base.ResumeLayout(false);
		}

		public void messageForThread(string string_4)
		{
			try
			{
				if (!this.richTextBoxSts.InvokeRequired)
				{
					this.method_9(string_4);
				}
				else
				{
					TaobaoLoginForm.MsgDelegate msgDelegate = new TaobaoLoginForm.MsgDelegate(this.messageForThread);
					object[] string4 = new object[] { string_4 };
					base.BeginInvoke(msgDelegate, string4);
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
				this.method_9(string.Concat("[initContextMenuStripLoginPage]出错：", exception.ToString()));
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
				this.method_9(string.Concat("[RefreshPage_Click]出错：", exception.ToString()));
			}
		}

		private void method_2(object sender, EventArgs e)
		{
			try
			{
				this.webBrowserLoginAlimama.Navigate(this.string_2);
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[RefreshPage_Click]出错：", exception.ToString()));
			}
		}

		private void method_3(object sender, EventArgs e)
		{
			try
			{
				this.timer_0.Stop();
				this.sendMsgToMainFormAndExit("close", CUtil.FORM_MSG_TYPE_CLOSENOTLOGINED);
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[exitWithOutLogin]出错！", exception.ToString()));
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
				this.method_9(string.Concat("[GetFormOffset]出错！", exception.ToString()));
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
				this.method_9(string.Concat("[drag]出错了！", exception.ToString()));
			}
		}

		private void method_6(object sender, EventArgs e)
		{
			try
			{
				if (this.textBoxVerify.Text.Length > 0)
				{
					this.method_9("完成【验证码】输入！");
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
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 800
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_0.Start();
					this.SetVerifyVisible(false);
				}
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[textBoxVerify_TextChanged]出错了！", exception.ToString()));
			}
		}

		private void method_7()
		{
			try
			{
				this.method_9("正在登录UU打码平台！");
				string str = this.uuwise_0.login(this.string_0, this.string_1);
				this.bool_0 = true;
				this.method_9(str);
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[uuWiseLogin]出错了！", exception.ToString()));
			}
		}

		private void method_8()
		{
			try
			{
				this.method_9("正在识别验证码！");
				string str = this.uuwise_0.recogniseImg(this.image_0);
				if (!str.Equals("TIMEOUT"))
				{
					this.SetTextBoxVerify(str);
					this.method_9(string.Concat("验证码识别成功，验证码：【", str, "】！"));
				}
				else
				{
					this.method_9("打码超时，正在重新打码。");
					Thread.Sleep(100);
					this.method_8();
				}
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[recogniseCode]打码出错，正在重新打。", exception.ToString()));
				Thread.Sleep(100);
				this.method_8();
			}
		}

		private void method_9(string string_4)
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
					str[2] = string_4;
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
					str[2] = string_4;
					str[3] = "\n";
					str[4] = text.Substring(0, 5000);
					richTextBox1.Text = string.Concat(str);
				}
			}
			catch
			{
				this.messageForThread(string_4);
			}
		}

		[DllImport("User32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SendMessage(IntPtr intptr_0, int int_3, int int_4, int int_5);

		public void sendMsgToMainFormAndExit(string string_4, int msgtyp)
		{
			IntPtr intPtr;
			try
			{
				int num = 0;
				while (true)
				{
					IntPtr intPtr1 = TaobaoLoginForm.FindWindow(null, this.mainFormTitle);
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
				char[] chars = unicodeEncoding.GetChars(unicodeEncoding.GetBytes(string_4));
				for (int i = 0; i < (int)chars.Length; i++)
				{
					char chr = chars[i];
					TaobaoLoginForm.SendMessage(intPtr, 1125, chr, 0);
				}
				TaobaoLoginForm.SendMessage(intPtr, 1125, 0, msgtyp);
				Environment.Exit(0);
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[sendMessgeToMainForm]出错！", exception.ToString()));
			}
		}

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern void SetForegroundWindow(IntPtr intptr_0);

		public void SetTextBoxVerify(string string_4)
		{
			try
			{
				if (!this.textBoxVerify.InvokeRequired)
				{
					this.textBoxVerify.Text = string_4;
				}
				else
				{
					TaobaoLoginForm.SetTextBoxVerifyDelegate setTextBoxVerifyDelegate = new TaobaoLoginForm.SetTextBoxVerifyDelegate(this.SetTextBoxVerify);
					object[] string4 = new object[] { string_4 };
					base.BeginInvoke(setTextBoxVerifyDelegate, string4);
				}
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[SetTextBoxVerify]出错：", exception.ToString()));
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
					TaobaoLoginForm.SetVerifyVisibleDelegate setVerifyVisibleDelegate = new TaobaoLoginForm.SetVerifyVisibleDelegate(this.SetVerifyVisible);
					object[] objArray = new object[] { visible };
					base.BeginInvoke(setVerifyVisibleDelegate, objArray);
				}
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[SetVerifyVisible]出错：", exception.ToString()));
			}
		}

		public void setWindowFront()
		{
			try
			{
				while (true)
				{
					TaobaoLoginForm.SetForegroundWindow(TaobaoLoginForm.FindWindow(null, this.Text));
					base.Activate();
					Thread.Sleep(300);
				}
			}
			catch
			{
			}
		}

		private void TaobaoLoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				base.Visible = true;
				string cookieString = GetCookie.GetCookieString("http://www.taobao.com");
				if (!TaobaoSvc.checkTaobaoLogin(cookieString))
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
				this.method_9(string.Concat("[FormClosingProcess]出错，", exception.ToString()));
			}
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			try
			{
				this.timer_0.Stop();
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
								if ((attribute == null ? false : attribute.Contains("item-sso-user")) && current.InnerHtml.Contains(string.Concat(">", this.username, "<")))
								{
									if (!attribute.Contains("current"))
									{
										current.InvokeMember("click");
									}
									this.webBrowserLoginAlimama.Document.GetElementById("J_SubmitQuick").InvokeMember("click");
									flag = true;
									this.timer_0 = new System.Windows.Forms.Timer()
									{
										Interval = 2000
									};
									this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
									this.timer_0.Start();
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
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
			}
			catch (Exception exception)
			{
				this.timer_0 = new System.Windows.Forms.Timer()
				{
					Interval = 3000
				};
				this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
				this.timer_0.Start();
			}
		}

		private void timer_0_Tick_1(object sender, EventArgs e)
		{
			try
			{
				this.timer_0.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("TPL_username_1");
				if (!(!(elementById != null) || this.username.Equals("") ? true : this.password.Equals("")))
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					IntPtr intPtr = TaobaoLoginForm.FindWindow(null, this.Text);
					TaobaoLoginForm.SetForegroundWindow(intPtr);
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
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 1500
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_2);
					this.timer_0.Start();
				}
				else if (this.loginErrCnt < 5)
				{
					TaobaoLoginForm taobaoLoginForm = this;
					taobaoLoginForm.loginErrCnt = taobaoLoginForm.loginErrCnt + 1;
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				else
				{
					this.cleanCookie();
					this.method_9("等待【登录页面打开】超过5次！");
					this.loginErrCnt = 0;
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.cleanCookie();
					this.method_9(string.Concat("[inputAlimamaUserName]出错，等待3秒重试！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				catch (Exception exception1)
				{
					this.method_9(string.Concat("[inputAlimamaUserName]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_2(object sender, EventArgs e)
		{
			try
			{
				this.timer_0.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("TPL_password_1");
				elementById.InvokeMember("click");
				elementById.SetAttribute("value", this.password);
				this.timer_0 = new System.Windows.Forms.Timer()
				{
					Interval = 1000
				};
				this.timer_0.Tick += new EventHandler(this.timer_0_Tick_3);
				this.timer_0.Start();
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.cleanCookie();
					this.method_9(string.Concat("[inputPassword]出错！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				catch (Exception exception1)
				{
					this.method_9(string.Concat("[inputPassword]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_3(object sender, EventArgs e)
		{
			try
			{
				this.timer_0.Stop();
				HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("J_SubmitStatic");
				elementById.InvokeMember("click");
				this.timer_0 = new System.Windows.Forms.Timer()
				{
					Interval = 3000
				};
				this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
				this.timer_0.Start();
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.cleanCookie();
					this.method_9(string.Concat("[submitLogin]出错！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				catch (Exception exception1)
				{
					this.method_9(string.Concat("[submitLogin]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_4(object sender, EventArgs e)
		{
			Point offset;
			Thread thread;
			try
			{
				this.timer_0.Stop();
				if (TaobaoSvc.checkTaobaoLogin(GetCookie.GetCookieString("http://www.taobao.com")))
				{
					this.method_9("淘宝登录成功！");
					this.logined = true;
					try
					{
						this.timer_0.Stop();
					}
					catch
					{
					}
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请输入验证码"))
				{
					if ((this.string_0.Equals("") ? true : this.string_1.Equals("")))
					{
						this.method_9("出现验证码，没有设置UU打码打码账号和密码，请手动输入！");
					}
					else
					{
						this.method_9("出现验证码,开始打码！");
						this.timer_0 = new System.Windows.Forms.Timer()
						{
							Interval = 500
						};
						this.timer_0.Tick += new EventHandler(this.timer_0_Tick_5);
						this.timer_0.Start();
					}
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请点击图中的") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证通过")))
				{
					this.method_9("点图中文字，验证通过！");
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 100
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请点击图中的"))
				{
					this.method_9("点图中文字，软件没有办法自动点，请手动点击文字！");
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 10000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_0.Start();
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证通过")))
				{
					this.method_9("拖动验证通过！");
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 100
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("请按住滑块，拖动到最右边")))
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					TaobaoLoginForm.SetForegroundWindow(TaobaoLoginForm.FindWindow(null, this.Text));
					this.method_9("开始拖动滑块。。。。。请等待！");
					Point point = this.method_4(this.webBrowserLoginAlimama);
					HtmlElement elementById = this.webBrowserLoginAlimama.Document.GetElementById("_n1z");
					if (elementById == null)
					{
						this.method_9("新拖动模式，阿里妈妈又疯了！");
						elementById = this.webBrowserLoginAlimama.Document.GetElementById("nc_1_n1z");
						offset = this.GetOffset(elementById);
						offset.X = offset.X + 10;
						offset.Y = offset.Y + 45;
						this.int_1 = offset.X + point.X;
						this.int_2 = offset.Y + point.Y;
						thread = new Thread(new ParameterizedThreadStart(this.method_5));
						thread.Start(string.Concat(270, ""));
					}
					else
					{
						this.method_9("旧拖动模式，软件能搞的定！");
						offset = this.GetOffset(elementById);
						offset.X = offset.X + 10;
						offset.Y = offset.Y + 45;
						this.int_1 = offset.X + point.X;
						this.int_2 = offset.Y + point.Y;
						thread = new Thread(new ParameterizedThreadStart(this.method_5));
						thread.Start(string.Concat(220, ""));
					}
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 3000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_0.Start();
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("加载中")))
				{
					base.Visible = true;
					base.WindowState = FormWindowState.Normal;
					base.Activate();
					TaobaoLoginForm.SetForegroundWindow(TaobaoLoginForm.FindWindow(null, this.Text));
					this.method_9("需要拖动滑块，加载滑块中，请等待！");
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_0.Start();
				}
				else if (!(!this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("拖动滑块") ? true : !this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("网络不给力")))
				{
					this.method_9("拖动滑块验证失败，重新登录！");
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 2000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_0.Start();
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("验证码错误，请重新输入"))
				{
					this.method_9("验证码错误，请重新输入！");
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 500
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_5);
					this.timer_0.Start();
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("账户名和密码不匹配"))
				{
					this.method_9("你输入的账户名和密码不匹配，请手动输入！");
				}
				else if (this.webBrowserLoginAlimama.Document.Body.InnerHtml.Contains("网站无法显示该页面"))
				{
					this.method_9("网站无法显示该页面，登录程序重新启动！");
					this.cleanCookie();
					this.sendMsgToMainFormAndExit("restart", CUtil.FORM_MSG_TYPE_NOTOPEN);
				}
				else if (this.loginErrCnt < 8)
				{
					TaobaoLoginForm taobaoLoginForm = this;
					taobaoLoginForm.loginErrCnt = taobaoLoginForm.loginErrCnt + 1;
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 1000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_4);
					this.timer_0.Start();
				}
				else
				{
					this.method_9("等待检查登录超过8次！");
					this.loginErrCnt = 0;
					this.sendMsgToMainFormAndExit("restart", CUtil.FORM_MSG_TYPE_CHKTMOUT);
				}
			}
			catch (Exception exception2)
			{
				Exception exception = exception2;
				try
				{
					this.method_9(string.Concat("[checkLoginSuccess]出错！", exception.ToString()));
					this.webBrowserLoginAlimama.Navigate(this.string_2);
					this.timer_0 = new System.Windows.Forms.Timer()
					{
						Interval = 2000
					};
					this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
					this.timer_0.Start();
				}
				catch (Exception exception1)
				{
					this.method_9(string.Concat("[checkLoginSuccess]出错！ex1:", exception1.ToString()));
				}
			}
		}

		private void timer_0_Tick_5(object sender, EventArgs e)
		{
			try
			{
				this.SetVerifyVisible(true);
				this.timer_0.Stop();
				if (!this.bool_0)
				{
					this.method_7();
				}
				this.method_9("正在【打码】！");
				this.ihtmldocument2_0 = (IHTMLDocument2)this.webBrowserLoginAlimama.Document.DomDocument;
				IHTMLControlRange hTMLControlRange = (IHTMLControlRange)((HTMLBody)this.ihtmldocument2_0.body).createControlRange();
				IHTMLControlElement hTMLControlElement = (IHTMLControlElement)this.ihtmldocument2_0.all.item("J_StandardCode_m", 0);
				hTMLControlRange.@add(hTMLControlElement);
				hTMLControlRange.execCommand("Copy", false, null);
				Image image = Clipboard.GetImage();
				this.pictureBoxVerify.Image = image;
				this.textBoxVerify.Focus();
				this.image_0 = image;
				(new Thread(new ThreadStart(this.method_8))).Start();
			}
			catch (Exception exception)
			{
				this.method_9(string.Concat("[inputVerifyCode]出错了！", exception.ToString()));
			}
		}

		public delegate void MsgDelegate(string string_0);

		public delegate void SetTextBoxVerifyDelegate(string string_0);

		public delegate void SetVerifyVisibleDelegate(bool visible);
	}
}