using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float jumpSpeed;

    public delegate void BirdListen();
    public event BirdListen addPoint;
    public event BirdListen endGame;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpSpeed);
        }
    }

    private void sendInfo()
    {
        addPoint?.Invoke();
    }

    private void end()
    {
        endGame?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            sendInfo();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("hit");

            end();
        }
    }

}
