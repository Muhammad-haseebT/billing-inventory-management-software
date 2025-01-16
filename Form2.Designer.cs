namespace WinFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 30, 69);
            button1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(44, 648);
            button1.Name = "button1";
            button1.Size = new Size(198, 54);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 566);
            label4.Name = "label4";
            label4.Size = new Size(529, 38);
            label4.TabIndex = 14;
            label4.Text = "Login if you already have an account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 484);
            label3.Name = "label3";
            label3.Size = new Size(177, 46);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 414);
            label2.Name = "label2";
            label2.Size = new Size(189, 46);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(208, 491);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 39);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(208, 421);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 39);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 326);
            label1.Name = "label1";
            label1.Size = new Size(156, 46);
            label1.TabIndex = 9;
            label1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(31, 30, 69);
            button2.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(330, 648);
            button2.Name = "button2";
            button2.Size = new Size(198, 54);
            button2.TabIndex = 17;
            button2.Text = "Register";
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
            iconPictureBox1.Location = new Point(450, 491);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(39, 39);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 18;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            ForeColor = SystemColors.ControlLight;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}