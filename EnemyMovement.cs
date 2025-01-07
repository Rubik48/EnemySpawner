using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    
    private Vector3 _moveDirection;
    
    private void Update()
    {
        transform.position += _moveDirection * _moveSpeed * Time.deltaTime;
    }

    private void OnCollisionExit(Collision collision)
    {
        Platform platform = collision.gameObject.GetComponent<Platform>();

        if (platform != null)
        {
            Destroy(gameObject);
        }
    }
    
    public void SetDirection(Vector3 direction)
    {
        _moveDirection = direction.normalized;
    }
}