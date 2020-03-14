using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Work_1
{
    public partial class Form1 : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source = DESKTOP-KCS7V0D\\SQLEXPRESS; Initial Catalog = Nail_Salon;" + "Integrated Security = true;");
        SqlDataAdapter daClient, daAppointment;
        DataSet ds;
        SqlCommandBuilder cb;
        BindingSource bsClient, bsAppointment;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            
            ds = new DataSet();
            daClient = new SqlDataAdapter("Select * from Client", dbConn);
            daAppointment = new SqlDataAdapter("SELECT * from Appointment", dbConn);
            cb = new SqlCommandBuilder(daAppointment);
            daClient.Fill(ds, "Client");
            daAppointment.Fill(ds, "Appointment");
            DataRelation dr = new DataRelation("FK__Appointment__CID__6D0D32F4",
                ds.Tables["Client"].Columns["CID"],
                ds.Tables["Appointment"].Columns["CID"]);
            ds.Relations.Add(dr);

            //DATA BIDING
            bsClient = new BindingSource();
            bsClient.DataSource = ds;
            bsClient.DataMember = "Client";
            bsAppointment = new BindingSource();
            bsAppointment.DataSource = bsClient;
            bsAppointment.DataMember = "FK__Appointment__CID__6D0D32F4";

            dgvClient.DataSource = bsClient;
            dgvAppointment.DataSource = bsAppointment;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string insert_query = "insert into Appointment(CID, SID, EmID, TyID, AtID, Duration, Price, Date) ";
            //insert_query += "values(@CID, @SID, @EmID, @TyID, @AtID, @Duration, @Price, @Date)";
            //command = new SqlCommand(insert_query, dbConn);
            //command.Parameters.AddWithValue("@CID", CID_add.Text);
            //command.Parameters.AddWithValue("@SID", SID_add.Text);
            //command.Parameters.AddWithValue("@EmID", EmID_add.Text);
            //command.Parameters.AddWithValue("@TyID", TyID_add.Text);
            //command.Parameters.AddWithValue("@AtID", AtID_add.Text);
            //command.Parameters.AddWithValue("@Duration", Duration_add.Text);
            //command.Parameters.AddWithValue("@Price", Price_add.Text);
            //command.Parameters.AddWithValue("@Date", Date_add.Text);
            //dbConn.Open();
            //command.ExecuteNonQuery();
            //dbConn.Close();
            daAppointment.Update(ds, "Appointment");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daAppointment.Update(ds, "Appointment");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            daAppointment.Update(ds, "Appointment");
            
        }
    }
}
