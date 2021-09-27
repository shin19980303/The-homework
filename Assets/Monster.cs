using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    [Range(0, 500)]
    public float attack = 100;
    [Range(0, 5000)]
    public float hp = 350;
    [Range(0, 50)]
    public float RangeTrack = 30;
    public Vector3 v3TrackingOffset;
    [Header("�����D��")]
    public GameObject dropitem;
    [Range(0, 1)]
    public float dropitemChance = 1;
    [Header("���ĸ��")]
    public AudioClip dropitemSound;
    public AudioClip HurtSound;
    public AudioClip attackSound;

    private AudioSource audioSource;
    private Rigidbody2D rigidbody2D_1;
    private Animator animator; 

}
