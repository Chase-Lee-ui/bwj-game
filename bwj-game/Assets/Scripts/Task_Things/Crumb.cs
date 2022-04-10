using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumb : MonoBehaviour
{
    public TASK_Vaccum Manager;
    void Awake()
    {
        Manager = FindObjectOfType<TASK_Vaccum>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Manager.Crumbs_Collected++;
            Destroy(this.gameObject);
        }
    }
}
