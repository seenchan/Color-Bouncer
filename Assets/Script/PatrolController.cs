using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolController : MonoBehaviour {

    public Transform[] patrol;
    private int Currentpoint;
    public float moveSpeed;
    public bool isPatrol = false;

    void Start()
    {
        if (isPatrol == true)
        {
            transform.position = patrol[0].position;
            Currentpoint = 0;
        }
    }
    void Update()
    {
        if (isPatrol == true)
        {
            if (transform.position == patrol[Currentpoint].position)
            {
                Currentpoint++;
            }

            if (Currentpoint >= patrol.Length)
            {
                Currentpoint = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, patrol[Currentpoint].position, moveSpeed * Time.deltaTime);
        }
    }
}
