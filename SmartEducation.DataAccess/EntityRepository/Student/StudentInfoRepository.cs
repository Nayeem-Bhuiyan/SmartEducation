using Microsoft.EntityFrameworkCore;
using SmartEducation.Application.IEntityRepository.MasterPanel;
using SmartEducation.Application.IEntityRepository.Student;
using SmartEducation.Application.IRepository;
using SmartEducation.DataAccess.DBContext;
using SmartEducation.DataAccess.Repository;
using SmartEducation.Domain.Model.MasterPanel;
using SmartEducation.Domain.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.DataAccess.EntityRepository.Student
{
    public class StudentInfoRepository : BaseRepository<StudentInfo>, IStudentInfoRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public readonly IBaseRepository<StudentInfo> _baseRepository;
       
        public StudentInfoRepository(ApplicationDbContext dbContext, IBaseRepository<StudentInfo> baseRepository) : base(dbContext)
        {
            _dbContext=dbContext;
            _baseRepository=baseRepository;
        }

        #region Crud_Repository
        public IQueryable<StudentInfo> Get_All_IQueryable()
        {
            return _baseRepository.GetAll_Queryable();
        }
        public async Task<string> Save_StudentInfo(StudentInfo model)
        {

            string resMsg = "";
            if (model.Id>0)
            {
                _baseRepository.Update(model);
            }
            else
            {
                _baseRepository.Add(model);

            }

            try
            {
                int responseCount = await _baseRepository.SaveChangesAsync();
                if (responseCount>0)
                    resMsg="success";
                else resMsg="Error found in save information!!";
                return resMsg;
            }
            catch (Exception)
            {
                return "Catch-Error:Error found in save information!!";
            }
        }

        public StudentInfo GetById(int id)
        {
            return _baseRepository.FirstOrDefault(x => x.Id==id);
        }

        public string Delete_Single(int id)
        {
            if (_baseRepository.Delete(id))
                return "success";
            else
                return "Error found in delete";
        }
        #endregion
    }
}
