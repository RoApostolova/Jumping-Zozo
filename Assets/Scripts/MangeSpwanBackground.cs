using UnityEngine;
using System.Collections;

public class MangeSpwanBackground : MonoBehaviour {

    public GameObject Sky;
    public GameObject Colider;
    public GameObject Zozo;
    public GameObject brick;
    
    // Use this for initialization
    void Start () {
        
           
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            Instantiate(Sky, new Vector2(Sky.transform.position.x, Sky.transform.position.y + (float)1), Quaternion.identity);
            Instantiate(brick, new Vector2(Sky.transform.position.x, Sky.transform.position.y + (float)1), Quaternion.identity);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            Destroy(Sky);
           
        }
    }


}
