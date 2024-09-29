using UnityEngine;

namespace Core.Guns
{
    [CreateAssetMenu(fileName = "NewGun", menuName = "Guns/GunVariant")]
    public class Gun : ScriptableObject
    {
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public int AttackSpeed { get; private set; }
        [field: SerializeField] public int Speed { get; private set; }
        [field: SerializeField] public Sprite GunSprite { get; private set; }

        // Метод для изменения полей
        public void GunChange(int _speed, int _attackSpeed, int _damage)
        {
            Damage = _damage;
            Speed = _speed;
            AttackSpeed = _attackSpeed;
        }
    }
}
