using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Level : MonoBehaviour
{
    public float Augment;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameObject.FindObjectOfType<Task_Manager>().Difficulty_Augment *= Augment;
            GameObject.FindObjectOfType<Task_Manager>().Initiated = false;
            GameObject.FindObjectOfType<Task_Manager>().Done = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }
}
