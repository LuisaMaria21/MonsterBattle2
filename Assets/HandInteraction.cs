using UnityEngine;
using System.Collections;

public class HandInteraction : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		this.transform.gameObject.SetActive(false);
	}
}
