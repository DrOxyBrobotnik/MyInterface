namespace MyInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BunnyPic bunna = new BunnyPic(69.69);
            BunnyDungeon(bunna);
            KattPic katt = new KattPic();
            BunnyDungeon(katt);
            List<BunnyPic> dummaretainer = new List<BunnyPic>();
           
        }

        static void BunnyDungeon(ICummable cumma)
        {
            var dumma = cumma.Cum();
            if (dumma <= 0)
            {
                Console.WriteLine("Small load");
            }
            else if (dumma >= 1)
            {
                Console.WriteLine("Large load");
            }
            else
            {
                Console.WriteLine("Medium load");
            }
        }
    }
}