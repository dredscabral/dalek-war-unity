﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.gameObject.isStatic && col.gameObject.tag != "Player" && col.gameObject.tag != "PowerUp" && col.gameObject.tag != "UndestroyableBlock")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Enemies") {
            PlayerStats.Kills +=1;
            Debug.Log("Just killed an enemy !!!");
        }
    }
}
