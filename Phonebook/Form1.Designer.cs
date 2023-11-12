namespace Phonebook
{
    partial class Phonebook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_job = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_udaje = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tb_prefix);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_job);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.tb_surname);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(38, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 265);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phonebook.Properties.Resources.phone;
            this.pictureBox1.InitialImage = global::Phonebook.Properties.Resources.phone;
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(414, 108);
            this.tb_prefix.Multiline = true;
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(73, 38);
            this.tb_prefix.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(300, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Funkce:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(300, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(300, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(300, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Příjmení:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(300, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jméno:";
            // 
            // tb_job
            // 
            this.tb_job.Location = new System.Drawing.Point(414, 196);
            this.tb_job.Multiline = true;
            this.tb_job.Name = "tb_job";
            this.tb_job.Size = new System.Drawing.Size(249, 38);
            this.tb_job.TabIndex = 6;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(414, 152);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(249, 38);
            this.tb_email.TabIndex = 5;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(493, 108);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(170, 38);
            this.tb_phone.TabIndex = 4;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(414, 64);
            this.tb_surname.Multiline = true;
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(249, 38);
            this.tb_surname.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(414, 20);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(249, 38);
            this.tb_name.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.Location = new System.Drawing.Point(826, 182);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(180, 59);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Přidat";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Location = new System.Drawing.Point(826, 97);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 59);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Odstranit";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.Location = new System.Drawing.Point(826, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 59);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Ulož tabulku";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_udaje
            // 
            this.lb_udaje.FormattingEnabled = true;
            this.lb_udaje.ItemHeight = 16;
            this.lb_udaje.Location = new System.Drawing.Point(38, 342);
            this.lb_udaje.Name = "lb_udaje";
            this.lb_udaje.Size = new System.Drawing.Size(1029, 388);
            this.lb_udaje.TabIndex = 10;
            this.lb_udaje.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 775);
            this.Controls.Add(this.lb_udaje);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1112, 822);
            this.MinimumSize = new System.Drawing.Size(1112, 822);
            this.Name = "Phonebook";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_job;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lb_udaje;
    }
}

