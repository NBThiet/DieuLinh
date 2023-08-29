// See https://aka.ms/new-console-template for more information



static double NhapSoThuc(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine());
}

static char NhapToanTu(string message)
{
    Console.Write(message);
    return char.Parse(Console.ReadLine());
}

static double ThucHienPhepTinh(double a, double b, char operation)
{
   switch (operation)
            {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0.");
                return double.NaN;
            }
        default:
            Console.WriteLine("Phep toan khong hop le.");
            return double.NaN;
    }
}

static void InKQ(double result)
{
    if(!double.IsNaN(result))
    {
        Console.WriteLine("Ket qua :" + result);
    }
}


string choise;
do
{
    double a = NhapSoThuc("nhap so thu nhat:");
    double b = NhapSoThuc("nhap so thu hai:");
    char operation = NhapToanTu("Nhap phep tinh ban muon:");
    double result = ThucHienPhepTinh(a,b,operation);

    InKQ(result);

    Console.WriteLine("ban co muon tiep tuc khong (chon T hoac t de ket thuc):");

    choise = Console.ReadLine();

} while (choise != "T" && choise != "t");