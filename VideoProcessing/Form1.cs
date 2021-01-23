using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using FFMediaToolkit;

namespace VideoProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (ofdInputFile.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = ofdInputFile.FileName;
            }
        }

        private void btnChooseOutputFloder_Click(object sender, EventArgs e)
        {
            fbdOutputFloder.SelectedPath = Environment.CurrentDirectory;
            if (fbdOutputFloder.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = fbdOutputFloder.SelectedPath;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string command = $@"-i {txtInput.Text} -r 1 -s 1000x600 -qscale:v 2 -f image2 {txtOutput.Text}\{txtImageName.Text}-%03d.jpeg ";
            // "-r 1" tức là mỗi một giây lấy 1 ảnh 
            ExecFfmpegCommand(command);         
        }

        private void btnMergeIntoVideo_Click(object sender, EventArgs e)
        {
            string command = $@"-f image2 -framerate 29 -i {txtOutput.Text}\{txtImageName.Text}-%03d.jpeg -s 1000x600 {txtOutput.Text}\{txtImageName.Text}{cbbType.SelectedItem.ToString()}";
            // "-framerate 5 " 5 frame 1 giây
            ExecFfmpegCommand(command);
        }

        public void ExecFfmpegCommand(string ffmpegComand)
        {
            try
            {
                Process.Start("cmd.exe", $@"/k ffmpeg.exe {ffmpegComand}");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Document\VideoTest\videoplayback.mp4";
            // Lay keyframe cua video , cac anh co chat luong tot nhat
            /*
            string cmd = "-i " + path + " -vf \"select = eq(pict_type\\, I)\" -vsync vfr img%d.jpg";
            ExecFfmpegCommand(cmd);
            */
            // kiem tra 1 frame da cat co timestamp bn trong video
            //string cmd = "-ss 00:02:30 -i "+path+" -t 00:00:40 -loop 1 -i thumbnail.jpg -filter_complex \"scale=480:270,hue=s=0,blend=difference:shortest=1, blackframe = 95:30,fps = fps = 23\" -f null -";

            //string cmd = $"ffprobe -i "+path+" -show_frames";
            //ExecFfmpegCommand(cmd);

            //Luu frame voi timestamp
            string cmd = "-i "+path+" -vf fps=1,select='not(mod(t,1))' -vsync 0 -frame_pts 1 Image/z%d.jpg";
            ExecFfmpegCommand(cmd);

            /*
            string cmd = "-i " + path + " -vf \"fps=1,select=eq(pict_type\\, I)\" -vsync 0 -frame_pts 1 Image/z%d.jpg";
            ExecFfmpegCommand(cmd);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("Image");
            foreach (FileInfo file in di.GetFiles())
            {
                using (Bitmap image = (Bitmap)Bitmap.FromFile(file.FullName))
                {
                    int y =(image.Height / 3);
                    CropImage(image, new Rectangle(0, 2 * y, image.Width, y)).Save("Image/process/" + file.Name);
                }    
            }
           
            MessageBox.Show("ht");

        }

        Bitmap CropImage(Bitmap img, Rectangle cropRect)
        {
            Bitmap bitmap = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(img, new Rectangle(0, 0, bitmap.Width, bitmap.Height), cropRect, GraphicsUnit.Pixel);
            }
            return bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecFfmpegCommand(@"-i Nosub.mp4 -vf subtitles=EngSub.srt -c:v h264 -c:a copy video.mp4");
        }
    }
}
