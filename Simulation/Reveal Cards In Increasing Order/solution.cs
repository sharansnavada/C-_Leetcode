public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        int[] retArr = new int[deck.Length];
        deck.Sort();
        int deckIndex = 0;
        int counter = 0;
        int oddDeckIndex = 0;

        for(int i = 0; i < deck.Length; i = i + 2){
            retArr[i] = deck[deckIndex++];
            oddDeckIndex = i - 1;
            counter++;
        }
        
        
        bool skip = true;

        while(counter != deck.Length){
            oddDeckIndex = GetNewIndex(oddDeckIndex, deck.Length, retArr);
            if(!skip){
                retArr[oddDeckIndex] = deck[deckIndex++];
                counter++;
            }
            skip = !skip;
        }
        return retArr;
    }

    int GetNewIndex(int i, int length, int[] retArr){
        
        do{
            if(i + 2 < length) i = i + 2;
            else i = 1;
        } while(retArr[i] != 0);

        return i;
    }
}
