using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{
    public GameObject haveKeyText;
    //public bool canWin;
    public GameObject winZone;

    // Start is called before the first frame update
    void Start()
    {
        haveKeyText.SetActive(false);
        //canWin = false;
        winZone.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Angel")) {
            SceneManager.LoadSceneAsync("Assets/Scenes/GameOver.unity");
            Scene gameOver = SceneManager.GetSceneByPath("Assets/Scenes/GameOver.unity");
            SceneManager.SetActiveScene(gameOver);

        }

        if (other.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            haveKeyText.gameObject.SetActive(true);
            //canWin = true;
            winZone.SetActive(true);
        }

        if (other.CompareTag("WinZone"))
        {
            SceneManager.LoadSceneAsync("Assets/Scenes/Win.unity");
            Scene win = SceneManager.GetSceneByPath("Assets/Scenes/Win.unity");
            SceneManager.SetActiveScene(win);
        }
    }
}
