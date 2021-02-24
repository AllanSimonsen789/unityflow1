using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controllerNPC : MonoBehaviour
{
    NavMeshAgent nm;
    Rigidbody rb;
    Animator anim;
    public Transform Target;
    public Transform[] WayPoints;
    public int cur_WayPoint;
    public float speed, stop_distance;
    public float pauseTimer;
    public float pauseTimerShop;
    [SerializeField]
    private float cur_timer;

    void Awake()
    {
        nm = gameObject.GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
        cur_WayPoint = Random.Range(0, WayPoints.Length);
        Target = WayPoints[cur_WayPoint];

        cur_timer = (Target.tag == "Shop") ? pauseTimerShop : pauseTimer;

    }


    void Update()
    {
        nm.acceleration = speed;
        nm.stoppingDistance = stop_distance;

        float distance = Vector3.Distance(transform.position, Target.position);

        if (distance > stop_distance && WayPoints.Length > 0)
        {
            anim.SetFloat("Speed", 0.2f);

            Target = WayPoints[cur_WayPoint];
        }
        else if (distance <= stop_distance && WayPoints.Length > 0)
        {
            if (cur_timer > 0)
            {
                cur_timer -= 0.01f;
                anim.SetFloat("Speed", 0f);
                if(Target.tag == "Shop"){
                    transform.localEulerAngles = new Vector3(0,Target.transform.eulerAngles.y,0);
                    Debug.Log(Target.tag);
                }


            }
            if (cur_timer <= 0)
            {
                cur_WayPoint = Random.Range(0, WayPoints.Length);
                Target = WayPoints[cur_WayPoint];
                cur_timer = (Target.tag == "Shop") ? pauseTimerShop : pauseTimer;
            }
        }
        nm.SetDestination(Target.position);
    }
}
