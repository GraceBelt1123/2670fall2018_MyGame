using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour {

    public NameID ID;
    public UnityEvent OnMatch;

    private void Invoke (NameID id)
    {
        if (id == ID)
        {
            OnMatch.Invoke();
        }
    }
}
