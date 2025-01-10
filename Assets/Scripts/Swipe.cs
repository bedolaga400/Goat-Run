using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
public class Swipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Transform Square;
    public Transform leftBoundary;
    public Transform rightBoundary;
    public float moveSpeed = 5f;

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = Square.position;
    }

    private void Update()
    {
        Square.position = Vector3.MoveTowards(Square.position, targetPosition, moveSpeed);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            Vector3 newPosition = Square.position;

            if (eventData.delta.x > 0)
            {
                newPosition += Vector3.right;
            }
            else
            {
                newPosition += Vector3.left;
            }

            if (newPosition.x < leftBoundary.position.x)
            {
                newPosition.x = leftBoundary.position.x;
            }
            else if (newPosition.x > rightBoundary.position.x)
            {
                newPosition.x = rightBoundary.position.x;
            }

            targetPosition = newPosition;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }
}

