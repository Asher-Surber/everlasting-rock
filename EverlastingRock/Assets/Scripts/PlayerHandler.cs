using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHandler : MonoBehaviour
{
    public GameObject haveKeyText;
    public GameObject winZone;
    public TextMeshProUGUI hpText;
    public GameObject findKeyText;
    private int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        haveKeyText.SetActive(false);
        findKeyText.SetActive(true);
        winZone.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Angel")) {
            hp -= 1;
            hpText.text = "HP: " + hp;
            if (hp == 0)
            {
                SceneManager.LoadScene("Assets/Scenes/GameOver.unity");
                Scene gameOver = SceneManager.GetSceneByPath("Assets/Scenes/GameOver.unity");
                SceneManager.SetActiveScene(gameOver);
            }

        }

        if (other.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            findKeyText.SetActive(false);
            haveKeyText.gameObject.SetActive(true);
            winZone.SetActive(true);
        }

        if (other.CompareTag("WinZone"))
        {
            SceneManager.LoadScene("Assets/Scenes/Win.unity");
            Scene win = SceneManager.GetSceneByPath("Assets/Scenes/Win.unity");
            SceneManager.SetActiveScene(win);
        }
    }
}
