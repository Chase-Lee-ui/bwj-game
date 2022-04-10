using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laundry_Collect : MonoBehaviour
{
    public int Laundry_Inside;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Laundry")
        {
            Laundry_Inside++;
            Destroy(col.gameObject);
        }
    }
}
