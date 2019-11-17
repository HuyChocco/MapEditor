namespace MapEditor
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
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTileName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbX = new System.Windows.Forms.Label();
			this.lbY = new System.Windows.Forms.Label();
			this.lbW = new System.Windows.Forms.Label();
			this.lbH = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(783, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Load Tiles Set";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.vScrollBar2);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(631, 530);
			this.panel1.TabIndex = 2;
			this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
			// 
			// vScrollBar2
			// 
			this.vScrollBar2.Location = new System.Drawing.Point(606, 0);
			this.vScrollBar2.Name = "vScrollBar2";
			this.vScrollBar2.Size = new System.Drawing.Size(23, 511);
			this.vScrollBar2.TabIndex = 1;
			this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(1, 511);
			this.hScrollBar1.Maximum = 2000;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(628, 17);
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
			this.vScrollBar1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(783, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "16";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(784, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Size";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(784, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tile Size";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(783, 101);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "16";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(783, 261);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 7;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(783, 424);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(100, 100);
			this.panel2.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(783, 296);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 28);
			this.button3.TabIndex = 9;
			this.button3.Text = "Load Background";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(783, 352);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "160";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(783, 336);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Opacity";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(783, 388);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(100, 30);
			this.btnGenerate.TabIndex = 12;
			this.btnGenerate.Text = "Generate Tiles";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(783, 140);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 20);
			this.txtID.TabIndex = 5;
			this.txtID.Text = "1";
			this.txtID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(784, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "ID";
			// 
			// txtTileName
			// 
			this.txtTileName.Location = new System.Drawing.Point(783, 193);
			this.txtTileName.Name = "txtTileName";
			this.txtTileName.Size = new System.Drawing.Size(100, 20);
			this.txtTileName.TabIndex = 5;
			this.txtTileName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(784, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Tile Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(667, 423);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(12, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "y";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(667, 388);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(12, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "x";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(667, 464);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Width";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(667, 500);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "Heigh";
			// 
			// lbX
			// 
			this.lbX.AutoSize = true;
			this.lbX.Location = new System.Drawing.Point(706, 388);
			this.lbX.Name = "lbX";
			this.lbX.Size = new System.Drawing.Size(22, 13);
			this.lbX.TabIndex = 15;
			this.lbX.Text = "lbX";
			// 
			// lbY
			// 
			this.lbY.AutoSize = true;
			this.lbY.Location = new System.Drawing.Point(706, 423);
			this.lbY.Name = "lbY";
			this.lbY.Size = new System.Drawing.Size(22, 13);
			this.lbY.TabIndex = 15;
			this.lbY.Text = "lbY";
			// 
			// lbW
			// 
			this.lbW.AutoSize = true;
			this.lbW.Location = new System.Drawing.Point(708, 464);
			this.lbW.Name = "lbW";
			this.lbW.Size = new System.Drawing.Size(26, 13);
			this.lbW.TabIndex = 15;
			this.lbW.Text = "lbW";
			// 
			// lbH
			// 
			this.lbH.AutoSize = true;
			this.lbH.Location = new System.Drawing.Point(708, 500);
			this.lbH.Name = "lbH";
			this.lbH.Size = new System.Drawing.Size(23, 13);
			this.lbH.TabIndex = 15;
			this.lbH.Text = "lbH";
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(666, 232);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(100, 20);
			this.txtWidth.TabIndex = 5;
			this.txtWidth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(667, 216);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Width";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(783, 232);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(100, 20);
			this.txtHeight.TabIndex = 5;
			this.txtHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(784, 216);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 13);
			this.label11.TabIndex = 6;
			this.label11.Text = "Height";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(666, 301);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(100, 20);
			this.txtLocation.TabIndex = 5;
			this.txtLocation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(667, 285);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Location path";
			this.label12.Click += new System.EventHandler(this.label10_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 542);
			this.Controls.Add(this.lbH);
			this.Controls.Add(this.lbW);
			this.Controls.Add(this.lbY);
			this.Controls.Add(this.lbX);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTileName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.VScrollBar vScrollBar2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTileName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbX;
		private System.Windows.Forms.Label lbY;
		private System.Windows.Forms.Label lbW;
		private System.Windows.Forms.Label lbH;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.Label label12;
	}
}

