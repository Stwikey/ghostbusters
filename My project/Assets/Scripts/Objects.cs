using UnityEngine;

public class Objects : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {
            Debug.Log("touched");
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 1f);
                RaycastHit hit;

                Debug.Log("phase begin");

                if (Physics.Raycast(ray, out hit))
                {
                    Destroy(gameObject);
                }
            }
        }
        
    }
}
 