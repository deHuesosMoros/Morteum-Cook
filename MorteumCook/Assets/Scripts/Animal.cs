using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : CatchableObjects
{
    public Transform[] wayPoints = new Transform[4];

    private NavMeshAgent agent;
    public Transform currentwayPoint = null;
    public bool arrivedTarget = false;
    
    private bool dead;
    public bool isGrabbed;

    // Start is called before the first frame update
    private void Awake()
    {        
        agent = GetComponent<NavMeshAgent>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isGrabbed)
            return;

        if (currentwayPoint == null)
        {
            goToTarget();
        }
        else
        {
            if (arrivedTarget)
            {
                goToTarget();
            }
        }
        calculateDistanceToTarget();


    }

    public void goToTarget(){

        currentwayPoint = wayPoints[Random.Range(1,4)];
        agent.destination = currentwayPoint.position;
        arrivedTarget = false;

    }

    public void SetGrabbed()
    {
        agent.isStopped = true;
        isGrabbed = true;
    }

    public void calculateDistanceToTarget()
    {
        Vector3 agentToTarget = currentwayPoint.position - this.transform.position;
        if(agentToTarget.magnitude < 1){
               arrivedTarget = true;
        }
    }

   
}
