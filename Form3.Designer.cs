namespace WinFormsApp2
{
    partial class Form3
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            sell1 = new sell();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 20.25F);
            iconButton1.ForeColor = SystemColors.HighlightText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(10);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(249, 81);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Dashboard";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 20.25F);
            iconButton2.ForeColor = SystemColors.HighlightText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 81);
            iconButton2.Margin = new Padding(10);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(249, 84);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Products";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 20.25F);
            iconButton3.ForeColor = SystemColors.HighlightText;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 165);
            iconButton3.Margin = new Padding(10);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(249, 85);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Orders";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 20.25F);
            iconButton4.ForeColor = SystemColors.HighlightText;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 250);
            iconButton4.Margin = new Padding(10);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 20, 0);
            iconButton4.Size = new Size(249, 78);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Sell";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 20.25F);
            iconButton5.ForeColor = SystemColors.HighlightText;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 328);
            iconButton5.Margin = new Padding(10);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 20, 0);
            iconButton5.Size = new Size(249, 78);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "Logout";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(iconButton5);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 682);
            panel1.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.FromArgb(31, 30, 80);
            userControl11.Location = new Point(243, 0);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(864, 679);
            userControl11.TabIndex = 1;
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.FromArgb(38, 32, 80);
            userControl21.Dock = DockStyle.Fill;
            userControl21.Location = new Point(249, 0);
            userControl21.Name = "userControl21";
            userControl21.Padding = new Padding(20);
            userControl21.Size = new Size(859, 682);
            userControl21.TabIndex = 6;
            // 
            // sell1
            // 
            sell1.BackColor = Color.FromArgb(38, 32, 80);
            sell1.Location = new Point(249, 3);
            sell1.Name = "sell1";
            sell1.Size = new Size(859, 679);
            sell1.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 682);
            Controls.Add(sell1);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form36";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel panel1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private sell sell1;
    }
}