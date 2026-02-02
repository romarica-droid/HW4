using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D pipeRb;
  
    void Update()
    {
       pipeRb.velocity = new Vector2 (-moveSpeed, pipeRb.velocity.y);
    }
}
