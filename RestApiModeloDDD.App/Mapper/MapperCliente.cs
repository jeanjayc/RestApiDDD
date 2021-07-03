using RestApiModeloDDD.App.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using RestApiModeloDDD.App.Interfaces.mapper;

namespace RestApiModeloDDD.App.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        
        public Cliente MapperDtoToEntity(ClienteDTO clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };
            return cliente;
        }

        public ClienteDTO MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDTO()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDTO> MapperListClienteDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email
            });
            return dto;
        }
    }
}