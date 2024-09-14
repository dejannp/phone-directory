using System;
using System.Data;
using System.Data.SqlClient;

public partial class add_contact : System.Web.UI.Page
{
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

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        if (firstname.Text == "" | lastname.Text == "" | TextBox1.Text == "" | email.Text=="" | resident.Text == "" | city.Text == "")
        {
            Response.Write("<script>alert('All fields must be filled')</script>");
        }
        else {

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "INSERT INTO add_contact (username,firstname,lastname,contactno,email,resident_adress,city) VALUES ('" + Session["username"] + "','" + firstname.Text + "','" + lastname.Text + "','" + TextBox1.Text + "','" + email.Text + "','" + resident.Text + "','" + city.Text + "')";

            cmd1.ExecuteNonQuery();

            Response.Write("<script>alert('New contact added succesfuly!')</script>");

        }

    }
}