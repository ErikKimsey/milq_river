using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDeformerInput : MonoBehaviour
{
      public float force = 10f;
      public float forceOffset = 0.1f;

    void HandleInput () {
      Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;

      if (Physics.Raycast(inputRay, out hit)) {
        MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();
        if (deformer) {
          Vector3 point = hit.point;
          deformer.AddDeformingForce(point, force);
        }
      }
    }
    void Start()
    {
      // HandleInput();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButton(0)) {
          HandleInput();
        }
    }
}
