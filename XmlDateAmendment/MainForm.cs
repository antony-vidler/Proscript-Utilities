using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace XmlDateAmendment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSourceFolder.Text))
            {
                txtDestinationFolder.Text = Path.Combine(txtSourceFolder.Text, "output");
            }
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Source Folder";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSourceFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnDestinationBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Destination Folder";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestinationFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceFolder.Text))
            {
                MessageBox.Show("Please select a Source Folder.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDestinationFolder.Text))
            {
                MessageBox.Show("Please select a Destination Folder.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(txtSourceFolder.Text))
            {
                MessageBox.Show("Source folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmendmentDate.Text))
            {
                MessageBox.Show("Please enter an Amendment Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(txtAmendmentDate.Text, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime amendmentDate))
            {
                MessageBox.Show("Invalid date format. Please use dd/MM/yyyy (e.g., 24/02/2026)", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtDestinationFolder.Text))
            {
                Directory.CreateDirectory(txtDestinationFolder.Text);
            }

            try
            {
                ProcessXmlFiles(txtSourceFolder.Text, txtDestinationFolder.Text, amendmentDate, chkAutoGenerateTransactionId.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during processing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessXmlFiles(string sourceFolder, string destinationFolder, DateTime amendmentDate, bool autoGenerateTransactionId)
        {
            string formattedDate = amendmentDate.ToString("yyyy-MM-dd");
            DateTime now = DateTime.Now;
            string dateTimeValue = amendmentDate.ToString("yyyy-MM-dd") + "T" + now.ToString("HH:mm:ss");

            DirectoryInfo sourceDir = new DirectoryInfo(sourceFolder);
            FileInfo[] xmlFiles = sourceDir.GetFiles("*.xml");

            if (xmlFiles.Length == 0)
            {
                MessageBox.Show("No XML files found in the source folder.", "No Files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int successCount = 0;
            int failureCount = 0;

            foreach (FileInfo file in xmlFiles)
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(file.FullName);

                    XmlNamespaceManager nsManager = new XmlNamespaceManager(xmlDoc.NameTable);
                    nsManager.AddNamespace("ns", "http://www.eps.nds.scot.nhs.uk");

                    if (autoGenerateTransactionId)
                    {
                        XmlNode appTransIdNode = xmlDoc.SelectSingleNode("//ns:AppTransID", nsManager);
                        if (appTransIdNode != null)
                        {
                            appTransIdNode.InnerText = Guid.NewGuid().ToString().ToUpper();
                        }
                    }

                    XmlNode appTransDateTimeNode = xmlDoc.SelectSingleNode("//ns:AppTransDateTime", nsManager);
                    if (appTransDateTimeNode != null)
                    {
                        appTransDateTimeNode.InnerText = dateTimeValue;
                    }

                    XmlNode prescriptionDateTimeNode = xmlDoc.SelectSingleNode("//ns:PrescriptionDateTime", nsManager);
                    if (prescriptionDateTimeNode != null)
                    {
                        prescriptionDateTimeNode.InnerText = dateTimeValue;
                    }

                    XmlNodeList medicationStartDateNodes = xmlDoc.SelectNodes("//ns:MedicationStartDate", nsManager);
                    foreach (XmlNode node in medicationStartDateNodes)
                    {
                        node.InnerText = formattedDate;
                    }

                    string destinationPath = Path.Combine(destinationFolder, file.Name);
                    XmlWriterSettings settings = new XmlWriterSettings
                    {
                        Indent = true,
                        IndentChars = "\t",
                        Encoding = System.Text.Encoding.UTF8
                    };

                    using (XmlWriter writer = XmlWriter.Create(destinationPath, settings))
                    {
                        xmlDoc.WriteTo(writer);
                    }

                    successCount++;
                }
                catch (Exception ex)
                {
                    failureCount++;
                    System.Diagnostics.Debug.WriteLine($"Error processing {file.Name}: {ex.Message}");
                }
            }

            MessageBox.Show($"Processing completed.\n\nSuccessfully processed: {successCount} file(s)\nFailed: {failureCount} file(s)", "Processing Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
