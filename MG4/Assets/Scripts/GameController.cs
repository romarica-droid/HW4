using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private GameObject colliderPrefab;

    private bool canSpawn;

    private float actionTime;

    void Start()
    {
        actionTime = 1.0f;
        canSpawn = true;
        Locater.Instance.player.endGame += stopGame;
}

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= actionTime)
        {
            if (canSpawn)
            {
                SpawnPipe(pipePrefab);
            }
            actionTime += 2.0f;
        }
    }
    
    private void SpawnPipe(GameObject sprite)
    {
        GameObject newThing = Instantiate(sprite) as GameObject;
        placeThing(newThing);
    }

    private void placeThing(GameObject sprite)
    {
        float tempY = Random.Range(5f, -3f);
        sprite.gameObject.transform.position = new Vector2(3f, tempY);
    }

    private void stopGame()
    {
        canSpawn = false;
        Debug.Log("Stop the game");
    }
}
