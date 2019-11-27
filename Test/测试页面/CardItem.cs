using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.测试页面
{
    public class CardItem
    {
        public CardItem() { }
        public CardItem(int id, string name)
        {
            HCID = id;
            this.name = name;
        }

        public int HCID { get; set; }
        public string name { get; set; }
        public int num { get; set; }


    }

}