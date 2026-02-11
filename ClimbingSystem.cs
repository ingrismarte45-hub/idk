// ClimbingSystem.cs

using UnityEngine;

public class ClimbingSystem : MonoBehaviour
{
    public float climbSpeed = 3.0f;
    public LayerMask climbableLayer;
    private bool isClimbing = false;

    void Update()
    {
        if (Input.GetButtonDown("Climb") && IsOnClimbableSurface())
        {
            StartClimbing();
        }
        if (isClimbing)
        {
            Climb();
        }
        if (Input.GetButtonUp("Climb"))
        {
            StopClimbing();
        }
    }

    private bool IsOnClimbableSurface()
    {
        // Check if the player is in contact with a climbing surface (using raycasting for example)
        return Physics.CheckSphere(transform.position, 0.2f, climbableLayer);
    }

    private void StartClimbing()
    {
        isClimbing = true;
        // Disable player gravity, turn on climbing animations, etc.
    }

    private void Climb()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 climbDirection = transform.up * moveVertical * climbSpeed * Time.deltaTime;
        transform.position += climbDirection;
        // Add animations and other functionalities for climbing here
    }

    private void StopClimbing()
    {
        isClimbing = false;
        // Enable player gravity, disable climbing animations, etc.
    }
}