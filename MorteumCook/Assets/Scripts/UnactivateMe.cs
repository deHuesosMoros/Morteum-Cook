using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnactivateMe : MonoBehaviour
{
    public float timeForAdvice = 0;
    public GameObject gameAdvice;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            timeForAdvice += Time.time;
            if(timeForAdvice >= 300){
                timeForAdvice = 0;
                gameAdvice.SetActive(false);
            }
        
    }
}
