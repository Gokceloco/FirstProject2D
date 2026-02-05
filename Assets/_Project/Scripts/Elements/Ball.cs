using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;

    private Vector3 _direction;


    private void Start()
    {
        _direction = new Vector3(Random.Range(-.5f, .5f), 1, 0);
    }

    void Update()
    {
        transform.position += _direction * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _direction = Vector3.Reflect(_direction, collision.contacts[0].normal);        
    }
}
