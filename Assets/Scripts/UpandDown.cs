using UnityEngine;

public class UpandDown : MonoBehaviour
{
    public float HightVariables = 1f;

    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HightVariables;
    }
}
