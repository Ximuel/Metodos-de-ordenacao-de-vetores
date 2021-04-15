using System.Diagnostics;

namespace Pratica5 {
    class OrdenacaoEstatistica {
        // TODO: contador de comparações e trocas
        // TODO: declarar demais métodos de ordenação
        public static int cont_c, cont_t;
        public static void Bolha(int[] vet) {
            cont_c = 0;
            cont_t = 0;
            int i, j, temp;
            for (i = 0; i < vet.Length - 1; i++) {
                for (j = vet.Length - 1; j > i; j--) {
                    cont_c++;
                    if (vet[j] < vet[j - 1]) {
                        temp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = temp;
                        cont_t++;
                    }
                }
            }
        }

        public static void selecao(int[] vet)
        {
            cont_c = 0;
            cont_t = 0;
            int i, j, min, temp;
            for (i = 0; i < vet.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < vet.Length; j++)
                {
                    cont_c++;
                    if (vet[j] < vet[min])
                    {
                        min = j;
                        
                    }
                }
                temp = vet[i];
                vet[i] = vet[min];
                vet[min] = temp;
                cont_t++;
            }
        }

        public static void insercao(int[] vet)
        {
            cont_c = 0;
            cont_t = 0;
            int temp, i, j;
            for (i = 1; i < vet.Length; i++)
            {
                temp = vet[i];
                j = i - 1;
                while (j >= 0 && temp < vet[j]) 
                {
                    vet[j + 1] = vet[j];
                    cont_t++;
                    cont_c++;
                    j--;
                    
                }
                vet[j + 1] = temp;
                
            }
        }

        public static void shellSort(int[] vet)
        {
            cont_c = 0;
            cont_t = 0;
            int i, j, x, n;
            int h = 1;
            n = vet.Length;
            do
            {
                h = h * 3 + 1;
            } while (h <= n); 
            do
            {
                
                h /= 3;
                for (i = h; i < n; i++)
                {
                    
                    x = vet[i];
                    j = i;
                    while (j > (h - 1) && vet[j - h] > x)
                    {
                        
                        vet[j] = vet[j - h];
                        j -= h;
                        cont_t++;
                    }
                    vet[j] = x;
                }
                cont_c++;
            } while (h != 1);
        }

        public static void quickSort(int[] vet, int esq, int dir)
        {
            cont_c = 0;
            cont_t = 0;
            int i, j, x, temp;

            x = vet[(esq + dir) / 2]; // pivo
            i = esq;
            j = dir;
            do
            {
                while (x > vet[i]) i++;
                while (x < vet[j]) j--;
                
                if (i <= j)
                {
                    temp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = temp;
                    cont_t++;
                    i++;
                    j--;
                }
                cont_c++;
            } while (i <= j);
            if (esq < j) quickSort(vet, esq, j);
            if (i < dir) quickSort(vet, i, dir);
            cont_c++;
            cont_c++;
        }

        public static void heapSort(int[] v)
        {
            cont_c = 0;
            cont_t = 0;
            constroiMaxHeap(v);
            int n = v.Length;
            
            for (int i = v.Length - 1; i > 0; i--)
            {
                troca(v, i, 0);
                refaz(v, 0, --n);
            }
        }

        private static void constroiMaxHeap(int[] v)
        {
            
            for (int i = v.Length / 2 - 1; i >= 0; i--)
                refaz(v, i, v.Length);

        }

        private static void refaz(int[] vetor, int pos, int tamanhoDoVetor)
        {

            int max = 2 * pos + 1, right = max + 1;
            cont_c++;
            if (max < tamanhoDoVetor)
            {
                cont_c++;
                if (right < tamanhoDoVetor && vetor[max] < vetor[right])
                    max = right;
                cont_c++;
                if (vetor[max] > vetor[pos])
                {
                    troca(vetor, max, pos);
                    refaz(vetor, max, tamanhoDoVetor);
                }
            }
        }

        public static void troca(int[] v, int j, int aposJ)
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
            cont_t++;
        }

        private static void merge(int[] v, int i, int m, int j)
        {

            int[] temp = new int[m - i + 1];
            int k;
            for (k = i; k <= m; k++)
                temp[k - i] = v[k];
            int esq = 0, dir = m + 1;
            k = m - i + 1;
            while (esq < k && dir <= j)
            {
                cont_c++;
                
                if (temp[esq] <= v[dir])
                {
                    v[i++] = temp[esq++];
                    cont_t++;
                }
               
                else
                {
                    cont_c++;
                    v[i++] = v[dir++];
                    cont_t++;
                }
            }
            while (esq < k)
            {
                cont_c++;
                v[i++] = temp[esq++];
                cont_t++;
            }
        }
        public static void mergeSort(int[] v, int i, int j)
        {
            cont_c = 0;
            cont_t = 0;

            cont_c++;
            if (i < j)
            {
                
                int m = (i + j) / 2;
                mergeSort(v, i, m);
                mergeSort(v, m + 1, j);
                merge(v, i, m, j); // intercala v[i..m] e v[m+1..j] em v[i..j] 
            }
        }

    }
}
