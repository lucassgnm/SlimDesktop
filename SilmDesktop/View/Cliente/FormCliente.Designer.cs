namespace SilmDesktop.View.Cliente
{
    partial class FormCliente
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
            this.btnTodosProdutos = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscaCliente = new MetroFramework.Controls.MetroButton();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.ltvClientes = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTodosProdutos
            // 
            this.btnTodosProdutos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTodosProdutos.Location = new System.Drawing.Point(724, 587);
            this.btnTodosProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTodosProdutos.Name = "btnTodosProdutos";
            this.btnTodosProdutos.Size = new System.Drawing.Size(229, 42);
            this.btnTodosProdutos.TabIndex = 11;
            this.btnTodosProdutos.Text = "Limpar pesquisa";
            this.btnTodosProdutos.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.Location = new System.Drawing.Point(9, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "O carregamento dos clientes pode variar de acordo com a quantidade de itens a ser" +
    "em exibidos*";
            // 
            // btnbuscaCliente
            // 
            this.btnbuscaCliente.Location = new System.Drawing.Point(376, 585);
            this.btnbuscaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscaCliente.Name = "btnbuscaCliente";
            this.btnbuscaCliente.Size = new System.Drawing.Size(165, 26);
            this.btnbuscaCliente.TabIndex = 8;
            this.btnbuscaCliente.Text = "Pesquisar cliente";
            this.btnbuscaCliente.UseSelectable = true;
            this.btnbuscaCliente.Click += new System.EventHandler(this.btnbuscaCliente_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(8, 585);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(361, 26);
            this.txtNomeCliente.TabIndex = 6;
            // 
            // ltvClientes
            // 
            this.ltvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.email,
            this.cpf,
            this.telefone});
            this.ltvClientes.FullRowSelect = true;
            this.ltvClientes.GridLines = true;
            this.ltvClientes.HideSelection = false;
            this.ltvClientes.Location = new System.Drawing.Point(-1, 1);
            this.ltvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltvClientes.Name = "ltvClientes";
            this.ltvClientes.Size = new System.Drawing.Size(1144, 578);
            this.ltvClientes.TabIndex = 7;
            this.ltvClientes.UseCompatibleStateImageBehavior = false;
            this.ltvClientes.View = System.Windows.Forms.View.Details;
            this.ltvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltvClientes_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 80;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 250;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 250;
            // 
            // cpf
            // 
            this.cpf.Text = "CPF";
            this.cpf.Width = 140;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.Width = 140;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.ShowImageMargin = false;
            this.metroContextMenu1.Size = new System.Drawing.Size(97, 52);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 636);
            this.Controls.Add(this.btnTodosProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscaCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.ltvClientes);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Clientes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCliente_KeyDown);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTodosProdutos;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnbuscaCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ListView ltvClientes;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader telefone;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}