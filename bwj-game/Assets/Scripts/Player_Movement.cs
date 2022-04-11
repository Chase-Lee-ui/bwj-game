using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public float playerSpeed = 10f;
    private Rigidbody2D rb;
    public float xDirection;
    public float yDirection;
    public AudioSource Vroom;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical"); 

        Vector3 Movement = new Vector3(xDirection, yDirection, 0f);
        transform.position += Movement * Time.deltaTime * playerSpeed;

        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
         diff.Normalize();
 
         float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
         transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        if(xDirection == 0 && yDirection == 0)
        {
            Vroom.mute = true;
        }
        else
        {
            Vroom.mute = false;
        }
    }
}
