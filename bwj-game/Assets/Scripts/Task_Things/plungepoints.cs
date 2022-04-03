using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plungepoints : MonoBehaviour
{
    static plungepoints Instance;

    public int maxPoints = 2;
    public Text pointsText;
    public GameObject levelCompletedUI;
    private int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    void UpdatePotinsText();
    {
        pointsText.text = points + "/" + maxPoints;
        if (plungepoints == maxPoints) {
            levelCompletedUI.SetActive(true);
        }
    }


    public static void AddPoint()
    {
        AddPoints(1);
    }

    public static void AddPoints(int points)
    {
        Instance.points += points;
        Instance.UpdatePotinsText();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
