namespace Lab2.Models
{
    public class Licz
    {
        private int _value;

        public Licz(int value)
        {
            _value = value;
        }

        public void Dodaj(int add)
        {
            Value += add;
        }

        public void Oddejmnij(int sub)
        {
            Value -= sub;
        }
    }
}
