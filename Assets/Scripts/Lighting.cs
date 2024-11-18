using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public GameObject cube;
    public Material Basic;
    public Material specular;
    public Material specularAmb;
    public GameObject Particles;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            this.GetComponent<Light>().enabled = false;
            cube.GetComponent<MeshRenderer>().material = Basic;
            Particles.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            this.GetComponent<Light>().enabled = true;
            cube.GetComponent<MeshRenderer>().material = Basic;
            Particles.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cube.GetComponent<MeshRenderer>().material = specular;
            this.GetComponent<Light>().enabled = true;
            Particles.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            cube.GetComponent<MeshRenderer>().material = specularAmb;
            this.GetComponent<Light>().enabled = true;
            Particles.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            cube.GetComponent<MeshRenderer>().material = specularAmb;
            this.GetComponent<Light>().enabled = true;
            Particles.SetActive(true);
        }

    }
}