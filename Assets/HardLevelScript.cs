using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevelScript : MonoBehaviour
{
    public void HardLevel()
    {
        SceneManager.LoadScene("HardLevelScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
