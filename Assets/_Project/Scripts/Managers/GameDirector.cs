using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameDirector : MonoBehaviour
{
    public TokenManager tokenManager;

    private void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        tokenManager.RestartTokenManager();
    }

    internal void Clicked()
    {
        tokenManager.MoveTokenUp();
    }

}
