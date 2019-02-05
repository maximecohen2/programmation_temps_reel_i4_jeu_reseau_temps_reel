using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketLocalController : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    public float speed = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        
        HandleMovement(vertical);
    }

    private void HandleMovement(float vertical)
    {
        _rb2D.velocity = new Vector2(_rb2D.velocity.x, vertical * speed);
    }

}
