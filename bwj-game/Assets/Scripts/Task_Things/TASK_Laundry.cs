using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Laundry : Task_Progress
{
    public Laundry_Collect Collector;
    public Laundry_Collect Dryer;
    public Laundry_Collect Hamper;
    private int LaundryIN = 0;
    public int AmtOfLaundry = 3;
    public GameObject Laundry;
    public GameObject Canvas;
    public bool Spawned = false, Spawned2 = false, Spawned3 = false;
    [Range(0, 30.0f)]
    public float Timer;
    public bool Phase1 = true, Phase2 = false, Phase3 = false;
    // Start is called before the first frame update
    void Start()
    {
        NameOfTask = "Laundry";
        AmtOfLaundry = Mathf.CeilToInt(Difficulty * AmtOfLaundry);
    }

    public override void Update()
    {
        Timer -= Time.deltaTime;
        if(Phase1)
        {
            
            if(!Spawned)
            {
                for(int i = 0; i<AmtOfLaundry; i++)
                {
                    var img = Instantiate(Laundry) as GameObject;
                    img.transform.SetParent(Canvas.transform, false);
                }
                Spawned = true;
            }
            LaundryIN = Collector.Laundry_Inside;
            Progress = LaundryIN / AmtOfLaundry;
            if(LaundryIN == AmtOfLaundry)
            {
                Destroy(Collector.gameObject);
                Phase1 = false;
                Progress = 100;
                Timer = 15.0f;
            }
        }
        else
        {
            if(Timer<=0)
            {
                if(!Phase1) { Phase2 = true; Dryer.gameObject.SetActive(true); }
            }
        }

        if(Phase2)
        {
            if(!Spawned2)
            {
                for(int i = 0; i<AmtOfLaundry; i++)
                {
                    var img = Instantiate(Laundry) as GameObject;
                    img.transform.SetParent(Canvas.transform, false);
                }
                Spawned2 = true;
            }
            LaundryIN = Dryer.Laundry_Inside;
            Progress = LaundryIN / AmtOfLaundry;
            if(LaundryIN == AmtOfLaundry)
            {
                Destroy(Dryer.gameObject);
                Phase2 = false;
                Progress = 100;
                Timer = 15.0f;
            }
        }
        else
        {
            if(Timer<=0)
            {
                if(!Phase2 && !Phase1) { Phase3 = true; Hamper.gameObject.SetActive(true); }
            }
        }

        if(Phase3)
        {
            if(!Spawned3)
            {
                for(int i = 0; i<AmtOfLaundry; i++)
                {
                    var img = Instantiate(Laundry) as GameObject;
                    img.transform.SetParent(Canvas.transform, false);
                }
                Spawned3 = true;
            }
            LaundryIN = Dryer.Laundry_Inside;
            Progress = LaundryIN / AmtOfLaundry;
            if(LaundryIN == AmtOfLaundry)
            {
                Phase3 = false;
                Indicator.SetActive(false);
                Progress = 100;
            }
        }

        if(Progress >= 100)
        {
            Indicator.SetActive(false);
        }
        else
        {
            Indicator.SetActive(true);
        }
    }
}
