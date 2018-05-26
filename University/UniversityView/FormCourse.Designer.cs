namespace UniversityView
{
    partial class FormCourse
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNameCourse = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPriceCourse = new System.Windows.Forms.TextBox();
            this.labelPriceCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(231, 98);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(347, 98);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNameCourse
            // 
            this.textBoxNameCourse.Location = new System.Drawing.Point(130, 12);
            this.textBoxNameCourse.Name = "textBoxNameCourse";
            this.textBoxNameCourse.Size = new System.Drawing.Size(304, 20);
            this.textBoxNameCourse.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Название курса";
            // 
            // textBoxPriceCourse
            // 
            this.textBoxPriceCourse.Location = new System.Drawing.Point(130, 55);
            this.textBoxPriceCourse.Name = "textBoxPriceCourse";
            this.textBoxPriceCourse.Size = new System.Drawing.Size(304, 20);
            this.textBoxPriceCourse.TabIndex = 4;
            // 
            // labelPriceCourse
            // 
            this.labelPriceCourse.AutoSize = true;
            this.labelPriceCourse.Location = new System.Drawing.Point(12, 62);
            this.labelPriceCourse.Name = "labelPriceCourse";
            this.labelPriceCourse.Size = new System.Drawing.Size(33, 13);
            this.labelPriceCourse.TabIndex = 5;
            this.labelPriceCourse.Text = "Цена";
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 133);
            this.Controls.Add(this.labelPriceCourse);
            this.Controls.Add(this.textBoxPriceCourse);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNameCourse);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormCourse";
            this.Text = "FormCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxNameCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPriceCourse;
        private System.Windows.Forms.Label labelPriceCourse;
    }
}