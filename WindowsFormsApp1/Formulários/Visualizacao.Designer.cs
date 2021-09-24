namespace IBPT
{
    partial class Visualizacao
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
            this.btnRetornarProdutos = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.bbtnAtualizar = new System.Windows.Forms.Button();
            this.bbtnLimpar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Concluido = new System.Windows.Forms.PictureBox();
            this.NaoConcluido = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bbtnRodaProcedure = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.NumReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Concluido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaoConcluido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornarProdutos
            // 
            this.btnRetornarProdutos.Location = new System.Drawing.Point(36, 53);
            this.btnRetornarProdutos.Name = "btnRetornarProdutos";
            this.btnRetornarProdutos.Size = new System.Drawing.Size(134, 31);
            this.btnRetornarProdutos.TabIndex = 3;
            this.btnRetornarProdutos.Text = "Retornar Produtos";
            this.btnRetornarProdutos.UseVisualStyleBackColor = true;
            this.btnRetornarProdutos.Click += new System.EventHandler(this.bbtnRetornarProdutos_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(189, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(995, 335);
            this.DGV.TabIndex = 5;
            // 
            // bbtnAtualizar
            // 
            this.bbtnAtualizar.Location = new System.Drawing.Point(36, 110);
            this.bbtnAtualizar.Name = "bbtnAtualizar";
            this.bbtnAtualizar.Size = new System.Drawing.Size(134, 31);
            this.bbtnAtualizar.TabIndex = 6;
            this.bbtnAtualizar.Text = "Atualizar";
            this.bbtnAtualizar.UseVisualStyleBackColor = true;
            this.bbtnAtualizar.Click += new System.EventHandler(this.bbtnAtualizar_Click);
            // 
            // bbtnLimpar
            // 
            this.bbtnLimpar.Location = new System.Drawing.Point(36, 300);
            this.bbtnLimpar.Name = "bbtnLimpar";
            this.bbtnLimpar.Size = new System.Drawing.Size(134, 31);
            this.bbtnLimpar.TabIndex = 7;
            this.bbtnLimpar.Text = "Limpar";
            this.bbtnLimpar.UseVisualStyleBackColor = true;
            this.bbtnLimpar.Click += new System.EventHandler(this.bbtnLimpar_Click);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.White;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titulo.Location = new System.Drawing.Point(36, 12);
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Size = new System.Drawing.Size(134, 13);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Comandos";
            this.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Concluido
            // 
            this.Concluido.BackColor = System.Drawing.Color.White;
            this.Concluido.Location = new System.Drawing.Point(36, 165);
            this.Concluido.Name = "Concluido";
            this.Concluido.Size = new System.Drawing.Size(30, 26);
            this.Concluido.TabIndex = 9;
            this.Concluido.TabStop = false;
            // 
            // NaoConcluido
            // 
            this.NaoConcluido.BackColor = System.Drawing.Color.White;
            this.NaoConcluido.Location = new System.Drawing.Point(36, 213);
            this.NaoConcluido.Name = "NaoConcluido";
            this.NaoConcluido.Size = new System.Drawing.Size(30, 26);
            this.NaoConcluido.TabIndex = 10;
            this.NaoConcluido.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(82, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Concluida";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(82, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Não Concluida";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bbtnRodaProcedure
            // 
            this.bbtnRodaProcedure.Location = new System.Drawing.Point(36, 254);
            this.bbtnRodaProcedure.Name = "bbtnRodaProcedure";
            this.bbtnRodaProcedure.Size = new System.Drawing.Size(134, 31);
            this.bbtnRodaProcedure.TabIndex = 13;
            this.bbtnRodaProcedure.Text = "Rodar Procedure";
            this.bbtnRodaProcedure.UseVisualStyleBackColor = true;
            this.bbtnRodaProcedure.Visible = false;
            this.bbtnRodaProcedure.Click += new System.EventHandler(this.bbtnRodaProcedure_Click);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(488, 156);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(434, 35);
            this.pbar.TabIndex = 14;
            this.pbar.Visible = false;
            // 
            // label1
            // 
            this.NumReg.AutoSize = true;
            this.NumReg.Location = new System.Drawing.Point(1043, 350);
            this.NumReg.Name = "label1";
            this.NumReg.Size = new System.Drawing.Size(76, 13);
            this.NumReg.TabIndex = 15;
            this.NumReg.Text = "NumRegistros:";
            // 
            // Visualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 363);
            this.Controls.Add(this.NumReg);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.bbtnRodaProcedure);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NaoConcluido);
            this.Controls.Add(this.Concluido);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.bbtnLimpar);
            this.Controls.Add(this.bbtnAtualizar);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnRetornarProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Visualizacao";
            this.Text = "IBPT";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Concluido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaoConcluido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRetornarProdutos;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button bbtnAtualizar;
        private System.Windows.Forms.Button bbtnLimpar;
        private System.Windows.Forms.TextBox Titulo;
        public System.Windows.Forms.PictureBox Concluido;
        public System.Windows.Forms.PictureBox NaoConcluido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bbtnRodaProcedure;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label NumReg;
    }
}

