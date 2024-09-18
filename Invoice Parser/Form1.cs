using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using Newtonsoft.Json;

namespace Invoice_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Browse button click event
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*",
                Title = "Select an Invoice PDF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ParseInvoice(filePath); // Parse the selected file
            }
        }

        // Invoice parsing logic using iText7
        private void ParseInvoice(string filePath)
        {
            try
            {
                string rawText = ExtractTextFromPDF(filePath); // Extract text using iText7

                var invoiceData = ExtractInvoiceDataFromText(rawText); // Manually parse text for invoice data

                string jsonResult = JsonConvert.SerializeObject(invoiceData, Formatting.Indented);

                // Save parsed data to a JSON file
                string outputFilePath = Path.Combine(Path.GetDirectoryName(filePath) ?? "", $"{Path.GetFileNameWithoutExtension(filePath)}_parsed.json");
                File.WriteAllText(outputFilePath, jsonResult);

                MessageBox.Show($"Invoice parsed successfully!\nJSON file saved at: {outputFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Extract text from PDF using iText7
        private string ExtractTextFromPDF(string filePath)
        {
            using (PdfReader reader = new PdfReader(filePath))
            using (PdfDocument pdfDoc = new PdfDocument(reader))
            {
                StringBuilder text = new StringBuilder();
                for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
                {
                    string pageText = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i));
                    text.Append(pageText);
                }
                return text.ToString();
            }
        }

        // Manually parse the raw text to extract invoice data
        private dynamic ExtractInvoiceDataFromText(string rawText)
        {
            var invoiceData = new
            {
                InvoiceNumber = ExtractValueFromText(rawText, "Invoice Number"),
                CompanyName = ExtractValueFromText(rawText, "Company Name"),
                CustomerName = ExtractValueFromText(rawText, "Bill To"),
                BillingAddress = ExtractAddress(rawText),
                Items = ExtractItemsFromText(rawText),
                BalanceDue = ExtractValueFromText(rawText, "Balance Due")
            };

            return invoiceData;
        }

        private string ExtractValueFromText(string text, string fieldName)
        {
            // Regex to find a pattern like "Invoice Number: INV-000001"
            string pattern = $@"{fieldName}[:\s]*([^\n\r]*)";
            var match = Regex.Match(text, pattern);
            return match.Success ? match.Groups[1].Value.Trim() : $"{fieldName} not found";
        }

        private List<dynamic> ExtractItemsFromText(string text)
        {
            var items = new List<dynamic>();

            // Logic to parse items (this will need to be tailored to the specific format of your invoice)
            // Example: "1 Brochure Design 1 900.00"
            string pattern = @"(\d+)\s+([^\d]+)\s+(\d+)\s+([^\n\r]+)";
            foreach (Match match in Regex.Matches(text, pattern))
            {
                items.Add(new
                {
                    ItemNumber = match.Groups[1].Value.Trim(),
                    ItemDescription = match.Groups[2].Value.Trim(),
                    Quantity = match.Groups[3].Value.Trim(),
                    Amount = match.Groups[4].Value.Trim()
                });
            }

            return items;
        }

        private string ExtractAddress(string text)
        {
            // You can define rules to extract an address based on patterns
            // Example: "Bill To: [Address]"
            string pattern = @"Bill To[:\s]*([^\n\r]+)";
            var match = Regex.Match(text, pattern);
            return match.Success ? match.Groups[1].Value.Trim() : "Billing Address not found";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
