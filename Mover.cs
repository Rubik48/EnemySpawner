using UnityEngine;

public class Mover : MonoBehaviour  
{
    [SerializeField] private float _moveSpeed = 5f;
    
    private Vector3 _moveDirection;
    
    private void Update()
    {
        transform.position += _moveDirection * _moveSpeed * Time.deltaTime;
    }
    
    public void SetDirection(Vector3 direction)
    {
        _moveDirection = direction.normalized;
    }
}