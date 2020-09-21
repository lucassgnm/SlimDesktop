namespace SilmDesktop.View.Venda
{
    partial class FormVenda
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
            this.btnTodosProdutos = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscaProduto = new MetroFramework.Controls.MetroButton();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.ltvVenda = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datavenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnTodosProdutos
            // 
            this.btnTodosProdutos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTodosProdutos.Location = new System.Drawing.Point(705, 583);
            this.btnTodosProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTodosProdutos.Name = "btnTodosProdutos";
            this.btnTodosProdutos.Size = new System.Drawing.Size(229, 42);
            this.btnTodosProdutos.TabIndex = 11;
            this.btnTodosProdutos.Text = "Limpar pesquisa";
            this.btnTodosProdutos.UseSelectable = true;
            this.btnTodosProdutos.Click += new System.EventHandler(this.btnTodosProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.Location = new System.Drawing.Point(13, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "O carregamento das vendas pode variar de acordo com a quantidade de itens a serem" +
    " exibidos*";
            // 
            // btnbuscaProduto
            // 
            this.btnbuscaProduto.Location = new System.Drawing.Point(380, 583);
            this.btnbuscaProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscaProduto.Name = "btnbuscaProduto";
            this.btnbuscaProduto.Size = new System.Drawing.Size(165, 26);
            this.btnbuscaProduto.TabIndex = 8;
            this.btnbuscaProduto.Text = "Pesquisar venda (id)";
            this.btnbuscaProduto.UseSelectable = true;
            this.btnbuscaProduto.Click += new System.EventHandler(this.btnbuscaProduto_Click);
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenda.Location = new System.Drawing.Point(12, 583);
            this.txtIdVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(361, 26);
            this.txtIdVenda.TabIndex = 6;
            // 
            // ltvVenda
            // 
            this.ltvVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.total,
            this.datavenda,
            this.status});
            this.ltvVenda.FullRowSelect = true;
            this.ltvVenda.GridLines = true;
            this.ltvVenda.HideSelection = false;
            this.ltvVenda.Location = new System.Drawing.Point(-3, 0);
            this.ltvVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltvVenda.Name = "ltvVenda";
            this.ltvVenda.Size = new System.Drawing.Size(1057, 578);
            this.ltvVenda.TabIndex = 7;
            this.ltvVenda.UseCompatibleStateImageBehavior = false;
            this.ltvVenda.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 80;
            // 
            // nome
            // 
            this.nome.Text = "Nome do cliente";
            this.nome.Width = 350;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 140;
            // 
            // datavenda
            // 
            this.datavenda.Text = "Data / Hora";
            this.datavenda.Width = 140;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 140;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 633);
            this.Controls.Add(this.btnTodosProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscaProduto);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.ltvVenda);
            this.KeyPreview = true;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Vendas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVenda_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTodosProdutos;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnbuscaProduto;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.ListView ltvVenda;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader datavenda;
        private System.Windows.Forms.ColumnHeader status;
    }
}