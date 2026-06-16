using UnityEngine;

public class CamRotateOnDrag : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float zoomSpeed = 5f;

    [SerializeField]
    private float minDistance = 3f;

    [SerializeField]
    private float maxDistance = 15f;

    private Vector3 lastMousePosition;
    private bool dragging = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragging = true;
            lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
        if (dragging)
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;

            transform.RotateAround(Vector3.zero, Vector3.up, -delta.x * speed * Time.deltaTime);
            transform.RotateAround(Vector3.zero, transform.right, delta.y * speed * Time.deltaTime);

            lastMousePosition = Input.mousePosition;
        }

        float scroll = Input.mouseScrollDelta.y;
        if (Mathf.Abs(scroll) > 0.01f)
        {
            float currentDistance = transform.position.magnitude;
            float targetDistance = Mathf.Clamp(
                currentDistance - scroll * zoomSpeed,
                minDistance,
                maxDistance);

            transform.position = transform.position.normalized * targetDistance;
        }
    }
}
