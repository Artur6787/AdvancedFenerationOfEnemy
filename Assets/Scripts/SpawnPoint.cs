using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Enemy _template;
    private Target _target;

    public void Spawn()
    {
        if (_target != null && _template != null)
        {
            Enemy enemy = Instantiate(_template, transform.position, Quaternion.identity);
            enemy.SetTarget(_target);
        }
    }

    public void SetTemplate(Enemy template) => _template = template;

    public void SetTarget(Target target) => _target = target;
}