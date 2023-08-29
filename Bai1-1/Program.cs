// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ho va Ten");
var name = Console.ReadLine();

Console.WriteLine("Lop");
var lop = Console.ReadLine();

Console.WriteLine("Diem QTH");
var QTH = double .Parse(Console.ReadLine());



Console.WriteLine("Diem HTTTQL");
var HTTTQL = double .Parse(Console.ReadLine());


Console.WriteLine("Diem CSLT");
var CSLT = double .Parse(Console.ReadLine());


Console.WriteLine("Diem Triet");
var Triet = double .Parse(Console.ReadLine());


var GPA = QTH + HTTTQL + CSLT + Triet;
    GPA = (GPA / 40) * 4 ;

Console.WriteLine(GPA.GetType());
string Top = "a";


if(GPA < 2)
{
Top = "yeu";
}else if(2<GPA && GPA <2.5)
{
    Top = "Trung Binh";
}
else if(2.5 < GPA && GPA<3.2)
{
    Top = "Kha";
}else if(3.2< GPA && GPA <3.6)
{
    Top = "Gioi";
}else 
{
    Top = "Xuat Sac";
}

Console.WriteLine($"Sinh vien {name.ToUpper()}, Lop {lop}, Dat GPA {GPA},Xep loai {Top}");




