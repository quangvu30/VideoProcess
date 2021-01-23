namespace VideoProcessing
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.ofdInputFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdOutputFloder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnChooseOutputFloder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.btnMergeIntoVideo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "intput:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(209, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(305, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(209, 78);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(305, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "type:";
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            ".avi",
            ".mp4",
            ".flv"});
            this.cbbType.Location = new System.Drawing.Point(466, 160);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(65, 21);
            this.cbbType.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(86, 187);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(117, 51);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "EctractToImage";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ofdInputFile
            // 
            this.ofdInputFile.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(553, 31);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.Text = "choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnChooseOutputFloder
            // 
            this.btnChooseOutputFloder.Location = new System.Drawing.Point(553, 78);
            this.btnChooseOutputFloder.Name = "btnChooseOutputFloder";
            this.btnChooseOutputFloder.Size = new System.Drawing.Size(75, 23);
            this.btnChooseOutputFloder.TabIndex = 4;
            this.btnChooseOutputFloder.Text = "output floder";
            this.btnChooseOutputFloder.UseVisualStyleBackColor = true;
            this.btnChooseOutputFloder.Click += new System.EventHandler(this.btnChooseOutputFloder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "film name:";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(209, 123);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(305, 20);
            this.txtImageName.TabIndex = 1;
            // 
            // btnMergeIntoVideo
            // 
            this.btnMergeIntoVideo.Location = new System.Drawing.Point(414, 188);
            this.btnMergeIntoVideo.Name = "btnMergeIntoVideo";
            this.btnMergeIntoVideo.Size = new System.Drawing.Size(117, 50);
            this.btnMergeIntoVideo.TabIndex = 5;
            this.btnMergeIntoVideo.Text = "merge into video";
            this.btnMergeIntoVideo.UseVisualStyleBackColor = true;
            this.btnMergeIntoVideo.Click += new System.EventHandler(this.btnMergeIntoVideo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "crop image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Subtitle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 385);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMergeIntoVideo);
            this.Controls.Add(this.btnChooseOutputFloder);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.OpenFileDialog ofdInputFile;
        private System.Windows.Forms.FolderBrowserDialog fbdOutputFloder;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnChooseOutputFloder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Button btnMergeIntoVideo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

