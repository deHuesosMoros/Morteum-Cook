using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : CatchableObjects
{


    public ChickenGenerator myManager;
    public Transform[] wayPoints = new Transform[4];

    private NavMeshAgent agent;
    public Transform currentwayPoint = null;
    public bool arrivedTarget = false;
    
    private bool dead;
    public bool isGrabbed;

    public Animator chikenAnimator;


    private AudioSource chikenAsource;
    [Header("Sound Clips")]
    public AudioClip chikenGrabedClip;


    // Start is called before the first frame update
    private void Awake()
    {
        chikenAsource = GetComponent<AudioSource>();
        //chikenAnimator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrabbed)
            return;

        if (myManager != null)
        {
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

        


    }

    public void SetRun() {
        chikenAnimator.SetBool("Run", true);
    }


    public void goToTarget()
    {
        currentwayPoint = myManager.wayPoints[Random.Range(1,4)];
        agent.destination = currentwayPoint.position;
        arrivedTarget = false;
    }

    public void SetGrabbed()
    {
        //chikenAsource.clip = chikenGrabedClip;
        //chikenAsource.Play();
        PlayChikenScream();
        agent.isStopped = true;
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Collider>().enabled = false;
        isGrabbed = true;
    }

    public void PlayChikenScream()
    {
        chikenAsource.PlayOneShot(chikenGrabedClip);
    }

    public void calculateDistanceToTarget()
    {
        Vector3 agentToTarget = currentwayPoint.position - this.transform.position;
        if(agentToTarget.magnitude < 1){
               arrivedTarget = true;
        }
    }

   
}
