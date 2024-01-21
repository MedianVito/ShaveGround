using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
	public int sceneNumber;

	public void NextLevel()
	{
		SceneManager.LoadScene(sceneNumber);
	}
}
