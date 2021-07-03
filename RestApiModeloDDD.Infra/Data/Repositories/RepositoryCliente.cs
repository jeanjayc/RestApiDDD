﻿using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infra.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _sqlContext;
        public RepositoryCliente(SqlContext sqlContext)
            :base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
