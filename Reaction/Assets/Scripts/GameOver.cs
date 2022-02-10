using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public void OnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OnRestart()
    {
        SceneManager.LoadScene(1);
    }
}
