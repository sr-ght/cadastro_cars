
namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSobre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedIdade = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEnd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.datNome = new System.Windows.Forms.TextBox();
            this.datSobre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // maskedCpf
            // 
            this.maskedCpf.Location = new System.Drawing.Point(73, 97);
            this.maskedCpf.Mask = "000.000.000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.Size = new System.Drawing.Size(83, 20);
            this.maskedCpf.TabIndex = 3;
            this.maskedCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(73, 35);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(130, 20);
            this.textNome.TabIndex = 5;
            this.textNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome";
            // 
            // textSobre
            // 
            this.textSobre.Location = new System.Drawing.Point(73, 63);
            this.textSobre.Name = "textSobre";
            this.textSobre.Size = new System.Drawing.Size(130, 20);
            this.textSobre.TabIndex = 7;
            this.textSobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "idade";
            // 
            // maskedIdade
            // 
            this.maskedIdade.Location = new System.Drawing.Point(73, 130);
            this.maskedIdade.Mask = "000";
            this.maskedIdade.Name = "maskedIdade";
            this.maskedIdade.Size = new System.Drawing.Size(30, 20);
            this.maskedIdade.TabIndex = 10;
            this.maskedIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Endereço";
            // 
            // textEnd
            // 
            this.textEnd.Location = new System.Drawing.Point(73, 160);
            this.textEnd.Name = "textEnd";
            this.textEnd.Size = new System.Drawing.Size(130, 20);
            this.textEnd.TabIndex = 13;
            this.textEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(73, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(73, 6);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(130, 20);
            this.textUser.TabIndex = 15;
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(320, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datNome
            // 
            this.datNome.Location = new System.Drawing.Point(303, 66);
            this.datNome.Name = "datNome";
            this.datNome.Size = new System.Drawing.Size(130, 20);
            this.datNome.TabIndex = 17;
            this.datNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datSobre
            // 
            this.datSobre.Location = new System.Drawing.Point(303, 100);
            this.datSobre.Name = "datSobre";
            this.datSobre.Size = new System.Drawing.Size(130, 20);
            this.datSobre.TabIndex = 18;
            this.datSobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 377);
            this.Controls.Add(this.datSobre);
            this.Controls.Add(this.datNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSobre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedCpf);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedCpf;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSobre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedIdade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox datNome;
        private System.Windows.Forms.TextBox datSobre;
    }
}

