using System;

namespace HomeworkClasses
{
    public class Humanoid: Creature
    {
        public enum Race { human, elf, orc, dwarf, alien };
        protected readonly Race        _race;
        public int                  intelligence;
        public Inventar             inventar;

        public override void Wounds(int dmg) 
        {
            _currentHp -= GetDamage(dmg);
        }
        int GetDamage(int amountOfDamage)
        {
            return _race switch
            {
                Race.human  => amountOfDamage,
                Race.elf    => (int)(amountOfDamage * 1.1),
                Race.orc    => _currentHp - amountOfDamage > 0 ? amountOfDamage : _currentHp - 1,
                Race.dwarf  => (int)(amountOfDamage * 0.9),
                Race.alien  => amountOfDamage,
                _           => throw new ArgumentException("неизвестное существо")
            };
        }
    }
}
