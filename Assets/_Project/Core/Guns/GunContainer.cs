using UnityEngine;

namespace Core.Guns
{
    public class GunContainer : MonoBehaviour
    {
        public Gun Gun { get; private set; }

        public delegate void CreatedGunDelegate(Gun gun);
        public event CreatedGunDelegate CreatedGun;

        public GunContainer Init(Gun gun)
        {
            Gun = gun;
            CreatedGun(gun);
            return this;
        }
    }
}
