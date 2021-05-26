using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mainmenu : MonoBehaviour
{
    public Animator fade;
    public GameObject canvas;
   

    public void GameStart()
    {
        Invoke("ok", 2f);
        canvas.SetActive(false);
        fade.SetTrigger("Fade");
    }

    void ok()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
