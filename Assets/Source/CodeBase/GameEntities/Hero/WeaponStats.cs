using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    [Serializable]
    public class WeaponStats
    {
        [SerializeField][Range(1, 10)] private int _damage;
        [SerializeField][Range(5, 15)] private int _magicDamage;
        [SerializeField][Range(0.1f, 5f)] private float _attackDelay;

        public float Damage => _damage;
        public float AttackDelay => _attackDelay;
        public float MagicDamage => _magicDamage;
    }
}
