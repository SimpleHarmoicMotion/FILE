namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string category = (string)"딸기";
            int price;
            switch(category)
            {
                case "사과":
                    price = 1000;
                    break;
                case "딸기":
                    price = 1100;
                    break;
                case "포도":
                    price = 900;
                    break;
                default:
                    price = 0;
                    break;
            }

            Console.WriteLine(price);
        }
    }
}