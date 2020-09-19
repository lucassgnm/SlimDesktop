namespace SilmDesktop.View
{
    partial class FormProduto
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
            this.ltvProdutos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnbuscaProduto = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new MetroFramework.Controls.MetroButton();
            this.btnTodosProdutos = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvProdutos
            // 
            this.ltvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.descricao,
            this.qtde,
            this.valor});
            this.ltvProdutos.FullRowSelect = true;
            this.ltvProdutos.GridLines = true;
            this.ltvProdutos.HideSelection = false;
            this.ltvProdutos.Location = new System.Drawing.Point(-2, -2);
            this.ltvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.ltvProdutos.Name = "ltvProdutos";
            this.ltvProdutos.Size = new System.Drawing.Size(794, 470);
            this.ltvProdutos.TabIndex = 1;
            this.ltvProdutos.UseCompatibleStateImageBehavior = false;
            this.ltvProdutos.View = System.Windows.Forms.View.Details;
            this.ltvProdutos.DoubleClick += new System.EventHandler(this.ltvProdutos_DoubleClick);
            this.ltvProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltvProdutos_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 80;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 510;
            // 
            // qtde
            // 
            this.qtde.Text = "Quantidade";
            this.qtde.Width = 80;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 140;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(9, 472);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(272, 23);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // btnbuscaProduto
            // 
            this.btnbuscaProduto.Location = new System.Drawing.Point(285, 472);
            this.btnbuscaProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscaProduto.Name = "btnbuscaProduto";
            this.btnbuscaProduto.Size = new System.Drawing.Size(124, 21);
            this.btnbuscaProduto.TabIndex = 2;
            this.btnbuscaProduto.Text = "Pesquisar produto";
            this.btnbuscaProduto.UseSelectable = true;
            this.btnbuscaProduto.Click += new System.EventHandler(this.btnbuscaProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.Location = new System.Drawing.Point(10, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "O carregamento dos produtos pode variar de acordo com a quantidade de itens a ser" +
    "em exibidos*";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(610, 472);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(172, 34);
            this.btnAdicionarProduto.TabIndex = 4;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseSelectable = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnTodosProdutos
            // 
            this.btnTodosProdutos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTodosProdutos.Location = new System.Drawing.Point(422, 472);
            this.btnTodosProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodosProdutos.Name = "btnTodosProdutos";
            this.btnTodosProdutos.Size = new System.Drawing.Size(172, 34);
            this.btnTodosProdutos.TabIndex = 5;
            this.btnTodosProdutos.Text = "Limpar pesquisa";
            this.btnTodosProdutos.UseSelectable = true;
            this.btnTodosProdutos.Click += new System.EventHandler(this.btnTodosProdutos_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.testeToolStripMenuItem1});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.ShowImageMargin = false;
            this.metroContextMenu1.Size = new System.Drawing.Size(85, 48);
            this.metroContextMenu1.Text = "Opções";
            this.metroContextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.testeToolStripMenuItem.Text = "Editar";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(84, 22);
            this.testeToolStripMenuItem1.Text = "Excluir";
            this.testeToolStripMenuItem1.Click += new System.EventHandler(this.testeToolStripMenuItem1_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.btnTodosProdutos);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscaProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.ltvProdutos);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Produtos";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProduto_KeyDown);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltvProdutos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader qtde;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private MetroFramework.Controls.MetroButton btnbuscaProduto;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnAdicionarProduto;
        private MetroFramework.Controls.MetroButton btnTodosProdutos;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
    }
}