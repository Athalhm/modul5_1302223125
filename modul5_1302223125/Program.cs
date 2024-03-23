// See https://aka.ms/new-console-template for more information

namespace modul5_1302223125
{
    internal class Program
    {
        public class Penjumlahan
        {


            public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
            {
                dynamic Angka1 = angka1;
                dynamic Angka2 = angka2;
                dynamic Angka3 = angka3;
                return Angka1 + Angka2 + Angka3;
            }
        }
        public class SimpleDataBase<T>
        {
            public List<T> storedData;
            public List<DateTime> inputDates;
            
            public void AddNewData(T data)
            {
                this.storedData.Add(data);
                this.inputDates.Add(DateTime.Now);
            }
            public void PrintAllData()
            {
                for(int i = 0; i<this.storedData.Count; i++)
                {
                    Console.WriteLine("Data " + i + "berisi " + this.storedData[1] + "yang disimpan pada waktu UTC : 3/10/2022 5:32:01 AM");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 22));
            Console.WriteLine("\n" + Penjumlahan.JumlahTigaAngka<double>(13, 02, 22));
            SimpleDataBase<double>Data = new SimpleDataBase<double>();
            Data.AddNewData(13);
            Data.AddNewData(02);
            Data.AddNewData(22);
            Data.PrintAllData();
        }

    }
}

