using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using week2_huseyingulerman.Core.Interfaces;
using week2_huseyingulerman.Core.Result.Abstract;
using week2_huseyingulerman.Core.VMs;

namespace week2_huseyingulerman.Core.Services
{
    public interface IService<TEntity, TRequest,TResponse> where TEntity:IEntity where TRequest:class where TResponse:class
    {
        Task<IAppResult<TResponse>> AddAsync(TRequest request);
        Task<IAppResult<IEnumerable<TResponse>>> AddRangeAsync(IEnumerable<TRequest> requests);
        Task<IAppResult<NoContentVm>> UpdateAsync(TRequest request);
        Task<IAppResult<NoContentVm>> RemoveAsync(int id);
        Task<IAppResult<NoContentVm>> RemoveRangeAsync(IEnumerable<int> ids);
        Task<IAppResult<IEnumerable<TResponse>>> Where(Expression<Func<TEntity, bool>> expression);
        Task<IAppResult<TResponse>> GetByIdAsync(int id);
        Task<IAppResult<IEnumerable<TResponse>>> GetAllAsync();
        Task<IAppResult<IEnumerable<TResponse>>> GetAllActiveAsync();
    }
}
