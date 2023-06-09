namespace Exercicio_list_box
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codProduto = new System.Windows.Forms.TextBox();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.txt_valorProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_addItem = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_apagaItem = new System.Windows.Forms.Button();
            this.bt_limpaLista = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código_Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // txt_codProduto
            // 
            this.txt_codProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codProduto.Location = new System.Drawing.Point(129, 28);
            this.txt_codProduto.Name = "txt_codProduto";
            this.txt_codProduto.Size = new System.Drawing.Size(67, 22);
            this.txt_codProduto.TabIndex = 3;
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeProduto.Location = new System.Drawing.Point(75, 80);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(121, 22);
            this.txt_nomeProduto.TabIndex = 4;
            // 
            // txt_valorProduto
            // 
            this.txt_valorProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorProduto.Location = new System.Drawing.Point(75, 133);
            this.txt_valorProduto.Name = "txt_valorProduto";
            this.txt_valorProduto.Size = new System.Drawing.Size(121, 22);
            this.txt_valorProduto.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_valorProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nomeProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_codProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 244);
            this.listBox1.TabIndex = 7;
            // 
            // bt_addItem
            // 
            this.bt_addItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addItem.Location = new System.Drawing.Point(15, 31);
            this.bt_addItem.Name = "bt_addItem";
            this.bt_addItem.Size = new System.Drawing.Size(104, 34);
            this.bt_addItem.TabIndex = 8;
            this.bt_addItem.Text = "&Adcionar";
            this.bt_addItem.UseVisualStyleBackColor = true;
            this.bt_addItem.Click += new System.EventHandler(this.bt_addItem_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(15, 102);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(104, 34);
            this.bt_cancelar.TabIndex = 9;
            this.bt_cancelar.Text = "&Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_fechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_fechar.Location = new System.Drawing.Point(27, 119);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(82, 34);
            this.bt_fechar.TabIndex = 10;
            this.bt_fechar.Text = "&Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_addItem);
            this.groupBox2.Controls.Add(this.bt_cancelar);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 168);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // bt_apagaItem
            // 
            this.bt_apagaItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_apagaItem.Location = new System.Drawing.Point(15, 19);
            this.bt_apagaItem.Name = "bt_apagaItem";
            this.bt_apagaItem.Size = new System.Drawing.Size(104, 34);
            this.bt_apagaItem.TabIndex = 11;
            this.bt_apagaItem.Text = "Apaga &Item";
            this.bt_apagaItem.UseVisualStyleBackColor = true;
            this.bt_apagaItem.Click += new System.EventHandler(this.bt_apagaItem_Click);
            // 
            // bt_limpaLista
            // 
            this.bt_limpaLista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpaLista.Location = new System.Drawing.Point(15, 67);
            this.bt_limpaLista.Name = "bt_limpaLista";
            this.bt_limpaLista.Size = new System.Drawing.Size(104, 34);
            this.bt_limpaLista.TabIndex = 12;
            this.bt_limpaLista.Text = "Limpa &Lista";
            this.bt_limpaLista.UseVisualStyleBackColor = true;
            this.bt_limpaLista.Click += new System.EventHandler(this.bt_limpaLista_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_apagaItem);
            this.groupBox3.Controls.Add(this.bt_limpaLista);
            this.groupBox3.Controls.Add(this.bt_fechar);
            this.groupBox3.Location = new System.Drawing.Point(227, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 168);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codProduto;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.TextBox txt_valorProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_addItem;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_apagaItem;
        private System.Windows.Forms.Button bt_limpaLista;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

