using UnityEngine;

public class smallObects : MonoBehaviour
{
    public float speed = 1;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (transform.position.x > 30)
        {
            transform.position += new Vector3(-50, 0, 0);
        }
    }
}
