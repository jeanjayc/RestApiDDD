using System.Collections.Generic;
using RestApiModeloDDD.App.Dtos;

namespace RestApiModeloDDD.App.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO produtoDto);
        void Update(ProdutoDTO produtoDto);
        void Remove(ProdutoDTO produtoDto);
        IEnumerable<ProdutoDTO> GetAll();
        ProdutoDTO GetById(int id);
    }
}