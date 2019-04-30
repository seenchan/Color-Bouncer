using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text healthText;
    public Text scoreFinalText;
    public Text comboText;
    public Text powerupTimer;
    public Text powerupText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        ChangeTheText();
    }

    void ChangeTheText()
    {
        scoreText.text = GameManager.Instance.score.ToString();
        healthText.text = GameManager.Instance.health.ToString();
        scoreFinalText.text = GameManager.Instance.score.ToString();
        powerupText.text = GameManager.Instance.powerupName;
        powerupTimer.text = GameManager.Instance.powerupTimer;
        if (GameManager.Instance.combo == 0)
        {
            comboText.text = "";
        }
        else
        {
            comboText.text = GameManager.Instance.combo.ToString() + "x";
        }
    }
}
