using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationController : MonoBehaviour {
	public GameObject Destination;
	private NavMeshAgent navMeshAgent;
	private double TimeAtDestination = 0f;
	// Use this for initialization
	void Start () {
		navMeshAgent = GetComponent<NavMeshAgent>();
		navMeshAgent.destination = Destination.transform.localPosition;
		navMeshAgent.isStopped = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (((transform.position - navMeshAgent.destination).magnitude) <= 4) { TimeAtDestination += Time.deltaTime; };
		if (TimeAtDestination > 1) { navMeshAgent.isStopped = true; }
	}
}
