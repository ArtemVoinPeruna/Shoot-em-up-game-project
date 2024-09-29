using System.Collections.Generic;
using UnityEngine;

namespace Core.Guns
{
    [CreateAssetMenu(fileName = "NewGunList", menuName = "GunList/GunList")]
    public class GunBox : ScriptableObject
    {
        public List <Gun> GunsList { get; private set; }
    }
}
