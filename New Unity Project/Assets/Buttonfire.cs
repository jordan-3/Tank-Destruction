using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonfire : MonoBehaviour
{
    public GameObject theBullet;
    private float shortDistance = 100000;
    private GameObject target;
  
    //Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            /*
             var clone = Instantiate(ButtonFire, transform.position, transform.rotation);
             clone.velocity = transform.TransformDirection(Vector3)(0, 0, Speed));

             Destroy(clone.gameObject, 3);
             */

        }
    }

    public void FireBullet()
    {
        shortDistance = 1000000;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            float dist = Vector3.Distance(enemy.transform.position, transform.position);
            if (shortDistance > dist)
            {
                shortDistance = dist;
                target = enemy;

            }
        }
        GameObject bullet = Instantiate(theBullet, transform.position, transform.rotation);
        bullet.GetComponent<MoveBullet>().Feed(target);
    }
}                 
         


    
