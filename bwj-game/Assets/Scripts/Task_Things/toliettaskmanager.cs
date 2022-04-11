using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toliettaskmanager : MonoBehaviour
{

    public GameObject plunger;
    public int total;
    public GameObject toilet;
    public float Progress_Total = 0;

    // Start is called before the first frame update
    void Start()
    {
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (total == 4) 
        {
            toilet.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == plunger) 
        {
            total++;
            Progress_Total += 25;
        }
    }
}
