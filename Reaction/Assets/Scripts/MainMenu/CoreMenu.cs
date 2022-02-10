using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreMenu : MonoBehaviour
{

   public void OnStartScene()
   {
        SceneManager.LoadScene(1);
   }
    public void OnOptions()
    {
        Application.Quit();
    }
}
