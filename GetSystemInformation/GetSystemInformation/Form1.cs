using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Drawing.Imaging;

namespace GetSystemInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "64-bit operating system = " + Environment.Is64BitOperatingSystem + Environment.NewLine
                + "Number Of Cores" + Environment.ProcessorCount + Environment.NewLine
                + "" + Environment.NewLine;

            Process Proc = new Process();
            Proc.StartInfo.FileName = "msinfo32.exe";
            Proc.StartInfo.CreateNoWindow = true;
            Proc.Start();

            System.Threading.Thread.Sleep(3000);
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            string ImagePath = @"C:\Users\Desktop\YASHIKA\printscreen.jpg";
            printscreen.Save(ImagePath, ImageFormat.Jpeg);

            System.Console.WriteLine("Msinfo32 /report C:\\Users\\YASHIKA\\Desktop\\Demo123.txt");

            MessageBox.Show("Thank You");
        }
    }
}
