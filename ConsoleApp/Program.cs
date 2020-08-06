using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var servico = new ServicoGeral("Leonardo", "Americano");

            //Questão 1
            servico.numMultiplos();

            var list = new List<int> { 1, 2, 3, 4, 5 };
            
            //Questão 2
            Console.WriteLine(servico.somaDeQuadrados(list.ToArray()));

            //Questão 3
            Console.WriteLine(servico.Fibonacci5Dititos());

            //Questão 4
            Arvore a = new Arvore() { id = 1, filhos = new Arvore[]{
                new Arvore() { id = 4, filhos = new Arvore[]{
                    new Arvore() { id = 10, filhos = new Arvore[] {
                        new Arvore() { id = 8 }
                    } },
                    new Arvore() { id = 2, filhos = new Arvore[]{
                        new Arvore() { id = 12, filhos = new Arvore[] {
                            new Arvore() { id = 13, filhos = new Arvore[] {
                                new Arvore() { id = 9 }
                            } }
                        } }
                    } }
                } },
                new Arvore() { id = 7, filhos = new Arvore[]{
                    new Arvore() { id = 3 },
                    new Arvore() { id = 11, filhos = new Arvore[]{
                        new Arvore() { id = 6 },
                        new Arvore() { id = 5 }
                    } }
                } }
            } };

            Print(servico.caminho_arvore(a,9));
            Print(servico.caminho_arvore(a,1));
            Print(servico.caminho_arvore(a,17));
            Print(servico.caminho_arvore(a,4));

            //Questão 5
            Console.WriteLine(servico.Acumular(servico.Combiner, 0, list));

            //Questão 6
            Console.WriteLine(servico.palavraTriangulo("SKY"));
            Console.WriteLine(servico.palavraTriangulo("ASDF"));

            Console.ReadKey();
        }

        private static void Print(int[] arr)
        {
            int total = arr.Length;

            Console.Write('[');
            foreach (var item in arr)
            {
                Console.Write(item.ToString());
                total--;
                if (total >= 1)
                    Console.Write(",");
            }
            Console.Write(']');
            Console.WriteLine("");
        }
    }
}