using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
namespace AOA_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Broswer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                FileDialogue.Text = fileName;
                MessageBox.Show("File Uploaded Successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txt_To_Compress.MaxLength = 2000000000;
            //string Example = txt_To_Compress.Text;
            //var huffman = new Huffman<char>(Example);
            //List<int> encoding = huffman.Encode(Example);
            //List<char> decoding = huffman.Decode(encoding);
            //var outstring = new string(decoding.ToArray());
            //MessageBox.Show("Encoding Worked ");
            //TextWriter txt = new StreamWriter("C:\\Temp\\demo.txt");
            //txt.Write(Example);
            //txt.Close();
            string path = FileDialogue.Text;
            FileStream sourceFile = File.OpenRead(path);
            FileStream destinationFile = File.Create(path + ".zip");

            byte[] buffer = new byte[sourceFile.Length];
            sourceFile.Read(buffer, 0, buffer.Length);

            using (GZipStream output = new GZipStream(destinationFile,
                CompressionMode.Compress))
            {
                Console.WriteLine("Compressing {0} to {1}.", sourceFile.Name,
                    destinationFile.Name, false);

                output.Write(buffer, 0, buffer.Length);
            }

            // Close the files.
            sourceFile.Close();
            destinationFile.Close();
            MessageBox.Show("File Compressed Sucessfully");
        }
        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
                MessageBox.Show("File Decompressed Successfully");
            }
        }
            private void btn_Decompress_Click(object sender, EventArgs e)
            {
            string path = FileDialogue.Text;
            FileInfo filepath = new FileInfo(path);
            Decompress(filepath);
            }
            //    string startPath = @".\start";
            //    string zipPath = @".\result.zip";
            //    string extractPath = @".\extract";

            //    ZipFile.CreateFromDirectory(startPath, zipPath);

            //    ZipFile.ExtractToDirectory(zipPath, extractPath)
    }
}
