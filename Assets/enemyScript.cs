using System.Collections;
using UnityEngine.AI;
using UnityEngine;

public class enemyScript : MonoBehaviour {
	Transform player;
	NavMeshAgent nav;


	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;

		nav = GetComponent <NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (player.position);
	}
}
