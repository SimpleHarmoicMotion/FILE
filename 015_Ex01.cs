namespace Ex01
{
    class Project
    {
        double _Sum = 0;
        DateTime _Time;
        bool? _Selected;

        public void CheckInput( int? i, double? d, DateTime? time, bool? selected)
        {
            if(i.HasValue && d.HasValue)
                this._Sum = (double)i.Value + (double)d.Value;

            if(!time.HasValue)
                throw new ArgumentException();
            else
                this._Time = time.Value;
            
            this._Selected = selected ?? false;
            
        }
    }
}