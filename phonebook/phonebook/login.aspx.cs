using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
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
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from registration WHERE username='"+username.Text+"' AND password='"+password.Text+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        i = int.Parse(dt.Rows.Count.ToString());

        if (username.Text == "" | password.Text == "")
        {
            Response.Write("<script>alert('Sva polja moraju biti popunjena!');</script>");
        }
            else {
           

            if (i == 0)
            {
                Response.Write("<script>alert('Korisnicko ime nije pronadjeno u bazi podataka');</script>");

            }


            else
            {

                Session["username"] = username.Text;
                Response.Redirect("mycontact.aspx");
            }
        }
    }
}