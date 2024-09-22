using System.Collections.Generic;
using UnityEngine;
using Core.LvlStages;
using Entitys;
using System.Linq;

namespace Core.Enemys
{
    public class SpawnEnemy : MonoBehaviour
    {
        [field: SerializeField] private List<Entity> _enemies;
        [field: SerializeField] private List<Transform> _spawnPoints;
        [field: SerializeField] private int NumberWaves;

        private void Start() 
        {
            SpawnRandomEnemy();
        }
        
        public void SpawnRandomEnemy()
        {
            if (_enemies.Count == 0 || _spawnPoints.Count == 0)
            {
                Debug.LogWarning("No enemies or spawn points available.");
                return;
            }

            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

            int MinDamageEnemy = _enemies.Min(x => x.Damage);

            List<Entity> DamageEnemys = new();

            for (var i = 0; i < NumberWaves; i++)
            { 
                if (ChanceReturn(MinDamageEnemy) == 1)
                {
                    DamageEnemys = _enemies.Where(x => x.Damage <= MinDamageEnemy).ToList();
                }
                else
                {
                    DamageEnemys = _enemies.Where(x => x.Damage > MinDamageEnemy * 0.2).ToList();
                }

                GameObject EnemyObj = Instantiate(DamageEnemys[Random.Range(0, DamageEnemys.Count)].Enemy_PREFAB, _spawnPoints[Random.Range(0, _spawnPoints.Count)].position, Quaternion.identity); //тут надо поменять GameObject на тип, который будет инфу по UI распредеять
            }

            MinDamageEnemy = (int)(MinDamageEnemy * 0.05);

            NumberWaves++;
        }

        public int ChanceReturn(params int[] chances)
        {
            int chance = Random.Range(0, 100) + 1;
            for (int index = 0; index < chances.Length; index++)
            {
                var ch = chances[index];
                if (chance <= ch)
                    return index;
            }
            return 0;
        }
    }
}
