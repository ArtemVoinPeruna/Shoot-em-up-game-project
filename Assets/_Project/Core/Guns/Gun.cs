using UnityEngine;

namespace Core.Guns
{
    public class Gun : MonoBehaviour
    {
    
        [CreateAssetMenu(fileName = "NewGun", menuName = "Guns/GunVariant")]
        public class Entity : ScriptableObject
        {
            [field: SerializeField] public int Damage { get; private set; }
            [field: SerializeField] public int Reload { get; private set; }
            [field: SerializeField] public int Speed { get; private set; }            
            [field: SerializeField] public Sprite GunSprite { get; private set; }

            public void GunChange (int _ammo, int _attackspeed,int _damage)
            {
            // Ammo
            // AttackSpeed = _Attackspeed;
                Damage = _damage;
            }
        }
    }
}

