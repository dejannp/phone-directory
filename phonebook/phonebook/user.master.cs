using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        labela.Text = " ";
        labela.Text = "Loged in as ";
        labela.Text = labela.Text + Session["username"].ToString();




    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("login.aspx");







    }
}
