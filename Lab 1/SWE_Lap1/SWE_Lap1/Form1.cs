using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// import oracle libraries
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_Laps
{
    public partial class Form1 : Form
    {
        // TASK :
        // - Connect program to oracle Database.
        // - Display each column in different comboboBox



        // 1- Identify connection
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 2- Connect to database conn and open it
            conn = new OracleConnection(ordb);
            conn.Open();

            // 3- Your command goes here
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ActorID from Actors";
            cmd.CommandType = CommandType.Text;

            // 4- Excute command
            // 4.1- Create reader object so i can read from database
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // 4.2- Specify the column you want to read
                // Actor ID is the first column in Database at index 0
                // if you do not know the index of the column you can index using its name with ""
                comboBox1.Items.Add(reader[0]);
            }

            cmd.CommandText = "select ActorName from Actors";
            reader = cmd.ExecuteReader();
            while (reader.Read()) { comboBox2.Items.Add(reader[0]); }

            cmd.CommandText = "select Gender from Actors";
            reader = cmd.ExecuteReader();
            while (reader.Read()) { comboBox3.Items.Add(reader[0]); }

            // 4.3- Close reader
            reader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 5- Close connection and clean reources
            conn.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
