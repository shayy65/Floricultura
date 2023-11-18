namespace Floricultura
{
    partial class CadastroClien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emailcliente = new System.Windows.Forms.TextBox();
            this.txt_enderecocliente = new System.Windows.Forms.TextBox();
            this.txt_nomecliente = new System.Windows.Forms.TextBox();
            this.txt_cpfcliente = new System.Windows.Forms.TextBox();
            this.txt_telefonecliente = new System.Windows.Forms.TextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(327, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(340, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(633, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(297, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(679, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 47);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cadastrar Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(663, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_emailcliente
            // 
            this.txt_emailcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_emailcliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailcliente.Location = new System.Drawing.Point(768, 326);
            this.txt_emailcliente.Name = "txt_emailcliente";
            this.txt_emailcliente.Size = new System.Drawing.Size(480, 39);
            this.txt_emailcliente.TabIndex = 10;
            this.txt_emailcliente.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_enderecocliente
            // 
            this.txt_enderecocliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_enderecocliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enderecocliente.Location = new System.Drawing.Point(768, 402);
            this.txt_enderecocliente.Name = "txt_enderecocliente";
            this.txt_enderecocliente.Size = new System.Drawing.Size(480, 39);
            this.txt_enderecocliente.TabIndex = 2;
            this.txt_enderecocliente.TextChanged += new System.EventHandler(this.txt_enderecocliente_TextChanged);
            // 
            // txt_nomecliente
            // 
            this.txt_nomecliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nomecliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecliente.Location = new System.Drawing.Point(420, 253);
            this.txt_nomecliente.Name = "txt_nomecliente";
            this.txt_nomecliente.Size = new System.Drawing.Size(828, 39);
            this.txt_nomecliente.TabIndex = 0;
            // 
            // txt_cpfcliente
            // 
            this.txt_cpfcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cpfcliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpfcliente.Location = new System.Drawing.Point(420, 326);
            this.txt_cpfcliente.Name = "txt_cpfcliente";
            this.txt_cpfcliente.Size = new System.Drawing.Size(208, 39);
            this.txt_cpfcliente.TabIndex = 1;
            // 
            // txt_telefonecliente
            // 
            this.txt_telefonecliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefonecliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefonecliente.Location = new System.Drawing.Point(420, 402);
            this.txt_telefonecliente.Name = "txt_telefonecliente";
            this.txt_telefonecliente.Size = new System.Drawing.Size(208, 39);
            this.txt_telefonecliente.TabIndex = 3;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_limpar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.ForeColor = System.Drawing.Color.Gray;
            this.bt_limpar.Location = new System.Drawing.Point(639, 478);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(154, 47);
            this.bt_limpar.TabIndex = 14;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.Gray;
            this.bt_cadastrar.Location = new System.Drawing.Point(845, 478);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(165, 47);
            this.bt_cadastrar.TabIndex = 15;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_voltar.BackColor = System.Drawing.Color.White;
            this.bt_voltar.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bt_voltar.Location = new System.Drawing.Point(420, 478);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(163, 47);
            this.bt_voltar.TabIndex = 33;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // CadastroClien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Floricultura.Properties.Resources.Rua_Alegre__123___Cidade_Brasileira_ola_grandesite_com_br__12__3456_7890_www_grandesite_com_br__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 603);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_emailcliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_telefonecliente);
            this.Controls.Add(this.txt_enderecocliente);
            this.Controls.Add(this.txt_cpfcliente);
            this.Controls.Add(this.txt_nomecliente);
            this.DoubleBuffered = true;
            this.Name = "CadastroClien";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CadastroClien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_emailcliente;
        private System.Windows.Forms.TextBox txt_enderecocliente;
        private System.Windows.Forms.TextBox txt_nomecliente;
        private System.Windows.Forms.TextBox txt_cpfcliente;
        private System.Windows.Forms.TextBox txt_telefonecliente;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_voltar;
    }
}