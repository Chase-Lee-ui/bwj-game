using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListManager : MonoBehaviour
{
    [SerializeField] GameObject taskEntryPrefab;

    private GameObject manager;

    [SerializeField] LinkedList<GameObject> taskList;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");

        foreach (Task_Progress task in manager.GetComponent<Task_Manager>().Task_Progresses)
        {
            GameObject tTask = Instantiate(taskEntryPrefab, new Vector3(0, 0, 0), Quaternion.identity);

            tTask.name = task.NameOfTask;
            tTask.GetComponent<TMP_Text>().text = task.NameOfTask;

            taskList.AddLast(tTask);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
