using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.DataAccess.DataAccessHelper
{
    public class CatchException
    {
        /// <summary>
        /// Returns recursively inner exceptions messages if they are exists
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static string GetCatchException(Exception? exception)
            => exception == null ? "Exception is NULL" : GetErrorMessage(exception);

        private static string GetErrorMessage(Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendLine(exception.Message);
            if (exception.InnerException != null)
            {
                sb.AppendLine(GetErrorMessage(exception.InnerException));
            }
            return sb.ToString();
        }
    }
}
