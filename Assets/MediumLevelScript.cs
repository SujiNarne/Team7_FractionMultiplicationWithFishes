using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MediumLevelScript : MonoBehaviour
{
    public void MediumLevel()
    {
        SceneManager.LoadScene("MediumLevelScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
