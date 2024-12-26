//using UnityEngine;

//public class SpawnPoint : MonoBehaviour
//{
//    private Enemy _template;
//    private Target _target;

//    public void Spawn()
//    {
//        if (_target != null && _template != null)
//        {
//            Enemy enemy = Instantiate(_template, transform.position, Quaternion.identity);
//            enemy.SetTarget(_target);
//        }
//    }

//    public void SetTemplate(Enemy template) => _template = template;

//    public void SetTarget(Target target) => _target = target;
//}
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy template;
    [SerializeField] private Target target;

    public void Spawn()
    {
        if (target != null && template != null)
        {
            Enemy enemy = Instantiate(template, transform.position, Quaternion.identity);
            enemy.SetTarget(target);
        }
    }

    public void SetTemplate(Enemy newTemplate) => template = newTemplate;
    public void SetTarget(Target newTarget) => target = newTarget;
}