using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class WaterChanger : MonoBehaviour
{
    public GameObject Water;
    public Material WaterTexture;
    public Material basic;
    public FlareLayer Lens;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Minus))
        {
            Water.GetComponent<MeshRenderer>().material = WaterTexture;

        }
        if (Input.GetKey(KeyCode.Equals))
        {
            Water.GetComponent<MeshRenderer>().material = basic;
 
        }

        if (Input.GetKey(KeyCode.LeftBracket))
        {
            Lens.enabled = true;

        }

        if (Input.GetKey(KeyCode.RightBracket))
        {
            Lens.enabled = false;

        }

    }
    
}