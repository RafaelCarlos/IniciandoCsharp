using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIniciando
{
    public partial class Form1 : Form
    {
        private Conta [] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idade1 = 10;
            int idade2 = 20;
            int idade3 = 40;
            
            float resultado = (idade1 + idade2 + idade3) /3;
            string teste = "O resultado é: ";
            MessageBox.Show(teste + resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.contas = new Conta[3];

            // vamos inicializar algumas instâncias de Conta.
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("mauricio");
            this.contas[1].Numero = 2;
            
            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("Rafael");
            this.contas[2].Numero = 3;


            comboContas.Items.Add("Texto que aparecerá no combo box");

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
        
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {

            // primeiro precisamos recuperar o índice da conta selecionada
            int indice = Convert.ToInt32(textoIndice.Text);
            // e depois precisamos ler a posição correta do array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            // primeiro precisamos recuperar o índice da conta selecionada
            int indice = Convert.ToInt32(textoIndice.Text);
            // e depois precisamos ler a posição correta do array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void textoIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }
    }
}
