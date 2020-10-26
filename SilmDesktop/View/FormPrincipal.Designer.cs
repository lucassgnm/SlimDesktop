namespace SilmDesktop.View
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.btnVendas = new MetroFramework.Controls.MetroTile();
            this.btnProdutos = new MetroFramework.Controls.MetroTile();
            this.btnClientes = new MetroFramework.Controls.MetroTile();
            this.lblNomeAdm = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblNomeAdm);
            this.groupBox1.Controls.Add(this.lblDataHora);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(20, 799);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1079, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(49, 22);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(0, 17);
            this.lblDataHora.TabIndex = 0;
            // 
            // btnVendas
            // 
            this.btnVendas.ActiveControl = null;
            this.btnVendas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVendas.Location = new System.Drawing.Point(39, 292);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(353, 218);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TileImage = global::SilmDesktop.Properties.Resources.vendas;
            this.btnVendas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVendas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnVendas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnVendas.UseCustomBackColor = true;
            this.btnVendas.UseSelectable = true;
            this.btnVendas.UseTileImage = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.ActiveControl = null;
            this.btnProdutos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdutos.Location = new System.Drawing.Point(39, 43);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(353, 222);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TileImage = global::SilmDesktop.Properties.Resources.produtos1;
            this.btnProdutos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProdutos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnProdutos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnProdutos.UseCustomBackColor = true;
            this.btnProdutos.UseCustomForeColor = true;
            this.btnProdutos.UseSelectable = true;
            this.btnProdutos.UseTileImage = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ActiveControl = null;
            this.btnClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClientes.Location = new System.Drawing.Point(39, 537);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(353, 222);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TileImage = global::SilmDesktop.Properties.Resources.clientes;
            this.btnClientes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClientes.UseCustomBackColor = true;
            this.btnClientes.UseSelectable = true;
            this.btnClientes.UseTileImage = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblNomeAdm
            // 
            this.lblNomeAdm.AutoSize = true;
            this.lblNomeAdm.Location = new System.Drawing.Point(341, 17);
            this.lblNomeAdm.Name = "lblNomeAdm";
            this.lblNomeAdm.Size = new System.Drawing.Size(211, 20);
            this.lblNomeAdm.TabIndex = 0;
            this.lblNomeAdm.Text = "Nome de usuário não informado";
            this.lblNomeAdm.Click += new System.EventHandler(this.lblNomeAdm_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Data:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(258, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Usuário:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 869);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnClientes;
        private MetroFramework.Controls.MetroTile btnProdutos;
        private MetroFramework.Controls.MetroTile btnVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDataHora;
        private MetroFramework.Controls.MetroLabel lblNomeAdm;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}