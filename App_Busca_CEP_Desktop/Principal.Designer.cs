namespace App_Busca_CEP_Desktop
{
    partial class form_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_menu_lateral = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pn_submenu_opcoes = new System.Windows.Forms.Panel();
            this.btn_form_logradouros_por_bairro = new System.Windows.Forms.Button();
            this.btn_form_bairros_por_cidade = new System.Windows.Forms.Button();
            this.btn_form_ceps_por_logradouro = new System.Windows.Forms.Button();
            this.btn_form_cidades_por_estado = new System.Windows.Forms.Button();
            this.btn_form_endereco = new System.Windows.Forms.Button();
            this.btn_opcoes = new System.Windows.Forms.Button();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.pcbox_logo = new System.Windows.Forms.PictureBox();
            this.pn_formulario = new System.Windows.Forms.Panel();
            this.pn_form_externo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pn_menu_lateral.SuspendLayout();
            this.pn_submenu_opcoes.SuspendLayout();
            this.pn_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_logo)).BeginInit();
            this.pn_formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pn_menu_lateral);
            this.panel1.Controls.Add(this.pn_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 561);
            this.panel1.TabIndex = 0;
            // 
            // pn_menu_lateral
            // 
            this.pn_menu_lateral.AutoScroll = true;
            this.pn_menu_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pn_menu_lateral.Controls.Add(this.btn_sair);
            this.pn_menu_lateral.Controls.Add(this.pn_submenu_opcoes);
            this.pn_menu_lateral.Controls.Add(this.btn_opcoes);
            this.pn_menu_lateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_menu_lateral.ForeColor = System.Drawing.Color.White;
            this.pn_menu_lateral.Location = new System.Drawing.Point(0, 126);
            this.pn_menu_lateral.Name = "pn_menu_lateral";
            this.pn_menu_lateral.Size = new System.Drawing.Size(223, 435);
            this.pn_menu_lateral.TabIndex = 1;
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(0, 425);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_sair.Size = new System.Drawing.Size(206, 50);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pn_submenu_opcoes
            // 
            this.pn_submenu_opcoes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_submenu_opcoes.Controls.Add(this.btn_form_logradouros_por_bairro);
            this.pn_submenu_opcoes.Controls.Add(this.btn_form_bairros_por_cidade);
            this.pn_submenu_opcoes.Controls.Add(this.btn_form_ceps_por_logradouro);
            this.pn_submenu_opcoes.Controls.Add(this.btn_form_cidades_por_estado);
            this.pn_submenu_opcoes.Controls.Add(this.btn_form_endereco);
            this.pn_submenu_opcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_submenu_opcoes.Location = new System.Drawing.Point(0, 50);
            this.pn_submenu_opcoes.Name = "pn_submenu_opcoes";
            this.pn_submenu_opcoes.Size = new System.Drawing.Size(206, 375);
            this.pn_submenu_opcoes.TabIndex = 0;
            // 
            // btn_form_logradouros_por_bairro
            // 
            this.btn_form_logradouros_por_bairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btn_form_logradouros_por_bairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_logradouros_por_bairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_logradouros_por_bairro.FlatAppearance.BorderSize = 0;
            this.btn_form_logradouros_por_bairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_logradouros_por_bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_form_logradouros_por_bairro.ForeColor = System.Drawing.Color.Red;
            this.btn_form_logradouros_por_bairro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_logradouros_por_bairro.Location = new System.Drawing.Point(0, 300);
            this.btn_form_logradouros_por_bairro.Name = "btn_form_logradouros_por_bairro";
            this.btn_form_logradouros_por_bairro.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_form_logradouros_por_bairro.Size = new System.Drawing.Size(206, 75);
            this.btn_form_logradouros_por_bairro.TabIndex = 8;
            this.btn_form_logradouros_por_bairro.Text = "Os logradouros presentes no seu bairro";
            this.btn_form_logradouros_por_bairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_logradouros_por_bairro.UseVisualStyleBackColor = false;
            this.btn_form_logradouros_por_bairro.Click += new System.EventHandler(this.btn_form_logradouros_por_bairro_Click);
            // 
            // btn_form_bairros_por_cidade
            // 
            this.btn_form_bairros_por_cidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btn_form_bairros_por_cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_bairros_por_cidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_bairros_por_cidade.FlatAppearance.BorderSize = 0;
            this.btn_form_bairros_por_cidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_bairros_por_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_form_bairros_por_cidade.ForeColor = System.Drawing.Color.Red;
            this.btn_form_bairros_por_cidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_bairros_por_cidade.Location = new System.Drawing.Point(0, 225);
            this.btn_form_bairros_por_cidade.Name = "btn_form_bairros_por_cidade";
            this.btn_form_bairros_por_cidade.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_form_bairros_por_cidade.Size = new System.Drawing.Size(206, 75);
            this.btn_form_bairros_por_cidade.TabIndex = 7;
            this.btn_form_bairros_por_cidade.Text = "Os bairros da sua cidade";
            this.btn_form_bairros_por_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_bairros_por_cidade.UseVisualStyleBackColor = false;
            this.btn_form_bairros_por_cidade.Click += new System.EventHandler(this.btn_form_bairros_por_cidade_Click);
            // 
            // btn_form_ceps_por_logradouro
            // 
            this.btn_form_ceps_por_logradouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btn_form_ceps_por_logradouro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_ceps_por_logradouro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_ceps_por_logradouro.FlatAppearance.BorderSize = 0;
            this.btn_form_ceps_por_logradouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_ceps_por_logradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_form_ceps_por_logradouro.ForeColor = System.Drawing.Color.Red;
            this.btn_form_ceps_por_logradouro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_ceps_por_logradouro.Location = new System.Drawing.Point(0, 150);
            this.btn_form_ceps_por_logradouro.Name = "btn_form_ceps_por_logradouro";
            this.btn_form_ceps_por_logradouro.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_form_ceps_por_logradouro.Size = new System.Drawing.Size(206, 75);
            this.btn_form_ceps_por_logradouro.TabIndex = 6;
            this.btn_form_ceps_por_logradouro.Text = "Os ceps presentes no seu logradouro";
            this.btn_form_ceps_por_logradouro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_ceps_por_logradouro.UseVisualStyleBackColor = false;
            this.btn_form_ceps_por_logradouro.Click += new System.EventHandler(this.btn_form_ceps_por_logradouro_Click);
            // 
            // btn_form_cidades_por_estado
            // 
            this.btn_form_cidades_por_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btn_form_cidades_por_estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_cidades_por_estado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_cidades_por_estado.FlatAppearance.BorderSize = 0;
            this.btn_form_cidades_por_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_cidades_por_estado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_form_cidades_por_estado.ForeColor = System.Drawing.Color.Red;
            this.btn_form_cidades_por_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_cidades_por_estado.Location = new System.Drawing.Point(0, 75);
            this.btn_form_cidades_por_estado.Name = "btn_form_cidades_por_estado";
            this.btn_form_cidades_por_estado.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_form_cidades_por_estado.Size = new System.Drawing.Size(206, 75);
            this.btn_form_cidades_por_estado.TabIndex = 5;
            this.btn_form_cidades_por_estado.Text = "As cidades do seu estado";
            this.btn_form_cidades_por_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_cidades_por_estado.UseVisualStyleBackColor = false;
            this.btn_form_cidades_por_estado.Click += new System.EventHandler(this.btn_form_cidades_por_estado_Click);
            // 
            // btn_form_endereco
            // 
            this.btn_form_endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btn_form_endereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_endereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_form_endereco.FlatAppearance.BorderSize = 0;
            this.btn_form_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_endereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_form_endereco.ForeColor = System.Drawing.Color.Red;
            this.btn_form_endereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_endereco.Location = new System.Drawing.Point(0, 0);
            this.btn_form_endereco.Name = "btn_form_endereco";
            this.btn_form_endereco.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_form_endereco.Size = new System.Drawing.Size(206, 75);
            this.btn_form_endereco.TabIndex = 4;
            this.btn_form_endereco.Text = "Seu endereço";
            this.btn_form_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_form_endereco.UseVisualStyleBackColor = false;
            this.btn_form_endereco.Click += new System.EventHandler(this.btn_form_endereco_Click);
            // 
            // btn_opcoes
            // 
            this.btn_opcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_opcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_opcoes.FlatAppearance.BorderSize = 0;
            this.btn_opcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_opcoes.ForeColor = System.Drawing.Color.Red;
            this.btn_opcoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_opcoes.Location = new System.Drawing.Point(0, 0);
            this.btn_opcoes.Name = "btn_opcoes";
            this.btn_opcoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_opcoes.Size = new System.Drawing.Size(206, 50);
            this.btn_opcoes.TabIndex = 0;
            this.btn_opcoes.Text = "Opções";
            this.btn_opcoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_opcoes.UseVisualStyleBackColor = true;
            this.btn_opcoes.Click += new System.EventHandler(this.btn_opcoes_Click);
            // 
            // pn_logo
            // 
            this.pn_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pn_logo.Controls.Add(this.pcbox_logo);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(0, 0);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(223, 126);
            this.pn_logo.TabIndex = 1;
            // 
            // pcbox_logo
            // 
            this.pcbox_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbox_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pcbox_logo.Image")));
            this.pcbox_logo.Location = new System.Drawing.Point(0, 0);
            this.pcbox_logo.Name = "pcbox_logo";
            this.pcbox_logo.Size = new System.Drawing.Size(223, 126);
            this.pcbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbox_logo.TabIndex = 0;
            this.pcbox_logo.TabStop = false;
            // 
            // pn_formulario
            // 
            this.pn_formulario.BackColor = System.Drawing.Color.Gray;
            this.pn_formulario.Controls.Add(this.pn_form_externo);
            this.pn_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_formulario.Location = new System.Drawing.Point(223, 0);
            this.pn_formulario.Name = "pn_formulario";
            this.pn_formulario.Size = new System.Drawing.Size(661, 561);
            this.pn_formulario.TabIndex = 1;
            // 
            // pn_form_externo
            // 
            this.pn_form_externo.BackColor = System.Drawing.Color.Transparent;
            this.pn_form_externo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_form_externo.Location = new System.Drawing.Point(0, 0);
            this.pn_form_externo.Name = "pn_form_externo";
            this.pn_form_externo.Size = new System.Drawing.Size(661, 561);
            this.pn_form_externo.TabIndex = 0;
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pn_formulario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.pn_menu_lateral.ResumeLayout(false);
            this.pn_submenu_opcoes.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_logo)).EndInit();
            this.pn_formulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pn_menu_lateral;
        private Panel pn_logo;
        private Panel pn_formulario;
        private PictureBox pcbox_logo;
        private Button btn_opcoes;
        private Panel pn_submenu_opcoes;
        private Button btn_sair;
        private Panel pn_form_externo;
        private Button btn_form_logradouros_por_bairro;
        private Button btn_form_bairros_por_cidade;
        private Button btn_form_ceps_por_logradouro;
        private Button btn_form_cidades_por_estado;
        private Button btn_form_endereco;
    }
}