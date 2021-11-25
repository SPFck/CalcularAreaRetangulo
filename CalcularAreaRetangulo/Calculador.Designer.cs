namespace CalcularAreaRetangulo
{
    partial class Calculador
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
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.txt_altura = new MonoFlat.MonoFlat_TextBox();
            this.txt_base = new MonoFlat.MonoFlat_TextBox();
            this.btnSair = new MonoFlat.MonoFlat_Button();
            this.txt_Resultado = new MonoFlat.MonoFlat_TextBox();
            this.btnLimpar = new MonoFlat.MonoFlat_Button();
            this.btnCalcular = new MonoFlat.MonoFlat_Button();
            this.lb_Resultado = new MonoFlat.MonoFlat_Label();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.lb_Resultado);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnCalcular);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnLimpar);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_Resultado);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnSair);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_altura);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_base);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = false;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(357, 318);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Calcular Area Retângulo";
            // 
            // txt_altura
            // 
            this.txt_altura.BackColor = System.Drawing.Color.Transparent;
            this.txt_altura.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_altura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_altura.Image = null;
            this.txt_altura.Location = new System.Drawing.Point(12, 128);
            this.txt_altura.MaxLength = 32767;
            this.txt_altura.Multiline = false;
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.ReadOnly = false;
            this.txt_altura.Size = new System.Drawing.Size(332, 41);
            this.txt_altura.TabIndex = 1;
            this.txt_altura.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_altura.UseSystemPasswordChar = false;
            // 
            // txt_base
            // 
            this.txt_base.BackColor = System.Drawing.Color.Transparent;
            this.txt_base.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_base.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_base.Image = null;
            this.txt_base.Location = new System.Drawing.Point(12, 73);
            this.txt_base.MaxLength = 32767;
            this.txt_base.Multiline = false;
            this.txt_base.Name = "txt_base";
            this.txt_base.ReadOnly = false;
            this.txt_base.Size = new System.Drawing.Size(332, 41);
            this.txt_base.TabIndex = 0;
            this.txt_base.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_base.UseSystemPasswordChar = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSair.Image = null;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(247, 175);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 41);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.txt_Resultado.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_Resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_Resultado.Image = null;
            this.txt_Resultado.Location = new System.Drawing.Point(18, 261);
            this.txt_Resultado.MaxLength = 32767;
            this.txt_Resultado.Multiline = false;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(326, 41);
            this.txt_Resultado.TabIndex = 3;
            this.txt_Resultado.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Resultado.UseSystemPasswordChar = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpar.Image = null;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(13, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalcular.Image = null;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(131, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 41);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.lb_Resultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Resultado.ForeColor = System.Drawing.Color.White;
            this.lb_Resultado.Location = new System.Drawing.Point(13, 233);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(103, 25);
            this.lb_Resultado.TabIndex = 6;
            this.lb_Resultado.Text = "Resultado: ";
            // 
            // Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 318);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculador";
            this.Text = "Calcular Area Retângulo";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_TextBox txt_altura;
        private MonoFlat.MonoFlat_TextBox txt_base;
        private MonoFlat.MonoFlat_Label lb_Resultado;
        private MonoFlat.MonoFlat_Button btnCalcular;
        private MonoFlat.MonoFlat_Button btnLimpar;
        private MonoFlat.MonoFlat_TextBox txt_Resultado;
        private MonoFlat.MonoFlat_Button btnSair;
    }
}

