using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyPlayerInput : MonoBehaviour
{



	// Basic example using PlayerInput class with SendMessages
	public void OnJump(InputValue value)
	{

			Debug.Log("value is = " + value.isPressed);

	}


	// Basic example using PlayerInput for InvokeUnityEvent
    public void Jump(InputAction.CallbackContext context)
    {
        
		if (context.performed)
        {
			Debug.Log("Jump!");
		}

		Debug.Log("Context value is = " +  context.ReadValue<float>());
		



		//context.interaction

	}



}
