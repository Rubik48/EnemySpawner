using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private float _spawnInterval = 2f;
    
    private void Start()
    {
        StartCoroutine(SpawnEnemiesRoutine());
    }
    
    private void SpawnEnemy()
    {
        float randomAngle = Random.Range(0f, 360f);
        
        Vector3 randomDirection = Quaternion.Euler(0, randomAngle, 0) * Vector3.forward;
        
        Transform randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
        
        Enemy enemy = Instantiate(_enemyPrefab, randomSpawnPoint.position, UnityEngine.Quaternion.LookRotation(randomDirection));
        
        enemy.Mover.SetDirection(randomDirection);
    }

    private IEnumerator SpawnEnemiesRoutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}