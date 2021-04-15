using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Configuration;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5
{
    public partial class FormOrdenacao : Form
    {
        int tamVet = 1000, codOrdenacao = 2;
        int[] vet = new int[500]; // vetor interno para a animação
        string nomeOrdenacao = "Aleatória";
        





        public FormOrdenacao()
        {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                e.Graphics.DrawLine(Pens.Olive, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Métodos de Ordenação - 2020/2\n\n" +
                "Desenvolvido por:\n72000848 - Samuel Alves Braga\n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Somente para fins didáticos.",
                "Sobre o trabalho...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a)
        {
            if (bgw.IsBusy != true)
            {
                
                bgw.RunWorkerAsync(a);
            }
            else
            {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Métodos de Ordenação - 2020/2",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this,
               "Animação concluída!",
               "Métodos de Ordenação - 2020/2",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            int[] vetor = new int[tamVet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch(codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break;

            }
       
            
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }

        private void seleçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamVet]; ; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch (codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break;

            }
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.selecao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Seleção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void inserçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamVet]; ; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch (codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break;

            }
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.insercao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                 "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Inserção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void shellSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamVet]; ; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch (codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break;

            }
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.shellSort(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                 "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método ShellSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length -1, panel));
        }

        private void quickSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamVet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch (codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break;

            }
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.quickSort(vetor, 0, vetor.Length-1);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método QuickSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void heapSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamVet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch (codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break; ;

            }
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.heapSort(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método HeapSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void mergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, 0, vet.Length -1, panel));
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[tamVet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            switch (codOrdenacao)
            {
                case 0:
                    Preenchimento.Crescente(vetor);
                    break;
                case 1:
                    Preenchimento.Decrescente(vetor);
                    break;
                case 2:
                    Preenchimento.Aleatorio(vetor, tamVet);
                    break;

            }
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.mergeSort(vetor, 0, vetor.Length -1);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamVet +
                  "\nOrdenação inicial: " + nomeOrdenacao +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método MergeSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tamVet = 1000;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            tamVet = 500000;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tamVet = 10000;
        }



        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tamVet = 50000;
        }

      

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tamVet = 100000;
        }

  

        private void crescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codOrdenacao = 0;
            nomeOrdenacao = "Crescente";
            
        }

        private void decrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codOrdenacao = 1;
            nomeOrdenacao = "Decrescente";
            
        }

        private void aleatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codOrdenacao = 2;
            nomeOrdenacao = "Aleatória";
        }


        private void crescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet);
        }


        private void decrescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet);
        }

        private void aleatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
        }



    }
}
