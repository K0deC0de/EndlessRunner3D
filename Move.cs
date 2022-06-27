using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public float xVel = 0;
	public float yVel = 0;
	public float zVel = 0;
	
    // Start is called before the first frame update
    void Start()
    {
		xVel = 5;	
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("a")) && (GetComponent<Transform>().position.z >2))
		{
			zVel = -5;
			xVel = 5;
			GetComponent<Rigidbody>().angularVelocity = new Vector3(0,-2,0);
			StartCoroutine(stopRotationL());
		}
		     if((Input.GetKeyDown("d")) && (GetComponent<Transform>().position.z >2))
		{
			zVel = 5;
			xVel = 5;
			GetComponent<Rigidbody>().angularVelocity = new Vector3(0,-2,0);
			StartCoroutine(stopRotationR());
		}
		
		
		GetComponent<Rigidbody>().velocity = new Vector3(xVel, yVel, zVel);
    }
	IEnumerator stopRotationL()
	{
		yield return new WaitForSeconds (.8f);
		GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
		GetComponent<Transform>().eulerAngles = new Vector3(0,-90,0);
	}
	IEnumerator stopRotationR()
	{
		yield return new WaitForSeconds (.8f);
		GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
		GetComponent<Transform>().eulerAngles = new Vector3(0,90,0);
	}
}
