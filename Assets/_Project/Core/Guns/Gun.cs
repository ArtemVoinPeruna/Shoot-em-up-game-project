using UnityEngine;

namespace Core.Guns
{
    public class Gun : MonoBehaviour
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
        private void Update()
            {
                RotateGun();
            }

        // Метод для поворота оружия
        private void RotateGun()
            {
                // Пример поворота оружия вокруг оси Y
                float rotationSpeed = 100f; // Скорость поворота
                float rotationInput = Input.GetAxis("Horizontal"); // Ввод пользователя
                transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);
            }
    }
}
