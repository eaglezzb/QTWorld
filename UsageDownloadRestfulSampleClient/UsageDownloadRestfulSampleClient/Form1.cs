using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace UsageDownloadRestfulSampleClient
{
    public partial class Form1 : Form
    {
        private UsageDownloadHelper downloadHlHelper = new UsageDownloadHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateInputForUsageList();
            string json = downloadHlHelper.GetEnrollmentUsageList(enrollmentTx.Text, accessKeyTx.Text);
            usageListJsonTx.Text = json;
        }

       byte[] reportBytes;
       private void btnSendRequest_Click(object sender, EventArgs e)
        {
            ValidateInputForUsageMonth();
            UsageReportType type = (UsageReportType)reportTypeCB.SelectedIndex;
            string json = downloadHlHelper.GetEnrollmentUsageByMonth(monthCalendar.SelectionEnd, type, enrollmentMonthTx.Text, accessKeyMonthTx.Text, formatCB.Text);
            reportBytes = Encoding.Default.GetBytes(json);
            jsonMonthTx.Text = json;
        }

       private void btnStreamDownload_Click(object sender, EventArgs e)
       {
           ValidateInputForUsageMonth();
           UsageReportType type = (UsageReportType)reportTypeCB.SelectedIndex;
           string json = downloadHlHelper.GetEnrollmentUsageByMonthStream(monthCalendar.SelectionEnd, type, enrollmentMonthTx.Text, accessKeyMonthTx.Text, formatCB.Text);
           reportBytes = Encoding.Default.GetBytes(json);
           jsonMonthTx.Text = json;
       }

       private void btnSaveReport_Click(object sender, EventArgs e)
        {
            
            string json = jsonMonthTx.Text;
            
            //UsageReportApiResponse response = JsonConvert.DeserializeObject<UsageReportApiResponse>(json);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = string.Format("Report files (*.{0})|*.{0}", "csv");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dialog.FileName, reportBytes);
            }
        }

       private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           GetTestKey();
       }

       private void GetTestKey()
       {
           Process.Start(ConfigurationManager.AppSettings["TestKey"]);
       }

        #region Private Methods

        private void ValidateInputForUsageList()
        {
            
        }

        private void ValidateInputForUsageMonth()
        {

        }

        #endregion

        private async void btnRegularDownload_Click(object sender, EventArgs e)
        {
            rtbResponseText.Clear();

            rtbResponseText.Clear();
            Application.EnableVisualStyles();
            label17.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            btnPaginatedStreamDownload.Enabled = false;
            btnRegularDownload.Enabled = false;

            var month = calMonth.SelectionEnd;
            var enrNumber = txtEnrNumber.Text;
            var txtAcessKey = txtAccessKey.Text;
            var fmt = cmbFormat.Text;
            var pageindex = int.Parse(txtPageIndex.Text);
            string json = string.Empty;

            try
            {

                json = await downloadHlHelper.GetEnrollmentPaginatedUsageByMonth(month, enrNumber, txtAcessKey, fmt, pageindex);
                rtbResponseText.Text = json;
            }
            catch(Exception ex)
            {
                rtbResponseText.Text = ex.Message;
            }

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Visible = false;
            label17.Visible = false;
            btnPaginatedStreamDownload.Enabled = true;
            btnRegularDownload.Enabled = true;
           
        }

        private async void btnPaginatedStreamDownload_Click(object sender, EventArgs e)
        {
            rtbResponseText.Clear();
            Application.EnableVisualStyles();
            label17.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            btnPaginatedStreamDownload.Enabled = false;
            btnRegularDownload.Enabled = false;

            var month = calMonth.SelectionEnd;
            var enrNumber = txtEnrNumber.Text;
            var txtAcessKey = txtAccessKey.Text;
            var fmt = cmbFormat.Text;
            var pageindex = int.Parse(txtPageIndex.Text);
            string json= string.Empty;
            await Task.Run(() =>
            {
                 json = downloadHlHelper.GetEnrollmentPaginatedUsageByMonthStream(month, enrNumber, txtAcessKey, fmt, pageindex);
               
            });
            rtbResponseText.Text = json;
           
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Visible = false;
            label17.Visible = false;
            btnPaginatedStreamDownload.Enabled = true;
            btnRegularDownload.Enabled = true;
            
        }
       

      

        

    }
}
