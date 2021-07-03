using System.Collections.Generic;
using RestApiModeloDDD.App.Dtos;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.App.Interfaces.mapper
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDTO clienteDto);
        IEnumerable<ClienteDTO> MapperListClienteDto(IEnumerable<Cliente> clientes);
        ClienteDTO MapperEntityToDto(Cliente cliente);
    }
}