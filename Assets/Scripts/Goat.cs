
using UnityEngine;

public class Goat : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Gamemanager.instance.Lose();
    }
    
}
