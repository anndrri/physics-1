using UnityEngine;

public class ZeroGravityTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
    public void OnTriggerExit(Collider collider)
    {
        collider.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
