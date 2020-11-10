using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    // Start is called before the first frame update
    // Interpolate light color between two colors back and forth
    //float duration = 3.0f;
    //Color color0 = Color.red;
    //Color color1 = Color.green;

    //public Gradient gradient;
    Light lt;


    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color[] myColors;

    int colorIndex = 0;

    float t = 0f;

    int len;



    void Start()
    {
        lt = GetComponent<Light>();
        len = myColors.Length;
        lerpTime = 5;
    }

    void Update()
    {
        // set light color
        //float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(lt.color, myColors[colorIndex], lerpTime * Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > 0.9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= myColors.Length) ? 0 : colorIndex;
        }



        //float t = Mathf.Repeat(Time.time, duration) / duration;
        //lt.color = Color.AdvColorLerp(t, Color.red, Color.green, Color.blue, Color.yellow);
        //lt.color = gradient.evaluate(t);
    }
}
