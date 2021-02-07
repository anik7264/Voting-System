namespace Project1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsertextBox1 = new System.Windows.Forms.TextBox();
            this.PasstextBox1 = new System.Windows.Forms.TextBox();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.LoginButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // UsertextBox1
            // 
            this.UsertextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsertextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertextBox1.Location = new System.Drawing.Point(189, 35);
            this.UsertextBox1.Name = "UsertextBox1";
            this.UsertextBox1.Size = new System.Drawing.Size(171, 29);
            this.UsertextBox1.TabIndex = 4;
            //this.UsertextBox1.TextChanged += new System.EventHandler(this.UsertextBox1_TextChanged);
            // 
            // PasstextBox1
            // 
            this.PasstextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasstextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasstextBox1.Location = new System.Drawing.Point(189, 96);
            this.PasstextBox1.Name = "PasstextBox1";
            this.PasstextBox1.PasswordChar = '*';
            this.PasstextBox1.Size = new System.Drawing.Size(171, 29);
            this.PasstextBox1.TabIndex = 5;
            // 
            // ExitButton1
            // 
            this.ExitButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton1.Location = new System.Drawing.Point(150, 154);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(82, 38);
            this.ExitButton1.TabIndex = 3;
            this.ExitButton1.Text = "Exit";
            this.ExitButton1.UseVisualStyleBackColor = false;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // LoginButton1
            // 
            this.LoginButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton1.Location = new System.Drawing.Point(271, 154);
            this.LoginButton1.Name = "LoginButton1";
            this.LoginButton1.Size = new System.Drawing.Size(91, 38);
            this.LoginButton1.TabIndex = 2;
            this.LoginButton1.Text = "Login";
            this.LoginButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton1.UseVisualStyleBackColor = false;
            this.LoginButton1.Click += new System.EventHandler(this.LoginButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(409, 237);
            this.Controls.Add(this.PasstextBox1);
            this.Controls.Add(this.UsertextBox1);
            this.Controls.Add(this.ExitButton1);
            this.Controls.Add(this.LoginButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Pannel";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton1;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.TextBox UsertextBox1;
        private System.Windows.Forms.TextBox PasstextBox1;
    }
}