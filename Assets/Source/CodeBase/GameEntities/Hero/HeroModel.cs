using System;

namespace Assets.Source.CodeBase
{
    public class HeroModel
    {
        private float _armor;

        public HeroModel(int health, float armor)
        {
            _armor = armor;
        }

        public int Health { get; private set; }

        public void TakeDamage(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            int damage = HandleDamage(value);

            if (Health - damage < 0)
                Health = 0;
            else
                Health -= damage;
        }

        private int HandleDamage(int value)
        {
            int percent = 100;
            int newDamage = value - value / percent * (int)(_armor * percent);
            return newDamage;
        }
    }
}