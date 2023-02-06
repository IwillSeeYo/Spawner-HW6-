using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private int _timeSpawn = 2;
    private bool _isSpawningEnemies = true;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_timeSpawn);
        int minSpawnPosition = 0;

        while (_isSpawningEnemies)
        {
            Enemy spawnedEnemy = Instantiate(_enemyPrefab, _spawnPoints[Random.Range(minSpawnPosition, _spawnPoints.Length)]);

            yield return waitForSeconds;
        }
    }
}