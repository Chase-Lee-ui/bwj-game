using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListManager : MonoBehaviour
{
    [SerializeField] private GameObject taskEntryPrefab;

    private GameObject manager;

    [SerializeField] private List<GameObject> taskList;

    // Start is called before the first frame update
    void Start()
    {
        taskList = new List<GameObject>();

        manager = GameObject.Find("Manager");

        if (manager.GetComponent<Task_Manager>().Task_Progresses.Length < 1)
        {
            GameObject tTask = Instantiate(taskEntryPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            tTask.transform.SetParent(transform, false);

            tTask.name = "Placeholder";
            tTask.GetComponent<TMP_Text>().text = "Placeholder";

            taskList.Add(tTask);
        }
        else
        {
            foreach (Task_Progress task in manager.GetComponent<Task_Manager>().Task_Progresses)
            {
                GameObject tTask = Instantiate(taskEntryPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                tTask.transform.SetParent(transform, false);

                tTask.name = task.NameOfTask;
                tTask.GetComponent<TMP_Text>().text = task.NameOfTask;

                taskList.Add(tTask);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Task_Progress task in manager.GetComponent<Task_Manager>().Task_Progresses)
        {
            if (task.Progress >= 100)
            {
                foreach (GameObject lObject in taskList)
                {
                    if (task.NameOfTask == lObject.name)
                    {
                        lObject.GetComponent<TMP_Text>().fontStyle = FontStyles.Strikethrough;

                        break;
                    }
                }
            }
        }
    }
}
