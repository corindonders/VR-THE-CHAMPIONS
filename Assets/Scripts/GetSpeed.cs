using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSpeed : MonoBehaviour {

    public Vector3 FrameVelocity { get; set; }
    public Vector3 PrevPosition { get; set; }
	public GameObject Wow;



	void Start () {
		Wow = GameObject.Find("Wow");
	}




	void Update()
    {
        // Keep an average velocity due to fixed update irregularity, else we will occassionally get 0 velocity
        float currFrameVelocity = (transform.position - PrevPosition).magnitude / Time.deltaTime;
        PrevPosition = transform.position;
		if (currFrameVelocity > 8 & currFrameVelocity < 30 ){
			Debug.Log("Awesome - This is your speed: " + currFrameVelocity );
			StartCoroutine("ShowWow");
		}
    }
		
	IEnumerator ShowWow ()
	{
		int changeFunction = UnityEngine.Random.Range (0,2);
		Wow.transform.GetChild(changeFunction).gameObject.SetActive(true);
		yield return new WaitForSeconds(1f);
		Wow.transform.GetChild(changeFunction).gameObject.SetActive(false);
	}




}

