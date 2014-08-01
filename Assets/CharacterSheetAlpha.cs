using UnityEngine;
using System.Collections;
using System.Collections.Generic;

#region Enums
public enum TaskType
{
	None = 0,
	Idle = 1,
	StudyPhysics = 2,
	MaintainFacility = 3,
	Sleep = 4,
	Eat = 5,
	GoToBathroom = 6,
	Shower = 7

}
//[System.Serializable]
//public enum GoalType
//{
//	None = 0,
//	HaveSexWith = 1,
//	TakeALife = 2,
//	MakeLoveTo = 3
//}
//
//[System.Serializable]
//public enum InformationDisposition
//{
//	None = 0,
//	GiveTrueInformation = 1,
//	GiveFalseInformation = 2,
//	AvoidConversation = 3
//}
//
//[System.Serializable]
//public enum InterestType
//{
//	Love = 0,
//	Women = 1,
//	Cynicism = 2,
//	Power = 3
//}
#endregion

#region Classes

[System.Serializable]
public class Task
{
	public TaskType taskType;
	public Facility facility;
	public float duration;

	public Task (TaskType _taskType)
	{
		taskType = _taskType;
		facility = null;
		duration = 0F;
	}
}

//public class Demeanor
//{
//	public InformationDisposition informationDisposition = InformationDisposition.None; //Receptive, Feign Cooperation, Guarded
//	public bool shareSight; //Whether this character will grant access to own perspective; may not be reciprocated
//
//	//On contact
//	//Attack on sight
//	//Retreat on sight
//	//Communicate
//	//-Exchange information
//	//-Threaten
//	//-Compliment
//	//
//}
//
//[System.Serializable]
//public class Goal
//{
//	public GoalType goalType = GoalType.None;
//	public List<int> targetObjects = new List<int>();
//	public int numberOfTimes = -1;
//}
//
//
//[System.Serializable]
//public class InterestInfo
//{
//	public InterestType interestType;
//	public List<Goal> relatedGoals;
//}
#endregion


public class CharacterSheetAlpha : MonoBehaviour {

	//Identification
	//public int objectId = -1;
	public int characterId = -1;
	public string characterName = "";

	//Skills
	public float arcology;
	public float marksmanship;
	public float melee;
	public float medicine;
	public float physics;

	//Status
	public float energy;
	public Task activeTask = new Task(TaskType.Idle);
	public List<Task> taskQueue = new List<Task>();
	public float taskStartTime;

	//Player chosen behaviors

//	public Demeanor generalDemeanor = new Demeanor(); //Default 
//	public Dictionary<int, Demeanor> specificDemanors = new Dictionary<int, Demeanor>(); //Other's character id: this character's demeanor towards other
//
//	//Mental assets
//	public List<InterestType> interests;
//	public List<Goal> goals;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {



		if(Time.timeScale > 0F)
		{
			if(activeTask.taskType == TaskType.Idle)
			{
				SetNextTask();
			} else if(Time.fixedTime - taskStartTime >= activeTask.duration)
			{
				SetNextTask();
			//} else {

			}
		}

		switch(activeTask.taskType)
		{
		case TaskType.StudyPhysics:
			physics = Mathf.Round ((Time.fixedDeltaTime + physics)*100F)/100F;
			
			Debug.Log ("Physics incremented by" + Time.fixedDeltaTime + "at "+Time.fixedTime);
			break;
		case TaskType.Sleep:
			energy = Mathf.Round ((Time.fixedDeltaTime + energy)*100F)/100F;
			Debug.Log ("Energy incremented by" + Time.fixedDeltaTime + "at "+Time.fixedTime);
			break;
		case TaskType.Idle:
			//Do nothing
			break;
		}
	}

	void SetNextTask()
	{
		if(taskQueue.Count > 0)
		{
		activeTask = taskQueue[0];
		taskQueue.RemoveAt(0);
		taskStartTime = Time.fixedTime;
			Debug.Log (activeTask.taskType.ToString() + " started at "+Time.fixedTime);
		} else {
			activeTask = new Task(TaskType.Idle);
		}
	}
}
