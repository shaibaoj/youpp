using System;
using System.Collections.Generic;
using System.Text;

namespace com.haopintui
{
    public class Constants
    {
        public static string api_url = "ok.haopintui.net";
        public static string software_url = "http://software.huopinjie.com";
        public static string domain_url = "www.haopintui.net";
        public static string put_tools_url = "http://put.tools.youdanhui.com";

        public static string product_code = "zhushou";
        public static int version = 187; //版本 更新判断
        public static string version_str = "2.0"; //显示的版本编号

        public static string main_exe = "好品推助手.exe";
        public static string auto_update_exe = "AutoUpdate.exe";
        public static string alimama_login_exe = "AliLogin.exe";
        public static string alimama_login_exe_name = "AliLogin";

        public static string weibo_login_exe = "WeiboLogin.exe";
        public static string weibo_login_exe_name = "WeiboLogin";

        public static string weixin_login_exe = "HptWeixin.exe";
        public static string weixin_login_exe_name = "HptWeixin";

        public static string qq_jiqiren_exe = "CQA.exe";
        public static string qq_jiqiren_proxy_exe = "Flexlive.CQP.CSharpProxy.exe";
        public static string qq_jiqiren_exe_name = "CQA";
        public static string qq_jiqiren_proxy_name = "Flexlive.CQP.CSharpProxy";

        public static string applyreason_pre = "该申请通过好品推助手发出(数万淘客推广，合作QQ 3563353667)：";

        public static string login_url = "http://" + api_url + "/zhushou/login";

        public static int FORM_MSG_TYPE_CHKTMOUT = 3;
        public static int FORM_MSG_TYPE_CLOSENOTLOGINED = 4;
        public static int FORM_MSG_TYPE_LOGINED = 1;
        public static int FORM_MSG_TYPE_NOTOPEN = 2;

        //public static string cms_url = "http://" + api_url + "/user_cms.php";
        //public static string user_taoke_url = "http://" + api_url + "/item.php";
        //public static string user_taoke_url_user = "http://" + api_url + "/item_user.php";
        //public static string user_taoke_create_url = "http://" + api_url + "/taoke_item.php";
        //public static string user_goods_url = "http://" + api_url + "/goods.php";
        //public static string cms_tongji_url = "http://" + api_url + "/tongji.php";
        //public static string cms_tongzhi_url = "http://" + api_url + "/tongzhi.php";

        //public static string user_taoke_create_url_plan = "http://" + api_url + "/taoke_item_plan.php";

        //public static string user_goods_click_url = "http://" + api_url + "/click.php";
        //public static string user_short_url = "http://" + api_url + "/short_url.php";
        //public static string goods_api_url = "http://" + api_url + "/goods_api_url.php";

        //public static string user_ali_order_create_url = "http://" + api_url + "/taoke_order.php";

        public static string user_qunfa_url = "http://" + api_url + "/zhushou/goods/user";
        //public static string user_qunfa_top_url = "http://" + api_url + "/user.php";

        public static string sms_url = "http://" + api_url + "/sms.php";
        public static string kouling_url = "http://" + api_url + "/kouling.php";

        public static string config_ini = "/config/config.ini";
        public static string config_qq_template_ini = "/config/qq_template.txt";
        public static string config_weixin_template_ini = "/config/weixin_template.txt";
        public static string config_weibo_template_ini = "/config/weibo_template.txt";

        public static string config_qun_template_ini_qunhao = "/config/qun_template_qunhao.txt";
        public static string config_qun_template_ini_guolv = "/config/qun_template_guolv.txt";
        public static string config_qun_template_ini_del = "/config/qun_template_del.txt";

        public static string config_taoke_cookie = "/config/taoke_cookie.txt";

        public static string regex_url = "((http|ftp|https)://)(([a-zA-Z0-9\\._-]+\\.[a-zA-Z]{2,6})|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(:[0-9]{1,4})*(/[a-zA-Z0-9\\&%_\\./-~-]*)?";

        public static bool set_ie_boolean = false;

        public static string coupon_url_m = "http://shop.m.taobao.com/shop/coupon.htm?seller_id={seller_id}&activity_id={activity_id}";
        public static string coupon_url_pc = "http://taoquan.taobao.com/coupon/unify_apply.htm?sellerId={seller_id}&activityId={activity_id}&scene=taobao_shop";

        public static string config_follow_path = @"\config\临时文件夹\follow";

        //qhkj_dtkp
        public static string uland_url = "http://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}";
        public static string kouling_template = "领#优惠券面额#元券下单地址：#手淘短网址#\n复制这条信息，#淘口令# ，打开【手机淘宝】即可领券并下单";


        public static string binding_url = "http://" + api_url + "/bind.php";
        public static string binding_income_url = "http://" + api_url + "/bind_income.php";




    }
}
