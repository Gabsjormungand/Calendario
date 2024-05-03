namespace Calendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataInicial = new System.Windows.Forms.TextBox();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.btnPegarData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataInicial2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDataFinal2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDataAtual2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual:";
            // 
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Location = new System.Drawing.Point(478, 54);
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(172, 26);
            this.textBoxDataInicial.TabIndex = 4;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Location = new System.Drawing.Point(478, 91);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(172, 26);
            this.textBoxDataFinal.TabIndex = 5;
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Location = new System.Drawing.Point(478, 127);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.Size = new System.Drawing.Size(172, 26);
            this.textBoxDataAtual.TabIndex = 6;
            // 
            // btnPegarData
            // 
            this.btnPegarData.Location = new System.Drawing.Point(383, 173);
            this.btnPegarData.Name = "btnPegarData";
            this.btnPegarData.Size = new System.Drawing.Size(267, 32);
            this.btnPegarData.TabIndex = 7;
            this.btnPegarData.Text = "Selecionar Data";
            this.btnPegarData.UseVisualStyleBackColor = true;
            this.btnPegarData.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Inicial:";
            // 
            // textBoxDataInicial2
            // 
            this.textBoxDataInicial2.Location = new System.Drawing.Point(126, 304);
            this.textBoxDataInicial2.Name = "textBoxDataInicial2";
            this.textBoxDataInicial2.Size = new System.Drawing.Size(130, 26);
            this.textBoxDataInicial2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Final:";
            // 
            // textBoxDataFinal2
            // 
            this.textBoxDataFinal2.Location = new System.Drawing.Point(126, 339);
            this.textBoxDataFinal2.Name = "textBoxDataFinal2";
            this.textBoxDataFinal2.Size = new System.Drawing.Size(130, 26);
            this.textBoxDataFinal2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Atual:";
            // 
            // textBoxDataAtual2
            // 
            this.textBoxDataAtual2.Location = new System.Drawing.Point(126, 371);
            this.textBoxDataAtual2.Name = "textBoxDataAtual2";
            this.textBoxDataAtual2.Size = new System.Drawing.Size(130, 26);
            this.textBoxDataAtual2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 571);
            this.Controls.Add(this.textBoxDataAtual2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDataFinal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDataInicial2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPegarData);
            this.Controls.Add(this.textBoxDataAtual);
            this.Controls.Add(this.textBoxDataFinal);
            this.Controls.Add(this.textBoxDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDataInicial;
        private System.Windows.Forms.TextBox textBoxDataFinal;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.Button btnPegarData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDataInicial2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDataFinal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDataAtual2;
    }
}

