using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    //public static int scoreValue = 0;
    //Text score;
    public void EndGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Score.scoreValue = 0;
        //score = GetComponent<Text>();

        //score.text = "Score: " + scoreValue;
    }
}
