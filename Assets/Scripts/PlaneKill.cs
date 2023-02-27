using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneKill : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 6.50 || transform.position.y < -6)
        {
            SceneManager.LoadScene(2);
            //Score.scoreValue = 0;
            Score.scoreValueEnd = Score.scoreValue;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(2);
        Score.scoreValueEnd = Score.scoreValue;
        //Score.scoreValue = 0;
    }
}

