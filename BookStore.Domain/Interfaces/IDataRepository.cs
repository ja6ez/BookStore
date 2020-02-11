/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */
using System.Collections.Generic;

namespace BookStore.Domain
{
    /// <summary>
    /// Generic repository interface for handling certain required methods
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="U"></typeparam>
    public interface IDataRepository<TEntity, U> where TEntity : class
    {
        /// <summary>
        /// Gets all the data
        /// </summary>
        /// <returns>Enumerable list of TEntity type</returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Get a item of TEntity type for the given Id
        /// </summary>
        /// <param name="id">Id of the item to fetch</param>
        /// <returns>An item of TEntity type</returns>
        TEntity Get(U id);
        /// <summary>
        /// Adds a item to the database
        /// </summary>
        /// <param name="b">An item of TEntity type</param>
        /// <returns>Id of the newly created item</returns>
        long Add(TEntity b);
        /// <summary>
        /// Update a given item in the database
        /// </summary>
        /// <param name="id">Id of the item to update</param>
        /// <param name="b">An item of TEntity type</param>
        /// <returns>Id of the updated item</returns>
        long Update(U id, TEntity b);
        /// <summary>
        /// Delete an item for the given id
        /// </summary>
        /// <param name="id">Id of the item to delete</param>
        /// <returns>Id of the deleted item</returns>
        long Delete(U id);
    }
}
