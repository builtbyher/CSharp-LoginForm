namespace loginform_web_application
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1 (Login)
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.MediumBlue;
            button1.Location = new Point(615, 296);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(144, 72);
            button1.TabIndex = 0;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click); // ✅ Hooked up
            // 
            // button2 (Cancel)
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(767, 296);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(146, 72);
            button2.TabIndex = 1;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1 (Username)
            // 
            textBox1.Location = new Point(719, 78);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2 (Password)
            // 
            textBox2.Location = new Point(719, 146);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 39);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(471, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(478, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // checkBox1 (Show Password)
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(707, 205);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(206, 36);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1 (Forgot Password)
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Control;
            linkLabel1.ForeColor = Color.Indigo;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(723, 409);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(190, 32);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password";
            linkLabel1.VisitedLinkColor = Color.Purple;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 41);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 312);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Indigo;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "loginform";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
