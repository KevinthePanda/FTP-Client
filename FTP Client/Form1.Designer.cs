namespace FTP_Client
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewFilename = new System.Windows.Forms.TextBox();
            this.txtCurrentFilename = new System.Windows.Forms.TextBox();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.grpBoxUpload = new System.Windows.Forms.GroupBox();
            this.btnFileSize = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNewDir = new System.Windows.Forms.TextBox();
            this.btnewDir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLstFiles = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.grpBoxUpload.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(465, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(236, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(5, 28);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(163, 20);
            this.txtHost.TabIndex = 1;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(2, 16);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(60, 13);
            this.lblHost.TabIndex = 4;
            this.lblHost.Text = "Host Name";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.txtPassword);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtUsername);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtHost);
            this.groupBox7.Controls.Add(this.btnApply);
            this.groupBox7.Controls.Add(this.lblHost);
            this.groupBox7.Location = new System.Drawing.Point(2, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(634, 88);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FTP Configurations";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(5, 54);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(629, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(6, 45);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(128, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "New File Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Old File Name";
            // 
            // txtNewFilename
            // 
            this.txtNewFilename.Location = new System.Drawing.Point(94, 45);
            this.txtNewFilename.Name = "txtNewFilename";
            this.txtNewFilename.Size = new System.Drawing.Size(530, 20);
            this.txtNewFilename.TabIndex = 2;
            // 
            // txtCurrentFilename
            // 
            this.txtCurrentFilename.Location = new System.Drawing.Point(94, 19);
            this.txtCurrentFilename.Name = "txtCurrentFilename";
            this.txtCurrentFilename.Size = new System.Drawing.Size(530, 20);
            this.txtCurrentFilename.TabIndex = 1;
            // 
            // txtUpload
            // 
            this.txtUpload.Location = new System.Drawing.Point(6, 19);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(619, 20);
            this.txtUpload.TabIndex = 1;
            // 
            // grpBoxUpload
            // 
            this.grpBoxUpload.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxUpload.Controls.Add(this.txtUpload);
            this.grpBoxUpload.Controls.Add(this.btnFileSize);
            this.grpBoxUpload.Controls.Add(this.btnUpload);
            this.grpBoxUpload.Controls.Add(this.btndelete);
            this.grpBoxUpload.Controls.Add(this.btnDownload);
            this.grpBoxUpload.Location = new System.Drawing.Point(1, 98);
            this.grpBoxUpload.Name = "grpBoxUpload";
            this.grpBoxUpload.Size = new System.Drawing.Size(635, 79);
            this.grpBoxUpload.TabIndex = 15;
            this.grpBoxUpload.TabStop = false;
            this.grpBoxUpload.Text = "Common FTP Operations";
            // 
            // btnFileSize
            // 
            this.btnFileSize.Enabled = false;
            this.btnFileSize.Location = new System.Drawing.Point(497, 45);
            this.btnFileSize.Name = "btnFileSize";
            this.btnFileSize.Size = new System.Drawing.Size(128, 23);
            this.btnFileSize.TabIndex = 0;
            this.btnFileSize.Text = "Size";
            this.btnFileSize.UseVisualStyleBackColor = true;
            this.btnFileSize.Click += new System.EventHandler(this.btnFileSize_Click);
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(337, 45);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 23);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(171, 45);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(128, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(5, 71);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(619, 23);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.txtNewDir);
            this.groupBox6.Controls.Add(this.btnewDir);
            this.groupBox6.Location = new System.Drawing.Point(1, 293);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(635, 79);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "New Directory";
            // 
            // txtNewDir
            // 
            this.txtNewDir.Location = new System.Drawing.Point(6, 19);
            this.txtNewDir.Name = "txtNewDir";
            this.txtNewDir.Size = new System.Drawing.Size(629, 20);
            this.txtNewDir.TabIndex = 1;
            // 
            // btnewDir
            // 
            this.btnewDir.Enabled = false;
            this.btnewDir.Location = new System.Drawing.Point(6, 45);
            this.btnewDir.Name = "btnewDir";
            this.btnewDir.Size = new System.Drawing.Size(629, 23);
            this.btnewDir.TabIndex = 0;
            this.btnewDir.Text = "Make Directory";
            this.btnewDir.UseVisualStyleBackColor = true;
            this.btnewDir.Click += new System.EventHandler(this.btnewDir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtNewFilename);
            this.groupBox5.Controls.Add(this.txtCurrentFilename);
            this.groupBox5.Controls.Add(this.btnRename);
            this.groupBox5.Location = new System.Drawing.Point(2, 183);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(634, 104);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File Rename";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(5, 51);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(627, 108);
            this.lstFiles.TabIndex = 1;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 626;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 108);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lstFiles);
            this.groupBox2.Controls.Add(this.btnLstFiles);
            this.groupBox2.Location = new System.Drawing.Point(2, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 167);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Listing: ";
            // 
            // btnLstFiles
            // 
            this.btnLstFiles.Enabled = false;
            this.btnLstFiles.Location = new System.Drawing.Point(6, 19);
            this.btnLstFiles.Name = "btnLstFiles";
            this.btnLstFiles.Size = new System.Drawing.Size(628, 23);
            this.btnLstFiles.TabIndex = 0;
            this.btnLstFiles.Text = "List Files";
            this.btnLstFiles.UseVisualStyleBackColor = true;
            this.btnLstFiles.Click += new System.EventHandler(this.btnLstFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.grpBoxUpload);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FTP CLIENT";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.grpBoxUpload.ResumeLayout(false);
            this.grpBoxUpload.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewFilename;
        private System.Windows.Forms.TextBox txtCurrentFilename;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.GroupBox grpBoxUpload;
        private System.Windows.Forms.Button btnFileSize;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNewDir;
        private System.Windows.Forms.Button btnewDir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLstFiles;

    }
}

