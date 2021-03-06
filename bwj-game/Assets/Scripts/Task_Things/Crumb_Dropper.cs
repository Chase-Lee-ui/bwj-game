using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumb_Dropper : MonoBehaviour
{
    public GameObject[] Crumbs;
    public float Time_Between_Crumbs;
    public int Max_Crumbs;
    private int Current_Crumbs;
    private Vector2 Destination;
    public Vector2 Max_Bound;
    public Vector2 Min_Bound;

    void Start()
    {
        StartCoroutine(Dropper());
        Destination = new Vector2(Random.Range(Min_Bound.x, Max_Bound.x), Random.Range(Min_Bound.y, Max_Bound.y));
        StartCoroutine(Move_To_Point());
    }

    void Update()
    {
        Vector3 diff = Destination - new Vector2(transform.position.x, transform.position.y);
        diff.Normalize();
 
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 180);
        transform.position = Vector2.Lerp(transform.position, Destination, Time.deltaTime * 0.5f);
    }

    IEnumerator Dropper()
    {
        yield return new WaitForSeconds(Time_Between_Crumbs);
        Instantiate(Crumbs[Random.Range(0, Crumbs.Length)], this.gameObject.transform.position, Quaternion.identity);
        Current_Crumbs++;
        if(Current_Crumbs < Max_Crumbs)
        {
            StartCoroutine(Dropper());
        }
    }

    IEnumerator Move_To_Point()
    {
        yield return new WaitForSeconds(Random.Range(7.0f, 12.0f));
        Destination = new Vector2(Random.Range(Min_Bound.x, Max_Bound.x), Random.Range(Min_Bound.y, Max_Bound.y));
        StartCoroutine(Move_To_Point());
    }
}
