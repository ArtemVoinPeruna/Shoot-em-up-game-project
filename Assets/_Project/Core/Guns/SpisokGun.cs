using System.Collections.Generic;
using UnityEngine;

namespace Core.Guns
{
    [CreateAssetMenu(fileName = "NewGunList", menuName = "GunList/GunList")]
    public class SpisokGun : ScriptableObject
    {
        public List <Gun> availableGuns { get; private set; }
    }
}
