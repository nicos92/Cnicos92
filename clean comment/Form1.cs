using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Security.Cryptography;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.ProgramSynthesis.Detection.Encoding;

namespace clean_comment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("User32.DLL", EntryPoint ="SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int WParam, int LPARAM);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }







        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void selectFile_DragDrop(object sender, DragEventArgs e)
        {
            
            txtEncoding.Text = "";
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            nameFile.Text = new FileInfo(archivos[0]).Name;

            LeerArchivo(archivos[0]);


        }


        private void LeerArchivo(string path)
        {
            try
            {


                Encoding miencoding = GetEncodingNonoAndy(path);
                txtEncoding.Text = miencoding.EncodingName;



                string clean = " Clean " + DateTime.Now.ToString("yyyy-MM-dd HH mm´ ss``") + ".txt";

                string archivoCreado = path.Replace(".txt", clean);

                // Crear una instancia de StreamReader

                FileStream mifile = File.Create( archivoCreado);
                Console.WriteLine(mifile.ToString());

                using (StreamWriter writer = new StreamWriter(mifile, miencoding))
                {
                    using (StreamReader sr = new StreamReader(path, miencoding))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Procesar cada línea del archivo

                            writer.WriteLine(line);
                        }
                    }

                
                
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }


        public static Encoding GetEncodingNonoAndy(string filename)
        {
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var detectedEncoding = EncodingIdentifier.IdentifyEncoding(file);
                switch (detectedEncoding)
                {
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Utf8:
                        return Encoding.UTF8;
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Utf16Be:
                        return Encoding.BigEndianUnicode;
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Utf16Le:
                        return Encoding.Unicode;
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Utf32Le:
                        return Encoding.UTF32;
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Ascii:
                        return Encoding.ASCII;
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Iso88591:
                        
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Unknown:
                    case Microsoft.ProgramSynthesis.Detection.Encoding.EncodingType.Windows1252:
                    default:
                        return Encoding.Default;
                }
            }
        }







   

 

 




    }
}
