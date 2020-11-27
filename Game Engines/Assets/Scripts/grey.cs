using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class grey : MonoBehaviour
{
    public Material effect;

  private void OnRenderImage(RenderTexture source, RenderTexture destination)
  {
    if(!effect)
    {
       Graphics.Blit(source, destination);
      return;
    }
    Graphics.Blit(source, destination, effect);
  }

}
