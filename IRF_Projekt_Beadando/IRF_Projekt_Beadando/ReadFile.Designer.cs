namespace IRF_Projekt_Beadando
{
    partial class ReadFile
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
            this.readFileWhidPath = new System.Windows.Forms.Button();
            this.openFilePath = new System.Windows.Forms.TextBox();
            this.readWhidOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialogPathText = new System.Windows.Forms.TextBox();
            this.openForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readFileWhidPath
            // 
            this.readFileWhidPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readFileWhidPath.Location = new System.Drawing.Point(340, 93);
            this.readFileWhidPath.Name = "readFileWhidPath";
            this.readFileWhidPath.Size = new System.Drawing.Size(95, 47);
            this.readFileWhidPath.TabIndex = 0;
            this.readFileWhidPath.Text = "Beolvaás";
            this.readFileWhidPath.UseVisualStyleBackColor = true;
            // 
            // openFilePath
            // 
            this.openFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openFilePath.Location = new System.Drawing.Point(24, 101);
            this.openFilePath.Name = "openFilePath";
            this.openFilePath.Size = new System.Drawing.Size(280, 29);
            this.openFilePath.TabIndex = 1;
            // 
            // readWhidOpenFileDialog
            // 
            this.readWhidOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readWhidOpenFileDialog.Location = new System.Drawing.Point(24, 187);
            this.readWhidOpenFileDialog.Name = "readWhidOpenFileDialog";
            this.readWhidOpenFileDialog.Size = new System.Drawing.Size(96, 47);
            this.readWhidOpenFileDialog.TabIndex = 2;
            this.readWhidOpenFileDialog.Text = "Beolvaás";
            this.readWhidOpenFileDialog.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fájl beolvasás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fájl elérési út megadása";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fájl tallózása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(136, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Elérési út: ";
            // 
            // openFileDialogPathText
            // 
            this.openFileDialogPathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openFileDialogPathText.Location = new System.Drawing.Point(240, 195);
            this.openFileDialogPathText.Name = "openFileDialogPathText";
            this.openFileDialogPathText.ReadOnly = true;
            this.openFileDialogPathText.Size = new System.Drawing.Size(195, 29);
            this.openFileDialogPathText.TabIndex = 7;
            // 
            // openForm1
            // 
            this.openForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openForm1.Location = new System.Drawing.Point(468, 240);
            this.openForm1.Name = "openForm1";
            this.openForm1.Size = new System.Drawing.Size(94, 45);
            this.openForm1.TabIndex = 8;
            this.openForm1.Text = "Tovább";
            this.openForm1.UseVisualStyleBackColor = true;
            this.openForm1.Click += new System.EventHandler(this.openForm1_Click);
            // 
            // ReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 298);
            this.Controls.Add(this.openForm1);
            this.Controls.Add(this.openFileDialogPathText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readWhidOpenFileDialog);
            this.Controls.Add(this.openFilePath);
            this.Controls.Add(this.readFileWhidPath);
            this.Name = "ReadFile";
            this.Text = "ReadFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFileWhidPath;
        private System.Windows.Forms.TextBox openFilePath;
        private System.Windows.Forms.Button readWhidOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox openFileDialogPathText;
        private System.Windows.Forms.Button openForm1;
    }
}