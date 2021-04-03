using System;
using System.Collections.Generic;
using System.Text;

namespace PercursoPrePosEmOrdem
{
    public class No
    {

        public string Dado { get; set; }
        public No NoEsquerdo { get; set; }
        public No NoDireira { get; set; }

        public No()
        {
            this.Dado = "";
            this.NoEsquerdo = null;
            this.NoDireira = null;
        }
        public No(string nome)
        {
            this.Dado = nome;
            this.NoEsquerdo = null;
            this.NoDireira = null;
        }

        public No(string nome, No esquerda, No direita)
        {
            this.Dado = nome;
            this.NoEsquerdo = esquerda;
            this.NoDireira = direita;
        }

        // USADO OBTER O VALOR HASH DO OBJETO
        public override int GetHashCode()
        {
            return Dado == null ? 0 : Dado.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is No))
            {
                return false;
            }
            // VERIFICA SE O VALOR HASH DOS NOS SÃO IGUAIS
            // DESSA FORMA VOCÊ PODE DEFINIR SE UM NO É IGUAL A OUTRO
            return ((No)obj).GetHashCode() == GetHashCode();
        }

        public override string ToString()
        {
            // RETORNA VAZIO SE NULO OU O VALOR DO DADO
            return Dado == null ? "" : Dado;
        }

    }
}
