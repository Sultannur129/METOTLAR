namespace METOTLAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr1=new Product();
            pr1.Name = "Elma";
            pr1.price = 15;
            pr1.description = "Amasya elması";

            Product pr2=new Product();
            pr2.Name = "Karpuz";
            pr2.price = 80;
            pr2.description = "Diyarbakır Karpuzu";

            Product[] prs = new Product[] {pr1,pr2 };
            
            foreach (Product p in prs)
            {
                Console.WriteLine(p.Name + " " + p.price + " " + p.description);
            }

            Console.WriteLine("-------------METOTLAR--------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(pr1);
        }
    }
}