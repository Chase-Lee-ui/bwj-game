using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeyucky : MonoBehaviour
{
    public GameObject towel;
    public yuckymanager yuckymanager;
    private Task_Progress task;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == towel) 
        {
            yuckymanager.count++;
            task.Progress += 12.5f;
            gameObject.SetActive(false);
        }
    }
}
