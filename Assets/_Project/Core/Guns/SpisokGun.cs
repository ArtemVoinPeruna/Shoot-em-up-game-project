using UnityEngine;

namespace Core.Guns
{
    [CreateAssetMenu(fileName = "NewGunList", menuName = "GunList/GunList")]
    public class SpisokGun : ScriptableObject
    {
        public Gun[] availableGuns { get; private set; }
    }
}
