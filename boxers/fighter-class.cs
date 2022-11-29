class Fighter
{
    public string firstName;
    public string lastName;
    public int weight;
    public string nickname;
    public int wins;
    public int losses;
    public int draws;
    public bool champion;
    public string belts;
    public bool p4p;
    public string p4pRank;
    public string ibfRank;
    public string wboRank;
    public string wbaRank;
    public string iboRank;
    public string wbcRank;
    public string promotion;

    //Fighter Constructor
    public Fighter(
                   string fighterFirstName,
                   string fighterLastName,
                   int fighterWeight,
                   string fighterNickName,
                   int fighterWins,
                   int fighterLosses,
                   int fighterDraws,
                   bool fighterIsChampion,
                   string fighterBelts,
                   bool fighterP4p,
                   string  fighterP4pRank,
                   string fighterIbfRank,
                   string fighterWboRank,
                   string fighterWbaRank,
                   string fighterIboRank,
                   string fighterWbcRank,
                   string fighterPromo
                   )
    {
        firstName = fighterFirstName;
        lastName = fighterLastName;
        weight = fighterWeight;
        nickname = fighterNickName;
        wins = fighterWins;
        losses = fighterLosses;
        draws = fighterDraws;
        champion = fighterIsChampion;
        belts = fighterBelts;
        p4p = fighterP4p;
        p4pRank = fighterP4pRank;
        ibfRank = fighterIbfRank;
        wboRank = fighterWboRank;
        wbaRank = fighterWbaRank;
        iboRank = fighterIboRank;
        wbcRank = fighterWbcRank;
        promotion = fighterPromo;
    }
}