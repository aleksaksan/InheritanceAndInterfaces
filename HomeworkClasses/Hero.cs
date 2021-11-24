using System;

namespace HomeworkClasses
{
    public class Hero : Humanoid, ICombatan
    {
        public readonly string name;
        int _minAttack;
        int _maxAttack;
        public int MinAttack 
        { 
            get => _minAttack; 
            set
            {
                if (value > 0)
                    _minAttack = value;
                else
                    throw new ArgumentException("атака не может быть меньше или равна нуля");
            }
        }
        public int MaxAttack
        {
            get => _maxAttack;
            set
            {
                if (value >= MinAttack)
                    _maxAttack = value;
                else
                    throw new ArgumentException("MaxAttack должна быть не меньше MinAttack");
            }
        }

        public int GetAttack(int bonus)
        {
            Random rnd = new Random();
            return rnd.Next(MinAttack, MaxAttack + 1) + bonus;
        }
        public Hero(string name, Race race, int hp, int minAttack, int maxAttack, int intelligence)
        {
            this.name = name;
            _maxHp = _currentHp = hp;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
            this.intelligence = intelligence;
        }
        public override string ToString()
        {
            return $"имя:\t\t\t{name}\nрасса:\t\t\t{_race}\nтекущее здоровье:\t{_currentHp}\n" +
                $"урон:\t\t\t{(MaxAttack-MinAttack)/2}\nинтеллект:\t\t{intelligence}";
        }
        public void GetInfo()
        {
            Console.WriteLine("__________________________________________________________\n");
            Console.WriteLine("Информация о герое:\n");
            Console.WriteLine(ToString());
            Console.WriteLine("__________________________________________________________");
        }
    }
}
