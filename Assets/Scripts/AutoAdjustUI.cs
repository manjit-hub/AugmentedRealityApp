using UnityEngine;
using UnityEngine.UI;

public class AutoAdjustUI : MonoBehaviour
{
    public CanvasScaler canvasScaler;

    // Reference resolution settings
    public float referenceWidth = 1920f;
    public float referenceHeight = 1080f;
    public bool matchWidth = true;

    private void Awake()
    {
        if (canvasScaler == null)
        {
            // If canvasScaler is not assigned, try to find it on the same GameObject
            canvasScaler = GetComponent<CanvasScaler>();
        }

        if (canvasScaler != null)
        {
            // Calculate the aspect ratio of the current screen
            float screenAspect = (float)Screen.width / Screen.height;

            if (matchWidth)
            {
                // Match the width, adjust the reference height
                canvasScaler.referenceResolution = new Vector2(referenceWidth, referenceWidth / screenAspect);
            }
            else
            {
                // Match the height, adjust the reference width
                canvasScaler.referenceResolution = new Vector2(referenceHeight * screenAspect, referenceHeight);
            }
        }
        else
        {
            Debug.LogError("Canvas Scaler component not found. Please assign it to the script.");
        }
    }
}
