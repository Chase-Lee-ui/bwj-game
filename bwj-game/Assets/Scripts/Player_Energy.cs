using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Energy : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxEnergy = 500;
    public int currentEnergy;

    public Energy energyBar;

    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoseEnergy(20);
        }
        currentEnergy -= (int)Time.deltaTime;
        energyBar.SetEnergy(currentEnergy);

    }

    void LoseEnergy(int drain)
    {
        currentEnergy -= drain;
        energyBar.SetEnergy(currentEnergy);
    }
}
