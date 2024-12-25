using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Enemy _template;
    private GameObject _target;

    public void Spawn()
    {
        if (_target != null && _template != null)
        {
            Enemy enemy = Instantiate(_template, transform.position, Quaternion.identity);
            enemy.SetTarget(_target);
        }
    }

    public void SetTemplate(Enemy template) => _template = template;

    public void SetTarget(GameObject target) => _target = target;
}
