using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject bullet;
    public float speed = 30;

	// Use this for initialization
	void Start () {
        Debug.Log("--hello unity!");
       // GameObject.Instantiate(bullet,transform.position,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletMade = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rgd = bulletMade.GetComponent<Rigidbody>();
            rgd.velocity = transform.forward * speed;
            Debug.Log("--mouseBtnDown shoot bullet ");
        }

	}
}
