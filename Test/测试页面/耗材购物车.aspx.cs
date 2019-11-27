using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test.测试页面
{
    public partial class 耗材购物车 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.ToString());
            string name = TextBox2.ToString();
            int number = int.Parse(TextBox3.ToString());
            if (Session["haocai"] == null)
                Session["haocai"] = new Card();
            Card card = Session["haocai"] as Card;
            card.addHaoCai(id, number, name);
        }
    }
}