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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TXT_Cognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Visualizza = new System.Windows.Forms.Button();
            this.LST_Elenco = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            // 
            // BTN_File
            // 
            this.BTN_File.Location = new System.Drawing.Point(663, 34);
            this.BTN_File.Name = "BTN_File";
            this.BTN_File.Size = new System.Drawing.Size(75, 23);
            this.BTN_File.TabIndex = 1;
            this.BTN_File.Text = "...";
            this.BTN_File.UseVisualStyleBackColor = true;
            this.BTN_File.Click += new System.EventHandler(this.BTN_File_Click);
            // 
            // TXT_File
            // 
            this.TXT_File.Location = new System.Drawing.Point(117, 34);
            this.TXT_File.Name = "TXT_File";
            this.TXT_File.Size = new System.Drawing.Size(540, 23);
            this.TXT_File.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TXT_Cognome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(69, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtri di Ricerca";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contiene",
            "Inizia",
            "Finisce"});
            this.comboBox1.Location = new System.Drawing.Point(515, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // TXT_Cognome
            // 
            this.TXT_Cognome.Location = new System.Drawing.Point(83, 36);
            this.TXT_Cognome.Name = "TXT_Cognome";
            this.TXT_Cognome.Size = new System.Drawing.Size(426, 23);
            this.TXT_Cognome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cognome";
            // 
            // BTN_Visualizza
            // 
            this.BTN_Visualizza.Location = new System.Drawing.Point(345, 193);
            this.BTN_Visualizza.Name = "BTN_Visualizza";
            this.BTN_Visualizza.Size = new System.Drawing.Size(75, 23);
            this.BTN_Visualizza.TabIndex = 4;
            this.BTN_Visualizza.Text = "Visualizza";
            this.BTN_Visualizza.UseVisualStyleBackColor = true;
            // 
            // LST_Elenco
            // 
            this.LST_Elenco.Location = new System.Drawing.Point(22, 242);
            this.LST_Elenco.Multiline = true;
            this.LST_Elenco.Name = "LST_Elenco";
            this.LST_Elenco.Size = new System.Drawing.Size(716, 196);
            this.LST_Elenco.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.LST_Elenco);
            this.Controls.Add(this.BTN_Visualizza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXT_File);
            this.Controls.Add(this.BTN_File);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BTN_File;
        private TextBox TXT_File;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox TXT_Cognome;
        private Label label2;
        private Button BTN_Visualizza;
        private TextBox LST_Elenco;
    }
}