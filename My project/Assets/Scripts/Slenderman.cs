using UnityEngine;

public class Slenderman : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float minx;
    public float minz;
    public float maxx;
    public float maxz;
    public float y;

    float timer;
    Vector3 pos;
    void Start()
    {
        pos = new Vector3(Random.Range(minx, maxx), y, Random.Range(minz, maxz));
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            timer = 0;
            pos = new Vector3(Random.Range(minx, maxx), y, Random.Range(minz, maxz));
            transform.position = pos;

        }

    }
}
