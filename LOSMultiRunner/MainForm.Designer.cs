namespace LOSMultiRunner
{
    partial class MainForm
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
            this.LOSDir = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.CleanUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOSDir
            // 
            this.LOSDir.Enabled = false;
            this.LOSDir.Location = new System.Drawing.Point(12, 12);
            this.LOSDir.Name = "LOSDir";
            this.LOSDir.Size = new System.Drawing.Size(420, 20);
            this.LOSDir.TabIndex = 0;
            this.LOSDir.Text = (string)Properties.Settings.Default["LOSDir"];
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(12, 38);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(100, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(119, 38);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(100, 23);
            this.Run.TabIndex = 2;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(226, 38);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CleanUp
            // 
            this.CleanUp.Location = new System.Drawing.Point(333, 38);
            this.CleanUp.Name = "CleanUp";
            this.CleanUp.Size = new System.Drawing.Size(100, 23);
            this.CleanUp.TabIndex = 4;
            this.CleanUp.Text = "CleanUp";
            this.CleanUp.UseVisualStyleBackColor = true;
            this.CleanUp.Click += new System.EventHandler(this.CleanUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 70);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.CleanUp);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.LOSDir);
            this.Name = "MainForm";
            this.Text = "LOSMultiRunner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LOSDir;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button CleanUp;
    }
}

