﻿using System;
using System.Collections.Generic;
namespace Crud.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Remover(TEntity entity);
        void Atualizar(TEntity entity);
    }
}
