using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeChat.NET.HTTP;
using WeChat.NET.Objects;


 

namespace WeChat.NET
{


    public partial class sendMainForm : Form
    {
        const int WM_COPYDATA = 0x004A;
        private struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }


        /// <summary>
        /// 当前登录微信用户
        /// </summary>
        private WXUser _me;

        private List<Object> _contact_all = new List<object>();
        private List<object> _contact_latest = new List<object>();

        public sendMainForm()
        {
            InitializeComponent();
        }

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_COPYDATA:
                    COPYDATASTRUCT mystr = new COPYDATASTRUCT();
                    Type mytype = mystr.GetType();
                    mystr = (COPYDATASTRUCT)m.GetLParam(mytype);
                    string receiveMsg = mystr.lpData;

                    this.sendContent(receiveMsg);
                    //MessageBox.Show(receiveMsg);
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void dataGridView_weixin_qun_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            if (dataGridView_weixin_qun_list.Columns[e.ColumnIndex].Name != "select") return;

            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView_weixin_qun_list.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value != null && (bool)cell.Value)
            {
                cell.Value = false;
            }
            else
            {
                cell.Value = true;
            }
        }

        private void sendMainForm_Load(object sender, EventArgs e)
        {
            DoMainLogic();
        }

        private void DoMainLogic()
        {
            //_lblWait.BringToFront();
            //MessageBox.Show("---1");
            ((Action)(delegate()
            {
                //MessageBox.Show("---2");
                LogUtil.log_call(this, "初始化微信信息");
                WXService wxs = new WXService();
                JObject init_result = wxs.WxInit();  //初始化


                List<object> contact_all = new List<object>();
                if (init_result != null)
                {
                    _me = new WXUser();
                    _me.UserName = init_result["User"]["UserName"].ToString();
                    try
                    {
                        _me.City = "";
                        _me.HeadImgUrl = init_result["User"]["HeadImgUrl"].ToString();
                        _me.NickName = init_result["User"]["NickName"].ToString();
                        _me.Province = "";
                        _me.PYQuanPin = init_result["User"]["PYQuanPin"].ToString();
                        _me.RemarkName = init_result["User"]["RemarkName"].ToString();
                        _me.RemarkPYQuanPin = init_result["User"]["RemarkPYQuanPin"].ToString();
                        _me.Sex = init_result["User"]["Sex"].ToString();
                        _me.Signature = init_result["User"]["Signature"].ToString();
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        foreach (JObject contact in init_result["ContactList"])  //部分好友名单
                        {
                            try
                            {
                                WXUser user = new WXUser();
                                user.UserName = contact["UserName"].ToString();
                                user.City = contact["City"].ToString();
                                user.HeadImgUrl = contact["HeadImgUrl"].ToString();
                                user.NickName = contact["NickName"].ToString();
                                user.Province = contact["Province"].ToString();
                                user.PYQuanPin = contact["PYQuanPin"].ToString();
                                user.RemarkName = contact["RemarkName"].ToString();
                                user.RemarkPYQuanPin = contact["RemarkPYQuanPin"].ToString();
                                user.Sex = contact["Sex"].ToString();
                                user.Signature = contact["Signature"].ToString();

                                _contact_latest.Add(user);
                            }
                            catch (Exception)
                            {
                            
                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                }

                JObject contact_result = wxs.GetContact(); //通讯录
                try
                {
                    if (contact_result != null)
                    {
                        foreach (JObject contact in contact_result["MemberList"])  //完整好友名单
                        {
                            try
                            {
                                WXUser user = new WXUser();
                                user.UserName = contact["UserName"].ToString();
                                user.City = contact["City"].ToString();
                                user.HeadImgUrl = contact["HeadImgUrl"].ToString();
                                user.NickName = contact["NickName"].ToString();
                                user.Province = contact["Province"].ToString();
                                user.PYQuanPin = contact["PYQuanPin"].ToString();
                                user.RemarkName = contact["RemarkName"].ToString();
                                user.RemarkPYQuanPin = contact["RemarkPYQuanPin"].ToString();
                                user.Sex = contact["Sex"].ToString();
                                user.Signature = contact["Signature"].ToString();

                                contact_all.Add(user);
                            }
                            catch (Exception)
                            {
                             }
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                //IOrderedEnumerable<object> list_all = contact_all.OrderBy(e => (e as WXUser).ShowPinYin);

                //WXUser wx; string start_char;
                //foreach (object o in list_all)
                //{
                //    wx = o as WXUser;
                //    start_char = wx.ShowPinYin == "" ? "" : wx.ShowPinYin.Substring(0, 1);
                //    if (!_contact_all.Contains(start_char.ToUpper()))
                //    {
                //        _contact_all.Add(start_char.ToUpper());
                //    }
                //    _contact_all.Add(o);
                //}

                //MessageBox.Show("---:" + contact_all.Count.ToString());

                try
                {
                    //this.appBean.weixin_list = weixinList;
                    this.dataGridView_weixin_qun_list.Rows.Clear();
                    //this.load_qq_qun_shunxu();
                    int num = 0;
                    foreach (WXUser arrayList4 in contact_all)
                    {
                        try
                        {
                            if (arrayList4.UserName.Contains("@@"))
                            {
                                //MessageBox.Show(arrayList4.UserName.ToString());
                                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                                this.dataGridView_weixin_qun_list.Rows.Add(dataGridViewRow);
                                //this.dataGridView_weixin_qun_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                                this.dataGridView_weixin_qun_list[0, num].Value = true;
                                this.dataGridView_weixin_qun_list[1, num].Value = arrayList4.NickName;
                                this.dataGridView_weixin_qun_list[1, num].Tag = arrayList4;
                                num++;
                            }
                            else {
                                //DataGridViewRow dataGridViewRow = new DataGridViewRow();
                                //this.dataGridView_weixin_qun_list.Rows.Add(dataGridViewRow);
                                ////this.dataGridView_weixin_qun_list.Rows[num].HeaderCell.Value = string.Concat(num + 1, "");
                                //this.dataGridView_weixin_qun_list[0, num].Value = true;
                                //this.dataGridView_weixin_qun_list[1, num].Value = arrayList4.NickName;
                                //this.dataGridView_weixin_qun_list[1, num].Tag = arrayList4;
                                //num++;
                            }
                        }
                        catch (Exception)
                        {
                            
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                    //LogUtil.log_call(this, string.Concat("[loadWeixinList]出错：", exception.ToString()));
                }

                //this.BeginInvoke((Action)(delegate()  //等待结束
                //{
                //    _lblWait.Visible = false;

                //    wChatList1.Items.AddRange(_contact_latest.ToArray());  //近期联系人
                //    wFriendsList1.Items.AddRange(_contact_all.ToArray());  //通讯录
                //    wpersonalinfo.FriendUser = _me;
                //}));


                string sync_flag = "";
                JObject sync_result;
                while (true)
                {
                    sync_flag = wxs.WxSyncCheck();  //同步检查
                    if (sync_flag == null)
                    {
                        continue;
                    }
                    //这里应该判断 sync_flag中selector的值
                    else //有消息
                    {
                        sync_result = wxs.WxSync();  //进行同步
                        if (sync_result != null)
                        {
                            if (sync_result["AddMsgCount"] != null && sync_result["AddMsgCount"].ToString() != "0")
                            {
                                foreach (JObject m in sync_result["AddMsgList"])
                                {
                                    string from = m["FromUserName"].ToString();
                                    string to = m["ToUserName"].ToString();
                                    string content = m["Content"].ToString();
                                    string type = m["MsgType"].ToString();

                                    WXMsg msg = new WXMsg();
                                    msg.From = from;
                                    msg.Msg = type == "1" ? content : "请在其他设备上查看消息";  //只接受文本消息
                                    msg.Readed = false;
                                    msg.Time = DateTime.Now;
                                    msg.To = to;
                                    msg.Type = int.Parse(type);

                                    if (msg.Type == 51)  //屏蔽一些系统数据
                                    {
                                        continue;
                                    }
                                    this.BeginInvoke((Action)delegate()
                                    {
                                        WXUser user; bool exist_latest_contact = false;
                                        //foreach (Object u in wChatList1.Items)
                                        //{
                                        //    user = u as WXUser;
                                        //    if (user != null)
                                        //    {
                                        //        if (user.UserName == msg.From && msg.To == _me.UserName)  //接收别人消息
                                        //        {
                                        //            wChatList1.Items.Remove(user);
                                        //            wChatList1.Items.Insert(0, user);
                                        //            exist_latest_contact = true;
                                        //            user.ReceiveMsg(msg);
                                        //            break;
                                        //        }
                                        //        else if (user.UserName == msg.To && msg.From == _me.UserName)  //同步自己在其他设备上发送的消息
                                        //        {
                                        //            wChatList1.Items.Remove(user);
                                        //            wChatList1.Items.Insert(0, user);
                                        //            exist_latest_contact = true;
                                        //            user.SendMsg(msg, true);
                                        //            break;
                                        //        }
                                        //    }
                                        //}
                                        //if (!exist_latest_contact)
                                        //{
                                        //    foreach (object o in wFriendsList1.Items)
                                        //    {
                                        //        WXUser friend = o as WXUser;
                                        //        if (friend != null && friend.UserName == msg.From && msg.To == _me.UserName)
                                        //        {
                                        //            wChatList1.Items.Insert(0, friend);
                                        //            friend.ReceiveMsg(msg);
                                        //            break;
                                        //        }
                                        //        if (friend != null && friend.UserName == msg.To && msg.From == _me.UserName)
                                        //        {
                                        //            wChatList1.Items.Insert(0, friend);
                                        //            friend.SendMsg(msg, true);
                                        //            break;
                                        //        }
                                        //    }
                                        //}
                                        //wChatList1.Invalidate();
                                    });
                                }
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(10);
                }

            })).BeginInvoke(null, null);
        }

        private void sendMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public void sendContent(string content_json) {
            LogUtil.log_call(this, "获取到发送信息，即将开始发送。。。");
            try
            {
                ArrayList img_list = new ArrayList();
                //LogUtil.log_call(this, "content_json：" + content_json);
                JObject sync_resul = JsonConvert.DeserializeObject(content_json) as JObject;

                string content = sync_resul["content"].ToString();
                if (sync_resul["imgs"]["count"].ToString() != "0")
                {
                    foreach (JObject key in sync_resul["imgs"]["items"])
                    {
                        img_list.Add(key["url"].ToString());
                    }
                }

                for (int i = 0; i < this.dataGridView_weixin_qun_list.Rows.Count; i++)
                {

                    if (this.dataGridView_weixin_qun_list[0, i].Value != null)
                    { 
                        bool checked_  = (bool)this.dataGridView_weixin_qun_list[0, i].Value;
                    
                        if (checked_)
                        {
                            WXUser user = (WXUser)this.dataGridView_weixin_qun_list[1, i].Tag;
                            if (user !=null)
                            {
                                //LogUtil.log_call(this, "user.UserName：" + user.UserName);

                                WXUser _friendUser = new WXUser();
                                WXMsg msg = new WXMsg();
                                msg.From = _me.UserName;
                                msg.Msg = content;
                                msg.Readed = false;
                                msg.To = user.UserName;
                                msg.Type = 1;
                                msg.Time = DateTime.Now;


                                foreach (string img in img_list)
                                {
                                    string img_str = img;
                                    if (img_str.Contains("file:///"))
                                    {
                                        img_str = img_str.Replace("file:///", "");
                                    }
                                    string MediaId = WXService.upload(this, "", _me.UserName, user.UserName, img_str);
                                    if(!string.IsNullOrEmpty(MediaId)){

                                        WXService wxs = new WXService();
                                        string send_result = wxs.SendMsg_img(msg.Msg, msg.From, msg.To, 3, MediaId);

                                        //LogUtil.log_call(this, "send_result：" + send_result);
                                    }
                                }
                                if (img_list.Count>0)
                                {
                                    Thread.Sleep(1000);
                                }

                                _friendUser.SendMsg(msg, false);

                                //WXService wxs = new WXService();
                                //wxs.up.SendMsg(msg.Msg, msg.From, msg.To, msg.Type);

                            }
                        }
                    }
                }
                LogUtil.log_call(this, "发送成功！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(this, string.Concat("[buttonFwSndDelAll_Click]出错：", exception.ToString()));
            }

        }

    }

    public delegate void log(sendMainForm cmsForm, String content);

}
