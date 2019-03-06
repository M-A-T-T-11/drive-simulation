using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    Vector3 movementVector;
    public float speed = 8;
    public CharacterController controller;
    private float gravity = 40;
    private float jumpPower = 15;
    private float xInput;
    private float xPos;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        movementVector.z = Input.GetAxis("LeftJoystickY") * speed;
        xInput = Input.GetAxis("LeftJoystickX") * speed;
        Debug.Log(xInput + "free");
        movementVector.x = xInput * speed * -1;
        xPos = movementVector.x;
	Debug.Log(xPos);
	Debug.Log(xInput);

        if (controller.isGrounded)
        {
            movementVector.y = 0;
        }
        controller.Move(movementVector * Time.deltaTime);
    }

    /*void FixedUpdate()
    {
        movementVector.y -= gravity * Time.deltaTime;
        Debug.Log(xInput + "fixed");
        controller.Move(movementVector * Time.deltaTime);
    }*/

}

