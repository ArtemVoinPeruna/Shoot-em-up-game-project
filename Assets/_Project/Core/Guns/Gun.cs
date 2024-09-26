using UnityEngine;

public class Gun : MonoBehaviour
{
   
    [CreateAssetMenu(fileName = "NewGun", menuName = "Guns/GunVariant")]
    public class Entity : ScriptableObject
    {
       // [field: SerializeField] public int AttackSpeed { get; private set; }
       // [field: SerializeField] public int Ammo { get; private set; }
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public GameObject Gun_PREFAB { get; private set; }

        public void GunChange (int _ammo, int _attackspeed,int _damage)
        {
           // Ammo
           // AttackSpeed = _Attackspeed;
            Damage = _damage;
        }
    }
}

