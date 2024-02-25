using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500;
    public float sidewaysForce = 5.0f;

    private float horizontalInput;

    private Vector3 movedDirection;

    //For Android app
    private float dirX;

    private void Update()
    {
        //For Android App
        if (Application.platform == RuntimePlatform.Android)
        {
            dirX = Input.acceleration.x * sidewaysForce;
            movedDirection = new Vector3(dirX, 0, 0);
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            movedDirection = new Vector3(horizontalInput, 0, 0);
        }
    }

    void FixedUpdate()
    {
        //Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        rb.AddForce(movedDirection * sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
