using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulariosimples
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //Validação de campos obrigatórios--------------------------------------------------------------------------------------

            //Validação textBox
            if (string.IsNullOrWhiteSpace(txtNumeroCadastro.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro");
                return; //Interrompe a execução do código caso o campo esteja vazio
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo");
                return;
            }

            //Validação DateTimePicker -Data de Nascimento
            dataNascimento = dateTimePicker1.Value.Date;

            //Verifica se a data é posterior ou igual à data atual 
            if (dataNascimento >= DateTime.Now.Date) //Compara com a data atual sem hora
            {
                MessageBox.Show("Verifique novamente sua data de nascimento.");
                return;
            }

            //Validação comboBox
            if (comboBoxCidade.SelectedItem == null) 
            {
                MessageBox.Show("Por favor, selecione a cidade");
                return;
            }

            //Validação radioButton
            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked) 
            {
                MessageBox.Show("Por favor, selecione o gênero");
                return;
            }


            //Agora, caso todos estejam preenchidos, a validação prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastro.Text);
            nomeUsuario = txtNomeCompleto.Text;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            
            //Determinar o gênero selecionado
            string generoSelecionado = "não informado"; //Caso nenhum gênero seja selecionado
            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else if (generoNB)
                generoSelecionado = "Não Binário";

            //Exibir as informações em message box
            MessageBox.Show("Número Cadastrado: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de nascimento: " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero: " + generoSelecionado);

        }

        private void txtNumeroCadastro_Click(object sender, EventArgs e)
        {
            //Limpa o conteúdo do TextBox quando o usuário clicar nele
            if (txtNumeroCadastro.Text == "Número Cadastro")
            {
                txtNumeroCadastro.Text = "";
            }
            
        }

        private void txtNomeCompleto_Click(object sender, EventArgs e)
        {
            //Limpa o conteúdo do TextBox quando o usuário clicar nele
            if (txtNomeCompleto.Text == "Insira o seu nome completo")
            {
                txtNomeCompleto.Text = "";
            }
        }
    }    
}
