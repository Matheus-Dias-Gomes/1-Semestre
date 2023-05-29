using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public class Produto
    {
        //Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //Construtores
        public Produto()
        {
        }

        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}