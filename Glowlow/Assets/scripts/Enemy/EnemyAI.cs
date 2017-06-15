using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{



    public float watchDistance = 30f;
	public float followDistance = 15f;
	public float attackDistance = 5f;
	public float attractionToDockDistance = 20f;
    public float moveSpeed = 2f;
	public float damping = 2f;
	private float initialFollowDistance;

	private Transform target;
    private Rigidbody rb;
	public AudioClip soundWatch, soundFollow, soundAttack;
	private AudioSource ac;

	NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
		ac = GetComponent<AudioSource> ();
        rb = GetComponent<Rigidbody>();

		agent = GetComponent<NavMeshAgent> ();
		target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
		initialFollowDistance = followDistance;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        // print(distance);
        if (distance < watchDistance)
        {
            watch();
        }

        if (distance < followDistance)
        {
            follow();
        }

        if (distance < attackDistance)
        {
            attack();
        }

    }

    private void watch()
    {
        Vector3 direction = target.position - transform.position;
//        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), damping);
    }

    private void follow()
    {
       // myAnimator.SetTrigger("IsWalking");


        // rb.AddRelativeForce(Vector3.forward * moveSpeed);
//        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		agent.speed = moveSpeed;
		agent.destination = target.position;

		ac.clip = soundFollow;
		ac.Play();
    }

    private void attack()
    {
		ac.clip = soundAttack;
		ac.Play();
    }

	public void makeMoreSenible(){
		followDistance = attractionToDockDistance;
	}
	public void makeLessSenible(){
		followDistance = initialFollowDistance;
	}
}
