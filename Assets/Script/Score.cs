using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score;
    public Text scoredis;

    private void Update()
    {
        int scr = (int)score;
        //int scr = Convert.ToInt32(score);
        scoredis.text = "SCORE " + scr.ToString();
    }
}
