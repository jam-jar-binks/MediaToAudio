
namespace VideoToAudio
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
            this.Video = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathVideo = new System.Windows.Forms.TextBox();
            this.txtPathAudio = new System.Windows.Forms.TextBox();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.outputFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.Location = new System.Drawing.Point(17, 12);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(66, 13);
            this.Video.TabIndex = 0;
            this.Video.Text = "Import Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save as";
            // 
            // txtPathVideo
            // 
            this.txtPathVideo.Location = new System.Drawing.Point(12, 35);
            this.txtPathVideo.Name = "txtPathVideo";
            this.txtPathVideo.Size = new System.Drawing.Size(354, 20);
            this.txtPathVideo.TabIndex = 2;
            // 
            // txtPathAudio
            // 
            this.txtPathAudio.Location = new System.Drawing.Point(12, 94);
            this.txtPathAudio.Name = "txtPathAudio";
            this.txtPathAudio.Size = new System.Drawing.Size(354, 20);
            this.txtPathAudio.TabIndex = 3;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Location = new System.Drawing.Point(89, 9);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(75, 20);
            this.btnOpenVideo.TabIndex = 4;
            this.btnOpenVideo.Text = "Choose...";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 135);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(354, 20);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // outputFormat
            // 
            this.outputFormat.FormattingEnabled = true;
            this.outputFormat.Items.AddRange(new object[] {
            "avi",
            "aiff",
            "codec2",
            "mov",
            "flac",
            "mp3",
            "ogg",
            "oga",
            "wav"});
            this.outputFormat.Location = new System.Drawing.Point(70, 67);
            this.outputFormat.Name = "outputFormat";
            this.outputFormat.Size = new System.Drawing.Size(130, 21);
            this.outputFormat.TabIndex = 7;
            this.outputFormat.SelectedIndexChanged += new System.EventHandler(this.outputFormat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Choose Path...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputFormat);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.txtPathAudio);
            this.Controls.Add(this.txtPathVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Video);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Video To Audio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Video;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathVideo;
        private System.Windows.Forms.TextBox txtPathAudio;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox outputFormat;
        private System.Windows.Forms.Button button1;
    }
}

