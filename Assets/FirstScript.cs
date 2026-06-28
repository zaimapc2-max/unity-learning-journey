using UnityEngine;

public class FirstScript : MonoBehaviour
{
	public float speed = 5f;

	void Update()
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveX, moveY, 0f);
		transform.Translate(movement * speed * Time.deltaTime);
	}
}