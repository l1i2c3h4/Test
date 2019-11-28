using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.测试页面
{
    public class Card
    {
        private List<CardItem> cards = new List<CardItem>();

        public List<CardItem> haocaiInCard
        {
            get
            {
                return cards;
            }
        }
        public void addHaoCai(int ID, int number,string name)
        {
            //检测购物车中现在是否有选中ID的货物
            CardItem HaoCai = cards.Find(b => b.HCID == ID);
            if (HaoCai != null)
            {
                HaoCai.num += number;
                if (HaoCai.num == 0)
                    cards.Remove(HaoCai);
                return;
            }

            else
            {

                HaoCai = new CardItem();
                HaoCai.HCID = ID;
                HaoCai.name = name;
                HaoCai.num = number;
                if (HaoCai != null)
                    cards.Add(HaoCai);

            }

        }
       
    }
}