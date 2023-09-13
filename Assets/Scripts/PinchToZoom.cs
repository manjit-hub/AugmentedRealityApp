using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchToZoom : MonoBehaviour
{
    public Transform objectToZoom; // The object you want to zoom
    public float zoomSpeed = 0.1f; // Adjust this to control the zoom speed
    public float minScale = 0.5f; // Minimum scale limit
    public float maxScale = 2.0f; // Maximum scale limit

    private float initialDistance;

    void Update()
    {
        // Detect pinch gesture
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch2.phase == TouchPhase.Began)
            {
                initialDistance = Vector2.Distance(touch1.position, touch2.position);
            }
            else if (touch1.phase == TouchPhase.Moved && touch2.phase == TouchPhase.Moved)
            {
                float currentDistance = Vector2.Distance(touch1.position, touch2.position);
                float scaleFactor = currentDistance / initialDistance;

                // Calculate new scale based on pinch gesture
                Vector3 newScale = objectToZoom.localScale * scaleFactor;

                // Clamp the new scale within min and max limits
                newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
                newScale.y = Mathf.Clamp(newScale.y, minScale, maxScale);
                newScale.z = Mathf.Clamp(newScale.z, minScale, maxScale);

                objectToZoom.localScale = newScale;
            }
        }
    }
}

