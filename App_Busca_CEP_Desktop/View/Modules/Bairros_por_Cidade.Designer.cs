namespace App_Busca_CEP_Desktop.View.Modules
{
    partial class form_bairros_por_cidade
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
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbbox_estado = new System.Windows.Forms.ComboBox();
            this.dgv_bairros_cidade = new System.Windows.Forms.DataGridView();
            this.cbbox_cidade = new System.Windows.Forms.ComboBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bairros_cidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estado.Location = new System.Drawing.Point(12, 12);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(254, 32);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Escolha um estado:";
            // 
            // cbbox_estado
            // 
            this.cbbox_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbox_estado.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbox_estado.FormattingEnabled = true;
            this.cbbox_estado.Location = new System.Drawing.Point(285, 12);
            this.cbbox_estado.Name = "cbbox_estado";
            this.cbbox_estado.Size = new System.Drawing.Size(348, 32);
            this.cbbox_estado.TabIndex = 1;
            this.cbbox_estado.SelectedIndexChanged += new System.EventHandler(this.cbbox_estado_SelectedIndexChanged);
            // 
            // dgv_bairros_cidade
            // 
            this.dgv_bairros_cidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bairros_cidade.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_bairros_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bairros_cidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bairros_cidade.Location = new System.Drawing.Point(12, 109);
            this.dgv_bairros_cidade.Name = "dgv_bairros_cidade";
            this.dgv_bairros_cidade.RowTemplate.Height = 25;
            this.dgv_bairros_cidade.Size = new System.Drawing.Size(621, 349);
            this.dgv_bairros_cidade.TabIndex = 2;
            // 
            // cbbox_cidade
            // 
            this.cbbox_cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbox_cidade.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbox_cidade.FormattingEnabled = true;
            this.cbbox_cidade.Location = new System.Drawing.Point(285, 60);
            this.cbbox_cidade.Name = "cbbox_cidade";
            this.cbbox_cidade.Size = new System.Drawing.Size(348, 32);
            this.cbbox_cidade.TabIndex = 6;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cidade.Location = new System.Drawing.Point(12, 60);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(267, 32);
            this.lbl_cidade.TabIndex = 5;
            this.lbl_cidade.Text = "Escolha uma cidade:";
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
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // form_bairros_por_cidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(645, 522);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.cbbox_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.dgv_bairros_cidade);
            this.Controls.Add(this.cbbox_estado);
            this.Controls.Add(this.lbl_estado);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(661, 561);
            this.Name = "form_bairros_por_cidade";
            this.Load += new System.EventHandler(this.form_bairros_por_cidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bairros_cidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_estado;
        private ComboBox cbbox_estado;
        private DataGridView dgv_bairros_cidade;
        private ComboBox cbbox_cidade;
        private Label lbl_cidade;
        private Button btn_fechar;
        private Button btn_buscar;
        private Button btn_limpar;
    }
}