using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float movementSpeed;

	void Update()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		transform.position = new Vector3(
			transform.position.x + horizontal * Time.deltaTime * movementSpeed * 5,
			transform.position.y + vertical * Time.deltaTime * movementSpeed * 5, 
			transform.position.z
		);
	}
}
