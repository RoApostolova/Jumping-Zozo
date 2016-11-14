using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public GameObject Zozo;
    bool isGrounded = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (isGrounded)
        {
            Application.LoadLevel(2);
        }
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            isGrounded = true;
            Debug.Log("asdasd");    
        }

    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            isGrounded = true;
        }

    }
}
