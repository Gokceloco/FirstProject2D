using UnityEngine;

public class Token : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);

        transform.position = Vector3.zero;
    }
}
