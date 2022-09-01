namespace SearchFoodForPet.Factory
{
    public class RecommendationCore
    {

        public int RecommendFood(double[] newPet, double[][] trainingData, int numClasses, int k)
        {
            //Compute and store distances from the new pet to all pets store in train data 
            int n = trainingData.Length;
            IndexAndDistance[] indexAndDistances = new IndexAndDistance[n];
            for (int i = 0; i < n; ++i)
            {
                IndexAndDistance curr = new IndexAndDistance();
                double dist = Distance(newPet, trainingData[i]);
                curr.Idx = i;
                curr.Distance = dist;
                indexAndDistances[i] = curr;
            }

            Array.Sort(indexAndDistances);  // sort by distance
            Console.WriteLine("\nNearest  /  Distance  / Food");
            Console.WriteLine("==============================");
            for (int i = 0; i < k; ++i)
            {
                int c = (int)trainingData[indexAndDistances[i].Idx][2];
                string dist = indexAndDistances[i].Distance.ToString("F3");
                Console.WriteLine("( " + trainingData[indexAndDistances[i].Idx][0] + "," + trainingData[indexAndDistances[i].Idx][1] + " )  :  " + dist + "        " + c);
            }

            int result = Vote(indexAndDistances, trainingData, numClasses, k);  // k nearest classes
            return result;

        }
        public double Distance(double[] newPet, double[] data)
        {
            double sum = 0.0;
            for (int i = 0; i < newPet.Length; ++i)
                sum += (newPet[i] - data[i]) * (newPet[i] - data[i]);
            return Math.Sqrt(sum);
        }

        public int Vote(IndexAndDistance[] info, double[][] trainData, int numClasses, int k)
        {
            int[] votes = new int[numClasses];
            for (int i = 0; i < k; ++i)
            {
                int idx = info[i].Idx;
                int c = (int)trainData[idx][2];
                ++votes[c];
            }

            int mostVotes = 0;
            int classWithMostVotes = 0;
            for (int j = 0; j < numClasses; ++j)
            {
                if (votes[j] > mostVotes)
                {
                    mostVotes = votes[j];
                    classWithMostVotes = j;
                }
            }

            return classWithMostVotes;
        }

    }
}
