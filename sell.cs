using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iText.Layout.Element;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Paragraph = iTextSharp.text.Paragraph;

namespace WinFormsApp2
{
    public partial class sell : UserControl
    {
        string connectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=AP_Project;Data Source=DESKTOP-4SF52E2"; // Update as per your DB connection
        SqlConnection con = new SqlConnection("Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=AP_Project;Data Source=DESKTOP-4SF52E2");

        public sell()
        {
            InitializeComponent();
            LoadAllData();
        }
      
        double sale = 0;
        private void sell_Load(object sender, EventArgs e) { }

        private void btnSell_Click(object sender, EventArgs e) { }

        private void LoadAllData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM product where qty!=0";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                // Populate DataGridView
                dataGridView1.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int id = 0;
        // ...
        private int getinvoicenumber()
        {
            int invoice = 0;
            try
            {
                con.Open();
                string query = "SELECT MAX(id) as id FROM orders";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        invoice = Convert.ToInt32(dr["id"]);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Error loading data: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            id = invoice + 1;
            return invoice + 1;
        }
        string filePath;
        private void GenerateInvoice(string customerName, List<(string Name, int Quantity, decimal Price)> products)
        {
            filePath = $@"D:\invoice\{getinvoicenumber()}.pdf";

            try
            {
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                // Ensure file is not locked and avoid opening twice
                if (File.Exists(filePath))
                {
                    File.Delete(filePath); // Delete the file before regenerating it to avoid lock
                }

                // Create the file stream with FileShare.ReadWrite to prevent locking
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                using (Document document = new Document())
                using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                {
                    // Open the document for writing
                    document.Open();

                    // Load font for bold text
                    iTextSharp.text.Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                    // Add Invoice Title
                    Paragraph title = new Paragraph("Invoice", boldFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.Font.Size = 20;
                    document.Add(title);

                    // Add Customer Name and Date
                    Paragraph customerParagraph = new Paragraph($"Customer: {customerName}");
                    customerParagraph.Font.Size = 12;
                    document.Add(customerParagraph);

                    Paragraph dateParagraph = new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy}");
                    dateParagraph.Font.Size = 12;
                    document.Add(dateParagraph);
                    document.Add(p);
                    // Add Table for Products
                    PdfPTable table = new PdfPTable(4); // 4 columns
                    table.WidthPercentage = 100; // Set width to 100%

                    // Add Table Headers with bold font
                    table.AddCell(new PdfPCell(new Phrase("Product Name", boldFont)));
                    table.AddCell(new PdfPCell(new Phrase("Quantity", boldFont)));
                    table.AddCell(new PdfPCell(new Phrase("Price", boldFont)));
                    table.AddCell(new PdfPCell(new Phrase("Total", boldFont)));

                    decimal grandTotal = 0;

                    foreach (var product in products)
                    {
                        decimal total = product.Quantity * product.Price;
                        grandTotal += total;

                        table.AddCell(new PdfPCell(new Phrase(product.Name)));
                        table.AddCell(new PdfPCell(new Phrase(product.Quantity.ToString())));
                        table.AddCell(new PdfPCell(new Phrase($"PKR{product.Price}")));
                        table.AddCell(new PdfPCell(new Phrase($"${total}")));
                    }
                    sale = Convert.ToDouble(grandTotal);
                    // Add Table to Document
                    document.Add(table);

                    // Add Horizontal Line

                    document.Add(p);




                    // Add Grand Total in Total Column
                    PdfPTable grandTotalTable = new PdfPTable(2); // 2 columns
                    grandTotalTable.WidthPercentage = 100;
                    PdfPCell grandTotalCell = new PdfPCell(new Phrase("Grand Total", boldFont));
                    grandTotalCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    grandTotalTable.AddCell(grandTotalCell);

                    PdfPCell grandTotalValueCell = new PdfPCell(new Phrase($"${grandTotal:F2}", boldFont));
                    grandTotalValueCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    grandTotalTable.AddCell(grandTotalValueCell);

                    document.Add(grandTotalTable);

                    // Add Thank You Note
                    Paragraph thankYouParagraph = new Paragraph("\nThank you for your purchase!");
                    thankYouParagraph.Font.Size = 12;
                    thankYouParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(thankYouParagraph);

                    // Close the document
                    document.Close();
                }

                MessageBox.Show($"Invoice saved as {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open PDF after creation
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening invoice: {ex.Message} , {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error generating invoice: {ex.Message}, {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update database after sale
        private void UpdateDatabaseAfterSale(List<(string Name, int Quantity, decimal Price)> products)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    foreach (var product in products)
                    {
                        // Update product stock after sale
                        string updateStockQuery = "UPDATE product SET qty = qty - @Quantity WHERE name = @Name";
                        using (SqlCommand cmd = new SqlCommand(updateStockQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                            cmd.Parameters.AddWithValue("@Name", product.Name);

                            cmd.ExecuteNonQuery();
                        }

                        // Insert sale record
                        string insertSaleQuery = "INSERT INTO sales (name, quantity, price, date) VALUES (@Name, @Quantity, @Price, @SaleDate)";
                        using (SqlCommand cmd = new SqlCommand(insertSaleQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@Name", product.Name);
                            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                            cmd.Parameters.AddWithValue("@Price", product.Price);
                            cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Sale recorded successfully and stock updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Error updating database: {ex.Message}", $"Error:{ex.StackTrace}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addcustomerdata()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO invoice ( customer_name, invoice_path,date,sale) VALUES ( @customer_name, @path,@date,@sale)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customer_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@path", filePath);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@sale", sale);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show($"Error loading data: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSell_Click_1(object sender, EventArgs e)
        {
            string customerName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter the customer's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProducts = new List<(string Name, int Quantity, decimal Price)>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) == true) // Assuming 'Select' is the checkbox column
                {
                    string productName = row.Cells[1].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[2].Value);
                    decimal price = Convert.ToDecimal(row.Cells[3].Value);

                    selectedProducts.Add((productName, quantity, price));
                }
            }

            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Please select at least one product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerateInvoice(customerName, selectedProducts);
            UpdateDatabaseAfterSale(selectedProducts); // Update database after sale
            addcustomerdata();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    LoadAllData();
                    return;
                }

                
                string query = "SELECT * FROM product where qty!=0 and name like '%" + textBox2.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dataGridView1.Rows.Clear();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

                    }

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
