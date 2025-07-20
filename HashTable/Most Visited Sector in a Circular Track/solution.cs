public class Solution {
    public IList<int> MostVisited(int n, int[] rounds) {
        int[] sector = new int[n]; //hashtable
        int itr = rounds[0];
        int max = 0;
        sector[rounds[0] - 1]++; // as start sector will be only taken into account when we start the race

        for(int i = 1; i < rounds.Length; i++){
            int currentSector = rounds[i];

            while (itr != currentSector)
            {
                if (itr == sector.Length)
                    itr = 0;
                sector[itr]++; //hashtable
                if (sector[itr] > max)
                    max = sector[itr];
                itr++;
            }
        }

        List<int> retList = new List<int>();
        for(int i = 0; i < sector.Length; i++){
            if(sector[i] == max)
                retList.Add(i + 1);
        }
        return retList;
    }
}
