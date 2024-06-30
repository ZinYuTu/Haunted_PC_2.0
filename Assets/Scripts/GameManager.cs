using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int clickGain = 1;
    [SerializeField] private int autoClickGain = 0;
    [SerializeField] private int upgradeClickCost = 10;
    [SerializeField] private int upgradeAutoClickCost = 50;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text upgradeClickCostText;
    [SerializeField] private Text upgradeAutoClickCostText;

    private void Start()
    {
        StartCoroutine(AutoClickCorutine());
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        upgradeClickCostText.text = upgradeClickCost.ToString();
        upgradeAutoClickCostText.text = upgradeAutoClickCost.ToString();
    }

    public void Click()
    {
        score += clickGain;
    }

    public void UpgradeClick()
    {
        if (score >= upgradeClickCost)
        {
            score -= upgradeClickCost;
            upgradeClickCost += 20;
            clickGain++;
        }
        else Debug.Log("Not enough points");
    }

    public void UpgradeAutoClick()
    {
        if (score >= upgradeAutoClickCost)
        {
            score -= upgradeAutoClickCost;
            upgradeAutoClickCost += 20;
            autoClickGain++;
        }
    }

    IEnumerator AutoClickCorutine()
    {
        while (true)
        {
            score += autoClickGain;
            yield return new WaitForSeconds(1);
        }
    }

    //void SaveLoad()
    //{
     //   int totalScore = PlayerPrefs.GetInt("score");
       // PlayerPrefs("score", totalScore + score);
    //}
}
