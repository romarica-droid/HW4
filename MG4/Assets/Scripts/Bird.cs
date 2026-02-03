using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float jumpSpeed;

    [SerializeField] private AudioSource explosion;
    [SerializeField] private AudioSource rupee;

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
            playSound(rupee);
            sendInfo();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            playSound(explosion);
            GameObject parent = collision.transform.parent.gameObject;
            Destroy(parent);
            end();
        }
    }

    private void playSound(AudioSource clip)
    {
        Instantiate(clip);
        clip.Play();
        Destroy(clip);
    }
}
