using UnityEngine;

namespace Core.Guns
{
    public class Gun : MonoBehaviour
    {
    
        [CreateAssetMenu(fileName = "NewGun", menuName = "Guns/GunVariant")]
        public class Entity : ScriptableObject
        {
            [field: SerializeField] public int Damage { get; private set; }
            [field: SerializeField] public int AttackSpeed { get; private set; }
            [field: SerializeField] public int Speed { get; private set; }            
            [field: SerializeField] public Sprite GunSprite { get; private set; }
            public void GunChange (int _speed, int _attackSpeed,int _damage)
            {
                Damage = _damage;
                AttackSpeed = _attackSpeed;
                Speed = _speed;
            }
        }
    }
}

