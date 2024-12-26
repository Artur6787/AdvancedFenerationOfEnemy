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
