using QRCodeSP.Interfaces;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using System.IO;
using QRCoder;


namespace QRCodeSP.Services
{
    public class QRCodeService : IQRCodeService
    {
        private readonly IQRCodeGenerator _qrCodeGenerator;

        public QRCodeService(IQRCodeGenerator qrCodeGenerator)
        {
            _qrCodeGenerator = qrCodeGenerator;
        }

        public void GenerateAndSaveQRCode(IEmployee employee, string filePath)
        {
            string qrData = $"EmployeeId: {employee.EmployeeId}\nTechnicalskills: {employee.Technicalskills}\nOrgName: {employee.OrgName}\nAccountName: {employee.AccountName}";
            byte[] qrCodeImage = _qrCodeGenerator.GenerateQRCode(qrData);

            using (Image<Rgba32> image = Image.Load<Rgba32>(qrCodeImage))
            {
                image.Save(filePath, new PngEncoder());
            }
        }
    }
}


