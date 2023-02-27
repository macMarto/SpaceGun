using UnityEngine;

public class Satelitte : MonoBehaviour
{
    public float HightVariables = 0.1f;

    void Update()
    {
        transform.position += Vector3.left * Mathf.Sin(Time.time) * Time.deltaTime * HightVariables;
    }
}
