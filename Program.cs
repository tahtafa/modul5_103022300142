namespace modul5_103022300142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SimpleDataBase<float> simpleDataBase = new SimpleDataBase<float>();
            simpleDataBase.AddNewData(10);
            simpleDataBase.AddNewData(30);
            simpleDataBase.AddNewData(22);
            simpleDataBase.PrintAllData();
        }
    }
}
