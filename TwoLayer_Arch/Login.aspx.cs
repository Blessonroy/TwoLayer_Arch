using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoLayer_Arch
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionCls obcls = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = "select count(Id) from T3 where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = obcls.Fn_Scalar(a);
            if (cid == "1")
            {
                Response.Redirect("UserProfile.aspx");
            }
            else
            {
                Label1.Text = "Invalid username or password";
            }
        }
    }
}