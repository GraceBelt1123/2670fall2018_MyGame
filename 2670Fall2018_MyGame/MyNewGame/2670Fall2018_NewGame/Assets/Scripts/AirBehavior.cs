using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR.WSA.WebCam;

public class AirBehaviour : MonoBehaviour
{

	public AiBase OnStart, OnEnter, OnExit;
	
	[HideInInSpector] 
	public AiBrain Brain;

	[HideInInSpector] 
	public AiPatrol Patrol;

	private Coroutine couroutine;
	private NavMeshAgent agent;

	private void Start()
	{
		Brain = ScriptableObject.CreateInstance<AiBrain>;
		Patrol = OnStart as AiPatrol;
		if (Patrol != null)
		{
			Patrol.SendCoroutine = ScriptableObject.CreateInstance<GameAction>();
			Patrol.SendCoroutine.RaiseNoArgs += CallCoroutine;	
		}

		agent = GetComponent<NavMeshAgent>();
		Brain.Base = OnStart;
		coroutine = StartCoroutine((Brain.Base.Nav(agent)));

		private void CallCoroutine()
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

		public void ChangeBase(AiBase ai)
		{
			Brain.Base = ai;
		}

		public void Restart()
		{
			StartCoroutine(OnRestart());
		}

		private IEnumerable OnRestart()
		{
			
		}
	}


}
