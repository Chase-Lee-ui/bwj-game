using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Manager : MonoBehaviour
{
    public Task_Progress[] Task_Progresses;
    public float Difficulty_Augment;
    public GameObject Game_Over;
    public float Timer = 60.0f;
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
        Timer -= Time.deltaTime;
        foreach(var tasks in Task_Progresses)
        {
            tasks.Difficulty = Difficulty_Augment;
            if(Timer<= 0)
            {
                if(tasks.Progress <= 0)
                {
                    CompletedAll = false;
                    Game_Over.SetActive(true);
                }
            }
        }

        if(Timer <= 0 && CompletedAll)
        {
            Winner.SetActive(true);
        }

        if(!Initiated)
        {
            var comp = GameObject.FindObjectsOfType<Task_Progress>();
            Task_Progresses = comp;
            Timer = 120;
            Winner.SetActive(false);
            Game_Over.SetActive(false);
            Initiated = true;
            CompletedAll = true;
        }
    }
}
