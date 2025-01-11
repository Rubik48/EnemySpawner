using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _pointA;
    [SerializeField] private Transform _pointB;
    [SerializeField] private float _speed = 3f;
    
    private Transform _currentTarget;
    
    private void Start()
    {
        _currentTarget = _pointB;
    }
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _currentTarget.position, _speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, _currentTarget.position) < 0.1f)
        {
            _currentTarget = _currentTarget == _pointA ? _pointB : _pointA;
        }
    }
}
