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
