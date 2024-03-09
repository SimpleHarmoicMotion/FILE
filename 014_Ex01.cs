namespace Ex01
{
    public class Cls1
    {
        private string name;
        private int age;

        public event EventHandler NameChanged;

        public MyCustomer()
        {
            name = string.Empty;
            age = -1;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(this.name != value)
                {
                    thus.name = value;
                    if (NameChanged != null)
                    {
                        Namechanged(this, EnentArgs.Empty);
                    }
                }
            }
        }

        public int age{
            get { return this.age; }
            set { this.age = value; }
        }

        public string GetCusData()
        {
            string data = string.Format("Name : {0} (age : {1})", this.name, this.age);
            return data;
        }
    }
}