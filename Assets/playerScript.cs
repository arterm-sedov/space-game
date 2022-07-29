using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public GameObject lazerShot;
    public Transform lazerGun;
    public float delay;

	public float speed;
	public float tilt;
	public float xMin, xMax, zMin, zMax;

    private float nextShot;

	Rigidbody player;

    // Start is called before the first frame update
    void Start()
    {
        // код при первом кадре / старте игры
        player = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // код на каждый кадр

        float moveHorizontal = Input.GetAxis("Horizontal"); //left/right
        float moveVertical = Input.GetAxis("Vertical"); //up/down

        player.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed;

        player.rotation = Quaternion.Euler(player.velocity.z*tilt, 0*tilt, -player.velocity.x*tilt);

        float positionX = Mathf.Clamp(player.position.x, xMin, xMax);
		float positionZ = Mathf.Clamp(player.position.z, zMin, zMax);

		player.position = new Vector3(positionX, 0, positionZ);

        if (Input.GetButton("Fire1") && Time.time > nextShot)
        {
        Instantiate(lazerShot, lazerGun.position, Quaternion.identity);    
        nextShot = Time.time+delay;
        }

    }
}
