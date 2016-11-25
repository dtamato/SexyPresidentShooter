using UnityEngine;
using System.Collections;

public class FlipSprite : MonoBehaviour {

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
	
		spriteRenderer = this.GetComponentInChildren<SpriteRenderer> ();
		StartCoroutine (Flip ());
	}
	
	IEnumerator Flip () {

		yield return new WaitForSeconds(1);

		spriteRenderer.flipX = !spriteRenderer.flipX;

		StartCoroutine (Flip ());
	}
}
