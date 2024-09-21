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

        private LvlStage _lvlStage = new();
        
        public void SpawnRandomEnemy()
        {
            if (_enemies.Count == 0 || _spawnPoints.Count == 0)
            {
                Debug.LogWarning("No enemies or spawn points available.");
                return;
            }

            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

            int MinDamageEnemy = _enemies.Min(x => x.Damage);

            List<Entity> MinDamageEnemys = _enemies.Where(x => x.Damage <= MinDamageEnemy).ToList();
            List<Entity> MaxDamageEnemys = _enemies.Where(x => x.Damage > MinDamageEnemy * 0.2).ToList();

            for (var i = 0; i < _enemies.Count; i++)
            { 
                if (ChanceReturn(MinDamageEnemy) == 1)
                {
                    GameObject fg = Instantiate(MinDamageEnemys[Random.Range(0, MinDamageEnemys.Count)].Enemy_PREFAB); //тут надо поменять GameObject на тип, который будет инфу по UI распредеять
                }
                else
                {
                    
                }
            }

        }

        private void GetEnemyByPriority()
        {
            
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
