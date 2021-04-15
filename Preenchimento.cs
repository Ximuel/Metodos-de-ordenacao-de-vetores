using System;

namespace Pratica5 {
    class Preenchimento {
        
        public static void Aleatorio(int[] vet, int limite) {
            Random r = new Random();
            for (int i = 0; i < vet.Length; i++) {
                vet[i] = r.Next(0, limite);
            }
        }
        public static void Crescente(int[] vet) {
            double add = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = Convert.ToInt32(add);
                add += 0.598;
            }
        }
        public static void Decrescente(int[] vet) {
            double add = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = 299 - (Convert.ToInt32(add));
                add += 0.598;
            }
        }
    }
}
