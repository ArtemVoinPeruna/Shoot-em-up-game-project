using UnityEngine;

namespace Core.Guns
{
    [CreateAssetMenu(fileName = "NewGun", menuName = "Guns/GunVariant")]
    public class GunInformation : ScriptableObject
    {
        [field: SerializeField] public int BulletSpeed { get; private set; }
        [field: SerializeField] public int AttackSpeed { get; private set; }
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public Sprite GunSprite { get; private set; }

        public void EntityChange (int _bulletspeed, int _attackspeed, int _damage)
        {
            BulletSpeed = _bulletspeed;
            AttackSpeed = _attackspeed;
            Damage = _damage;
        }
    }
}
