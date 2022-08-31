namespace SearchFoodForPet.Factory
{
    public class IndexAndDistance : IComparable
    {
        public int Idx;  // index of a training item

        public double Distance;  // distance from train item to unknown

        public IndexAndDistance(int index, double distance)
        {
            Idx = index;
            Distance = distance;
        }
        public IndexAndDistance()
        { }

        public int CompareTo(object? obj)
        {
            var indexAndDistance = obj as IndexAndDistance;
            if (indexAndDistance != null && Distance < indexAndDistance.Distance) return -1;
            if (indexAndDistance != null && Distance > indexAndDistance.Distance) return +1;
            return 0;
        }
    }
}
