using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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


    }
}
