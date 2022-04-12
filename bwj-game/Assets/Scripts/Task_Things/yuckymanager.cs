using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuckymanager : MonoBehaviour
{
    public int count;
    public GameObject interact;
    public Task_Progress Manage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 8) 
        {
            Manage.Progress = 100;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
