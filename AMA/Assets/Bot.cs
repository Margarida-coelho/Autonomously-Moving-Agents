using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    NavMeshAgent agent;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();  
    }

    void Seek(Vector3 pos)
    {
        agent.SetDestination(pos);
    }

    void Flee(Vector3 pos)
    {
        Vector3 fleeVector = pos - this.transform.position;
        agent.SetDestination(this.transform.position - fleeVector);
    }

    // Update is called once per frame
    void Update()
    {
        Flee(target.transform.position);
    }
}
