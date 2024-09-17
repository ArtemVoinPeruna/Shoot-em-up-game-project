using System;
using UnityEngine;

namespace Core.Enemys
{
    [CreateAssetMenu(fileName = "NewEnemy", menuName = "Enemy/EnemyVariant")]
    public class Enemy : ScriptableObject
    {
        [field: SerializeField] public int Speed;
        [field: SerializeField] public int Health;
        [field: SerializeField] public int Damage;
        [field: SerializeField] public GameObject Enemy_PREFAB;
    }
}
