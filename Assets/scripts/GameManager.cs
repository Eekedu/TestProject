using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    Text hi;
    Text healthtext;
    int health = 0;
    
	// Use this for initialization
	void Start () {
        healthtext = GameObject.FindGameObjectWithTag("healthtext").GetComponent<Text>();
        fHealthNextThink = Time.fixedTime + 1.0f;
    }

    float fHealthNextThink;
	// Update is called once per frame
	void Update () {
        if (Time.fixedTime >= fHealthNextThink)
        {
            health+=10;
            fHealthNextThink = Time.fixedTime + 1.0f;
            Debug.Log("Thinked");
        }
        healthtext.text = "Health: " + health;
	}
}
