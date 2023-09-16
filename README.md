# Piramide

Esercizio che calcola quanti piani di una piramide si possono costruire dato un numero finito di blocchi, il programma calcola anche il numero di blocchi rimanenti in caso non siano sufficenti per creare il piano successivo.

Dopo aver effeturo il controllo che i mattoni a disposizione non siano negativi o uguali a zero e avere dichiarato le variabili:

~~~c#
int supp = 0;
int piani = 0;
int rimanenti = mattoni;
int xandy = 1;

if (mattoni <= 0)
{
  return 0;
}
~~~

Il programma entra in un ciclo while dove grazie a un if annidato se possiede il numero di blocchi necessario aumenta il conto dei piani creabili di uno.
Se finisce i blocchi o se non ne ha abbastanza per creare il prossimo piano esce dal ciclo e ritorna il conteggio dei piani o quello dei blocchi rimanenti.

## Ciclo principale

~~~c#
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
~~~
