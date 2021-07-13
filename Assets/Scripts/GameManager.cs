using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public Transform player;


    void init()
    {
        player = PlayerController.instance.transform;
    }

    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
