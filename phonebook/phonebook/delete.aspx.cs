﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class delete : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|telephonedirectory.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        int id;
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

        con.Open();
        id = Convert.ToInt32 (Request.QueryString["id"].ToString());

        if (Session["username"] == null)
        {
            Response.Redirect("login.aspx");
        }

        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from add_contact where id="+id+"";
        cmd.ExecuteNonQuery();



















        Response.Redirect("mycontact.aspx");

    }
}