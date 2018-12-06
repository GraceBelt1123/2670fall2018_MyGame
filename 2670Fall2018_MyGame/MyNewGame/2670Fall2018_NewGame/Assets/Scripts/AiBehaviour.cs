using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR.WSA.WebCam;

/*public class AiBehaviour : MonoBehaviour
{

	//public Aibase OnStart, OnEnter, OnExit;]
		
	[HideInInspector] 
	//public AiBrain Brain;

	[HideInInspector] 
	public AiPatrol Patrol;
	private Coroutine coroutine;
	private NavMeshAgent agent;

	private void Start()
	{
		Brain = ScriptableObject.CreateInstance<AiBrain>();
		Patrol = OnStart as AiPatrol;
		if (Patrol != null)
		{
			Patrol.SendCoroutine = ScriptableObject.CreateInstance<GameAction>();
			Patrol.SendCoroutine.RaiseNoArgs += CallCoroutine;
		}

		agent = GetComponent<NavMeshAgent>();
		Brain.Base = OnStart;
		coroutine = StartCoroutine(Brain.Base.Nav(agent));
	}

	private void CallCoroutine;
	{
		OnCall(coroutine);
	}

	private void OnTriggerEnter(Collider other)
	{
		Brain.Base = OnEnter;
		OnCall(coroutine);
	}

	private void OnTriggerEnter(Collider other)
	{
		Brain.Base = OnExit;
		OnCall(coroutine);
	}

	private void OnCall(Coroutine c)
	{
		StopCoroutine(c);
		coroutine = StartCoroutine(Brain.Base.Nav(agent));
	}

	public void ChangeBase(Aibase ai)
	{
		Brain.Base = ai;
	}

	public void Restart()
	{
		StartCoroutine(OnRestart);
	}
	
	private IEnumberator OnStart()
	{
		
	}
}*/
