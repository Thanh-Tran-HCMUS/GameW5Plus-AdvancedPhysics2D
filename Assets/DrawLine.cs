﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    
    private LineRenderer line;

    // Use this for initialization
    void Start()
    {
        // Add a Line Renderer to the GameObject
        line = this.gameObject.AddComponent<LineRenderer>();
        // Set the width of the Line Renderer
        //line.SetWidth(0.05F, 0.05F);
        line.startWidth = 0.05f;
        line.endWidth = 0.05f;

        line.positionCount = 2;
        // Set the number of vertex fo the Line Renderer
        //line.SetVertexCount(2);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the GameObjects are not null
        if (gameObject1 != null && gameObject2 != null)
        {

            // Update position of the two vertex of the Line Renderer
            line.SetPosition(0, gameObject1.transform.position);
            line.SetPosition(1, gameObject2.transform.position);
        }
    }
}
