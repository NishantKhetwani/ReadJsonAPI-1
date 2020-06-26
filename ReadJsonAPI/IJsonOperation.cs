using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReadJsonAPI
{
    /// <summary>
    /// Interface 
    /// </summary>
    public interface IFileOperation
    {
        Task<T> ReadFile<T>();
        Task<List<T>>WriteFile<T>(T obj);
    }
}