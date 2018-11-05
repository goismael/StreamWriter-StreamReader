namespace WriteToDataFile
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
            this.Results = new System.Windows.Forms.TextBox();
            this.WriteDateToFile = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(60, 103);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(656, 184);
            this.Results.TabIndex = 0;
            // 
            // WriteDateToFile
            // 
            this.WriteDateToFile.Location = new System.Drawing.Point(104, 26);
            this.WriteDateToFile.Name = "WriteDateToFile";
            this.WriteDateToFile.Size = new System.Drawing.Size(174, 33);
            this.WriteDateToFile.TabIndex = 1;
            this.WriteDateToFile.Text = "Create File";
            this.WriteDateToFile.UseVisualStyleBackColor = true;
            this.WriteDateToFile.Click += new System.EventHandler(this.WriteDateToFile_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(495, 26);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(181, 33);
            this.ReadFile.TabIndex = 2;
            this.ReadFile.Text = "Read File";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(366, 336);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(130, 32);
            this.Btn_Clear.TabIndex = 3;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.WriteDateToFile);
            this.Controls.Add(this.Results);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Button WriteDateToFile;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button Btn_Clear;
    }
}

