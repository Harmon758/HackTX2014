using UnityEngine;
using System.Collections;

public class Myo_Functions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Myo game object to connect with.
	// This object must have a ThalmicMyo script attached.
	public GameObject myo = null;
	
	// Update is called once per frame
	void Update () {
		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		if(thalmicMyo.pose == Thalmic.Myo.Pose.Fist){
			print("Test");
		}
		rigidbody.AddForce(19 * thalmicMyo.accelerometer.x * rigidbody.mass, 19 * thalmicMyo.accelerometer.z * rigidbody.mass, 19 * thalmicMyo.accelerometer.y * rigidbody.mass);
	}
}
