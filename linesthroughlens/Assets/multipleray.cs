using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multipleray : MonoBehaviour
{
    // The target marker.
    public Transform target;

    // Angular speed in radians per sec.
    public float speed = 0.5f;


    void Update()
    {

        //float speed = 0.5f;

        Ray ray = new Ray(transform.position + Vector3.up, transform.forward);
        var fwd = transform.TransformDirection(Vector3.down);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 0.5f))
        {


            
            //ray.direction = Quaternion.AngleAxis(12.0f, Vector3.forward) * Vector3.right;
            transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * speed*0.6f);
            //Debug.DrawRay(transform.position, hit.point, Color.red);

        }
        else
        {
            //Debug.DrawRay(transform.position, hit.point, Color.white);
            transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * speed * 0.6f);
            transform.position += transform.forward * speed* Time.deltaTime;
            
        }



    }

}