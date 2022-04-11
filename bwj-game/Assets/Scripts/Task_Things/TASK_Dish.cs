using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Dish : Task_Progress
{
    public override void Update()
    {
        if(Progress >= 100)
        {
            if(Indicator) { Destroy(Indicator); }
            if(Interactables) { Destroy(Interactables); }
        }
    }
}
