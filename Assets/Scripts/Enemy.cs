using UnityEngine; 

public class Enemy : MonoBehaviour 
{ 
    public float speed; 


    void Update()  
    { 
        transform.Translate(Vector2.down * speed * Time.deltaTime); 
    }
    public void IncreaseSpeed()
    {
        speed += 0.1f;
    }

}
