using UnityEngine;

public class TokenManager : MonoBehaviour
{
    public Token tokenPrefab;
    
    private Token _curToken;

    public void RestartTokenManager()
    {
        DestroyOldToken();
        CreateNewToken();
    }

    internal void MoveTokenUp()
    {
        _curToken.transform.position += Vector3.up;
    }

    private void CreateNewToken()
    {
        _curToken = Instantiate(tokenPrefab);
        _curToken.transform.position = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
    }

    private void DestroyOldToken()
    {
        if (_curToken != null)
        {
            Destroy(_curToken.gameObject);
        }
    }
}
