using UnityEngine;
using System.Collections;

public class RenderLine : MonoBehaviour {
    // Use this for initialization
    bool clicked = false;
    LineRenderer lineRenderer; 
    void Start () {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetColors(Color.red, Color.yellow);
        lineRenderer.SetWidth(5.0f, 5.0f);

    }
    void Update()
    {
        if (clicked && GameManager.turn % 2 == 1 && tag == "Red")
        {
            Vector3 scrSpace = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 offset = new Vector3(scrSpace.x - Input.mousePosition.x, 0, scrSpace.y - Input.mousePosition.y);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position + offset);
        }
        if(clicked && GameManager.turn % 2 == 0 && tag == "Blue") {
                Vector3 scrSpace = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 offset = new Vector3(scrSpace.x - Input.mousePosition.x, 0, scrSpace.y - Input.mousePosition.y);
                lineRenderer.SetPosition(0, transform.position);
                lineRenderer.SetPosition(1, transform.position - offset);
        }
    }
    void OnMouseDown() {
        clicked = true;
    }
    void OnMouseUp() {
        clicked = false;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position);
    }
}
