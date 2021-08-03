namespace UsageDownloadRestfulSampleClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usageListJsonTx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.accessKeyTx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollmentTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.formatCB = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.reportTypeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jsonMonthTx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.accessKeyMonthTx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enrollmentMonthTx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPageIndex = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rtbResponseText = new System.Windows.Forms.RichTextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.calMonth = new System.Windows.Forms.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPaginatedStreamDownload = new System.Windows.Forms.Button();
            this.btnRegularDownload = new System.Windows.Forms.Button();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEnrNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.usageListJsonTx);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.accessKeyTx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.enrollmentTx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UsageList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(338, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get enrollment 100 test Access Key";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enter \'100\' for test enrollment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Json Response";
            // 
            // usageListJsonTx
            // 
            this.usageListJsonTx.Location = new System.Drawing.Point(21, 72);
            this.usageListJsonTx.Multiline = true;
            this.usageListJsonTx.Name = "usageListJsonTx";
            this.usageListJsonTx.ReadOnly = true;
            this.usageListJsonTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usageListJsonTx.Size = new System.Drawing.Size(1039, 522);
            this.usageListJsonTx.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(972, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accessKeyTx
            // 
            this.accessKeyTx.Location = new System.Drawing.Point(341, 9);
            this.accessKeyTx.Name = "accessKeyTx";
            this.accessKeyTx.Size = new System.Drawing.Size(609, 20);
            this.accessKeyTx.TabIndex = 3;
            this.accessKeyTx.Text = resources.GetString("accessKeyTx.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access Key:";
            // 
            // enrollmentTx
            // 
            this.enrollmentTx.Location = new System.Drawing.Point(123, 9);
            this.enrollmentTx.Name = "enrollmentTx";
            this.enrollmentTx.Size = new System.Drawing.Size(100, 20);
            this.enrollmentTx.TabIndex = 1;
            this.enrollmentTx.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment Number:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.formatCB);
            this.tabPage2.Controls.Add(this.lblFormat);
            this.tabPage2.Controls.Add(this.btnSaveReport);
            this.tabPage2.Controls.Add(this.reportTypeCB);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.monthCalendar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.jsonMonthTx);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnSendRequest);
            this.tabPage2.Controls.Add(this.accessKeyMonthTx);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.enrollmentMonthTx);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1078, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UsageByMonth";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // formatCB
            // 
            this.formatCB.FormattingEnabled = true;
            this.formatCB.Items.AddRange(new object[] {
            "CSV",
            "JSON"});
            this.formatCB.Location = new System.Drawing.Point(96, 247);
            this.formatCB.Name = "formatCB";
            this.formatCB.Size = new System.Drawing.Size(121, 21);
            this.formatCB.TabIndex = 21;
            this.formatCB.Text = "CSV";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(21, 250);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(42, 13);
            this.lblFormat.TabIndex = 20;
            this.lblFormat.Text = "Format:";
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(972, 41);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(81, 23);
            this.btnSaveReport.TabIndex = 19;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Visible = false;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // reportTypeCB
            // 
            this.reportTypeCB.FormattingEnabled = true;
            this.reportTypeCB.Items.AddRange(new object[] {
            "Summary",
            "Detail",
            "StoreCharge",
            "PriceSheet"});
            this.reportTypeCB.Location = new System.Drawing.Point(96, 220);
            this.reportTypeCB.Name = "reportTypeCB";
            this.reportTypeCB.Size = new System.Drawing.Size(121, 21);
            this.reportTypeCB.TabIndex = 18;
            this.reportTypeCB.Text = "Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Report Type:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(70, 41);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Json Response";
            // 
            // jsonMonthTx
            // 
            this.jsonMonthTx.Location = new System.Drawing.Point(312, 76);
            this.jsonMonthTx.Multiline = true;
            this.jsonMonthTx.Name = "jsonMonthTx";
            this.jsonMonthTx.ReadOnly = true;
            this.jsonMonthTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.jsonMonthTx.Size = new System.Drawing.Size(748, 518);
            this.jsonMonthTx.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Stream Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStreamDownload_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(812, 9);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(117, 23);
            this.btnSendRequest.TabIndex = 12;
            this.btnSendRequest.Text = "Regular Download";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // accessKeyMonthTx
            // 
            this.accessKeyMonthTx.Location = new System.Drawing.Point(375, 9);
            this.accessKeyMonthTx.Name = "accessKeyMonthTx";
            this.accessKeyMonthTx.Size = new System.Drawing.Size(431, 20);
            this.accessKeyMonthTx.TabIndex = 11;
            this.accessKeyMonthTx.Text = this.accessKeyTx.Text;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Access Key:";
            // 
            // enrollmentMonthTx
            // 
            this.enrollmentMonthTx.Location = new System.Drawing.Point(123, 9);
            this.enrollmentMonthTx.Name = "enrollmentMonthTx";
            this.enrollmentMonthTx.Size = new System.Drawing.Size(100, 20);
            this.enrollmentMonthTx.TabIndex = 9;
            this.enrollmentMonthTx.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enrollment Number:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtPageIndex);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.rtbResponseText);
            this.tabPage3.Controls.Add(this.cmbFormat);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.cmbReportType);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.calMonth);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnPaginatedStreamDownload);
            this.tabPage3.Controls.Add(this.btnRegularDownload);
            this.tabPage3.Controls.Add(this.txtAccessKey);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtEnrNumber);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1078, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PaginatedUsageByMonth";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(809, 50);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 40;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(706, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Downloading File : ";
            this.label17.Visible = false;
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.Location = new System.Drawing.Point(93, 282);
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Size = new System.Drawing.Size(100, 20);
            this.txtPageIndex.TabIndex = 38;
            this.txtPageIndex.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "PageIndex:";
            // 
            // rtbResponseText
            // 
            this.rtbResponseText.Location = new System.Drawing.Point(309, 78);
            this.rtbResponseText.Name = "rtbResponseText";
            this.rtbResponseText.ReadOnly = true;
            this.rtbResponseText.Size = new System.Drawing.Size(741, 519);
            this.rtbResponseText.TabIndex = 36;
            this.rtbResponseText.Text = "";
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "CSV",
            "JSON"});
            this.cmbFormat.Location = new System.Drawing.Point(93, 253);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(121, 21);
            this.cmbFormat.TabIndex = 35;
            this.cmbFormat.Text = "CSV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Format:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Save Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Detail"});
            this.cmbReportType.Location = new System.Drawing.Point(93, 226);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(121, 21);
            this.cmbReportType.TabIndex = 32;
            this.cmbReportType.Text = "Detail";
            this.cmbReportType.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Report Type:";
            this.label11.Visible = false;
            // 
            // calMonth
            // 
            this.calMonth.Location = new System.Drawing.Point(67, 47);
            this.calMonth.Name = "calMonth";
            this.calMonth.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Month:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Json Response";
            // 
            // btnPaginatedStreamDownload
            // 
            this.btnPaginatedStreamDownload.Location = new System.Drawing.Point(932, 15);
            this.btnPaginatedStreamDownload.Name = "btnPaginatedStreamDownload";
            this.btnPaginatedStreamDownload.Size = new System.Drawing.Size(118, 23);
            this.btnPaginatedStreamDownload.TabIndex = 26;
            this.btnPaginatedStreamDownload.Text = "Stream Download";
            this.btnPaginatedStreamDownload.UseVisualStyleBackColor = true;
            this.btnPaginatedStreamDownload.Click += new System.EventHandler(this.btnPaginatedStreamDownload_Click);
            // 
            // btnRegularDownload
            // 
            this.btnRegularDownload.Location = new System.Drawing.Point(809, 15);
            this.btnRegularDownload.Name = "btnRegularDownload";
            this.btnRegularDownload.Size = new System.Drawing.Size(117, 23);
            this.btnRegularDownload.TabIndex = 27;
            this.btnRegularDownload.Text = "Regular Download";
            this.btnRegularDownload.UseVisualStyleBackColor = true;
            this.btnRegularDownload.Click += new System.EventHandler(this.btnRegularDownload_Click);
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(372, 15);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(431, 20);
            this.txtAccessKey.TabIndex = 25;
            this.txtAccessKey.Text = this.accessKeyTx.Text;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Access Key:";
            // 
            // txtEnrNumber
            // 
            this.txtEnrNumber.Location = new System.Drawing.Point(120, 15);
            this.txtEnrNumber.Name = "txtEnrNumber";
            this.txtEnrNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnrNumber.TabIndex = 23;
            this.txtEnrNumber.Text = "100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Enrollment Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usageListJsonTx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox accessKeyTx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enrollmentTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jsonMonthTx;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox accessKeyMonthTx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enrollmentMonthTx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox reportTypeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.ComboBox formatCB;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbResponseText;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MonthCalendar calMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPaginatedStreamDownload;
        private System.Windows.Forms.Button btnRegularDownload;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEnrNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPageIndex;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label17;
    }
}

