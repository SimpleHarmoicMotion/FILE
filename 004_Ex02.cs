namespace Ex02{
    class Program{
        static void Main(string[] args){
            int sum = 0;
            int[] scores = {50, 60, 70, 80, 90};
            for(int i = 0 ; i < scores.Length ; i++){
                sum += scores[i];
            }
            Console.WriteLine(sum);
        }
    }
}