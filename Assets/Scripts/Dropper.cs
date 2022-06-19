using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer _renderer;
    private Rigidbody _rigidbody;
    
    [SerializeField] private float timeToWait = 5f;
    

    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();

        _renderer.enabled = false;
        _rigidbody = GetComponent<Rigidbody>();

        _rigidbody.useGravity = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("three seconds have  elapse");
        }
    }
}
