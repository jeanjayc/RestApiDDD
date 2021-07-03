using System.Collections;
using System.Collections.Generic;
using RestApiModeloDDD.App.Dtos;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.App.Interfaces.mapper
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDTO produtoDto);
        IEnumerable<ProdutoDTO> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDTO MapperEntityToDto(Produto produto);
    }
}