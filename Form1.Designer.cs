namespace Krasains_Ekrans
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
            this.butBalts = new System.Windows.Forms.Button();
            this.butMelns = new System.Windows.Forms.Button();
            this.butZals = new System.Windows.Forms.Button();
            this.butZils = new System.Windows.Forms.Button();
            this.butRoza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(179, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klikšķini uz pogas, lai mainītu fona krāsu ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butBalts
            // 
            this.butBalts.BackColor = System.Drawing.SystemColors.Info;
            this.butBalts.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBalts.Location = new System.Drawing.Point(30, 189);
            this.butBalts.Name = "butBalts";
            this.butBalts.Size = new System.Drawing.Size(132, 57);
            this.butBalts.TabIndex = 1;
            this.butBalts.Text = "Balts";
            this.butBalts.UseVisualStyleBackColor = false;
            this.butBalts.Click += new System.EventHandler(this.butBalts_Click);
            // 
            // butMelns
            // 
            this.butMelns.BackColor = System.Drawing.SystemColors.Info;
            this.butMelns.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMelns.Location = new System.Drawing.Point(297, 189);
            this.butMelns.Name = "butMelns";
            this.butMelns.Size = new System.Drawing.Size(132, 57);
            this.butMelns.TabIndex = 2;
            this.butMelns.Text = "Melns";
            this.butMelns.UseVisualStyleBackColor = false;
            this.butMelns.Click += new System.EventHandler(this.butMelns_Click);
            // 
            // butZals
            // 
            this.butZals.BackColor = System.Drawing.SystemColors.Info;
            this.butZals.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butZals.Location = new System.Drawing.Point(562, 189);
            this.butZals.Name = "butZals";
            this.butZals.Size = new System.Drawing.Size(132, 57);
            this.butZals.TabIndex = 3;
            this.butZals.Text = "Zaļš";
            this.butZals.UseVisualStyleBackColor = false;
            this.butZals.Click += new System.EventHandler(this.butZals_Click);
            // 
            // butZils
            // 
            this.butZils.BackColor = System.Drawing.SystemColors.Info;
            this.butZils.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butZils.Location = new System.Drawing.Point(159, 329);
            this.butZils.Name = "butZils";
            this.butZils.Size = new System.Drawing.Size(132, 57);
            this.butZils.TabIndex = 4;
            this.butZils.Text = "Zils";
            this.butZils.UseVisualStyleBackColor = false;
            this.butZils.Click += new System.EventHandler(this.butZils_Click);
            // 
            // butRoza
            // 
            this.butRoza.BackColor = System.Drawing.SystemColors.Info;
            this.butRoza.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRoza.Location = new System.Drawing.Point(454, 329);
            this.butRoza.Name = "butRoza";
            this.butRoza.Size = new System.Drawing.Size(132, 57);
            this.butRoza.TabIndex = 5;
            this.butRoza.Text = "Rozā";
            this.butRoza.UseVisualStyleBackColor = false;
            this.butRoza.Click += new System.EventHandler(this.butRoza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.butRoza);
            this.Controls.Add(this.butZils);
            this.Controls.Add(this.butZals);
            this.Controls.Add(this.butMelns);
            this.Controls.Add(this.butBalts);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Krāsains Ekrāns";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butBalts;
        private System.Windows.Forms.Button butMelns;
        private System.Windows.Forms.Button butZals;
        private System.Windows.Forms.Button butZils;
        private System.Windows.Forms.Button butRoza;
    }
}

