using RestApiModeloDDD.App.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using RestApiModeloDDD.App.Interfaces.mapper;

namespace RestApiModeloDDD.App.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDTO produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            return produto;
        }

        public ProdutoDTO MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDTO()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var result = produtos.Select(p => new ProdutoDTO
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor
            });
            return result;
        }
    }
}