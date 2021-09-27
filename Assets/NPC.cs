using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// NPC
/// 定義NPC方法
/// </summary>
public class TEST2 : MonoBehaviour
{
    /// <summary>
    /// 對話功能
    /// </summary>
    /// <param name="dioLogNpc"></param>
    private void Dialogue(string dioLogNpc)
    {

    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="itemMoney">道具價格</param>
    /// <returns></returns>
    public int BuyItem(int itemMoney = 100)//item price
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="taskID">任務編號</param>
    public void GetTask(int taskID)//Get Mission(int indexMission)
    {

    }
    /// <summary>
    /// 更新任務
    /// </summary>
    /// <param name="taskItemnew">任務道具數量</param>
    /// <returns></returns>
    private int Tasknew(int taskItemnew = 1)
    {
        return 0;
    }

    private bool TaskEnd(int taskID)
    {
        return false;
    }
}
