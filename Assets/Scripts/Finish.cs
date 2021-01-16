using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
	public GameManager gameManager;
	
    void OnTriggerEnter2D(Collider2D collision)
	{
		gameManager.CompleteLevel();
	}
}
