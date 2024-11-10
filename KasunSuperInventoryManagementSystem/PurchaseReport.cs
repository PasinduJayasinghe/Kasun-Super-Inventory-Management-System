using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KasunSuperInventoryManagementSystem
{
    public partial class PurchaseReport : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\thisa\\OneDrive\\Desktop\\Bit Project\\KasunSuperInventoryManagementSystem\\KasunSuperInventoryManagementSystem\\inventory.mdf\";Integrated Security=True");





        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * purchaseMaster";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["productTotal"].ToString());
            }

            label3.Text = i.ToString();

        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startDate;
            string endDate;

            startDate = dateTimePicker1.Value.ToString("dd/mm/yyyy");
            endDate = dateTimePicker2.Value.ToString("dd/mm/yyyy");

            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * purchaseMaster where purchaseDate>='"+startDate.ToString()+"' AND purchaseDate<='"+endDate.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["productTotal"].ToString());
            }

            label3.Text = i.ToString();

        }
    }
    }
   