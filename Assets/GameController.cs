using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static GameController Instance;

	public float timeMultiplier = 0F;
	public float elapsedWorldTime = 0F;
	//public float elapsedWorldTime = 0.00F;
	//public float timeConstant = 0.001F;
	//public float worldSpeed = 0F;
	//public float deltaWorldTime;

	private List<CharacterSheetAlpha> activeCharacters;

	void Awake()
	{
		Instance = this;
		Time.timeScale = timeMultiplier;
	}

	// Use this for initialization
	void Start () {
		activeCharacters = new List<CharacterSheetAlpha>(GameObject.Find ("CharacterContainer").GetComponentsInChildren<CharacterSheetAlpha>());
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Time.timeScale = timeMultiplier;
		elapsedWorldTime = Time.fixedTime;
	
		//elapsedWorldTime += timeConstant * worldSpeed;

//		foreach(CharacterSheetAlpha character in activeCharacters)
//		{
//
//		}

	}

	void LateUpdate()
	{
	}
}
