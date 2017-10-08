using System;

public class GoodsItem1
{
    public double double_0 = 0.0;
    public double double_1 = 0.0;
    public int int_0 = 0;
    public string num_iid = "";
    public string title = "";
    public string price = "";
    public string user_num_id = "";
    public string string_4 = "";
    public string string_5 = "";

    public string method_0()
    {
        return string.Concat(new object[] { 
            this.num_iid, "\t", this.title.Replace("'", "").Replace("\t", ""), "\t", this.price, "\t", this.user_num_id, "\t", this.int_0, "\t", this.double_0, "\t", this.string_4, "\t", this.double_1, "\t", 
            this.string_5
         });
    }
}

