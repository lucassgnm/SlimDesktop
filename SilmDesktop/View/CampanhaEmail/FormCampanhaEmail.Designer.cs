namespace SilmDesktop.View.CampanhaEmail
{
    partial class FormCampanhaEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCampanhaEmail));
            this.txtCorpo = new System.Windows.Forms.RichTextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txtCorpo
            // 
            this.txtCorpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpo.Location = new System.Drawing.Point(23, 135);
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(566, 262);
            this.txtCorpo.TabIndex = 0;
            this.txtCorpo.Text = "";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(23, 76);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(566, 24);
            this.txtAssunto.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Assunto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Corpo do email:";
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.BackColor = System.Drawing.Color.Salmon;
            this.metroTile7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile7.Location = new System.Drawing.Point(212, 411);
            this.metroTile7.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(189, 65);
            this.metroTile7.TabIndex = 20;
            this.metroTile7.Text = "Enviar emails";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile7.UseCustomBackColor = true;
            this.metroTile7.UseCustomForeColor = true;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // FormCampanhaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 492);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtCorpo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCampanhaEmail";
            this.Resizable = false;
            this.Text = "Enviar email em massa:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCorpo;
        private System.Windows.Forms.TextBox txtAssunto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile7;
    }
}