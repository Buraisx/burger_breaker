using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    // Update is called once per frame
    void Update()
    {
        // your position needs to be proportional to the width of the screen
        // Input.mousePosition.x / Screen.width
        // This will be a percentage unit from 1 to -1
        // After multiplying by width it will be 1 to 16
        float mouseX = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        // Vector2 is a compact way of storing x and y coordinates
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseX, minX, maxX);
        transform.position = paddlePos;
    }
}
