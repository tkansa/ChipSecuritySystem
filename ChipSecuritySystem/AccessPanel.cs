using System.Collections.Generic;

namespace ChipSecuritySystem
{
    public class AccessPanel
    {
        // Well this was humbling LOL!
        // Researching this problem I came across articles about Graph Theory
        // and recursively transversing nodes. Stuff that's way beyond the scope
        // of bootcamp. I did take a CS101 class once for fun and implemented
        // a bubble sort in C. But that's about it!
        // I could spend a day or two researching. But that seems outside the
        // suggested 90 minutes for the challenge. So I opted for suboptimal brute force :)
        // which won't always return the longest combo, and might not always
        // find a viable solution b/c it just loops thru in order
        // if this were real code I'd definitely want to keep working on this!
        public static string OpenSesame(List<ColorChip> chps)
        {
            string message = Constants.ErrorMessage;

            int count = chps.Count;

            // start out looking for a match for blue
            Color colorToMatch = Color.Blue;

            List<ColorChip> solution = new List<ColorChip>();

            while (count > 0)
            {
                for (int i = 0; i < chps.Count; i++)
                {
                    if (chps[i].StartColor == colorToMatch && chps[i].EndColor == Color.Green)
                    {
                        solution.Add(chps[i]);
                        message = "";
                        foreach(ColorChip chip in solution)
                        {
                            message += "[" + chip.ToString() + "]";
                        }

                    }

                    if (chps[i].StartColor == colorToMatch)
                    {
                        colorToMatch = chps[i].EndColor;
                        solution.Add(chps[i]);
                        chps.RemoveAt(i);
                    }
                }

                count--;
            }

            return message;
        }
    }
}

