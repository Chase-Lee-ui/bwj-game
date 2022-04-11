using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Energy : MonoBehaviour
{

    [SerializeField] public float Decrease;
    [SerializeField] public float charge;
    // Start is called before the first frame update
    public float maxEnergy = 100;
    public float currentEnergy;
    public GameObject Roomba_Station;
    public Player_Movement Player;
    public Energy energyBar;
    public Vector2 MaxBounds;
    public Vector2 MinBounds;

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
            // this.gameObject.SetActive(false);
            transform.position = Vector2.Lerp(transform.position, Roomba_Station.transform.position, Time.deltaTime * 100.0f);
            StartCoroutine(StopPlayer());
        }
        // if (!this.gameObject.activeSelf)
        // {
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // }

        //Manual Energy Loss (for testing purposes)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //LoseEnergy(20);
        }

        //Energy Drain
        currentEnergy -= Time.deltaTime*Decrease;
        energyBar.SetEnergy(currentEnergy);


        //Recharge Station
        if(this.gameObject.transform.position.x <= MaxBounds.x &&
        this.gameObject.transform.position.x >= MinBounds.x &&
        this.gameObject.transform.position.y <= MaxBounds.y &&
        this.gameObject.transform.position.y >= MinBounds.y &&
        currentEnergy <= maxEnergy)
        {
            currentEnergy += Time.deltaTime*charge;
            energyBar.SetEnergy(currentEnergy);
        }
    }

    IEnumerator StopPlayer()
    {
        Player.enabled = false;
        yield return new WaitForSeconds(3.0f);
        Player.enabled = true;
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
