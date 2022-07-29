using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterScript : MonoBehaviour
{

	public GameObject asteroid;
	public float minDelay, maxDelay;

	private float nextLaunch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    	if (Time.time > nextLaunch)
    	{
    		nextLaunch = Time.time + Random.Range(minDelay, maxDelay);

    		float positionX = Random.Range(- transform.localScale.x/2, transform.localScale.x/2);

    		Vector3 newPosition = new Vector3 (positionX, transform.position.y, transform.position.z);

    		Instantiate(asteroid, newPosition, Quaternion.identity);


    	}

    }
}
