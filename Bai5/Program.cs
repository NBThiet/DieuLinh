 Console.Write("Nhap vao hai so nguyen a va b: ");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    // a. In kết quả bình phương tổng a và b
    TBP(a, b);

    // b. Tính và in kết quả bình phương tổng a và b
    int kq1 = 0;
    TBP(a, b, ref kq1);
    Console.WriteLine("Ket qua tham so kq: " + kq1);

    // c. Tính và trả về kết quả bình phương tổng a và b
    int kq2 = TBP(a, b);
    Console.WriteLine("Ket qua tra ve: " + kq2);
}

// a. Hàm TBP(a,b): Kết quả được in lên màn hình
static void TBP(int a, int b)
{
    int sumOfSquares = a * a + b * b;
    Console.WriteLine("Tong binh phuong cua " + a + " va " + b + " la: " + sumOfSquares);
}

// b. Hàm TBP(a,b,kq): Tham số kq mang kết quả
static void TBP(int a, int b, ref int kq)
{
    kq = a * a + b * b;
}

// c. Hàm TBP(a,b): Kết quả được trả về qua tên hàm
static int TBP(int a, int b)
{
    return a * a + b * b;
}
