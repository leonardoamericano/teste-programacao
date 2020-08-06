using Domain;
using System;
using System.Collections.Generic;

namespace Service
{
    public class ServicoGeral
    {
        public ServicoGeral(){}

        public ServicoGeral(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }

        public string Nome;
        public string SobreNome;

        public void numMultiplos()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write(i.ToString() + " ");
                if ((i % 3) == 0)
                {
                    Console.Write(Nome+" ");
                }
                if ((i % 5) == 0)
                {
                    Console.Write(SobreNome);
                }
                Console.WriteLine("");
            }
        }

        public string Fibonacci5Dititos()
        {
            int num1 = 0, num2 = 1, aux;

            while (num2.ToString().Length < 5)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
            }

            return num2.ToString();
        }

        public int somaDeQuadrados(int[] lista)
        {
            int retorno = 0;
            foreach (int item in lista)
            {
                retorno += (int)Math.Pow(item, 2);
            }
            return retorno;
        }

        public int[] caminho_arvore(Arvore a, int n)
        {
            return buscar(a, n).ToArray();
        }

        private List<int> buscar(Arvore a, int n)
        {
            List<int> retorno = new List<int>();

            //possui filhos
            if (a.filhos != null)
            {
                if (a.filhos[0] != null)
                {
                    retorno = buscar(a.filhos[0], n);
                }

                if (retorno.Count == 0)
                {
                    if (a.filhos.Length > 1)
                    {
                        if (a.filhos[1] != null)
                        {
                            retorno = buscar(a.filhos[1], n);
                        }
                    }
                }
            }
            if (retorno.Count > 0)
            {
                n = a.id;
            }

            if (a.id == n)
            {
                List<int> aux = new List<int>();
                aux.Add(a.id);

                //inicializa o array
                aux.AddRange(retorno);

                retorno = aux;
            }


            return retorno;
        }

        public int Acumular(Func<int, int, int> combiner, int nullValue, List<int> list)
        {
            if (list.Count == 0)
                return 0;

            var primeiro = list[0];
            list.RemoveAt(0);

            return combiner(primeiro, Acumular(combiner, nullValue, list));
        }

        public int Combiner(int x, int acumulador)
        {
            return (x * x) + acumulador;
        }

        public int palavraTriangulo(string word)
        {
            int wordSum = 0;
            char[] characters = word.ToCharArray();
            foreach (char oneChar in characters)
            {
                wordSum += ((int)char.ToUpper(oneChar)) - 64;
            }
            int number = 1;
            int numeroTrangulo = (number * (number + 1)) / 2;
            while (wordSum > numeroTrangulo)
            {
                number++;
                numeroTrangulo = (number * (number + 1)) / 2;
            }
            if (wordSum == numeroTrangulo)
            {
                return number;
            }
            return -1;
        }
    }
}
