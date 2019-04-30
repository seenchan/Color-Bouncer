using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {

    public GameObject[] Ball;

    private float spawnTime;

    // Use this for initialization
    void Start () {
        spawnTime = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        spawnTime += Time.deltaTime;
        if (spawnTime >= GameManager.Instance.ballSpawnTime)
        {
            if(GameManager.Instance.layout == 1)
            {
                Instantiate(Ball[2]);
            }
            else if (GameManager.Instance.layout == 2)
            {
                Instantiate(Ball[Random.Range(0, 3)]);
            }
            else if (GameManager.Instance.layout >= 3)
            {
                Instantiate(Ball[Random.Range(0, Ball.Length)]);
            }
            spawnTime = 0;
        }
	}
}
