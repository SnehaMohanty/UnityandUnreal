using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update

    public Material nMaterial;
  
    public void setColorToBlack()
    {
        nMaterial.SetColor("_Color", Color.black);
    }

    public void setColorToWhite()
    {
        nMaterial.SetColor("_Color", Color.white);
    }

    public void setColorToRed()
    {
        nMaterial.SetColor("_Color", Color.red);
    }

    public void setColorToGreen()
    {
        nMaterial.SetColor("_Color", Color.green);
    }
}
