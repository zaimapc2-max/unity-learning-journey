using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Trigger fired! Hit by: " + other.name);
		ScoreManager.instance.AddScore(10);
		gameObject.SetActive(false);
	}
}