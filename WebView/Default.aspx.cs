using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
using Data.Repository;

namespace WebView
{
    public partial class _Default : Page
    {
        RepositoryProduto repository = new RepositoryProduto();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            Categoria categoria = new Categoria();

            //produto.Id = 0; Adicionar auto incremento
            produto.Nome = Convert.ToString(tbxNomeProduto.Text);
            produto.Descricao = Convert.ToString(tbxDescricaoProduto.Text);
            produto.Categoria = categoria;

            repository.Create(produto);
            
        }
    }
}