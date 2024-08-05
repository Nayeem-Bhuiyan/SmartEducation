using SmartEducation.Application.IEntityRepository.MasterPanel;
using SmartEducation.Application.IEntityRepository.Student;
using SmartEducation.Application.IEntityService.MasterPanel;
using SmartEducation.Application.IEntityService.Student;
using SmartEducation.Domain.Model.MasterPanel;
using SmartEducation.Domain.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Service.EntityService.Student
{

    public class StudentInfoService : IStudentInfoService
    {
        private readonly IStudentInfoRepository _StudentInfoRepository;
        public StudentInfoService(IStudentInfoRepository StudentInfoRepository)
        {
            this._StudentInfoRepository = StudentInfoRepository;
        }


        #region Crud_Service
        public IQueryable<StudentInfo> Get_All_StudentInfo()
        {
            return _StudentInfoRepository.Get_All_IQueryable();
        }
        public async Task<string> Save_StudentInfo(StudentInfo model)
        {
            string resMsg = "";
            resMsg=await _StudentInfoRepository.Save_StudentInfo(model);
            return resMsg;
        }

        public StudentInfo Get_StudentInfo(int id)
        {
            return _StudentInfoRepository.GetById(id);
        }

        public string Delete_StudentInfo(int id)
        {
            string resMsg = string.Empty;
            resMsg=_StudentInfoRepository.Delete_Single(id);
            return resMsg;
        }
        #endregion

    }
}
