using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TASK_Vaccum : Task_Progress
{
    public bool Spawned;
    public int Spawn_Crumbs;
    public float Num_Of_Crumbs;
    public float Crumbs_Collected;
    public GameObject[] Crumbs;
    public Vector2 Max_Bounds;
    public Vector2 Min_Bounds;
    // Start is called before the first frame update
    void Start()
    {
        NameOfTask = "Vaccum";
    }

    // Update is called once per frame
    public override void Update()
    {
        if(!Spawned)
        {
            for(int i = 0; i<Spawn_Crumbs; i++)
            {
                Vector2 randLoc = new Vector2(Random.Range(Min_Bounds.x, Max_Bounds.x), Random.Range(Min_Bounds.y, Max_Bounds.y));
                var obj = Instantiate(Crumbs[Random.Range(0, Crumbs.Length)], randLoc, Quaternion.identity);
                obj.GetComponent<Crumb>().Manager = this.gameObject.GetComponent<TASK_Vaccum>();
                obj.transform.parent = this.gameObject.transform;
            }
            Spawned = true;
        }

        var crumbs = GameObject.FindGameObjectsWithTag("Crumb");
        Num_Of_Crumbs = crumbs.Length;
        float total = Crumbs_Collected+Num_Of_Crumbs;
        if(total >= 0)
        {
            this.Progress = (Crumbs_Collected / total)*100.0f;
        }
    }
}
