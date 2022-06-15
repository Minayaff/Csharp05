internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Proqramalaşdırma nə qədər çox şey bildiyinizlə yox," +
                " bildiyinizlə ortaya çıxardığınız işlərlə maraqlanır";


            //CountCharacther1(str);
            //CountCharacther2(str);

            // CountWord(str);
            // CountHerf(str);

            //CountHerf1(str);

            //LastTwoWordDelete(str);

            //var arr = str.Split(' ');

            //string[] arrString = str.Split(' '); 

            // LastTwoWordDelete(str);


        }

        #region String Search Task 5
        public static void StringSearch(string str,string searchWord)
        {
            bool isContain = str.Contains(searchWord);
            if (isContain)
            {
                Console.WriteLine("Daxildir");
            }
            else
            {
                Console.WriteLine("Daxil Deyil");
            }
           
        }
        #endregion

        #region Last Two Word Remomve Task 4
        public static void LastTwoWordDelete(string str)
        {
            if (LastFindWordSrtartIndex(str) == -1)
            {

                Console.WriteLine("ERROR");
            }
            else
            {
                int startIndex = LastFindWordSrtartIndex(str);
                Console.WriteLine(str.Substring(startIndex));
            }
        }

        public static int LastFindWordSrtartIndex(string str)
        {
            int count = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    count++;
                    if (count == 2)
                    {
                        return i + 1;
                    }

                }
            }
            return -1;
        }
        #endregion

        #region Covert Word Array Task 3 
        public static string[] CovertWordArray(string str)
        {
            return str.Split(' ');
        }
        #endregion

        #region Count Letter Task 2
        public static void CountHerf(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            int charactherCount = CountCharacther2(str);
            Console.WriteLine(charactherCount - (count + 1));

        }
        public static void CountHerf1(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (Char.IsLetter(item))
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }

        #endregion

        #region Count Sinvol  Task 1

        public static void CountCharacther1(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                count++;
            }

            Console.WriteLine(count);
        }


        public static int CountCharacther2(string str)
        {
           return str.Length;
        }
        #endregion
        // Əlavə Olaraq  
        public static void CountWord(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            count++;
            Console.WriteLine(count);
        }


    }
