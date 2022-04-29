using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
namespace Arbeidskrav1_OOP
{
    public partial class Instrument_select : Form
    {
        string con = ConfigurationManager.ConnectionStrings["DatabaseOOP"].ConnectionString;
        public Instrument_select()
        {
            InitializeComponent();

            ImportToComboBox();
        }
        void ImportToComboBox()
        {
            SqlConnection con1 = new SqlConnection(con);
            string sqlQuery = "SELECT Parameter_ID FROM PARAMETER";
            SqlCommand sql = new SqlCommand(sqlQuery, con1);
            con1.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                ChooseInstrumentIDComboBox.Items.Add(sqlQuery);
            }
            con1.Close();
        }
        private void ConnectInstrumentIDBtn_Click(object sender, EventArgs e)
        {
            {
                if (ChooseInstrumentIDComboBox.Text != "")
                {
                    string Combobox, sqlQuery;
                    try
                    {
                        //Oppretter en connection mot databasen med string definert i App.config:
                        SqlConnection con1 = new SqlConnection(con); //kaller denne for con1
                        Combobox = ChooseInstrumentIDComboBox.Text;        //Verdien som skal inn i databasen
                        sqlQuery = String.Concat(@"UPDATE PLACEHOLDER SET Parameter_ID =('", Combobox, "') WHERE status = 1"); //Setter variabelen carMake inn i sql-spørringen
                        con1.Open();
                        SqlCommand command = new SqlCommand(sqlQuery, con1);
                        command.ExecuteNonQuery();
                        con1.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    this.Close();
                }

                else

                {
                    MessageBox.Show("Please choose one of the Instrument tags avaiable!");
                }
            }
        }
    }
}
