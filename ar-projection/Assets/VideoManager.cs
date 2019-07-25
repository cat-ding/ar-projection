using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VideoManager : MonoBehaviour
{
    //TARGET 1
    public GameObject pos_one; //target 1, pos 1 *****
    public GameObject pos_two; //target 1, pos 2 
    public GameObject neg_one; //target 1, neg 1 *****
    public GameObject neg_two; //target 1, neg 2

    //TARGET 2
    public GameObject pos_three; //target 2, pos 1
    public GameObject pos_four; //target 2, pos 2 *****
    public GameObject neg_three; //target 2, neg 1
    public GameObject neg_four; //target 2, neg 2 *****

    int prev_rand_one;
    int prev_rand_two;
    int rand_one;
    int rand_two;

    int rand_pos;
    int rand_neg;

    bool pos_button_pressed;
    bool neg_button_pressed;

    //is called when positive button is pressed
    public void showPositive()
    {
        neg_button_pressed = false;

        //need to account for if a rando comb satisfies this and when pos is pressed turns it off
        if (((pos_one.activeSelf && pos_four.activeSelf) || (pos_two.activeSelf && pos_three.activeSelf))
            && (pos_button_pressed == true))
        { 
            pos_one.SetActive(false);
            pos_two.SetActive(false);
            pos_three.SetActive(false);
            pos_four.SetActive(false);
            return;
        }

        rand_pos = (int)Random.Range(1, 3);

        if (rand_pos == 1)
        {
            pos_one.SetActive(true);
            pos_four.SetActive(true);
            pos_two.SetActive(false);
            pos_three.SetActive(false);
            neg_one.SetActive(false);
            neg_four.SetActive(false);
            neg_two.SetActive(false);
            neg_three.SetActive(false);
        }
        else if (rand_pos == 2)
        {
            pos_two.SetActive(true);
            pos_three.SetActive(true);
            pos_one.SetActive(false);
            pos_four.SetActive(false);
            neg_two.SetActive(false);
            neg_three.SetActive(false);
            pos_one.SetActive(false);
            pos_four.SetActive(false);
        }

        pos_button_pressed = true;
    }

    //is called when negative button is pressed
    public void showNegative()
    {
        pos_button_pressed = false;

        if (((neg_one.activeSelf && neg_four.activeSelf) || (neg_two.activeSelf && neg_three.activeSelf))
            && (neg_button_pressed == true))
        {
            neg_one.SetActive(false);
            neg_two.SetActive(false);
            neg_three.SetActive(false);
            neg_four.SetActive(false);
            return;
        }

        rand_neg = (int)Random.Range(1, 3);

        if (rand_neg == 1)
        {
            neg_one.SetActive(true);
            neg_four.SetActive(true);
            neg_two.SetActive(false);
            neg_three.SetActive(false);
            pos_one.SetActive(false);
            pos_four.SetActive(false);
            pos_two.SetActive(false);
            pos_three.SetActive(false);
        }
        else if (rand_neg == 2)
        {
            neg_two.SetActive(true);
            neg_three.SetActive(true);
            neg_one.SetActive(false);
            neg_four.SetActive(false);
            pos_two.SetActive(false);
            pos_three.SetActive(false);
            pos_one.SetActive(false);
            pos_four.SetActive(false);
        }

        neg_button_pressed = true;
    }

    //is called when random button is pressed
    public void generateRandom()
    {
        pos_button_pressed = false;
        neg_button_pressed = false;

        rand_one = (int)Random.Range(1, 5);
        rand_two = (int)Random.Range(1, 5);

        while (rand_two == rand_one)
        {
            rand_two = (int)Random.Range(1, 4);
        }

        while (rand_one == prev_rand_one && rand_two == prev_rand_two)
        {
            rand_one = (int)Random.Range(1, 4);
            rand_two = (int)Random.Range(1, 4);

            while (rand_two == rand_one)
            {
                rand_two = (int)Random.Range(1, 4);
            }
        }

        prev_rand_one = rand_one;
        prev_rand_two = rand_two;

        //FOR FIRST TARGET
        if (rand_one == 1)
        {
            pos_one.SetActive(true);
            pos_two.SetActive(false);
            neg_one.SetActive(false);
            neg_two.SetActive(false);
        }
        else if (rand_one == 2)
        {
            pos_one.SetActive(false);
            pos_two.SetActive(true);
            neg_one.SetActive(false);
            neg_two.SetActive(false);
        }
        else if (rand_one == 3)
        {
            pos_one.SetActive(false);
            pos_two.SetActive(false);
            neg_one.SetActive(true);
            neg_two.SetActive(false);
        }
        else if (rand_one == 4)
        {
            pos_one.SetActive(false);
            pos_two.SetActive(false);
            neg_one.SetActive(false);
            neg_two.SetActive(true);
        }

        //FOR SECOND TARGET
        if (rand_two == 1)
        {
            pos_three.SetActive(true);
            pos_four.SetActive(false);
            neg_three.SetActive(false);
            neg_four.SetActive(false);
        }
        else if (rand_two == 2)
        {
            pos_three.SetActive(false);
            pos_four.SetActive(true);
            neg_three.SetActive(false);
            neg_four.SetActive(false);
        }
        else if (rand_two == 3)
        {
            pos_three.SetActive(false);
            pos_four.SetActive(false);
            neg_three.SetActive(true);
            neg_four.SetActive(false);
        }
        else if (rand_two == 4)
        {
            pos_three.SetActive(false);
            pos_four.SetActive(false);
            neg_three.SetActive(false);
            neg_four.SetActive(true);
        }
    }
}