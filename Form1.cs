using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoToAudio
{
    public partial class Form1 : Form
    {
        string videoPath, videoName, audioPath, audioName, audioFormat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                audioPath = folderBrowserDialog.SelectedPath;
                audioName = videoName.Substring(0, videoName.Length - 4);
                audioPath += ("\\" + audioName + "." + audioFormat);
            }
            txtPathAudio.Text = audioPath;
        }

        private void outputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

            audioFormat = outputFormat.SelectedItem.ToString();
            if (audioPath == null)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    audioPath = folderBrowserDialog.SelectedPath;
                    audioName = videoName.Substring(0, videoName.Length - 4);
                    audioPath += ("\\" + audioName + "." + audioFormat);
                }
                
            }
            else
            {
                int index = audioPath.LastIndexOf(".");
                if(index > 0)
                {
                    audioPath = audioPath.Substring(0, index);
                }
                audioName = videoName.Substring(0, videoName.Length - 4);
                audioPath += ("." + audioFormat);
            }
            txtPathAudio.Text = audioPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }
            txtPathVideo.Text = videoPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();
            convert.ConvertMedia(txtPathVideo.Text.Trim(), txtPathAudio.Text.Trim(), audioFormat);
        }

    }
}
