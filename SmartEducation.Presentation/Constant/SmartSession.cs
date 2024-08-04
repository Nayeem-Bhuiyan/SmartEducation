using System.ComponentModel.DataAnnotations;

namespace SmartEducation.Presentation.Constant
{
    public class SmartSession
    {
        public string userId { get; set; }
        public string userRoleId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserCode { get; set; }
        public string baseUrl { get; set; }
        public string logoName { get; set; }
        public string reportSortingOrder { get; set; }
        public int InstitutionalDivisionId { get; set; }
        public int InstitutionId { get; set; }
        public int InstitutionName { get; set; }
    }
}
