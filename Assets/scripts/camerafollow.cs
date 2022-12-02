using UnityEngine;

public class camerafollow : MonoBehaviour
{
    private GameObject hero;
    public float timeOffset;
    public Vector3 posOffset;

    private Vector3 velocity;

    void Update()
    {
        hero = GameObject.FindGameObjectWithTag("Player");
        transform.position = Vector3.SmoothDamp(transform.position, hero.transform.position + posOffset, ref velocity, timeOffset);
    }
}
