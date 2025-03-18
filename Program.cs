class main
{
    static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        pemrosesData.dapatkanNilaiTerbesar<float>(10, 30, 22);
      
        simpleDataBase<float> simpleDataBase = new simpleDataBase<float>();
        simpleDataBase.addNewData(10);
        simpleDataBase.addNewData(30);
        simpleDataBase.addNewData(22);
        simpleDataBase.printAllData();
    }
}

class simpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public simpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count(); i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData.ElementAt(i)} " +
                $"yang disimpan pada waktu UTC: {inputDates.ElementAt(i)}");
        }
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
