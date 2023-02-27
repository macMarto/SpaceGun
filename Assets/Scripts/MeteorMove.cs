using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    public float speed = 1;
    private Enemy enemy;

    public void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //float num = Random.Range(4f, -4f);

        if (transform.position.x < -20)
        {
            transform.position += new Vector3(40, 0, 0);
            enemy?.Respawn();
        }

    }
}
