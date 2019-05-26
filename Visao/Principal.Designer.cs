namespace Visao
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgInfo = new System.Windows.Forms.PictureBox();
            this.panelImportacao = new System.Windows.Forms.Panel();
            this.txtCaminhoSalvamento = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtOpen = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.txtLinhaInicialDados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePlanilha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPREC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxColunaTempo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.resultadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).BeginInit();
            this.panelImportacao.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgInfo
            // 
            this.imgInfo.Image = ((System.Drawing.Image)(resources.GetObject("imgInfo.Image")));
            this.imgInfo.Location = new System.Drawing.Point(280, 139);
            this.imgInfo.Name = "imgInfo";
            this.imgInfo.Size = new System.Drawing.Size(16, 16);
            this.imgInfo.TabIndex = 32;
            this.imgInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.imgInfo, "O intervalo deve ser informado somente em minutos!");
            // 
            // panelImportacao
            // 
            this.panelImportacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImportacao.Controls.Add(this.txtCaminhoSalvamento);
            this.panelImportacao.Controls.Add(this.btnDestino);
            this.panelImportacao.Controls.Add(this.txtIntervalo);
            this.panelImportacao.Controls.Add(this.txtCaminho);
            this.panelImportacao.Controls.Add(this.txtOpen);
            this.panelImportacao.Controls.Add(this.imgInfo);
            this.panelImportacao.Controls.Add(this.pnBotoes);
            this.panelImportacao.Controls.Add(this.txtLinhaInicialDados);
            this.panelImportacao.Controls.Add(this.label5);
            this.panelImportacao.Controls.Add(this.txtNomePlanilha);
            this.panelImportacao.Controls.Add(this.label4);
            this.panelImportacao.Controls.Add(this.cbxPREC);
            this.panelImportacao.Controls.Add(this.label3);
            this.panelImportacao.Controls.Add(this.cbxColunaTempo);
            this.panelImportacao.Controls.Add(this.label2);
            this.panelImportacao.Controls.Add(this.label1);
            this.panelImportacao.Location = new System.Drawing.Point(12, 12);
            this.panelImportacao.Name = "panelImportacao";
            this.panelImportacao.Size = new System.Drawing.Size(856, 313);
            this.panelImportacao.TabIndex = 0;
            // 
            // txtCaminhoSalvamento
            // 
            this.txtCaminhoSalvamento.Enabled = false;
            this.txtCaminhoSalvamento.Location = new System.Drawing.Point(127, 91);
            this.txtCaminhoSalvamento.Name = "txtCaminhoSalvamento";
            this.txtCaminhoSalvamento.Size = new System.Drawing.Size(550, 29);
            this.txtCaminhoSalvamento.TabIndex = 35;
            // 
            // btnDestino
            // 
            this.btnDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnDestino.Image")));
            this.btnDestino.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDestino.Location = new System.Drawing.Point(4, 76);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(117, 67);
            this.btnDestino.TabIndex = 34;
            this.btnDestino.Text = "Destino";
            this.btnDestino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnDestino, "Caminho de destino do arquivo resultado");
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(127, 158);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(169, 29);
            this.txtIntervalo.TabIndex = 2;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Location = new System.Drawing.Point(127, 20);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(717, 29);
            this.txtCaminho.TabIndex = 33;
            // 
            // txtOpen
            // 
            this.txtOpen.Image = ((System.Drawing.Image)(resources.GetObject("txtOpen.Image")));
            this.txtOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtOpen.Location = new System.Drawing.Point(4, 3);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(117, 67);
            this.txtOpen.TabIndex = 1;
            this.txtOpen.Text = "Abrir";
            this.txtOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.txtOpen, "Caminho onde está o arquivo .xlsx para realização dos cálculos");
            this.txtOpen.UseVisualStyleBackColor = true;
            this.txtOpen.Click += new System.EventHandler(this.txtOpen_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBotoes.Controls.Add(this.btnIniciar);
            this.pnBotoes.Controls.Add(this.btnLimparCampos);
            this.pnBotoes.Location = new System.Drawing.Point(704, 101);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(140, 183);
            this.pnBotoes.TabIndex = 29;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.Location = new System.Drawing.Point(11, 103);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(117, 67);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnIniciar, "Iniciar");
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCampos.Image")));
            this.btnLimparCampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimparCampos.Location = new System.Drawing.Point(11, 12);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(117, 67);
            this.btnLimparCampos.TabIndex = 8;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnLimparCampos, "Limpar Campos");
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click_1);
            // 
            // txtLinhaInicialDados
            // 
            this.txtLinhaInicialDados.Location = new System.Drawing.Point(330, 256);
            this.txtLinhaInicialDados.Name = "txtLinhaInicialDados";
            this.txtLinhaInicialDados.Size = new System.Drawing.Size(157, 29);
            this.txtLinhaInicialDados.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Linha inicial Dados*";
            // 
            // txtNomePlanilha
            // 
            this.txtNomePlanilha.Location = new System.Drawing.Point(127, 255);
            this.txtNomePlanilha.Name = "txtNomePlanilha";
            this.txtNomePlanilha.Size = new System.Drawing.Size(169, 29);
            this.txtNomePlanilha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nome da Planilha*";
            // 
            // cbxPREC
            // 
            this.cbxPREC.FormattingEnabled = true;
            this.cbxPREC.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cbxPREC.Location = new System.Drawing.Point(520, 158);
            this.cbxPREC.Name = "cbxPREC";
            this.cbxPREC.Size = new System.Drawing.Size(157, 29);
            this.cbxPREC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Coluna PREC*";
            // 
            // cbxColunaTempo
            // 
            this.cbxColunaTempo.FormattingEnabled = true;
            this.cbxColunaTempo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cbxColunaTempo.Location = new System.Drawing.Point(330, 158);
            this.cbxColunaTempo.Name = "cbxColunaTempo";
            this.cbxColunaTempo.Size = new System.Drawing.Size(157, 29);
            this.cbxColunaTempo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Coluna Tempo*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Informe o Intervalo*";
            // 
            // resultadoBindingSource
            // 
            this.resultadoBindingSource.DataSource = typeof(Negocio.Resultado);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 333);
            this.Controls.Add(this.panelImportacao);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importação";
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).EndInit();
            this.panelImportacao.ResumeLayout(false);
            this.panelImportacao.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelImportacao;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button txtOpen;
        private System.Windows.Forms.PictureBox imgInfo;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.TextBox txtLinhaInicialDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePlanilha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPREC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxColunaTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.BindingSource resultadoBindingSource;
        private System.Windows.Forms.TextBox txtCaminhoSalvamento;
        private System.Windows.Forms.Button btnDestino;
    }
}

