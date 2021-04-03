using System;
using System.Collections.Generic;
using System.Text;

namespace PercursoPrePosEmOrdem
{
    public class ArvoreBinaria
    {

        private No NoArvore;

        public void setArvore(No no) { 
            this.NoArvore = no; 
        }

        /**
         * 
         * @param raiz raiz da árvore
         */
        public ArvoreBinaria(string raiz)
        {
            setArvore(new No(raiz));
        }

        // INFORMA O NO PAI
        // INFORMA O NOME DO NÓ
        // INFORMA A POSIÇÃO AO QUAL ELE DEVE ENTRAR SE É ESQUERDA OU DIREITA
        public void AdicionarNo(InsercaoEnum modo, string noPai, string nomeNo)
        {
            if (modo == InsercaoEnum.DIREITA)
            {
                ColocarNoADireitaDoPai(noPai, nomeNo);
            }
            else if (modo == InsercaoEnum.ESQUERDA)
            {
                ColocarNoAEsquerdaDoPai(noPai, nomeNo);
            }
        }

        public void ColocarNoAEsquerdaDoPai(string NomeNoPai, string NomeNovoNo)
        {
            // INICIA A CHAMADA DA FUNÇÃO RECURSIVA PARA ENCONTRAR O NO
            // PAI INFORMADO NO PARÂMETRO
            No no = EncontrarNoArvore(NoArvore, NomeNoPai);
            if (no == null) {
                return; 
            }
            no.NoEsquerdo = new No(NomeNovoNo);
        }

        public void ColocarNoADireitaDoPai(string NomeNoPai, string NomeNovoNo)
        {
            // INICIA A CHAMADA DA FUNÇÃO RECURSIVA PARA ENCONTRAR O NO
            // PAI INFORMADO NO PARÂMETRO
            No no = EncontrarNoArvore(NoArvore, NomeNoPai);
            if (no == null) { 
                return; 
            }
            no.NoDireira = new No(NomeNovoNo);
        }

        private No EncontrarNoArvore(No no, string nome)
        {
            // IF INSERIR UM NO NULO RETORNA NÃO ENCONTRADO E 
            // NOME DO NÓ VAZIO
            if (no == null || nome == null || string.IsNullOrEmpty(nome)) { 
                return null; 
            }
            if (no.Dado == nome) { 
                return no; 
            }
            // CHAMA RECURSIVAMENTE A BUSCA NO MODO ESQUERDA DIREITA
            No noESQUERDA = EncontrarNoArvore(no.NoEsquerdo, nome);
            if (noESQUERDA != null) { 
                return noESQUERDA; 
            }
            return EncontrarNoArvore(no.NoDireira, nome);
        }

        /**
         * limpa a árvore
         * @param raiz raiz da árvore
         */
        public void LimparArvore(string raiz)
        {
            RecursivaLimpaNos(NoArvore);
            setArvore(new No(raiz));
        }

        /**
         * método recursivo auxiliar para limpar a árvore
         * @param no
         */
        private void RecursivaLimpaNos(No no)
        {
            if (no == null) { 
                return; 
            }
            RecursivaLimpaNos(no.NoDireira);
            RecursivaLimpaNos(no.NoEsquerdo);
            no.NoEsquerdo = null; 
            no.NoDireira = null;
            no = null;
        }

        /**
         * RED
         * @return
         */
        public string LerArvoreEmPreOrdem()
        {
            if (NoArvore == null) { 
                return ""; 
            }
            return LerArvoreEmPreOrdem(NoArvore);
        }

        private string LerArvoreEmPreOrdem(No no)
        {
            if (no == null) { return ""; }
            string ContruirStringApresentacao = no.ToString();
            if (no.NoEsquerdo != null)
            {
                ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + LerArvoreEmPreOrdem(no.NoEsquerdo);
            }
            if (no.NoDireira != null)
            {
                ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + LerArvoreEmPreOrdem(no.NoDireira);
            }
            return ContruirStringApresentacao;
        }

        public string LerArvoreEmInOrdem()
        {
            if (NoArvore == null) { 
                return ""; 
            }
            return LerArvoreEmInOrdem(NoArvore);
        }

        private string LerArvoreEmInOrdem(No no)
        {
            if (no == null) 
            { 
                return ""; 
            }
            string ContruirStringApresentacao = "";
            if (no.NoEsquerdo != null)
            {
                ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + LerArvoreEmInOrdem(no.NoEsquerdo);
            }
            ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + no.ToString();
            if (no.NoDireira != null)
            {
                ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + LerArvoreEmInOrdem(no.NoDireira);
            }
            return ContruirStringApresentacao;
        }

        public string LerArvoreEmPosOrdem()
        {
            if (NoArvore == null) { 
                return ""; 
            }
            return LerArvoreEmPosOrdem(NoArvore);
        }

        private string LerArvoreEmPosOrdem(No no)
        {
            if (no == null) { 
                return ""; 
            }
            string ContruirStringApresentacao = "";
            if (no.NoEsquerdo != null)
            {
                ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + LerArvoreEmPosOrdem(no.NoEsquerdo);
            }
            if (no.NoDireira != null)
            {
                ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + LerArvoreEmPosOrdem(no.NoDireira);
            }
            ContruirStringApresentacao = ContruirStringApresentacao + (string.IsNullOrEmpty(ContruirStringApresentacao) ? "" : "--") + no.ToString();
            return ContruirStringApresentacao;
        }
    }
}
