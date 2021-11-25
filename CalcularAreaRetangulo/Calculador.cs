using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularAreaRetangulo
{
    public partial class Calculador : Form
    {
        public Calculador() {
            InitializeComponent();
        }

        private void txt_base_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult pergunta = MessageBox.Show("Deseja mesmo sair do programa?", "Confirmação", MessageBoxButtons.YesNo);
            if(pergunta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txt_altura.Text = "";
            txt_base.Text = "";
            txt_Resultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            CalcularAreaRetangulo rec = new CalcularAreaRetangulo();

            if(txt_altura.Text == "" || txt_base.Text == "") {
                MessageBox.Show("Algum argumento está em falta!");
            } else {
                rec.lado1 = float.Parse(txt_altura.Text);
                rec.lado2 = float.Parse(txt_base.Text);
                txt_Resultado.Text = Convert.ToString(rec.area(rec.lado1, rec.lado2));
            }
        }
    }
}
