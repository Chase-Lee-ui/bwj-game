using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Wire : Task_Progress
{
    public WireTask Parent;
    public override void Update()
    {
        if(Parent)
        {
            if(Parent.IsTaskCompleted)
            {
                Progress = 100;
                Destroy(Interactables);
                Destroy(Indicator);
            }
        }
    }
}
