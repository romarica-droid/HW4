using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;

public class Locater : MonoBehaviour
{
    public static Locater Instance { get; private set; }
    public Bird player { get; private set; }

    public void Awake()
    {
       if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        player = playerObj.GetComponent<Bird>();
    }
}
