using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogodeNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogodeNumeros()
        {
            InitializeComponent();
        }

        private void frmJogodeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); // Número aleatório entre 1 a 100
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            
            //Verifica se o número de tentativas chegou a 0
            if(numeroTentativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou!";
                return;
            }
            
            //Validação do valor do palpite (entre 1 e 100)
            if(!int.TryParse(txtNumeroInserido.Text, out palpitedoJogador) || palpitedoJogador < 1 || palpitedoJogador > 100)
            {
                txtResultado.Text = "Por favor, insira um numero entre 1 e 100.";
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();
           
            if (palpitedoJogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Parabéns, você acertou!";
            }
            else if (palpitedoJogador < randomNumber)
            {
                dica = "O número do seu palpite é menor";
            }
            else
            {
                dica = "O número do seu palpite é maior";
            }

            txtResultado.Text = dica;

        }
    }
}
