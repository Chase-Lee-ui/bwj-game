using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject Task;
    private GameObject Player;
    private bool Inside;
    public void Update()
    {
        if(Player && Inside)
        {
            if(Task) { Task.SetActive(true); }
            
        }
        else
        {
            if(Task) { Task.SetActive(false); }
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Inside = true;
            Player = col.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Inside = false;
            Player = null;
        }
    }
}
