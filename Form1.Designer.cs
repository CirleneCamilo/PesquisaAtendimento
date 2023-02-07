namespace PesquisaAtendimento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbSim = new System.Windows.Forms.Label();
            this.LbNao = new System.Windows.Forms.Label();
            this.BtSim = new System.Windows.Forms.Button();
            this.BtNao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você ficou satisfeito com o atendimento da nossa loja ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(195, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sim :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(296, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Não :";
            // 
            // LbSim
            // 
            this.LbSim.AutoSize = true;
            this.LbSim.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSim.Location = new System.Drawing.Point(258, 313);
            this.LbSim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSim.Name = "LbSim";
            this.LbSim.Size = new System.Drawing.Size(29, 29);
            this.LbSim.TabIndex = 3;
            this.LbSim.Text = "0";
            // 
            // LbNao
            // 
            this.LbNao.AutoSize = true;
            this.LbNao.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNao.Location = new System.Drawing.Point(363, 313);
            this.LbNao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNao.Name = "LbNao";
            this.LbNao.Size = new System.Drawing.Size(29, 29);
            this.LbNao.TabIndex = 4;
            this.LbNao.Text = "0";
            // 
            // BtSim
            // 
            this.BtSim.BackColor = System.Drawing.Color.Blue;
            this.BtSim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtSim.FlatAppearance.BorderSize = 3;
            this.BtSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSim.ForeColor = System.Drawing.Color.White;
            this.BtSim.Location = new System.Drawing.Point(164, 211);
            this.BtSim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtSim.Name = "BtSim";
            this.BtSim.Size = new System.Drawing.Size(86, 49);
            this.BtSim.TabIndex = 5;
            this.BtSim.Text = "Sim";
            this.BtSim.UseVisualStyleBackColor = false;
            this.BtSim.Click += new System.EventHandler(this.BtSim_Click);
            // 
            // BtNao
            // 
            this.BtNao.BackColor = System.Drawing.Color.Blue;
            this.BtNao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtNao.FlatAppearance.BorderSize = 3;
            this.BtNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNao.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNao.ForeColor = System.Drawing.Color.White;
            this.BtNao.Location = new System.Drawing.Point(318, 211);
            this.BtNao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtNao.Name = "BtNao";
            this.BtNao.Size = new System.Drawing.Size(88, 49);
            this.BtNao.TabIndex = 6;
            this.BtNao.Text = "Não";
            this.BtNao.UseVisualStyleBackColor = false;
            this.BtNao.Click += new System.EventHandler(this.BtNao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtNao);
            this.Controls.Add(this.BtSim);
            this.Controls.Add(this.LbNao);
            this.Controls.Add(this.LbSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pesquisar o Atendimento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbSim;
        private System.Windows.Forms.Label LbNao;
        private System.Windows.Forms.Button BtSim;
        private System.Windows.Forms.Button BtNao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

