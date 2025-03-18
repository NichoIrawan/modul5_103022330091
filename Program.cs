class main
{
    static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        pemrosesData.dapatkanNilaiTerbesar<float>(10, 30, 22);
    }
}

class PemrosesData
{
    public void dapatkanNilaiTerbesar<T>(T T1, T T2, T T3)
    {
        dynamic a = T1;
        dynamic b = T2;
        dynamic c = T3;

        dynamic max = a;

        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine($"Nilai Maksimum adalah {max}");
    }
}