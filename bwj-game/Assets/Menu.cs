using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

 public void PlayGame ()
 {
     SceneManager.LoadScene("CHASE_BaseV2");
 }

public void QuitGame ()
{
   Debug.Log("QUIT!");
    Application.Quit();
}

}