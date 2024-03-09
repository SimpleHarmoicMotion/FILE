namespace Ex01
{
    class Program
    {
        enum City
        {
            Seoul,
            Daejun,
            Busan = 5,
            Daegu = 10
        }

        static void Main(string[] args){
            City myCity;
            myCity = City.Seoul;

           int cityVal = (int) myCity;

            if(myCity == City.Seoul){
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
   
}