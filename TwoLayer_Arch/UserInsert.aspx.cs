using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoLayer_Arch
{
    public partial class UserInsert : System.Web.UI.Page
    {
        ConnectionCls coc = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/pic/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string strinsert = "insert into T3 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + path + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = coc.Fn_Nonquery(strinsert);
            if (i == 1)
            {
                Label1.Text = "Inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
    }
}