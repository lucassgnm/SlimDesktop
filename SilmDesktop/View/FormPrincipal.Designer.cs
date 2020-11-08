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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblNomeAdm = new MetroFramework.Controls.MetroLabel();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.btnVendas = new MetroFramework.Controls.MetroTile();
            this.btnProdutos = new MetroFramework.Controls.MetroTile();
            this.btnClientes = new MetroFramework.Controls.MetroTile();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomecliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datavenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bandeira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblNomeAdm);
            this.groupBox1.Controls.Add(this.lblDataHora);
            this.groupBox1.Location = new System.Drawing.Point(29, 620);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1151, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(194, 15);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Usuário:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(4, 15);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Data:";
            // 
            // lblNomeAdm
            // 
            this.lblNomeAdm.AutoSize = true;
            this.lblNomeAdm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNomeAdm.Location = new System.Drawing.Point(257, 15);
            this.lblNomeAdm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAdm.Name = "lblNomeAdm";
            this.lblNomeAdm.Size = new System.Drawing.Size(208, 19);
            this.lblNomeAdm.TabIndex = 0;
            this.lblNomeAdm.Text = "Nome de usuário não informado";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(45, 18);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(0, 15);
            this.lblDataHora.TabIndex = 0;
            // 
            // btnVendas
            // 
            this.btnVendas.ActiveControl = null;
            this.btnVendas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVendas.Location = new System.Drawing.Point(29, 237);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(265, 177);
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
            this.btnProdutos.Location = new System.Drawing.Point(29, 35);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(265, 180);
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
            this.btnClientes.Location = new System.Drawing.Point(29, 436);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(265, 180);
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
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.SystemColors.Window;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nomecliente,
            this.total,
            this.datavenda,
            this.bandeira});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.ForeColor = System.Drawing.SystemColors.Window;
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(325, 72);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(612, 342);
            this.metroListView1.TabIndex = 4;
            this.metroListView1.TileSize = new System.Drawing.Size(288, 95);
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Tile;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 160;
            // 
            // nomecliente
            // 
            this.nomecliente.Text = "Nome do cliente";
            this.nomecliente.Width = 200;
            // 
            // total
            // 
            this.total.Text = "Valor total";
            this.total.Width = 130;
            // 
            // datavenda
            // 
            this.datavenda.Text = "Data / Hora";
            // 
            // bandeira
            // 
            this.bandeira.Text = "Forma Pagto.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(325, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(232, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Ultimas vendas (Live reload): ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 673);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nomecliente;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader datavenda;
        private System.Windows.Forms.ColumnHeader bandeira;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}