using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour
{
	public Canvas Overlay;
	public Canvas Menu;
	/// <summary>
	/// Game's main menu.
	/// </summary>
	private Scene MenuScene;
	/// <summary>
	/// Game's main scene.
	/// </summary>
	private Scene GameScene;
	/// <summary>
	/// Starts a new game.
	/// </summary>
	public void StartGame()
	{
		SceneManager.LoadSceneAsync(1);
		SceneManager.SetActiveScene(GameScene);
	}
	/// <summary>
	/// Continues current game.
	/// </summary>
	public void ContinueGame()
	{
		Time.timeScale = 1;
		Menu.gameObject.SetActive(false);
		Overlay.gameObject.SetActive(true);
	}
	/// <summary>
	/// Returns to main menu.
	/// </summary>
	public void Leave()
	{
		SceneManager.SetActiveScene(MenuScene);
		SceneManager.UnloadSceneAsync(GameScene);
	}
	/// <summary>
	/// Pauses the game.
	/// </summary>
	public void PauseGame()
	{
		Time.timeScale = 0;
		Overlay.gameObject.SetActive(false);
		Menu.gameObject.SetActive(true);
	}
	// Use this for initialization
	void Start () {
		MenuScene = SceneManager.GetSceneByBuildIndex(1);
		GameScene = SceneManager.GetSceneByBuildIndex(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
