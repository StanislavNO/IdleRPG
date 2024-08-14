using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class HeroModel : IHealth
    {
        private readonly float _armor;
        private int _maxHealth = 100;

        public HeroModel(int startHealth, float armor)
        {
            _armor = armor;
            _maxHealth = startHealth;
        }

        public int HealthPoint { get; private set; }

        public void TakeDamage(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            int damage = HandleDamage(value);

            if (HealthPoint - damage < 0)
                HealthPoint = 0;
            else
                HealthPoint -= damage;
        }

        public void AddHealth(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            if(HealthPoint + value > _maxHealth)
                HealthPoint = _maxHealth;
            else
                HealthPoint += value;
        }

        private int HandleDamage(int value)
        {
            int percent = 100;
            int newDamage = value - value / percent * (int)(_armor * percent);
            return newDamage;
        }
    }
}