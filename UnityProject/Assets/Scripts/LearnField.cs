
using UnityEngine;

public class LearnField : MonoBehaviour
{//定義欄位:
//語法:欄位類型 名稱  結束(指定值)
//int 整數                   預設為0
//float 浮點數               預設為0
//string 字串                預設為"空值"
//bool 布林植(true or false) 預設為false
    #region  屬性(變數)
    //整數 等級
    //修飾詞 公開public  私人(預設)
   
    [Header("玩家等級"),Range(1,99)]
    public int Lv=1;
    //提示欄位功能
    [Tooltip("玩家移動速度")]
    //限制欄位範圍(int,float))
    [Range(0.1f,1.5f)]
    public float Speed=1.5f;
    public string Name="111";
    public bool Missson = true;
    #endregion

    #region  事件
    #endregion

    #region  方法
    #endregion
}
