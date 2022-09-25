namespace AS2223_4G_INF_BunardziuVehap_RubricaCSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_File = new System.Windows.Forms.Button();
            this.TXT_File = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File CSV rubrica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_File
            // 
            this.BTN_File.Location = new System.Drawing.Point(663, 34);
            this.BTN_File.Name = "BTN_File";
            this.BTN_File.Size = new System.Drawing.Size(75, 23);
            this.BTN_File.TabIndex = 1;
            this.BTN_File.Text = "button1";
            this.BTN_File.UseVisualStyleBackColor = true;
            this.BTN_File.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_File
            // 
            this.TXT_File.Location = new System.Drawing.Point(117, 34);
            this.TXT_File.Name = "TXT_File";
            this.TXT_File.Size = new System.Drawing.Size(540, 23);
            this.TXT_File.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXT_File);
            this.Controls.Add(this.BTN_File);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BTN_File;
        private TextBox TXT_File;
    }
}