using System.Collections;
using System.Collections.Generic;
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
		Raise(obj);
	}

	public void RaiseAction(float obj)
	{
		Raise(obj);
	}

	public void RaiseAction(Transform obj)
	{
		Raise(obj);
	}

	public void RaiseAction(Coroutine obj)
	{
		RaiseCoroutine(obj);
	}
}
