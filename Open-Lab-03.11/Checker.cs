using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string stp = "";

            for (int i = str.Length-1; i > -1; i--)
			{
                stp += str[1];
			}
            if(stp==str){

                return true;
            
            }
            else{

                return false;
            
            }
        } 
    }
}
