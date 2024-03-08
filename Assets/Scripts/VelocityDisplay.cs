using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VelocityDisplay : MonoBehaviour
{
    public Camera cameraToTrack;
    public TMP_Text velocityText;

    void Update()
    {
        // Get the velocity of the camera
        Vector3 velocity = cameraToTrack.velocity;

        // Display velocity on screen
        velocityText.text = velocity.magnitude.ToString("F2") + " m/s";
    }
}
