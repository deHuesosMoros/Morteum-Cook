using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{   
    public GameObject tablePoint;

    
    
    void Awake()
    {
        tablePoint = this.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isEmpty() {
        if(tablePoint.transform.childCount > 0){
            return false;
        }else{
            return true;
        }
    }

    virtual public bool canUseTable(GameObject other){
       return true;
    }
}
