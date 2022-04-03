using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Energy : MonoBehaviour
{

    [SerializeField] private GameObject Player;
    [SerializeField] public float Decrease;
    [SerializeField] public float charge;
    // Start is called before the first frame update
    public float maxEnergy = 100;
    public float currentEnergy;

    public Energy energyBar;

    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);

    }

    // Update is called once per frame
    void Update()
    {
        //Out of Energy Reset (technically tentative for change)
        if (currentEnergy <= 0)
        {
            this.Player.gameObject.SetActive(false);
        }
        if (!this.Player.gameObject.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //Manual Energy Loss (for testing purposes)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //LoseEnergy(20);
        }

        //Energy Drain
        currentEnergy -= Time.deltaTime*Decrease;
        energyBar.SetEnergy(currentEnergy);


        //Recharge Station
        if (this.Player.gameObject.transform.position.y <= 1.5
          && this.Player.gameObject.transform.position.y >= -1.5
          && this.Player.gameObject.transform.position.x <= 1.5
          && this.Player.gameObject.transform.position.x >= -1.5
          && currentEnergy < maxEnergy)
        {
            currentEnergy += Time.deltaTime*charge;
            energyBar.SetEnergy(currentEnergy);
        }
    }

    /*void LoseEnergy(float drain)
    {
        currentEnergy -= drain;
        energyBar.SetEnergy(currentEnergy);
        while (this.Player.gameObject.transform.position.y <= 10
          && this.Player.gameObject.transform.position.y >= -10
          && this.Player.gameObject.transform.position.x <= 10
          && this.Player.gameObject.transform.position.x >= -10)
        {
            currentEnergy += drain*10;
            energyBar.SetEnergy(currentEnergy);
        }
    }


    void Recharge(float charge)
    {
        while (this.Player.gameObject.transform.position.y <= 3
          && this.Player.gameObject.transform.position.y >= -3
          && this.Player.gameObject.transform.position.x <= 3
          && this.Player.gameObject.transform.position.x >= -3)
        {
            currentEnergy += charge;
            energyBar.SetEnergy(currentEnergy);
        }
    }
    */
}
