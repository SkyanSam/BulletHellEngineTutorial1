using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
    }
}
