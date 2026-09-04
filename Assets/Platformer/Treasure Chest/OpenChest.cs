using UnityEngine;

public class OpenChest : MonoBehaviour
{
    Animator animator;
    void Start() { animator = GetComponentInParent<Animator>(); }
    void OnTriggerEnter(Collider other) { animator.SetTrigger("OpenChest"); }
}
