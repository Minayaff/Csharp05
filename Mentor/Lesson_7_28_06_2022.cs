        public static int LengthOfLastWord(string s)
        {
            // https://leetcode.com/problems/length-of-last-word/
            //"                           fly me   to   the moon  "
            s = s.Trim(); //Əvvəldəki və sondakı boşluqları kesirik
            //"fly me   to   the moon"
            string[] words = s.Split(' '); // {"fly",....,"moon"}
            int index = words.Length - 1;//sonuncu sözün indexi => Last index => "moon"
            int length = words[index].Length; // həmin sözün uzunluğu "moon".length
            return length;

        }
        #region IsPalidrom

        public bool IsPalindrome(int x)
        {

            // https://leetcode.com/problems/palindrome-number/submissions/
            // 123
            bool resault = false; // neticəticəni qeyd edirəm
            string strNum = x.ToString(); //"121" string type cevirirəm = > stringin methodlarından istifadəsinə görə
            string revStr = ReverseString(strNum); // "321"
                                                   //"121" == "321"
            if (strNum == revStr)
            {
                resault = true;
            }
            return resault;
        }

        public static string ReverseString(string s)
        {
            // Char[] chars = s.ToCharArray();
            // chars.Reverse();
            // return new string(chars.ToArray());
            return new string(s.ToCharArray().Reverse().ToArray());
        }


        #endregion
