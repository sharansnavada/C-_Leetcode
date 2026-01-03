public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        string startsWithBlack = "aceg";

        string coOrdinate1Column = coordinate1[0].ToString();
        string coOrdinate2Column = coordinate2[0].ToString();

        int coOrdinate1Row = int.Parse(coordinate1[1].ToString());
        int coOrdinate2Row = int.Parse(coordinate2[1].ToString());

        string coOrdinate1Color = "white";
        string coOrdiante2Color = "white";

        if(startsWithBlack.Contains(coOrdinate1Column))
            coOrdinate1Color = "black";
        if(startsWithBlack.Contains(coOrdinate2Column))
            coOrdiante2Color = "black";

        while(coOrdinate1Row != 0){
            if(coOrdinate1Color == "black")
                coOrdinate1Color = "white";
            else
                coOrdinate1Color = "black";
            coOrdinate1Row--;
        }

        while(coOrdinate2Row != 0){
            if(coOrdiante2Color == "black")
                coOrdiante2Color = "white";
            else
                coOrdiante2Color = "black";
            coOrdinate2Row--;
        }

        return coOrdinate1Color == coOrdiante2Color;
    }
}
