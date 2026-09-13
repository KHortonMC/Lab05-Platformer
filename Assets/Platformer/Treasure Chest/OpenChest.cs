using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] Animator chest;
    [SerializeField] Animator coins1;
    [SerializeField] Animator coins2;
    void OnTriggerEnter(Collider other) { 
        chest.SetTrigger("OpenChest"); 
        coins1.SetTrigger("SpillCoins");
        coins2.SetTrigger("SpillCoins");
    }
}
