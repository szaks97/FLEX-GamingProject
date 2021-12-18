using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeams : MonoBehaviour
{
    private LineRenderer lr;
   
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, new Vector3(hit.distance, 0, 0));
            }

            else
            {
                lr.SetPosition(1, new Vector3(50, 0, 0));
            }
        }
    }
}
