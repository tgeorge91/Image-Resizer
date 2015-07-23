namespace ImageResizer
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
            this.allImages = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeasurment = new System.Windows.Forms.ComboBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnConvertPng = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // allImages
            // 
            this.allImages.DisplayMember = "FileName";
            this.allImages.FormattingEnabled = true;
            this.allImages.Location = new System.Drawing.Point(12, 12);
            this.allImages.Name = "allImages";
            this.allImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.allImages.Size = new System.Drawing.Size(181, 251);
            this.allImages.TabIndex = 0;
            this.allImages.ValueMember = "FullPath";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(12, 269);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(114, 23);
            this.btnAddFiles.TabIndex = 1;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(132, 269);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(61, 23);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "Remove";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Width:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(268, 34);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(268, 9);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Measurement:";
            // 
            // txtMeasurment
            // 
            this.txtMeasurment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMeasurment.FormattingEnabled = true;
            this.txtMeasurment.Items.AddRange(new object[] {
            "Pixels",
            "Percent"});
            this.txtMeasurment.Location = new System.Drawing.Point(279, 71);
            this.txtMeasurment.Name = "txtMeasurment";
            this.txtMeasurment.Size = new System.Drawing.Size(89, 21);
            this.txtMeasurment.TabIndex = 8;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(210, 211);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(156, 23);
            this.btnResize.TabIndex = 9;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(210, 182);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(237, 115);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(95, 17);
            this.chkOverwrite.TabIndex = 11;
            this.chkOverwrite.Text = "Overwrite Files";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(210, 240);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(156, 23);
            this.btnCompress.TabIndex = 12;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnConvertPng
            // 
            this.btnConvertPng.Location = new System.Drawing.Point(210, 269);
            this.btnConvertPng.Name = "btnConvertPng";
            this.btnConvertPng.Size = new System.Drawing.Size(156, 23);
            this.btnConvertPng.TabIndex = 13;
            this.btnConvertPng.Text = "Convert to PNG";
            this.btnConvertPng.UseVisualStyleBackColor = true;
            this.btnConvertPng.Click += new System.EventHandler(this.btnConvertPng_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(86, 138);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(226, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 299);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnConvertPng);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.txtMeasurment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.allImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtMeasurment;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnConvertPng;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

