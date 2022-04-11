using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking_Progress : MonoBehaviour
{
    public bool cooking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        cooking = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        cooking = false;
    }
}
