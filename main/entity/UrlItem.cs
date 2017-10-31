using System;
using System.Collections.Generic;
using System.Text;

namespace haopintui.entity
{
    public class UrlItem
    {
        public string ori_url = "";
        public string url = "";
        public string title = "";
        public string item_url = "";
        public string click_url = "";
        public string nick = "";
        public string content = "";
        public int url_type = 0; //0 一般链接 1 优惠券 2产品链接 3 店铺链接 4 二合一链接 5好品商品链接 6营销计划
        public string num_iid = "";
        public string user_num_id = "";

        public string pc_url = "";
        public string m_url = "";

        public CouponItem couponItem;
        public TaokeItem taokeItem;

        public int tkMktStatus = 0;


    }
}
