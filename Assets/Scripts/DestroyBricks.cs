using UnityEngine;
using System.Collections;

public class DestroyBricks : MonoBehaviour {

    public GameObject Zozo;
    public GameObject brick;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            Destroy(brick);

        }
    }
}
