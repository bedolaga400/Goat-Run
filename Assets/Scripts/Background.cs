
using UnityEngine; 

public class Background : MonoBehaviour 
{ 
    public float speed; 
    public GameObject teleportRoad; 
    public float roadLength; 
    public int roadCount; 

    void Update() 
    { 
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
        if (transform.position.y < teleportRoad.transform.position.y) 
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y + roadLength * roadCount, transform.position.z); 
        } 
    } 

}

