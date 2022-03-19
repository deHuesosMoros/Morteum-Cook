using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashTable : Table
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty()== false){
            Destroy(tablePoint.transform.GetChild(0).gameObject);
        }
    }

    override public bool canUseTable(GameObject other){
        return true;
    }
}
