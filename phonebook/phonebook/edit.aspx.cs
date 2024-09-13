using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    int id;

    
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|telephonedirectory.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

        con.Open();

        if (Session["username"] == null)
        {
            Response.Redirect("login.aspx");
        }
        id = Convert.ToInt32( Request.QueryString["id"].ToString());

        if (IsPostBack) return;

        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from add_contact where id=" + id + "";
         cmd.ExecuteScalar();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        foreach(DataRow dr in dt.Rows)
        {

            firstname.Text = dr["firstname"].ToString();
            lastname.Text = dr["lastname"].ToString();
            TextBox1.Text = dr["contactno"].ToString();
            email.Text = dr["email"].ToString();
            resident.Text   = dr["resident_adress"].ToString();
            city.Text = dr["city"].ToString();
        }


    }

    protected void button1_Click(object sender, EventArgs e)
    {

        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "UPDATE add_contact SET firstname='"+firstname.Text+ "',lastname='" + lastname.Text + "', contactno='" + TextBox1.Text + "', email='" + email.Text + "', resident_adress='" + resident.Text + "', city='" + city.Text + "' where id=" + id + "";


        cmd.ExecuteNonQuery();
        Response.Redirect("mycontact.aspx");








    }
}