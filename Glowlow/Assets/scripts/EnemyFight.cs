using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFight : MonoBehaviour {

	public float punchImpact;
	private GameObject player;
	private PlayerEnergy pe;
    

    void Start(){

        
        
        
        player = GameObject.FindGameObjectsWithTag("Player")[0];
		pe = (PlayerEnergy) player.GetComponent(typeof(PlayerEnergy));
	}


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.Equals(player))
		{
            
            
            pe.LooseEnergy (punchImpact);
		}
	}
}
