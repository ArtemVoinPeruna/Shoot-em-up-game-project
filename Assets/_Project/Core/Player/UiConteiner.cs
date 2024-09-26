using Entitys;
using UnityEngine;

namespace Core.Player
{
    public class UiConteiner : MonoBehaviour
    {
        [field: SerializeField] public Entity SpecPl { get; set; }

        public delegate void BarChangedDelegate(Entity bar);
        public event BarChangedDelegate BarChanged;

        public UiConteiner Init(Entity bar)
        {
            if (bar != null)
            {
                SpecPl = bar;
                BarChanged?.Invoke(bar);
            }
            else
            {
                Debug.LogError("Attempted to initialize with a null RewardLine.");
            }

            return this;
        }
    }
}
