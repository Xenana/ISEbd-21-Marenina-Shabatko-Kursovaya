namespace UniversityView
{
    partial class FormClient
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonBonus = new System.Windows.Forms.Button();
            this.ButtonFine = new System.Windows.Forms.Button();
            this.ButtonBlock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(532, 298);
            this.dataGridViewClient.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "отправить счет doc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "отправить счет xml";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ButtonBonus
            // 
            this.ButtonBonus.Location = new System.Drawing.Point(19, 19);
            this.ButtonBonus.Name = "ButtonBonus";
            this.ButtonBonus.Size = new System.Drawing.Size(91, 23);
            this.ButtonBonus.TabIndex = 3;
            this.ButtonBonus.Text = "бонусы";
            this.ButtonBonus.UseVisualStyleBackColor = true;
            this.ButtonBonus.Click += new System.EventHandler(this.ButtonBonus_Click);
            // 
            // ButtonFine
            // 
            this.ButtonFine.Location = new System.Drawing.Point(19, 57);
            this.ButtonFine.Name = "ButtonFine";
            this.ButtonFine.Size = new System.Drawing.Size(91, 23);
            this.ButtonFine.TabIndex = 4;
            this.ButtonFine.Text = "штрафы";
            this.ButtonFine.UseVisualStyleBackColor = true;
            this.ButtonFine.Click += new System.EventHandler(this.ButtonFine_Click);
            // 
            // ButtonBlock
            // 
            this.ButtonBlock.Location = new System.Drawing.Point(586, 287);
            this.ButtonBlock.Name = "ButtonBlock";
            this.ButtonBlock.Size = new System.Drawing.Size(91, 23);
            this.ButtonBlock.TabIndex = 5;
            this.ButtonBlock.Text = "блокировать";
            this.ButtonBlock.UseVisualStyleBackColor = true;
            this.ButtonBlock.Click += new System.EventHandler(this.ButtonBlock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonFine);
            this.groupBox1.Controls.Add(this.ButtonBonus);
            this.groupBox1.Location = new System.Drawing.Point(564, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начислить:";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonBlock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewClient);
            this.Name = "FormClient";
            this.Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonBonus;
        private System.Windows.Forms.Button ButtonFine;
        private System.Windows.Forms.Button ButtonBlock;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}