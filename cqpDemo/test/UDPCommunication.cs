using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Reflection;

namespace MoecraftFramework
{
    public class UDPCommunication
    {
        public bool RunningFlag { get; set; }
        public string sendMsg { get; set; }
        public string fromQQ { get; set; }
        public string cqpath { get; set; }
        public string receiveMsg { get; set; }
        private IPEndPoint ipLocalPoint;
        private EndPoint RemotePoint;
        private Socket mySocket;
        MoeDllImport.PluginManager md = new MoeDllImport.PluginManager();
        /// <summary>
        /// 预定义参数集合
        /// <para>0 string EventType = "";</para> 
        /// <para>1 int subType = 0;</para> 
        /// <para>2 int sendTime = 0;</para> 
        /// <para>3 int fromGroup = 0;</para> 
        /// <para>4 int fromDiscuss = 0;</para> 
        /// <para>5 int fromQQ = 0;</para> 
        /// <para>6 string fromAnonymous = "";</para> 
        /// <para>7 int beingOperateQQ = 0;</para> 
        /// <para>8 string Msg = "";</para> 
        /// <para>9 int font = 0;</para> 
        /// <para>10 string responseFlag = "";</para> 
        /// <para>11 string file = "";</para> 
        /// </summary>
        public List<object> comatb { get; set; } = new List<object>(){"",0,0,0,0,0,"",0,"",0,"",""}; 
        public UDPCommunication()
        {
            //得到本机IP，设置UDP端口号     
            IPAddress ip = getValidIP("127.0.0.1");
            int port = getValidPort("10086");
            ipLocalPoint = new IPEndPoint(ip, port);
            //定义网络类型，数据连接类型和网络协议UDP  
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //绑定网络地址  
            mySocket.Bind(ipLocalPoint);
            //得到客户机IP  
            ip = getValidIP("127.0.0.1");
            port = getValidPort("10010");
            IPEndPoint ipep = new IPEndPoint(ip, port);
            RemotePoint = (EndPoint)(ipep);
            //启动一个新的线程，执行方法this.ReceiveHandle，  
            //以便在一个独立的进程中执行数据接收的操作  
            RunningFlag = true;
            Thread thread = new Thread(new ThreadStart(this.ReceiveHandle));
            thread.Start();
        }
        private void ReceiveHandle()
        {
            //接收数据处理线程，相当于消息处理的入口  
            byte[] data = new byte[1024];        
            while (RunningFlag)
            {
                if (mySocket == null || mySocket.Available < 1)
                {
                    Thread.Sleep(200);
                    continue;
                }
                int rlen = 0;
                try
                {
                    rlen = mySocket.ReceiveFrom(data, ref RemotePoint);
                }
                catch
                {
                    //防止远程关闭，跳过无响应
                }
                receiveMsg = Encoding.Default.GetString(data, 0, rlen);
                string Msg = receiveMsg;
                #region 消息解析
                if (Msg != null)
                {
                    if (Msg.Length != 0)
                    {
                        if (Msg.IndexOf(">")>0)
                        {
                            int i = 0;
                            string precmd = GetSubString(Msg,"<",">");
                            string[] compex = precmd.Split('&');
                            foreach (var str in compex)//遍历参数集
                            {
                                string x = str + "%cutB%";
                                x = GetSubString(x, "=", "%cutB%");
                                if (comatb[i].GetType() == x.GetType())//为string的时候
                                {
                                    comatb[i] = x;
                                }
                                else if (comatb[i].GetType() == i.GetType())//为int的时候
                                {
                                    int ii = 0;
                                    int.TryParse(x.ToString(), out ii);
                                    comatb[i] = ii;
                                }
                                i++;
                            }
                        }
                    }
                }
                #endregion
                #region 这里是调用反射
                sendMsg = string.Join("",md.GetPlugins(comatb));
                #endregion
                SendHandle();//调用发送命令   
                Msg = null;//清空消息，等待新的指令
            }
        }
        public void SendHandle()
        {       
            string msg;
            msg = sendMsg;
            byte[] data = Encoding.Default.GetBytes(msg);
            mySocket.SendTo(data, data.Length, SocketFlags.None, RemotePoint);
            msg = "";
        }
        private int getValidPort(string port)
        {
            int lport;
            //测试端口号是否有效  
            try
            {
                //是否为空  
                if (port == "")
                {
                    throw new ArgumentException(
                        "端口号无效，不能启动DUP");
                }
                lport = System.Convert.ToInt32(port);
            }
            catch (Exception e)
            {
                //ArgumentException,   
                //FormatException,   
                //OverflowException  
                Console.WriteLine("无效的端口号：" + e.ToString());
                return -1;
            }
            return lport;
        }
        private IPAddress getValidIP(string ip)
        {
            IPAddress lip = null;
            //测试IP是否有效  
            try
            {
                //是否为空  
                if (!IPAddress.TryParse(ip, out lip))
                {
                    throw new ArgumentException(
                        "IP无效，不能启动DUP");
                }
            }
            catch (Exception e)
            {
                //ArgumentException,   
                //FormatException,   
                //OverflowException  
                Console.WriteLine("无效的IP：" + e.ToString());
                return null;
            }
            return lip;
        }
        public string GetSubString(string str,string a,string b)
        {
            int length = a.Length;
            int start = str.IndexOf(a,0)+length;
            int picklength = str.IndexOf(b,start)-start;
            if (picklength > 0)
            {
                return (str.Substring(start, picklength));
            }
            return "";
        }
    }
}
