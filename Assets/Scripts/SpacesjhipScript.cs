using UnityEngine;
using UnityEngine.InputSystem;

public class Spaceship2D : MonoBehaviour
{
    public float thrustForce = 10f;
    public float torqueForce = 0.0000000000001f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleThrust();
        HandleRotation();
    }

    void HandleThrust()
    {
        var keyboard = Keyboard.current;

        if (keyboard.upArrowKey.isPressed)
            rb.AddForce(transform.up * thrustForce);

        if (keyboard.downArrowKey.isPressed)
            rb.AddForce(-transform.up * thrustForce);
    }

    void HandleRotation()
    {
        var keyboard = Keyboard.current;

        if (keyboard.rightArrowKey.isPressed)
            rb.AddTorque(-torqueForce);

        if (keyboard.leftArrowKey.isPressed)
            rb.AddTorque(torqueForce);
    }
}
