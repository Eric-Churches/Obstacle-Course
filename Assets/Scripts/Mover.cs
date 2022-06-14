using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.02f;
    [SerializeField] float zValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Update(zValue);
    }

    // Update is called once per frame
    void Update(float zValue)
    {
        transform.Translate(xValue,yValue, zValue);
    }
}
