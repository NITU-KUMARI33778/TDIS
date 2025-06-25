using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class sign_up_page_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (TextBox1.Text == "")

        {
            IbIMsg.Text = "Please Enter your Full Name";
            return;
        }
        if (TextBox2.Text == "")
        {
            IbIMsg.Text = "PLease enter your Email ID";
            return;
        }
        if (TextBox3.Text == "")
        {
            IbIMsg.Text = "PLease enter your Phone no";
            return;
        }
        if ( RadioButton1.Checked == false && RadioButton2.Checked == false )
        {
                IbIMsg.Text = "PLease enter your Gender";
                return;
            }
            if (TextBox8.Text == "")
            {
                IbIMsg.Text = "PLease Create your Password  ";
                return;
            }
            if (TextBox9.Text == "")
            {
                IbIMsg.Text = "PLease Confirm your Password" ;
                return;
            }
            if (TextBox4.Text == "")
            {
                IbIMsg.Text = "PLease Enter your Address"  ;
                return;
            }
            if (TextBox5.Text == "")
            {
                IbIMsg.Text = "PLease Enter your City" ;
                return;
            }
            if (TextBox6.Text == "")
            {
                IbIMsg.Text = "PLease enter your State";
                return;
            }
            if (TextBox7.Text == "")
            {
                IbIMsg.Text = "PLease enter your PinCode ";
                return;
            }
        string GEN = "";
        if(RadioButton1.Checked==true)
        {
            GEN = "MALE";
        }
        else if(RadioButton2.Checked==true)
        {
            GEN = "FEMALE";
        }
        String AA = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
        SqlConnection CONN = new SqlConnection(AA);
        
        CONN.Open();
        SqlCommand CMD = new SqlCommand();
        CMD.Connection = CONN;
        CMD.CommandText = "Insert into Userdetails (Full_Name,Email_ID,Phone_no,Gender,Create_Password,Confirm_Password,Address,City,State,Pin_Code,Username) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + GEN +"','"+ TextBox8.Text +"','"+ TextBox9.Text+"','"+ TextBox4.Text +"','"+ TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text+ "','"+ TextBox10.Text + "')";
        CMD.ExecuteNonQuery();
        CONN.Close();
        RadioButton1.Checked = false;
            RadioButton2.Checked = false;
        TextBox1.Text =
            TextBox2.Text = "";
            TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        IbIMsg.Text = "Your Data is Saved";
            }

} 