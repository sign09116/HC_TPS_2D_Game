
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region  屬性
    [Header("目前分數")]
    public int Score;
    [Header("分數文字")]
    public GameObject ScoreText;
    [Header("最高分數")]
    public int HighScore;
    [Header("水管物件")]
    public GameObject PipeObj;
    [Header("加分區域物件")]
    public GameObject AddScoreObj;
    #endregion

    #region  事件
    #endregion

    #region  方法
    /// <summary>
    /// 最高分數
    /// </summary>
    void FinalScore()
    {

    }
    /// <summary>
    /// 生成水管
    /// </summary>
    void CreateWaterpipe()
    {

    }
    /// <summary>
    /// 加分
    /// </summary>
    public void AddScore()
    {
        Score++;
        ScoreText.GetComponent<Text>().text = Score.ToString();

    }
    /// <summary>
    /// 遊戲失敗
    /// </summary>
    public void GameOver()
    {

    }
    /// <summary>
    /// 遊戲過關
    /// </summary>
    void GameClear()
    {

    }
    #endregion
}
