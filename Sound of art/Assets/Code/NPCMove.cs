using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{

    [SerializeField]
    List<NPCWaypoint> waypoint;

   /* [SerializeField]
    float totaltime = 3f;
    [SerializeField]
    float switchchange = 0.2f;
    [SerializeField]
    float totalintime = 3f;

    [SerializeField]
    bool patrolwait;*/

    NavMeshAgent navMeshBob;

 
    public int curentindex;
    public float waittimer;
    public float stetictime;

    // Start is called before the first frame update
    void Start()
    {
        navMeshBob = GetComponent<NavMeshAgent>();
        stetictime = waittimer;
    }
    

	private void Update()
	{
        Runing();
    }

	private void Runing() 
    {
       
        waittimer -= Time.deltaTime;

        Vector3 targetA = waypoint[curentindex ].transform.position;
        navMeshBob.SetDestination(targetA);
        if (waittimer <= 0)
            {
            print("1");
            
            print("2");
            if (curentindex == waypoint.Count -1)
            {
                print("3");
                curentindex = 0;
            }
            else
            {
                print("4");
                curentindex++;
            }
            
            print("5");
            waittimer = stetictime;
            }
    }

    
}
