using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query;
using SmartEducation.Application.ApplicationHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Application.IRepository
{
    //IBaseRepository
    public interface IBaseRepository<T>
    {


        #region GetALL
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetAll_Queryable();
        IEnumerable<T> GetAll_IncludeMultiple(string includeProperties = "");
        Task<List<T>> GetByExp_Include(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);
        Task<List<T>> GetAll_Include(params Expression<Func<T, object>>[] includes);



        #endregion

        #region Pagination_List
        IQueryable<T> GetList<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, bool>> orderByLambda);
        IEnumerable<T> Get(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, int? limit = null, int? offset = null, string includeProperties = "");
        Task<List<T>> GetAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, int? limit = null, int? offset = null, string includeProperties = "");
        IPagedList<T> GetPagedList(Expression<Func<T, bool>> predicate = null,
                                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                int pageIndex = 0,
                                                int pageSize = 20,
                                                bool disableTracking = true,
                                                bool ignoreQueryFilters = false);
        #endregion

        #region GetMany_Using_whereLamdaExp
        IQueryable<T> GetMany(Expression<Func<T, bool>> whereLamdaExp);
        #endregion

        #region GetFirstOrDefault_Method
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> whereLambda);
        T FirstOrDefault(Expression<Func<T, bool>> whereLambdaExp);
        #endregion

        #region Find_Method
        T FindById(int id);
        Task<T> FindIdAsync(int id);

        #endregion

        #region GetRequest_EntityFramework
        T GetById(params object[] keyValues);
        #endregion

        #region Add_Record
        string Add(T model);
        Task<string> AddAsync(T model);
        bool AddRange(IEnumerable<T> entities);
        Task<int> AddRangeAsync(IEnumerable<T> entities);

        #endregion

        #region Update_Record
        string Update(T entity);
        bool Edit(T model);
        string UpdateRange(IEnumerable<T> entities);

        #endregion

        #region Delete

        #region BatchDelete
        int BatchDelete(Expression<Func<T, bool>> whereLambda);
        int BatchDelete();

        #endregion

        #region SingDelete
        int Delete(params object[] keyValues);
        bool Delete(T model);
        bool Delete(int id);

        #endregion

        #endregion

        #region Sql_Command_Method
        int ExecuteSqlCommand(string sql);
        Task<int> ExecuteSqlCommandAsync(string sql);
        int ExecuteSqlCommandWithParam(string sql, params SqlParameter[] sp);
        Task<int> ExecuteSqlCommandWithParamAsync(string sql, params SqlParameter[] sp);
        IQueryable<T> SqlQuery_GetModelData(string sql, params object[] paras);
        IQueryable<T> SqlQuery_GetModelData(string sql);

        #endregion

        #region Existance_Check
        bool IsExist(object id);
        Task<bool> AnyExistAsync(Expression<Func<T, bool>> lamdaExp);

        #endregion

        #region Count_Item
        int Count();
        Task<int> CountAsync();
        #endregion

        #region SaveChanges_Event
        //public int SaveChanges()
        //{
        //    return db.SaveChanges();
        //}
        //public Task<int> SaveChangesAsync()
        //{
        //    return db.SaveChangesAsync();
        //}

        Task<int> SaveChangesAsync();
        void SaveChanges();

        #endregion

        #region Comments_Code
        // string Add(T model);
        // Task<string> AddAsync(T model);
        // bool Edit(T model);
        // bool Delete(T model);
        // /// <summary>
        // /// Delete by primary key
        // /// </summary>
        // /// <param name="keyValues"></param>
        // int Delete(params object[] keyValues);

        // #region GetALL
        // IEnumerable<T> GetAll();
        // IQueryable<T> GetAll_Queryable();
        // #endregion

        // #region GetMany_Using_whereLamdaExp
        // IQueryable<T> GetMany(Expression<Func<T, bool>> whereLamdaExp);
        // #endregion


        // #region GetFirstOrDefault_Method
        // Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> whereLambdaExp);
        // T FirstOrDefault(Expression<Func<T, bool>> whereLambdaExp);
        // #endregion


        // T GetById(params object[] keyValues);




        // /// <summary>
        // /// Query with level 2 cache
        // /// </summary>
        // /// <param name="whereLambda"></param>
        // /// <returns></returns>
        // IQueryable<T> GetList<S>(int pageSize, int pageIndex, out int total
        //     , Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, bool>> orderByLambda);
        // /// <summary>
        // /// batch deletion
        // /// </summary>
        // /// <param name="whereLambda">Delete condition</param>
        // /// <returns></returns>
        // int BatchDelete(Expression<Func<T, bool>> whereLambda);
        // /// <summary>
        // /// Delete the entire table data in batches
        // /// </summary>
        // /// <returns></returns>
        // int BatchDelete();
        // /// <summary>
        // /// Batch
        // /// </summary>
        // /// <param name="whereLambda">Expression</param>
        // /// <param name="updateLambda">m_Rep.BatchUpdate(a=>a.Age==36,a=>new SysSample() { Age = 37});</param>
        // /// <returns></returns>
        //// int BatchUpdate(Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> updateLambda);
        // /// <summary>
        // ///Update the entire table
        // /// </summary>
        // /// <param name="updateLambda">m_Rep.BatchUpdate(a=>a.Age==36,a=>new SysSample() { Age = 37});</param>
        // /// <returns></returns>
        // //int BatchUpdate(Expression<Func<T, T>> updateLambda);


        // string Update(T entity);
        // string UpdateRange(IEnumerable<T> entities);


        // bool IsExist(object id);
        // #region
        // ////Execute database statements
        // /// <summary>
        // /// Execute a SQL statement
        // /// </summary>
        // /// <param name="sql"></param>
        // /// <returns></returns>
        // int ExecuteSqlCommand(string sql);
        // Task<int> ExecuteSqlCommandAsync(string sql);
        // int ExecuteSqlCommandWithParam(string sql, params SqlParameter[] sp);
        // Task<int> ExecuteSqlCommandWithParamAsync(string sql, params SqlParameter[] sp);
        // IQueryable<T> SqlQuery_GetModelData(string sql, params object[] paras);
        // #endregion


        // #region Existance_Check
        // Task<bool> AnyExistAsync(Expression<Func<T, bool>> lamdaExp);

        // #endregion

        // #region Count_Item
        // int Count();
        // Task<int> CountAsync();
        // #endregion

        // int SaveChanges();
        // Task<int> SaveChangesAsync();
        #endregion


    }
}
