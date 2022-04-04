
namespace Odstevalnik
{
    partial class Casovnik
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
            this.components = new System.ComponentModel.Container();
            this.Ponastavi_gumb = new System.Windows.Forms.Button();
            this.Ustavi_gumb = new System.Windows.Forms.Button();
            this.Zacni_gumb = new System.Windows.Forms.Button();
            this.cas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Ponastavi_gumb
            // 
            this.Ponastavi_gumb.Location = new System.Drawing.Point(59, 340);
            this.Ponastavi_gumb.Name = "Ponastavi_gumb";
            this.Ponastavi_gumb.Size = new System.Drawing.Size(201, 68);
            this.Ponastavi_gumb.TabIndex = 0;
            this.Ponastavi_gumb.Text = "Ponastavi";
            this.Ponastavi_gumb.UseVisualStyleBackColor = true;
            this.Ponastavi_gumb.Click += new System.EventHandler(this.Ponastavi_gumb_Click);
            // 
            // Ustavi_gumb
            // 
            this.Ustavi_gumb.Location = new System.Drawing.Point(299, 340);
            this.Ustavi_gumb.Name = "Ustavi_gumb";
            this.Ustavi_gumb.Size = new System.Drawing.Size(201, 68);
            this.Ustavi_gumb.TabIndex = 1;
            this.Ustavi_gumb.Text = "Ustavi";
            this.Ustavi_gumb.UseVisualStyleBackColor = true;
            this.Ustavi_gumb.Click += new System.EventHandler(this.Ustavi_gumb_Click);
            // 
            // Zacni_gumb
            // 
            this.Zacni_gumb.Location = new System.Drawing.Point(537, 340);
            this.Zacni_gumb.Name = "Zacni_gumb";
            this.Zacni_gumb.Size = new System.Drawing.Size(201, 68);
            this.Zacni_gumb.TabIndex = 2;
            this.Zacni_gumb.Text = "Začni";
            this.Zacni_gumb.UseVisualStyleBackColor = true;
            this.Zacni_gumb.Click += new System.EventHandler(this.button3_Click);
            // 
            // cas
            // 
            this.cas.AutoSize = true;
            this.cas.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cas.Location = new System.Drawing.Point(350, 97);
            this.cas.Name = "cas";
            this.cas.Size = new System.Drawing.Size(103, 119);
            this.cas.TabIndex = 3;
            this.cas.Text = "9";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Casovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cas);
            this.Controls.Add(this.Zacni_gumb);
            this.Controls.Add(this.Ustavi_gumb);
            this.Controls.Add(this.Ponastavi_gumb);
            this.Name = "Casovnik";
            this.Text = "Časovnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ponastavi_gumb;
        private System.Windows.Forms.Button Ustavi_gumb;
        private System.Windows.Forms.Button Zacni_gumb;
        private System.Windows.Forms.Label cas;
        private System.Windows.Forms.Timer timer1;
    }
}

