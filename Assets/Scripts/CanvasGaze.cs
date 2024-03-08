using UnityEngine;

public class FollowGaze : MonoBehaviour
{
    private Camera mainCamera;
    public float distance = 2f; // Set the distance from the camera

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Get the forward direction of the camera
        Vector3 gazeDirection = mainCamera.transform.forward;

        // Set the position of the canvas in front of the camera
        transform.position = mainCamera.transform.position + (gazeDirection * distance);

        // Make the canvas face the camera
        transform.LookAt(mainCamera.transform);
    }
}
