using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBall : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == this.tag)
        {
            Destroy(this.gameObject);
            GameManager.Instance.combo++;
            GameManager.Instance.score+= GameManager.Instance.combo;
            if (GameManager.Instance.combo >= 10)
            {
                GameManager.Instance.health++;
            }
        }
        else if (obj.tag != this.tag)
        {
            Destroy(this.gameObject);
            GameManager.Instance.health--;
            GameManager.Instance.combo = 0;
        }
    }
}
