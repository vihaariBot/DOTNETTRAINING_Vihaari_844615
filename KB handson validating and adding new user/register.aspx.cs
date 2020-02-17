using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KB_handson11_2
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            string name = fname.Text; 
            int agee = int.Parse(age.Text);
            string lname = loginname.Text;
            string pass = password.Text;
            int ex = int.Parse(exp.Text);
            int salar = int.Parse(sal.Text);

            kbhEntities2 x = new kbhEntities2();
           // var tab = from i in x.kbhts select i;
           kbht n = new kbht();
            n.firstname = name;
            n.age = agee;
            n.login = lname;
            n.password = pass;
            n.experience = ex;
            n.salary = salar;
            x.kbhts.Add(n);
            x.SaveChanges();
            Response.Redirect("secondpage.aspx");

        }
    }
}