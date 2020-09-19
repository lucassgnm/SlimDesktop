namespace SilmDesktop.View
{
    partial class FormProdutoEdit
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
            this.btnEditProduto = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCodBarras = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtQtde = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtValorUn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnEditProduto
            // 
            this.btnEditProduto.Location = new System.Drawing.Point(23, 227);
            this.btnEditProduto.Name = "btnEditProduto";
            this.btnEditProduto.Size = new System.Drawing.Size(562, 36);
            this.btnEditProduto.TabIndex = 20;
            this.btnEditProduto.Text = "Editar produto";
            this.btnEditProduto.UseSelectable = true;
            this.btnEditProduto.Click += new System.EventHandler(this.btnEditProduto_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(395, 148);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Código de barras";
            // 
            // txtCodBarras
            // 
            // 
            // 
            // 
            this.txtCodBarras.CustomButton.Image = null;
            this.txtCodBarras.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtCodBarras.CustomButton.Name = "";
            this.txtCodBarras.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodBarras.CustomButton.TabIndex = 1;
            this.txtCodBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodBarras.CustomButton.UseSelectable = true;
            this.txtCodBarras.CustomButton.Visible = false;
            this.txtCodBarras.Lines = new string[0];
            this.txtCodBarras.Location = new System.Drawing.Point(395, 170);
            this.txtCodBarras.MaxLength = 32767;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.PasswordChar = '\0';
            this.txtCodBarras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBarras.SelectedText = "";
            this.txtCodBarras.SelectionLength = 0;
            this.txtCodBarras.SelectionStart = 0;
            this.txtCodBarras.ShortcutsEnabled = true;
            this.txtCodBarras.Size = new System.Drawing.Size(190, 23);
            this.txtCodBarras.TabIndex = 18;
            this.txtCodBarras.UseSelectable = true;
            this.txtCodBarras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBarras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(200, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Quantidade";
            // 
            // txtQtde
            // 
            // 
            // 
            // 
            this.txtQtde.CustomButton.Image = null;
            this.txtQtde.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtQtde.CustomButton.Name = "";
            this.txtQtde.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtde.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtde.CustomButton.TabIndex = 1;
            this.txtQtde.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtde.CustomButton.UseSelectable = true;
            this.txtQtde.CustomButton.Visible = false;
            this.txtQtde.Lines = new string[0];
            this.txtQtde.Location = new System.Drawing.Point(200, 170);
            this.txtQtde.MaxLength = 32767;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.PasswordChar = '\0';
            this.txtQtde.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtde.SelectedText = "";
            this.txtQtde.SelectionLength = 0;
            this.txtQtde.SelectionStart = 0;
            this.txtQtde.ShortcutsEnabled = true;
            this.txtQtde.Size = new System.Drawing.Size(189, 23);
            this.txtQtde.TabIndex = 16;
            this.txtQtde.UseSelectable = true;
            this.txtQtde.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtde.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Valor Unitário";
            // 
            // txtValorUn
            // 
            // 
            // 
            // 
            this.txtValorUn.CustomButton.Image = null;
            this.txtValorUn.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtValorUn.CustomButton.Name = "";
            this.txtValorUn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorUn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorUn.CustomButton.TabIndex = 1;
            this.txtValorUn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorUn.CustomButton.UseSelectable = true;
            this.txtValorUn.CustomButton.Visible = false;
            this.txtValorUn.Lines = new string[0];
            this.txtValorUn.Location = new System.Drawing.Point(23, 170);
            this.txtValorUn.MaxLength = 32767;
            this.txtValorUn.Name = "txtValorUn";
            this.txtValorUn.PasswordChar = '\0';
            this.txtValorUn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorUn.SelectedText = "";
            this.txtValorUn.SelectionLength = 0;
            this.txtValorUn.SelectionStart = 0;
            this.txtValorUn.ShortcutsEnabled = true;
            this.txtValorUn.Size = new System.Drawing.Size(171, 23);
            this.txtValorUn.TabIndex = 14;
            this.txtValorUn.UseSelectable = true;
            this.txtValorUn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorUn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorUn.TextChanged += new System.EventHandler(this.txtValorUn_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Descrição do produto";
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(540, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(23, 93);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(562, 23);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblId.Location = new System.Drawing.Point(461, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 0);
            this.lblId.TabIndex = 21;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(431, 32);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(24, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "ID:";
            // 
            // FormProdutoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 287);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEditProduto);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtValorUn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescricao);
            this.MaximizeBox = false;
            this.Name = "FormProdutoEdit";
            this.Resizable = false;
            this.Text = "Editar Produto";
            this.Load += new System.EventHandler(this.FormProdutoEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEditProduto;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCodBarras;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtQtde;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtValorUn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}