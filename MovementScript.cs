
using UnityEngine;

public class MovementScript : MonoBehaviour
{    

    public Rigidbody rb;
 
        public float forwardForce=2000f;  
        public float sidewaysForce=2000f; 
    // Update is called once per frame
  
    void Update()
    {
         rb.AddForce(0,0,forwardForce*Time.deltaTime);

         if (Input.GetKey("d")){
                 rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
         }
         
         if (Input.GetKey("a")){
                 rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
         }
                
                if (rb.position.y< -1f){
                     FindObjectOfType<GameManager>().EndGame();
                }
    }
}
