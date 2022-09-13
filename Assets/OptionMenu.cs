using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
   public void Volume()
    {
        SceneManager.LoadScene("OptionScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
