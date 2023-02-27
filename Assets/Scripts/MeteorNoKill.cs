using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorNoKill : MonoBehaviour
{
    public float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < -30)
        {
            transform.position += new Vector3(55, 0, 0);
        }

    }
}
