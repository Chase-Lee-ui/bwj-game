using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laundry_Basket : MonoBehaviour
{
    public string Laundry_Tag;
    public int Amt_Inside;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == Laundry_Tag)
        {
            Amt_Inside++;
            Destroy(col.gameObject);
        }
    }
}
