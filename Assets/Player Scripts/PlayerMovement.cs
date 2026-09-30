using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement3D : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0f, moveV);
        rb.AddForce(movement * speed);
    }
}