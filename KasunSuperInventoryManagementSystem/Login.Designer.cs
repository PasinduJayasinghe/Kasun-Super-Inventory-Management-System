namespace KasunSuperInventoryManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            passwordtextBox = new TextBox();
            userNametextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 469);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passwordtextBox);
            panel1.Controls.Add(userNametextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(563, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 469);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 46);
            label3.Name = "label3";
            label3.Size = new Size(353, 25);
            label3.TabIndex = 2;
            label3.Text = "Please Enter Your User Name and Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(191, 317);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(240, 233);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PasswordChar = '*';
            passwordtextBox.Size = new Size(150, 31);
            passwordtextBox.TabIndex = 3;
            // 
            // userNametextBox
            // 
            userNametextBox.Location = new Point(240, 122);
            userNametextBox.Name = "userNametextBox";
            userNametextBox.Size = new Size(150, 31);
            userNametextBox.TabIndex = 2;
            userNametextBox.TextChanged += userNametextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 233);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 122);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1081, 603);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private TextBox passwordtextBox;
        private TextBox userNametextBox;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
