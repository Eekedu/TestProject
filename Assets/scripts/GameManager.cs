using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    Text hi;
    Text healthtext;
    Text otherText;
    int health = 0;
    
	// Use this for initialization
	void Start () {
        healthtext = GameObject.FindGameObjectWithTag("healthtext").GetComponent<Text>();
        otherText = GameObject.FindGameObjectWithTag("blah").GetComponent<Text>();
        otherText.text = "HI THERE";
    }
	
	// Update is called once per frame
	void Update () {
        health++;
        healthtext.text = "Health: " + health;
	}
}
