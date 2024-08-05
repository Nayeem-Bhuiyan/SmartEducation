using SmartEducation.Domain.Model.MasterPanel;
using SmartEducation.Domain.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Application.IEntityService.Student
{
    public interface IStudentInfoService
    {
        #region Crud_Service
        IQueryable<StudentInfo> Get_All_StudentInfo();
        Task<string> Save_StudentInfo(StudentInfo model);
        StudentInfo Get_StudentInfo(int id);
        string Delete_StudentInfo(int id);
        #endregion
    }
}
