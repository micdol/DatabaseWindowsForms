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

namespace DatabaseWindowsForms
{
    public partial class FormDatabase : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Student\\source\\repos\\DatabaseWindowsForms\\DatabaseWindowsForms\\Database.mdf;Integrated Security = True";

        public FormDatabase()
        {
            InitializeComponent();
            loadList();
        }

        private void loadList()
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                try
                {
                    listBoxID.Items.Clear();
                    listBoxComment.Items.Clear();
                    listBoxTime.Items.Clear();
                    listBoxValue.Items.Clear();

                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Measurements", dbConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxID.Items.Add(reader[0]);
                            listBoxTime.Items.Add(reader[1]);
                            listBoxValue.Items.Add(reader[2]);
                            listBoxComment.Items.Add(reader[3]);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            updateGridView();
        }

        private void updateGridView()
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("select * from measurements", dbConnection);
                    if (dbConnection.State == ConnectionState.Closed)
                        dbConnection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sqlCmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbdataset;
                    dataGridViewMeasurements.DataSource = dbdataset;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error 2");
                }
            }

        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                try
                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "INSERT INTO Measurements (value, time, comment) VALUES( (@_value), (@_time), (@_comment))";
                    sqlCmd.Parameters.AddWithValue("@_value", textBoxValue.Text);
                    sqlCmd.Parameters.AddWithValue("@_time", DateTime.Now);
                    sqlCmd.Parameters.AddWithValue("@_comment", textBoxComment.Text);
                    sqlCmd.Connection = dbConnection;
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved succesfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            loadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                try
                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "DELETE FROM Measurements WHERE Id = (@_ID)";
                    sqlCmd.Parameters.AddWithValue("@_ID", listBoxID.SelectedItem.ToString());
                    sqlCmd.Connection = dbConnection;
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted succesfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            loadList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                try
                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "UPDATE Measurements SET value=(@_value), time=(@_time), comment=(@_comment) WHERE Id = (@_ID)";
                    sqlCmd.Parameters.AddWithValue("@_value", textBoxValue.Text);
                    sqlCmd.Parameters.AddWithValue("@_time", DateTime.Now);
                    sqlCmd.Parameters.AddWithValue("@_comment", textBoxComment.Text);
                    sqlCmd.Parameters.AddWithValue("@_ID", listBoxID.SelectedItem.ToString());
                    sqlCmd.Connection = dbConnection;
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            loadList();
        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.Measurements' . Możesz go przenieść lub usunąć.
            this.measurementsTableAdapter.Fill(this.databaseDataSet.Measurements);

        }
    }
}

