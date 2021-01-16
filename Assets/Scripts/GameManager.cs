using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject completeLevelUI;
	
    public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
		StartCoroutine(ChangePage());
	}
	
	public IEnumerator ChangePage()
	{
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
