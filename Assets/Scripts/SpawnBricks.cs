using UnityEngine;
using System.Collections;

public class SpawnBricks : MonoBehaviour
{

    public GameObject Zozo;
    public GameObject brick;

    public float spawnTime = 5f;
    public float spawnDelay = 1f;
    public GameObject[] bricks;

    Vector3 newPositon = new Vector3();



    public void Start()
    {

        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {

        int brickIndex = Random.Range(0, bricks.Length);


        newPositon.x = Random.Range(1f, 5f);
        newPositon.y = Random.Range(0.2f, 1f);
        Instantiate(bricks[brickIndex], newPositon, transform.rotation);
        //Random.insideUnitSphere

    }
    
    

}