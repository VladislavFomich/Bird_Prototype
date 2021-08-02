using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateColliders : MonoBehaviour
{
    public float rightX;
    public float lefttX;
    void Awake()
    {
        Camera camera = Camera.main;
        Vector2 lDCorner = camera.ViewportToWorldPoint(new Vector3(0, 0f, camera.nearClipPlane));
        Vector2 rUCorner = camera.ViewportToWorldPoint(new Vector3(1f, 1f, camera.nearClipPlane));
        Vector2[] colliderpoints;

        EdgeCollider2D leftEdge = new GameObject("LeftEdge").AddComponent<EdgeCollider2D>();
        leftEdge.gameObject.transform.SetParent(gameObject.transform);
        colliderpoints = leftEdge.points;
        colliderpoints[0] = new Vector2(lDCorner.x, lDCorner.y + 45);
        colliderpoints[1] = new Vector2(lDCorner.x, rUCorner.y - 30);
        leftEdge.points = colliderpoints;
        leftEdge.gameObject.layer = 6;
        lefttX = lDCorner.x;

        EdgeCollider2D rightEdge = new GameObject("RightEdge").AddComponent<EdgeCollider2D>();
        rightEdge.gameObject.transform.SetParent(gameObject.transform);
        colliderpoints = rightEdge.points;
        colliderpoints[0] = new Vector2(rUCorner.x, rUCorner.y - 30);
        colliderpoints[1] = new Vector2(rUCorner.x, lDCorner.y + 45);
        rightEdge.points = colliderpoints;
        rightEdge.gameObject.layer = 6;
        rightX = rightEdge.transform.position.x;

        EdgeCollider2D lowerEdge = new GameObject("LowerEdge").AddComponent<EdgeCollider2D>();
        lowerEdge.GetComponent<EdgeCollider2D>().isTrigger = true;
        lowerEdge.gameObject.transform.SetParent(gameObject.transform);
        colliderpoints = lowerEdge.points;
        colliderpoints[0] = new Vector2(lDCorner.x, lDCorner.y);
        colliderpoints[1] = new Vector2(rUCorner.x, lDCorner.y);
        lowerEdge.points = colliderpoints;
    }

   
}
