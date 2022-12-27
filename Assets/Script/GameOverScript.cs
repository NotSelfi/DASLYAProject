using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string gameOverMessage;
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject.GetComponent<MyCharacterController>());
        Destroy(other.gameObject.GetComponent<Rigidbody>());

        textComponent.text = gameOverMessage;
        textComponent.enabled = true;
        StartCoroutine(WaitAndRestart());
    }

    IEnumerator WaitAndRestart()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
}