public partial class CapsStatScr
{
    class Caps1Evol {
        public int CapsToEvolution;
        public int MoneyToEvolution;
        public int ExpForEvolution;
        public int ChanceOfSuccess;

        public void Common() {
            CapsToEvolution = 20;
            MoneyToEvolution = 300;
            ExpForEvolution = 500;
            ChanceOfSuccess = 30;
        }
        public void Rare()
        {
            CapsToEvolution = 10;
            MoneyToEvolution = 400;
            ExpForEvolution = 1000;
            ChanceOfSuccess = 40;
        }
        public void Epic()
        {
            CapsToEvolution = 6;
            MoneyToEvolution = 600;
            ExpForEvolution = 3000;
            ChanceOfSuccess = 50;
        }
        public void Legend()
        {
            CapsToEvolution = 2;
            MoneyToEvolution = 1000;
            ExpForEvolution = 6000;
            ChanceOfSuccess = 60;
        }

        }

    class Caps2Evol
    {
        public int CapsToEvolution;
        public int MoneyToEvolution;
        public int ExpForEvolution;
        public int ChanceOfSuccess;

        public void Common()
        {
            CapsToEvolution = 40;
            MoneyToEvolution = 600;
            ExpForEvolution = 700;
            ChanceOfSuccess = 35;
        }
        public void Rare()
        {
            CapsToEvolution = 20;
            MoneyToEvolution = 800;
            ExpForEvolution = 1500;
            ChanceOfSuccess = 45;
        }
        public void Epic()
        {
            CapsToEvolution = 12;
            MoneyToEvolution = 1200;
            ExpForEvolution = 5000;
            ChanceOfSuccess = 55;
        }
        public void Legend()
        {
            CapsToEvolution = 4;
            MoneyToEvolution = 2000;
            ExpForEvolution = 9000;
            ChanceOfSuccess = 65;
        }
    }

    class Caps3Evol
    {
        public int CapsToEvolution;
        public int MoneyToEvolution;
        public int ExpForEvolution;
        public int ChanceOfSuccess;

        public void Common()
        {
            CapsToEvolution = 0;
            MoneyToEvolution = 0;
            ExpForEvolution = 0;
            ChanceOfSuccess = 40;
        }
        public void Rare()
        {
            CapsToEvolution = 0;
            MoneyToEvolution = 0;
            ExpForEvolution = 0;
            ChanceOfSuccess = 50;
        }
        public void Epic()
        {
            CapsToEvolution = 40;
            MoneyToEvolution = 600;
            ExpForEvolution = 700;
            ChanceOfSuccess = 60;
        }
        public void Legend()
        {
            CapsToEvolution = 0;
            MoneyToEvolution = 0;
            ExpForEvolution = 0;
            ChanceOfSuccess = 70;
        }
    }


    public enum RARITY
    {
        Common = 0,
        Rare = 1,
        Epic = 2,
        Legend = 3
    };

    public enum Evolution
    {
        First = 0,
        Second = 1,
        Third = 2
    };
}
