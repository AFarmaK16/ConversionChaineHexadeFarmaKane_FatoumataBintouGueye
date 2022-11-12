using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
Console.WriteLine("Entrer le nbre:");
int nbre = Convert.ToInt32(Console.ReadLine());

int quotient= (int)(nbre);
int reste = 0;
var chaine = new StringBuilder() ;
while (quotient > 0)
{ 
    reste = quotient % 16;
    switch (reste)
    {

      case 10: chaine.Insert(0,"A");
            break;
      case 11: chaine.Insert(0,"B");
            break;
     case 12: chaine.Insert(0,"C");
            break;
     case 13: chaine.Insert(0,"D");
            break;
     case 14: chaine.Insert(0,"E");
            break;
     case 15: chaine.Insert(0,"F");
            break;
       default:
            chaine.Insert(0, reste);
            break;
    }
    quotient /= 16;

}
Console.WriteLine(chaine);
