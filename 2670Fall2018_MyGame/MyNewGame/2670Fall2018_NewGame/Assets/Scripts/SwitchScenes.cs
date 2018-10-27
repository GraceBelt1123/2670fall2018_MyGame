using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchScenes : MonoBehaviour {

    public void changescene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
