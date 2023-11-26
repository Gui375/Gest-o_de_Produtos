using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GestaoDeProdutos.Domain.Entities
{
    public class Fornecedor : EntidadeBase
    {
        #region 1 - Construtor

        public Fornecedor(string nome, string cnpj, string razaoSocial, DateTime dataCadastro, bool ativo)
        {
            Nome = nome;
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        public Fornecedor(Guid codigoId, string nome, string cnpj, string razaoSocial, DateTime dataCadastro, bool ativo)
        {
            CodigoId = codigoId;
            Nome = nome;
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        #endregion

        #region 2 - Propriedades

        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public string RazaoSocial { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }


        #endregion

        #region 3 - Comportamentos

        public void Alterar(Fornecedor fornecedor)
        {
            Nome = fornecedor.Nome;
            CNPJ = fornecedor.CNPJ;
            RazaoSocial = fornecedor.RazaoSocial;
        }
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        public void AlterarNome(string nome) => Nome = nome;
        public void AlterarRazaoSocial(string razaoSocial) => RazaoSocial = razaoSocial;
        public void AlterarCNPJ(string cnpj) => CNPJ = cnpj;


        #endregion
    }
}
