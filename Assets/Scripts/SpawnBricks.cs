using UnityEngine;
using System.Collections;

public class SpawnBricks : MonoBehaviour {

    public float spawnTime = 5f;        
    public float spawnDelay = 1f;               
    public GameObject[] bricks;        

    public void Start()
    {
       
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
       
        int brickIndex = Random.Range(0, bricks.Length);
        Vector3 newPositon = new Vector3();
        newPositon.x = Random.Range(0.5f, 2f);
        newPositon.y = Random.Range(0.2f, 1f);
        Instantiate(bricks[brickIndex], newPositon, transform.rotation);
    }
   
}
