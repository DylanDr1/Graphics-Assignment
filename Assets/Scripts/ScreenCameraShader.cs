using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScreenCameraShader : MonoBehaviour
{
    public Shader awesomeShader;
    public Material m_renderMaterial;
    public Material ColourGradeClean;
    public Material ColourGrade;
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, m_renderMaterial);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha6))
        {

            m_renderMaterial = ColourGradeClean;
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {

            m_renderMaterial = ColourGrade;
        }
    }
   
}