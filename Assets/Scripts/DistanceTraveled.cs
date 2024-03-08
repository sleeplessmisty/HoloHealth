using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceTraveled : MonoBehaviour
{
    public static DistanceTraveled instance;
    private float totalDistance = 0f;
    private Vector3 previousPosition;
    public TMP_Text distanceText;

    // Ensure only one instance exists across scenes
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        //previousPosition = transform.position;  //just so we don't go crazy on the first frame
        previousPosition = Camera.main.transform.position;  //just so we don't go crazy on the first frame
    }
    void Update()
    {
        float distanceThisFrame = Vector3.Distance(Camera.main.transform.position, previousPosition);
        totalDistance += distanceThisFrame;
        distanceText.text = totalDistance.ToString("f2") + "m";
        previousPosition = Camera.main.transform.position;
    }

    public float GetDistance() 
    { 
        return totalDistance;
    }
}