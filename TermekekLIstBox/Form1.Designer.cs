namespace TermekekLIstBox
{
    partial class Form_Termek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Termek));
            this.listBox_Termekek = new System.Windows.Forms.ListBox();
            this.button1_Betoltes = new System.Windows.Forms.Button();
            this.button2_Mentes = new System.Windows.Forms.Button();
            this.button3_UjTermek = new System.Windows.Forms.Button();
            this.button4_Modosit = new System.Windows.Forms.Button();
            this.button5_Torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Termekek
            // 
            this.listBox_Termekek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Termekek.FormattingEnabled = true;
            this.listBox_Termekek.ItemHeight = 25;
            this.listBox_Termekek.Location = new System.Drawing.Point(0, 0);
            this.listBox_Termekek.Margin = new System.Windows.Forms.Padding(5);
            this.listBox_Termekek.Name = "listBox_Termekek";
            this.listBox_Termekek.Size = new System.Drawing.Size(594, 703);
            this.listBox_Termekek.TabIndex = 0;
            this.listBox_Termekek.SelectedIndexChanged += new System.EventHandler(this.listBox_Termekek_SelectedIndexChanged);
            // 
            // button1_Betoltes
            // 
            this.button1_Betoltes.Location = new System.Drawing.Point(776, 34);
            this.button1_Betoltes.Name = "button1_Betoltes";
            this.button1_Betoltes.Size = new System.Drawing.Size(309, 53);
            this.button1_Betoltes.TabIndex = 1;
            this.button1_Betoltes.Text = "Betöltés";
            this.button1_Betoltes.UseVisualStyleBackColor = true;
            this.button1_Betoltes.Click += new System.EventHandler(this.button1_Betoltes_Click);
            // 
            // button2_Mentes
            // 
            this.button2_Mentes.Location = new System.Drawing.Point(776, 93);
            this.button2_Mentes.Name = "button2_Mentes";
            this.button2_Mentes.Size = new System.Drawing.Size(309, 53);
            this.button2_Mentes.TabIndex = 2;
            this.button2_Mentes.Text = "Mentés";
            this.button2_Mentes.UseVisualStyleBackColor = true;
            this.button2_Mentes.Click += new System.EventHandler(this.button2_Mentes_Click);
            // 
            // button3_UjTermek
            // 
            this.button3_UjTermek.Location = new System.Drawing.Point(776, 198);
            this.button3_UjTermek.Name = "button3_UjTermek";
            this.button3_UjTermek.Size = new System.Drawing.Size(309, 53);
            this.button3_UjTermek.TabIndex = 3;
            this.button3_UjTermek.Text = "Új Termék";
            this.button3_UjTermek.UseVisualStyleBackColor = true;
            this.button3_UjTermek.Click += new System.EventHandler(this.button3_UjTermek_Click);
            // 
            // button4_Modosit
            // 
            this.button4_Modosit.Location = new System.Drawing.Point(776, 257);
            this.button4_Modosit.Name = "button4_Modosit";
            this.button4_Modosit.Size = new System.Drawing.Size(309, 53);
            this.button4_Modosit.TabIndex = 4;
            this.button4_Modosit.Text = "Módosítás";
            this.button4_Modosit.UseVisualStyleBackColor = true;
            this.button4_Modosit.Click += new System.EventHandler(this.button4_Modosit_Click);
            // 
            // button5_Torles
            // 
            this.button5_Torles.Location = new System.Drawing.Point(776, 316);
            this.button5_Torles.Name = "button5_Torles";
            this.button5_Torles.Size = new System.Drawing.Size(309, 53);
            this.button5_Torles.TabIndex = 5;
            this.button5_Torles.Text = "Törlés";
            this.button5_Torles.UseVisualStyleBackColor = true;
            this.button5_Torles.Click += new System.EventHandler(this.button5_Torles_Click);
            // 
            // Form_Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.button5_Torles);
            this.Controls.Add(this.button4_Modosit);
            this.Controls.Add(this.button3_UjTermek);
            this.Controls.Add(this.button2_Mentes);
            this.Controls.Add(this.button1_Betoltes);
            this.Controls.Add(this.listBox_Termekek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Termek";
            this.Text = "Termékek";
            this.Load += new System.EventHandler(this.Form_Termek_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_Betoltes;
        private System.Windows.Forms.Button button2_Mentes;
        private System.Windows.Forms.Button button3_UjTermek;
        private System.Windows.Forms.Button button4_Modosit;
        private System.Windows.Forms.Button button5_Torles;
        public System.Windows.Forms.ListBox listBox_Termekek;
    }
}

