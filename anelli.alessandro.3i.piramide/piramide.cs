
namespace Piramide
{
    public static class Piramide
    {

        public static int Piani(int mattoni)
        {

            int supp = 0;
            int piani = 0;
            int rimanenti = mattoni;
            int xandy = 1;

            if (mattoni <= 0)
            {
                return 0;
            }

            while (supp == 0)
            {
                if (rimanenti >= xandy * xandy)
                {
                    piani++;
                    rimanenti = rimanenti - (xandy * xandy);
                    xandy = xandy + 2;
                }
                else
                {
                    supp = 1;
                }
            }
            return piani;

        }
        public static int Rimanenti(int mattoni)
        {

            int supp = 0;
            int piani = 0;
            int rimanenti = mattoni;
            int xandy = 1;

            if (mattoni <= 0)
            {
                return 0;
            }

            while (supp == 0)
            {
                if (rimanenti >= xandy * xandy)
                {
                    piani++;
                    rimanenti = rimanenti - (xandy * xandy);
                    xandy = xandy + 2;
                }
                else
                {
                    supp = 1;
                }
            }
            return rimanenti;


        }

    }
}