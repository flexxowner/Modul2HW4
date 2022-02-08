public class LengthComparer : IComparer<Plant>
{
    public int Compare(Plant? p1, Plant? p2)
    {
        if (p1?.Length > p2?.Length)
        {
            return 1;
        }
        else if (p1?.Length < p2?.Length)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}