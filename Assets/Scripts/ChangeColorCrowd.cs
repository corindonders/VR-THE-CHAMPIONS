using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCrowd : MonoBehaviour {

	[Header("Head 01")]
	public GameObject crowdHeadMember1;
	public GameObject crowdNoseMember1;
	public GameObject crowdEarsMember1;
	public GameObject crowdMustacheMember1;

	[Header("Head 02")]
	public GameObject crowdHeadMember2;
	public GameObject crowdNoseMember2;
	public GameObject crowdEarsMember2;
	public GameObject crowdAfroMember2;
	public GameObject crowdMustacheMember2;

	[Header("Head 03")]
	public GameObject crowdHeadMember3;
	public GameObject crowdNoseMember3;
	public GameObject crowdEarsMember3;
	public GameObject crowdHairMember3;

	[Header("Head 04")]
	public GameObject crowdHeadMember4;
	public GameObject crowdNoseMember4;
	public GameObject crowdEarsMember4;
	public GameObject crowdHairMember4;

	[Header("Head 05")]
	public GameObject crowdHeadMember5;
	public GameObject crowdNoseMember5;
	public GameObject crowdEarsMember5;
	public GameObject crowdHairMember5;

	[Header("Head 06")]
	public GameObject crowdHeadMember6;
	public GameObject crowdNoseMember6;
	public GameObject crowdEarsMember6;
	public GameObject crowdHairMember6;
	public GameObject crowdMustacheMember6;

	[Header("Head 07")]
	public GameObject crowdHeadMember7;
	public GameObject crowdNoseMember7;
	public GameObject crowdEarsMember7;
	public GameObject crowdHairMember7;

	[Header("Head 08")]
	public GameObject crowdHeadMember8;
	public GameObject crowdNoseMember8;
	public GameObject crowdEarsMember8;
	public GameObject crowdHairMember8;
	public GameObject crowdMustacheMember8;

	[Header("Body")]
	public GameObject crowdBody;
	public GameObject crowdShirt;
	public GameObject crowdNeck;
	public GameObject ArmL;
	public GameObject ArmR;

	public Material[] matsCrowd;
	public Material HairColor;
	public Material SkinColorCrowd;  
	public Material CrowdOutfitColor1;  

	// Use this for initialization
	void Start () {
		Invoke ("ChangeColors", 0.1f);
	}

	void ChangeColors () {

//		GameObject[] crowdHead = GameObject.FindGameObjectsWithTag("head_crowd");
//		GameObject[] crowdNose = GameObject.FindGameObjectsWithTag("nose_crowd");
//		GameObject[] crowdEars = GameObject.FindGameObjectsWithTag("ears_crowd");
//		GameObject[] crowdBody = GameObject.FindGameObjectsWithTag("body_crowd");
//		GameObject[] crowdShirt = GameObject.FindGameObjectsWithTag("shirt_crowd");
//		GameObject[] crowdNeck = GameObject.FindGameObjectsWithTag("neck_crowd");
//		GameObject[] ArmL = GameObject.FindGameObjectsWithTag("arml_crowd");
//		GameObject[] ArmR = GameObject.FindGameObjectsWithTag("armr_crowd");

		Object[] crowd_skin_materials = Resources.LoadAll("skins", typeof(Material));
		Object[] crowd_outfit_materials = Resources.LoadAll("outfit", typeof(Material));
		Object[] crowd_hair_materials = Resources.LoadAll("hair", typeof(Material));

		SkinColorCrowd = (Material)crowd_skin_materials[Random.Range(0, crowd_skin_materials.Length)]; 
		CrowdOutfitColor1 = (Material)crowd_outfit_materials [Random.Range (0, crowd_outfit_materials.Length)];
		HairColor = (Material)crowd_hair_materials[Random.Range(0, crowd_hair_materials.Length)];

		matsCrowd = ArmL.GetComponent<Renderer> ().materials;
		matsCrowd [0] = CrowdOutfitColor1;
		matsCrowd [1] = SkinColorCrowd;
		ArmL.GetComponent<Renderer> ().materials = matsCrowd;

		matsCrowd = ArmR.GetComponent<Renderer> ().materials;
		matsCrowd [0] = CrowdOutfitColor1;
		matsCrowd [1] = SkinColorCrowd;
		ArmR.GetComponent<Renderer> ().materials = matsCrowd;

		crowdBody.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNeck.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdShirt.GetComponent<Renderer> ().material = CrowdOutfitColor1;
			
		// Head 01
		crowdHeadMember1.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember1.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember1.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdMustacheMember1.GetComponent<Renderer> ().material = HairColor;

		// Head 02
		crowdHeadMember2.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember2.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember2.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdAfroMember2.GetComponent<Renderer> ().material = HairColor;
		crowdMustacheMember2.GetComponent<Renderer> ().material = HairColor;

		// Head 03
		crowdHeadMember3.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember3.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember3.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdHairMember3.GetComponent<Renderer> ().material = HairColor;

		// Head 04
		crowdHeadMember4.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember4.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember4.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdHairMember4.GetComponent<Renderer> ().material = HairColor;

		// Head 05
		crowdHeadMember5.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember5.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember5.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdHairMember5.GetComponent<Renderer> ().material = HairColor;

		// Head 06
		crowdHeadMember6.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember6.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember6.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdHairMember6.GetComponent<Renderer> ().material = HairColor;
		crowdMustacheMember6.GetComponent<Renderer> ().material = HairColor;

		// Head 07
		crowdHeadMember7.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember7.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember7.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdHairMember7.GetComponent<Renderer> ().material = HairColor;

		// Head 08
		crowdHeadMember8.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdNoseMember8.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdEarsMember8.GetComponent<Renderer> ().material = SkinColorCrowd;
		crowdHairMember8.GetComponent<Renderer> ().material = HairColor;
		crowdMustacheMember8.GetComponent<Renderer> ().material = HairColor;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
