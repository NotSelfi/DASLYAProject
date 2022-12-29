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
		if(other.tag == "Player"){
        	Destroy(other.gameObject.GetComponent<MyCharacterController>());
        	Destroy(other.gameObject.GetComponent<Rigidbody>());
			//Destroy(this.gameObject);

        	textComponent.text = gameOverMessage;
        	textComponent.enabled = true;
        	StartCoroutine(WaitAndRestart());
		}
    }

    IEnumerator WaitAndRestart()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}