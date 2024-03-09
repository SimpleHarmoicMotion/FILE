namespace Ex02
{
    class MyBt
    {
        private EventHandler _click;
        public event EventHandler Click
        {
            add
            {
                _click += value;
                //  _click + value => Single Cast
            }
            remove
            {
                _click -= value;
            }
        }

        public void MouseBtDn()
        {
            uf(this._click != null)
            {
                _click(this, EventArgs.Empty);
            }
        }
        /*속성 정의
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        */
    }
}