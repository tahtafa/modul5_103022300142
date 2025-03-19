using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300142
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data: {0}, berisi: {1} , yang disimpan pada waktu UTC: {2}", i+1, storedData[i], inputDates[i]);
            }
        }
    }
}
