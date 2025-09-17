using UnityEngine;

public class ifDeath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        float yCoord = playerPosition.y;
        //Debug.Log("yCoord is:" + yCoord);
        if(yCoord<-5){
            transform.position = new Vector3(0f,3f,0f);
            Debug.Log("You fell out of the world");
        }
        
    }
}
