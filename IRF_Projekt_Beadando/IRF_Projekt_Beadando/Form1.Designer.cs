namespace IRF_Projekt_Beadando
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
            this.delRowButton = new System.Windows.Forms.Button();
            this.openWriteFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.importDataButton = new System.Windows.Forms.Button();
            this.errrorMesseges = new System.Windows.Forms.Label();
            this.keruletListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.szobaSzamListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.liftComboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delRowButton
            // 
            this.delRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delRowButton.Location = new System.Drawing.Point(381, 527);
            this.delRowButton.Name = "delRowButton";
            this.delRowButton.Size = new System.Drawing.Size(191, 62);
            this.delRowButton.TabIndex = 1;
            this.delRowButton.Text = "Kijelült elemek törlése";
            this.delRowButton.UseVisualStyleBackColor = true;
            this.delRowButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openWriteFileButton
            // 
            this.openWriteFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openWriteFileButton.Location = new System.Drawing.Point(814, 125);
            this.openWriteFileButton.Name = "openWriteFileButton";
            this.openWriteFileButton.Size = new System.Drawing.Size(191, 66);
            this.openWriteFileButton.TabIndex = 3;
            this.openWriteFileButton.Text = "Adatok exportálása";
            this.openWriteFileButton.UseVisualStyleBackColor = true;
            this.openWriteFileButton.Click += new System.EventHandler(this.openWriteFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Helytelen adatok törlése";
            // 
            // importDataButton
            // 
            this.importDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.importDataButton.Location = new System.Drawing.Point(814, 19);
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(191, 66);
            this.importDataButton.TabIndex = 5;
            this.importDataButton.Text = "Más adatok importálása";
            this.importDataButton.UseVisualStyleBackColor = true;
            this.importDataButton.Click += new System.EventHandler(this.importDataButton_Click);
            // 
            // errrorMesseges
            // 
            this.errrorMesseges.AutoSize = true;
            this.errrorMesseges.ForeColor = System.Drawing.Color.DarkRed;
            this.errrorMesseges.Location = new System.Drawing.Point(546, 19);
            this.errrorMesseges.Name = "errrorMesseges";
            this.errrorMesseges.Size = new System.Drawing.Size(0, 13);
            this.errrorMesseges.TabIndex = 6;
            // 
            // keruletListBox1
            // 
            this.keruletListBox1.FormattingEnabled = true;
            this.keruletListBox1.Location = new System.Drawing.Point(20, 125);
            this.keruletListBox1.Name = "keruletListBox1";
            this.keruletListBox1.Size = new System.Drawing.Size(120, 94);
            this.keruletListBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Melyik kerületeket szeretné törölni a adatbázisból?";
            // 
            // szobaSzamListBox2
            // 
            this.szobaSzamListBox2.FormattingEnabled = true;
            this.szobaSzamListBox2.Location = new System.Drawing.Point(19, 435);
            this.szobaSzamListBox2.Name = "szobaSzamListBox2";
            this.szobaSzamListBox2.Size = new System.Drawing.Size(120, 94);
            this.szobaSzamListBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hány szobás lakásokat szeretné törölni a adatbázisból?";
            // 
            // liftComboBox1
            // 
            this.liftComboBox1.FormattingEnabled = true;
            this.liftComboBox1.Location = new System.Drawing.Point(20, 313);
            this.liftComboBox1.Name = "liftComboBox1";
            this.liftComboBox1.Size = new System.Drawing.Size(121, 21);
            this.liftComboBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Azok a lakások törlése adatbázisból ahol ....... lift.";
            // 
            // productTextBox1
            // 
            this.productTextBox1.Location = new System.Drawing.Point(915, 596);
            this.productTextBox1.Name = "productTextBox1";
            this.productTextBox1.ReadOnly = true;
            this.productTextBox1.Size = new System.Drawing.Size(100, 20);
            this.productTextBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 628);
            this.Controls.Add(this.productTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.liftComboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szobaSzamListBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keruletListBox1);
            this.Controls.Add(this.errrorMesseges);
            this.Controls.Add(this.importDataButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openWriteFileButton);
            this.Controls.Add(this.delRowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delRowButton;
        private System.Windows.Forms.Button openWriteFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importDataButton;
        private System.Windows.Forms.Label errrorMesseges;
        private System.Windows.Forms.CheckedListBox keruletListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox szobaSzamListBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox liftComboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productTextBox1;
    }
}

