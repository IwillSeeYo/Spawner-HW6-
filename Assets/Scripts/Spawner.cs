using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    const int SpawnTime = 2;
    const int TimeReset = 0;

    private int _timeSpawn = SpawnTime;
    private float _timer= TimeReset;

    void Update()
    {
        int minSpawnPosition = 0;
        _timer += Time.deltaTime;

        if(_timer >= _timeSpawn)
        {
            _timer = TimeReset;

            Instantiate(_enemyPrefab, _spawnPoints[Random.Range(minSpawnPosition, _spawnPoints.Length)]);
        }
    }
}
