using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace haopintui.entity
{
    public class CouponContentSend
    {

        public CouponContent couponContent;

        public string content = ""; //原来
        public string content_send = ""; //需要发送 qq
        public string content_weixin = ""; //文字
        public string content_weixin_img = ""; //图片

        public ArrayList imgList;

        public string memo = "";

        public ArrayList urlList;

        public string num_iid;

        public int volume;
        public double price;
        public double coupon_money;
        public string coupon_url;

        public int status; //状态
        public string uland_url;

        public string market_url;

        public int url_type;

        public double get_buy_price()
        {
            return (price - coupon_money);
        }

    }
}
