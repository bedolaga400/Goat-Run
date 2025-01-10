
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Destroy(gameObject);
    }
}
