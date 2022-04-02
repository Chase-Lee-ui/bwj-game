using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public GameObject echo;
    private Player_Movement player;
    void Start()
    {
        player = GetComponent<Player_Movement>();
    }
    void Update()
    {
        if(player.xDirection != 0 || player.yDirection != 0)
        {
            if(timeBtwSpawns <= 0)
            {
                Instantiate(echo, transform.position, this.transform.rotation);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
        
    }
}
