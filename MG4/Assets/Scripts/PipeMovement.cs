using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D pipeRb;



    private void Start()
    {
        
    }
    void Update()
    {
       pipeRb.velocity = new Vector2 (-moveSpeed, pipeRb.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Delete")
        {
            Destroy(this);
        }
    }
}
