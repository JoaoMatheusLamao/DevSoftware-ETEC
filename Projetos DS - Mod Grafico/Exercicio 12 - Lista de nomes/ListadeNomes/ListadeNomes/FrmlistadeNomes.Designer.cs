namespace ListadeNomes
{
    partial class FrmlistadeNomes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.btAdiciona = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btRemoveTudo = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item para lista";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.ItemHeight = 16;
            this.lstNome.Location = new System.Drawing.Point(28, 73);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(213, 276);
            this.lstNome.Sorted = true;
            this.lstNome.TabIndex = 2;
            this.lstNome.SelectedIndexChanged += new System.EventHandler(this.lstNome_SelectedIndexChanged);
            // 
            // btAdiciona
            // 
            this.btAdiciona.Location = new System.Drawing.Point(247, 73);
            this.btAdiciona.Name = "btAdiciona";
            this.btAdiciona.Size = new System.Drawing.Size(131, 32);
            this.btAdiciona.TabIndex = 3;
            this.btAdiciona.Text = "&Adiciona";
            this.btAdiciona.UseVisualStyleBackColor = true;
            this.btAdiciona.Click += new System.EventHandler(this.btAdiciona_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(247, 133);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(131, 32);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "&RemoveItem";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btRemoveTudo
            // 
            this.btRemoveTudo.Location = new System.Drawing.Point(247, 194);
            this.btRemoveTudo.Name = "btRemoveTudo";
            this.btRemoveTudo.Size = new System.Drawing.Size(131, 32);
            this.btRemoveTudo.TabIndex = 5;
            this.btRemoveTudo.Text = "Remove&Tudo";
            this.btRemoveTudo.UseVisualStyleBackColor = true;
            this.btRemoveTudo.Click += new System.EventHandler(this.btRemoveTudo_Click);
            // 
            // btCancela
            // 
            this.btCancela.Location = new System.Drawing.Point(247, 256);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(131, 32);
            this.btCancela.TabIndex = 6;
            this.btCancela.Text = "&Cancela";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(247, 317);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(131, 32);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FrmlistadeNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.btRemoveTudo);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdiciona);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmlistadeNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de nomes";
            this.Load += new System.EventHandler(this.FrmlistadeNomes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.Button btAdiciona;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btRemoveTudo;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Button btSair;
    }
}

