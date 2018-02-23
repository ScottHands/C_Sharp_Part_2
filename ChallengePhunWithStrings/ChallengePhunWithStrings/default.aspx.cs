﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                // 1.  Reverse your Name
                string name = "Scott Hands";
                string reversedName = " ";

                for (int i = name.Length - 1; i >= 0; i--)
                {
                    reversedName = reversedName + name[i];
                }
                resultLabel1.Text = reversedName;

            

               // 2.  Reverse this sequence:
               string names = "Luke,Leia,Han,Chewbacca";
                 // result:  Chewbacca,Han,Leia,Luke
                 string[] reversedNames = names.Split(',');
                 string result = " ";

                  for (int i = reversedNames.Length - 1; i >= 0; i--)
                  {
                     result += reversedNames[i] + ","; 
                  }
                  result = result.Remove(result.Length - 1);
                  resultLabel2.Text = result; 
            


            // 3.  Use the sequence to create ascii art: use padding left and right
            // *****Luke*****
            // *****Leia*****
            // *****Han******
            // **Chewbacca***
           // string names = "Luke,Leia,Han,Chewbacca";
            string[] reversedNames2 = names.Split(',');
               string result2 = "";
               for (int i = 0; i < reversedNames2.Length; i++)
               {
                   int padLeft = (14 - reversedNames2[i].Length) / 2;
                   string temp = reversedNames2[i].PadLeft(reversedNames2[i].Length + padLeft, '*');
                   result2 += temp.PadRight(14, '*');
                   result2 += "<br />";
               }
               resultLabel3.Text = result2; 



            // 4.  Solve the puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");


            resultLabel4.Text = puzzle;
        }
    }
}