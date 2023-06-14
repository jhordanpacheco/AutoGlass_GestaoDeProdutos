﻿using System;
using System.Collections.Generic;

namespace AutoGlass_GestaoDeProdutos.Domain.Core.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}