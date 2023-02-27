using UnityEngine;
using System.Collections;

public class PlanetSpin : MonoBehaviour
{

    public float HightVariables = 1f;
    void Update()
    {

        transform.Rotate(Vector3.forward * -HightVariables);
    }

}