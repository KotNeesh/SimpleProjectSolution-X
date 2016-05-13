

namespace SimpleTeam.Sce
{
    public class SimplusHP : ISimplusHPServer, ISimplusHPClient
    {
        private int _cur;
        private int _max = 100;
        private int _bonusCapture = 10;
        public int Cur { get { return _cur; } }
        public int Max { get { return _max; } }
        private void Limit()
        {
            if (_cur > _max)
            {
                _cur = _max;
            }
        }
        public bool Attack(int HP)
        {
            _cur -= HP;
            bool isСaptured = _cur < 0;
            if (isСaptured)
            {
                _cur *= -1;
                _cur += _bonusCapture;
            }
            Limit();
            return isСaptured;
        }
        public void Defense(int HP)
        {
            Inc(HP);
        }
        public void Inc(int HP)
        {
            _cur += HP;
            Limit();
        }
    }
}
