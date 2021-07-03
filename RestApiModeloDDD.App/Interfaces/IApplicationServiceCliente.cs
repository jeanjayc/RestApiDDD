using System.Collections.Generic;
using RestApiModeloDDD.App.Dtos;

namespace RestApiModeloDDD.App.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO clienteDto);
        void Update(ClienteDTO clienteDto);
        void Remove(ClienteDTO clienteDtor);
        IEnumerable<ClienteDTO> GetAll();
        ClienteDTO GetById(int id);
    }
}