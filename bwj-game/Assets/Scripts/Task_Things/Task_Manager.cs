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
    public bool Done = false;
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
        bool complete = true;
        foreach(var tasks in Task_Progresses)
        {
            if (tasks.Progress < 100)
            {
                complete = false;
            }
        }

        if(timer.timeValue >= 0 && complete && !Done)
        {
            Winner.SetActive(true);
        }
        else if(timer.timeValue <= 0 && !complete && !Done)
        {
            Game_Over.SetActive(true);
        }

        if (!Initiated)
        {
            var comp = GameObject.FindObjectsOfType<Task_Progress>();
            Task_Progresses = comp;
            timer.timeValue = 120.0f;
            Winner.SetActive(false);
            Game_Over.SetActive(false);
            Initiated = true;
            CompletedAll = true;
        }
    }
}
