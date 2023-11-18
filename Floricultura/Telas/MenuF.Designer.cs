namespace Floricultura
{
    partial class MenuF
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(189, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(189, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(407, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Venda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(189, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(407, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cadastrar produto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button4.Location = new System.Drawing.Point(189, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(407, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cadastrar Funcionário";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_voltar.BackColor = System.Drawing.Color.White;
            this.bt_voltar.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bt_voltar.Location = new System.Drawing.Point(345, 464);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(124, 53);
            this.bt_voltar.TabIndex = 4;
            this.bt_voltar.Text = "Sair";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // MenuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Floricultura.Properties.Resources.Rua_Alegre__123___Cidade_Brasileira_ola_grandesite_com_br__12__3456_7890_www_grandesite_com_br__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "MenuF";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_voltar;
    }
}