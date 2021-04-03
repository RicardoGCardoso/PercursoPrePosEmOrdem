using System;
using System.Collections.Generic;
using System.Text;
using static PercursoPrePosEmOrdem.ArvoreBinaria;

namespace PercursoPrePosEmOrdem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n");
            ArvoreBinaria arvore = new ArvoreBinaria("X");

            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "X", "B");
            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "B", "D");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "X", "C");
            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "C", "E");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "E", "G");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "C", "T");
            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "T", "H");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "T", "I");

            Console.WriteLine("MOSTRAR EM INORDEM " + arvore.LerArvoreEmInOrdem());
            Console.WriteLine("MOSTAR EM POS ORDEM " + arvore.LerArvoreEmPosOrdem());
            Console.WriteLine("MOSTRAR EM PREORDEM " + arvore.LerArvoreEmPreOrdem());
            Console.WriteLine("\n\n\n\n");

            arvore.LimparArvore("F");

            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "U", "W");
            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "W", "A");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "W", "Z");
            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "Z", "C");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "Z", "E");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "U", "G");
            arvore.AdicionarNo(InsercaoEnum.DIREITA, "G", "I");
            arvore.AdicionarNo(InsercaoEnum.ESQUERDA, "I", "K");

            
            Console.WriteLine("MOSTRAR EM INORDEM " + arvore.LerArvoreEmInOrdem());
            Console.WriteLine("MOSTAR EM POS ORDEM " + arvore.LerArvoreEmPosOrdem());
            Console.WriteLine("MOSTRAR EM PREORDEM " + arvore.LerArvoreEmPreOrdem());

            Console.ReadLine();
        }
    }
}
