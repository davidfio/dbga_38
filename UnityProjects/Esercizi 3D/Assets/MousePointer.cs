using UnityEngine;
using System.Collections;

public class MousePointer : MonoBehaviour {

    Camera camera;

    public Color color = Color.magenta;

    void Awake()
    {
        camera = GetComponent<Camera>();
    }

	void Update ()
    {
        RaycastHit hit;
        Vector3 screenPos = Input.mousePosition;
        //Ray ray = camera.ScreenPointToRay(screenPos);

        Vector3 viewportPos = camera.ScreenToViewportPoint(screenPos);
        Ray ray = camera.ViewportPointToRay(viewportPos);
        Debug.Log(viewportPos);
        Debug.Log(screenPos);

        // Controlliamo se tocchiamo qualcosa
        if (Physics.Raycast(ray, out hit, 1000))
        {
            Debug.DrawLine(ray.origin, hit.point, color);
        }

	}

}
