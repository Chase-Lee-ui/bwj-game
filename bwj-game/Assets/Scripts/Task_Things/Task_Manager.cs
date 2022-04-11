using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Manager : MonoBehaviour
{
    public Task_Progress[] Task_Progresses;
    public GameObject Game_Over;
    public float Timer = 60.0f;
    public bool CompletedAll = true;
    public GameObject Winner;
    void Update()
    {
        Timer -= Time.deltaTime;
        foreach(var tasks in Task_Progresses)
        {
            if(Timer<= 0)
            {
                if(tasks.Progress <= 0)
                {
                    CompletedAll = false;
                    Game_Over.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }

        if(Timer <= 0 && CompletedAll)
        {
            Winner.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
