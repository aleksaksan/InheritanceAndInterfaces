using System;

namespace HomeworkClasses
{
    public abstract class Creature
    {
        protected string    _name;
        protected int       _maxHp;
        protected int       _currentHp;
        public bool IsDead => _currentHp > 0 ? true : false;
        public abstract void Wounds(int dmg);
        
    }
}
