using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    private Mover _mover;
    private Target _target;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _target.gameObject)
        {
            Destroy(gameObject);
        }
    }

    public void GetTarget(Target target)
    {
        _target = target;
        
        _mover.SetTarget(target);
    }
}