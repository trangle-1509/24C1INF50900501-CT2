internal class Program
{
    private static void Main(string[] args)
    {
        // baitap_1();
        // baitap_2();
        baitap_3();
    }
    static void baitap_1()
    {
        float doC, doK, doF;
        Console.WriteLine("Nhap mot nhiet do (C):");
        doC = Convert.ToSingle(Console.ReadLine());
        doK = doC + 273;
        doF = doC * 18 / 10 + 32;

        Console.WriteLine($"{doC} do C = {doK} do K");
        Console.WriteLine($"{doC}do C = {doK} do F");
        Console.ReadLine();
    }
    static void baitap_2()
    {
        double PI = Math.PI;
        Console.WriteLine("Nhap ban kinh hinh cau r");
        double r = Convert.ToSingle(Console.ReadLine());
        double s = 4 * Math.PI * Math.Pow(r, 2);
        double v = 4 / 3 * Math.PI * Math.Pow(r, 3);

        Console.WriteLine($"{r} R = {s} S");
        Console.WriteLine($"{r} R = {v} V");
        Console.ReadLine();
    }
    static void baitap_3()
    {
        Console.Write("Nhap so thu nhat:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so thu hai:");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int cong = n1 + n2;
        int tru = n1 - n2;
        int nhan = n1 * n2;
        int chia = n1 / n2;
        int layDu = n1 % n2;

        Console.WriteLine($"{n1} + {n2} = {cong}");
        Console.WriteLine($"{n1} - {n2} = {tru}");
        Console.WriteLine($"{n1} * {n2} = {nhan}");
        Console.WriteLine($"{n1} / {n2} = {chia}");
        Console.WriteLine($"{n1} % {n2} = {layDu}");
        Console.ReadLine();

    }
}
}