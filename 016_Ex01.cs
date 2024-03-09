namespace Ex01
{
    class Program
    {
        private void Cal(int a)
        {
            a *= 2;
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            
            int val = 100;
            P.Cal(val);
            //val 값은 부동
        }
    }
}