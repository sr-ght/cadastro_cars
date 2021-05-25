
namespace Cadastro
{
    partial class Consulta
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
            this.comboBusca = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBusca = new System.Windows.Forms.GroupBox();
            this.boxObs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelMarc = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelDV = new System.Windows.Forms.Label();
            this.boxEnd = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDC = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxCpf = new System.Windows.Forms.TextBox();
            this.boxPlaca = new System.Windows.Forms.TextBox();
            this.boxMarc = new System.Windows.Forms.TextBox();
            this.boxModel = new System.Windows.Forms.TextBox();
            this.boxCor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buscaPlaca = new System.Windows.Forms.MaskedTextBox();
            this.buscaName = new System.Windows.Forms.TextBox();
            this.groupBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar por:";
            // 
            // comboBusca
            // 
            this.comboBusca.FormattingEnabled = true;
            this.comboBusca.Items.AddRange(new object[] {
            "PLACA",
            "NOME",
            "MODELO",
            "MARCA"});
            this.comboBusca.Location = new System.Drawing.Point(12, 48);
            this.comboBusca.Name = "comboBusca";
            this.comboBusca.Size = new System.Drawing.Size(271, 21);
            this.comboBusca.TabIndex = 1;
            this.comboBusca.SelectedIndexChanged += new System.EventHandler(this.comboBusca_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(289, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBusca
            // 
            this.groupBusca.BackColor = System.Drawing.Color.White;
            this.groupBusca.Controls.Add(this.boxCor);
            this.groupBusca.Controls.Add(this.boxModel);
            this.groupBusca.Controls.Add(this.boxMarc);
            this.groupBusca.Controls.Add(this.boxPlaca);
            this.groupBusca.Controls.Add(this.boxCpf);
            this.groupBusca.Controls.Add(this.labelDC);
            this.groupBusca.Controls.Add(this.boxObs);
            this.groupBusca.Controls.Add(this.boxName);
            this.groupBusca.Controls.Add(this.labelNome);
            this.groupBusca.Controls.Add(this.labelCpf);
            this.groupBusca.Controls.Add(this.label9);
            this.groupBusca.Controls.Add(this.label8);
            this.groupBusca.Controls.Add(this.labelEnd);
            this.groupBusca.Controls.Add(this.labelModel);
            this.groupBusca.Controls.Add(this.boxEnd);
            this.groupBusca.Controls.Add(this.labelDV);
            this.groupBusca.Controls.Add(this.labelMarc);
            this.groupBusca.Controls.Add(this.labelPlaca);
            this.groupBusca.Location = new System.Drawing.Point(12, 101);
            this.groupBusca.Name = "groupBusca";
            this.groupBusca.Size = new System.Drawing.Size(340, 337);
            this.groupBusca.TabIndex = 3;
            this.groupBusca.TabStop = false;
            // 
            // boxObs
            // 
            this.boxObs.BackColor = System.Drawing.Color.White;
            this.boxObs.Enabled = false;
            this.boxObs.ForeColor = System.Drawing.Color.Black;
            this.boxObs.Location = new System.Drawing.Point(100, 271);
            this.boxObs.Name = "boxObs";
            this.boxObs.Size = new System.Drawing.Size(217, 20);
            this.boxObs.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "OBS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "COR:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(18, 219);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(56, 13);
            this.labelModel.TabIndex = 47;
            this.labelModel.Text = "MODELO:";
            // 
            // labelMarc
            // 
            this.labelMarc.AutoSize = true;
            this.labelMarc.Location = new System.Drawing.Point(18, 192);
            this.labelMarc.Name = "labelMarc";
            this.labelMarc.Size = new System.Drawing.Size(48, 13);
            this.labelMarc.TabIndex = 45;
            this.labelMarc.Text = "MARCA:";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(18, 166);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(44, 13);
            this.labelPlaca.TabIndex = 44;
            this.labelPlaca.Text = "PLACA:";
            // 
            // labelDV
            // 
            this.labelDV.AutoSize = true;
            this.labelDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelDV.Location = new System.Drawing.Point(6, 135);
            this.labelDV.Name = "labelDV";
            this.labelDV.Size = new System.Drawing.Size(139, 16);
            this.labelDV.TabIndex = 43;
            this.labelDV.Text = "DADOS DO VEÍCULO";
            // 
            // boxEnd
            // 
            this.boxEnd.BackColor = System.Drawing.Color.White;
            this.boxEnd.Enabled = false;
            this.boxEnd.Location = new System.Drawing.Point(100, 95);
            this.boxEnd.Name = "boxEnd";
            this.boxEnd.Size = new System.Drawing.Size(217, 20);
            this.boxEnd.TabIndex = 42;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(18, 98);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(70, 13);
            this.labelEnd.TabIndex = 37;
            this.labelEnd.Text = "ENDEREÇO:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(18, 72);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 40;
            this.labelCpf.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(18, 46);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 13);
            this.labelNome.TabIndex = 39;
            this.labelNome.Text = "NOME:";
            // 
            // labelDC
            // 
            this.labelDC.AutoSize = true;
            this.labelDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelDC.Location = new System.Drawing.Point(6, 16);
            this.labelDC.Name = "labelDC";
            this.labelDC.Size = new System.Drawing.Size(138, 16);
            this.labelDC.TabIndex = 38;
            this.labelDC.Text = "DADOS DO CLIENTE";
            // 
            // boxName
            // 
            this.boxName.BackColor = System.Drawing.Color.White;
            this.boxName.Enabled = false;
            this.boxName.Location = new System.Drawing.Point(100, 43);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(217, 20);
            this.boxName.TabIndex = 36;
            // 
            // boxCpf
            // 
            this.boxCpf.BackColor = System.Drawing.Color.White;
            this.boxCpf.Enabled = false;
            this.boxCpf.Location = new System.Drawing.Point(100, 69);
            this.boxCpf.Name = "boxCpf";
            this.boxCpf.Size = new System.Drawing.Size(83, 20);
            this.boxCpf.TabIndex = 54;
            // 
            // boxPlaca
            // 
            this.boxPlaca.BackColor = System.Drawing.Color.White;
            this.boxPlaca.Enabled = false;
            this.boxPlaca.Location = new System.Drawing.Point(100, 163);
            this.boxPlaca.Name = "boxPlaca";
            this.boxPlaca.Size = new System.Drawing.Size(55, 20);
            this.boxPlaca.TabIndex = 55;
            // 
            // boxMarc
            // 
            this.boxMarc.BackColor = System.Drawing.Color.White;
            this.boxMarc.Enabled = false;
            this.boxMarc.Location = new System.Drawing.Point(100, 189);
            this.boxMarc.Name = "boxMarc";
            this.boxMarc.Size = new System.Drawing.Size(217, 20);
            this.boxMarc.TabIndex = 56;
            // 
            // boxModel
            // 
            this.boxModel.BackColor = System.Drawing.Color.White;
            this.boxModel.Enabled = false;
            this.boxModel.Location = new System.Drawing.Point(100, 216);
            this.boxModel.Name = "boxModel";
            this.boxModel.Size = new System.Drawing.Size(217, 20);
            this.boxModel.TabIndex = 57;
            // 
            // boxCor
            // 
            this.boxCor.BackColor = System.Drawing.Color.White;
            this.boxCor.Enabled = false;
            this.boxCor.Location = new System.Drawing.Point(100, 243);
            this.boxCor.Name = "boxCor";
            this.boxCor.Size = new System.Drawing.Size(217, 20);
            this.boxCor.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Consulta de Veículo";
            // 
            // buscaPlaca
            // 
            this.buscaPlaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscaPlaca.Location = new System.Drawing.Point(12, 75);
            this.buscaPlaca.Mask = "LLL-0000";
            this.buscaPlaca.Name = "buscaPlaca";
            this.buscaPlaca.Size = new System.Drawing.Size(55, 20);
            this.buscaPlaca.TabIndex = 60;
            this.buscaPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buscaName
            // 
            this.buscaName.BackColor = System.Drawing.Color.White;
            this.buscaName.Location = new System.Drawing.Point(12, 75);
            this.buscaName.Name = "buscaName";
            this.buscaName.Size = new System.Drawing.Size(217, 20);
            this.buscaName.TabIndex = 59;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.buscaName);
            this.Controls.Add(this.buscaPlaca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBusca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Consulta";
            this.Text = "Veículo | Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.groupBusca.ResumeLayout(false);
            this.groupBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBusca;
        private System.Windows.Forms.Label labelDC;
        private System.Windows.Forms.TextBox boxObs;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox boxEnd;
        private System.Windows.Forms.Label labelDV;
        private System.Windows.Forms.Label labelMarc;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.TextBox boxCor;
        private System.Windows.Forms.TextBox boxModel;
        private System.Windows.Forms.TextBox boxMarc;
        private System.Windows.Forms.TextBox boxPlaca;
        private System.Windows.Forms.TextBox boxCpf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox buscaPlaca;
        private System.Windows.Forms.TextBox buscaName;
    }
}