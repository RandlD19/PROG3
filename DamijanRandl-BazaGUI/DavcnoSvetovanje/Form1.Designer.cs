
namespace DavcnoSvetovanje
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
            this.dodajNarocnika_label = new System.Windows.Forms.Label();
            this.listaNarocnikov_label = new System.Windows.Forms.Label();
            this.ime_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ime_textBox = new System.Windows.Forms.TextBox();
            this.priimek_label = new System.Windows.Forms.Label();
            this.priimek_textBox = new System.Windows.Forms.TextBox();
            this.dodaj_gumb = new System.Windows.Forms.Button();
            this.osvezi_gumb = new System.Windows.Forms.Button();
            this.narocniki_listBox = new System.Windows.Forms.ListBox();
            this.naslov_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.davcna_testBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dodajNarocnika_label
            // 
            this.dodajNarocnika_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajNarocnika_label.Location = new System.Drawing.Point(33, 67);
            this.dodajNarocnika_label.Name = "dodajNarocnika_label";
            this.dodajNarocnika_label.Size = new System.Drawing.Size(387, 64);
            this.dodajNarocnika_label.TabIndex = 0;
            this.dodajNarocnika_label.Text = "Dodaj naročnika";
            // 
            // listaNarocnikov_label
            // 
            this.listaNarocnikov_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaNarocnikov_label.Location = new System.Drawing.Point(492, 67);
            this.listaNarocnikov_label.Name = "listaNarocnikov_label";
            this.listaNarocnikov_label.Size = new System.Drawing.Size(387, 64);
            this.listaNarocnikov_label.TabIndex = 1;
            this.listaNarocnikov_label.Text = "Lista naročnikov";
            // 
            // ime_label
            // 
            this.ime_label.AutoSize = true;
            this.ime_label.Location = new System.Drawing.Point(49, 142);
            this.ime_label.Name = "ime_label";
            this.ime_label.Size = new System.Drawing.Size(52, 25);
            this.ime_label.TabIndex = 2;
            this.ime_label.Text = "Ime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 31);
            this.textBox1.TabIndex = 3;
            // 
            // ime_textBox
            // 
            this.ime_textBox.Location = new System.Drawing.Point(54, 170);
            this.ime_textBox.Name = "ime_textBox";
            this.ime_textBox.Size = new System.Drawing.Size(330, 31);
            this.ime_textBox.TabIndex = 4;
            // 
            // priimek_label
            // 
            this.priimek_label.AutoSize = true;
            this.priimek_label.Location = new System.Drawing.Point(49, 212);
            this.priimek_label.Name = "priimek_label";
            this.priimek_label.Size = new System.Drawing.Size(89, 25);
            this.priimek_label.TabIndex = 5;
            this.priimek_label.Text = "Priimek:";
            // 
            // priimek_textBox
            // 
            this.priimek_textBox.Location = new System.Drawing.Point(54, 240);
            this.priimek_textBox.Name = "priimek_textBox";
            this.priimek_textBox.Size = new System.Drawing.Size(330, 31);
            this.priimek_textBox.TabIndex = 6;
            // 
            // dodaj_gumb
            // 
            this.dodaj_gumb.Location = new System.Drawing.Point(54, 596);
            this.dodaj_gumb.Name = "dodaj_gumb";
            this.dodaj_gumb.Size = new System.Drawing.Size(213, 45);
            this.dodaj_gumb.TabIndex = 7;
            this.dodaj_gumb.Text = "Dodaj!";
            this.dodaj_gumb.UseVisualStyleBackColor = true;
            this.dodaj_gumb.Click += new System.EventHandler(this.dodaj_gumb_Click);
            // 
            // osvezi_gumb
            // 
            this.osvezi_gumb.Location = new System.Drawing.Point(54, 657);
            this.osvezi_gumb.Name = "osvezi_gumb";
            this.osvezi_gumb.Size = new System.Drawing.Size(213, 45);
            this.osvezi_gumb.TabIndex = 8;
            this.osvezi_gumb.Text = "Osveži podatke";
            this.osvezi_gumb.UseVisualStyleBackColor = true;
            this.osvezi_gumb.Click += new System.EventHandler(this.osvezi_gumb_Click);
            // 
            // narocniki_listBox
            // 
            this.narocniki_listBox.FormattingEnabled = true;
            this.narocniki_listBox.ItemHeight = 25;
            this.narocniki_listBox.Location = new System.Drawing.Point(505, 175);
            this.narocniki_listBox.Name = "narocniki_listBox";
            this.narocniki_listBox.Size = new System.Drawing.Size(354, 579);
            this.narocniki_listBox.TabIndex = 9;
            // 
            // naslov_textBox
            // 
            this.naslov_textBox.Location = new System.Drawing.Point(54, 388);
            this.naslov_textBox.Name = "naslov_textBox";
            this.naslov_textBox.Size = new System.Drawing.Size(330, 31);
            this.naslov_textBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naslov:";
            // 
            // davcna_testBox
            // 
            this.davcna_testBox.Location = new System.Drawing.Point(54, 314);
            this.davcna_testBox.Name = "davcna_testBox";
            this.davcna_testBox.Size = new System.Drawing.Size(330, 31);
            this.davcna_testBox.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(294, 298);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 31);
            this.textBox5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Davčna številka:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status:";
            // 
            // status_comboBox
            // 
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.status_comboBox.Location = new System.Drawing.Point(54, 476);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(110, 33);
            this.status_comboBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 796);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.naslov_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.davcna_testBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.narocniki_listBox);
            this.Controls.Add(this.osvezi_gumb);
            this.Controls.Add(this.dodaj_gumb);
            this.Controls.Add(this.priimek_textBox);
            this.Controls.Add(this.priimek_label);
            this.Controls.Add(this.ime_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ime_label);
            this.Controls.Add(this.listaNarocnikov_label);
            this.Controls.Add(this.dodajNarocnika_label);
            this.Name = "Form1";
            this.Text = "Davčno svetovanje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dodajNarocnika_label;
        private System.Windows.Forms.Label listaNarocnikov_label;
        private System.Windows.Forms.Label ime_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ime_textBox;
        private System.Windows.Forms.Label priimek_label;
        private System.Windows.Forms.TextBox priimek_textBox;
        private System.Windows.Forms.Button dodaj_gumb;
        private System.Windows.Forms.Button osvezi_gumb;
        private System.Windows.Forms.ListBox narocniki_listBox;
        private System.Windows.Forms.TextBox naslov_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox davcna_testBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox status_comboBox;
    }
}

