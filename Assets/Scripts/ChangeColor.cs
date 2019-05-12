using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	private GameObject Head;
	private GameObject Nose;
	private GameObject Ears;
	private GameObject Body;
	private GameObject Headband;
	private GameObject Hair;
	public Material[] mats;  
	public Material SkinColor;
	public Material HairColor;
	public Material OutfitColor1;  
	public Material OutfitColor2;  

	// Use this for initialization
	void Start () {
		Invoke ("ChangeColors", 0.1f);

	}

	void ChangeColors () {
		Head = GameObject.FindGameObjectWithTag("head_dancer");
		Nose = GameObject.FindGameObjectWithTag("nose_dancer");
		Ears = GameObject.FindGameObjectWithTag("ears_dancer");
		Body = GameObject.FindGameObjectWithTag("body_dancer");
		Headband = GameObject.FindGameObjectWithTag("headband_dancer");
		GameObject[] Hair = GameObject.FindGameObjectsWithTag("hair_dancer");

		Object[] hair_materials = Resources.LoadAll("hair", typeof(Material));
		Object[] skin_materials = Resources.LoadAll("skins", typeof(Material));
		Object[] outfit_materials = Resources.LoadAll("outfit", typeof(Material));

		SkinColor = (Material)skin_materials[Random.Range(0, skin_materials.Length)];
		HairColor = (Material)hair_materials[Random.Range(0, hair_materials.Length)];
		OutfitColor1 = (Material)outfit_materials[Random.Range(0, outfit_materials.Length)]; 
		OutfitColor2 = (Material)outfit_materials[Random.Range(0, outfit_materials.Length)]; 

		mats = Body.GetComponent<Renderer>().materials;
		mats[0] = OutfitColor1;
		mats[1] = OutfitColor2;
		mats[3] = SkinColor;

		Body.GetComponent<Renderer>().materials = mats;
		Head.GetComponent<Renderer> ().material = SkinColor;
		Nose.GetComponent<Renderer> ().material = SkinColor;
		Ears.GetComponent<Renderer> ().material = SkinColor;

		foreach (GameObject kapsel in Hair) {
			kapsel.GetComponent<Renderer> ().material = HairColor;
		}


		Headband.GetComponent<Renderer> ().material = OutfitColor2;
	}

	// Update is called once per frame
	void Update () {
	}
}
