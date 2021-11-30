using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    BoxCollider2D boxCollider2D;


    private void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (boxCollider2D.IsTouchingLayers(LayerMask.GetMask("Level")))
        {
            SceneManager.LoadScene(0);
        }
    }
}
