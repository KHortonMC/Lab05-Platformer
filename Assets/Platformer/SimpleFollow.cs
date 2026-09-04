using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
    [SerializeField] GameObject follow;
    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = follow.transform.position + offset;
    }
}
