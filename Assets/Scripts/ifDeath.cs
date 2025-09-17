using UnityEngine;
using UnityEngine.SceneManagement;

public class ifDeath : MonoBehaviour
{
    private Transform playerTransform;

    void Awake()
    {
        playerTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = playerTransform.position;
        float yCoord = playerPosition.y;
        //Debug.Log("yCoord is:" + yCoord);
        if(yCoord < -5){
            SceneManager.LoadScene("Assets/Scenes/SampleScene.unity");
            Debug.Log("You fell out of the world");
        }
    }
}
