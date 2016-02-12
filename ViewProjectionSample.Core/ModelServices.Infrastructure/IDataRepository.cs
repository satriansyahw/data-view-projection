using System;
using System.Collections;
using System.Collections.Generic;

namespace MyInventory.ModelServices
{
    /// <summary>
    /// Defines the methods to support a data repository implementation.
    /// </summary>
    public interface IDataRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
    }
}
