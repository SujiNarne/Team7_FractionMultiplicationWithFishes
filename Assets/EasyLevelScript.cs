using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyLevelScript : MonoBehaviour
{
    public void EasyLevel()
    {
        SceneManager.LoadScene("EasyLevelScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
