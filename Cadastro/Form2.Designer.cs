
namespace Cadastro
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
            this.boxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedPlaca = new System.Windows.Forms.MaskedTextBox();
            this.boxObs = new System.Windows.Forms.TextBox();
            this.comboCor = new System.Windows.Forms.ComboBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboMarc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.concluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(100, 43);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(217, 20);
            this.boxName.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.maskedPlaca);
            this.groupBox1.Controls.Add(this.boxObs);
            this.groupBox1.Controls.Add(this.comboCor);
            this.groupBox1.Controls.Add(this.comboModel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboMarc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelPlaca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boxEnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedCpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 312);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // maskedPlaca
            // 
            this.maskedPlaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maskedPlaca.Location = new System.Drawing.Point(100, 163);
            this.maskedPlaca.Mask = "LLL-0000";
            this.maskedPlaca.Name = "maskedPlaca";
            this.maskedPlaca.Size = new System.Drawing.Size(55, 20);
            this.maskedPlaca.TabIndex = 35;
            this.maskedPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxObs
            // 
            this.boxObs.BackColor = System.Drawing.Color.White;
            this.boxObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxObs.ForeColor = System.Drawing.Color.Black;
            this.boxObs.Location = new System.Drawing.Point(100, 271);
            this.boxObs.Name = "boxObs";
            this.boxObs.Size = new System.Drawing.Size(217, 20);
            this.boxObs.TabIndex = 34;
            // 
            // comboCor
            // 
            this.comboCor.FormattingEnabled = true;
            this.comboCor.Items.AddRange(new object[] {
            "VERMELHO",
            "PRETO",
            "BRANCO"});
            this.comboCor.Location = new System.Drawing.Point(100, 243);
            this.comboCor.Name = "comboCor";
            this.comboCor.Size = new System.Drawing.Size(217, 21);
            this.comboCor.TabIndex = 33;
            this.comboCor.SelectedIndexChanged += new System.EventHandler(this.comboCor_SelectedIndexChanged);
            // 
            // comboModel
            // 
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(100, 216);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(217, 21);
            this.comboModel.TabIndex = 32;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "OBS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "COR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "MODELO:";
            // 
            // comboMarc
            // 
            this.comboMarc.BackColor = System.Drawing.Color.White;
            this.comboMarc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMarc.FormattingEnabled = true;
            this.comboMarc.Items.AddRange(new object[] {
            "AUDI",
            "CHEVROLET",
            "FERRARI",
            "FORD",
            "HONDA",
            "LAMBORGUINI",
            "TOYOTA"});
            this.comboMarc.Location = new System.Drawing.Point(100, 189);
            this.comboMarc.Name = "comboMarc";
            this.comboMarc.Size = new System.Drawing.Size(217, 21);
            this.comboMarc.TabIndex = 28;
            this.comboMarc.SelectedIndexChanged += new System.EventHandler(this.comboMarc_SelectedIndexChanged);
            this.comboMarc.SelectedValueChanged += new System.EventHandler(this.comboMarc_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "MARCA:";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(18, 166);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(44, 13);
            this.labelPlaca.TabIndex = 25;
            this.labelPlaca.Text = "PLACA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "DADOS DO VEÍCULO";
            // 
            // boxEnd
            // 
            this.boxEnd.Location = new System.Drawing.Point(100, 95);
            this.boxEnd.Name = "boxEnd";
            this.boxEnd.Size = new System.Drawing.Size(217, 20);
            this.boxEnd.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ENDEREÇO:";
            // 
            // maskedCpf
            // 
            this.maskedCpf.Location = new System.Drawing.Point(100, 69);
            this.maskedCpf.Mask = "000.000.000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.Size = new System.Drawing.Size(83, 20);
            this.maskedCpf.TabIndex = 22;
            this.maskedCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(18, 46);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 13);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "NOME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "DADOS DO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cadastro de Veículos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(366, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 257);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cadastro.Properties.Resources._24800_1;
            this.pictureBox2.Location = new System.Drawing.Point(6, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 239);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // concluir
            // 
            this.concluir.BackColor = System.Drawing.Color.White;
            this.concluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.concluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.concluir.Location = new System.Drawing.Point(628, 331);
            this.concluir.Name = "concluir";
            this.concluir.Size = new System.Drawing.Size(100, 23);
            this.concluir.TabIndex = 26;
            this.concluir.Text = "CONCLUIR";
            this.concluir.UseVisualStyleBackColor = false;
            this.concluir.Click += new System.EventHandler(this.concluir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(522, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(740, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.concluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Cadastro de Veículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.MaskedTextBox maskedCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button concluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.TextBox boxObs;
        private System.Windows.Forms.ComboBox comboCor;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboMarc;
        private System.Windows.Forms.MaskedTextBox maskedPlaca;
    }
}