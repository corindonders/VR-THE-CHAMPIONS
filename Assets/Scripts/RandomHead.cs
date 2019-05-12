using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHead : MonoBehaviour {



	// Use this for initialization
	void Start () {
		int changeFunction = UnityEngine.Random.Range (0,7);
		gameObject.transform.GetChild(changeFunction).gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
