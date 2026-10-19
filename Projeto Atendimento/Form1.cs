using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
            btnGerar.Click += btnGerar_Click;
            btnAdicionarGuiche.Click += btnAdicionarGuiche_Click;
            btnChamar.Click += btnChamar_Click;
            btnListarSenhas.Click += btnListarSenhas_Click;
            btnListarAtendimentos.Click += btnListarAtendimentos_Click;
            AtualizarTotalGuiches();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            AtualizarListaSenhas();
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            int novoId = guiches.ListaGuiches.Count + 1;
            guiches.adicionar(new Guiche(novoId));
            AtualizarTotalGuiches();
            MessageBox.Show($"Guichê {novoId} adicionado com sucesso!", "Guichê Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuiche.Text, out int idGuiche) || idGuiche <= 0)
            {
                MessageBox.Show("Informe um número de guichê válido no campo Guichê.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guiche guicheSelecionado = guiches.ListaGuiches.Find(g => g.Id == idGuiche);

            if (guicheSelecionado == null)
            {
                MessageBox.Show($"Guichê {idGuiche} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool sucesso = guicheSelecionado.chamar(senhas.FilaSenhas);

            if (sucesso)
            {
                AtualizarListaSenhas();
                AtualizarListaAtendimentos(guicheSelecionado);
            }
            else
            {
                MessageBox.Show("Não há senhas aguardando atendimento na fila.", "Fila Vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            AtualizarListaSenhas();
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuiche.Text, out int idGuiche) || idGuiche <= 0)
            {
                MessageBox.Show("Informe o ID do guichê para listar seus atendimentos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guiche guicheSelecionado = guiches.ListaGuiches.Find(g => g.Id == idGuiche);

            if (guicheSelecionado == null)
            {
                MessageBox.Show($"Guichê {idGuiche} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AtualizarListaAtendimentos(guicheSelecionado);
        }

        private void AtualizarListaSenhas()
        {
            lstSenhas.Items.Clear();
            foreach (Senha s in senhas.FilaSenhas)
            {
                lstSenhas.Items.Add(s.dadosParciais());
            }
        }

        private void AtualizarListaAtendimentos(Guiche guiche)
        {
            lstAtendimentos.Items.Clear();
            foreach (Senha s in guiche.Atendimentos)
            {
                lstAtendimentos.Items.Add(s.dadosCompletos());
            }
        }

        private void AtualizarTotalGuiches()
        {
            if (lblQtdeGuiches != null)
            {
                lblQtdeGuiches.Text = $"Guichês cadastrados: {guiches.ListaGuiches.Count}";
            }
        }
    }
}
