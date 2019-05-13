using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySpeed : MonoBehaviour {

	void Start () {
		
	}
	
	//Dit zorgt er alleen voor dat de objecten naar beneden trekken. Helaas is er af en toe lag dat de timing verstoort
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, new Vector2(transform.position.x, -277.0f), 1);
    }
}
