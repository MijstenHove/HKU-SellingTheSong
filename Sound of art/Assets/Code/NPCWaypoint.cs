using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWaypoint : MonoBehaviour
{
    [SerializeField]
    protected float debugRedius = 1.0f;

    
    public virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, debugRedius);
    
    }
  
}