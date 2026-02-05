using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallManager : MonoBehaviour
{
    public List<Ball> balls = new List<Ball>();

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            var tempList = new List<Ball>(balls);
            foreach (var b in tempList)
            {
                var newBall = Instantiate(b);
                balls.Add(newBall);
            }
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            foreach (var b in balls)
            {
                Destroy(b.gameObject);
            }
            balls.Clear();
        }
    }
}
