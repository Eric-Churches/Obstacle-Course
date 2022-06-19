
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int _hits;
    // Start is called before the first frame update
    
    private void OnCollisionEnter(Collision other)
    {
        _hits++;
        Debug.Log("You have bumped into the wall this many times: " + _hits);
    }
}
