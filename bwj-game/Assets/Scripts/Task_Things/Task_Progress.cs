using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Progress : MonoBehaviour
{
    public string NameOfTask;
    public GameObject Indicator;
    public float Difficulty = 1;
    public float Progress = 0;
    public float Rate_Of_Decay = 0.5f;
    public bool Decay_Enabled;
    public GameObject Interactables;

    public virtual void Update()
    {
        if(Progress >= 0 && Decay_Enabled)
        {
            Progress -= Rate_Of_Decay * Time.deltaTime;
        }
    }
}
