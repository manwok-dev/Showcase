namespace ViktorMeth
{
    public class Program
    {
        static void Main(string[] args)
        {
            Viktor vik1 = new Viktor(1,2,3);
            Viktor vik2 = new Viktor(4,5,6);

            Viktor vikErg = vik1.Cross(vik2);
            Console.WriteLine(vikErg.OutputStr());

            Console.WriteLine("Skalar: " + vik1.Skalar(vik2));
            double[] erg = vik1.Leng(vik2);
            Console.WriteLine("Vecotr length: " + erg[0] + " & " + erg[1]);

            Console.WriteLine("Angel: " + vik1.Angel(vik2));
        }
    }
}
