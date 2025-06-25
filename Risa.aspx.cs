using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class TDIS_langa_voni_telangana_Risa : System.Web.UI.Page
{
    SqlConnection CONN = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        String AA = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
        CONN = new SqlConnection(AA);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label1.Text + "','" + Label2.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label3.Text + "','" + Label4.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa2.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label5.Text + "','" + Label6.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa3.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label7.Text + "','" + Label8.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa4.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label9.Text + "','" + Label10.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa5.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label11.Text + "','" + Label12.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa6.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label13.Text + "','" + Label14.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa7.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label15.Text + "','" + Label16.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa8.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label17.Text + "','" + Label18.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa9.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        String Booking_Date = DateTime.Now.ToShortDateString();
        String User_name = Session["Username"].ToString();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CONN.Open();
        CMD.CommandText = "Insert into AddtoCart(Item_Name,Rate,Booking_Date,User_name,image_url) values('" + Label19.Text + "','" + Label20.Text + "','" + Booking_Date + "','" + User_name + "','~/TDIS/risa tripura/risa10.jpeg')";
        CMD.ExecuteNonQuery();
        CONN.Close();

        Response.Write("Script>Alert('Item Added')</Script>");
        Response.Write("<Script>alert('select Add to Cart')</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        Session["RATE"] = Label11.Text;
        Response.Redirect("BILL PAY.aspx");
    }
}