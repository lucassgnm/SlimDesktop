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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataHora);
            this.groupBox1.Location = new System.Drawing.Point(630, 516);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data / Hora";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(7, 21);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(0, 17);
            this.lblDataHora.TabIndex = 0;
            // 
            // btnVendas
            // 
            this.btnVendas.ActiveControl = null;
            this.btnVendas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVendas.Location = new System.Drawing.Point(39, 292);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(757, 218);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TileImage = global::SilmDesktop.Properties.Resources.vendas;
            this.btnVendas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVendas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnVendas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnVendas.UseCustomBackColor = true;
            this.btnVendas.UseSelectable = true;
            this.btnVendas.UseTileImage = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.ActiveControl = null;
            this.btnProdutos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdutos.Location = new System.Drawing.Point(39, 43);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(353, 221);
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
            this.btnClientes.Location = new System.Drawing.Point(443, 43);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(353, 221);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TileImage = global::SilmDesktop.Properties.Resources.clientes;
            this.btnClientes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClientes.UseCustomBackColor = true;
            this.btnClientes.UseSelectable = true;
            this.btnClientes.UseTileImage = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Resizable = false;
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
    }
}