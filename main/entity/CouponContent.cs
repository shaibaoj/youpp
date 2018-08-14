using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace haopintui.entity
{
    public class CouponContent
    {

        public string content = ""; //原来

        public string num_iid;
        public int status; //状态

        public int volume;
        public double price;
        public double coupon_money;

        public string memo = "";

        public double get_buy_price()
        {
            return (price - coupon_money);
        }

    }
}
