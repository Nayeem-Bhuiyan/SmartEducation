using SmartEducation.Domain.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Application.IEntityRepository.Student
{
    public interface IStudentInfoRepository
    {
        #region Crud_Repository
        IQueryable<StudentInfo> Get_All_IQueryable();
        Task<string> Save_StudentInfo(StudentInfo model);
        StudentInfo GetById(int id);
        string Delete_Single(int id);
        #endregion

    }
}
