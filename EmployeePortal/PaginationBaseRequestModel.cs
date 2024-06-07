using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Server.Business.Core.DataTransferModels
{
    public class PaginationBaseRequestModel
    {

        [Required]
        public int PageNumber { get; set; } 

        [Required]
        public int PageSize { get; set; }

        public string SortOrder { get; set; } = "";

        public String Search { get; set; } = "";

        /// <summary>
        /// if client already know total record then it can pass so for next all paginated request there is no need to count total records
        /// </summary>
        public int TotalRecords { get; set; }
    }
}
