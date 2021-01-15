
namespace Menu
{
    partial class Form2
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
            this.cekdiskon = new System.Windows.Forms.CheckBox();
            this.labeldiskon = new System.Windows.Forms.Label();
            this.inputdiskon = new System.Windows.Forms.TextBox();
            this.persen = new System.Windows.Forms.Label();
            this.hitung = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hargatotal = new System.Windows.Forms.Label();
            this.pajak = new System.Windows.Forms.Label();
            this.diskon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cekdiskon
            // 
            this.cekdiskon.AutoSize = true;
            this.cekdiskon.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cekdiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekdiskon.Location = new System.Drawing.Point(34, 32);
            this.cekdiskon.Name = "cekdiskon";
            this.cekdiskon.Size = new System.Drawing.Size(82, 21);
            this.cekdiskon.TabIndex = 1;
            this.cekdiskon.Text = "Discount";
            this.cekdiskon.UseVisualStyleBackColor = true;
            this.cekdiskon.CheckedChanged += new System.EventHandler(this.cekdiskon_CheckedChanged);
            // 
            // labeldiskon
            // 
            this.labeldiskon.AutoSize = true;
            this.labeldiskon.Location = new System.Drawing.Point(31, 69);
            this.labeldiskon.Name = "labeldiskon";
            this.labeldiskon.Size = new System.Drawing.Size(31, 13);
            this.labeldiskon.TabIndex = 2;
            this.labeldiskon.Text = "Input";
            this.labeldiskon.Visible = false;
            // 
            // inputdiskon
            // 
            this.inputdiskon.Location = new System.Drawing.Point(68, 66);
            this.inputdiskon.Name = "inputdiskon";
            this.inputdiskon.Size = new System.Drawing.Size(100, 20);
            this.inputdiskon.TabIndex = 3;
            this.inputdiskon.Visible = false;
            this.inputdiskon.WordWrap = false;
            // 
            // persen
            // 
            this.persen.AutoSize = true;
            this.persen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persen.Location = new System.Drawing.Point(174, 69);
            this.persen.Name = "persen";
            this.persen.Size = new System.Drawing.Size(20, 17);
            this.persen.TabIndex = 4;
            this.persen.Text = "%";
            this.persen.Visible = false;
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(79, 118);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(75, 23);
            this.hitung.TabIndex = 5;
            this.hitung.Text = "Calculate";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtotal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // hargatotal
            // 
            this.hargatotal.AutoSize = true;
            this.hargatotal.Location = new System.Drawing.Point(361, 66);
            this.hargatotal.Name = "hargatotal";
            this.hargatotal.Size = new System.Drawing.Size(16, 13);
            this.hargatotal.TabIndex = 10;
            this.hargatotal.Text = "...";
            this.hargatotal.Click += new System.EventHandler(this.hargatotal_Click);
            // 
            // pajak
            // 
            this.pajak.AutoSize = true;
            this.pajak.Location = new System.Drawing.Point(361, 91);
            this.pajak.Name = "pajak";
            this.pajak.Size = new System.Drawing.Size(16, 13);
            this.pajak.TabIndex = 11;
            this.pajak.Text = "...";
            // 
            // diskon
            // 
            this.diskon.AutoSize = true;
            this.diskon.Location = new System.Drawing.Point(361, 118);
            this.diskon.Name = "diskon";
            this.diskon.Size = new System.Drawing.Size(13, 13);
            this.diskon.TabIndex = 12;
            this.diskon.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.diskon);
            this.Controls.Add(this.pajak);
            this.Controls.Add(this.hargatotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.persen);
            this.Controls.Add(this.inputdiskon);
            this.Controls.Add(this.labeldiskon);
            this.Controls.Add(this.cekdiskon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cekdiskon;
        private System.Windows.Forms.Label labeldiskon;
        private System.Windows.Forms.TextBox inputdiskon;
        private System.Windows.Forms.Label persen;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hargatotal;
        private System.Windows.Forms.Label pajak;
        private System.Windows.Forms.Label diskon;
    }
}