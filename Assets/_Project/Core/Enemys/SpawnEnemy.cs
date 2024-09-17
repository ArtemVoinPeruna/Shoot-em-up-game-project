using System.Collections.Generic;
using UnityEngine;
using Core.LvlStages;

namespace Core.Enemys
{
    public class SpawnEnemy : MonoBehaviour
    {
        [field: SerializeField] private List<Enemy> _enemies;
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
    }
}
