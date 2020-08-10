namespace Team_Phenomenon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bill1 = new Team_Phenomenon.Bill();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userControl31 = new Team_Phenomenon.UserControl3();
            this.userControl12 = new Team_Phenomenon.UserControl1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 731);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Location = new System.Drawing.Point(1, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 74);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(5, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 51);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-5, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-3, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "          ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 49);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.bill1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.userControl31);
            this.panel2.Controls.Add(this.userControl12);
            this.panel2.Location = new System.Drawing.Point(120, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 762);
            this.panel2.TabIndex = 1;
            // 
            // bill1
            // 
            this.bill1.Location = new System.Drawing.Point(0, 40);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(1173, 689);
            this.bill1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Location = new System.Drawing.Point(0, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1176, 78);
            this.panel5.TabIndex = 2;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.DimGray;
            this.userControl31.Location = new System.Drawing.Point(25, 52);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1128, 677);
            this.userControl31.TabIndex = 1;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load_1);
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.Gray;
            this.userControl12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userControl12.Location = new System.Drawing.Point(25, 52);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(1128, 665);
            this.userControl12.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 54);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1293, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private UserControl1 userControl11;
        private UserControl3 userControl31;
        private UserControl1 userControl12;
        private System.Windows.Forms.Panel panel5;
        private Bill bill1;
    }
}

