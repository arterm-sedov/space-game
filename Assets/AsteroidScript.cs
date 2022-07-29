using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{

	public float rotation;
	public float minSpeed, maxSpeed;

	public GameObject playerExplosion;
	public GameObject asteroidExplosion;

    // Start is called before the first frame update
    void Start()
    {
     
    	Rigidbody asteroid = GetComponent<Rigidbody>();
    	asteroid.angularVelocity = Random.insideUnitSphere*rotation;
    	asteroid.velocity = Vector3.back * Random.Range(minSpeed, maxSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other)
   {

   	if (other.tag == "Asteroid" || other.tag == "GameBoundary")
   	{
   		return;
   	}
   	Instantiate(asteroidExplosion, transform.position, Quaternion.identity);

   	if (other.tag == "Player")
   	{
	Instantiate(playerExplosion, other.transform.position, Quaternion.identity);   		
   	}
   else
        {
            GameSscript.instance.increaseScore(10);
        }
    
   	Destroy(gameObject);
   	Destroy(other.gameObject);
   }

}
