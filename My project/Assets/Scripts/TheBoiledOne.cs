using UnityEngine;

public class TheBoiledOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("hi");
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
