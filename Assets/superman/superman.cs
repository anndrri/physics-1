using UnityEngine;

public class superman : MonoBehaviour
{
    public float velocity;

    void FixedUpdate()
    {
        transform.Translate(0.1f, 0, 0);
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.layer == 6 /*&& collision.rigidbody*/)
        {
            Debug.Log("bad guy");
            Vector3 direction = collision.transform.position - transform.position /*+ new Vector3(0,1)*/;
            Debug.Log(direction);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * velocity, ForceMode.Impulse);
        }
        if (collision.gameObject.layer == 7)
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>());
        }
    }
}
