using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
        private Vector3 offsetProjectile = new Vector3(2,0,0);

    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began|| Input.GetKeyDown("space"))
        {
            var projectile = Instantiate(projectilePrefab, transform.position + offsetProjectile,
                projectilePrefab.transform.rotation);

        }
    }
}
