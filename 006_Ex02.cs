namespace Ex02
{
    class Program
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

        static void Main(string[] args){
            Border b = Border.Top | Border.Bottom;

            if((b & Border.Top) != 0){
                if(b.HasFlag(Border.Bottom)){
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}