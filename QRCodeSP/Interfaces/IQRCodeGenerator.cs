namespace QRCodeSP.Interfaces
{
    public interface IQRCodeGenerator
    {
        byte[] GenerateQRCode(string data);
    }
}
