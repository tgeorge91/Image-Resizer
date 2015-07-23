﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace ImageResizer
{
    public partial class Form1 : Form
    {
        public List<Img> AllImages = new List<Img>();
        string FolderLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                var files = openFileDialog1.FileNames;
                ShowProgressBar(true, files.Count());

                foreach (var file in files)
                {
                    UpdateProgressBar();
                    var path = file;
                    var fileName = System.IO.Path.GetFileName(path);
                    var extention = Path.GetExtension(path);

                    using (var image = Image.FromFile(file))
                    {
                        var img = new Img { FullPath = file, FileName = fileName, Width = image.Width, Height = image.Height, FileExtention = extention };
                        AllImages.Add(img);
                    }
                }

                ShowProgressBar(false);

                RepopulateListBox();
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            var filesToRemove = allImages.SelectedItems;
            foreach (Img file in filesToRemove)
            {
                var img = AllImages.SingleOrDefault(q => q.FullPath == file.FullPath);
                AllImages.Remove(img);
            }

            RepopulateListBox();
        }

        private void RepopulateListBox()
        {
            allImages.Items.Clear();
            foreach (var image in AllImages)
            {
                allImages.Items.Add(image);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            AllImages.Clear();
            RepopulateListBox();
            txtHeight.Text = "";
            txtWidth.Text = "";
            txtMeasurment.SelectedIndex = 0;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            SetFolderLocation("Resized");
            ShowProgressBar(true, AllImages.Count());

            foreach (Img file in AllImages)
            {
                UpdateProgressBar();
                var image = Image.FromFile(file.FullPath);
                var width = GetWidth(file);
                var height = GetHeight(file);
                var newImage = ResizeImage(image, width, height);
                var newFileLocation = GetNewFileLocation(file);
                var extention = GetExtention(file.FileExtention);
                image.Dispose();

                newImage.Save(newFileLocation, extention);
            }

            ShowProgressBar(false);
            AllImages.Clear();
            RepopulateListBox();

            MessageBox.Show("Completed Resizing.");
            OpenFolder();
        }

        public Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMeasurment.SelectedIndex = 0;
        }

        private int GetWidth(Img img)
        {
            int width;
            var isPixels = txtMeasurment.SelectedText == "Pixels";
            if (isPixels)
            {
                width = Int32.Parse(txtWidth.Text);
            }
            else // Percent
            {
                width = (int)Math.Round(img.Width * (Double.Parse(txtWidth.Text) / 100));
            }

            return width;
        }

        private int GetHeight(Img img)
        {
            int height;
            var isPixels = txtMeasurment.SelectedText == "Pixels";
            if (isPixels)
            {
                height = Int32.Parse(txtHeight.Text);
            }
            else // Percent
            {
                height = (int)Math.Round(img.Height * (Double.Parse(txtHeight.Text) / 100));
            }

            return height;
        }

        private void SetFolderLocation(string type)
        {
            if (!Directory.Exists(@"C:\Resized"))
            {
                Directory.CreateDirectory(@"C:\Resized");
            }

            var newDir = String.Format("{0:G}", DateTime.Now).Replace("/", "-").Replace(":", "-");
            FolderLocation = @"C:\Resized" + @"\" + newDir + " " + type + @"\";

            Directory.CreateDirectory(FolderLocation);
        }

        private string GetNewFileLocation(Img img, bool convert = false)
        {
            if (chkOverwrite.Checked && !convert)
            {
                return img.FullPath;
            }
            else
            {
                var fileName = Path.GetFileNameWithoutExtension(img.FullPath);
                var extention = convert ? ".png" : Path.GetExtension(img.FullPath);

                var fileLocation = FolderLocation + fileName + extention;

                return fileLocation;
            }
        }

        private ImageFormat GetExtention(string extention)
        {
            if (extention == ".jpg" || extention == ".jpeg")
            {
                return ImageFormat.Jpeg;
            }
            else if (extention == ".gif")
            {
                return ImageFormat.Gif;
            }
            else if (extention == ".png")
            {
                return ImageFormat.Png;
            }
            else if (extention == ".bmp")
            {
                return ImageFormat.Bmp;
            }

            return null;
        }

        private void ShowProgressBar(bool show, int max = 0)
        {
            if (show)
            {
                progressBar.Show();
                progressBar.Maximum = max;
                progressBar.Value = 0;
            }
            else
            {
                progressBar.Hide();
            }
        }

        private void UpdateProgressBar()
        {
            if (progressBar.Value < progressBar.Maximum)
                progressBar.Increment(1);
            else
                progressBar.Value = 0;
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            SetFolderLocation("Compressed");
            ShowProgressBar(true, AllImages.Count());

            foreach (Img file in AllImages)
            {
                UpdateProgressBar();
                var image = Image.FromFile(file.FullPath);
                var width = image.Width;
                var height = image.Height;
                var newImage = ResizeImage(image, width, height);
                var newFileLocation = GetNewFileLocation(file);
                var extention = GetExtention(file.FileExtention);
                image.Dispose();

                newImage.Save(newFileLocation, extention);
            }

            ShowProgressBar(false);
            AllImages.Clear();
            RepopulateListBox();

            MessageBox.Show("Completed Compression.");
            OpenFolder();
        }

        private void btnConvertPng_Click(object sender, EventArgs e)
        {
            SetFolderLocation("Converted to Png");
            ShowProgressBar(true, AllImages.Count());

            foreach (Img file in AllImages)
            {
                UpdateProgressBar();
                var image = Image.FromFile(file.FullPath);
                var width = image.Width;
                var height = image.Height;
                var newImage = ResizeImage(image, width, height);
                var newFileLocation = GetNewFileLocation(file, true);
                var extention = ImageFormat.Png;
                image.Dispose();

                newImage.Save(newFileLocation, extention);
            }

            ShowProgressBar(false);
            AllImages.Clear();
            RepopulateListBox();

            MessageBox.Show("Completed Conversion.");
            OpenFolder();
        }

        private void OpenFolder()
        {
            Process.Start(FolderLocation);
        }
    }
}