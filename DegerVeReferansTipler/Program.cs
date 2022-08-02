namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array,class,interface referans
            //int,double,float,char,decimal değer tip
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 75;
            Console.WriteLine(sayi1);
            int[] array1 = new int[3] {10,20,30};
            int[] array2 = new int[3] {100,200,300};
            array1 = array2;
            array2[0] = 5;
            Console.WriteLine(array1[0]);
            //değer tiplerde değer atanır,referans tiplerde adres atanır.


        }
    }
}