using UnityEngine;
using System.Collections;
using System.Collections.Generic;

#region Enums
[System.Serializable]
public enum GoalType
{
	None,
	HaveSexWith,
	Kill,
	MakeLoveTo
}

[System.Serializable]
public enum InformationDisposition
{
	None,
	GiveTrueInformation,
	GiveFalseInformation,
	AvoidConversation
}

[System.Serializable]
public enum InterestType
{
	Love,
	Women,
	Cynicism,

}
#endregion

#region Classes
public class Demeanor
{
	public InformationDisposition informationDisposition = InformationDisposition.None; //Receptive, Feign Cooperation, Guarded
	public bool shareSight; //Whether this character will grant access to own perspective; may not be reciprocated

	//On contact
	//Attack on sight
	//Retreat on sight
	//Communicate
	//-Exchange information
	//-Threaten
	//-Compliment
	//
}

[System.Serializable]
public class Goal
{
	public GoalType goalType = GoalType.None;
	public List<int> targetObjects = new List<int>();
	public int numberOfTimes = -1;
}


[System.Serializable]
public class InterestInfo
{
	public InterestType interestType;
	public List<Goal> relatedGoals;
}
#endregion


public class CharacterSheet : MonoBehaviour {

	//Identification
	public int objectId = -1;
	public string characterName = "";

	//Player chosen behaviors
	public List<ActionInfo> actionQueue = new List<ActionInfo>();
	public Demeanor generalDemeanor = new Demeanor(); //Default 
	public Dictionary<int, Demeanor> specificDemanors = new Dictionary<int, Demeanor>(); //Other's character id: this character's demeanor towards other

	//Mental assets
	public List<InterestType> interests;
	public List<Goal> goals;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
