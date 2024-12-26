using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _path;

    private Transform[] _waypoints;
    private int _currentWaypoint;

    private void Awake()
    {
        _waypoints = new Transform[_path.childCount];

        for (int i = 0; i < _waypoints.Length; i++)
        {
            _waypoints[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);

        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
        }
    }
}