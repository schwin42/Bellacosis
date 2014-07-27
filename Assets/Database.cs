using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum ActionType
{
	None,
	Attack,
	Train,
	FlirtWith,
	AskAbout,
	BreakUpWith,
	InviteToGoal,

}

public class ActionInfo
{
	public ActionType actionType;
	public List<int> targetObjects;
}

public class Database : MonoBehaviour {

	public Dictionary<InterestType, InterestInfo> interestReference;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
