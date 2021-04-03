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

            // ALGORITMO DE ARVORE BINÁRIA EM POR PERCURSO
            // INSERÇÃO DA ARVORE BINÁRIA POR PERCURSO SE DEFINE IMPOSIÇÃO
            // DA POSICAO DO NO A SER INSERIDO EM RELAÇÃO AO NO PAI
            // DESSA FORMA ESTÁ ARVO PODE NÃO SEGUIR OS PADRÕES DA ARVORE BINÁRIA ONDE
            // O MAIOR VALOR FICA A DIREITA E MENOR A ESQUERDA.
            // NO CASO DA ARVORE POR PERCURSO NÃO NECESSARIAMENTE DEVE SEGUIR ESTE PADRÃO POIS
            // A DEFINIÇÃO DA POSIÇÃO DEVE SER INFORMADA INICIALMENTE A FIM DEFINIR O PERCURSO QUE 
            // ELA DEVE SEGUIR.

            // DEPENDENDO DA ORGANIZAÇÃO DE INSERÇÃO DOS DADOS UMA ARVORE POR PERCURSO PODE DA MESMA FORMA QUE 
            // UMA ARVORE BINÁRIA FICAR COM TODOS OS NÓS A DIREITA OU ESQUERDA DEPENDENDO DO PERCURSO, SE ESTE CASO OCORRER
            // OU SEJA, TODO OS NÓS A ESTEJA SOMENTE PARA UM LADO, O USO DO ALGORITMO DE BUSCA IRÁ NO PIOR CASO TER QUE
            // ITERAR RECURSIVAMENTE ATÉ O NÓ FOLHA SE O ELEMENTO ESTIVER NA ESTREMIDADE DA ARVORE, NESTA CONDIÇÃO DE 
            // PIOR CASO TEREMOS QUE A COMPLEXIDADE SERÁ O(N) POIS A ITERAÇÃO TERÁ QUE PASSAR POR TODOS OS NÓS,
            // CASO A INSERÇÃO POR PERCURSO ESTEJA BALANCEADO TEREMOS O MESMO CASO DA ARVORE AVL O(LOG N)


            Console.WriteLine("\n\n\n\n");
            ArvoreBinaria arvore = new ArvoreBinaria("X");

            // INFORME A POSICAO RELATIVA DO FILHO EM RELAÇÃO AO PAI
            // AdicionarNo(POSICAO, NO PAI, NO FILHO);
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "X", "B");
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "B", "D");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "X", "C");
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "C", "E");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "E", "G");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "C", "T");
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "T", "H");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "T", "I");

            Console.WriteLine("MOSTRAR EM INORDEM " + arvore.LerArvoreEmInOrdem());
            Console.WriteLine("MOSTAR EM POS ORDEM " + arvore.LerArvoreEmPosOrdem());
            Console.WriteLine("MOSTRAR EM PREORDEM " + arvore.LerArvoreEmPreOrdem());
            Console.WriteLine("\n\n\n\n");

            arvore.LimparArvore("U");

            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "U", "W");
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "W", "A");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "W", "Z");
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "Z", "C");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "Z", "E");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "U", "G");
            arvore.AdicionarPorPercurso(InsercaoEnum.DIREITA, "G", "I");
            arvore.AdicionarPorPercurso(InsercaoEnum.ESQUERDA, "I", "K");

            
            Console.WriteLine("MOSTRAR EM INORDEM " + arvore.LerArvoreEmInOrdem());
            Console.WriteLine("MOSTAR EM POS ORDEM " + arvore.LerArvoreEmPosOrdem());
            Console.WriteLine("MOSTRAR EM PREORDEM " + arvore.LerArvoreEmPreOrdem());

            Console.ReadLine();
        }
    }
}
