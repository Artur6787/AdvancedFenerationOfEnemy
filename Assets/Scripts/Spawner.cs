using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnTime;
    private SpawnPoint[] _points;
    private bool _isWorking = true;
    private int _minValue = 0;

    private void Awake()
    {
        _points = GetComponentsInChildren<SpawnPoint>();
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds time = new WaitForSeconds(spawnTime);

        while (_isWorking)
        {
            if (_points.Length > _minValue)
            {
                _points[Random.Range(_minValue, _points.Length)].Spawn();
            }

            yield return time;
        }
    }
}