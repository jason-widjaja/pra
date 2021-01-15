
namespace Menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.makanan = new System.Windows.Forms.RadioButton();
            this.minuman = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size = new System.Windows.Forms.GroupBox();
            this.normal = new System.Windows.Forms.RadioButton();
            this.jumbo = new System.Windows.Forms.RadioButton();
            this.boxmakanan = new System.Windows.Forms.ListBox();
            this.boxharga = new System.Windows.Forms.ListBox();
            this.total = new System.Windows.Forms.Label();
            this.TotalHarga = new System.Windows.Forms.Label();
            this.abc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.size.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BU DEWI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEMS";
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(170, 394);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 27);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // makanan
            // 
            this.makanan.AutoSize = true;
            this.makanan.Checked = true;
            this.makanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makanan.Location = new System.Drawing.Point(6, 12);
            this.makanan.Name = "makanan";
            this.makanan.Size = new System.Drawing.Size(84, 21);
            this.makanan.TabIndex = 5;
            this.makanan.TabStop = true;
            this.makanan.Text = "Makanan";
            this.makanan.UseVisualStyleBackColor = true;
            this.makanan.CheckedChanged += new System.EventHandler(this.makanan_CheckedChanged);
            // 
            // minuman
            // 
            this.minuman.AutoSize = true;
            this.minuman.BackColor = System.Drawing.SystemColors.Control;
            this.minuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuman.Location = new System.Drawing.Point(111, 12);
            this.minuman.Name = "minuman";
            this.minuman.Size = new System.Drawing.Size(83, 21);
            this.minuman.TabIndex = 6;
            this.minuman.Text = "Minuman";
            this.minuman.UseVisualStyleBackColor = false;
            this.minuman.CheckedChanged += new System.EventHandler(this.minuman_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Menu";
            // 
            // menu
            // 
            this.menu.FormattingEnabled = true;
            this.menu.Items.AddRange(new object[] {
            "Nasi Goreng",
            "Nasi Goreng Spesial",
            "Ayam Bakar",
            "Nasi Goreng Pete"});
            this.menu.Location = new System.Drawing.Point(446, 173);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(121, 21);
            this.menu.TabIndex = 8;
            this.menu.Text = "Nasi Goreng";
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga :  Rp.";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.Location = new System.Drawing.Point(668, 174);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(48, 17);
            this.harga.TabIndex = 10;
            this.harga.Text = "10000";
            this.harga.Click += new System.EventHandler(this.harga_Click);
            // 
            // buy
            // 
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.Location = new System.Drawing.Point(446, 334);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(106, 35);
            this.buy.TabIndex = 12;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(621, 377);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(123, 44);
            this.check.TabIndex = 13;
            this.check.Text = "Check Out";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.makanan);
            this.groupBox1.Controls.Add(this.minuman);
            this.groupBox1.Location = new System.Drawing.Point(388, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 39);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.size.Controls.Add(this.jumbo);
            this.size.Controls.Add(this.normal);
            this.size.Location = new System.Drawing.Point(397, 238);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(200, 40);
            this.size.TabIndex = 16;
            this.size.TabStop = false;
            this.size.Text = "Size";
            this.size.Visible = false;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal.Location = new System.Drawing.Point(6, 17);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(71, 21);
            this.normal.TabIndex = 0;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // jumbo
            // 
            this.jumbo.AutoSize = true;
            this.jumbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumbo.Location = new System.Drawing.Point(102, 17);
            this.jumbo.Name = "jumbo";
            this.jumbo.Size = new System.Drawing.Size(68, 21);
            this.jumbo.TabIndex = 1;
            this.jumbo.Text = "Jumbo";
            this.jumbo.UseVisualStyleBackColor = true;
            this.jumbo.CheckedChanged += new System.EventHandler(this.jumbo_CheckedChanged);
            // 
            // boxmakanan
            // 
            this.boxmakanan.FormattingEnabled = true;
            this.boxmakanan.Location = new System.Drawing.Point(50, 99);
            this.boxmakanan.Name = "boxmakanan";
            this.boxmakanan.Size = new System.Drawing.Size(157, 264);
            this.boxmakanan.TabIndex = 17;
            this.boxmakanan.Tag = "asd";
            this.boxmakanan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // boxharga
            // 
            this.boxharga.FormattingEnabled = true;
            this.boxharga.Location = new System.Drawing.Point(213, 99);
            this.boxharga.Name = "boxharga";
            this.boxharga.Size = new System.Drawing.Size(93, 264);
            this.boxharga.TabIndex = 18;
            this.boxharga.SelectedIndexChanged += new System.EventHandler(this.boxharga_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(671, 301);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 19;
            this.total.Visible = false;
            // 
            // TotalHarga
            // 
            this.TotalHarga.AutoSize = true;
            this.TotalHarga.Location = new System.Drawing.Point(630, 321);
            this.TotalHarga.Name = "TotalHarga";
            this.TotalHarga.Size = new System.Drawing.Size(0, 13);
            this.TotalHarga.TabIndex = 20;
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Location = new System.Drawing.Point(678, 320);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(35, 13);
            this.abc.TabIndex = 21;
            this.abc.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.TotalHarga);
            this.Controls.Add(this.total);
            this.Controls.Add(this.boxharga);
            this.Controls.Add(this.boxmakanan);
            this.Controls.Add(this.size);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.size.ResumeLayout(false);
            this.size.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.RadioButton makanan;
        private System.Windows.Forms.RadioButton minuman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox size;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton jumbo;
        private System.Windows.Forms.ListBox boxmakanan;
        private System.Windows.Forms.ListBox boxharga;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label TotalHarga;
        private System.Windows.Forms.Label abc;
    }
}

