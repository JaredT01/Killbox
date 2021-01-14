using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    Vector3 spawn;
    Quaternion rotate;


    void Start()
    {
        spawn = gameObject.transform.position;
        rotate = gameObject.transform.rotation;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Killbox")
        {
            Debug.Log("TRIGGERED!");
            this.transform.position = spawn;
            this.transform.rotation = rotate;
            
        }
    }
}
