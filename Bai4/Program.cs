// See https://aka.ms/new-console-template for more information
 static void InDoiCoDiemNhieuNhat(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int[] diem = new int[n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i != j)
            {
                diem[i] += matrix[i, j];
            }
        }
    }

    int maxDiem = diem.Max();

    Console.WriteLine("Doi co so diem cao nhat:");
    for (int i = 0; i < n; i++)
    {
        if (diem[i] == maxDiem)
        {
            Console.Write((i + 1) + " ");
        }
    }
    Console.WriteLine();
}

static void InDoiThangNhieuHonThua(int[,] matrix)
{
    int n = matrix.GetLength(0);
    Console.WriteLine("Doi co so tran thang nhieu hon so tran thua:");
    for (int i = 0; i < n; i++)
    {
        int tranThang = 0;
        int tranThua = 0;
        for (int j = 0; j < n; j++)
        {
            if (i != j)
            {
                if (matrix[i, j] == 3)
                {
                    tranThang++;
                }
                else if (matrix[i, j] == 0)
                {
                    tranThua++;
                }
            }
        }
        if (tranThang > tranThua)
        {
            Console.Write((i + 1) + " ");
        }
    }
    Console.WriteLine();
}

static void InDoiKhongThua(int[,] matrix)
{
    int n = matrix.GetLength(0);
    Console.WriteLine("Doi khong thua tran nao:");
    for (int i = 0; i < n; i++)
    {
        bool thua = false;
        for (int j = 0; j < n; j++)
        {
            if (i != j && matrix[i, j] == 0)
            {
                thua = true;
                break;
            }
        }
        if (!thua)
        {
            Console.Write((i + 1) + " ");
        }
    }
    Console.WriteLine();
}

int n;
Console.Write("Nhap so doi tham gia: ");
n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("Nhap ket qua tran " + (i + 1) + " vs " + (j + 1) + " (3/1/0): ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

InDoiCoDiemNhieuNhat(matrix);
InDoiThangNhieuHonThua(matrix);
InDoiKhongThua(matrix);