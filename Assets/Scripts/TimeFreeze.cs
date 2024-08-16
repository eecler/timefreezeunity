using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreeze : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] private Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TogglePause();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            objwe();
        }
    }

    void TogglePause()
    {
        isPaused = true;
        if (isPaused)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    void objwe()
    {
        rb.isKinematic = false;
    }
}
