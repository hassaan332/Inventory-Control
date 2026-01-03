using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\line\Desktop\repos\InventoryControl\InventoryControl\bin\Debug\net8.0-windows\InventoryDatabase.accdb;";
            connection = new OleDbConnection(connectionString);
            LoadData();
        }
        
        private void LoadData()
        {
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ItemID, SerialNo, Description, Model, Location, StockDate, Available FROM Inventory", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(txtSerialNo.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtModel.Text) ||
                    string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Additional length checks (adjust according to your database schema)
                if (txtSerialNo.Text.Length > 20) // Assuming SerialNo max length is 20
                {
                    MessageBox.Show("SerialNo exceeds maximum length.");
                    return;
                }

                // Note: If ItemID is auto-incremented, you might not need to set it during insertion.
                // If not, ensure you have it defined correctly and it's a valid integer.
                if (!int.TryParse(txtItemID.Text, out int itemId))
                {
                    MessageBox.Show("ItemID must be a valid integer.");
                    return;
                }

                connection.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO Inventory (ItemID, SerialNo, Description, Model, Location, StockDate, Available) VALUES (@ItemID, @SerialNo, @Description, @Model, @Location, @StockDate, @Available)", connection);

                command.Parameters.Add("@ItemID", OleDbType.Integer).Value = itemId;
                command.Parameters.Add("@SerialNo", OleDbType.VarChar).Value = txtSerialNo.Text; // Ensure SerialNo is a valid string
                command.Parameters.Add("@Description", OleDbType.VarChar).Value = txtDescription.Text; // Ensure Description is a valid string
                command.Parameters.Add("@Model", OleDbType.VarChar).Value = txtModel.Text; // Ensure Model is a valid string
                command.Parameters.Add("@Location", OleDbType.VarChar).Value = txtLocation.Text; // Ensure Location is a valid string
                command.Parameters.Add("@StockDate", OleDbType.Date).Value = dtpStockDate.Value; // Ensure StockDate is valid DateTime
                command.Parameters.Add("@Available", OleDbType.Boolean).Value = chkAvailable.Checked; // Ensure Available is a boolean

                command.ExecuteNonQuery();
                MessageBox.Show("Item added successfully.");
                connection.Close();
                LoadData();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("UPDATE Inventory SET SerialNo=@SerialNo, Description=@Description, Model=@Model, Location=@Location, StockDate=@StockDate, Available=@Available WHERE ItemID=@ItemID", connection);

                command.Parameters.Add("@SerialNo", OleDbType.VarChar).Value = txtSerialNo.Text; // Cast as VarChar
                command.Parameters.Add("@Description", OleDbType.VarChar).Value = txtDescription.Text; // Cast as VarChar
                command.Parameters.Add("@Model", OleDbType.VarChar).Value = txtModel.Text; // Cast as VarChar
                command.Parameters.Add("@Location", OleDbType.VarChar).Value = txtLocation.Text; // Cast as VarChar
                command.Parameters.Add("@StockDate", OleDbType.Date).Value = dtpStockDate.Value; // Cast as Date
                command.Parameters.Add("@Available", OleDbType.Boolean).Value = chkAvailable.Checked; // Cast as Boolean
                command.Parameters.Add("@ItemID", OleDbType.Integer).Value = Convert.ToInt32(txtItemID.Text); // Cast as Integer

                command.ExecuteNonQuery();
                MessageBox.Show("Item updated successfully.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating item: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("DELETE FROM Inventory WHERE ItemID=@ItemID", connection);
                command.Parameters.Add("@ItemID", OleDbType.Integer).Value = Convert.ToInt32(txtItemID.Text); // Cast as Integer

                command.ExecuteNonQuery();
                MessageBox.Show("Item deleted successfully.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtItemID.Text = dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString();
                txtSerialNo.Text = dataGridView1.CurrentRow.Cells["SerialNo"].Value.ToString();
                txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                txtModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
                txtLocation.Text = dataGridView1.CurrentRow.Cells["Location"].Value.ToString();
                dtpStockDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["StockDate"].Value);
                chkAvailable.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Available"].Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
