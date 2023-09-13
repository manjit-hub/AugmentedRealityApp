using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAdjustment : MonoBehaviour
{
    public Transform[] objectsToAdjust; // Array of objects you want to adjust
    public float baseScreenHeight = 1080f; // Reference screen height
    public float scaleFactor = 1.0f; // Adjust this to fine-tune scaling

    void Start()
    {
        AdjustObjects();
    }

    void AdjustObjects()
    {
        float screenHeight = Screen.height;
        float scaleFactor = baseScreenHeight / screenHeight;

        foreach (Transform objTransform in objectsToAdjust)
        {
            // Adjust object's position
            Vector3 newPosition = objTransform.localPosition;
            newPosition.y *= scaleFactor;
            objTransform.localPosition = newPosition;

            // Adjust object's scale
            Vector3 newScale = objTransform.localScale;
            newScale *= scaleFactor;
            objTransform.localScale = newScale;
        }
    }
}
