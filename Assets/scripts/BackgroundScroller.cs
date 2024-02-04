using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = -0.2f;
    private MeshRenderer m_Renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Renderer.material.mainTextureOffset = new Vector2(Time.time * speed, Time.time * speed);
    }
}
