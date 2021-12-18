using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YksTercihRobotu4
{
    public partial class tercihekrani : Form
    {
        public tercihekrani()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-NU510C0;Initial Catalog=SqlYKSTercihDB;Integrated Security=True";

        SqlConnection connect = new SqlConnection(constring);
        DataTable dt = new DataTable();

        private void tercihekrani_Load(object sender, EventArgs e)
        {


        }



        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = advancedDataGridView1.SortString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();

            if (checkBox1.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite where PuanTipi = 'SAYISAL' ", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }

            if (checkBox2.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite where PuanTipi = 'EŞİT AĞIRLIK'", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }
            if (checkBox3.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }
            if (checkBox4.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite where PuanTipi = 'SÖZEL'", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }
            if (checkBox5.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite where ProgramSuresi = '4 YIL'", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }
            if (checkBox6.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite where ProgramSuresi = '2 YIL'", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }
            if (checkBox7.Checked == true)
            {
                SqlDataAdapter adtr = new SqlDataAdapter("Select * From TabloUniversite where ProgramSuresi = '2 YIL'", connect);
                adtr.Fill(dt);
                advancedDataGridView1.DataSource = dt;



            }


        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {

            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                //Yazdırma işlemi için kodlarım yer alıyor.
            }

        }

        
    }

}

