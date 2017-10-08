using System;

public class Store
{
    public float avg_commission;
    public string member_id = "";
    public string ori_member_id = "";
    public string title = "";
    public string shop_url = "";

    public string toString()
    {
        return string.Concat(new object[] { "memberID:[", this.member_id, "], oriMemberId:[", this.ori_member_id, "], shopTitle:[", this.title, "], AvgCommission:[", this.avg_commission, "], shopUrl:[", this.shop_url, "]" });
    }
}

