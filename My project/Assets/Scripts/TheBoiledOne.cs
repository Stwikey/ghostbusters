using UnityEngine;

public class TheBoiledOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject scare;
    Camera cam;
    Vector3 camPos;
    void Start()
    {
        cam = Camera.main;
        camPos = cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        Vector3 spawnPos = Camera.main.transform.position + Camera.main.transform.forward * 2f;
        Instantiate(scare, spawnPos, Quaternion.identity);    
    }
}
