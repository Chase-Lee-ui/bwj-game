using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Laundry : Task_Progress
{
    public Laundry_Collect Collector;
    private int LaundryIN = 0;
    public int AmtOfLaundry = 3;
    public GameObject Laundry;
    public GameObject Canvas;
    public bool Spawned;
    // Start is called before the first frame update
    void Start()
    {
        NameOfTask = "Laundry";
    }

    public override void Update()
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
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Laundry")
        {
            LaundryIN++;
        }
    }
}
