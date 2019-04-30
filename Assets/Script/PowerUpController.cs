using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour {

    public float powerupTime = 10;
    public GameObject powerup;

    public GameObject[] playerShape;
    public GameObject safeRail;

    private float timer = 0;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        PowerupSpawn();
		if(GameManager.Instance.getPowerup == true)
        {
            if (GameManager.Instance.randomPowerup < 1)
            {
                GameManager.Instance.powerupName = "Shape Shift";
                ShapeChange();
                StartTimer();
            }
            else if (GameManager.Instance.randomPowerup >= 1 && GameManager.Instance.randomPowerup < 2)
            {
                GameManager.Instance.powerupName = "Slow Time";
                Time.timeScale = 0.5f;
                StartTimer();
            }
            else if (GameManager.Instance.randomPowerup >= 2)
            {
                GameManager.Instance.powerupName = "Safety Rail";
                safeRail.SetActive(true);
                StartTimer();
            }
        }
        if (timer <=0)
        {
            ShapeRevert();
            Time.timeScale = 1;
            safeRail.SetActive(false);
            timer = powerupTime;
            GameManager.Instance.getPowerup = false;
            GameManager.Instance.powerupName = "";
            GameManager.Instance.powerupTimer = "";
        }
	}

    void PowerupSpawn()
    {
        GameManager.Instance.timePlaying += Time.deltaTime;
        if (GameManager.Instance.timePlaying > GameManager.Instance.powerupSpawnTime)
        {
            Instantiate(powerup);
            GameManager.Instance.timePlaying = 0;
        }
    }

    void StartTimer()
    {
        timer -= Time.deltaTime;
        GameManager.Instance.powerupTimer = timer.ToString();
    }

    void ShapeChange()
    {
        playerShape[0].SetActive(false);
        playerShape[1].SetActive(true);
    }

    void ShapeRevert()
    {
        playerShape[0].SetActive(true);
        playerShape[1].SetActive(false);
    }
}
