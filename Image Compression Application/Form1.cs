using ImageMagick;
using ImageMagick.Formats;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_Compression_Application
{
    public partial class Image_Compressor : Form
    {
        // this is where everything starts to be intialized and displayed to the user before anything happens right from the get go 
        public Image_Compressor()
        {
            InitializeComponent();

            string[] Dither_Drop_Down_List = { "FloydSteinberg", "Riemersma", "None" };
            Dither_Dropdown2.Items.AddRange(Dither_Drop_Down_List);

            string[] Chroma_Drop_Down_List = { "4:4:4", "4:2:2", "4:2:0", "4:1:1" };
            Chroma_Dropdown.Items.AddRange(Chroma_Drop_Down_List);

            string[] Image_Type_Drop_Down_List = { "png", "jpg", "bmp", "gif", "webp" };
            Compressed_Image_Dropdown.Items.AddRange(Image_Type_Drop_Down_List);

            Dither_Dropdown2.SelectedItem = "None";
            Chroma_Dropdown.SelectedItem = "4:4:4";
            Compressed_Image_Dropdown.SelectedItem = "jpg";

        }
        private string Image_Name_Extractor(string Image_Name, ref string File_Directory)
        {

            string True_Image_Name = "";

            // this loop does get the name but all of the characters in the final variable string is flipped 
            for (int i = (File_Directory.Length - 1); i > 0; i--)
            {

                if (File_Directory[i] == '\\')
                {
                    break;
                }

                else
                {
                    Image_Name += File_Directory[i];
                }

            }

            Console.WriteLine(Image_Name);

            // which gives a purpose for the 2nd loop to unflip those strings

            // for some reason for loops wont run if you use "i == 0" as a condition so instead as a alternative solution to access the final character of the string im going to have to use the 
            // condition: "i > -1"
            for (int i = (Image_Name.Length - 1); i > -1; i--)
            {
                True_Image_Name += Image_Name[i];
            }

            Console.WriteLine(True_Image_Name);

            string[] Remove_File_Extension_List = { ".png", ".jpg", ".webp", ".bmp", ".gif" };

            // god what a fucking awful variable name but this will have to do for now 
            string True_True_Image_Name = "";

            // go through the list of file extensions offered and remove them from the text to display the file name without the file extension 
            for (int i = 0; i < (Remove_File_Extension_List.Length); i++)
            {
                True_True_Image_Name = Regex.Replace(True_Image_Name, $"{Remove_File_Extension_List[i]}", "");

                if (True_Image_Name != True_True_Image_Name)
                {
                    break;
                }

            }

            Console.WriteLine(True_True_Image_Name);

            return True_True_Image_Name;
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        // help button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Hubyzi") { UseShellExecute = true });
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void kryptonTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            Quant_UpDown.Value = Quant_Trackbar.Value;
        }
        private void kryptonNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Quant_Trackbar.Value = Convert.ToInt16(Quant_UpDown.Value);
        }

        // import image button
        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            // seeing that i yoinked this code from the microsoft website i assume this var datatype is there so that this variable can automatically handle any datatype the file being opened requires
            var fileContent = "";
            string filePath = "";

            // 
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                // double backward slashes are needed so that this IDE does not freak out and think we are trying to do an incomplete escape sequence for unprintable characters 
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png images (*.png)|*.png|jpg/jpeg images (*.jpg)|*.jpg|gif images (*.gif)|*.gif|WebP images (*.webp)|*.webp|bmp images (*.bmp)|*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                try
                {
                    // condition is only executed if the user confirms their selection 
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // get file path of file
                        filePath = openFileDialog.FileName;

                        // automatically display the directory the user wants to open the file from 
                        Source_Directory_Text.Text = filePath;

                        // read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        Uncompressed_Image.ImageLocation = Source_Directory_Text.Text;

                    }

                    using (var image = new MagickImage($"{Uncompressed_Image.ImageLocation}"))
                    {
                        string File_Directory = Uncompressed_Image.ImageLocation;

                        string Image_Name = "";
                        DateTime Image_Creation_Date = File.GetCreationTime(Uncompressed_Image.ImageLocation);
                        DateTime Image_Last_Mod_Date = File.GetLastWriteTime(Uncompressed_Image.ImageLocation);
                        decimal Image_Size = new FileInfo(Uncompressed_Image.ImageLocation).Length / 1024;

                        Image_Name = Image_Name_Extractor(Image_Name, ref File_Directory);
                        Uncompressed_Details.Text = $"File Name: {Image_Name} \r\nFormat: {image.Format} \r\nDimensions: {image.Width} x {image.Height} \r\nFile Size: {Image_Size}KB \r\nCreation Date: {Image_Creation_Date} \r\nLast Modification: {Image_Last_Mod_Date}";
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(Convert.ToString(ex));
                }

            }
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            Compression_Percentage.Text = $"0%";

            // the so trustworthy feedback loop progress bar function 
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(75);
                progressBar1.Value += 10;
                Compression_Percentage.Text = $"{progressBar1.Value}%";
            }

            // random numbers added to file name to prevent any duplicate files from overwriting eachover each time a image has been compressed 
            var rand_num = new Random();

            var Chroma_Image_Type = MagickFormat.Null;
            var DitherMethod_Selection = DitherMethod.No;
            var Compression_Type_Method = CompressionMethod.NoCompression;

            int Random_Number = rand_num.Next(0, 10000000);
            uint Resized_Percentage = Convert.ToUInt16(UpDown_Percent_Size.Value / 100);
            uint Colour_Quant_Value = Convert.ToUInt16(Quant_UpDown.Value);

            string Image_Type = Convert.ToString(Compressed_Image_Dropdown.SelectedItem);

            Uncompressed_Image.ImageLocation = Source_Directory_Text.Text;

            if (Convert.ToString(Dither_Dropdown2.SelectedItem) == "FloydSteinberg")
            {
                DitherMethod_Selection = DitherMethod.FloydSteinberg;
            }

            else if (Convert.ToString(Dither_Dropdown2.SelectedItem) == "Riemersma")
            {
                DitherMethod_Selection = DitherMethod.Riemersma;
            }

            // all the compression methods and chroma image type configurations conditions  
            if (Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "jpg")
            {
                Chroma_Image_Type = MagickFormat.Jpg;
                Compression_Type_Method = CompressionMethod.JPEG;
            }

            else if (Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "webp")
            {
                Chroma_Image_Type = MagickFormat.WebP;
                Compression_Type_Method = CompressionMethod.WebP;
            }
            // the zip algorithm from what i remember is the default compression algorithm for lossless image types 
            else if (Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "gif")
            {
                Compression_Type_Method = CompressionMethod.Zip;
            }

            else if (Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "bmp")
            {
                Compression_Type_Method = CompressionMethod.Zip;
            }

            else if (Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "png")
            {
                Compression_Type_Method = CompressionMethod.Zip;
            }

            try
            {
                // thank you magick image libraryyyyy basically this package is being used to set the bit depth of 2 and use a compression method then finally writing it 
                using (var image = new MagickImage($"{Uncompressed_Image.ImageLocation}"))
                {

                    decimal image_width = image.Width * UpDown_Percent_Size.Value / 100;
                    decimal image_height = image.Height * UpDown_Percent_Size.Value / 100;

                    // instead of bit depth compression this program will instead allow the user to adjust the colours of the image via colour quantization with dithering controls 
                    image.Quantize(new QuantizeSettings { Colors = Colour_Quant_Value, DitherMethod = DitherMethod_Selection });
                    image.Settings.SetDefine(Chroma_Image_Type, "sampling-factor", $"{Chroma_Dropdown.SelectedItem}");

                    if (Percent_Resize_Select.Checked == true)
                    {
                        var Image_Size = new MagickGeometry(Convert.ToUInt16(image_width), Convert.ToUInt16(image_height));
                        Image_Size.IgnoreAspectRatio = true;
                        image.Resize(Image_Size);
                    }

                    else
                    {
                        MagickGeometry Image_Size = new MagickGeometry(Convert.ToUInt16(Width_UpDown.Value), Convert.ToUInt16(Height_UpDown.Value));
                        image.Resize(Image_Size);
                    }

                    // set the compression method (zip is the default for compressing lossless image formats like pngs) 
                    image.Settings.Compression = Compression_Type_Method;

                    // add a minor hitch to the progress bar to give it more realism i suppose 
                    Thread.Sleep(95);
                    progressBar1.Value += 10;
                    Compression_Percentage.Text = $"{progressBar1.Value}%";

                    image.Write($"{Output_Directory_Text.Text}\\output{Random_Number}.{Image_Type}");

                    // filling out the compressed image details section 
                    Compressed_Image.ImageLocation = $"{Output_Directory_Text.Text}\\output{Random_Number}.{Image_Type}";

                    string File_Directory = Compressed_Image.ImageLocation;

                    string Image_Name = "";
                    DateTime Image_Creation_Date = File.GetCreationTime(Compressed_Image.ImageLocation);
                    DateTime Image_Last_Mod_Date = File.GetLastWriteTime(Compressed_Image.ImageLocation);
                    decimal Compressed_Image_Size = new FileInfo(Compressed_Image.ImageLocation).Length / 1024;

                    Image_Name = Image_Name_Extractor(Image_Name, ref File_Directory);
                    Compressed_Details.Text = $"File Name: {Image_Name} \r\nFormat: {image.Format} \r\nDimensions: {image.Width} x {image.Height} \r\nFile Size: {Compressed_Image_Size}KB \r\nCreation Date: {Image_Creation_Date} \r\nLast Modification: {Image_Last_Mod_Date}";
                    
                    // compression successful pop-up 
                    var Success_Popup = new Compression_Success();
                    Success_Popup.Show();

                }

            }

            // ik it seems confusing for this to be first Error 2 but thats because error 2 used to repeat that error 1 said so now im changing it to be an error related to empty directories
            // upon compression 
            catch (System.ArgumentException Empty_Directory)
            {

                progressBar1.Value = 0;
                Compression_Percentage.Text = $"0%";

                var Error_Exception_2 = new Error_2();
                Error_Exception_2.Show();

            }

            // this is catch section catches two exceptions hence the vauge variable exception name 
            catch (MagickBlobErrorException Error_1)
            {

                progressBar1.Value = 0;
                Compression_Percentage.Text = $"0%";

                var Error_Exception_1 = new Error_1();
                Error_Exception_1.Show();

            }

            // when i mean invalid directory structure i mean typing out a lot of bullshit instead of a proper structure like "C:\Images"
            catch (MagickMissingDelegateErrorException Invalid_Directory_Structure)
            {

                progressBar1.Value = 0;
                Compression_Percentage.Text = $"0%";

                var Error_Exception_1 = new Error_1();
                Error_Exception_1.Show();

            }

        }
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            string Folder_Path = "";

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Folder_Path = fbd.SelectedPath;
                    Output_Directory_Text.Text = Folder_Path;
                }
            }
        }
        private void Percent_Resize_Select_CheckedChanged(object sender, EventArgs e)
        {

            // enable percentage options 
            Percent_Size_Image_Text.Enabled = true;
            Percent_Trackbar2.Enabled = true;
            UpDown_Percent_Size.Enabled = true;

            // disable image resolution settings
            Width_Text.Enabled = false;
            Width_UpDown.Enabled = false;
            Height_Text.Enabled = false;
            Height_UpDown.Enabled = false;

        }
        private void Aspect_Ratio_Select_CheckedChanged(object sender, EventArgs e)
        {

            // enable image resolution settings
            Width_Text.Enabled = true;
            Width_UpDown.Enabled = true;
            Height_Text.Enabled = true;
            Height_UpDown.Enabled = true;

            // disable percentage options 
            Percent_Size_Image_Text.Enabled = false;
            Percent_Trackbar2.Enabled = false;
            UpDown_Percent_Size.Enabled = false;

        }
        private void kryptonTrackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            UpDown_Percent_Size.Value = Percent_Trackbar2.Value;
        }
        private void kryptonNumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Percent_Trackbar2.Value = Convert.ToInt16(UpDown_Percent_Size.Value);
        }
        private void Compressed_Image_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "png" || Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "gif" || Convert.ToString(Compressed_Image_Dropdown.SelectedItem) == "bmp")
            {
                label7.Enabled = false;
                Chroma_Dropdown.Enabled = false;
            }

            else
            {
                label7.Enabled = true;
                Chroma_Dropdown.Enabled = true;
            }
        }
        private void Uncompressed_Details_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
