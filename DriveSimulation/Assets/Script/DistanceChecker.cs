using UnityEngine;
using System.Collections;

public class DistanceChecker : MonoBehaviour
{
    public float theDistance;
    public static float points = 0;
    private bool ready = true;
    public float test;

    void Update()
    {
        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if(Physics.Raycast(transform.position, (forward), out hit)){
            theDistance = hit.distance;
        } else {
            theDistance = -1;
        }
        
        check(hit);
        if(theDistance < 1 && theDistance > 0 && Input.GetKeyDown(KeyCode.E) && hit.collider.tag == "CargoShip" && ready){  
            points += 2;
            ready = false;
            test = 0;
        }
        check(hit);
    }

    private void check(RaycastHit hit){
        if(!(hit.collider.tag == "CargoShip")){
            test++;
        }
        if(test > 250){
            ready = true;
        }
    }
    
}
