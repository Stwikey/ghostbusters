using UnityEngine;

public class Objects : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 1;
    public float dist = 2f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, dist))
                {
                    health -= 1;
                }
            }
        }
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
 