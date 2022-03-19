using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChickenGenerator : MonoBehaviour
{
    public Transform[] wayPoints = new Transform[4];

    public Transform[] chikenSpawners = new Transform[2];
  

    public int maxCantChikens;

    private int currentChickenAmount;

    public float chikenRate;
    public float proxChiken;

    public GameObject chikenPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CreateChiken();
        Debug.Log("Chicken Genrtor");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateChiken();
        }
    }

    public void CreateChiken()
    {
        GameObject newChiken = Instantiate(chikenPrefab);
        newChiken.GetComponent<Animal>().myManager = this;
        newChiken.GetComponent<Animal>().SetRun();

        Vector3 sourcePostion = SelectSpawner();//The position you want to place your agent
        newChiken.transform.position = SelectSpawner();


        newChiken.GetComponent<NavMeshAgent>().enabled = true;
        /*NavMeshHit closestHit;
        if (NavMesh.SamplePosition(sourcePostion, out closestHit, 500, 1))
        {
            Vector3 finalPos = Vector3.zero;
            finalPos.x = sourcePostion.x;
            finalPos.y = closestHit.position.y;
            finalPos.z = sourcePostion.z;

            
            
        }*/



   
    }

    public Vector3 SelectSpawner()
    {
        int spawnerIndex = (int)Random.Range(0, 2);

        Vector3 spawnPosition = chikenSpawners[spawnerIndex].position;

        return spawnPosition;
    }
}
