using UnityEngine;

namespace Core.Guns
{
    public class GunInformation : MonoBehaviour
    {
    
        [CreateAssetMenu(fileName = "NewGun", menuName = "Guns/GunVariant")]
        public class Entity : ScriptableObject
        {
            [field: SerializeField] public int Damage { get; private set; }
            [field: SerializeField] public int Attackspeed { get; private set; } // attackspeed
            [field: SerializeField] public int Bulletspeed { get; private set; }            
            [field: SerializeField] public Sprite GunSprite { get; private set; }

            public void GunChange (int _attackspeed, int _bulletspeed,int _damage)
            {
                Bulletspeed = _bulletspeed;
                Attackspeed = _attackspeed;
                Damage = _damage;
            }
        }
    }
}

