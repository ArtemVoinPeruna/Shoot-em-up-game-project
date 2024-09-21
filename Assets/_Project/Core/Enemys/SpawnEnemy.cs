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
