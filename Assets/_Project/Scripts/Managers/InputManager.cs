using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public GameDirector gameDirector;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //gameDirector.Clicked();
        }
    }
}
