using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class OnOffTexture : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Floor1;
    public GameObject Floor2;

    public Material wall;
    public Material floor;
    public Material wall2;
    public Material floor2;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha8))
        {
            Wall1.GetComponent<MeshRenderer>().material = wall;
            Wall2.GetComponent<MeshRenderer>().material = wall;
            Wall3.GetComponent<MeshRenderer>().material = wall;
            Wall4.GetComponent<MeshRenderer>().material = wall;
            Floor1.GetComponent<MeshRenderer>().material = floor;
            Floor2.GetComponent<MeshRenderer>().material = floor;
          
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            Wall1.GetComponent<MeshRenderer>().material = wall2;
            Wall2.GetComponent<MeshRenderer>().material = wall2;
            Wall3.GetComponent<MeshRenderer>().material = wall2;
            Wall4.GetComponent<MeshRenderer>().material = wall2;
            Floor1.GetComponent<MeshRenderer>().material = floor2;
            Floor2.GetComponent<MeshRenderer>().material = floor2;
        }

    }
}
