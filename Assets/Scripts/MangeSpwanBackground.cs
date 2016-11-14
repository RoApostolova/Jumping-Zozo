using UnityEngine;
using System.Collections;

public class MangeSpwanBackground : MonoBehaviour {

    public GameObject Zozo;
    public GameObject Background;
    public GameObject Background2;


    public Vector2 BackGroundPosition;
    public Vector2 BackGroundPosition2;


    // Use this for initialization
    void Start () {
        
           
    }
	
	// Update is called once per frame
	void Update () {
       BackGroundPosition = new Vector2(Background.transform.position.x+(float)7.9, Background.transform.position.y);
       BackGroundPosition2 = new Vector2(Background2.transform.position.x + (float)7.9, Background2.transform.position.y);


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            Background2.transform.position = BackGroundPosition;
            


        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == Zozo.name)
        {
            Background.transform.position = BackGroundPosition2;

        }
    }


}
