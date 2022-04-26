using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    public GameObject sphere;
    float x = 0f;
    float y = 0f;

    void Awake()
    {
        float inc = 0.2f;
        float half = (int)(length / 2);
        float size = 0f;
        for (int i = 0; i < length; i++)
        {
            GameObject s = GameObject.Instantiate<GameObject>(sphere);
            s.transform.SetParent(this.transform);
            s.AddComponent<NoiseWander>();
            s.AddComponent<ObstacleAvoidance>();
            if (i < half)
            {
                size = inc * (i + 1);
                s.transform.localScale = new Vector3(size, size, size);
                s.transform.position = new Vector3((x + s.transform.localScale.x / 2), y, 0);
            }
            else
            {
                size = inc * (length - i);
                s.transform.localScale = new Vector3(size, size, size);
                s.transform.position = new Vector3((x + s.transform.localScale.x / 2), y, 0);
            }
            x = x + 1 + (s.transform.localScale.x / 2);

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
