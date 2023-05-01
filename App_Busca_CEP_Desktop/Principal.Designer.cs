namespace App_Busca_CEP_Desktop
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pn_submenu_sobre = new System.Windows.Forms.Panel();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.pn_submenu_opcoes = new System.Windows.Forms.Panel();
            this.btn_opcoes = new System.Windows.Forms.Button();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.pcbox_logo = new System.Windows.Forms.PictureBox();
            this.pn_formulario = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pn_menu.SuspendLayout();
            this.pn_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pn_menu);
            this.panel1.Controls.Add(this.pn_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 561);
            this.panel1.TabIndex = 0;
            // 
            // pn_menu
            // 
            this.pn_menu.AutoScroll = true;
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pn_menu.Controls.Add(this.btn_sair);
            this.pn_menu.Controls.Add(this.pn_submenu_sobre);
            this.pn_menu.Controls.Add(this.btn_sobre);
            this.pn_menu.Controls.Add(this.pn_submenu_opcoes);
            this.pn_menu.Controls.Add(this.btn_opcoes);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_menu.ForeColor = System.Drawing.Color.White;
            this.pn_menu.Location = new System.Drawing.Point(0, 126);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(223, 435);
            this.pn_menu.TabIndex = 1;
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(0, 496);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_sair.Size = new System.Drawing.Size(206, 40);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pn_submenu_sobre
            // 
            this.pn_submenu_sobre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_submenu_sobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_submenu_sobre.Location = new System.Drawing.Point(0, 288);
            this.pn_submenu_sobre.Name = "pn_submenu_sobre";
            this.pn_submenu_sobre.Size = new System.Drawing.Size(206, 208);
            this.pn_submenu_sobre.TabIndex = 2;
            // 
            // btn_sobre
            // 
            this.btn_sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sobre.FlatAppearance.BorderSize = 0;
            this.btn_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sobre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sobre.ForeColor = System.Drawing.Color.Red;
            this.btn_sobre.Location = new System.Drawing.Point(0, 248);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_sobre.Size = new System.Drawing.Size(206, 40);
            this.btn_sobre.TabIndex = 1;
            this.btn_sobre.Text = "Sobre";
            this.btn_sobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sobre.UseVisualStyleBackColor = true;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // pn_submenu_opcoes
            // 
            this.pn_submenu_opcoes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_submenu_opcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_submenu_opcoes.Location = new System.Drawing.Point(0, 40);
            this.pn_submenu_opcoes.Name = "pn_submenu_opcoes";
            this.pn_submenu_opcoes.Size = new System.Drawing.Size(206, 208);
            this.pn_submenu_opcoes.TabIndex = 0;
            // 
            // btn_opcoes
            // 
            this.btn_opcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_opcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_opcoes.FlatAppearance.BorderSize = 0;
            this.btn_opcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_opcoes.ForeColor = System.Drawing.Color.Red;
            this.btn_opcoes.Location = new System.Drawing.Point(0, 0);
            this.btn_opcoes.Name = "btn_opcoes";
            this.btn_opcoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_opcoes.Size = new System.Drawing.Size(206, 40);
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
            this.pn_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_formulario.Location = new System.Drawing.Point(223, 0);
            this.pn_formulario.Name = "pn_formulario";
            this.pn_formulario.Size = new System.Drawing.Size(661, 561);
            this.pn_formulario.TabIndex = 1;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pn_formulario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.pn_menu.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pn_menu;
        private Panel pn_logo;
        private Panel pn_formulario;
        private PictureBox pcbox_logo;
        private Button btn_opcoes;
        private Panel pn_submenu_opcoes;
        private Button btn_sobre;
        private Panel pn_submenu_sobre;
        private Button btn_sair;
    }
}