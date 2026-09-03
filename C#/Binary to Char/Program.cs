internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Gib Binary");
        var sUserInp = Console.ReadLine();
        string sOutput = BinToChar(sUserInp);
        Console.WriteLine(sOutput);

    }

    private static string BinToChar(string sBin)
    {
        char[] cBinArray = sBin.ToArray();
        string sReturnString = "";
        for (int i = 7;i < cBinArray.Length; i+=9)
        {
            int a = i;
            double dCurrentNumber = 0;
            int iPotenz = 0;
            while ( a > (i - 8) )
            {
                var test = cBinArray[a];
                if (cBinArray[a] == '1')
                {
                    dCurrentNumber = (dCurrentNumber + Math.Pow(2, iPotenz));
                    iPotenz++;
                    a--;
                }
                else
                {
                    iPotenz++;
                    a--;
                }
            }
            sReturnString += (char)dCurrentNumber;
            
        }
        return sReturnString;
    }
}