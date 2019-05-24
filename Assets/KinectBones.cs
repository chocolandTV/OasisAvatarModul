using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinectBones : MonoBehaviour
{
    public List<GameObject> Lolabunny = new List<GameObject>();
    public List<GameObject> KinectSensor = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Lolabunny.Count; i++)
        {
            Lolabunny[i].transform.rotation=KinectSensor[i].transform.rotation;
        }
    }
}
