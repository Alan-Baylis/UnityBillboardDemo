using UnityEngine;
using System.Collections;

// Either drop this on a GameObject you want to billboard in the editor, or call
// BillboardToCamera.Billboard(this.transform); from other MonoBehaviours
public class BillboardToCamera : MonoBehaviour {

	void Update() {
		Billboard(transform);
	}

	public static void Billboard(Transform transform) {
		Transform cameraTransform = Camera.main.transform;
		transform.rotation = cameraTransform.rotation;
	}
}
