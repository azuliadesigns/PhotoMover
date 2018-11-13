using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoMover
{
    public partial class frmMain : Form
    {
        const int propertyTagExifDTOrig_ = 0x9003; //36867;
        List<ItemToMove> items = new List<ItemToMove>();

        public frmMain()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            resultLabel.Text = string.Empty;
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            if (fbSourceFolder.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = fbSourceFolder.SelectedPath;
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            if (fbDestinationBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = fbDestinationBrowser.SelectedPath;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                if (string.IsNullOrEmpty(txtDestinationFolder.Text))
                {
                    txtDestinationFolder.Text = txtSourceFolder.Text;
                }

                resultLabel.Text = string.Empty;
                gvResults.DataSource = null;
                backgroundWorker1.RunWorkerAsync();
            }
            else if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string[] files = System.IO.Directory.GetFiles(txtSourceFolder.Text);
            List<string> errors = new List<string>();
            int counter = 0;
            int total = files.Count();
            items = new List<ItemToMove>();

            foreach (string file in files)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    DateTime? dateTaken = GetDateTaken(file);

                    if (dateTaken.HasValue)
                    {
                        string filename = Path.GetFileName(file);
                        ItemToMove item = new ItemToMove();
                        item.dataTaken = dateTaken.Value.ToString(txtDateFormat.Text);
                        item.sourceFilename = file;
                        item.destinationFilename = $"{txtDestinationFolder.Text}\\{item.dataTaken}\\{filename}";
                        item.format = Path.GetExtension(filename).ToUpper().TrimStart('.');
                        items.Add(item);
                    }
                }

                counter++;
                var percent = Decimal.Divide(counter,total) * 100;
                worker.ReportProgress(Convert.ToInt32(percent));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resultLabel.Text = "Complete";

            if (items.Count > 0)
            {
                gvResults.DataSource = items;
                gvResults.AutoResizeColumns();
                btnMoveFiles.Enabled = true;
            }
        }

        private DateTime? GetDateTaken(string filename)
        {
            string dateTakenText = string.Empty;
            string ext = Path.GetExtension(filename).ToLower();

            if ((ext == ".jpg") || (ext == ".jpeg"))
            {
                using (Image photo = Image.FromFile(filename))
                {
                    PropertyItem pi = photo.GetPropertyItem(propertyTagExifDTOrig_);
                    ASCIIEncoding enc = new ASCIIEncoding();
                    dateTakenText = enc.GetString(pi.Value, 0, pi.Len - 1);
                }

                if (!string.IsNullOrEmpty(dateTakenText))
                {
                    DateTime dateTaken;
                    if (DateTime.TryParseExact(dateTakenText, "yyyy:MM:dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTaken))
                    {
                        return dateTaken;
                    }
                }
            }
            else if (ext == ".cr2")
            {
                var directories = ImageMetadataReader.ReadMetadata(filename);
                var directory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();

                if (directory == null)
                    return null;

                if (directory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out var dateTime))
                    return dateTime;
            }

            return null;
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvResults.Rows)
            {
                string source = row.Cells[0].Value.ToString();
                string destination = row.Cells[1].Value.ToString();
                string date = row.Cells[2].Value.ToString();

                string folder = Path.GetDirectoryName(destination);

                if (!System.IO.Directory.Exists(folder))
                    System.IO.Directory.CreateDirectory(folder);

                if (rbMove.Checked)
                {
                    if (!File.Exists(destination))
                        File.Move(source, destination);
                }
                else if (rbCopy.Checked)
                {
                    if (!File.Exists(destination))
                        File.Copy(source, destination);
                }
            }
        }

        private void rbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopy.Checked)
                btnMoveFiles.Text = "Copy";
            else if (rbMove.Checked)
                btnMoveFiles.Text = "Move";
        }
    }

    public class ItemToMove
    {
        public string sourceFilename { get; set; }
        public string format { get; set; }
        public string dataTaken { get; set; }
        public string destinationFilename { get; set; }
    }
}
