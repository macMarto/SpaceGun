using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startt : MonoBehaviour
{
    public Text hightScoreText;
    private void Start()
    {
        hightScoreText.text = "Hight Score : " +((int) PlayerPrefs.GetFloat("HightScore")).ToString();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
