using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public float Dif;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Mode");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);
        var comp = GameObject.FindObjectOfType<Task_Manager>();
        comp.Difficulty_Augment *= Dif;
    }
}
