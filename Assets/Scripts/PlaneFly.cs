using UnityEngine;

public class PlaneFly : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpFloat = 1;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector2(0f, jumpFloat), ForceMode2D.Force);
            GetComponent<AudioSource>().Play();
        }
    }
}
