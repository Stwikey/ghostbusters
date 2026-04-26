using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> hallucinations = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < hallucinations.Count; i++)
        {
            if(hallucinations[i] != null)
            {
                break;
            }
            if(hallucinations == null && i == hallucinations.Count - 1)
            {
                Debug.Log("finished");
            }
        }
    }
}
