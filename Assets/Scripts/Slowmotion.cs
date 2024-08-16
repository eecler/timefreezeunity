using UnityEngine;
using UnityEngine.UI;

public class Slowmotion : MonoBehaviour
{
    public float slowMotionScale = 0.1f; 
    private bool isSlowMotion = false;

    [SerializeField] private Text text;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleSlowMotion();
        }
    }

    private void ToggleSlowMotion()
    {
        isSlowMotion = !isSlowMotion;
        text.text = "Slowmo is enabled";
        Time.timeScale = isSlowMotion ? slowMotionScale : 1.0f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale; 
    }
}
