using System.Collections;
using UnityEngine;

public class LaserSettings : MonoBehaviour
{
    public GameObject sensorEdge;
    
    void Laser()
    {
        RaycastHit hit;
        if (Physics.Raycast(sensorEdge.transform.position, sensorEdge.transform.forward, out hit))
        {
            if(hit.collider.tag == "Player")
            {
                print("Hit : " + hit.collider.gameObject.name);
            }
        }
    }
}
