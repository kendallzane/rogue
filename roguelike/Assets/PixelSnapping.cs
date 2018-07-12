using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelSnapping : MonoBehaviour {

    [SerializeField]
    private int pixelsPerUnit = 16;

    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
    }
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 newLocalPosition = new Vector3(0f, 0f, 0f);
		newLocalPosition.x = (Mathf.Round(parent.position.x * pixelsPerUnit) / pixelsPerUnit) - parent.position.x;
		newLocalPosition.y = (Mathf.Round(parent.position.y * pixelsPerUnit) / pixelsPerUnit) - parent.position.y;
		transform.localPosition = newLocalPosition;
	}
}
