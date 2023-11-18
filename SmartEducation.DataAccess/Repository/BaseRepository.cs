using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using SmartEducation.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SmartEducation.Application.ApplicationHelper;
using SmartEducation.Application.IRepository;
using SmartEducation.DataAccess.DataAccessHelper;

namespace SmartEducation.DataAccess.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private DbSet<T> _entities;


        protected ApplicationDbContext _context { get; }
        public BaseRepository(ApplicationDbContext context)
        {
            this._context = context;
            _entities = context.Set<T>();
        }




        #region GetALL
        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }
        public virtual IQueryable<T> GetAll_Queryable()
        {
            return _context.Set<T>();
        }

        public virtual async Task<List<T>> GetAll_Include(params Expression<Func<T, object>>[] includes)
        {
            var query = GetManyIncludesQuery(includes);
            return await query.ToListAsync();
        }


        public IEnumerable<T> GetAll_IncludeMultiple(string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.ToList();
        }




        public virtual Task<List<T>> GetByExp_Include(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            var query = GetManyIncludesQuery(includes);
            return query.Where(filter).ToListAsync();
        }

        #endregion

        #region Pagination_List
        public virtual IQueryable<T> GetList<S>(int pageSize, int pageIndex, out int total
    , Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, bool>> orderByLambda)
        {
            var queryable = _context.Set<T>().Where(whereLambda);
            total = queryable.Count();
            if (isAsc)
            {
                queryable = queryable.OrderBy(orderByLambda).Skip<T>(pageSize * (pageIndex - 1)).Take<T>(pageSize);
            }
            else
            {
                queryable = queryable.OrderByDescending(orderByLambda).Skip<T>(pageSize * (pageIndex - 1)).Take<T>(pageSize);
            }
            return queryable;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, int? limit = null, int? offset = null, string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query).AsQueryable();
            }

            if (offset != null)
            {
                query = query.Skip((int)offset);
            }

            if (limit != null)
            {
                query = query.Take((int)limit);
            }
            return query.ToList();
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, int? limit = null, int? offset = null, string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query).AsQueryable();
            }

            if (offset != null)
            {
                query = query.Skip((int)offset);
            }

            if (limit != null)
            {
                query = query.Take((int)limit);
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// Gets the <see cref="IPagedList{T}"/> based on a predicate, orderby delegate and page information. This method default no-tracking query.
        /// </summary>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="orderBy">A function to order elements.</param>
        /// <param name="include">A function to include navigation properties</param>
        /// <param name="pageIndex">The index of page.</param>
        /// <param name="pageSize">The size of the page.</param>
        /// <param name="disableTracking"><c>True</c> to disable changing tracking; otherwise, <c>false</c>. Default to <c>true</c>.</param>
        /// <param name="ignoreQueryFilters">Ignore query filters</param>
        /// <returns>An <see cref="IPagedList{T}"/> that contains elements that satisfy the condition specified by <paramref name="predicate"/>.</returns>
        /// <remarks>This method default no-tracking query.</remarks>
        public virtual IPagedList<T> GetPagedList(Expression<Func<T, bool>> predicate = null,
                                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                int pageIndex = 0,
                                                int pageSize = 20,
                                                bool disableTracking = true,
                                                bool ignoreQueryFilters = false)
        {
            IQueryable<T> query = _entities;

            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (ignoreQueryFilters)
            {
                query = query.IgnoreQueryFilters();
            }

            if (orderBy != null)
            {
                return orderBy(query).ToPagedList(pageIndex, pageSize);
            }
            else
            {
                return query.ToPagedList(pageIndex, pageSize);
            }
        }

        #endregion

        #region GetMany_Using_whereLamdaExp
        public IQueryable<T> GetMany(Expression<Func<T, bool>> whereLamdaExp)
        {
            var dbObj = _context.Set<T>().AsNoTracking().AsQueryable();
            if (whereLamdaExp != null)
                dbObj = dbObj.Where(whereLamdaExp);
            return dbObj;
        }



        #endregion

        #region GetFirstOrDefault_Method
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> whereLambda)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(whereLambda);
        }
        public T FirstOrDefault(Expression<Func<T, bool>> whereLambdaExp)
        {
            return _context.Set<T>().AsNoTracking().FirstOrDefault(whereLambdaExp);
        }

        #endregion

        #region Find_Method
        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public async Task<T> FindIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }



        #endregion

        #region GetRequest_EntityFramework

        public virtual T GetById(params object[] keyValues)
        {
            return _context.Set<T>().Find(keyValues);
        }

        #endregion

        #region Add_Record
        public virtual string Add(T model)
        {
            string resMsg = "success";
            try
            {
                _context.Set<T>().Add(model);
                _context.SaveChanges();
                return resMsg;
            }
            catch (Exception ex)
            {
                resMsg =CatchException.GetCatchException(ex);
                return resMsg;
            }
        }
        public virtual async Task<string> AddAsync(T model)
        {
            string resMsg = "success";
            try
            {
                _context.Set<T>().Add(model);
                await SaveChangesAsync();
                return resMsg;
            }
            catch (Exception ex)
            {
                resMsg =CatchException.GetCatchException(ex);
                return resMsg;
            }
        }

        public bool AddRange(IEnumerable<T> entities)
        {

            _context.Set<T>().AddRange(entities);
            return _context.SaveChanges() > 0;
        }

        public async Task<int> AddRangeAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
            return await SaveChangesAsync();
        }
        #endregion

        #region Update_Record
        public string Update(T entity)
        {
            string resMsg = "success";
            try
            {
                _context.Set<T>().Update(entity);
                return resMsg;
            }
            catch (Exception ex)
            {
                resMsg =CatchException.GetCatchException(ex);
                return resMsg;
            }
        }

        public virtual bool Edit(T model)
        {
            if (_context.Entry<T>(model).State == EntityState.Modified)
            {
                return _context.SaveChanges() > 0;
            }
            else if (_context.Entry<T>(model).State == EntityState.Detached)
            {
                try
                {
                    _context.Set<T>().Attach(model);
                    _context.Entry<T>(model).State = EntityState.Modified;
                }
                catch (InvalidOperationException)
                {
                    //T old = Find(model._ID);
                    //_context.Entry<old>.CurrentValues.SetValues(model);
                    return false;
                }
                return _context.SaveChanges() > 0;
            }
            return false;
        }
        public string UpdateRange(IEnumerable<T> entities)
        {
            string resMsg = "success";
            try
            {
                _context.Set<T>().UpdateRange(entities);
                return resMsg;
            }
            catch (Exception ex)
            {
                resMsg =CatchException.GetCatchException(ex);
                return resMsg;
            }
        }
        #endregion

        #region Delete

        #region BatchDelete
        public virtual int BatchDelete(Expression<Func<T, bool>> whereLambda)
        {
            return _context.Set<T>().Where(whereLambda).ExecuteDelete();
        }
        public virtual int BatchDelete()
        {
            return _context.Set<T>().ExecuteDelete();
        }
        #endregion

        #region SingDelete
        public virtual int Delete(params object[] keyValues)
        {
            foreach (var item in keyValues)
            {
                T model = GetById(item);
                if (model != null)
                {
                    _context.Set<T>().Remove(model);
                }
            }
            return _context.SaveChanges();
        }

        public virtual bool Delete(T model)
        {
            _context.Set<T>().Remove(model);
            return _context.SaveChanges() > 0;
        }
        public virtual bool Delete(int id)
        {
            T model = GetById(id);
            _context.Set<T>().Remove(model);
            return _context.SaveChanges() > 0;
        }
        #endregion

        #endregion

        #region Sql_Command_Method



        public int ExecuteSqlCommand(string sql)
        {
            return _context.Database.ExecuteSqlRaw(sql);
        }

        public async Task<int> ExecuteSqlCommandAsync(string sql)
        {
            return await _context.Database.ExecuteSqlRawAsync(sql);
        }

        public int ExecuteSqlCommandWithParam(string sql, params SqlParameter[] sp)
        {
            return _context.Database.ExecuteSqlRaw(sql, sp);
        }

        public async Task<int> ExecuteSqlCommandWithParamAsync(string sql, params SqlParameter[] sp)
        {
            return await _context.Database.ExecuteSqlRawAsync(sql, sp);
        }

        public IQueryable<T> SqlQuery_GetModelData(string sql)
        {
            return _entities.FromSqlRaw<T>(sql);
        }
        public IQueryable<T> SqlQuery_GetModelData(string sql, params object[] paras)
        {
            return _context.Database.SqlQueryRaw<T>(sql, paras);
        }

        #endregion

        #region Existance_Check
        public virtual bool IsExist(object id)
        {
            return GetById(id) != null;
        }
        public async Task<bool> AnyExistAsync(Expression<Func<T, bool>> lamdaExp)
        {
            return await _context.Set<T>().AnyAsync(lamdaExp);
        }
        #endregion

        #region Count_Item

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        public Task<int> CountAsync()
        {
            return _context.Set<T>().CountAsync();
        }
        #endregion

        #region SaveChanges_Event
        //public int SaveChanges()
        //{
        //    return _context.SaveChanges();
        //}
        //public Task<int> SaveChangesAsync()
        //{
        //    return _context.SaveChangesAsync();
        //}

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                var entities = _context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added
                                || e.State == EntityState.Modified)
                    .Select(e => e.Entity);

                foreach (var entity in entities)
                {
                    var validationContext = new ValidationContext(entity);
                    Validator.ValidateObject(entity, validationContext, validateAllProperties: true);
                }

                return await _context.SaveChangesAsync();
            }
            catch (ValidationException exc)
            {
                Console.WriteLine($"{nameof(SaveChanges)} validation exception: {exc?.Message}");
                throw (exc.InnerException as Exception ?? exc);
            }
            catch (Exception ex) //DbUpdateException 
            {
                throw (ex.InnerException as Exception ?? ex);
            }
        }

        public void SaveChanges()
        {
            try
            {
                var entities = _context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added
                                || e.State == EntityState.Modified)
                    .Select(e => e.Entity);

                foreach (var entity in entities)
                {
                    var validationContext = new ValidationContext(entity);
                    Validator.ValidateObject(entity, validationContext, validateAllProperties: true);
                }

                _context.SaveChanges();
            }
            catch (ValidationException exc)
            {
                Console.WriteLine($"{nameof(SaveChanges)} validation exception: {exc?.Message}");
                throw (exc.InnerException as Exception ?? exc);
            }
            catch (Exception ex) //DbUpdateException 
            {
                throw (ex.InnerException as Exception ?? ex);
            }
        }
        #endregion





        #region Helper
        protected IQueryable<T> GetManyIncludesQuery(Expression<Func<T, object>>[] includes)
        {
            var query = _context.Set<T>().AsQueryable();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
        #endregion

        #region Dispose_Method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {

            if (disposing)
            {
                _context.Dispose();
            }
        }


        #endregion

    }
}
