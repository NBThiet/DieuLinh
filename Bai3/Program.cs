// See https://aka.ms/new-console-template for more information
 static void TinhVaInTongTuyetDoiAm(double[] arr)
        {
            double sum = 0;
            foreach (var num in arr)
            {
                if (num < 0)
                {
                    sum += Math.Abs(num);
                }
            }
            Console.WriteLine("Tong gia tri tuyet doi am cua mang: " + sum);
        }

static void TinhVaInTichPhanTuGiuaMaxVaMin(double[] arr)
{
    int maxIndex = 0;
    int minIndex = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[maxIndex])
        {
            maxIndex = i;
        }
        if (arr[i] < arr[minIndex])
        {
            minIndex = i;
        }
    }

    int start = Math.Min(maxIndex, minIndex) + 1;
    int end = Math.Max(maxIndex, minIndex);
    double product = 1;

    for (int i = start; i < end; i++)
    {
        product *= arr[i];
    }

    Console.WriteLine("Tich cac phan tu nam giua Max va Min: " + product);
}

static void SapXepTangDan(double[] arr)
{
    Array.Sort(arr);
    Console.WriteLine("Mang sau khi sap xep tang dan:");
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

static void SapXepChanLe(double[] arr)
{
    Array.Sort(arr, (a, b) =>
    {
        int compare = (int)a % 2 - (int)b % 2;
        if (compare == 0)
        {
            compare = a.CompareTo(b);
        }
        return compare;
    });
}


Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());

double[] arr = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Nhap phan tu thu {0}: ", i + 1);
    arr[i] = double.Parse(Console.ReadLine());
}

TinhVaInTongTuyetDoiAm(arr);
TinhVaInTichPhanTuGiuaMaxVaMin(arr);
SapXepTangDan(arr);
SapXepChanLe(arr);

Console.WriteLine("Mang sau khi sap xep chan le:");
foreach (var num in arr)
{
    Console.Write(num + " ");
}