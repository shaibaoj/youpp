using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace haopintui
{
    public class AppBean
    {
        public string config_ini = "";
        public Hashtable hashtable_config = new Hashtable();
        public Hashtable hashtable_weibo = new Hashtable();

        public long user_id = 0L;
        public string user_name = "";
        public string user_key = "";

        public string alimama_acc = "";
        public string alimama_pwd = "";
        public bool alimama_auto_login = false;
        public bool alimama_scan_login = false;
        public bool alimama_login_status = false;
        public bool weibo_login_status = false;

        public string weibo_login_name = "";

        public string uu_username = "";
        public string uu_pwd = "";

        public string taoke_cookie="";

        public bool apply_taoke_url_status = false;
        public string applyreason = "";

        public string member_id = "";
        public string cms_siteid = "";
        public string cms_adzoneid = "";
        public string cms_app_id = "";
        public bool cms_jihua = true;
        public bool cms_xianshi = false;

        public bool alimama_cookie_put_url_status = false;
        public int alimama_request_url_time = 0;

        public string taokouling = null;

        public string qqquan_path = "";
        public string qqquan_shunxun_path = "";
        public ArrayList qqqun_list;

        public int send_coupon_num = 0;
        public float send_commission = 0;
        public int send_qunfa_times_jiange = 0;
        public int send_qunfa_times = 0;

        public string qq_com_sid = "";
        public string qq_com_aid = "";
        public string qq_com_pid = "";

        public string qq_queqiao_sid = "";
        public string qq_queqiao_aid = "";
        public string qq_queqiao_pid = "";

        public string weixin_sid = "";
        public string weixin_aid = "";
        public string weixin_pid = "";

        public string weibo_sid = "";
        public string weibo_aid = "";
        public string weibo_pid = "";

        public string weixin_path = "";
        public string weixin_path_img = "";
        public ArrayList weixin_list;
        public IntPtr weixin_win_id;

        public ArrayList weibo_list;

        public string send_content;
        public bool send_status = false;

        public string follow_path = "";

        public bool qunfa_genfa_status = false;
        public bool qunfa_genfa_qunfa_status = false;

        public string qunfa = "";
        public string alimama_id = "";
        public string user_type_name = "";
        public string qunfa_date = "";

        public int qunfa_hours = 1;

        public string weixin_template = "";
        public string qq_template = "";
        public string weibo_template = "";


        public string textBox_qun_list = "";
        public string textBox_qun_guolv = "";
        public string textBox_qun_del = "";

        public bool gengfa_qun = false;

        public bool qunfa_duanlian = false;
        public string qunfa_duanlian_fangshi = "1";

        public UserCmsBean userCmsBean;
        public UserCmsBean userCmsBean_user = new UserCmsBean();

        public ArrayList pid_qq_list;
        public ArrayList pid_weixin_list;

        public int qunfa_caiji_pinlv = 10;

        public int qunfa_ds_s1 = 0;
        public int qunfa_ds_f1 = 0;
        public int qunfa_ds_s2 = 23;
        public int qunfa_ds_f2 = 50;

        public int ali_order_pinlv = 1;
        public int ali_order_days = 1;
        public bool ali_order_status = false;

        public int qun_price1 = 0;
        public int qun_price2 = 0;


        public Queue<TaokeItem> listTaokeItemQueue = new Queue<TaokeItem>();  

    }
}
