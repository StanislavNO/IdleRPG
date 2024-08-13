using UnityEngine;

namespace Assets.Source.CodeBase
{
    [CreateAssetMenu(fileName = "HeroConfig", menuName = "Configs/Hero")]
    public class HeroConfig : ScriptableObject
    {
        [field: SerializeField] public int Health { get; private set; }
        [field: SerializeField] public float Armor { get; private set; }
        [field: SerializeField] public WeaponStats Weapon { get; private set; }
    }
}