namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.buttom_slideshow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Next.Location = new System.Drawing.Point(409, 360);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 1;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_previous.Location = new System.Drawing.Point(103, 360);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(75, 23);
            this.button_previous.TabIndex = 2;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Exit.Location = new System.Drawing.Point(253, 418);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // buttom_slideshow
            // 
            this.buttom_slideshow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttom_slideshow.Location = new System.Drawing.Point(253, 360);
            this.buttom_slideshow.Name = "buttom_slideshow";
            this.buttom_slideshow.Size = new System.Drawing.Size(75, 23);
            this.buttom_slideshow.TabIndex = 4;
            this.buttom_slideshow.Text = "SlideShow";
            this.buttom_slideshow.UseVisualStyleBackColor = false;
            this.buttom_slideshow.Click += new System.EventHandler(this.buttom_slideshow_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_stop.Location = new System.Drawing.Point(253, 389);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 5;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 462);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.buttom_slideshow);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Gallary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button buttom_slideshow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_stop;
    }
}

