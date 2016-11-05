using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    public GameObject brick;//Public variable to store a reference to the player game object


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
    public void SpawnRandom()
    {
        //Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane+5)); //will get the middle of the screen

        Vector2 screenPosition = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height)));
        Instantiate(brick, screenPosition, Quaternion.identity);
    }


}
