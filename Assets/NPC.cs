using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// NPC
/// �w�qNPC��k
/// </summary>
public class TEST2 : MonoBehaviour
{
    /// <summary>
    /// ��ܥ\��
    /// </summary>
    /// <param name="dioLogNpc"></param>
    private void Dialogue(string dioLogNpc)
    {

    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="itemMoney">�D�����</param>
    /// <returns></returns>
    public int BuyItem(int itemMoney = 100)//item price
    {
        return 0;
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="taskID">���Ƚs��</param>
    public void GetTask(int taskID)//Get Mission(int indexMission)
    {

    }
    /// <summary>
    /// ��s����
    /// </summary>
    /// <param name="taskItemnew">���ȹD��ƶq</param>
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
