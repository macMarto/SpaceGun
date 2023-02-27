using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Die()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        Score.scoreValue += 1;
        if (PlayerPrefs.GetFloat("HightScore") < Score.scoreValue)
        {
            PlayerPrefs.SetFloat("HightScore", Score.scoreValue);
        }

    }

    public void Respawn()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}
