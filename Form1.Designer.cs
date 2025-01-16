namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 329);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 424);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 39);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 417);
            label2.Name = "label2";
            label2.Size = new Size(189, 46);
            label2.TabIndex = 4;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 494);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 39);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 487);
            label3.Name = "label3";
            label3.Size = new Size(177, 46);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 569);
            label4.Name = "label4";
            label4.Size = new Size(495, 38);
            label4.TabIndex = 5;
            label4.Text = "Register if you dont have account ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 30, 69);
            button1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 623);
            button1.Name = "button1";
            button1.Size = new Size(198, 54);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(31, 30, 69);
            button2.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(309, 623);
            button2.Name = "button2";
            button2.Size = new Size(198, 54);
            button2.TabIndex = 8;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(31, 30, 68);
            iconPictureBox1.ForeColor = SystemColors.ControlLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconPictureBox1.IconColor = SystemColors.ControlLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 39;
            iconPictureBox1.Location = new Point(467, 494);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(39, 39);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(570, 732);
            Controls.Add(iconPictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
