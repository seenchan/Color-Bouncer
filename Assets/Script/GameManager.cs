using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>{

    protected override void Init()
    {

    }

    public int score = 0;
    public float playerSpeed = 20f;
    public int health = 5;
    public bool isGameOver = false;
    public GameObject gameOvercanvas;
    public int layout = 1;
    public float ballSpawnTime = 2f;
    public int combo = 0;
    public bool getPowerup = false;
    public float randomPowerup;
    public string powerupTimer;
    public string powerupName;
    public float powerupSpawnTime = 60f;
    public float timePlaying = 0;

    public GameObject[] arenaLayout;

    //[System.NonSerialized] public float speedMultiplier;

    void FixedUpdate()
    {
        if (health <= 0)
        {
            Debug.Log("gameover");
            isGameOver = true;
        }
        if (gameOvercanvas.activeSelf == true && isGameOver == false)
        {
            gameOvercanvas.SetActive(false);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
        score = 0;
        playerSpeed = 20f;
        isGameOver = false;
        health = 5;
        gameOvercanvas.SetActive(false);
    }
}
