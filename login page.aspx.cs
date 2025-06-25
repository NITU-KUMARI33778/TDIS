using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class login_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String AA = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
        SqlConnection CONN = new SqlConnection(AA);
        SqlCommand CMD1 = new SqlCommand(AA);
        CMD1.Connection = CONN;
        CMD1.CommandText = "select * from Userdetails where Username ='" + TextBox1.Text + "' and Create_Password='" + TextBox2.Text + "'";
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = CMD1;
        DataSet DS = new DataSet();
        DA.Fill(DS);
        if (DS.Tables[0].Rows.Count > 0)
        {
            Session["Username"] = TextBox1.Text;
            //Response.Redirect("dharmavaram saree .aspx");
            Response.Redirect("AddtoCart.aspx");
        }
        else

        {
            IbIMsg.Text = "Your Username and Password is incorrect ";
            return;


        }

    }
}