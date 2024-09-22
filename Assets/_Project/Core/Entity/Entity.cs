using UnityEngine;

namespace Entitys
{
    [CreateAssetMenu(fileName = "NewEntity", menuName = "Entity/EntityVariant")]
    public class Entity : ScriptableObject
    {
        [field: SerializeField] public int Speed { get; private set; }
        [field: SerializeField] public int Health { get; private set; }
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public GameObject Enemy_PREFAB { get; private set; }

        public void EntityChange (int _speed, int _health, int _damage)
        {
            Speed = _speed;
            Health = _health;
            Damage = _damage;
        }
    }
}
