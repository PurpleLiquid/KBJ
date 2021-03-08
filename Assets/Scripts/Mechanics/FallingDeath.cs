using System.Collections;
using UnityEngine;

public class FallingDeath : MonoBehaviour
{
    private string deathScreen = "Dead End";
    [SerializeField] LevelChanger fadeUI;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowDeathScreen());
    }

    private IEnumerator ShowDeathScreen()
    {
        fadeUI.setNextScene(deathScreen);
        fadeUI.Fade();

        yield return new WaitForSeconds(2);
        fadeUI.PlayNextScene();
    }
}
