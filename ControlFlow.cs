using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        //bai_1();
        //bai_2();
        //bai_3(); 
        //bai_4();
        //bai_5();
        //bai_6();
        bai_7();
        //bai_8();
        //bai_9();
        //bai_10();
        //bai_11();

    }
    static void bai_1()
    {
        Console.Write("Nhap mot so bat ky: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Day la so chan");
        }
        else
        {
            Console.WriteLine("Day la so le");
        }
        Console.ReadLine();
    }

    static void bai_2()
    {
        int num1, num2, num3, largest;
        Console.Write("Nhap so thu nhat: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so thu ba: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            largest = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }
        Console.WriteLine("So lon nhat la: " + largest);
        Console.ReadLine();
    }

    static void bai_3()
    {
        Console.Write("Nhap toa do x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap toa do y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.Write($"Diem ({x},{y}) nam o goc phan tu thu nhat");
        }
        else if (x < 0 && y > 0)
        {
            Console.Write($"Diem ({x},{y}) nam o goc phan tu thu hai");
        }
        else if (x < 0 && y < 0)
        {
            Console.Write($"Diem ({x},{y}) nam o goc phan tu thu ba ");
        }
        else
        {
            Console.Write($"Diem ({x},{y}) nam o goc phan tu thu tu");
        }
        Console.ReadLine();
    }

    static void bai_4()
    {
        Console.Write("Nhap canh a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b <= c || a + c <= b || a + b <= c)
        {
            Console.WriteLine("Day khong phai la tam giac");
        }
        else if (a == b && b == c)
        {
            Console.WriteLine("Day la tam giac deu");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Day la tam giac can");
        }
        else
        {
            Console.WriteLine("Day la tam giac thuong");
        }
        Console.ReadLine();
    }

    static void bai_5()
    {
        int sum = 0;
        int num;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("So thu {0}: ", i);
            num = int.Parse("0" + Console.ReadLine());
            sum += num;
        }
        double avg = (double)sum / 10;
        Console.WriteLine("Tong= " + sum);
        Console.WriteLine("Trung binh cong= " + avg);
        Console.ReadLine();
    }

    static void bai_6()
    {
        int n;
        Console.Write("Nhap so nguyen n: ");
        n = int.Parse("0" + Console.ReadLine());
        Console.WriteLine($"Bang cuu chuong cua {n} la: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
        Console.ReadLine();
    }

    static void bai_7()
    {
           
        }
    }
}
