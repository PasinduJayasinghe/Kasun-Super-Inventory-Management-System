using System.Data;
using System.Data.SqlClient;






namespace KasunSuperInventoryManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\thisa\\OneDrive\\Desktop\\Bit Project\\KasunSuperInventoryManagementSystem\\KasunSuperInventoryManagementSystem\\inventory.mdf\";Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from registration where username='"+userNametextBox.Text+ "'and password='"+ passwordtextBox.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i=Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Username or Password is Incorrect!");
            }
            else
            {
                this.Hide();
                MDIParent1 mdi=new MDIParent1();
                mdi.Show();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();    
            }
            con.Open();
        }

        private void userNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
