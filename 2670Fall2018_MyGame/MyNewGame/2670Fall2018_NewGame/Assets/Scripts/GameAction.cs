using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Actions/GameAction")]
public class GameAction : ScriptableObject
{
	public UnityAction<object> Raise;
	public UnityAction<Coroutine> RaiseCoroutine;
	public UnityAction RaiseNoArgs;
	
	
	public void RaiseAction()
	{
		RaiseNoArgs();
	}

	public void RaiseAction(object obj)
	{
		RaiseAction(obj);
	}

	public void RaiseAction(float obj)
	{
		RaiseAction(obj);
	}

	public void RaiseAction(Transform obj)
	{
		RaiseAction(obj);
	}

	public void RaiseAction(Coroutine obj)
	{
		RaiseCoroutine(obj);
	}
}
