using UnityEngine;
using System.Collections;

public enum FacilityType
{
	None = 0,
	Bathroom = 1,
	Kitchen = 2,
	Dormatory = 3,
	GuardTower = 5,
	Perch = 6,
	Library = 7

}

public class Facility : MonoBehaviour {

	public FacilityType facilityType = FacilityType.None;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

}
