using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Vector3 dumpPos;
    private Transform camTr;

    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    
    void Update()
    {
        camTr.position = GameManager.instance.player.position - dumpPos;
    }
}
