namespace Genomium
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gvDados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PapelBiologico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosiçãoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosiçãoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SequenciaDNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblAlunos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDados
            // 
            this.gvDados.AllowUserToAddRows = false;
            this.gvDados.AllowUserToOrderColumns = true;
            this.gvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Gene,
            this.Tipo,
            this.Familia,
            this.PapelBiologico,
            this.PosiçãoInicial,
            this.PosiçãoFinal,
            this.SequenciaDNA});
            this.gvDados.Location = new System.Drawing.Point(12, 41);
            this.gvDados.Name = "gvDados";
            this.gvDados.ReadOnly = true;
            this.gvDados.Size = new System.Drawing.Size(737, 649);
            this.gvDados.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Gene
            // 
            this.Gene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gene.DataPropertyName = "Gene";
            this.Gene.HeaderText = "Gene";
            this.Gene.Name = "Gene";
            this.Gene.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Familia
            // 
            this.Familia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Familia.DataPropertyName = "Familia";
            this.Familia.HeaderText = "Família";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            // 
            // PapelBiologico
            // 
            this.PapelBiologico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PapelBiologico.DataPropertyName = "PapelBiologico";
            this.PapelBiologico.HeaderText = "Papel Biológico";
            this.PapelBiologico.Name = "PapelBiologico";
            this.PapelBiologico.ReadOnly = true;
            // 
            // PosiçãoInicial
            // 
            this.PosiçãoInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PosiçãoInicial.DataPropertyName = "PosicaoInicial";
            this.PosiçãoInicial.HeaderText = "Posição Inicial";
            this.PosiçãoInicial.Name = "PosiçãoInicial";
            this.PosiçãoInicial.ReadOnly = true;
            // 
            // PosiçãoFinal
            // 
            this.PosiçãoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PosiçãoFinal.DataPropertyName = "PosicaoFinal";
            this.PosiçãoFinal.HeaderText = "Posição Final";
            this.PosiçãoFinal.Name = "PosiçãoFinal";
            this.PosiçãoFinal.ReadOnly = true;
            // 
            // SequenciaDNA
            // 
            this.SequenciaDNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SequenciaDNA.DataPropertyName = "SequenciaDNA";
            this.SequenciaDNA.HeaderText = "Sequencia DNA";
            this.SequenciaDNA.Name = "SequenciaDNA";
            this.SequenciaDNA.ReadOnly = true;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(12, 15);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(104, 13);
            this.lblCaminho.TabIndex = 1;
            this.lblCaminho.Text = "Caminho do arquivo:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(122, 12);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(555, 20);
            this.txtCaminho.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(683, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.Location = new System.Drawing.Point(12, 695);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // lblAlunos
            // 
            this.lblAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(408, 700);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(341, 13);
            this.lblAlunos.TabIndex = 5;
            this.lblAlunos.Text = "Bruno Jonatha Orlandy, Jéssica da Silva Pavan e Vinicius Molon Toigo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 722);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.gvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "MainForm";
            this.Text = "Genomium";
            ((System.ComponentModel.ISupportInitialize)(this.gvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDados;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PapelBiologico;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosiçãoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosiçãoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SequenciaDNA;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblAlunos;
    }
}

