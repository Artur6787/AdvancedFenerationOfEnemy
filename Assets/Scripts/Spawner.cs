using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy[] _templates;
    [SerializeField] private Target[] _targets;
    [SerializeField] private float _spawnTime;

    private SpawnPoint[] _points;

    private void Awake()
    {
        _points = gameObject.GetComponentsInChildren<SpawnPoint>();

        for (int i = 0; i < _targets.Length && i < _points.Length; i++)
        {
            _points[i].SetTemplate(_templates[i]);
            _points[i].SetTarget(_targets[i]);
        }
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds time = new(_spawnTime);

        while (true)
        {
            _points[Random.Range(0, _points.Length)].Spawn();

            yield return time;
        }
    }
}