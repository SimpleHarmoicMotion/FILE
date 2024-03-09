namespace Ex01
{
    class Program
    {
        static void Main(string[] args){
            int a = -11;
            int val;
            if( a >= 0 ){
                val = a;
            }
            else{
                val = -a;
            }

            Console.WriteLine(val);
        }
    }
}