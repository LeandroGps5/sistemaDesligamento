namespace sistemaDesligamento
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
            this.dtAgendar = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txbMinutos = new System.Windows.Forms.TextBox();
            this.btnAgendarMin = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtAgendar
            // 
            this.dtAgendar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtAgendar.Location = new System.Drawing.Point(224, 69);
            this.dtAgendar.Name = "dtAgendar";
            this.dtAgendar.Size = new System.Drawing.Size(200, 20);
            this.dtAgendar.TabIndex = 0;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(284, 110);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txbMinutos
            // 
            this.txbMinutos.Location = new System.Drawing.Point(271, 235);
            this.txbMinutos.Name = "txbMinutos";
            this.txbMinutos.Size = new System.Drawing.Size(100, 20);
            this.txbMinutos.TabIndex = 2;
            // 
            // btnAgendarMin
            // 
            this.btnAgendarMin.Location = new System.Drawing.Point(284, 284);
            this.btnAgendarMin.Name = "btnAgendarMin";
            this.btnAgendarMin.Size = new System.Drawing.Size(75, 23);
            this.btnAgendarMin.TabIndex = 3;
            this.btnAgendarMin.Text = "Agendar";
            this.btnAgendarMin.UseVisualStyleBackColor = true;
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(256, 409);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(115, 23);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar Agora";
            this.btnDesligar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(271, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha o Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desligar Daqui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Outros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnAgendarMin);
            this.Controls.Add(this.txbMinutos);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dtAgendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtAgendar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txbMinutos;
        private System.Windows.Forms.Button btnAgendarMin;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

