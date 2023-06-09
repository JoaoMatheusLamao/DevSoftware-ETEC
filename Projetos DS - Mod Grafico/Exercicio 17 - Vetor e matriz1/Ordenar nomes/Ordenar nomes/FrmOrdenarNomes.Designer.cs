namespace Ordenar_nomes
{
    partial class FrmOrdenarNomes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnome1 = new System.Windows.Forms.TextBox();
            this.txtnome2 = new System.Windows.Forms.TextBox();
            this.txtnome3 = new System.Windows.Forms.TextBox();
            this.txtnome4 = new System.Windows.Forms.TextBox();
            this.txtnome5 = new System.Windows.Forms.TextBox();
            this.btClassificar = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listas de Nomes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnome5);
            this.groupBox1.Controls.Add(this.txtnome4);
            this.groupBox1.Controls.Add(this.txtnome3);
            this.groupBox1.Controls.Add(this.txtnome2);
            this.groupBox1.Controls.Add(this.txtnome1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(365, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btFechar);
            this.groupBox3.Controls.Add(this.btCancela);
            this.groupBox3.Controls.Add(this.btClassificar);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "1° nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "2° nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "3° nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "4° nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "5° nome";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 170);
            this.label7.TabIndex = 5;
            // 
            // txtnome1
            // 
            this.txtnome1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome1.Location = new System.Drawing.Point(95, 22);
            this.txtnome1.Name = "txtnome1";
            this.txtnome1.Size = new System.Drawing.Size(225, 23);
            this.txtnome1.TabIndex = 6;
            // 
            // txtnome2
            // 
            this.txtnome2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome2.Location = new System.Drawing.Point(95, 59);
            this.txtnome2.Name = "txtnome2";
            this.txtnome2.Size = new System.Drawing.Size(225, 23);
            this.txtnome2.TabIndex = 7;
            // 
            // txtnome3
            // 
            this.txtnome3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome3.Location = new System.Drawing.Point(95, 97);
            this.txtnome3.Name = "txtnome3";
            this.txtnome3.Size = new System.Drawing.Size(225, 23);
            this.txtnome3.TabIndex = 8;
            // 
            // txtnome4
            // 
            this.txtnome4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome4.Location = new System.Drawing.Point(95, 135);
            this.txtnome4.Name = "txtnome4";
            this.txtnome4.Size = new System.Drawing.Size(225, 23);
            this.txtnome4.TabIndex = 9;
            // 
            // txtnome5
            // 
            this.txtnome5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome5.Location = new System.Drawing.Point(95, 172);
            this.txtnome5.Name = "txtnome5";
            this.txtnome5.Size = new System.Drawing.Size(225, 23);
            this.txtnome5.TabIndex = 10;
            // 
            // btClassificar
            // 
            this.btClassificar.Location = new System.Drawing.Point(30, 23);
            this.btClassificar.Name = "btClassificar";
            this.btClassificar.Size = new System.Drawing.Size(127, 35);
            this.btClassificar.TabIndex = 0;
            this.btClassificar.Text = "&Classificar";
            this.btClassificar.UseVisualStyleBackColor = true;
            this.btClassificar.Click += new System.EventHandler(this.btClassificar_Click);
            // 
            // btCancela
            // 
            this.btCancela.Location = new System.Drawing.Point(217, 22);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(127, 35);
            this.btCancela.TabIndex = 1;
            this.btCancela.Text = "&Cancela";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(408, 22);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(127, 35);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "&Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FrmOrdenarNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmOrdenarNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificar Nomes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnome5;
        private System.Windows.Forms.TextBox txtnome4;
        private System.Windows.Forms.TextBox txtnome3;
        private System.Windows.Forms.TextBox txtnome2;
        private System.Windows.Forms.TextBox txtnome1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Button btClassificar;
    }
}

