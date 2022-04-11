using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task_Bedroom : Task_Progress
{
    public GameObject messyBedroom;
    public GameObject cleanBedroom;
    public Slider blanket;

    public Clean_Bed pillow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        if (pillow.clean && blanket.value > 75)
        {
            Progress = 100;
        }
        if (Progress == 100)
        {
            messyBedroom.SetActive(false);
            cleanBedroom.SetActive(true);
        }
        
    }
}
