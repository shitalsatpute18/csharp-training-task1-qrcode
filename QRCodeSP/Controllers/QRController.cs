using Microsoft.AspNetCore.Mvc;
using QRCodeSP.Interfaces;
using QRCodeSP.Models;
using System.IO;

namespace QRCodeSP.Controllers
{
    [ApiController]
    [Route("api/qr/")]
    public class QRController : ControllerBase
    {
        private readonly IQRCodeService _qrCodeService;

        public QRController(IQRCodeService qrCodeService)
        {
            _qrCodeService = qrCodeService;
        }

        [HttpGet("generate-qr")]
        public IActionResult GenerateQRCode()
        {
            GenerateQR();
            return Ok("QR Code Generated Successfully");
        }

        private void GenerateQR()
        {
            IEmployee emp = new Employee()
            {
                EmployeeId = "1001",
                Technicalskills = "java",
                OrgName = "Praval",
                AccountName = "Dev"
            };

            string filePath = @"C:\Training\C# Training";
            string fileName = "QRCode.png";
            string fullPath = Path.Combine(filePath, fileName);
            _qrCodeService.GenerateAndSaveQRCode(emp, fullPath);
        }
    }
}
