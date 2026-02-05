using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public BallManager ballManager;

    private void Start()
    {
        RestartLevel();
    }

    void RestartLevel()
    {
          ballManager.RestartBallManager(); 
    }
}
