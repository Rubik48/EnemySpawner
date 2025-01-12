using UnityEngine;

public class Mover : MonoBehaviour  
{
    [SerializeField] private float _moveSpeed = 5f;
    
    private Vector3 _moveDirection;
    private Target _target;
    
    private void Update()
    {
        LookAtTarget(_target);
        
        MoveToTarget(_target);
    }

    public void MoveToTarget(Target target)
    {
        _moveDirection = (target.transform.position - transform.position).normalized;
        
        transform.position += _moveDirection * _moveSpeed * Time.deltaTime;
    }
    
    public void SetTarget(Target target)
    {
        _target = target;
    }
    
    private void LookAtTarget(Target target)
    {
        transform.LookAt(target.transform.position);
    }
}