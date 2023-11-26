using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Entities
{
    public class Produto : EntidadeBase
    {
        #region 1 - Contrutores

        public Produto(string nome, string descricao, decimal valor, string imagem, int quantidadeEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Imagem = imagem;
            Quantidade_Estoque = quantidadeEstoque;
        }

        public Produto(string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, string imagem, int quantidadeEstoque, int estoqueMinimo)
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
            Quantidade_Estoque = quantidadeEstoque;
            Estoque_Minimo = estoqueMinimo;
        }

        public Produto(Guid codigoId, string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, string imagem, int quantidadeEstoque, int estoqueMinimo)
        {
            CodigoId = codigoId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
            Quantidade_Estoque = quantidadeEstoque;
            Estoque_Minimo = estoqueMinimo;
        }

        #endregion

        #region 2 - Propriedades

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int Quantidade_Estoque { get; private set; }
        public Guid CategoriaID { get; private set; }
        public int Estoque_Minimo { get; private set; }

        #endregion

        #region 3 - Comportamentos

        public void Reativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        public void AlterarDescricao(string descricao) => Descricao = descricao;
        public void AlterarPreco(Decimal valor) => Valor = valor;
        public void AlterarProduto(Produto produto)
        {
            Nome = produto.Nome;
            Descricao = produto.Descricao;
            Valor = produto.Valor;
            Imagem = produto.Imagem;
            Quantidade_Estoque = produto.Quantidade_Estoque;
        }
        public void AlterarCategoria(Guid categoriaID) => CategoriaID = categoriaID;
        public void DebitarEstoque(int quantidade)
        {
            if (!PossuiEstoque(quantidade)) throw new Exception("Estoque insuficiente");
            Quantidade_Estoque -= quantidade;
        }
        public void ReporEstoque(int quantidade)
        {
            Quantidade_Estoque += quantidade;
        }
        public bool PossuiEstoque(int quantidade) => Quantidade_Estoque >= quantidade;
        public bool VeririficaEstoqueMinimo() => Quantidade_Estoque < Estoque_Minimo;

        #endregion
    }
}
