/* For Test purpose only
 * Created by Jabez Azariah
 * 11.02.2020 
 */
using System;

namespace BookStore.Domain
{
    /// <summary>
    /// Interface for seeding initial data.
    /// </summary>
    public interface IDataGenerator
    {
        /// <summary>
        /// Seeds a set of initial data
        /// </summary>
        /// <param name="serviceProvider"></param>
        void Initialize(IServiceProvider serviceProvider);
    }
}
