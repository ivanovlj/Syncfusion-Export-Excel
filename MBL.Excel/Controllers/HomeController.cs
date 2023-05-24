using Microsoft.AspNetCore.Mvc;
using Syncfusion.XlsIO;
using System.IO;

namespace MBL.Excel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GenerateExcel()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");


            using (var excelEngine = new ExcelEngine())
            {
                var application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;

                var workbook = application.Workbooks.Create();
                var worksheet = workbook.Worksheets[0];

                worksheet.Range["A1"].Text = "Hello";
                worksheet.Range["B1"].Text = "World!";

                var stream = new MemoryStream();
                workbook.SaveAs(stream);

                stream.Position = 0;

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "sample.xlsx");
            }
        }
    }
}
