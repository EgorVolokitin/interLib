using UnityEngine;

public class MainCursor : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public Camera camera;

    // Use this for initialization
    void Start()
    {
        meshRenderer = this.gameObject.GetComponentInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(
                camera.transform.position,
                camera.transform.forward,
                out hitInfo,
                20.0f,
                Physics.DefaultRaycastLayers))
        {

            //if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        //{
            // If the raycast hit a hologram...
            // Display the cursor mesh.
            meshRenderer.enabled = true;

            // Move the cursor to the point where the raycast hit.
            this.transform.position = hitInfo.point;

            // Rotate the cursor to hug the surface of the hologram.
            this.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
        else
        {
            // If the raycast did not hit a hologram, hide the cursor mesh.
            meshRenderer.enabled = false;
        }
    }
}