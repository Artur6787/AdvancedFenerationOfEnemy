using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;

    public void Spawn()
    {
        if (_target != null && _enemy != null)
        {
            Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            enemy.SetTarget(_target);
        }
    }

    public void SetTemplate(Enemy newEnemy)
    {
        _enemy = newEnemy;
    }
    public void SetTarget(Target newTarget)
    {
        _target = newTarget;
    }
}