using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public LayerMask hitLayers;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        ControlType1();
    }

    void ControlType1()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        this.transform.position = Vector3.MoveTowards(transform.position, castPoint.GetPoint(15.710f), GameManager.Instance.playerSpeed * Time.deltaTime);
    }
    void ControlType2()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        this.transform.Translate(new Vector3(10,10,0));
    }

}
