using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Job_Server.Business.Core.DataTransferModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System;

namespace EmployeePortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        public ValuesController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }
        [HttpGet]
        public string Get(int number)
        {
            //Icon = H.Icon == null ? null : _appSettings.Value.url + "" + _appSettings.Value.ServiceProviderIconAttachment + "" + H.Icon,

            return _appSettings.Value.Url;
        }

        //public ExecutionResult<IconResponseModel> ServiceProviderIconImgUpload(IconModel model)
        //{
        //    var search = _dbContext.ServiceProviders.FirstOrDefault(x => x.Id == model.Id);
        //    if (search != null)
        //    {
        //        String patha = "Photo/serviceprovider/" + search.Icon;

        //        if (System.IO.File.Exists(patha))
        //        {
        //            System.IO.File.Delete(patha);
        //        }
        //    }
        //    string newFilename = "";
        //    string date = DateTime.Now.ToString("yyyy-MM-dd");
        //    string time = DateTime.Now.ToString("HH:mm:ss");
        //    newFilename = "Icon_Pic" + date.Replace("-", "_") + "_" + time.Replace(":", "_");

        //    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), "Photo/serviceprovider");
        //    if (!Directory.Exists(pathToSave))
        //    {
        //        Directory.CreateDirectory(pathToSave);
        //    }
        //    FileInfo fi = new FileInfo(model.Icon.FileName);
        //    var ext = newFilename + fi.Extension;

        //    var filePathToSave = Path.Combine(pathToSave, ext);

        //    using (FileStream fs = System.IO.File.Create(filePathToSave))
        //    {
        //        model.Icon.CopyTo(fs);
        //        fs.Flush();
        //    }

        //    IconResponseModel response = new IconResponseModel();
        //    response.IconPath = "~/Photo/serviceprovider/" + ext;
        //    response.IconValue = ext;
        //    return new ExecutionResult<IconResponseModel>(response);
        //}

        //        DECLARE @PageSize INT = 10; -- Number of records per page
        //DECLARE @PageNumber INT = 1; -- Current page number
        //DECLARE @SortColumn NVARCHAR(50) = 'Id'; -- Default sort column
        //DECLARE @SortOrder NVARCHAR(10) = 'asc'; -- Default sort order
        //DECLARE @SearchTerm NVARCHAR(100) = ''; -- Search term

        //-- Pagination
        //DECLARE @Offset INT = 10; -- (@PageNumber - 1) * @PageSize;

        //-- Construct the SQL query dynamically
        //DECLARE @SQLQuery NVARCHAR(MAX);

        //        SET @SQLQuery = '
        //    SELECT*
        //    FROM Freight
        //    WHERE 1=1'; -- Placeholder to add conditions dynamically

        //-- Searching
        //IF @SearchTerm IS NOT NULL AND @SearchTerm != ''
        //BEGIN
        //    SET @SQLQuery = @SQLQuery + '
        //    AND(freightNo LIKE ''%'' + @SearchTerm + ''%''
        //    OR LoadingLocation LIKE ''%'' + @SearchTerm + ''%'')';
        //END

        //-- Sorting
        //SET @SQLQuery = @SQLQuery + '
        //    ORDER BY ' + @SortColumn + ' ' + @SortOrder;

        //-- Pagination
        //SET @SQLQuery = @SQLQuery + '
        //    OFFSET ' + CAST(@Offset AS NVARCHAR(10)) + ' ROWS
        //    FETCH NEXT ' + CAST(@PageSize AS NVARCHAR(10)) + ' ROWS ONLY;';

        //	print @SQLQuery
        //-- Execute the dynamic SQL query
        //EXEC sp_executesql @SQLQuery, N'@SearchTerm NVARCHAR(100)', @SearchTerm = @SearchTerm;



        //        CREATE PROCEDURE GetProducts
        //    @PageSize INT,
        //    @PageNumber INT,
        //    @SortColumn NVARCHAR(50),
        //    @SortOrder NVARCHAR(10),
        //    @SearchTerm NVARCHAR(100)
        //AS
        //BEGIN
        //    SET NOCOUNT ON;

        //    DECLARE @Offset INT = (@PageNumber - 1) * @PageSize;

        //    DECLARE @SQLQuery NVARCHAR(MAX);

        //        SET @SQLQuery = '
        //        SELECT*
        //        FROM products
        //        WHERE 1=1'; -- Placeholder to add conditions dynamically

        //    -- Searching
        //    IF @SearchTerm IS NOT NULL AND @SearchTerm != ''
        //    BEGIN
        //        SET @SQLQuery = @SQLQuery + '
        //        AND(product_name LIKE ''%'' + @SearchTerm + ''%''
        //        OR category LIKE ''%'' + @SearchTerm + ''%'')';
        //    END

        //    -- Sorting
        //    SET @SQLQuery = @SQLQuery + '
        //        ORDER BY ' + QUOTENAME(@SortColumn) + ' ' + @SortOrder;

        //    -- Pagination
        //    SET @SQLQuery = @SQLQuery + '
        //        OFFSET ' + CAST(@Offset AS NVARCHAR(10)) + ' ROWS
        //        FETCH NEXT ' + CAST(@PageSize AS NVARCHAR(10)) + ' ROWS ONLY;';

        //    -- Execute the dynamic SQL query
        //    EXEC sp_executesql @SQLQuery, N'@SearchTerm NVARCHAR(100)', @SearchTerm = @SearchTerm;
        //        END





        //public ExecutionResult<PaginatedResponse<JobDetails>> GetJobs(PaginationBaseRequestModel paginationBase)
        //{
        //    IQueryable<JobDetails> jobs = (from o in _dbContext.JobDetails
        //                                   join ur in _dbContext.Users on o.UserId equals ur.Id into cc
        //                                   from ur in cc.DefaultIfEmpty()
        //                                   where o.IsDeleted == false
        //                                   select new JobDetails
        //                                   {
        //                                       Id = o.Id,

        //                                   });
        //    if (!string.IsNullOrWhiteSpace(paginationBase.Search))
        //    {
        //        jobs = jobs.Where(s => s.Name.Contains(paginationBase.Search)
        //                            || s.Email.Contains(paginationBase.Search)
        //    }
        //    if (!string.IsNullOrWhiteSpace(paginationBase.SortOrder))
        //    {
        //        switch (paginationBase.SortOrder)
        //        {
        //            case "name_asc":
        //                jobs = jobs.OrderBy(s => s.Name);
        //                break;
        //            case "name_desc":
        //                jobs = jobs.OrderByDescending(s => s.Name);
        //                break;
        //            default:  // id ascending 
        //                jobs = jobs.OrderBy(s => s.Id);
        //                break;
        //        }
        //    }
        //    var res = jobs.ToList();
        //    PaginatedResponse<JobDetails> response = new PaginatedResponse<JobDetails>();
        //    response.TotalRecords = paginationBase.TotalRecords > 0 ? paginationBase.TotalRecords : res.Count();
        //    res = res.Skip(paginationBase.PageNumber).Take(paginationBase.PageSize).ToList();
        //    response.Data = _mapper.Map<List<JobDetails>>(res);
        //    response.PageNumber = paginationBase.PageNumber;
        //    response.PageSize = paginationBase.PageSize;
        //    return new ExecutionResult<PaginatedResponse<JobDetails>>(response);
        //}

    }
}
