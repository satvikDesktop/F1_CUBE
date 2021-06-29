using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public MovementScript movement;
    
    public void end () {
             FindObjectOfType<GameManager>().EndGame();
    }
   public void OnCollisionEnter (Collision collisioninfo)
    {
       if(collisioninfo.collider.tag=="Obstacles"){
              movement.enabled= false;
        
              Invoke("end",1);
       }
    }
    
            
    
}
