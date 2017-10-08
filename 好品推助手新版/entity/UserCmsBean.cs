using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace haopintui.entity
{
   public  class UserCmsBean
    {

       public int weizhi = 0;  //操作到的位置
       public string user_id;
       public string app_id;

       public ArrayList items; //商品数据

       public Queue<CmsPlanItem> ListQueue = new Queue<CmsPlanItem>();  

       public ArrayList itemsTaoke;


    }
}
