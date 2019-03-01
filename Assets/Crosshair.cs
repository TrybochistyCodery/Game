using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    // Crosshairs
    public bool showCrosshair = true;                   // Whether or not the crosshair should be displayed
    public Texture2D crosshairTexture;                  // The texture used to draw the crosshair
    public int crosshairLength = 10;                    // The length of each crosshair line
    public int crosshairWidth = 4;                      // The width of each crosshair line
    public float startingCrosshairSize = 10.0f;         // The gap of space (in pixels) between the crosshair lines (for weapon inaccuracy)
    private float currentCrosshairSize;					// The gap of space between crosshair lines that is updated based on weapon accuracy in realtime

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        // Hold the location of the center of the screen in a variable
        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);

        // Draw the crosshairs based on the weapon's inaccuracy
        // Left
        Rect leftRect = new Rect(center.x - crosshairLength - currentCrosshairSize, center.y - (crosshairWidth / 2), crosshairLength, crosshairWidth);
        GUI.DrawTexture(leftRect, crosshairTexture, ScaleMode.StretchToFill);
        // Right
        Rect rightRect = new Rect(center.x + currentCrosshairSize, center.y - (crosshairWidth / 2), crosshairLength, crosshairWidth);
        GUI.DrawTexture(rightRect, crosshairTexture, ScaleMode.StretchToFill);
        // Top
        Rect topRect = new Rect(center.x - (crosshairWidth / 2), center.y - crosshairLength - currentCrosshairSize, crosshairWidth, crosshairLength);
        GUI.DrawTexture(topRect, crosshairTexture, ScaleMode.StretchToFill);
        // Bottom
        Rect bottomRect = new Rect(center.x - (crosshairWidth / 2), center.y + currentCrosshairSize, crosshairWidth, crosshairLength);
        GUI.DrawTexture(bottomRect, crosshairTexture, ScaleMode.StretchToFill);
    }
}
