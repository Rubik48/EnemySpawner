using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _goal;
    [SerializeField] private float _spawnInterval = 2f;
    
    private void Start()
    {
        StartCoroutine(SpawnEnemiesRoutine());
    }
    
    private void SpawnEnemy()
    {
        Vector3 direction = (_goal.position - transform.position).normalized; ;
        
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, UnityEngine.Quaternion.LookRotation(direction));
        
        enemy.GetDirection(direction);
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