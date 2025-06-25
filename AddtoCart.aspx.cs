using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class TDIS_PurchaseDetails : System.Web.UI.Page
{
    SqlConnection CONN = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        String AA = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
        CONN = new SqlConnection(AA);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        SqlDataAdapter DA = new SqlDataAdapter();
        //CMD.CommandText = "Select Item_name, rate, (rate* 1) as Qty, (Rate * 1) as Amount from AddtoCart where Username '" + User_name + "' and Status='Open' ";
        CMD.CommandText = "Select Item_name, rate, (1* 1) as Qty, (Rate * 1) as Amount from AddtoCart where User_name = '" + User_name + "' and Status='Open'  ";
        DA.SelectCommand = CMD;
        DataSet DS = new DataSet();
        DA.Fill(DS);
        
        GridView1.DataSource = DS.Tables[0];
        GridView1.DataBind();
        Label2.Text = "";
        int TT = 0;
        for(int I=0; I< DS.Tables[0].Rows.Count;I++)
        {
            TT += (Convert.ToInt16(DS.Tables[0].Rows[I].ItemArray[3]));
        }
        Label2.Text = TT.ToString();
    }
}