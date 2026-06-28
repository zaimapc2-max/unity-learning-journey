using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Player touched the obstacle!");
		gameObject.SetActive(false);
	}
}