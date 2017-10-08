using System;

public class CouponItem
{
    public int money = 0;
    public int leftCount = 0;
    public int receiveCount = 0;
    public string endTime = "0";

    public string ToString()
    {
        if (this.leftCount > 0)
        {
            return string.Concat(new object[] { this.money, "元优惠券，剩【", this.leftCount, "】张(已领用", this.receiveCount, "张)，有效期：【", this.endTime, "】" });
        }
        return "该优惠券不存在或者已经过期！ ";
    }
}

