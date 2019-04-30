using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaLayoutManager : MonoBehaviour {

    public int layout1 = 7;
    public int layout2 = 20;
    public int layout3 = 40;
    public int layout4 = 70;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (GameManager.Instance.score < layout1)
        {
            GameManager.Instance.arenaLayout[1].SetActive(false);
            GameManager.Instance.arenaLayout[2].SetActive(false);
            GameManager.Instance.arenaLayout[3].SetActive(false);
        }
        else if (GameManager.Instance.score >= layout1 && GameManager.Instance.score < layout2)
        {
            GameManager.Instance.layout = 2;
            GameManager.Instance.arenaLayout[1].SetActive(true);
        }
        else if (GameManager.Instance.score >= layout2 && GameManager.Instance.score < layout3)
        {
            GameManager.Instance.layout = 3;
            GameManager.Instance.arenaLayout[2].SetActive(true);
        }
        else if (GameManager.Instance.score >= layout3)
        {
            GameManager.Instance.layout = 4;
            GameManager.Instance.arenaLayout[1].SetActive(false);
            GameManager.Instance.arenaLayout[2].SetActive(false);
            GameManager.Instance.arenaLayout[0].SetActive(false);
            GameManager.Instance.arenaLayout[3].SetActive(true);
        }
    }
}
