namespace Project1
{
    partial class step2
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
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.ResultsButton2 = new System.Windows.Forms.Button();
            this.PollingButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton2
            // 
            this.ExitButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton2.Location = new System.Drawing.Point(181, 209);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(74, 41);
            this.ExitButton2.TabIndex = 2;
            this.ExitButton2.Text = "Exit";
            this.ExitButton2.UseVisualStyleBackColor = false;
            this.ExitButton2.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // ResultsButton2
            // 
            this.ResultsButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultsButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsButton2.Location = new System.Drawing.Point(251, 24);
            this.ResultsButton2.Name = "ResultsButton2";
            this.ResultsButton2.Size = new System.Drawing.Size(138, 132);
            this.ResultsButton2.TabIndex = 1;
            this.ResultsButton2.Text = "Results";
            this.ResultsButton2.UseVisualStyleBackColor = false;
            this.ResultsButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PollingButton2
            // 
            this.PollingButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PollingButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PollingButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PollingButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PollingButton2.Location = new System.Drawing.Point(56, 24);
            this.PollingButton2.Name = "PollingButton2";
            this.PollingButton2.Size = new System.Drawing.Size(140, 132);
            this.PollingButton2.TabIndex = 0;
            this.PollingButton2.Text = "Polling Vote";
            this.PollingButton2.UseVisualStyleBackColor = false;
            this.PollingButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(443, 290);
            this.Controls.Add(this.ExitButton2);
            this.Controls.Add(this.ResultsButton2);
            this.Controls.Add(this.PollingButton2);
            this.Name = "step2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting Matchien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PollingButton2;
        private System.Windows.Forms.Button ResultsButton2;
        private System.Windows.Forms.Button ExitButton2;
    }
}