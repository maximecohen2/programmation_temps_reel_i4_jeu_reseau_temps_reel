using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D _rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "RacketRight")
        {
            float y = HitFactor(transform.position, other.transform.position, other.collider.bounds.size.y);
            _rigidbody.velocity = new Vector2(-1, y).normalized * speed;
        }
        
        if (other.gameObject.name == "RacketLeft")
        {
            float y = HitFactor(transform.position, other.transform.position, other.collider.bounds.size.y);
            _rigidbody.velocity = new Vector2(1, y).normalized * speed;
        }
    }
}
