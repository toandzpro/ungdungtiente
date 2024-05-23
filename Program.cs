using System.Text;
public class Bàitap9
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        float rate = 23000; // Tỉ giá 23000 VND/USD
        Console.Write("Nhập số tiền USD: ");
        float soTienUSD = Convert.ToSingle(Console.ReadLine());
        float soTienVND = soTienUSD * rate;
        Console.WriteLine("Giá trị tiền VNĐ là: " + soTienVND);
    }
}