using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doNOTDestroymusic : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
