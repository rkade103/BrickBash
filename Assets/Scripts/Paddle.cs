using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    //Configuration parameters 
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;      //Limit to the left in units
    [SerializeField] float maxX = 15f;    //Limit to the right in units

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Debug.Log(mousePos);
        Vector2 paddlePos = new Vector2(mousePos, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePos, minX, maxX);
        transform.position = paddlePos;
	}
}
