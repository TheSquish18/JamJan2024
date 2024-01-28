using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantStorgae : MonoBehaviour
{

    public static int octopusTentacleCheck = 0; //win if tentacleCheck = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(octopusTentacleCheck);
    }
}
