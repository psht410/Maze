using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate ()
    {  
        rigid.velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}
}
