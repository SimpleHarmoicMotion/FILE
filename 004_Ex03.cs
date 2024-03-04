namespace Ex03{
    class Program{
        static void Main(string[] args){
            int[] scores = {80, 85 ,90, 95, 100};
            int sum = CalculateSum(scores);
            Console.WriteLine(sum);
        }

        static int CalculateSum(int[] scoresArray){
            int sum = 0;
            for(int i = 0 ; i < scoresArray.Length ; i++){
                sum += scoresArray[i];
            }
            return sum;
        }
    }
}