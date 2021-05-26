using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endmenu : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
