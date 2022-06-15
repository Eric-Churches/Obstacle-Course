using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 9.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * (_speed * Time.deltaTime);
        float zValue = Input.GetAxis("Vertical") * (_speed * Time.deltaTime);
        transform.Translate(xValue,0, zValue);
    }
}
