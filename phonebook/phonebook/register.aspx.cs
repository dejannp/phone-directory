using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|telephonedirectory.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

        con.Open();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        int i = 0;
        SqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select * from registration where username='"+username.Text+"'";
        cmd1.ExecuteNonQuery();
        DataTable dt1 = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        da1.Fill(dt1);
        i = int.Parse(dt1.Rows.Count.ToString());
        Response.Write("<script>alert(i)</script>");


        if (username.Text == "" | firstname.Text == "" | lastname.Text == "" | email.Text == "" | contact.Text == "" | password.Text == "")
        {
            Response.Write("<script>alert('Sva polja moraju biti popunjena');</script>");
        }

        else {

            if (i == 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into registration (firstname,lastname,email,username,password,contact) values ('" + firstname.Text + "','" + lastname.Text + "','" + email.Text + "','" + username.Text + "','" + password.Text + "','" + contact.Text + "') ";
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registracija uspješna');</script>");

            }

            else
            {

                Response.Write("<script>alert('Korisničko ime je već registrovano!');</script>");
            }

        }

        









    }
}