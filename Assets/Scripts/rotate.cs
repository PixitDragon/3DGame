using UnityEngine;

public class rotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,30 * Time.deltaTime);
    }
}
