using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
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

    /*
     * ���콺 Ŭ���� �������� ĳ���� �̵� ī�޶�� ���ͺ�
     * 
     */

    public float speed = 10.0f;

    private NavMeshAgent agent;
    private Camera mainCam;
    private RaycastHit hit;

    public Ray mousePosition
    {
        get
        {
            return mainCam.ScreenPointToRay(Input.mousePosition);
        }
    }

    void initVariable()
    {
        agent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
        agent.speed = speed;
    }

    void Start()
    {
        initVariable();
    }


    
    void Update()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButton(1))
        {
            MovePosition();
        }

        MoveFunction();

    }


    void MovePosition()
    {
        if (Physics.Raycast(mousePosition, out hit))
        {
            Transform objectHit = hit.transform;

            agent.destination = hit.point;
        }
    }

    void MoveFunction()
    {

    }
    
}
