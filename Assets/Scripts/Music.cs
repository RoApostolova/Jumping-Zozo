using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{

    private float horizontal;
    public AudioSource src;
    public AudioClip[] clips;
    void Start()
    {
        if (horizontal == 0)
        {
            this.src.clip = this.clips[0];
            this.src.Play();

        }
        //else if()
        //{
        //    this.src.clip = this.clips[1];
        //    this.src.Play();
        //}
    }

    void Update()
    {
        
    }
}
