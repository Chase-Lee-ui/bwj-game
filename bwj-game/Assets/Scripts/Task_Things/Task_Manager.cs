using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Manager : MonoBehaviour
{
    public Task_Progress[] Task_Progresses;
    public float Difficulty_Augment;
    public GameObject Game_Over;
    public Timer timer;
    public bool CompletedAll = true;
    public bool Initiated = true;
    public GameObject Winner;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Manager");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        foreach(var tasks in Task_Progresses)
        {
            if (tasks.Progress != 100)
            {
                CompletedAll = false;
            }
            else if (tasks.Progress == 100) 
            {
                CompletedAll = true;
            }
        }
        if(timer.timeValue >= 0 && CompletedAll)
        {
            Winner.SetActive(true);
        }
        else if(timer.timeValue <= 0 && !CompletedAll)
        {
            Game_Over.SetActive(true);
        }

        if (!Initiated)
        {
            var comp = GameObject.FindObjectsOfType<Task_Progress>();
            Task_Progresses = comp;
            Winner.SetActive(false);
            Game_Over.SetActive(false);
            Initiated = true;
            CompletedAll = true;
        }
    }
}
