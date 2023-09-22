namespace As_racing_car_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.over = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.C4 = new System.Windows.Forms.PictureBox();
            this.C5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(65, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(147, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 71);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(147, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 105);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Location = new System.Drawing.Point(65, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 105);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Location = new System.Drawing.Point(147, 295);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 71);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox6.Location = new System.Drawing.Point(65, 295);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 71);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(95, 310);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(19, 39);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // A1
            // 
            this.A1.Image = ((System.Drawing.Image)(resources.GetObject("A1.Image")));
            this.A1.Location = new System.Drawing.Point(12, 161);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(21, 39);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 7;
            this.A1.TabStop = false;
            // 
            // A3
            // 
            this.A3.Image = ((System.Drawing.Image)(resources.GetObject("A3.Image")));
            this.A3.Location = new System.Drawing.Point(187, 161);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(25, 39);
            this.A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A3.TabIndex = 8;
            this.A3.TabStop = false;
            // 
            // A2
            // 
            this.A2.Image = ((System.Drawing.Image)(resources.GetObject("A2.Image")));
            this.A2.Location = new System.Drawing.Point(172, 35);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(19, 38);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 9;
            this.A2.TabStop = false;
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.White;
            this.over.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.over.Location = new System.Drawing.Point(30, 97);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(161, 32);
            this.over.TabIndex = 10;
            this.over.Text = "Game Over";
            this.over.UseWaitCursor = true;
            // 
            // C2
            // 
            this.C2.Image = ((System.Drawing.Image)(resources.GetObject("C2.Image")));
            this.C2.Location = new System.Drawing.Point(102, 181);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(21, 19);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2.TabIndex = 11;
            this.C2.TabStop = false;
            // 
            // C1
            // 
            this.C1.Image = ((System.Drawing.Image)(resources.GetObject("C1.Image")));
            this.C1.Location = new System.Drawing.Point(102, 239);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(21, 19);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1.TabIndex = 12;
            this.C1.TabStop = false;
            // 
            // C3
            // 
            this.C3.Image = ((System.Drawing.Image)(resources.GetObject("C3.Image")));
            this.C3.Location = new System.Drawing.Point(102, 132);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(21, 19);
            this.C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3.TabIndex = 13;
            this.C3.TabStop = false;
            // 
            // C4
            // 
            this.C4.Image = ((System.Drawing.Image)(resources.GetObject("C4.Image")));
            this.C4.Location = new System.Drawing.Point(102, 87);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(21, 19);
            this.C4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C4.TabIndex = 14;
            this.C4.TabStop = false;
            // 
            // C5
            // 
            this.C5.Image = ((System.Drawing.Image)(resources.GetObject("C5.Image")));
            this.C5.Location = new System.Drawing.Point(102, 35);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(21, 19);
            this.C5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C5.TabIndex = 15;
            this.C5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Coins=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(224, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.over);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Enabled = false;
            this.MaximumSize = new System.Drawing.Size(240, 400);
            this.MinimumSize = new System.Drawing.Size(240, 400);
            this.Name = "Form1";
            this.Text = "AS game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox A3;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.PictureBox C3;
        private System.Windows.Forms.PictureBox C4;
        private System.Windows.Forms.PictureBox C5;
        private System.Windows.Forms.Label label1;
    }
}

