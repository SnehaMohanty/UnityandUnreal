﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multicolors : MonoBehaviour
{

    MeshRenderer cubeMeshrenderer;

    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color[] myColors;

    int colorIndex = 0;

    float t = 0f;

    int len;

    


    // Start is called before the first frame update
    void Start()
    {
        cubeMeshrenderer = GetComponent<MeshRenderer>();
        len = myColors.Length;
        lerpTime = 5;


    }

    // Update is called once per frame
    void Update()
    {

        cubeMeshrenderer.material.color = Color.Lerp(cubeMeshrenderer.material.color,myColors[colorIndex], lerpTime*Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > 0.9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= myColors.Length) ? 0 : colorIndex;
        }
    
    }
}
