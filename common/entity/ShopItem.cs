using System;

public class ShopItem
{
    public string title = "";
    public string nick = "";
    public string addr = "";
    public string catName = "";
    public string pic_url = "";

    public string method_0()
    {
        return ("shopName:[" + this.title + "], wangwangName:[" + this.nick + "], shopAddr:[" + this.addr + "], mainCat:[" + this.catName + "], shopImg:[" + this.pic_url + "]");
    }
}

