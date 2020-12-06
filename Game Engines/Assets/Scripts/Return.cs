using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    public void QuitGameMenu()
    {

#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
