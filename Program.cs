class main
{
    static void Main(string[] args)
    {
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
