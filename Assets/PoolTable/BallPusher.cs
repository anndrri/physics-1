using UnityEngine;

public class BallPusher : MonoBehaviour
{
    //4 balls in the pool
    //x=0
    //z=15
    public float forceX; 
    public float forceZ; 
    public void OnButton()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(1*forceX, 0, 1*forceZ, ForceMode.Impulse);
    }
}
