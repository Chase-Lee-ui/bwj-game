using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Toilet : Task_Progress
{
    public toliettaskmanager _manager;
    public AudioSource Flush;
    public override void Update()
    {
        Progress = _manager.Progress_Total;
        if(Progress >= 100)
        {
            Indicator.SetActive(false);
            if(Interactables) { Destroy(Interactables); Flush.Play(); }
        }
    }
}
