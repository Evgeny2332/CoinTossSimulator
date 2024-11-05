using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject buttonToss;
    [SerializeField] private Text resultText;

    private IEnumerator TossCoin()
    {
        resultText.text = "";
        animator.Play("Toss");
        buttonToss.SetActive(false);
        yield return new WaitForSeconds(1);
        int x = Random.Range(0, 2);
        if (x == 0) resultText.text = "Орел";
        else if (x == 1) resultText.text = "Решка";
        buttonToss.SetActive(true);
        animator.Play("New State");
    }

    public void StartToss()
    {
        StartCoroutine(TossCoin());
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
