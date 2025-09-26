using UnityEngine;

/// <summary>
/// Continuously rotates the GameObject this script is attached to.
/// </summary>
public class spinn : MonoBehaviour
{
    // The speed and direction of the rotation.
    // You can change these values in the Inspector.
    [Tooltip("The speed of rotation on each axis (X, Y, Z).")]
    public Vector3 rotationSpeed = new Vector3(0, 30, 0);

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local axes.
        // Time.deltaTime ensures the rotation is smooth and independent of frame rate.
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}