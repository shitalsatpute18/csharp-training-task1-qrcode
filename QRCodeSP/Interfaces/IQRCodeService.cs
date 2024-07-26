using QRCodeSP.Interfaces;

namespace QRCodeSP.Interfaces
{
    public interface IQRCodeService
    {
        void GenerateAndSaveQRCode(IEmployee employee, string filePath);
    }
}


