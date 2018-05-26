namespace UniversityView
{
    partial class FormPaymentReport
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelData_from = new System.Windows.Forms.Label();
            this.labelData_to = new System.Windows.Forms.Label();
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonSaveToPDF = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(31, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(278, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // labelData_from
            // 
            this.labelData_from.AutoSize = true;
            this.labelData_from.Location = new System.Drawing.Point(12, 18);
            this.labelData_from.Name = "labelData_from";
            this.labelData_from.Size = new System.Drawing.Size(13, 13);
            this.labelData_from.TabIndex = 2;
            this.labelData_from.Text = "с";
            // 
            // labelData_to
            // 
            this.labelData_to.AutoSize = true;
            this.labelData_to.Location = new System.Drawing.Point(253, 18);
            this.labelData_to.Name = "labelData_to";
            this.labelData_to.Size = new System.Drawing.Size(19, 13);
            this.labelData_to.TabIndex = 3;
            this.labelData_to.Text = "по";
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(509, 12);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(95, 23);
            this.buttonMake.TabIndex = 4;
            this.buttonMake.Text = "Сформировать";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // buttonSaveToPDF
            // 
            this.buttonSaveToPDF.Location = new System.Drawing.Point(520, 375);
            this.buttonSaveToPDF.Name = "buttonSaveToPDF";
            this.buttonSaveToPDF.Size = new System.Drawing.Size(109, 23);
            this.buttonSaveToPDF.TabIndex = 5;
            this.buttonSaveToPDF.Text = "сохранить в pdf";
            this.buttonSaveToPDF.UseVisualStyleBackColor = true;
            this.buttonSaveToPDF.Click += new System.EventHandler(this.buttonSaveToPDF_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(354, 375);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(142, 23);
            this.ButtonSend.TabIndex = 6;
            this.ButtonSend.Text = "Отправить должникам";
            this.ButtonSend.UseVisualStyleBackColor = true;
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "UniversityView.ReportPayment.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(15, 54);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(589, 315);
            this.reportViewer.TabIndex = 7;
            // 
            // FormPaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 410);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.buttonSaveToPDF);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.labelData_to);
            this.Controls.Add(this.labelData_from);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "FormPaymentReport";
            this.Text = "FormPaymentReport";
            this.Load += new System.EventHandler(this.FormPaymentReport_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelData_from;
        private System.Windows.Forms.Label labelData_to;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Button buttonSaveToPDF;
        private System.Windows.Forms.Button ButtonSend;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}