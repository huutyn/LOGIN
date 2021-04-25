
namespace LOGIN
{
    partial class LOGIN
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
            this.labelUsename = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsename = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.radioButtonLaocong = new System.Windows.Forms.RadioButton();
            this.radioButtonTieptan = new System.Windows.Forms.RadioButton();
            this.radioButtonQuanly = new System.Windows.Forms.RadioButton();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsename
            // 
            this.labelUsename.AutoSize = true;
            this.labelUsename.Location = new System.Drawing.Point(639, 213);
            this.labelUsename.Name = "labelUsename";
            this.labelUsename.Size = new System.Drawing.Size(68, 17);
            this.labelUsename.TabIndex = 0;
            this.labelUsename.Text = "Usename";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(639, 298);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsename
            // 
            this.textBoxUsename.Location = new System.Drawing.Point(727, 199);
            this.textBoxUsename.Multiline = true;
            this.textBoxUsename.Name = "textBoxUsename";
            this.textBoxUsename.Size = new System.Drawing.Size(236, 41);
            this.textBoxUsename.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(727, 285);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(236, 41);
            this.textBoxPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(823, 458);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 45);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // radioButtonLaocong
            // 
            this.radioButtonLaocong.AutoSize = true;
            this.radioButtonLaocong.Checked = true;
            this.radioButtonLaocong.Location = new System.Drawing.Point(13, 6);
            this.radioButtonLaocong.Name = "radioButtonLaocong";
            this.radioButtonLaocong.Size = new System.Drawing.Size(90, 21);
            this.radioButtonLaocong.TabIndex = 7;
            this.radioButtonLaocong.TabStop = true;
            this.radioButtonLaocong.Text = "Lao Công";
            this.radioButtonLaocong.UseVisualStyleBackColor = true;
            // 
            // radioButtonTieptan
            // 
            this.radioButtonTieptan.AutoSize = true;
            this.radioButtonTieptan.Location = new System.Drawing.Point(138, 6);
            this.radioButtonTieptan.Name = "radioButtonTieptan";
            this.radioButtonTieptan.Size = new System.Drawing.Size(86, 21);
            this.radioButtonTieptan.TabIndex = 8;
            this.radioButtonTieptan.TabStop = true;
            this.radioButtonTieptan.Text = "Tiếp Tân";
            this.radioButtonTieptan.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuanly
            // 
            this.radioButtonQuanly.AutoSize = true;
            this.radioButtonQuanly.Location = new System.Drawing.Point(268, 6);
            this.radioButtonQuanly.Name = "radioButtonQuanly";
            this.radioButtonQuanly.Size = new System.Drawing.Size(83, 21);
            this.radioButtonQuanly.TabIndex = 9;
            this.radioButtonQuanly.TabStop = true;
            this.radioButtonQuanly.Text = "Quản Lý";
            this.radioButtonQuanly.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLogin.Location = new System.Drawing.Point(389, 43);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(341, 84);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "LOGIN NOW";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGIN.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(47, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LOGIN.Properties.Resources.banner1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1039, 641);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonQuanly);
            this.panel1.Controls.Add(this.radioButtonTieptan);
            this.panel1.Controls.Add(this.radioButtonLaocong);
            this.panel1.Location = new System.Drawing.Point(629, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 35);
            this.panel1.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(656, 459);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 44);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 648);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsename);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsename);
            this.Controls.Add(this.pictureBox2);
            this.Name = "LOGIN";
            this.Text = "LOGIN FORM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsename;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUsename;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.RadioButton radioButtonLaocong;
        private System.Windows.Forms.RadioButton radioButtonTieptan;
        private System.Windows.Forms.RadioButton radioButtonQuanly;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
    }
}

