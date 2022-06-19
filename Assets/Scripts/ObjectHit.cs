
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter()
    {
        
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
