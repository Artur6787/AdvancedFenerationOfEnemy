//using System.Collections;
//using UnityEngine;

//public class Spawner : MonoBehaviour
//{
//    [SerializeField] private Enemy[] _templates;
//    [SerializeField] private Target[] _targets;
//    [SerializeField] private float _spawnTime;

//    private SpawnPoint[] _points;
//    private int _minValue = 0;
//    private bool _isWork = true;

//    private void Awake()
//    {
//        _points = gameObject.GetComponentsInChildren<SpawnPoint>();

//        for (int i = 0; i < _targets.Length && i < _points.Length; i++)
//        {
//            _points[i].SetTemplate(_templates[i]);
//            _points[i].SetTarget(_targets[i]);
//        }
//    }

//    private void Start()
//    {
//        StartCoroutine(Spawn());
//    }

//    private IEnumerator Spawn()
//    {
//        WaitForSeconds time = new(_spawnTime);

//        while (_isWork)
//        {
//            _points[Random.Range(_minValue, _points.Length)].Spawn();

//            yield return time;
//        }
//    }
//}
using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnTime;
    private SpawnPoint[] points;
    private bool isWorking = true;
    private int minValue = 0;
    private void Awake()
    {
        points = GetComponentsInChildren<SpawnPoint>();
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds time = new WaitForSeconds(spawnTime);

        while (isWorking)
        {
            if (points.Length > minValue)
            {
                points[Random.Range(minValue, points.Length)].Spawn();
            }

            yield return time;
        }
    }
}