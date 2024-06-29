using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Interface.Repository
{
    public interface IRepository
    {

        #region Get
        Task<T> GetAsync<T>(Expression<Func<T, bool>> expression, bool AsNoTracking = true, CancellationToken cancellationToken = default) where T : BaseEntity;

        Task<IEnumerable<T>> GetListAsync<T>(Expression<Func<T, bool>> expression = null, bool AsNoTracking = true, CancellationToken cancellationToken = default) where T : BaseEntity;



        Task<bool> ExistsAsync<T>(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
        where T : BaseEntity;

        #endregion

        #region update
        Task UpdateAsync<T>(T entity)
        where T : BaseEntity;

        #endregion update

        #region Save Changes

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        #endregion Save Changes

        #region FirstOrDefault

        Task<T> FirstByConditionAsync<T>(Expression<Func<T, bool>> expression, bool AsNoTracking = true)
        where T : BaseEntity;

        #endregion FirstOrDefault

        #region LastOrDefault

        Task<T> LastByConditionAsync<T>(Expression<Func<T, bool>> expression, bool AsNoTracking = true)
        where T : BaseEntity;

        #endregion LastOrDefault

        #region Create

        Task<Guid> CreateAsync<T>(T entity)
        where T : BaseEntity;

        Task<IList<Guid>> CreateRangeAsync<T>(IEnumerable<T> entity)
        where T : BaseEntity;

        #endregion Create

        #region DeleteOrRemoveOrClear

        Task RemoveAsync<T>(T entity)
        where T : BaseEntity;

        Task<T> RemoveByIdAsync<T>(Guid entityId)
        where T : BaseEntity;

        Task ClearAsync<T>(Expression<Func<T, bool>> expression = null)
        where T : BaseEntity;

        #endregion Paginate
        //Task<PaginatedResult<TDto>> GetPaginatedListAsync<T, TDto>(PaginationFilter filter = null, Expression<Func<T, bool>> expression = null, bool AsNoTracking = true, CancellationToken cancellationToken = default) where T : BaseEntity;
        #region Aggregations
        Task<int> CountByConditionAsync<T>(Expression<Func<T, bool>> expression = null, CancellationToken cancellationToken = default)
        where T : BaseEntity;

        #endregion Aggregations
    }
}
