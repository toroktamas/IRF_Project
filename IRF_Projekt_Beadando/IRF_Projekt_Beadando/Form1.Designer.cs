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
            this.reloadButton = new System.Windows.Forms.Button();
            this.openWriteFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.importDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delRowButton
            // 
            this.delRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delRowButton.Location = new System.Drawing.Point(557, 67);
            this.delRowButton.Name = "delRowButton";
            this.delRowButton.Size = new System.Drawing.Size(191, 62);
            this.delRowButton.TabIndex = 1;
            this.delRowButton.Text = "Kijelült sorok törlése";
            this.delRowButton.UseVisualStyleBackColor = true;
            this.delRowButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reloadButton.Location = new System.Drawing.Point(557, 150);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(191, 66);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "Újra töltés";
            this.reloadButton.UseVisualStyleBackColor = true;
            // 
            // openWriteFileButton
            // 
            this.openWriteFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openWriteFileButton.Location = new System.Drawing.Point(557, 372);
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
            this.importDataButton.Location = new System.Drawing.Point(557, 282);
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(191, 66);
            this.importDataButton.TabIndex = 5;
            this.importDataButton.Text = "Más adatok importálása";
            this.importDataButton.UseVisualStyleBackColor = true;
            this.importDataButton.Click += new System.EventHandler(this.importDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importDataButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openWriteFileButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.delRowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delRowButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button openWriteFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importDataButton;
    }
}

