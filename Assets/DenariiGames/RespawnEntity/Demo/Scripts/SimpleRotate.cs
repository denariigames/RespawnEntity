/**
 * SimpleRotate
 * Author: Denarii Games
 * Version: 1.0
 *
 * Add component to prefab to rotate on Y axis.
 */

using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
	[SerializeField]
	private float rotateSpeed = 10f;

	void Update()
	{
		transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotateSpeed);
	}
}
