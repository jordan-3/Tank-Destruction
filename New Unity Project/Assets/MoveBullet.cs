using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    bool fire = false;
    GameObject bTarget;
    float bspeed = 20;
    Rigidbody rb;
    private bool setDes = false;

    void start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (fire)
        {
            if (!bTarget)
            {
                Destroy(gameObject, 5);
            }
        }
        else
        {
            transform.LookAt(bTarget.transform);
            rb.AddRelativeForce(Vector3.forward * bspeed, ForceMode.Force);
        }
     }
 }
 public void Feed(GameObject Target)
 {
     bTarget = Target;
     fire = true;
 }

private void OnTriggerEnter(Collider other)
 {
    if (other.gameObject.tag == "Enemy")
    {
        Destroy(other.gameobject);
        Destroy(gameobject);
    }
 }
