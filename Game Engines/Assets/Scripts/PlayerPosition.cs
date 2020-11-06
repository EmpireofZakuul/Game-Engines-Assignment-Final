using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    #region Singleton

    public static PlayerPosition instance;

    void OnEnable()
    {
        instance = this;
    }
    #endregion

    public GameObject player;
}

