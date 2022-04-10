using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Laundry_Sort : Task_Progress
{
    public Laundry_Basket[] Laundry_Baskets;
    public GameObject Spawn_Point1, Spawn_Point2;
    public bool Spawned;
    public int Shirts;
    public GameObject Shirt;
    public int Pants;
    public GameObject Pant;
    // Start is called before the first frame update
    void Start()
    {
        NameOfTask = "Laundry Sort";
    }

    // Update is called once per frame
    public override void Update()
    {
        if(!Spawned)
        {
            for(int i = 0; i<Shirts; i++)
            {
                var img = Instantiate(Shirt) as GameObject;
                img.transform.SetParent(Spawn_Point1.transform, false);
            }
            for(int i = 0; i<Pants; i++)
            {
                var img = Instantiate(Pant) as GameObject;
                img.transform.SetParent(Spawn_Point2.transform, false);
            }
            Spawned = true;
        }

        int total = 0;
        for(int i = 0; i<Laundry_Baskets.Length; i++)
        {
            total += Laundry_Baskets[i].Amt_Inside;
        }

        Progress = total / (Shirts + Pants);
        if(Progress >= 100)
        {
            Indicator.SetActive(false);
        }
    }
}
