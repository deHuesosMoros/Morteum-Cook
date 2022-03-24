using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    private AudioSource stampSource;
    public Animator anim;
     public bool toCrush;


    private void Awake()
    {
        stampSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Crushing(){
        anim.SetTrigger("toCrush");
    }


    //Called from animation event
    public void PlayStamp()
    {
        stampSource.Play();
    }
}
