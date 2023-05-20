namespace App_Busca_CEP_Desktop.View.Modules
{
    partial class form_endereco_pelo_cep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_endereco_pelo_cep));
            this.lbl_cep = new System.Windows.Forms.Label();
            this.msktxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.grpbox_endereco = new System.Windows.Forms.GroupBox();
            this.pn_dados = new System.Windows.Forms.Panel();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_titulo_pais = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_titulo_estado = new System.Windows.Forms.TextBox();
            this.txt_codigo_ibge = new System.Windows.Forms.TextBox();
            this.txt_titulo_codigo_municipal_ibge = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_titulo_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_titulo_bairro = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_titulo_tipo = new System.Windows.Forms.TextBox();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.txt_titulo_logradouro = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.grpbox_endereco.SuspendLayout();
            this.pn_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cep.ForeColor = System.Drawing.Color.White;
            this.lbl_cep.Location = new System.Drawing.Point(12, 12);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(200, 32);
            this.lbl_cep.TabIndex = 25;
            this.lbl_cep.Text = "Digite um CEP:";
            // 
            // msktxt_cep
            // 
            this.msktxt_cep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msktxt_cep.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msktxt_cep.Location = new System.Drawing.Point(218, 12);
            this.msktxt_cep.Mask = "##,###-###";
            this.msktxt_cep.Name = "msktxt_cep";
            this.msktxt_cep.Size = new System.Drawing.Size(415, 32);
            this.msktxt_cep.TabIndex = 27;
            // 
            // grpbox_endereco
            // 
            this.grpbox_endereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_endereco.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_endereco.Controls.Add(this.pn_dados);
            this.grpbox_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbox_endereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpbox_endereco.Location = new System.Drawing.Point(12, 62);
            this.grpbox_endereco.Name = "grpbox_endereco";
            this.grpbox_endereco.Padding = new System.Windows.Forms.Padding(10);
            this.grpbox_endereco.Size = new System.Drawing.Size(621, 396);
            this.grpbox_endereco.TabIndex = 28;
            this.grpbox_endereco.TabStop = false;
            // 
            // pn_dados
            // 
            this.pn_dados.AutoScroll = true;
            this.pn_dados.BackColor = System.Drawing.Color.Black;
            this.pn_dados.Controls.Add(this.txt_pais);
            this.pn_dados.Controls.Add(this.txt_titulo_pais);
            this.pn_dados.Controls.Add(this.txt_estado);
            this.pn_dados.Controls.Add(this.txt_titulo_estado);
            this.pn_dados.Controls.Add(this.txt_codigo_ibge);
            this.pn_dados.Controls.Add(this.txt_titulo_codigo_municipal_ibge);
            this.pn_dados.Controls.Add(this.txt_cidade);
            this.pn_dados.Controls.Add(this.txt_titulo_cidade);
            this.pn_dados.Controls.Add(this.txt_bairro);
            this.pn_dados.Controls.Add(this.txt_titulo_bairro);
            this.pn_dados.Controls.Add(this.txt_tipo);
            this.pn_dados.Controls.Add(this.txt_titulo_tipo);
            this.pn_dados.Controls.Add(this.txt_logradouro);
            this.pn_dados.Controls.Add(this.txt_titulo_logradouro);
            this.pn_dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dados.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pn_dados.Location = new System.Drawing.Point(10, 24);
            this.pn_dados.Name = "pn_dados";
            this.pn_dados.Size = new System.Drawing.Size(601, 362);
            this.pn_dados.TabIndex = 1;
            // 
            // txt_pais
            // 
            this.txt_pais.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_pais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pais.ForeColor = System.Drawing.Color.Black;
            this.txt_pais.Location = new System.Drawing.Point(0, 366);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.ReadOnly = true;
            this.txt_pais.Size = new System.Drawing.Size(584, 26);
            this.txt_pais.TabIndex = 35;
            this.txt_pais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_pais
            // 
            this.txt_titulo_pais.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_pais.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_pais.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_pais.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_pais.Location = new System.Drawing.Point(0, 336);
            this.txt_titulo_pais.Name = "txt_titulo_pais";
            this.txt_titulo_pais.ReadOnly = true;
            this.txt_titulo_pais.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_pais.TabIndex = 34;
            this.txt_titulo_pais.Text = "País:";
            this.txt_titulo_pais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_estado
            // 
            this.txt_estado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_estado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_estado.ForeColor = System.Drawing.Color.Black;
            this.txt_estado.Location = new System.Drawing.Point(0, 310);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(584, 26);
            this.txt_estado.TabIndex = 7;
            this.txt_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_estado
            // 
            this.txt_titulo_estado.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_estado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_estado.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_estado.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_estado.Location = new System.Drawing.Point(0, 280);
            this.txt_titulo_estado.Name = "txt_titulo_estado";
            this.txt_titulo_estado.ReadOnly = true;
            this.txt_titulo_estado.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_estado.TabIndex = 6;
            this.txt_titulo_estado.Text = "Unidade Federal (Estado):";
            this.txt_titulo_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_codigo_ibge
            // 
            this.txt_codigo_ibge.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_codigo_ibge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_codigo_ibge.ForeColor = System.Drawing.Color.Black;
            this.txt_codigo_ibge.Location = new System.Drawing.Point(0, 254);
            this.txt_codigo_ibge.Name = "txt_codigo_ibge";
            this.txt_codigo_ibge.ReadOnly = true;
            this.txt_codigo_ibge.Size = new System.Drawing.Size(584, 26);
            this.txt_codigo_ibge.TabIndex = 5;
            this.txt_codigo_ibge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_codigo_municipal_ibge
            // 
            this.txt_titulo_codigo_municipal_ibge.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_codigo_municipal_ibge.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_codigo_municipal_ibge.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_codigo_municipal_ibge.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_codigo_municipal_ibge.Location = new System.Drawing.Point(0, 224);
            this.txt_titulo_codigo_municipal_ibge.Name = "txt_titulo_codigo_municipal_ibge";
            this.txt_titulo_codigo_municipal_ibge.ReadOnly = true;
            this.txt_titulo_codigo_municipal_ibge.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_codigo_municipal_ibge.TabIndex = 4;
            this.txt_titulo_codigo_municipal_ibge.Text = "Código Municipal - IBGE:";
            this.txt_titulo_codigo_municipal_ibge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cidade.ForeColor = System.Drawing.Color.Black;
            this.txt_cidade.Location = new System.Drawing.Point(0, 198);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(584, 26);
            this.txt_cidade.TabIndex = 9;
            this.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_cidade
            // 
            this.txt_titulo_cidade.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_cidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_cidade.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_cidade.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_cidade.Location = new System.Drawing.Point(0, 168);
            this.txt_titulo_cidade.Name = "txt_titulo_cidade";
            this.txt_titulo_cidade.ReadOnly = true;
            this.txt_titulo_cidade.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_cidade.TabIndex = 8;
            this.txt_titulo_cidade.Text = "Cidade:";
            this.txt_titulo_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bairro.ForeColor = System.Drawing.Color.Black;
            this.txt_bairro.Location = new System.Drawing.Point(0, 142);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.ReadOnly = true;
            this.txt_bairro.Size = new System.Drawing.Size(584, 26);
            this.txt_bairro.TabIndex = 33;
            this.txt_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_bairro
            // 
            this.txt_titulo_bairro.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_bairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_bairro.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_bairro.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_bairro.Location = new System.Drawing.Point(0, 112);
            this.txt_titulo_bairro.Name = "txt_titulo_bairro";
            this.txt_titulo_bairro.ReadOnly = true;
            this.txt_titulo_bairro.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_bairro.TabIndex = 32;
            this.txt_titulo_bairro.Text = "Bairro:";
            this.txt_titulo_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_tipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tipo.ForeColor = System.Drawing.Color.Black;
            this.txt_tipo.Location = new System.Drawing.Point(0, 86);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(584, 26);
            this.txt_tipo.TabIndex = 3;
            this.txt_tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_tipo
            // 
            this.txt_titulo_tipo.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_tipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_tipo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_tipo.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_tipo.Location = new System.Drawing.Point(0, 56);
            this.txt_titulo_tipo.Name = "txt_titulo_tipo";
            this.txt_titulo_tipo.ReadOnly = true;
            this.txt_titulo_tipo.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_tipo.TabIndex = 2;
            this.txt_titulo_tipo.Text = "Tipo:";
            this.txt_titulo_tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_logradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_logradouro.ForeColor = System.Drawing.Color.Black;
            this.txt_logradouro.Location = new System.Drawing.Point(0, 30);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.ReadOnly = true;
            this.txt_logradouro.Size = new System.Drawing.Size(584, 26);
            this.txt_logradouro.TabIndex = 1;
            this.txt_logradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_titulo_logradouro
            // 
            this.txt_titulo_logradouro.BackColor = System.Drawing.Color.Black;
            this.txt_titulo_logradouro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo_logradouro.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_titulo_logradouro.ForeColor = System.Drawing.Color.White;
            this.txt_titulo_logradouro.Location = new System.Drawing.Point(0, 0);
            this.txt_titulo_logradouro.Name = "txt_titulo_logradouro";
            this.txt_titulo_logradouro.ReadOnly = true;
            this.txt_titulo_logradouro.Size = new System.Drawing.Size(584, 30);
            this.txt_titulo_logradouro.TabIndex = 0;
            this.txt_titulo_logradouro.Text = "Logradouro:";
            this.txt_titulo_logradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(427, 475);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 35);
            this.btn_limpar.TabIndex = 31;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.Location = new System.Drawing.Point(533, 475);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 35);
            this.btn_buscar.TabIndex = 30;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fechar.FlatAppearance.BorderSize = 2;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.Location = new System.Drawing.Point(12, 475);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 35);
            this.btn_fechar.TabIndex = 29;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // form_endereco_pelo_cep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(645, 522);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.grpbox_endereco);
            this.Controls.Add(this.msktxt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(661, 561);
            this.Name = "form_endereco_pelo_cep";
            this.Load += new System.EventHandler(this.form_endereco_pelo_cep_Load);
            this.grpbox_endereco.ResumeLayout(false);
            this.pn_dados.ResumeLayout(false);
            this.pn_dados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_cep;
        private MaskedTextBox msktxt_cep;
        private GroupBox grpbox_endereco;
        private Panel pn_dados;
        private Button btn_limpar;
        private Button btn_buscar;
        private Button btn_fechar;
        private TextBox txt_logradouro;
        private TextBox txt_titulo_logradouro;
        private TextBox txt_estado;
        private TextBox txt_titulo_estado;
        private TextBox txt_codigo_ibge;
        private TextBox txt_titulo_codigo_municipal_ibge;
        private TextBox txt_tipo;
        private TextBox txt_titulo_tipo;
        private TextBox txt_cidade;
        private TextBox txt_titulo_cidade;
        private TextBox txt_bairro;
        private TextBox txt_titulo_bairro;
        private TextBox txt_titulo_pais;
        private TextBox txt_pais;
    }
}