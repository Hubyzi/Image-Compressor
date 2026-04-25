namespace Image_Compression_Application
{
    partial class Image_Compressor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image_Compressor));
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            Uncompressed_Image = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            Compression_Percentage = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            Width_Text = new Label();
            Height_Text = new Label();
            Percent_Size_Image_Text = new Label();
            label12 = new Label();
            label13 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            Compressed_Image = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Quant_Trackbar = new Krypton.Toolkit.KryptonTrackBar();
            Quant_UpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            Dither_Dropdown2 = new Krypton.Toolkit.KryptonComboBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            progressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            Chroma_Dropdown = new Krypton.Toolkit.KryptonComboBox();
            Compressed_Image_Dropdown = new Krypton.Toolkit.KryptonComboBox();
            Percent_Resize_Select = new Krypton.Toolkit.KryptonRadioButton();
            Aspect_Ratio_Select = new Krypton.Toolkit.KryptonRadioButton();
            Percent_Trackbar2 = new Krypton.Toolkit.KryptonTrackBar();
            Width_UpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            Height_UpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            UpDown_Percent_Size = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            Output_Directory_Text = new Krypton.Toolkit.KryptonTextBox();
            Source_Directory_Text = new Krypton.Toolkit.KryptonTextBox();
            Uncompressed_Details = new TextBox();
            Compressed_Details = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Uncompressed_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Compressed_Image).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dither_Dropdown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chroma_Dropdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Compressed_Image_Dropdown).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // Uncompressed_Image
            // 
            Uncompressed_Image.BackColor = Color.FromArgb(134, 179, 236);
            Uncompressed_Image.ErrorImage = (Image)resources.GetObject("Uncompressed_Image.ErrorImage");
            Uncompressed_Image.Image = (Image)resources.GetObject("Uncompressed_Image.Image");
            Uncompressed_Image.Location = new Point(3, 3);
            Uncompressed_Image.Name = "Uncompressed_Image";
            Uncompressed_Image.Size = new Size(168, 168);
            Uncompressed_Image.SizeMode = PictureBoxSizeMode.AutoSize;
            Uncompressed_Image.TabIndex = 0;
            Uncompressed_Image.TabStop = false;
            Uncompressed_Image.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(53, 45);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 3;
            label2.Text = "Image Source Directory";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(53, 134);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 5;
            label3.Text = "Image Source Output Directory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(23, 270);
            label1.Name = "label1";
            label1.Size = new Size(124, 16);
            label1.TabIndex = 14;
            label1.Text = "Colour Quantization:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(34, 317);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 16;
            label4.Text = "Dither Method:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(84, 529);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 18;
            label5.Text = "Compression Progress:";
            // 
            // Compression_Percentage
            // 
            Compression_Percentage.AutoSize = true;
            Compression_Percentage.BackColor = Color.Transparent;
            Compression_Percentage.ForeColor = SystemColors.ActiveCaptionText;
            Compression_Percentage.Location = new Point(725, 553);
            Compression_Percentage.Name = "Compression_Percentage";
            Compression_Percentage.Size = new Size(23, 15);
            Compression_Percentage.TabIndex = 19;
            Compression_Percentage.Text = "0%";
            Compression_Percentage.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(34, 367);
            label7.Name = "label7";
            label7.Size = new Size(149, 15);
            label7.TabIndex = 21;
            label7.Text = "Chroma subampling Ratio:";
            label7.Click += label7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(702, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(288, 422);
            label8.Name = "label8";
            label8.Size = new Size(139, 15);
            label8.TabIndex = 24;
            label8.Text = "Compressed Image Type:";
            // 
            // Width_Text
            // 
            Width_Text.AutoSize = true;
            Width_Text.BackColor = Color.Transparent;
            Width_Text.Enabled = false;
            Width_Text.ForeColor = SystemColors.ControlLightLight;
            Width_Text.Location = new Point(407, 324);
            Width_Text.Name = "Width_Text";
            Width_Text.Size = new Size(42, 15);
            Width_Text.TabIndex = 26;
            Width_Text.Text = "Width:";
            // 
            // Height_Text
            // 
            Height_Text.AutoSize = true;
            Height_Text.BackColor = Color.Transparent;
            Height_Text.Enabled = false;
            Height_Text.ForeColor = SystemColors.ControlLightLight;
            Height_Text.Location = new Point(562, 324);
            Height_Text.Name = "Height_Text";
            Height_Text.Size = new Size(46, 15);
            Height_Text.TabIndex = 28;
            Height_Text.Text = "Height:";
            // 
            // Percent_Size_Image_Text
            // 
            Percent_Size_Image_Text.AutoSize = true;
            Percent_Size_Image_Text.BackColor = Color.Transparent;
            Percent_Size_Image_Text.ForeColor = SystemColors.ControlLightLight;
            Percent_Size_Image_Text.Location = new Point(362, 364);
            Percent_Size_Image_Text.Name = "Percent_Size_Image_Text";
            Percent_Size_Image_Text.Size = new Size(112, 15);
            Percent_Size_Image_Text.TabIndex = 30;
            Percent_Size_Image_Text.Text = "% of Original Image";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(483, 270);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 33;
            label12.Text = "Resize by Percent:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(480, 295);
            label13.Name = "label13";
            label13.Size = new Size(104, 15);
            label13.TabIndex = 34;
            label13.Text = "Lock Aspect Ratio:";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Compressed_Image
            // 
            Compressed_Image.ErrorImage = (Image)resources.GetObject("Compressed_Image.ErrorImage");
            Compressed_Image.Image = (Image)resources.GetObject("Compressed_Image.Image");
            Compressed_Image.Location = new Point(3, 3);
            Compressed_Image.Name = "Compressed_Image";
            Compressed_Image.Size = new Size(168, 168);
            Compressed_Image.SizeMode = PictureBoxSizeMode.AutoSize;
            Compressed_Image.TabIndex = 47;
            Compressed_Image.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(Uncompressed_Image);
            flowLayoutPanel1.Location = new Point(770, 31);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(192, 169);
            flowLayoutPanel1.TabIndex = 48;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(Compressed_Image);
            flowLayoutPanel2.Location = new Point(770, 270);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(192, 169);
            flowLayoutPanel2.TabIndex = 49;
            // 
            // Quant_Trackbar
            // 
            Quant_Trackbar.LargeChange = 1000;
            Quant_Trackbar.Location = new Point(153, 268);
            Quant_Trackbar.Maximum = 20000;
            Quant_Trackbar.Name = "Quant_Trackbar";
            Quant_Trackbar.Size = new Size(179, 27);
            Quant_Trackbar.TabIndex = 50;
            Quant_Trackbar.ValueChanged += kryptonTrackBar1_ValueChanged;
            // 
            // Quant_UpDown
            // 
            Quant_UpDown.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            Quant_UpDown.Location = new Point(338, 270);
            Quant_UpDown.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            Quant_UpDown.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            Quant_UpDown.Name = "Quant_UpDown";
            Quant_UpDown.Size = new Size(53, 22);
            Quant_UpDown.TabIndex = 51;
            Quant_UpDown.Value = new decimal(new int[] { 0, 0, 0, 0 });
            Quant_UpDown.ValueChanged += kryptonNumericUpDown1_ValueChanged;
            // 
            // Dither_Dropdown2
            // 
            Dither_Dropdown2.DropDownStyle = ComboBoxStyle.DropDownList;
            Dither_Dropdown2.DropDownWidth = 121;
            Dither_Dropdown2.Location = new Point(153, 314);
            Dither_Dropdown2.MaxDropDownItems = 4;
            Dither_Dropdown2.Name = "Dither_Dropdown2";
            Dither_Dropdown2.Size = new Size(121, 22);
            Dither_Dropdown2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Dither_Dropdown2.TabIndex = 52;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(590, 70);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(73, 22);
            kryptonButton1.TabIndex = 53;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Browse";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(355, 486);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(102, 25);
            kryptonButton2.TabIndex = 54;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Compress";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(84, 547);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(633, 26);
            progressBar1.StateCommon.Back.Color1 = Color.Green;
            progressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progressBar1.TabIndex = 55;
            progressBar1.TextBackdropColor = Color.Empty;
            progressBar1.TextShadowColor = Color.Empty;
            progressBar1.Values.Text = "";
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(590, 158);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(73, 22);
            kryptonButton3.TabIndex = 56;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "Browse";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // Chroma_Dropdown
            // 
            Chroma_Dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            Chroma_Dropdown.DropDownWidth = 121;
            Chroma_Dropdown.Location = new Point(189, 365);
            Chroma_Dropdown.Name = "Chroma_Dropdown";
            Chroma_Dropdown.Size = new Size(121, 22);
            Chroma_Dropdown.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Chroma_Dropdown.TabIndex = 57;
            // 
            // Compressed_Image_Dropdown
            // 
            Compressed_Image_Dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            Compressed_Image_Dropdown.DropDownWidth = 121;
            Compressed_Image_Dropdown.Location = new Point(440, 422);
            Compressed_Image_Dropdown.Name = "Compressed_Image_Dropdown";
            Compressed_Image_Dropdown.Size = new Size(121, 22);
            Compressed_Image_Dropdown.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Compressed_Image_Dropdown.TabIndex = 58;
            Compressed_Image_Dropdown.SelectedIndexChanged += Compressed_Image_Dropdown_SelectedIndexChanged;
            // 
            // Percent_Resize_Select
            // 
            Percent_Resize_Select.Checked = true;
            Percent_Resize_Select.Location = new Point(590, 267);
            Percent_Resize_Select.Name = "Percent_Resize_Select";
            Percent_Resize_Select.Size = new Size(19, 25);
            Percent_Resize_Select.TabIndex = 59;
            Percent_Resize_Select.Values.Text = "";
            Percent_Resize_Select.CheckedChanged += Percent_Resize_Select_CheckedChanged;
            // 
            // Aspect_Ratio_Select
            // 
            Aspect_Ratio_Select.Location = new Point(590, 291);
            Aspect_Ratio_Select.Name = "Aspect_Ratio_Select";
            Aspect_Ratio_Select.Size = new Size(19, 25);
            Aspect_Ratio_Select.TabIndex = 60;
            Aspect_Ratio_Select.Values.Text = "";
            Aspect_Ratio_Select.CheckedChanged += Aspect_Ratio_Select_CheckedChanged;
            // 
            // Percent_Trackbar2
            // 
            Percent_Trackbar2.LargeChange = 30;
            Percent_Trackbar2.Location = new Point(480, 360);
            Percent_Trackbar2.Maximum = 300;
            Percent_Trackbar2.Name = "Percent_Trackbar2";
            Percent_Trackbar2.Size = new Size(142, 27);
            Percent_Trackbar2.TabIndex = 61;
            Percent_Trackbar2.Value = 100;
            Percent_Trackbar2.ValueChanged += kryptonTrackBar1_ValueChanged_1;
            // 
            // Width_UpDown
            // 
            Width_UpDown.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            Width_UpDown.Location = new Point(468, 322);
            Width_UpDown.Maximum = new decimal(new int[] { 7680, 0, 0, 0 });
            Width_UpDown.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            Width_UpDown.Name = "Width_UpDown";
            Width_UpDown.Size = new Size(67, 22);
            Width_UpDown.TabIndex = 62;
            Width_UpDown.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // Height_UpDown
            // 
            Height_UpDown.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            Height_UpDown.Location = new Point(628, 322);
            Height_UpDown.Maximum = new decimal(new int[] { 4320, 0, 0, 0 });
            Height_UpDown.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            Height_UpDown.Name = "Height_UpDown";
            Height_UpDown.Size = new Size(67, 22);
            Height_UpDown.TabIndex = 63;
            Height_UpDown.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // UpDown_Percent_Size
            // 
            UpDown_Percent_Size.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            UpDown_Percent_Size.Location = new Point(628, 364);
            UpDown_Percent_Size.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            UpDown_Percent_Size.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            UpDown_Percent_Size.Name = "UpDown_Percent_Size";
            UpDown_Percent_Size.Size = new Size(68, 22);
            UpDown_Percent_Size.TabIndex = 64;
            UpDown_Percent_Size.Value = new decimal(new int[] { 100, 0, 0, 0 });
            UpDown_Percent_Size.ValueChanged += kryptonNumericUpDown1_ValueChanged_1;
            // 
            // kryptonManager1
            // 
            kryptonManager1.BaseFont = new Font("Microsoft JhengHei UI", 9F);
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            kryptonManager1.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
            kryptonManager1.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
            // 
            // Output_Directory_Text
            // 
            Output_Directory_Text.Location = new Point(53, 158);
            Output_Directory_Text.Name = "Output_Directory_Text";
            Output_Directory_Text.Size = new Size(508, 23);
            Output_Directory_Text.TabIndex = 65;
            // 
            // Source_Directory_Text
            // 
            Source_Directory_Text.Location = new Point(53, 70);
            Source_Directory_Text.Name = "Source_Directory_Text";
            Source_Directory_Text.Size = new Size(508, 23);
            Source_Directory_Text.TabIndex = 66;
            // 
            // Uncompressed_Details
            // 
            Uncompressed_Details.BackColor = Color.FromArgb(134, 179, 236);
            Uncompressed_Details.BorderStyle = BorderStyle.FixedSingle;
            Uncompressed_Details.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Uncompressed_Details.ForeColor = Color.FromArgb(29, 0, 248);
            Uncompressed_Details.Location = new Point(770, 195);
            Uncompressed_Details.Multiline = true;
            Uncompressed_Details.Name = "Uncompressed_Details";
            Uncompressed_Details.ScrollBars = ScrollBars.Vertical;
            Uncompressed_Details.Size = new Size(191, 76);
            Uncompressed_Details.TabIndex = 69;
            Uncompressed_Details.Text = "File Name: \r\nFormat: \r\nDimensions:\r\nFile Size: \r\nCreation Date:\r\nLast Modification:\r\n\r\n";
            // 
            // Compressed_Details
            // 
            Compressed_Details.BackColor = Color.FromArgb(134, 179, 236);
            Compressed_Details.BorderStyle = BorderStyle.FixedSingle;
            Compressed_Details.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Compressed_Details.ForeColor = Color.FromArgb(29, 0, 248);
            Compressed_Details.Location = new Point(770, 437);
            Compressed_Details.Multiline = true;
            Compressed_Details.Name = "Compressed_Details";
            Compressed_Details.ScrollBars = ScrollBars.Vertical;
            Compressed_Details.Size = new Size(190, 74);
            Compressed_Details.TabIndex = 70;
            Compressed_Details.Text = "File Name: \r\nFormat: \r\nDimensions:\r\nFile Size: \r\nCreation Date:\r\nLast Modification:\r\n\r\n";
            // 
            // Image_Compressor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(961, 582);
            Controls.Add(Compressed_Details);
            Controls.Add(Uncompressed_Details);
            Controls.Add(Source_Directory_Text);
            Controls.Add(Output_Directory_Text);
            Controls.Add(UpDown_Percent_Size);
            Controls.Add(Height_UpDown);
            Controls.Add(Width_UpDown);
            Controls.Add(Percent_Trackbar2);
            Controls.Add(Aspect_Ratio_Select);
            Controls.Add(Percent_Resize_Select);
            Controls.Add(Compressed_Image_Dropdown);
            Controls.Add(Chroma_Dropdown);
            Controls.Add(kryptonButton3);
            Controls.Add(progressBar1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(Dither_Dropdown2);
            Controls.Add(Quant_UpDown);
            Controls.Add(Quant_Trackbar);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(Percent_Size_Image_Text);
            Controls.Add(Height_Text);
            Controls.Add(Width_Text);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(Compression_Percentage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Image_Compressor";
            Text = "ByteSized - Image Compressor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Uncompressed_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Compressed_Image).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dither_Dropdown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chroma_Dropdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Compressed_Image_Dropdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private PictureBox Uncompressed_Image;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label Compression_Percentage;
        private Label label5;
        private ComboBox kryptonComboBox1;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label8;
        private Label Percent_Size_Image_Text;
        private Label Height_Text;
        private Label Width_Text;
        private Label label13;
        private Label label12;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox Compressed_Image;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonTrackBar Quant_Trackbar;
        private Krypton.Toolkit.KryptonNumericUpDown Quant_UpDown;
        private Krypton.Toolkit.KryptonComboBox Dither_Dropdown2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonProgressBar progressBar1;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonComboBox Chroma_Dropdown;
        private Krypton.Toolkit.KryptonComboBox Compressed_Image_Dropdown;
        private Krypton.Toolkit.KryptonRadioButton Aspect_Ratio_Select;
        private Krypton.Toolkit.KryptonRadioButton Percent_Resize_Select;
        private Krypton.Toolkit.KryptonTrackBar Percent_Trackbar2;
        private Krypton.Toolkit.KryptonNumericUpDown Width_UpDown;
        private Krypton.Toolkit.KryptonNumericUpDown Height_UpDown;
        private Krypton.Toolkit.KryptonNumericUpDown UpDown_Percent_Size;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonTextBox Output_Directory_Text;
        private Krypton.Toolkit.KryptonTextBox Source_Directory_Text;
        private TextBox Uncompressed_Details;
        private TextBox Compressed_Details;
    }
}
