using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDetector : MonoBehaviour {

    public GameObject character;
    private Animator animator;
    private float timer = 0;
    private bool animStart = false;

    // Use this for initialization
    void Start () {
        animator = character.gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (animStart == true)
        {
            timer += Time.deltaTime;
            if (timer > 0.2f)
            {
                animator.SetBool("Bounce", false);
                timer = 0;
                animStart = false;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Powerup")
        {
            GameManager.Instance.getPowerup = true;
            float randomPowerup;
            randomPowerup = Random.Range(0, 3);
            GameManager.Instance.randomPowerup = randomPowerup;
            Destroy(col.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Red" || col.gameObject.tag == "Green" || col.gameObject.tag == "Blue")
        {
            animStart = true;
            animator.SetBool("Bounce", true);
        }

    }
}
