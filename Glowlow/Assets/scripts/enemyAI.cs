using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{



    public float watchDistance = 30f;
	public float followDistance = 15f;
	public float attackDistance = 5f;
    public float moveSpeed = 2f;
	public float damping = 2f;

	private Transform target;
    private Rigidbody rb;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		target = GameObject.FindGameObjectsWithTag("Player")[0].transform; 
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
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), damping);
    }

    private void follow()
    {
        // rb.AddRelativeForce(Vector3.forward * moveSpeed);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void attack()
    {
        //print("fight!");
    }
}
