using UnityEngine;

namespace Core.Guns
{
<<<<<<< HEAD
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
            ChangeDamage(_damage);
            ChangeAttackSpeed(_attackSpeed);
            ChangeSpeed(_speed);
        }

        // Приватные методы для изменения значений
        private void ChangeDamage(int newDamage)
        {
            Damage = newDamage;
        }

        private void ChangeAttackSpeed(int newAttackSpeed)
        {
            AttackSpeed = newAttackSpeed;
        }

        private void ChangeSpeed(int newSpeed)
        {
            Speed = newSpeed;
=======
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
>>>>>>> parent of 35335cc (Merge pull request #8 from ArtemVoinPeruna/Combining_scenes)
        }
    }
}
