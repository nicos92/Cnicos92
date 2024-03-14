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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void selectFile_DragDrop(object sender, DragEventArgs e)
        {
            txtContenido.Text = "";
            encoding.Text = "";
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            nameFile.Text = archivos[0];



            Thread thr = new Thread( new ThreadStart(LeerArchivo) );
            thr.Start();



        }

        public  void LeerArchivo()
        {

            //encoding.Text = getEncoding(path);

            StreamReader lector = File.OpenText(nameFile.Text);

            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                //txtContenido.AppendText(linea + "\r\n");
                Console.WriteLine(linea);
            }

            lector.Close();


        }





        private void label7_Click(object sender, EventArgs e)
        {

        }

        private string getEncoding(string miArchivo)

        {


            using(StreamReader reader = new StreamReader(miArchivo, true))
            {
                reader.Peek();

                Encoding enconding = reader.CurrentEncoding;
                Console.WriteLine("Mi encoding: " + enconding.EncodingName + " " + enconding.ToString() + " " + enconding);
                return enconding.EncodingName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ControlExtension.Draggable(selectFile, true);
        }
    }
}
