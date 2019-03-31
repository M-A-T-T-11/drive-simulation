using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(CharacterController))]
public class RobotMovement : MonoBehaviour
{
    public CharacterController controller;
    public float Speed = 3.0f;
    public float RotateSpeed = 3.0f;
    private float curSpeed = 0f;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (transform != null)
        {
            
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            curSpeed = Speed * Input.GetAxis("LeftJoystickY");
            if(Input.GetAxis("LeftJoystickY") < 0){
                transform.Rotate(0, -Input.GetAxis("RightJoystickX") * RotateSpeed, 0);
            } else{
                transform.Rotate(0, Input.GetAxis("RightJoystickX") * RotateSpeed, 0);
            }
            controller.SimpleMove(forward * curSpeed);
        }
    }
}