
double demo = BetterRandom.NextDouble();
string demoString = BetterRandom.RandomString("bike", "tool", "goat", "biscuit");
bool coinFlip = BetterRandom.CoinFlip();
Console.WriteLine(demo);
Console.WriteLine(demoString);
Console.WriteLine(coinFlip);



public static class BetterRandom
{ 
    public static double NextDouble()
    {
        double thisDouble;
        Random temp = new Random();
        thisDouble = temp.NextDouble();
        return thisDouble * 10;

    }

    public static string RandomString(params string[]  theseStrings)
    {
        string outputString;
        Random random = new Random();



        outputString = theseStrings[random.Next(1, theseStrings.Length)];
        return outputString;
    }

    public static bool CoinFlip(int odds = 3)
    {
        bool output;
        Random random = new Random();
        int picker = random.Next(1, odds);

        if (picker % odds == 1)
        {
            output = true;
        }
        else
        {
            output = false;
        }


        return output;
    }
}