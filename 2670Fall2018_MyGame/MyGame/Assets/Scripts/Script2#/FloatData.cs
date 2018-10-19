﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject {

   
        public float value;

        public virtual float Value
        {
            get { return value; }
        }
    }

