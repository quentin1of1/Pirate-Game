using UnityEngine;
using System.Collections;
public class TempCameraMove : MonoBehaviour {
	public float speed = 200;
	public float rotateSpeed = 40;

     public GameObject projectile;
    GameObject sp;
        float fireRate = 0.1f;
    float HeightLimit = 60;
    private float nextFire = 0.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		transform.Translate(Vector3.forward*speed*Time.deltaTime,Space.Self);
		if(Input.GetKey("w")){
			transform.Translate(Vector3.forward*speed*Time.deltaTime,Space.Self);
		}
		
		if(Input.GetKey("s")){
			transform.Translate(Vector3.back*speed*Time.deltaTime,Space.Self);
		}
		
		if(Input.GetKey("a")){
			transform.Translate(Vector3.left*speed*Time.deltaTime,Space.Self);
		}
		
		if(Input.GetKey("d")){
			transform.Translate(Vector3.right*speed*Time.deltaTime,Space.Self);
		}
		
		
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Rotate(Vector3.left*rotateSpeed*Time.deltaTime,Space.Self);
		}
		
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Rotate(Vector3.right*rotateSpeed*Time.deltaTime,Space.Self);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(Vector3.down*rotateSpeed*Time.deltaTime,Space.World);
			
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime,Space.World);
		}
 if(Input.GetKey("q") && Time.time > nextFire)  {
         nextFire = Time.time + fireRate;
         // Instantiate the projectile at the position and rotation of this transform
            GameObject clone = (GameObject)Instantiate(projectile, transform.position, transform.rotation);


    clone.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0.5f, 1)*20000);;
     }




    }
}
