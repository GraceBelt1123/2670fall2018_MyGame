using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Patrol, menuName = "Ai/Function/Patrol)]
public class AiPatrol : AiBase
{

	public UnityEvent NextPatrol;
	public UnityEvent EndPatrol;

	private int i = 0;

	[HideInInspector] 
	public GameAction SendCoroutine;
	public GameAction AddPointsToList;
	public GameAction AddPointList;
	public FloatData distance;
	public FloatData HoldTime;
	
	public List<Vector3Data>PatrolPoints { get; set; }

	private void OnEnable()
	{
		PatrolPoints.Clear();
		if(AddPointsToList) != null) AddPointsToList.Raise += AddPatrolPoints;
		if (AddPointList != null) AddPointList.Raise += AddPatrolPointList;
		i = 0;
		NextPatrol.AddListener(RestartPatrol);
	}

	private void AddPatrolPoints(object obj)
	{
		PatrolPoints.Add(obj as Vector3Data);
	}

	private void AddPatrolPointList(object obj)
	{
		PatrolPoints = obj as List<Vector3Data>;
	}
}
