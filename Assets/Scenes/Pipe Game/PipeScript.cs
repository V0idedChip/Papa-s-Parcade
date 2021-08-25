using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    public int curRot = 0;

    public float[] correctRotations;
    public bool isPlaced = false;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public AudioClip Powerup14;
    private AudioSource audioSource;

    private void Start()
    {
        //Rather than tracking the euler angle, we track our location in the rotations list
        //ie curRot = 3 means that the rotation we are at is 270 in the rotations list
        curRot = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[curRot]);

        RotationCheck();

        audioSource = gameObject.GetComponent<AudioSource>();

    }

    private void OnMouseDown()
    {


        //Rotate the object, we don't pay attention to its euler angle
        transform.Rotate(new Vector3(0, 0, 90));
        //Increase the current rotation to reference the approprate rotation in the rotations list
        curRot++;
        //If the current rotation is outside the rotation list, then we're at 0 again
        if(curRot >= rotations.Length)
        {
            curRot = 0;
        }
        RotationCheck();

        audioSource.clip = Powerup14;
        Debug.Log("skrrt");
        audioSource.Play();
    }

    //This function returns a boolean
    private bool IsCorrectRotation()
    {
        //IsCorrectRotation goes through each rotation in the CorrectRotations list as entered from the inspector
        //If the rotation we are currently looking at (as per curRot) matches a rotation in the list from the inspector, it returns true
        //Otherwise, it's not in a correct location and will return false
        foreach(float rot in correctRotations)
        {
            if (rotations[curRot] == rot)
            {
                return true;
            }
        }
        return false;        
    }

    //RotationCheck uses IsCorrectRotation to see if we're in an accepted position
    //Game Manager then checks if we've rotated all of the pipes into position
    private void RotationCheck()
    {
        isPlaced = IsCorrectRotation();
        gameManager.CheckIfComplete();
    }
}
