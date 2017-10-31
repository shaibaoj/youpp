using com.haopintui;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace haopintui.util
{
    public class QQqunUtil
    {

        public static void sendGroup(CmsForm cmsForm,string content_json)
        {
            if (!cmsForm.appBean.gengfa_qun)
            {
                return;
            }
            if (cmsForm.appBean.qunfa_genfa_status == false)
            {
                return;
            }
            JsonData sync_resul = JsonMapper.ToObject(content_json) as JsonData;
            string content = sync_resul["content"].ToString();
            string group = sync_resul["group"].ToString();
            string qq = sync_resul["qq"].ToString();

            ArrayList textBox_qun_list = QQqunUtil.findGroup(cmsForm);
            ArrayList textBox_qun_guolv = QQqunUtil.findGroup_guolv(cmsForm);
            ArrayList textBox_qun_del = QQqunUtil.findGroup_del(cmsForm);

            string sbf = "";
            if(textBox_qun_list.Contains(group)){
                if (!string.IsNullOrEmpty(content))
                {
                    string[] sArray = Regex.Split(content, "\n", RegexOptions.IgnoreCase);
                    foreach (string i in sArray)
                    {
                        if(QQqunUtil.isContains(textBox_qun_del,i)){
                            break;
                        }
                        if (QQqunUtil.isContains(textBox_qun_guolv, i))
                        {
                            continue;
                        }
                        sbf = sbf+i;
                    }
                }
            
                LogUtil.log_qun_call(cmsForm, "content:" + content);

                 if (!string.IsNullOrEmpty(sbf)){

                    SendItem sendItem = new SendItem();
                    sendItem.from = "群：" + group;
                    sendItem.create_date_str =  DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    content = sbf;

                    content = QQqunUtil.parseContentWenan(cmsForm,content);

                    if (!string.IsNullOrEmpty(content))
                    {
                        //content = UrlUtil.copyImgContent(this, content, sendItem.create_date_str);
                        sendItem.memo = CommonUtil.toText(content);
                        FollowUtil.load_item(cmsForm, sendItem);
                        string follow_path = cmsForm.appBean.follow_path + @"\" + sendItem.create_date_str;
                        if (!Directory.Exists(follow_path))
                        {
                            Directory.CreateDirectory(follow_path);
                        }
                        //UtilFile.write(string.Concat(follow_path, "\\content_wenan.html"), UrlUtil.parseContentWenan(this, content), Encoding.GetEncoding("GB2312"));

                        //UtilFile.write(string.Concat(follow_path, "\\content_img.html"), UrlUtil.parseImg(this, content), Encoding.GetEncoding("GB2312"));
                        UtilFile.write(string.Concat(follow_path, "\\content.html"), content, Encoding.GetEncoding("GB2312"));
                        //((IHTMLDocument2)this.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                        //LogUtil.log_call(this,"---------------------");
                        string out_log;
                        cmsForm.sendSqlUtil.insert(sendItem, out out_log);
                        //LogUtil.log_call(this, "-----------out_log----------" + out_log);
                    }
                    //FollowUtil.load_call(cmsForm);
                }
            }

        }

        public static bool isContains(ArrayList items,string str) {
            foreach (string i in items)
            {
                if (!string.IsNullOrEmpty(i)&&str.Contains(i))
                {
                    return true;
                }
            }
            return false;
        }

        public static ArrayList findGroup(CmsForm cmsForm)
        {
            ArrayList list = new ArrayList();
            string textBox_qun_list = cmsForm.appBean.textBox_qun_list.Trim();
            if(!string.IsNullOrEmpty(textBox_qun_list)){

                string[] sArray = Regex.Split(textBox_qun_list, "\n", RegexOptions.IgnoreCase);
                
                foreach (string i in sArray) {
                    if (!string.IsNullOrEmpty(i.Trim()))
                    {
                        list.Add(i.Trim());
                    }
                }
            }

            return list;
        }

        public static ArrayList findGroup_guolv(CmsForm cmsForm)
        {
            ArrayList list = new ArrayList();
            string textBox_qun_guolv = cmsForm.appBean.textBox_qun_guolv.Trim();
            if (!string.IsNullOrEmpty(textBox_qun_guolv))
            {

                string[] sArray = Regex.Split(textBox_qun_guolv, "\n", RegexOptions.IgnoreCase);

                foreach (string i in sArray)
                {
                    if (!string.IsNullOrEmpty(i.Trim()))
                    {
                        list.Add(i.Trim());
                    }
                }
            }

            return list;
        }

        public static ArrayList findGroup_del(CmsForm cmsForm)
        {
            ArrayList list = new ArrayList();
            string textBox_qun_del = cmsForm.appBean.textBox_qun_del.Trim();
            if (!string.IsNullOrEmpty(textBox_qun_del))
            {
                string[] sArray = Regex.Split(textBox_qun_del, "\n", RegexOptions.IgnoreCase);
                foreach (string i in sArray)
                {
                    if(!string.IsNullOrEmpty(i.Trim())){
                        list.Add(i.Trim());
                    }
                }
            }

            return list;
        }

        public static string parseContentWenan(CmsForm cmsForm, string content)
        {
            try
            {
                //content = CommonUtil.toText(content);
                content = content.Replace("\n", "<br>");
                content = content.Replace("\r", "<br>");
                content = content.Replace("<br>", " <br>");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, string.Concat("[parseContentWenan]出错：", exception.ToString()));
            }

            try
            {
                MatchCollection matchCollections = (new Regex(@"\[CQ:image,file=([\W|\w]+)\]")).Matches(content);
                //MatchCollection matchCollections = (new Regex(@"\[CQ([\W|\w]+)\]")).Matches(content);
                foreach (Match match in matchCollections)
                {
                    string img_code = match.Groups[1].Value.ToString();

                    string img_url_file = cmsForm.app_path + @"\Plugin\CQA\data\image\" + img_code + ".cqimg";
                    //LogUtil.log_call(cmsForm, "img_url_file:" + img_url_file);
                    if (File.Exists(img_url_file))
                    {
                        //LogUtil.log_call(cmsForm, "img_url_file11111:" + img_url_file);
                        StreamReader reader = new StreamReader(img_url_file, Encoding.GetEncoding("GB2312"));
                        string str = null;
                        while ((str = reader.ReadLine()) != null)
                        {
                            if (str.Contains("url="))
                            {
                                string pic_url = str.Split(new char[] { '=' })[1];
                                string content_img = "<IMG src=\"" + pic_url + "\"> <BR>" ;

                                content = content.Replace(match.Groups[0].Value.ToString(), content_img);
                            }
                        }
                        reader.Close();
                        reader.Dispose();
                    }

                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, string.Concat("[parseUrl]出错！", exception.ToString()));
            }

            //try
            //{
            //    ArrayList arrayLists1 = new ArrayList();
            //    MatchCollection matchCollections = (new Regex(Constants.regex_url)).Matches(content);
            //    foreach (Match match in matchCollections)
            //    {
            //        string url = match.Value.ToString();

            //        if (((url.Contains("taobao.com")
            //        || url.Contains("tmall.com")
            //        || url.Contains("yao.95095.com"))
            //        && url.Contains("item.htm") && url.Contains("id=")))
            //        {
            //           string num_iid = TaobaoUtil.get_num_iid(url);
            //           string out_log;
            //           ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + num_iid, cmsForm.appBean.taoke_cookie, out out_log);
            //           if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
            //           {
            //               content = "<IMG src=\"" + ((GoodsItem2)taoke_goods_list[0]).pictUrl + "\"> <BR>" + content;
            //           }
            //        }
            //        else if (url.Contains("activityId") && url.Contains("uland.taobao.com"))
            //        {
            //            string num_iid = TaobaoUtil.get_num_iid(url);
            //            string out_log;
            //            ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + num_iid, cmsForm.appBean.taoke_cookie, out out_log);
            //            if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
            //            {
            //                content = "<IMG src=\"" + ((GoodsItem2)taoke_goods_list[0]).pictUrl + "\"> <BR>" + content;
            //            }
            //        }

            //    }
            //}
            //catch (Exception exception)
            //{
            //    LogUtil.log_call(cmsForm, string.Concat("[parseUrl]出错！", exception.ToString()));
            //}

            return content;
        }


        public static void call_qq(CmsForm cmsForm) {
            try
            {
                if (Process.GetProcessesByName(Constants.qq_jiqiren_exe_name).Length > 0)
                {
                    LogUtil.log_call(cmsForm, "qq机器人已经启动！");
                }
                else
                {
                    LogUtil.log_call(cmsForm, "正在启动qq机器人。。。。");
                    string arguments = "";
                    try
                    {
                        Process.Start(cmsForm.app_path + @"\Plugin\CQA\" + Constants.qq_jiqiren_exe, arguments);
                    }
                    catch
                    {
                        
                    }
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "[call_qq]出错，" + exception.ToString());
            }
            try
            {
                if (Process.GetProcessesByName(Constants.qq_jiqiren_proxy_name).Length > 0)
                {
                    LogUtil.log_call(cmsForm, "qq监控代理服务已经启动！");
                }
                else
                {
                    LogUtil.log_call(cmsForm, "正在启动qq监控代理服务。。。。");
                    string arguments = "";
                    try
                    {
                        Process.Start(cmsForm.app_path + @"\Plugin\CQA\" + Constants.qq_jiqiren_proxy_exe, arguments);
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "[call_qq]出错，" + exception.ToString());
            }
        }

    }
}
