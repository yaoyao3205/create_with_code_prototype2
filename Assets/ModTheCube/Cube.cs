using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 3);
        transform.localScale = Vector3.one * 1.8f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.2f, 1.0f, 0.8f, 0.2f);
    }
    
    void Update()
    {
        transform.Rotate(12.0f * Time.deltaTime, 5.0f, 5.0f);
    }
}
