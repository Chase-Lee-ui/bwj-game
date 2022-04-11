using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task_Cooking : Task_Progress
{
    [SerializeField] public float progressRate;
    public GameObject FryingPan;
    public GameObject Canvas;
    public Slider slider;

    public float currentProgress;

    public Cooking_Progress within;
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    public override void Update()
    {
        if (within.cooking && Progress < 100)
        {
            Progress += Time.deltaTime * progressRate;
            slider.value = Progress;
        }
        else
        {
            if (Progress > 0)
            {
                Progress -= Time.deltaTime * Rate_Of_Decay / 2;
                slider.value = Progress;
            }
        }
        if (Progress >= 100)
        {
            Rate_Of_Decay = 0;
        }
        /*
        slider.value = Progress;
        if (Input.GetKeyDown(KeyCode.R))
        {
            slider.value = 0;
            Progress = 0;
        }
        */
    }
    public void completionRate(float progress)
    {
        slider.value = progress;
    }
}